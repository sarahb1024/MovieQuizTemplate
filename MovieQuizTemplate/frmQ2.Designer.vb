<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQ2
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAns1 = New System.Windows.Forms.RadioButton()
        Me.btnAns2 = New System.Windows.Forms.RadioButton()
        Me.btnAns3 = New System.Windows.Forms.RadioButton()
        Me.btnAns4 = New System.Windows.Forms.RadioButton()
        Me.btnNext = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(808, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "What year did Chris have a 'minor' altercation with Will?"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MovieQuizTemplate.My.Resources.Resources.Chris_Will
        Me.PictureBox1.Location = New System.Drawing.Point(43, 111)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(337, 245)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnAns1
        '
        Me.btnAns1.AutoSize = True
        Me.btnAns1.Location = New System.Drawing.Point(474, 117)
        Me.btnAns1.Name = "btnAns1"
        Me.btnAns1.Size = New System.Drawing.Size(49, 17)
        Me.btnAns1.TabIndex = 2
        Me.btnAns1.TabStop = True
        Me.btnAns1.Text = "2020"
        Me.btnAns1.UseVisualStyleBackColor = True
        '
        'btnAns2
        '
        Me.btnAns2.AutoSize = True
        Me.btnAns2.Location = New System.Drawing.Point(474, 189)
        Me.btnAns2.Name = "btnAns2"
        Me.btnAns2.Size = New System.Drawing.Size(49, 17)
        Me.btnAns2.TabIndex = 3
        Me.btnAns2.TabStop = True
        Me.btnAns2.Text = "2021"
        Me.btnAns2.UseVisualStyleBackColor = True
        '
        'btnAns3
        '
        Me.btnAns3.AutoSize = True
        Me.btnAns3.Location = New System.Drawing.Point(474, 265)
        Me.btnAns3.Name = "btnAns3"
        Me.btnAns3.Size = New System.Drawing.Size(49, 17)
        Me.btnAns3.TabIndex = 4
        Me.btnAns3.TabStop = True
        Me.btnAns3.Text = "2022"
        Me.btnAns3.UseVisualStyleBackColor = True
        '
        'btnAns4
        '
        Me.btnAns4.AutoSize = True
        Me.btnAns4.Location = New System.Drawing.Point(474, 339)
        Me.btnAns4.Name = "btnAns4"
        Me.btnAns4.Size = New System.Drawing.Size(49, 17)
        Me.btnAns4.TabIndex = 5
        Me.btnAns4.TabStop = True
        Me.btnAns4.Text = "2023"
        Me.btnAns4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAns4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAns4.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(651, 332)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(133, 44)
        Me.btnNext.TabIndex = 6
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'frmQ2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 472)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnAns4)
        Me.Controls.Add(Me.btnAns3)
        Me.Controls.Add(Me.btnAns2)
        Me.Controls.Add(Me.btnAns1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQ2"
        Me.Text = "frmQ2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAns1 As RadioButton
    Friend WithEvents btnAns2 As RadioButton
    Friend WithEvents btnAns3 As RadioButton
    Friend WithEvents btnAns4 As RadioButton
    Friend WithEvents btnNext As Button
End Class
