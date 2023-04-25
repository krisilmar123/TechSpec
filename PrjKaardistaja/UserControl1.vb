Imports GMap.NET
Imports GMap.NET.WindowsForms
Imports GMap.NET.MapProviders
Public Class UserControl1

    Private andmebaas As PrjAndmebaasKomponent.ISaaAndmed
  
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
    Private Sub btnOtsiPeatused_Click(sender As Object, e As EventArgs) Handles btnOtsiPeatused.Click
        Dim algPeatus As String = TxtAlgusPeatus.Text
        Dim loppPeatus As String = txtLoppPeatus.Text

        Dim bussiPeatuseKuvamine As New GMapOverlay("bussiPeatus")
        GMapControl1.Overlays.Add(bussiPeatuseKuvamine)

        andmebaas = New PrjAndmebaasKomponent.CSaaAndmed(Application.StartupPath)

        GMapControl1.Overlays.Clear()

        Dim markeriKuvamine As New GMapOverlay("markerid")
        GMapControl1.Overlays.Add(markeriKuvamine)

        Dim koordinaadidAlgus As Double() = andmebaas.saaPeatuseAsukoht(algPeatus)
        Dim koordinaadidLopp As Double() = andmebaas.saaPeatuseAsukoht(loppPeatus)

        Dim alguseMarker As New GMap.NET.WindowsForms.Markers.GMarkerGoogle(
        New PointLatLng(koordinaadidAlgus(0), koordinaadidAlgus(1)), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.green)
        
        Dim lopuMarker As New GMap.NET.WindowsForms.Markers.GMarkerGoogle(
        New PointLatLng(koordinaadidLopp(0), koordinaadidLopp(1)), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red)

        alguseMarker.ToolTipText = algPeatus
        lopuMarker.ToolTipText = loppPeatus

        Dim size As New Size(16, 16)
        alguseMarker.Size = size
        lopuMarker.Size = size

        markeriKuvamine.Markers.Add(alguseMarker)
        markeriKuvamine.Markers.Add(lopuMarker)

        Dim alguseOma As PointLatLng = New PointLatLng(koordinaadidAlgus(0), koordinaadidAlgus(1))
        Dim lopuOma As PointLatLng = New PointLatLng(koordinaadidLopp(0), koordinaadidLopp(1))

        Dim route As MapRoute = GMap.NET.MapProviders.OpenStreetMapProvider.Instance.GetRoute(alguseOma, lopuOma, False, False, 15)

        Dim ruut As GMapRoute = New GMapRoute(route.Points, "My route")

        dim routesOverlay As GMapOverlay = New GMapOverlay("routes")
        routesOverlay.Routes.Add(ruut)
        
        GMapControl1.Overlays.Add(routesOverlay)

        ruut.Stroke.Width = 2
        ruut.Stroke.Color = Color.Red
        GMapControl1.Refresh()
    End Sub
End Class
