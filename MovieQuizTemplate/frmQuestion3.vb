Public Class frmQuestion3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If (btnAnswer4.Checked) Then
            playerScore = playerScore + 1
        End If

        frmQuestion4.Show()


        Me.Hide()
    End Sub
End Class