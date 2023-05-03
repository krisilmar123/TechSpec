Public Class ULiinidJaPeatusedList

    Dim andmebaas As PrjAndmebaasKomponent.ISaaAndmed

    Public Property liiniValik As String

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

    Public Sub ListPeatused_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListPeatused.SelectedIndexChanged
        ListValjumised.Items.Clear()

        'Kui valitakse PeatusteListBoxist midagi siis kutsutakse välja funktsioon "KuvaValjumised"
        If ListPeatused.SelectedIndex >= 0 Then

            KuvaValjumised(ListPeatused.SelectedItem.ToString(), liiniValik)

        End If

    End Sub

    Public Sub KuvaValjumised(peatuseNimi As String, liiniNimi As String)
        ListValjumised.Items.Clear()

        Dim valjumised As List(Of String()) = andmebaas.saaValjumised(peatuseNimi, liiniNimi)

        'Lisab vaid unikaalsed liikemd AGA JÄETAKSE IKKA MILLEGI PÄRAST MÕNED DUPLIKAADID
        valjumised = valjumised.Distinct.ToList()

        For Each valjumine In valjumised

            ListValjumised.Items.Add("BUSS NR: " & valjumine(0) & " " & valjumine(1))
        Next

    End Sub

End Class





'Dim valjumised As List(Of String()) = andmebaas.saaValjumised(peatuseNimi, 15)

''Lisab vaid unikaalsed liikemd AGA JÄETAKSE IKKA MILLEGI PÄRAST MÕNED DUPLIKAADID
'valjumised = valjumised.Distinct.ToList()


'For Each valjumine In valjumised

''Võtab vaid kellaja
'Dim stringKell1 As String = valjumine(1)
''Splititakse kella aeg ":" kohtadest
'Dim stringKell2 As String() = stringKell1.Split(":")

''Jaotatakse aeg kolmeks osaks tunnid minutid ja sekundid
'Dim stringHour As String = stringKell2(0)
'Dim stringMinute As String = stringKell2(1)
'Dim stringSecond As String = stringKell2(2)
''Deklareeritakse "tulemus" tunnid ja minutid
'Dim stringResult As String = stringKell2(0) & stringKell2(1)
''Tehakse tulemus int tüüpi muutujaks
'Dim intResult As Integer = Integer.Parse(stringResult)

''Kui kellaja tunni kohas on 24 asendadtakse see 00-iga
'If stringKell2(0) = 24 Then
'stringKell2(0) = 0
'End If

''Võetakse reaalne kellaaeg
'Dim dateValue As String = DateTime.Now
''Eemaldatakse eest kuupäev jäetakse vaid kellaeg mis sisaldab ":"
'Dim stringaegDate As String() = dateValue.ToString().Split(" ")
''Eemaldatakse vaid kellaajast ":" 
'Dim stringDateWO As String() = stringaegDate(1).ToString().Split(":")
''Deklareeritakse uus string muutuja ja antakse väärtuseks tunnid ja minutid, et hiljem võrrelda
'Dim stringReaalResult As String = stringDateWO(0) & stringDateWO(1)
''Deklareeritakse uus muutuja mis on int tüüpi ja muudetakse eelnev tulemus intiks et võrrelda
'Dim intReaalResutl As Integer = Integer.Parse(stringReaalResult)

''Kui andmebaasist saadud kellaajast lahutada reaalne aeg, võrreldakse saadud tulemsut 30nega kas see on suure väiksem või võrdne
''Antud tsükkel jätkab kui tulemus on väiksem võrdne ja suurem 0-ist et ei oleks negatiivne
'If (intResult - intReaalResutl <= 30) And (intResult - intReaalResutl >= 0) Then

''Väljastataske tulemus ValjumisteListBoxi ja pannakse osade vahele koolonid
'ListValjumised.Items.Add("nr:" & valjumine(0) & " " & valjumine(1))

'End If

'Next