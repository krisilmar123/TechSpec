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
    End Sub

    Private Sub UserControl11_Load(sender As Object, e As EventArgs) Handles UMap.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UMap.margiKoikPeatused()

    End Sub

    Private Sub cbxPeatus_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UMap.margiSoidukiAsukoht(ULiinidJaPeatusedList1.liiniValik)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim CSV As CSVExporterDNF.IExporter
        CSV = New CSVExporterDNF.CExporter
        CSV.textQualifier = ","
        CSV.delimiter = ","
        CSV.setFileToSave()

        Dim DataList As List(Of String) = ULiinidJaPeatusedList1.liiniList
        Dim Data(DataList.Count - 1, 0) As String
        Dim i As Integer = 0
        For Each liin In DataList
            Data(i, 0) = liin
            i += 1
        Next
        CSV.saveDataToCsv(Data)

        MsgBox(CSV.textQualifier)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub txtAlgpeatus_TextChanged(sender As Object, e As EventArgs) Handles txtAlgpeatus.TextChanged

    End Sub
End Class