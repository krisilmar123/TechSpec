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
            markerOverlay.Markers.Add(marker)
        Next
    End Sub
End Class
