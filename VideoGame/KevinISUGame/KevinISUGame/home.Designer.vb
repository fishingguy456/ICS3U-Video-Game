<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class home
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
		Me.btnStartGame = New System.Windows.Forms.Button()
		Me.btnControls = New System.Windows.Forms.Button()
		Me.tmranimation = New System.Windows.Forms.Timer(Me.components)
		Me.lbldate = New System.Windows.Forms.Label()
		Me.lblsen1 = New System.Windows.Forms.Label()
		Me.lbllastsen = New System.Windows.Forms.Label()
		Me.tmrmoveup = New System.Windows.Forms.Timer(Me.components)
		Me.btnexit = New System.Windows.Forms.Button()
		Me.lbltitle = New System.Windows.Forms.Label()
		Me.picbackground = New System.Windows.Forms.PictureBox()
		CType(Me.picbackground, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnStartGame
		'
		Me.btnStartGame.BackColor = System.Drawing.Color.ForestGreen
		Me.btnStartGame.Font = New System.Drawing.Font("Microsoft Uighur", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnStartGame.Location = New System.Drawing.Point(420, 1354)
		Me.btnStartGame.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.btnStartGame.Name = "btnStartGame"
		Me.btnStartGame.Size = New System.Drawing.Size(316, 88)
		Me.btnStartGame.TabIndex = 0
		Me.btnStartGame.Text = "Start!"
		Me.btnStartGame.UseVisualStyleBackColor = False
		'
		'btnControls
		'
		Me.btnControls.BackColor = System.Drawing.Color.ForestGreen
		Me.btnControls.Font = New System.Drawing.Font("Microsoft Uighur", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnControls.Location = New System.Drawing.Point(420, 1491)
		Me.btnControls.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.btnControls.Name = "btnControls"
		Me.btnControls.Size = New System.Drawing.Size(316, 88)
		Me.btnControls.TabIndex = 1
		Me.btnControls.Text = "Controls"
		Me.btnControls.UseVisualStyleBackColor = False
		'
		'tmranimation
		'
		'
		'lbldate
		'
		Me.lbldate.AutoSize = True
		Me.lbldate.BackColor = System.Drawing.Color.Transparent
		Me.lbldate.Font = New System.Drawing.Font("Microsoft Uighur", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbldate.ForeColor = System.Drawing.Color.White
		Me.lbldate.Location = New System.Drawing.Point(440, 138)
		Me.lbldate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lbldate.Name = "lbldate"
		Me.lbldate.Size = New System.Drawing.Size(220, 68)
		Me.lbldate.TabIndex = 2
		Me.lbldate.Text = "July 24, 2028"
		'
		'lblsen1
		'
		Me.lblsen1.AutoSize = True
		Me.lblsen1.BackColor = System.Drawing.Color.Transparent
		Me.lblsen1.Font = New System.Drawing.Font("Microsoft Uighur", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblsen1.ForeColor = System.Drawing.Color.White
		Me.lblsen1.Location = New System.Drawing.Point(51, 223)
		Me.lblsen1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblsen1.Name = "lblsen1"
		Me.lblsen1.Size = New System.Drawing.Size(1057, 68)
		Me.lblsen1.TabIndex = 3
		Me.lblsen1.Text = "It has been 2 weeks since I have been stuck in the Forest of Minnemore."
		'
		'lbllastsen
		'
		Me.lbllastsen.AutoSize = True
		Me.lbllastsen.BackColor = System.Drawing.Color.Transparent
		Me.lbllastsen.Font = New System.Drawing.Font("Microsoft Uighur", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbllastsen.ForeColor = System.Drawing.Color.White
		Me.lbllastsen.Location = New System.Drawing.Point(290, 311)
		Me.lbllastsen.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lbllastsen.Name = "lbllastsen"
		Me.lbllastsen.Size = New System.Drawing.Size(565, 68)
		Me.lbllastsen.TabIndex = 4
		Me.lbllastsen.Text = "It’s about time that I get out of here..."
		'
		'tmrmoveup
		'
		Me.tmrmoveup.Interval = 20
		'
		'btnexit
		'
		Me.btnexit.BackColor = System.Drawing.Color.ForestGreen
		Me.btnexit.Font = New System.Drawing.Font("Microsoft Uighur", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnexit.Location = New System.Drawing.Point(420, 1217)
		Me.btnexit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.btnexit.Name = "btnexit"
		Me.btnexit.Size = New System.Drawing.Size(316, 88)
		Me.btnexit.TabIndex = 6
		Me.btnexit.Text = "Exit"
		Me.btnexit.UseVisualStyleBackColor = False
		'
		'lbltitle
		'
		Me.lbltitle.BackColor = System.Drawing.Color.ForestGreen
		Me.lbltitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbltitle.Font = New System.Drawing.Font("Microsoft Uighur", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbltitle.Location = New System.Drawing.Point(-15, 957)
		Me.lbltitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lbltitle.Name = "lbltitle"
		Me.lbltitle.Size = New System.Drawing.Size(1158, 97)
		Me.lbltitle.TabIndex = 7
		Me.lbltitle.Text = "Stranded in Minnemore"
		Me.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'picbackground
		'
		Me.picbackground.Image = Global.KevinISUGame.My.Resources.Resources.forest
		Me.picbackground.Location = New System.Drawing.Point(2, 812)
		Me.picbackground.Name = "picbackground"
		Me.picbackground.Size = New System.Drawing.Size(1130, 835)
		Me.picbackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picbackground.TabIndex = 5
		Me.picbackground.TabStop = False
		'
		'home
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Black
		Me.ClientSize = New System.Drawing.Size(1119, 750)
		Me.Controls.Add(Me.lbltitle)
		Me.Controls.Add(Me.btnexit)
		Me.Controls.Add(Me.lbllastsen)
		Me.Controls.Add(Me.lblsen1)
		Me.Controls.Add(Me.lbldate)
		Me.Controls.Add(Me.btnControls)
		Me.Controls.Add(Me.btnStartGame)
		Me.Controls.Add(Me.picbackground)
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.MaximizeBox = False
		Me.MaximumSize = New System.Drawing.Size(1141, 806)
		Me.MinimumSize = New System.Drawing.Size(1141, 806)
		Me.Name = "home"
		Me.Text = "Stranded in Minnemore"
		CType(Me.picbackground, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnStartGame As Button
    Friend WithEvents btnControls As Button
    Friend WithEvents tmranimation As Timer
    Friend WithEvents lbldate As Label
    Friend WithEvents lblsen1 As Label
    Friend WithEvents lbllastsen As Label
	Friend WithEvents tmrmoveup As Timer
	Friend WithEvents btnexit As Button
	Friend WithEvents picbackground As PictureBox
	Friend WithEvents lbltitle As Label
End Class
