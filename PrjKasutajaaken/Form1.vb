Imports System.Threading
Public Class Form1
    Public Selected As String
    Private Sub Form1_Load(sender As Object, e As EventArgs)
        UMap.Visible = False
        UMap.Hide()
    End Sub
    Private Sub liinValitud() Handles ULiinidJaPeatusedList1.liinValitud
        If chkBoxReaal.Checked Then
            Timer1.Enabled = True

        Else

            Timer1.Enabled = False
        End If

        Dim margi As PrjKaardistaja.IMargiKaardil
        margi = UMap
        margi.margiLiiniPeatused(ULiinidJaPeatusedList1.liiniInfo)
        UMap.Visible = True
        UMap.Show()
        btnKuvaPeatused.Visible = True
        btnKuvaPeatused.Enabled = True

        If chkBoxReaal.Checked Then
            Timer1.Enabled = True
            margi.margiSoidukiAsukoht(ULiinidJaPeatusedList1.liiniValik)
        Else
            Timer1.Enabled = False
        End If

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

    Private Sub eventBtnOtsi() Handles UMap.otsiClick
        UMap.uldineTeekonaKuvamine(ULiinidJaPeatusedList1.liiniInfo)
    End Sub

    Private Sub btnVaatamisvaarsused_Click(sender As Object, e As EventArgs) Handles btnVaatamisvaarsused.Click
        Dim margi As PrjKaardistaja.IMargiKaardil
        margi = UMap
        margi.margiKoikVaatamisvaarsused()
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