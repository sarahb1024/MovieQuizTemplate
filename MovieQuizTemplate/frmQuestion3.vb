Public Class frmQuestion3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If (btnAnswer4.Checked) Then
            playerScore = playerScore + 1
        End If

        frmHighScore.Show()
        frmHighScore.doScore

        Me.Hide()
        wmpQuiz.Ctlcontrols.stop

        Public Sub init()
        frmMain.playTrack("question1.mp3")

        bntAnswer1.Checked = False
        bntAnswer2.Checked = False
        bntAnswer3.Checked = False
        bntAnswer4.Checked = False
    End Sub
End Class