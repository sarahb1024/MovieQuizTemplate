Public Class frmQuestion5
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If (btnAnswer2.Checked) Then
            playerScore = playerScore + 1
        End If

        frmQuestion6.Show()


        Me.Hide()
    End Sub
End Class