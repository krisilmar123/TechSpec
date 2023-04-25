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

        RaiseEvent liinValitud()

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


    'Private Sub ListPeatused_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListPeatused.SelectedIndexChanged
    '    ListValjumised.Items.Clear()

    '    If ListPeatused.SelectedIndex >= 0 Then

    '        Dim peatuseNimi As String = ListPeatused.SelectedItem.ToString()

    '        Dim valjumised As List(Of String()) = andmebaas.saaValjumised(peatuseNimi)



    '        For Each valjumine In valjumised

    '            Dim stringKell As String = valjumine(1)
    '            Dim dateValue As Date = CDate(stringKell)

    '            ListValjumised.Items.Add(dateValue)

    '        Next
    '    End If

    '    Dim praeguneAeg As String = DateTime.Now

    '    ListValjumised.Items.Add(praeguneAeg)
    'End Sub
    Private Sub ListPeatused_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListPeatused.SelectedIndexChanged
        ListValjumised.Items.Clear()

        If ListPeatused.SelectedIndex >= 0 Then

            Dim peatuseNimi As String = ListPeatused.SelectedItem.ToString()

            Dim valjumised As List(Of String()) = andmebaas.saaValjumised(peatuseNimi)



            For Each valjumine In valjumised

                Dim stringKell1 As String = valjumine(1)
                Dim stringKell2 As String() = stringKell1.Split(":")
                Dim stringResult As String = ""

                Dim stringHour As String = stringKell2(0)
                Dim stringMinute As String = stringKell2(1)
                Dim stringSecond As String = stringKell2(2)

                stringResult &= stringKell2(0) & ":" & stringKell2(1) & ":" & stringKell2(2)


                If stringKell2(0) = 24 Then
                    stringKell2(0) = 0
                End If

                ListValjumised.Items.Add(stringResult)






            Next
        End If

        Dim dateValue As String = DateTime.Now
        Dim aegDate As String() = dateValue.ToString().Split(" ")
        Dim reaalAeg As String = aegDate(1)


        ListValjumised.Items.Add(reaalAeg)


        'Dim stringHour As String = DateTime.Now.Hour.ToString()
        'Dim stringMinute As String = DateTime.Now.Minute.ToString()
        'Dim stringSecond As String = DateTime.Now.Second.ToString()

        'Dim result As String = stringHour & ":" stringMinute & ":" stringSecond
        'Integer.Parse(result)

        'ListValjumised.Items.Add(result)
    End Sub





End Class
