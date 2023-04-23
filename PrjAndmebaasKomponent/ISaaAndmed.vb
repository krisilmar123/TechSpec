Public Interface ISaaAndmed
    Function saaPeatuseAsukoht(peatuseNimi As String) As Double()

    Function saaValjumised(peatuseNimi As String) As String

    Function saaLiinid() As List(Of String)

    Function saaKoikPeatuseNimed() As List(Of String)


End Interface
