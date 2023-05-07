Public Class ULiinidJaPeatusedList : Implements IKuvaAndmed

    Dim andmebaas As PrjAndmebaasKomponent.ISaaAndmed

    Public Property liiniValik As String
    Public Property pensionaarCheckBox As Boolean

    Public Property liiniInfo As String

    Public Property valjumisteList As List(Of String())

    Public Event liinValitud()
    Private Sub ULiinidJaPeatusedList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        andmebaas = New PrjAndmebaasKomponent.CSaaAndmed(Application.StartupPath)

        'Deklareeritaks uus muutuja stringList saab string list saab liinide listi (liini nr ja marsuut)
        Dim stringList As List(Of String) = andmebaas.saaLiinid()

        ' Puhasta liinide listbox
        ListLiinid.Items.Clear()

        ' Lisa iga liige listist Liini ListBoxi
        For Each s As String In stringList
            ListLiinid.Items.Add(s)
        Next
    End Sub

    Private Sub ListLiinid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListLiinid.SelectedIndexChanged
        ListPeatused.Items.Clear()
        'Annab kasutajaaknale teada et LiinideListBoxist on midagi valitud
        RaiseEvent liinValitud()

        If ListLiinid.SelectedIndex >= 0 Then
            'Tehakse valitud liini koos numbri ja marsuudiga stringiks
            Dim koosNimi As String = ListLiinid.SelectedItem.ToString()
            'Tehakse string array kus esimene liige on number ja teine on marsruut
            Dim stringArray As String() = Split(koosNimi)
            'Pannakse eraldi muutujasse esimene liige
            Dim liiniNimi As String = stringArray(0)

            Dim liiniTeekond As String = ""
            'Kuna see on public property siis saab tänu sellele kasutaja aken näha mida selles LiinideListBoxis valiti
            liiniValik = liiniNimi
            liiniInfo = koosNimi

            'Alustab esimesest liikmest, sest Split tehti tühikute järgi ja marsruudil. Võetakse sidekriipsude vahelt peatused ja pannakse see kokku uue stringina
            For i As Integer = 1 To stringArray.Length - 1
                liiniTeekond &= stringArray(i) & " "
            Next

            'Trim eemaldab kõik tühikud algusest ja lõpust et oleks ühtne väljastus
            liiniTeekond = Trim(liiniTeekond)

            'Luuakse uus muutuja mis salvestab kõik peatused listi valitud liini kohta
            Dim peatusteNimed As List(Of String) = andmebaas.saaPeatuseNimedLiiniJargi(liiniNimi, liiniTeekond)

            'Lisatakse iga peatus PeatusteListBoxi
            For Each peatus In peatusteNimed
                ListPeatused.Items.Add(peatus)
            Next
        End If

    End Sub

    Private Sub ListPeatused_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListPeatused.SelectedIndexChanged
        ListValjumised.Items.Clear()

        'Kui valitakse PeatusteListBoxist midagi siis kutsutakse välja funktsioon "KuvaValjumised"
        If ListPeatused.SelectedIndex >= 0 Then

            KuvaValjumised(ListPeatused.SelectedItem.ToString(), liiniValik)

        End If

    End Sub

    Public Sub KuvaValjumised(peatuseNimi As String, liiniNimi As String) Implements IKuvaAndmed.KuvaValjumised
        ListValjumised.Items.Clear()
        valjumisteList = New List(Of String())
        andmebaas = New PrjAndmebaasKomponent.CSaaAndmed(Application.StartupPath)

        If pensionaarCheckBox Then

            Dim valjumised As List(Of String())

            If chkMadal.Checked Then
                valjumised = andmebaas.saaValjumised(peatuseNimi, liiniNimi, DateTime.Now.DayOfWeek.ToString, "3", True)
            Else
                valjumised = andmebaas.saaValjumised(peatuseNimi, liiniNimi, DateTime.Now.DayOfWeek.ToString, "3", False)
            End If


            'Lisab vaid unikaalsed liikemd AGA JÄETAKSE IKKA MILLEGI PÄRAST MÕNED DUPLIKAADID
            valjumised = valjumised.Distinct.ToList()

            For Each valjumine In valjumised

                ListValjumised.Items.Add("Bussi nr: " & valjumine(0) & " " & valjumine(1))
            Next

        Else
            Dim valjumised As List(Of String())


            If chkMadal.Checked Then
                valjumised = andmebaas.saaValjumised(peatuseNimi, liiniNimi, DateTime.Now.DayOfWeek.ToString, "15", True)
            Else
                valjumised = andmebaas.saaValjumised(peatuseNimi, liiniNimi, DateTime.Now.DayOfWeek.ToString, "15", False)
            End If


            'Lisab vaid unikaalsed liikemd AGA JÄETAKSE IKKA MILLEGI PÄRAST MÕNED DUPLIKAADID
            valjumised = valjumised.Distinct.ToList()

            For Each valjumine In valjumised

                Dim liin = "Bussi nr: " & valjumine(0)
                Dim valjumisAeg = valjumine(1)
                ListValjumised.Items.Add(liin & " " & valjumisAeg)
                valjumisteList.Add(valjumine)
            Next
        End If

    End Sub

    Private Sub CheckBoxPensionaar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPensionaar.CheckedChanged
        ListValjumised.Items.Clear()
        ListPeatused.Items.Clear()

        pensionaarCheckBox = CheckBoxPensionaar.Checked

    End Sub

    Private Sub btnInimesteHulk_Click(sender As Object, e As EventArgs) Handles btnInimesteHulk.Click

        Dim esimeneOsaAlgus As Date = #12:00:00 AM#
        Dim esimeneOsaLopp As Date = #07:30:00 AM#
        Dim teineOsaAlgus As Date = #07:30:01 AM#
        Dim teineOsaLopp As Date = #10:30:00 AM#
        Dim kolmasOsaAlgus As Date = #10:30:01 AM#
        Dim kolmasOsaLopp As Date = #01:10:00 PM#
        Dim neljasOsaAlgus As Date = #01:10:01 PM#
        Dim neljasOsaLopp As Date = #07:30:00 PM#
        Dim viiesOsaAlgus As Date = #07:30:01 PM#
        Dim viiesOsaLopp As Date = #09:30:00 PM#
        Dim kuuesOsaAlgus As Date = #09:30:01 PM#
        Dim kuuesOsaLopp As Date = #11:59:59 PM#

        Dim aegPraegu As Date
        aegPraegu = TimeValue(Now)

        If aegPraegu >= esimeneOsaAlgus And aegPraegu <= esimeneOsaLopp Then
            txtInimesteHulk.Text = "VÄHE"

        ElseIf aegPraegu >= teineOsaAlgus And aegPraegu <= teineOsaLopp Then
            txtInimesteHulk.Text = "PALJU"

        ElseIf aegPraegu >= kolmasOsaAlgus And aegPraegu <= kolmasOsaLopp Then
            txtInimesteHulk.Text = "KESMISELT"

        ElseIf aegPraegu >= neljasOsaAlgus And aegPraegu <= neljasOsaLopp Then
            txtInimesteHulk.Text = "PALJU"

        ElseIf aegPraegu >= viiesOsaAlgus And aegPraegu <= viiesOsaLopp Then
            txtInimesteHulk.Text = "KESKMISELT"

        ElseIf aegPraegu >= kuuesOsaAlgus And aegPraegu <= kuuesOsaLopp Then
            txtInimesteHulk.Text = "VÄHE"

        Else
            txtInimesteHulk.Text = "ERROR"

        End If

    End Sub

End Class