Public Class frmMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        playerScore = 0
        If (txtName.Text = "") Then
            MsgBox("Please Enter Your Name")
        Else
            'save the palyer name to the global variable
            playerName = txtName.Text
            'show the first question form
            frmQuestion1.Show()
            'use the local sub procedure to initialise the form
            frmQuestion1.init()
            'set the player name to blank for game restart
            txtName.Text = ""
            'hide this form
            Me.Hide()
        End If
        playerName = txtName.Text
        frmQuestion1.Show()

        Me.Hide()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtPlayerName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub tmrQuestion1_Tick(sender As Object, e As EventArgs) Handles tmrQuestion1.Tick
        progressCount = progressCount + 1

        ProgressBarQ1.PerformStep()
        If (progressCount = 10) Then
            tmrQuestion1.Enabled = False
            MsgBox("Too Slow Try Again")
            frmQuestion2.Show()
            frmQuestion2.init()
            Me.Hide()
        End If
    End Sub

    Public Sub init()

        progressCount = 0
        tmrQuestion1.Enabled = True
        ProgressBarQ1.Value = 0
        btnAnswer1.Checked = False
        btnAnswer2.Checked = False
        btnAnswer3.Checked = False
        btnAnswer4.Checked = False

    End Sub
End Class