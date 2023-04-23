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

    Public Function saaLiinid() As List(Of String) Implements ISaaAndmed.saaLiinid
        connection.Open()

        If connection.State = ConnectionState.Open Then
            command.Connection = connection
            command.CommandText = "SELECT route_short_name, route_long_name FROM Route;"
            Dim rdr As SQLiteDataReader = command.ExecuteReader

            Dim liinideList As New List(Of String)
            Using rdr
                While (rdr.Read())
                    liinideList.Add(rdr.GetValue(0) & " " & rdr.GetValue(1))
                End While
            End Using
            connection.Close()
            Return liinideList
        End If

        connection.Close()
    End Function

    Public Function saaKoikPeatuseNimed() As List(Of String) Implements ISaaAndmed.saaKoikPeatuseNimed
        connection.Open()

        If connection.State = ConnectionState.Open Then
            command.Connection = connection
            command.CommandText = "SELECT DISTINCT stop_name FROM Stop;"
            Dim rdr As SQLiteDataReader = command.ExecuteReader

            Dim peatusteList As New List(Of String)
            Using rdr
                While (rdr.Read())
                    peatusteList.Add(rdr.GetValue(0))
                End While
            End Using
            connection.Close()
            Return peatusteList
        End If

        connection.Close()
    End Function

    Public Function saaPeatuseNimedLiiniJargi(liiniNimi As String, liiniTeekond As String) As List(Of String) Implements ISaaAndmed.saaPeatuseNimedLiiniJargi
        connection.Open()

        If connection.State = ConnectionState.Open Then
            command.Connection = connection
            command.CommandText = "SELECT DISTINCT stop_name
FROM Stop
INNER JOIN Stop_time ON Stop.stop_id = Stop_time.stop_id
INNER JOIN Trip ON Trip.trip_id = Stop_time.trip_id
INNER JOIN Route ON Route.route_id = Trip.route_id
WHERE Route.route_short_name='" & liiniNimi & "' AND Route.route_long_name='" & liiniTeekond & "' AND Trip.direction_code='A>B';"
            Dim rdr As SQLiteDataReader = command.ExecuteReader

            Dim resultList As New List(Of String)
            Using rdr
                While (rdr.Read())
                    resultList.Add(rdr.GetValue(0))
                End While
            End Using
            connection.Close()
            Return resultList
        End If

        connection.Close()
    End Function

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
