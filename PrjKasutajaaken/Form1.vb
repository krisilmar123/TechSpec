Public Class Form1
    Public Selected As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxVali.DropDownStyle = ComboBoxStyle.DropDownList
        cbxVali.Enabled = True
        Me.cbxVali.Items.Add("Peatus") ' Kuvab loetelu peatustest
        Me.cbxVali.Items.Add("Liin") ' Kuvab loetelu liinidest
        UMap.Hide()

    End Sub

    Private Sub cbxVali_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxVali.SelectedIndexChanged
        Selected = cbxVali.SelectedItem
        If Selected = "Peatus" Then

        End If
    End Sub

    Private Sub liinValitud() Handles ULiinidJaPeatusedList1.liinValitud
        UMap.margiSoidukiAsukoht(ULiinidJaPeatusedList1.liiniValik)
    End Sub

    Private Sub btnOtsi_Click(sender As Object, e As EventArgs)  ' Klikib OTSI ja siis kuvab kas liini peatuste loetelu VÕI peatuses peatuvad liinid

    End Sub

    Private Sub btnKuvaKaardil_Click(sender As Object, e As EventArgs) Handles btnKuvaKaardil.Click
        UMap.Show()
    End Sub

    Private Sub UserControl11_Load(sender As Object, e As EventArgs) Handles UMap.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UMap.margiKoikPeatused()

    End Sub

    Private Sub cbxPeatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPeatus.SelectedIndexChanged

    End Sub
End Class