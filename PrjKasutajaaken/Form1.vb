Imports System.Threading
Public Class Form1
    Public Selected As String
    Private Sub Form1_Load(sender As Object, e As EventArgs)
        UMap.Visible = False
        UMap.Hide()
    End Sub
    Private Sub liinValitud() Handles ULiinidJaPeatusedList1.liinValitud
        Dim margi As PrjKaardistaja.IMargiKaardil
        margi = UMap
        Timer1.Enabled = True
        margi.margiSoidukiAsukoht(ULiinidJaPeatusedList1.liiniValik)
        UMap.Visible = True
        Timer1.Enabled = False
        UMap.Show()
        btnKuvaPeatused.Visible = True
        btnKuvaPeatused.Enabled = True

    End Sub

    Private Sub btnKuvaKaardil_Click(sender As Object, e As EventArgs) Handles btnKuvaKaardil.Click
        Dim kaart As PrjKaardistaja.IKuvaKaart
        kaart = UMap
        kaart.kuvaKaart()
        UMap.Visible = True
        Timer1.Enabled = False
        UMap.Show()
        btnKuvaPeatused.Enabled = True
        btnVaatamisvaarsused.Enabled = True
    End Sub

    Private Sub btnKuvaPeatused_Click(sender As Object, e As EventArgs) Handles btnKuvaPeatused.Click
        Dim margi As PrjKaardistaja.IMargiKaardil
        margi = UMap

        margi.margiKoikPeatused()

        Timer1.Enabled = False
    End Sub

    ' Käivitub siis, kui klikitakse kaks korda kaardi markerile
    Private Sub markerDoubleClick(item As GMap.NET.WindowsForms.GMapMarker) Handles UMap.markerDoubleClick
        Dim valjumine As LiinidJaPeatusedList.IKuvaAndmed
        valjumine = New LiinidJaPeatusedList.ULiinidJaPeatusedList()

        If ULiinidJaPeatusedList1.liiniValik <= 0 Then
            MsgBox("Palun vali liiniloetelust liin")
        Else
            valjumine.KuvaValjumised(item.ToolTipText, ULiinidJaPeatusedList1.liiniValik)
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim margi As PrjKaardistaja.IMargiKaardil
        margi = UMap
        margi.margiSoidukiAsukoht(ULiinidJaPeatusedList1.liiniValik)

    End Sub

    Private Sub btnVaatamisvaarsused_Click(sender As Object, e As EventArgs) Handles btnVaatamisvaarsused.Click
        Dim margi As PrjKaardistaja.IMargiKaardil
        margi = UMap
        margi.margiKoikVaatamisvaarsused()
    End Sub
End Class