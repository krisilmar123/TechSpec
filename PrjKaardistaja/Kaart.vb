﻿Imports GMap.NET
Imports GMap.NET.WindowsForms
Imports GMap.NET.MapProviders
Imports Avalonia.OpenGL

Public Class Kaart : Implements IMargiKaardil : Implements IKuvaKaart
    Public Event otsiClick()

    Private andmebaas As PrjAndmebaasKomponent.ISaaAndmed

    ' Event mõeldud markeri topelt klikkimise tuvastasmieks, võtab markeri endaga kaasa 
    Public Event markerDoubleClick(item As GMapMarker)

    Public Sub kuvaKaart() Implements IKuvaKaart.kuvaKaart
        'Luuakse kaardi kiht
        GMapControl1.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance
        GMapControl1.Position = New GMap.NET.PointLatLng(59.437, 24.7536)
        GMapControl1.MinZoom = 1
        GMapControl1.MaxZoom = 18
        GMapControl1.Zoom = 13
        GMapControl1.Manager.Mode = GMap.NET.AccessMode.ServerAndCache
        GMapControl1.CanDragMap = True
        GMapControl1.DragButton = MouseButtons.Left
    End Sub

    ' Markerite loomine ja muutmine abimaterjal: http://www.independent-software.com/gmap-net-beginners-tutorial-adding-clickable-markers-to-your-map-updates-for-vs2015-and-gmap-1-7.html
    ' Looja: Independent Software
    Public Sub margiKoikPeatused() Implements IMargiKaardil.margiKoikPeatused
        ' Andmebaasi muutuja deklareerimine, selle kaudu kutsub andmebaasi komponendi funktsioone
        'Andtakse andmebaasile väärtus ja luuakse andmebaasikomponendi objekt ja parameetriks andmebaasi asukoht
        andmebaas = New PrjAndmebaasKomponent.CSaaAndmed(Application.StartupPath)

        GMapControl1.Overlays.Clear()

        ' Peatuste nimede nimekirja deklareerimine ja väärtuse andmine vastava funktsiooni kaudu
        Dim peatusteList As List(Of String)
        peatusteList = andmebaas.saaKoikPeatuseNimed

        Dim markerOverlay As New GMapOverlay("markers")
        'Overlay on nagu pealiskiht mis pannakse kaardi peale, milelle lisatakse hilisema koodis kordinaadid
        GMapControl1.Overlays.Add(markerOverlay)
        MsgBox(markerOverlay.Control.PolygonsEnabled)
        markerOverlay.Control.PolygonsEnabled = False

        ' Tsükkel, mis käib kõik peatuse nimed läbi
        For Each peatus As String In peatusteList
            ' Peatuse nime järgi koordinaatide saamine Double array'na.
            ' Array esimene liige on latitude, array teine liige on longitude
            Dim koordinaadid As Double() = andmebaas.saaPeatuseAsukoht(peatus)
            ' Markeri loomine koordinaatide järgi

            Dim destinationPath As String = Application.StartupPath & "\Icons" & "\mapMarker.png"

            Dim markerIcon As New Bitmap(destinationPath)
            'Dim marker As New GMap.NET.WindowsForms.Markers.GMarkerGoogle(New PointLatLng(koordinaadid(0), koordinaadid(1)), Markers.GMarkerGoogleType.green)
            Dim marker As New GMap.NET.WindowsForms.Markers.GMarkerGoogle(New PointLatLng(koordinaadid(0), koordinaadid(1)), markerIcon)

            ' Kui hiir läheb markeri peale, siis tuleb Tool Tip'ina tekst, mis kuvab peatuse nime
            marker.ToolTipText = peatus

            'Dim X As New Point(-15, 31)
            'marker.Offset = X


            ' Muudab markeri väiksemaks
            'Dim size As New Size(16, 16)
            'MsgBox(marker.Offset.X & " " & marker.Offset.Y)
            'MsgBox(marker.Position.Lat & " " & marker.Position.Lng)
            'MsgBox(marker.LocalPosition.X & " " & marker.LocalPosition.Y)
            'MsgBox(marker.LocalArea.X & " " & marker.LocalArea.Y & " " & marker.LocalArea.Width & " " & marker.LocalArea.Height)
            'marker.Size = size


            ' Lisab markeri kaardile
            markerOverlay.Markers.Add(marker)

        Next
    End Sub
    Private Sub btnOtsiPeatused_Click(sender As Object, e As EventArgs) Handles btnOtsiPeatused.Click
        RaiseEvent otsiClick()
    End Sub


    ' Teekonna kuvamiseks kasutatud abimaterjal: http://www.independent-software.com/gmap-net-tutorial-routes.html
    ' Looja: Independent Software
    Public Sub uldineTeekonaKuvamine(liin As String) Implements IMargiKaardil.uldineTeekonnaKuvamine
        Dim algPeatus As String = TxtAlgusPeatus.Text
        Dim loppPeatus As String = txtLoppPeatus.Text

        Dim bussiPeatuseKuvamine As New GMapOverlay("bussiPeatus")
        GMapControl1.Overlays.Add(bussiPeatuseKuvamine)

        andmebaas = New PrjAndmebaasKomponent.CSaaAndmed(Application.StartupPath)

        GMapControl1.Overlays.Clear()

        Dim markeriKuvamine As New GMapOverlay("markerid")
        GMapControl1.Overlays.Add(markeriKuvamine)

        Dim koordinaadidAlgus As Double() = andmebaas.saaPeatuseAsukoht(algPeatus)
        If koordinaadidAlgus(0) = 0 And koordinaadidAlgus(1) = 0 Then
            TxtAlgusPeatus.Text = "Sellist peatust ei eksisteeri"
            Return    
        End If

        Dim koordinaadidLopp As Double() = andmebaas.saaPeatuseAsukoht(loppPeatus)
        If koordinaadidLopp(0) = 0 And koordinaadidLopp(1) = 0 Then
            txtLoppPeatus.Text = "Sellist peatust ei eksisteeri"
            Return
        End If

        Dim destinationPathGreen As String = Application.StartupPath & "\Icons" & "\mapMarker.png"
        Dim destinationPathRed As String = Application.StartupPath & "\Icons" & "\mapMarkerRed.png"
        Dim destinationPathYellow As String = Application.StartupPath & "\Icons" & "\mapMarkerYellow.png"
        Dim markerIconGreen As New Bitmap(destinationPathGreen)
        Dim markerIconRed As New Bitmap(destinationPathRed)
        Dim markerIconYellow As New Bitmap(destinationPathYellow)

        Dim alguseMarker As New GMap.NET.WindowsForms.Markers.GMarkerGoogle(
        New PointLatLng(koordinaadidAlgus(0), koordinaadidAlgus(1)), markerIconGreen)

        Dim lopuMarker As New GMap.NET.WindowsForms.Markers.GMarkerGoogle(
        New PointLatLng(koordinaadidLopp(0), koordinaadidLopp(1)), markerIconRed)

        alguseMarker.ToolTipText = algPeatus
        lopuMarker.ToolTipText = loppPeatus

        Dim size As New Size(16, 16)
        alguseMarker.Size = size
        lopuMarker.Size = size

        markeriKuvamine.Markers.Add(alguseMarker)
        markeriKuvamine.Markers.Add(lopuMarker)
        'teekonna kuvamine'
        Dim liiniJada As String() = Split(liin)
        Dim liiniNimi As String = liiniJada(0)
        Dim liiniTeekond As String = Nothing

        'Alustab esimesest liikmest, sest Split tehti tühikute järgi ja marsruudil. Võetakse sidekriipsude vahelt peatused ja pannakse see kokku uue stringina
        For i As Integer = 1 To liiniJada.Length - 1
            liiniTeekond &= liiniJada(i) & " "
        Next

        liiniTeekond = Trim(liiniTeekond)

        Dim teekonnaList As List(Of String) = andmebaas.saaPeatuseNimedLiiniJargi(liiniNimi, liiniTeekond)

        For i As Integer = teekonnaList.IndexOf(algPeatus) To teekonnaList.IndexOf(loppPeatus) - 1
            Dim algPeatuse As String = teekonnaList(i)
            Dim loppPeatuse As String = teekonnaList(i + 1)

            Dim algKordinaadid As Double() = andmebaas.saaPeatuseAsukoht(algPeatuse)
            Dim loppKordinaadid As Double() = andmebaas.saaPeatuseAsukoht(loppPeatuse)

            Dim algusOma As PointLatLng = New PointLatLng(algKordinaadid(0), algKordinaadid(1))
            Dim lopuOma As PointLatLng = New PointLatLng(loppKordinaadid(0), loppKordinaadid(1))

            Dim teekond As MapRoute = GMap.NET.MapProviders.OpenStreetMapProvider.Instance.GetRoute(algusOma, lopuOma, False, False, 15)
            If i = teekonnaList.IndexOf(algPeatus) Then
                Dim algusMarker As New GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                algusOma, markerIconGreen)
                markeriKuvamine.Markers.Add(algusMarker)

                algusMarker.ToolTipText = algPeatus
                algusMarker.Size = size

            ElseIf i = teekonnaList.IndexOf(loppPeatus) Then

                Dim loppMarker As New GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                lopuOma, markerIconRed)
                markeriKuvamine.Markers.Add(loppMarker)

                loppMarker.ToolTipText = loppPeatus
                loppMarker.Size = size
            Else
                Dim vaheMarker As New GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                algusOma, markerIconYellow)
                markeriKuvamine.Markers.Add(vaheMarker)

                vaheMarker.ToolTipText = teekonnaList(i)
                vaheMarker.Size = size
            End If
            Dim ruut As GMapRoute = New GMapRoute(teekond.Points, "My route")

            Dim routesOverlay As GMapOverlay = New GMapOverlay("routes")
            routesOverlay.Routes.Add(ruut)

            GMapControl1.Overlays.Add(routesOverlay)

            ruut.Stroke.Width = 2
            ruut.Stroke.Color = Color.Red
        Next
        GMapControl1.Refresh()
    End Sub
    Public Sub margiSoidukiAsukoht(liin As String) Implements IMargiKaardil.margiSoidukiAsukoht
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

        Dim destinationPathRed As String = Application.StartupPath & "\Icons" & "\mapMarkerRed.png"
        Dim markerIconRed As New Bitmap(destinationPathRed)

        ' Loop kõikide sõidukite koordinaatide läbimiseks
        For Each koordinaadid In koordinaadidList
            Dim marker As New GMap.NET.WindowsForms.Markers.GMarkerGoogle(New PointLatLng(koordinaadid(1), koordinaadid(0)), markerIconRed)

            marker.ToolTipText = liin

            Dim size As New Size(16, 16)
            marker.Size = size

            markerOverlay.Markers.Add(marker)
        Next
    End Sub

    Public Sub margiKoikVaatamisvaarsused() Implements IMargiKaardil.margiKoikVaatamisvaarsused
        Dim andmebaas As PrjAndmebaasKomponent.ISaaAndmed
        andmebaas = New PrjAndmebaasKomponent.CSaaAndmed(Application.StartupPath)

        Dim vaatamisvaarsusedList As List(Of String)
        vaatamisvaarsusedList = andmebaas.saaKoikVaatamisvaarsuseNimed

        Dim markerOverlay As New GMapOverlay("markers")
        GMapControl1.Overlays.Add(markerOverlay)

        For Each koht As String In vaatamisvaarsusedList
            Dim koordinaadid As Double() = andmebaas.saaVaatamisvaarsuseAsukoht(koht)
            Dim destinationPath As String = Application.StartupPath & "\Icons" & "\kaamera.png"

            Dim markerIcon As New Bitmap(destinationPath)
            Dim marker As New GMap.NET.WindowsForms.Markers.GMarkerGoogle(New PointLatLng(koordinaadid(0), koordinaadid(1)), markerIcon)
            marker.ToolTipText = koht
            markerOverlay.Markers.Add(marker)
        Next
    End Sub

    Public Sub margiLiiniPeatused(liin As String) Implements IMargiKaardil.margiLiiniPeatused
        Dim liinipeatused As PrjAndmebaasKomponent.ISaaAndmed
        liinipeatused = New PrjAndmebaasKomponent.CSaaAndmed(Application.StartupPath)

        Dim markerOverlay As New GMapOverlay("markers")
        GMapControl1.Overlays.Clear()
        GMapControl1.Overlays.Add(markerOverlay)

        Dim stringArray As String() = Split(liin)
        Dim liiniNimi As String = stringArray(0)

        Dim liiniTeekond As String = ""

        For i As Integer = 1 To stringArray.Length - 1
            liiniTeekond &= stringArray(i) & " "
        Next
        liiniTeekond = Trim(liiniTeekond)

        Dim peatusteNimed As List(Of String) = liinipeatused.saaPeatuseNimedLiiniJargi(liiniNimi, liiniTeekond)
        Dim destinationPathPurple As String = Application.StartupPath & "\Icons" & "\mapMarkerPurple.png"
        Dim markerIconPurple As New Bitmap(destinationPathPurple)
        For Each peatus In peatusteNimed

            Dim kordinaadid As Double() = liinipeatused.saaPeatuseAsukoht(peatus)
            Dim marker As New GMap.NET.WindowsForms.Markers.GMarkerGoogle(New PointLatLng(kordinaadid(0), kordinaadid(1)), markerIconPurple)
            marker.ToolTipText = peatus
            markerOverlay.Markers.Add(marker)
        Next
    End Sub


    Private Sub GMapControl1_OnMarkerDoubleClick(item As GMapMarker, e As MouseEventArgs) Handles GMapControl1.OnMarkerDoubleClick
        ' Event käivitub ning seda jälgiv funktsioon käivitub kasutajaakna koodis
        RaiseEvent markerDoubleClick(item)
    End Sub
End Class
