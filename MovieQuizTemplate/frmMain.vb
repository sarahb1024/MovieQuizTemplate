Public Class frmMain
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtPlayerName.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        playerScore = 0
        playerName = txtPlayerName.Text
        frmQuestion1.Show()
        Me.Hide()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub


    Public Sub playTrack(ByVal track As String)
        wmpQuiz.Ctlcontrols.stop()
        wmpQuiz.URL = track
        wmpQuiz.Ctlcontrols.play()
    End Sub
End Class