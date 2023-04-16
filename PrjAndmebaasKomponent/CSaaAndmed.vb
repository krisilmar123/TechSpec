Imports System.Data.SQLite
Public Class CSaaAndmed
    Implements ISaaAndmed


    Private dbCommand = ""

    Private dbName As String = "TranspordiAndmed.db"
    Public Property dbPath As String = ""
    Private connString As String = ""

    Private connection As SQLiteConnection
    Private command As SQLiteCommand

    Public Sub New(Path As String)
        dbPath = Path & "\" & dbName
        connString = "Data Source=" & dbPath & ";Version=3"
        connection = New SQLiteConnection(connString)
        command = New SQLiteCommand("", connection)

    End Sub

    Public Function saaPeatuseAsukoht(peatuseNimi As String) As Double() Implements ISaaAndmed.saaPeatuseAsukoht
        connection.Open()

        If connection.State = ConnectionState.Open Then
            command.Connection = connection
            command.CommandText = "SELECT stop_lat, stop_lon FROM Stop WHERE stop_name='" & peatuseNimi & "';"
            Dim rdr As SQLiteDataReader = command.ExecuteReader

            Dim result As String = ""
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

    Function saaValjumised(peatuseNimi As String) As String Implements ISaaAndmed.saaValjumised
        connection.Open()

        If connection.State = ConnectionState.Open Then
            command.Connection = connection
            command.CommandText = "SELECT trip_id, departure_time FROM Stop_time INNER JOIN Stop ON Stop_time.stop_id = Stop.stop_id WHERE Stop.stop_name='" & peatuseNimi & "' ORDER BY departure_time;"
            Dim rdr As SQLiteDataReader = command.ExecuteReader

            Dim result As String = ""
            Using rdr
                While (rdr.Read())
                    result &= rdr.GetValue(0) & vbTab & rdr.GetValue(1) & vbLf
                End While
            End Using
            connection.Close()
            Return result
        End If

        connection.Close()
        Return "Failed"
    End Function

    Public Function saaLiinid() As String Implements ISaaAndmed.saaLiinid
        connection.Open()

        If connection.State = ConnectionState.Open Then
            command.Connection = connection
            command.CommandText = "SELECT route_short_name, route_long_name FROM Route;"
            Dim rdr As SQLiteDataReader = command.ExecuteReader

            Dim result As String = ""
            Using rdr
                While (rdr.Read())
                    result &= rdr.GetValue(0) & vbTab & rdr.GetValue(1) & vbLf
                End While
            End Using
            connection.Close()
            Return result
        End If

        connection.Close()
        Return "Failed"
    End Function
End Class
