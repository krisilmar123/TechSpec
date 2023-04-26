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
        ' Laeb internetist alla gps.txt
        Dim destinationPath As String = applicationStartUpPath & "\" & "gps.txt"
        My.Computer.Network.DownloadFile("https://transport.tallinn.ee/gps.txt", destinationPath, userName:=String.Empty, password:=String.Empty, showUI:=False, connectionTimeout:=10000, overwrite:=True)

        Dim fileReader As System.IO.StreamReader

        fileReader = My.Computer.FileSystem.OpenTextFileReader(destinationPath)

        Dim currrentLine As String = ""


        While fileReader.EndOfStream = False
            currrentLine = fileReader.ReadLine()
            Dim lineArray As String() = Split(currrentLine, ",")

            If lineArray(1) = liin Then
                Dim lon As Double = lineArray(2) / 1000000
                Dim lat As Double = lineArray(3) / 1000000

                connection.Open()
                command.Connection = connection
                command.CommandText = "UPDATE GPS SET long = '" & lon & "', lat = '" & lat & "' WHERE route_short_name = '" & liin & "' AND id = '" & lineArray(6) & "';"

                Dim affectedRows As Integer = 0

                affectedRows = command.ExecuteNonQuery()

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
