﻿Public Class Form1
    Public Selected As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxVali.DropDownStyle = ComboBoxStyle.DropDownList
        cbxVali.Enabled = True
        Me.cbxVali.Items.Add("Peatus") ' Kuvab loetelu peatustest
        Me.cbxVali.Items.Add("Liin") ' Kuvab loetelu liinidest
    End Sub

    Private Sub cbxVali_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxVali.SelectedIndexChanged
        Selected = cbxVali.SelectedItem
        If Selected = "Peatus" Then

        End If


    End Sub

    Private Sub btnOtsi_Click(sender As Object, e As EventArgs)  ' Klikib OTSI ja siis kuvab kas liini peatuste loetelu VÕI peatuses peatuvad liinid

    End Sub

    Private Sub btnKuvaKaardil_Click(sender As Object, e As EventArgs) Handles btnKuvaKaardil.Click
        ' Find the form you want to open by name
        Dim formToOpen As Form = Application.OpenForms("Map")
        ' If the form is not already open, create a new instance of it and show it
        If formToOpen Is Nothing Then
            formToOpen = New MapIsTesting.Map()
            formToOpen.Show()
        Else
            ' If the form is already open, bring it to the front
            formToOpen.BringToFront()
        End If
    End Sub

End Class