Public Class TekstiPooraja
    Implements ITeisendaja

    Private AlgusSymbol As Integer
    Private LoppSymbol As Integer
    Private PooratavTekst As String

    Private Property EsimeseTaheAsciiKood As Integer Implements ITeisendaja.EsimeseTaheAsciiKood
        Get
            Return AlgusSymbol
        End Get
        Set(value As Integer)
            AlgusSymbol = value
        End Set
    End Property

    Private Property ViimaseTaheAsciiKood As Integer Implements ITeisendaja.ViimaseTaheAsciiKood
        Get
            Return LoppSymbol
        End Get
        Set(value As Integer)
            LoppSymbol = value
        End Set
    End Property

    Private Property Tekst As String Implements ITeisendaja.Tekst
        Get
            Return PooratavTekst
        End Get
        Set(value As String)
            PooratavTekst = value
        End Set
    End Property

    Private Function PooraTekst() As String Implements ITeisendaja.PooraTekst
        Return StrReverse(PooratavTekst)
    End Function

    Private Sub TeisendaTekst(ByRef sisendTekst As String) Implements ITeisendaja.TeisendaTekst
        PooratavTekst = StrReverse(sisendTekst)
    End Sub

End Class
