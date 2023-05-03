Public Interface ISaaAndmed
    Function saaPeatuseAsukoht(peatuseNimi As String) As Double()

    Function saaValjumised(peatuseNimi As String, liiniNimi As String, paev As String) As List(Of String())

    Function saaLiinid() As List(Of String)

    Function saaKoikPeatuseNimed() As List(Of String)

    Function saaPeatuseNimedLiiniJargi(liiniNimi As String, liiniTeekond As String) As List(Of String)

    Function saaKoikVaatamisvaarsuseNimed() As List(Of String)

    Function saaVaatamisvaarsuseAsukoht(vaarsusNimi As String) As Double()

    Function saaSoidukiAsukoht(liin As String) As List(Of Double())
End Interface
