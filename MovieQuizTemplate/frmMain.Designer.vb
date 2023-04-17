<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBarQ1 = New System.Windows.Forms.ProgressBar()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tmrQuestion1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(1023, 301)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(166, 68)
        Me.btnQuit.TabIndex = 0
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        Me.btnQuit.UseWaitCursor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(1023, 383)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(166, 68)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        Me.btnStart.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(530, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 76)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Movie Quiz"
        '
        'ProgressBarQ1
        '
        Me.ProgressBarQ1.Location = New System.Drawing.Point(518, 301)
        Me.ProgressBarQ1.Name = "ProgressBarQ1"
        Me.ProgressBarQ1.Size = New System.Drawing.Size(378, 23)
        Me.ProgressBarQ1.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(518, 330)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(378, 38)
        Me.txtName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(327, 333)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 31)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Player Name"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.MovieQuizTemplate.My.Resources.Resources.image_2
        Me.PictureBox5.Location = New System.Drawing.Point(214, 12)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(184, 272)
        Me.PictureBox5.TabIndex = 10
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.MovieQuizTemplate.My.Resources.Resources.image_3
        Me.PictureBox4.Location = New System.Drawing.Point(620, 104)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(138, 180)
        Me.PictureBox4.TabIndex = 9
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.MovieQuizTemplate.My.Resources.Resources.image_5
        Me.PictureBox3.Location = New System.Drawing.Point(1235, 131)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(184, 272)
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.MovieQuizTemplate.My.Resources.Resources.image_4
        Me.PictureBox2.Location = New System.Drawing.Point(914, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(184, 272)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MovieQuizTemplate.My.Resources.Resources.image_1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 272)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'tmrQuestion1
        '
        Me.tmrQuestion1.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1425, 475)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.ProgressBarQ1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnQuit)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnQuit As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBarQ1 As ProgressBar
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents tmrQuestion1 As Timer
End Class
