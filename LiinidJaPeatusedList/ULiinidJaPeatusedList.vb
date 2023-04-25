Public Class ULiinidJaPeatusedList

    Dim andmebaas As PrjAndmebaasKomponent.ISaaAndmed

    Public Property liiniValik As String

    Public Event liinValitud()
    Private Sub ULiinidJaPeatusedList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        andmebaas = New PrjAndmebaasKomponent.CSaaAndmed(Application.StartupPath)

        ' Split the long string into a list of strings
        Dim stringList As List(Of String) = andmebaas.saaLiinid()

        ' Clear the items in the ListView control
        ListLiinid.Items.Clear()

        ' Add each string in the list as an item in the ListView control
        For Each s As String In stringList
            ListLiinid.Items.Add(s)
        Next
    End Sub
    Private Sub ListLiinid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListLiinid.SelectedIndexChanged
        ListPeatused.Items.Clear()


        If ListLiinid.SelectedIndex >= 0 Then
            Dim koosNimi As String = ListLiinid.SelectedItem.ToString()
            Dim stringArray As String() = Split(koosNimi)
            Dim liiniNimi As String = stringArray(0)

            Dim liiniTeekond As String = ""

            liiniValik = liiniNimi

            For i As Integer = 1 To stringArray.Length - 1
                liiniTeekond &= stringArray(i) & " "
            Next
            liiniTeekond = Trim(liiniTeekond)

            Dim peatusteNimed As List(Of String) = andmebaas.saaPeatuseNimedLiiniJargi(liiniNimi, liiniTeekond)

            For Each peatus In peatusteNimed
                ListPeatused.Items.Add(peatus)
            Next
        End If

    End Sub

    Public Sub ListPeatused_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListPeatused.SelectedIndexChanged
        ListValjumised.Items.Clear()


        If ListPeatused.SelectedIndex >= 0 Then

            KuvaValjumised(ListPeatused.SelectedItem.ToString())

        End If

    End Sub

    Public Sub KuvaValjumised(peatuseNimi As String)
        ListValjumised.Items.Clear()

        Dim valjumised As List(Of String()) = andmebaas.saaValjumised(peatuseNimi)

        valjumised = valjumised.Distinct.ToList()

        For Each valjumine In valjumised

            Dim stringKell1 As String = valjumine(1)
            Dim stringKell2 As String() = stringKell1.Split(":")


            Dim stringHour As String = stringKell2(0)
            Dim stringMinute As String = stringKell2(1)
            Dim stringSecond As String = stringKell2(2)
            Dim stringResult As String = stringKell2(0) & stringKell2(1)
            Dim intResult As Integer = Integer.Parse(stringResult)

            If stringKell2(0) = 24 Then
                stringKell2(0) = 0
            End If

            Dim dateValue As String = DateTime.Now
            Dim stringaegDate As String() = dateValue.ToString().Split(" ")
            Dim stringDateWO As String() = stringaegDate(1).ToString().Split(":")
            Dim stringReaalResult As String = stringDateWO(0) & stringDateWO(1)
            Dim intReaalResutl As Integer = Integer.Parse(stringReaalResult)

            If (intResult - intReaalResutl <= 30) And (intResult - intReaalResutl >= 0) Then

                ListValjumised.Items.Add("nr:" & valjumine(0) & " " & valjumine(1))

            End If

        Next
    End Sub

End Class
