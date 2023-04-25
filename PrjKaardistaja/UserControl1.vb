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
        ' Andmebaasi muutuja deklareerimine, selle kaudu kutsub andmebaasi komponendi funktsioone
        Dim andmebaas As PrjAndmebaasKomponent.ISaaAndmed
        andmebaas = New PrjAndmebaasKomponent.CSaaAndmed(Application.StartupPath)

        ' Peatuste nimede nimekirja deklareerimine ja väärtuse andmine vastava funktsiooni kaudu
        Dim peatusteList As List(Of String)
        peatusteList = andmebaas.saaKoikPeatuseNimed

        Dim markerOverlay As New GMapOverlay("markers")
        GMapControl1.Overlays.Add(markerOverlay)

        ' Tsükkel, mis käib kõik peatuse nimed läbi
        For Each peatus As String In peatusteList
            ' Peatuse nime järgi koordinaatide saamine Double array'na.
            ' Array esimene liige on latitude, array teine liige on longitude
            Dim koordinaadid As Double() = andmebaas.saaPeatuseAsukoht(peatus)
            ' Markeri loomine koordinaatide järgi
            Dim marker As New GMap.NET.WindowsForms.Markers.GMarkerGoogle(New PointLatLng(koordinaadid(0), koordinaadid(1)), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.green)
            ' Kui hiir läheb markeri peale, siis tuleb Tool Tip'ina tekst, mis kuvab peatuse nime
            marker.ToolTipText = peatus
            ' Muudab markeri väiksemaks
            Dim size As New Size(16, 16)
            marker.Size = size
            ' Lisab markeri kaardile
            markerOverlay.Markers.Add(marker)

        Next


    End Sub

    Public Sub margiSoidukiAsukoht(liin As String)
        ' Andmebaasi muutuja andmete hankimiseks
        Dim baasHankimine As PrjAndmebaasKomponent.ISaaAndmed
        baasHankimine = New PrjAndmebaasKomponent.CSaaAndmed(Application.StartupPath)
        ' Andmebaasi muutuja andmete uuendamiseks
        Dim baasUuendamine As PrjAndmebaasKomponent.IUuendaAndmed
        baasUuendamine = New PrjAndmebaasKomponent.CUuuendaAndmed(Application.StartupPath)

        ' Uuendab ühistranspordi sõidukite asukohta liini järgi
        baasUuendamine.uuendaSoidukiAsukoht(liin)

        ' Hangib sõidukite koordinaadid Double array List'ina
        ' Iga Double array esimene liige on longitude, teine liige on latitude
        Dim koordinaadidList As List(Of Double()) = baasHankimine.saaSoidukiAsukoht(liin)

        Dim markerOverlay As New GMapOverlay("markers")
        GMapControl1.Overlays.Clear()
        
        GMapControl1.Overlays.Add(markerOverlay)

        ' Loop kõikide sõidukite koordinaatide läbimiseks
        For Each koordinaadid In koordinaadidList
            Dim marker As New GMap.NET.WindowsForms.Markers.GMarkerGoogle(New PointLatLng(koordinaadid(1), koordinaadid(0)), WindowsForms.Markers.GMarkerGoogleType.red)

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
