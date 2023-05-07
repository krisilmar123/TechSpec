Imports System.Threading
Public Class Kasutajaaken
    Public Selected As String

    Property CSV As CSVExporterDNF.IExporter = New CSVExporterDNF.CExporter()
    Property failiPath As String
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

    Private Sub btnSaveAs_Click(sender As Object, e As EventArgs) Handles btnSaveAs.Click
        CSV.textQualifier = txtTunnus.Text
        CSV.delimiter = txtEraldaja.Text

        Dim DataList As List(Of String()) = ULiinidJaPeatusedList1.valjumisteList
        If DataList Is Nothing Then
            MsgBox("Väljumised puuduvad!")
            Exit Sub
        End If


        failiPath = CSV.setFileToSave()


        Dim Data(DataList.Count - 1, 1) As String
        Dim i As Integer = 0
        For Each liin In DataList
            Data(i, 0) = liin(0)
            Data(i, 1) = liin(1)
            i += 1
        Next

        If rdioUleKirjutamine.Checked Then
            Try
                CSV.saveDataToCsv(Data, False)
            Catch ex As Exception
                MsgBox("Sulgege fail enne uuesti salvestamist!")
            End Try

        ElseIf rdioFailiLoppu.Checked Then
            Try
                CSV.saveDataToCsv(Data, True)
            Catch ex As Exception
                MsgBox("Sulgege fail enne uuesti salvestamist!")
            End Try
        End If
        btnSave.Enabled = True

        Dim SplitArray As String() = Split(failiPath, "\")

        Dim failiNimi As String = SplitArray(UBound(SplitArray))

        txtFailiAsukoht.Text = failiPath
        txtFailiNimi.Text = failiNimi

    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        CSV.textQualifier = txtTunnus.Text
        CSV.delimiter = txtEraldaja.Text

        Dim DataList As List(Of String()) = ULiinidJaPeatusedList1.valjumisteList
        If DataList Is Nothing Then
            MsgBox("Väljumised puuduvad!")
            Exit Sub
        End If

        Dim Data(DataList.Count - 1, 1) As String
        Dim i As Integer = 0
        For Each liin In DataList
            Data(i, 0) = liin(0)
            Data(i, 1) = liin(1)
            i += 1
        Next

        If rdioUleKirjutamine.Checked Then
            Try
                CSV.saveDataToCsv(Data, False)
            Catch ex As Exception
                MsgBox("Sulgege fail enne uuesti salvestamist!")
            End Try

        ElseIf rdioFailiLoppu.Checked Then
            Try
                CSV.saveDataToCsv(Data, True)
            Catch ex As Exception
                MsgBox("Sulgege fail enne uuesti salvestamist!")
            End Try
        End If
        Dim SplitArray As String() = Split(failiPath, "\")

        Dim failiNimi As String = SplitArray(UBound(SplitArray))

        txtFailiAsukoht.Text = failiPath
        txtFailiNimi.Text = failiNimi
    End Sub

End Class