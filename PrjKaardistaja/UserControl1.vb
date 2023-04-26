Imports GMap.NET
Imports GMap.NET.WindowsForms
Public Class UserControl1
    Private Sub GMapControl1_Load(sender As Object, e As EventArgs) Handles GMapControl1.Load
        GMapControl1.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance
        GMapControl1.Position = New GMap.NET.PointLatLng(59.437, 24.7536)
        GMapControl1.MinZoom = 1
        GMapControl1.MaxZoom = 18
        GMapControl1.Zoom = 13
        GMapControl1.Manager.Mode = GMap.NET.AccessMode.ServerAndCache
        GMapControl1.CanDragMap = True
        GMapControl1.DragButton = MouseButtons.Left



    End Sub

    Public Sub margiKoikPeatused()
        Dim andmebaas As PrjAndmebaasKomponent.ISaaAndmed
        andmebaas = New PrjAndmebaasKomponent.CSaaAndmed(Application.StartupPath)

        Dim peatusteList As List(Of String)
        peatusteList = andmebaas.saaKoikPeatuseNimed

        Dim markerOverlay As New GMapOverlay("markers")
        GMapControl1.Overlays.Add(markerOverlay)

        For Each peatus As String In peatusteList
            Dim koordinaadid As Double() = andmebaas.saaPeatuseAsukoht(peatus)
            Dim marker As New GMap.NET.WindowsForms.Markers.GMarkerGoogle(New PointLatLng(koordinaadid(0), koordinaadid(1)), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.green)
            marker.ToolTipText = peatus
            Dim size As New Size(16, 16)
            marker.Size = size

            markerOverlay.Markers.Add(marker)

        Next
    End Sub

    Public Sub margiKoikVaatamisvaarsused()
        Dim andmebaas As PrjAndmebaasKomponent.ISaaAndmed
        andmebaas = New PrjAndmebaasKomponent.CSaaAndmed(Application.StartupPath)

        Dim vaatamisvaarsusedList As List(Of String)
        vaatamisvaarsusedList = andmebaas.saaKoikVaatamisvaarsuseNimed

        Dim markerOverlay As New GMapOverlay("markers")
        GMapControl1.Overlays.Add(markerOverlay)

        For Each koht As String In vaatamisvaarsusedList
            Dim koordinaadid As Double() = andmebaas.saaVaatamisvaarsuseAsukoht(koht)
            Dim marker As New GMap.NET.WindowsForms.Markers.GMarkerGoogle(New PointLatLng(koordinaadid(0), koordinaadid(1)), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue)
            marker.ToolTipText = koht
            Dim size As New Size(16, 16)
            marker.Size = size

            markerOverlay.Markers.Add(marker)

        Next
    End Sub

    Public Sub margiSoidukiAsukoht(liin As String)
        Dim baasHankimine As PrjAndmebaasKomponent.ISaaAndmed
        baasHankimine = New PrjAndmebaasKomponent.CSaaAndmed(Application.StartupPath)

        Dim baasUuendamine As PrjAndmebaasKomponent.IUuendaAndmed
        baasUuendamine = New PrjAndmebaasKomponent.CUuuendaAndmed(Application.StartupPath)

        baasUuendamine.uuendaSoidukiAsukoht(liin)

        Dim koordinaadidList As List(Of Double()) = baasHankimine.saaSoidukiAsukoht(liin)

        Dim markerOverlay As New GMapOverlay("markers")
        GMapControl1.Overlays.Clear()
        
        GMapControl1.Overlays.Add(markerOverlay)

        For Each koordinaadid In koordinaadidList
            Dim marker As New GMap.NET.WindowsForms.Markers.GMarkerGoogle(New PointLatLng(koordinaadid(1), koordinaadid(0)), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red)
            marker.ToolTipText = liin
            Dim size As New Size(16, 16)
            marker.Size = size

            markerOverlay.Markers.Add(marker)
        Next


    End Sub

    Private Sub GMapControl1_OnMarkerDoubleClick(item As GMapMarker, e As MouseEventArgs) Handles GMapControl1.OnMarkerDoubleClick
        Dim message As String = "Klikkisid just selle peatuse peale: " & item.ToolTipText
        MsgBox(message)

    End Sub
End Class
