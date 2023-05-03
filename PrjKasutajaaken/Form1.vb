Imports System.Threading
Public Class Form1
    Public Selected As String
    Private Sub Form1_Load(sender As Object, e As EventArgs)
        UMap.Visible = False
        UMap.Hide()

    End Sub
    Private Sub liinValitud() Handles ULiinidJaPeatusedList1.liinValitud
        Timer1.Enabled = True
        UMap.margiSoidukiAsukoht(ULiinidJaPeatusedList1.liiniValik)
    End Sub


    Private Sub btnKuvaKaardil_Click(sender As Object, e As EventArgs) Handles btnKuvaKaardil.Click
        UMap.Visible = True
        Timer1.Enabled = False
        UMap.Show()
        btnKuvaPeatused.Visible = True
    End Sub



    Private Sub btnKuvaPeatused_Click(sender As Object, e As EventArgs) Handles btnKuvaPeatused.Click
        UMap.margiKoikPeatused()
        Timer1.Enabled = False
    End Sub

    ' Käivitub siis, kui klikitakse kaks korda kaardi markerile
    Private Sub markerDoubleClick(item As GMap.NET.WindowsForms.GMapMarker) Handles UMap.markerDoubleClick
        If ULiinidJaPeatusedList1.liiniValik <= 0 Then
            MsgBox("Palun vali liiniloetelust liin")
        Else
            ULiinidJaPeatusedList1.KuvaValjumised(item.ToolTipText, ULiinidJaPeatusedList1.liiniValik)
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UMap.margiSoidukiAsukoht(ULiinidJaPeatusedList1.liiniValik)
    End Sub

End Class