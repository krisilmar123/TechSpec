Imports System.Data.SQLite
Public Class CUuuendaAndmed
    Implements IUuendaAndmed

    Private dbCommand = ""

    Private dbName As String = "TranspordiAndmed.db"
    Public Property dbPath As String = ""
    Private connString As String = ""

    Private connection As SQLiteConnection
    Private command As SQLiteCommand

    Private applicationStartUpPath As String = ""

    Public Sub New(Path As String)
        dbPath = Path & "\" & dbName
        connString = "Data Source=" & dbPath & ";Version=3"
        connection = New SQLiteConnection(connString)
        command = New SQLiteCommand("", connection)

        applicationStartUpPath = Path
    End Sub

    Public Sub uuendaSoidukiAsukoht(liin As String) Implements IUuendaAndmed.uuendaSoidukiAsukoht
        ' Laeb internetist alla sõidukite reaalaja infot sisaldava faili nimega "gps.txt", salvestab selle rakenduse käivituskohta
        Dim destinationPath As String = applicationStartUpPath & "\" & "gps.txt"
        My.Computer.Network.DownloadFile("https://transport.tallinn.ee/gps.txt", destinationPath, userName:=String.Empty, password:=String.Empty, showUI:=False, connectionTimeout:=10000, overwrite:=True)

        ' Faili lugeja deklareerimine
        Dim fileReader As System.IO.StreamReader

        ' Avab alla laetud faili
        fileReader = My.Computer.FileSystem.OpenTextFileReader(destinationPath)

        ' Rea salvestamiseks muutuja
        Dim currrentLine As String = ""


        ' Tsükkel kestab kuni faili lõpuni on jõutud
        While fileReader.EndOfStream = False
            ' Loeb uut rida
            currrentLine = fileReader.ReadLine()
            ' Koma järgi eraldab rea stringideks ning salvestab need array'sse
            Dim lineArray As String() = Split(currrentLine, ",")

            ' Teine liige array'st on liini nr, kontrollib kas see number on sama, mis otsitud liin
            If lineArray(1) = liin Then
                ' Kuna failis on koordinaadid ilma komata, siis on vaja jagada faili arv 1000000'ga, et saada komaga arv
                Dim lon As Double = lineArray(2) / 1000000
                Dim lat As Double = lineArray(3) / 1000000

                connection.Open()
                command.Connection = connection
                ' Uuendab sõidukite asukoha infot andmebaasis faili info järgi, array kohal 6 on sõiduki id number
                command.CommandText = "UPDATE GPS SET long = '" & lon & "', lat = '" & lat & "' WHERE route_short_name = '" & liin & "' AND id = '" & lineArray(6) & "';"

                Dim affectedRows As Integer = 0

                affectedRows = command.ExecuteNonQuery()

                ' Kontrollib, kas uuendamine üldse tegi midagi. Kui ei teinud, siis lisatakse faili info andmebaasi uue reana
                If affectedRows = 0 Then
                    command.CommandText = "INSERT INTO GPS VALUES ('" & liin & "', '" & lon & "', '" & lat & "', '" & lineArray(6) & "' );"
                    command.ExecuteNonQuery()
                End If

                connection.Close()
            End If
        End While

        fileReader.Close()

    End Sub
End Class
