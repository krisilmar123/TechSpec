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
            Dim liiniTeekond As String = stringArray(1)
            Dim liiniTeekond2 As String = stringArray(2)
            Dim liiniTeekond3 As String = stringArray(3)

            Dim mingiString As String = liiniNimi & liiniTeekond


            Dim uusLiiniTeekond As String = liiniTeekond & " " & liiniTeekond2 & " " & liiniTeekond3

            MsgBox(uusLiiniTeekond & "midagi")

            Dim peatusteNimed As List(Of String) = andmebaas.saaPeatuseNimedLiiniJargi(liiniNimi, uusLiiniTeekond)

            For Each peatus In peatusteNimed
                MsgBox(peatus)
            Next
        End If

    End Sub




End Class
