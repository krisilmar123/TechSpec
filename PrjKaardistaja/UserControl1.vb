Public Class UserControl1
    Private Sub GMapControl1_Load(sender As Object, e As EventArgs) Handles GMapControl1.Load
        GMapControl1.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance
        GMapControl1.Position = New GMap.NET.PointLatLng(59.4370, 24.7536)
        GMapControl1.MinZoom = 1
        GMapControl1.MaxZoom = 18
        GMapControl1.Zoom = 13
        GMapControl1.Manager.Mode = GMap.NET.AccessMode.ServerAndCache
        GMapControl1.CanDragMap = true
        GMapControl1.DragButton = MouseButtons.Left


        Dim busStopOverlay As New GMapOverlay("busStops")
        GMapControl1.Overlays.Add(busStopOverlay)
        


        Dim andmebaas As PrjAndmebaasKomponent.ISaaAndmed
        andmebaas = New PrjAndmebaasKomponent.CAndmebaasiKomponent(Application.StartupPath)

        

        GMapControl1.Overlays.Clear()

        Dim markerOverlay As New GMapOverlay("markers")
        GMapControl1.Overlays.Add(markerOverlay)


    ' Add start and end markers
        Dim startMarker As New GMap.NET.WindowsForms.Markers.GMarkerGoogle(
        New PointLatLng(andmebaas.saaPeatuseAsukohtLat(startPoint), andmebaas.saaPeatuseAsukohtLong(startPoint)),
        GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_dot)
        Dim endMarker As New GMap.NET.WindowsForms.Markers.GMarkerGoogle(
        New PointLatLng(andmebaas.saaPeatuseAsukohtLat(endPoint), andmebaas.saaPeatuseAsukohtLong(endPoint)),
        GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_dot)
        markerOverlay.Markers.Add(startMarker)
        markerOverlay.Markers.Add(endMarker)
    End Sub
End Class
