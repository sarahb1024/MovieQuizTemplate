Public Class frmQ2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If (btnAnswer4.Checked) Then
            playerScore = playerScore + 1
        End If

        frmQuestion3.Show()

        Me.Hide()
        Public Sub init()
        frmMain.playTrack("question1.mp3")

        bntAnswer1.Checked = False
        bntAnswer2.Checked = False
        bntAnswer3.Checked = False
        bntAnswer4.Checked = False
    End Sub
    End Sub
End Class