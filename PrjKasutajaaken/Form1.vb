﻿Imports System.Threading
Public Class Form1
    Public Selected As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UMap.Hide()

    End Sub


    Private Sub liinValitud() Handles ULiinidJaPeatusedList1.liinValitud
        Timer1.Enabled = True
        UMap.margiSoidukiAsukoht(ULiinidJaPeatusedList1.liiniValik)
    End Sub

    Private Sub btnOtsi_Click(sender As Object, e As EventArgs)  ' Klikib OTSI ja siis kuvab kas liini peatuste loetelu VÕI peatuses peatuvad liinid

    End Sub

    Private Sub btnKuvaKaardil_Click(sender As Object, e As EventArgs) Handles btnKuvaKaardil.Click
        UMap.Show()
        Button1.Visible = True
    End Sub

    Private Sub UserControl11_Load(sender As Object, e As EventArgs) Handles UMap.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UMap.margiKoikPeatused()
        Button1.Visible = False
    End Sub

    Private Sub cbxPeatus_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class