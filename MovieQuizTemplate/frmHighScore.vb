﻿Public Class frmHighScore
    Public Sub doScore()
        If (playerScore < 1) Then
            lblMessage.Text = "Sorry Your Score Was Not Good Enough"
        Else
            lblMessage.Text = "Congratulations Your Score Will Be Added To The Hall Of Fame"
1StHighScore.Items.Add(playerName & vbTab & vbTab & playerScore)
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub btnAgain_Click(sender As Object, e As EventArgs) Handles btnAgain.Click
        frmMain.Show()
        Me.Hide()
    End Sub
End Class