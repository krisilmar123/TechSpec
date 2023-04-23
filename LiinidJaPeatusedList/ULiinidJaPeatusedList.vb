Public Class ULiinidJaPeatusedList

    Dim andmebaas As PrjAndmebaasKomponent.ISaaAndmed

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




End Class
