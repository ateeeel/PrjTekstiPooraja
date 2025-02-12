Public Class formKasutajaAken

    ' Event handler for "PooraFunktsiooniga" button
    Private Sub btnPooraFunktsiooniga_Click(sender As Object, e As EventArgs) _
        Handles btnPooraFunktsiooniga.Click
        Dim pooraja As PrjTekstiPoorajaKomponent.ITeisendaja

        ' Dynamically select the class based on ComboBox selection
        If cmbPoorajaValik.SelectedItem.ToString() = "TekstiPooraja" Then
            pooraja = New PrjTekstiPoorajaKomponent.TekstiPooraja()
        ElseIf cmbPoorajaValik.SelectedItem.ToString() = "AlgoritmilinePooraja" Then
            pooraja = New PrjTekstiPoorajaKomponent.AlgoritmilinePooraja()
        End If

        pooraja.Tekst = txtSisendTekst.Text
        txtValjundTekst1.Text = pooraja.PooraTekst()
    End Sub

    ' Event handler for "PooraProtseduuriga" button
    Private Sub btnPooraProtseduuriga_Click(sender As Object, e As EventArgs) _
        Handles btnPooraProtseduuriga.Click

        Dim pooraja As PrjTekstiPoorajaKomponent.ITeisendaja

        ' Dynamically select the class based on ComboBox selection
        If cmbPoorajaValik.SelectedItem.ToString() = "TekstiPooraja" Then
            pooraja = New PrjTekstiPoorajaKomponent.TekstiPooraja()
        ElseIf cmbPoorajaValik.SelectedItem.ToString() = "AlgoritmilinePooraja" Then
            pooraja = New PrjTekstiPoorajaKomponent.AlgoritmilinePooraja()
        End If

        pooraja.TeisendaTekst(txtSisendTekst.Text)
        txtValjundTekst2.Text = pooraja.Tekst
    End Sub

    ' Event handler for the "Start" button
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        timerUuenda.Enabled = True
        btnStart.Enabled = False
        btnStopp.Enabled = True
    End Sub

    ' Timer tick event for updating text
    Private Sub timerUuenda_Tick(sender As Object, e As EventArgs) Handles timerUuenda.Tick
        Dim pooraja As PrjTekstiPoorajaKomponent.ITeisendaja

        ' Dynamically select the class based on ComboBox selection
        If cmbPoorajaValik.SelectedItem.ToString() = "TekstiPooraja" Then
            pooraja = New PrjTekstiPoorajaKomponent.TekstiPooraja()
        ElseIf cmbPoorajaValik.SelectedItem.ToString() = "AlgoritmilinePooraja" Then
            pooraja = New PrjTekstiPoorajaKomponent.AlgoritmilinePooraja()
        End If

        pooraja.TeisendaTekst(txtSisendTekst.Text)
        txtValjundTekst1.Text = pooraja.Tekst
    End Sub

    ' Event handler for the "Stop" button
    Private Sub btnStopp_Click(sender As Object, e As EventArgs) Handles btnStopp.Click
        timerUuenda.Enabled = False
        btnStart.Enabled = True
        btnStopp.Enabled = False
    End Sub

    ' TextChanged event for counting characters and vowels, etc.
    Private Sub txtSisendTekst_TextChanged(sender As Object, e As EventArgs) Handles txtSisendTekst.TextChanged
        ' counting characters
        Dim sisendLength As Object
        sisendLength = Len(Me.txtSisendTekst.Text)
        charLength.Text = "Pikkus:" & sisendLength

        ' counting vowels
        Dim I As Integer
        Dim nVowels As Integer
        Dim Vowels As String

        Vowels = "aeiouöäüõÖÄÕÜOIUAE"

        For I = 1 To Len(Me.txtSisendTekst.Text)
            If InStr(Vowels, Mid$(txtSisendTekst.Text, I, 1)) Then
                nVowels = nVowels + 1
            End If
        Next
        lblVowels.Text = "Vowels:" & nVowels

        ' Getting first and last char in a string
        If txtSisendTekst.Text.Length > 0 Then
            Dim firstChar = txtSisendTekst.Text.First()
            Dim lastChar = txtSisendTekst.Text.Last()
            Dim firstAscii As Integer = Asc(firstChar)
            Dim lastAscii As Integer = Asc(lastChar)
            lblAscii.Text = "First ASCII char: " & firstAscii & vbNewLine & "Last ASCII char: " & lastAscii
        Else
            lblAscii.Text = "No text entered"
        End If
    End Sub
End Class
