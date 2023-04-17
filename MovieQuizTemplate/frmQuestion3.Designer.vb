<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion3
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
        Me.btnAns1 = New System.Windows.Forms.RadioButton()
        Me.btnAns2 = New System.Windows.Forms.RadioButton()
        Me.btnAns3 = New System.Windows.Forms.RadioButton()
        Me.btnAns4 = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(534, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "The movie Titanic is celebrating its..."
        '
        'btnAns1
        '
        Me.btnAns1.AutoSize = True
        Me.btnAns1.Location = New System.Drawing.Point(418, 122)
        Me.btnAns1.Name = "btnAns1"
        Me.btnAns1.Size = New System.Drawing.Size(117, 17)
        Me.btnAns1.TabIndex = 1
        Me.btnAns1.TabStop = True
        Me.btnAns1.Text = "15 year anniversary"
        Me.btnAns1.UseVisualStyleBackColor = True
        '
        'btnAns2
        '
        Me.btnAns2.AutoSize = True
        Me.btnAns2.Location = New System.Drawing.Point(418, 175)
        Me.btnAns2.Name = "btnAns2"
        Me.btnAns2.Size = New System.Drawing.Size(117, 17)
        Me.btnAns2.TabIndex = 2
        Me.btnAns2.TabStop = True
        Me.btnAns2.Text = "18 year anniversary"
        Me.btnAns2.UseVisualStyleBackColor = True
        '
        'btnAns3
        '
        Me.btnAns3.AutoSize = True
        Me.btnAns3.Location = New System.Drawing.Point(418, 243)
        Me.btnAns3.Name = "btnAns3"
        Me.btnAns3.Size = New System.Drawing.Size(117, 17)
        Me.btnAns3.TabIndex = 3
        Me.btnAns3.TabStop = True
        Me.btnAns3.Text = "22 year anniversary"
        Me.btnAns3.UseVisualStyleBackColor = True
        '
        'btnAns4
        '
        Me.btnAns4.AutoSize = True
        Me.btnAns4.Location = New System.Drawing.Point(418, 302)
        Me.btnAns4.Name = "btnAns4"
        Me.btnAns4.Size = New System.Drawing.Size(117, 17)
        Me.btnAns4.TabIndex = 4
        Me.btnAns4.TabStop = True
        Me.btnAns4.Text = "25 year anniversary"
        Me.btnAns4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MovieQuizTemplate.My.Resources.Resources.Titanic
        Me.PictureBox1.Location = New System.Drawing.Point(59, 113)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(303, 246)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'frmQuestion3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnAns4)
        Me.Controls.Add(Me.btnAns3)
        Me.Controls.Add(Me.btnAns2)
        Me.Controls.Add(Me.btnAns1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQuestion3"
        Me.Text = "frmQuestion3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnAns1 As RadioButton
    Friend WithEvents btnAns2 As RadioButton
    Friend WithEvents btnAns3 As RadioButton
    Friend WithEvents btnAns4 As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
