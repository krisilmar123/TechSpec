' Koodi baas on võetud järgnevast Youtube video'st: https://www.youtube.com/watch?v=9PrPx83L2hY. 
' Looja: PSDen

Imports System.Data.SQLite

Public Class CSaaAndmed
    Implements ISaaAndmed

    ' Andmebaasi faili nimi 
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

    Public Function saaPeatuseAsukoht(peatuseNimi As String) As Double() Implements ISaaAndmed.saaPeatuseAsukoht
        ' Loob ühenduse andmebaasiga
        connection.Open()

        ' Kontrollib kas ühendus õnnestus
        If connection.State = ConnectionState.Open Then
            command.Connection = connection
            ' Kirjutab SQL lause, millega andmeid andmebaasist hankida
            ' Selle puhul saab peatuse koordinaadid nendelt ridadelt, kus peatuse nimi on sama, mis antud
            command.CommandText = "SELECT stop_lat, stop_lon FROM Stop WHERE stop_name='" & peatuseNimi & "';"
            ' Lause pannakse käima ning hakkab lugema Reader ehk lugeja
            Dim rdr As SQLiteDataReader = command.ExecuteReader

            Dim lat As Double
            Dim lon As Double

            ' Võtab lugejalt andmeid
            Using rdr
                While (rdr.Read())
                    lat = Convert.ToDouble(rdr.GetValue(0))
                    lon = Convert.ToDouble(rdr.GetValue(1))
                End While
            End Using
            ' Salvestab latitute ja longitude koordinaadid array'sse
            Dim koordinaadid = New Double() {lat, lon}
            connection.Close()
            Return koordinaadid
        End If

        connection.Close()
    End Function

    Function saaValjumised(peatuseNimi As String, liiniNimi As String, paev As String, limiit As String, madalSisenemine As Boolean) As List(Of String()) Implements ISaaAndmed.saaValjumised
        connection.Open()

        paev = paev.ToLower


        If connection.State = ConnectionState.Open Then
            command.Connection = connection

            If madalSisenemine Then
                command.CommandText = "SELECT DISTINCT Route.route_short_name, Stop_time.departure_time FROM Stop_time INNER JOIN Stop ON Stop_time.stop_id = Stop.stop_id INNER JOIN Trip ON Stop_time.trip_id = Trip.trip_id INNER JOIN Route ON Trip.route_id = Route.route_id INNER JOIN Calendar ON Trip.service_id = Calendar.service_id WHERE Stop.stop_name= '" & peatuseNimi & "' AND time(Stop_time.departure_time) >= TIME('" & DateTime.Now.TimeOfDay.ToString & "') AND Route.route_short_name = '" & liiniNimi & "' AND Calendar." & paev & " = '1' AND Trip.wheelchair_accesible = '1' ORDER BY time(Stop_time.departure_time) LIMIT " & limiit & ";"

            Else
                command.CommandText = "SELECT DISTINCT Route.route_short_name, Stop_time.departure_time FROM Stop_time INNER JOIN Stop ON Stop_time.stop_id = Stop.stop_id INNER JOIN Trip ON Stop_time.trip_id = Trip.trip_id INNER JOIN Route ON Trip.route_id = Route.route_id INNER JOIN Calendar ON Trip.service_id = Calendar.service_id WHERE Stop.stop_name= '" & peatuseNimi & "' AND time(Stop_time.departure_time) >= TIME('" & DateTime.Now.TimeOfDay.ToString & "') AND Route.route_short_name = '" & liiniNimi & "' AND Calendar." & paev & " = '1' ORDER BY time(Stop_time.departure_time) LIMIT " & limiit & ";"
            End If

            Dim rdr As SQLiteDataReader = command.ExecuteReader

            Dim result As New List(Of String())
            Using rdr
                While (rdr.Read())
                    Dim aeg As String = rdr.GetValue(1)
                    Dim resultArray As String() = {liiniNimi, aeg}
                    result.Add(resultArray)
                End While
            End Using
            connection.Close()
            Return result
        End If

        connection.Close()

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
JOIN Stop_time ON Stop.stop_id = Stop_time.stop_id
JOIN Trip ON Trip.trip_id = Stop_time.trip_id
JOIN Route ON Route.route_id = Trip.route_id
WHERE Route.route_short_name='" & liiniNimi & "' AND Route.route_long_name='" & liiniTeekond & "' AND Trip.direction_code='A>B' ORDER BY CAST(Stop_time.stop_sequence AS UNISGNED);"
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

    Public Function saaSoidukiAsukoht(liin As String) As List(Of Double()) Implements ISaaAndmed.saaSoidukiAsukoht
        connection.Open()

        If connection.State = ConnectionState.Open Then
            command.Connection = connection
            command.CommandText = "SELECT long, lat FROM GPS WHERE route_short_name='" & liin & "';"
            Dim rdr As SQLiteDataReader = command.ExecuteReader

            Dim lat As Double
            Dim lon As Double
            Dim list As New List(Of Double())

            Using rdr
                While (rdr.Read())
                    lon = Convert.ToDouble(rdr.GetValue(0))
                    lat = Convert.ToDouble(rdr.GetValue(1))
                    Dim koordinaadid = New Double() {lon, lat}
                    list.Add(koordinaadid)
                End While
            End Using
            connection.Close()
            Return list
        End If

        connection.Close()
    End Function
End Class
