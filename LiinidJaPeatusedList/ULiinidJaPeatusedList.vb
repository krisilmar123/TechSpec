Public Class ULiinidJaPeatusedList

    Dim andmebaas As PrjAndmebaasKomponent.ISaaAndmed

    Private Sub ULiinidJaPeatusedList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        andmebaas = New PrjAndmebaasKomponent.CSaaAndmed(Application.StartupPath)

        ' Split the long string into a list of strings
        Dim stringList As List(Of String) = andmebaas.saaLiinid()

        ' Clear the items in the ListView control
        ListView1.Items.Clear()

        ' Add each string in the list as an item in the ListView control
        For Each s As String In stringList
            ListView1.Items.Add(s)
        Next
    End Sub

End Class
