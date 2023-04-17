Public Class frmQ2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If (btnAnswer4.Checked) Then
            playerScore = playerScore + 1
        End If

        frmQuestion3.Show()

        Me.Hide()
    End Sub
End Class