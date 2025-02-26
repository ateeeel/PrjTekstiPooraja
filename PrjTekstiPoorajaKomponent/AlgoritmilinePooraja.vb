Public Class AlgoritmilinePooraja
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
        If PooratavTekst Is Nothing Then
            Throw New InvalidOperationException("PooratavTekst tuleb enne PooraTeksti helistamist initsialiseerida")
        End If

        Dim reversed As New System.Text.StringBuilder()
        For i As Integer = PooratavTekst.Length - 1 To 0 Step -1
            reversed.Append(PooratavTekst(i))
        Next

        Return reversed.ToString()
    End Function


    Private Sub TeisendaTekst(ByRef sisendTekst As String) Implements ITeisendaja.TeisendaTekst
        If String.IsNullOrEmpty(sisendTekst) Then
            Throw New ArgumentException("Tekst ei tohi olla tühi")
        End If
        PooratavTekst = sisendTekst
        PooratavTekst = PooraTekst()
    End Sub


End Class
