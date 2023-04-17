Public Class frmQuestion1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles btnAnswer3.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles btnAnswer4.CheckedChanged

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If (btnAnswer2.Checked) Then
            playerScore = playerScore + 1
        End If

        frmQ2.Show()

        Me.Hide()
    End Sub
End Class