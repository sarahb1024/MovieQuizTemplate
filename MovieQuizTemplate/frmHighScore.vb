Public Class frmHighScore
    Private Sub btnAgain_Click(sender As Object, e As EventArgs) Handles btnAgain.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub IstHighScore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IstHighScore.SelectedIndexChanged

    End Sub

    Public Sub doScore()
        If (playerScore < 1) Then
            Label1.Text = " Sorry Your Score Waas Not Good Enough"
        Else
            Label1.Text = "Congratulations Your ScoreWill be Added To The Hall Of Fame"
            IstHighScore.Items.Add(playerName & vbTab & vbTab & playerScore)
        End If
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub
End Class