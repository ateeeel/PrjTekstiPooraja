Public Class formKasutajaAken

    Private Sub btnPooraFunktsiooniga_Click(sender As Object, e As EventArgs) _
        Handles btnPooraFunktsiooniga.Click
        Dim pooraja As PrjTekstiPoorajaKomponent.ITeisendaja

        pooraja = New PrjTekstiPoorajaKomponent.TekstiPooraja

        pooraja.Tekst = txtSisendTekst.Text

        txtValjundTekst1.Text = pooraja.PooraTekst()
    End Sub

    Private Sub btnPooraProtseduuriga_Click(sender As Object, e As EventArgs) _
        Handles btnPooraProtseduuriga.Click

        Dim pooraja As PrjTekstiPoorajaKomponent.ITeisendaja

        pooraja = New PrjTekstiPoorajaKomponent.TekstiPooraja

        pooraja.TeisendaTekst(txtSisendTekst.Text)

        txtValjundTekst2.Text = pooraja.Tekst
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        timerUuenda.Enabled = True

        btnStart.Enabled = False

        btnStopp.Enabled = True
    End Sub

    Private Sub timerUuenda_Tick(sender As Object, e As EventArgs) Handles timerUuenda.Tick
        Dim pooraja As PrjTekstiPoorajaKomponent.ITeisendaja

        pooraja = New PrjTekstiPoorajaKomponent.TekstiPooraja

        pooraja.TeisendaTekst(txtSisendTekst.Text)

        txtValjundTekst1.Text = pooraja.Tekst
    End Sub

    Private Sub btnStopp_Click(sender As Object, e As EventArgs) Handles btnStopp.Click
        timerUuenda.Enabled = False

        btnStart.Enabled = True

        btnStopp.Enabled = False
    End Sub
End Class
