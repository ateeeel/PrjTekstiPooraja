Public Interface ITeisendaja
    Property EsimeseTaheAsciiKood As Integer

    Property ViimaseTaheAsciiKood As Integer

    Property Tekst As String
    Function PooraTekst() As String

    Sub TeisendajaTekst(ByRef sisendTekst As String)
End Interface
