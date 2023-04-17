<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHighScore
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnAgain = New System.Windows.Forms.Button()
        Me.IstHighScore = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(772, 31)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Congratulations Your Score Will Be Added To the Hall Of Fame"
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(613, 359)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(107, 55)
        Me.btnQuit.TabIndex = 11
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnAgain
        '
        Me.btnAgain.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgain.Location = New System.Drawing.Point(613, 272)
        Me.btnAgain.Name = "btnAgain"
        Me.btnAgain.Size = New System.Drawing.Size(107, 55)
        Me.btnAgain.TabIndex = 16
        Me.btnAgain.Text = "Again"
        Me.btnAgain.UseVisualStyleBackColor = True
        '
        'IstHighScore
        '
        Me.IstHighScore.FormattingEnabled = True
        Me.IstHighScore.Location = New System.Drawing.Point(256, 113)
        Me.IstHighScore.Name = "IstHighScore"
        Me.IstHighScore.Size = New System.Drawing.Size(237, 277)
        Me.IstHighScore.TabIndex = 17
        '
        'frmHighScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.IstHighScore)
        Me.Controls.Add(Me.btnAgain)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnQuit)
        Me.Name = "frmHighScore"
        Me.Text = "frmHighScore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnAgain As Button
    Friend WithEvents IstHighScore As ListBox
End Class
