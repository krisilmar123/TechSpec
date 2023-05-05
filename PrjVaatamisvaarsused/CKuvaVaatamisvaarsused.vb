


Imports System.Data.SQLite


Public Class CKuvaVaatamisvaarsused : Implements ISaaAndmed
    Private dbName As String = "TranspordiAndmed.db"

    ' Muutuja mõeldud andmebaasi faili asukoha hoidmiseks, saab väärtuse konstruktoris
    Public Property dbPath As String = ""

    ' Muutuja mõeldud andmebaasiga ühenduse loova stringi hoidmiseks
    Private connString As String = ""

    ' Ühenduse muutuja
    Private connection As SQLiteConnection
    ' SQL käsu muutuja
    Private command As SQLiteCommand


    ' Konstruktor, võtab argumendiks kausta, kus andmebaasi fail sees on
    Public Sub New(Path As String)
        dbPath = Path & "\" & dbName
        connString = "Data Source=" & dbPath & ";Version=3"
        connection = New SQLiteConnection(connString)
        command = New SQLiteCommand("", connection)
    End Sub
    Public Function saaKoikVaatamisvaarsuseNimed() As List(Of String) Implements ISaaAndmed.saaKoikVaatamisvaarsuseNimed
        connection.Open()

        If connection.State = ConnectionState.Open Then
            command.Connection = connection
            command.CommandText = "SELECT DISTINCT name FROM Vaatamisvaarsus;"
            Dim rdr As SQLiteDataReader = command.ExecuteReader

            Dim vaatamisvaarsusteList As New List(Of String)
            Using rdr
                While (rdr.Read())
                    vaatamisvaarsusteList.Add(rdr.GetValue(0))
                End While
            End Using
            connection.Close()
            Return vaatamisvaarsusteList
        End If

        connection.Close()
    End Function

    Public Function saaVaatamisvaarsuseAsukoht(vaarsusNimi As String) As Double() Implements ISaaAndmed.saaVaatamisvaarsuseAsukoht
        connection.Open()

        If connection.State = ConnectionState.Open Then
            command.Connection = connection
            command.CommandText = "SELECT latitude, longitude FROM Vaatamisvaarsus WHERE name='" & vaarsusNimi & "';"
            Dim rdr As SQLiteDataReader = command.ExecuteReader

            Dim lat As Double
            Dim lon As Double
            Using rdr
                While (rdr.Read())
                    lat = Convert.ToDouble(rdr.GetValue(0))
                    lon = Convert.ToDouble(rdr.GetValue(1))
                End While
            End Using
            Dim koordinaadid = New Double() {lat, lon}
            connection.Close()
            Return koordinaadid
        End If
        connection.Close()
    End Function


End Class
