<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class shooterlevel
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(shooterlevel))
		Me.lblstartingtext = New System.Windows.Forms.Label()
		Me.tmrtextdisplay = New System.Windows.Forms.Timer(Me.components)
		Me.picplayer = New System.Windows.Forms.PictureBox()
		Me.lblrotateleft = New System.Windows.Forms.Label()
		Me.lblrotateright = New System.Windows.Forms.Label()
		Me.lblshoot = New System.Windows.Forms.Label()
		Me.picwolf2 = New System.Windows.Forms.PictureBox()
		Me.picwolf3 = New System.Windows.Forms.PictureBox()
		Me.picwolf4 = New System.Windows.Forms.PictureBox()
		Me.picwolf1 = New System.Windows.Forms.PictureBox()
		Me.picrockup = New System.Windows.Forms.PictureBox()
		Me.picrockdown = New System.Windows.Forms.PictureBox()
		Me.picrockright = New System.Windows.Forms.PictureBox()
		Me.picrockleft = New System.Windows.Forms.PictureBox()
		Me.picrockdirection = New System.Windows.Forms.PictureBox()
		Me.tmrrockmovingup = New System.Windows.Forms.Timer(Me.components)
		Me.tmrrockmovingright = New System.Windows.Forms.Timer(Me.components)
		Me.tmrrockmovingdown = New System.Windows.Forms.Timer(Me.components)
		Me.tmrrockmovingleft = New System.Windows.Forms.Timer(Me.components)
		Me.tmrwolfmovedown = New System.Windows.Forms.Timer(Me.components)
		Me.tmrwolfmoveleft = New System.Windows.Forms.Timer(Me.components)
		Me.tmrwolfmoveup = New System.Windows.Forms.Timer(Me.components)
		Me.tmrwolfmoveright = New System.Windows.Forms.Timer(Me.components)
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.tmrfinaltext = New System.Windows.Forms.Timer(Me.components)
		Me.lblwolvesgone = New System.Windows.Forms.Label()
		CType(Me.picplayer, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picwolf2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picwolf3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picwolf4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picwolf1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picrockup, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picrockdown, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picrockright, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picrockleft, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picrockdirection, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'lblstartingtext
		'
		Me.lblstartingtext.AutoSize = True
		Me.lblstartingtext.BackColor = System.Drawing.Color.Transparent
		Me.lblstartingtext.Font = New System.Drawing.Font("Microsoft Uighur", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblstartingtext.ForeColor = System.Drawing.Color.White
		Me.lblstartingtext.Location = New System.Drawing.Point(322, 223)
		Me.lblstartingtext.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblstartingtext.Name = "lblstartingtext"
		Me.lblstartingtext.Size = New System.Drawing.Size(430, 68)
		Me.lblstartingtext.TabIndex = 3
		Me.lblstartingtext.Text = "I've got to rest for the night."
		'
		'tmrtextdisplay
		'
		'
		'picplayer
		'
		Me.picplayer.Image = Global.KevinISUGame.My.Resources.Resources.abovestraight
		Me.picplayer.Location = New System.Drawing.Point(528, 340)
		Me.picplayer.Name = "picplayer"
		Me.picplayer.Size = New System.Drawing.Size(50, 49)
		Me.picplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picplayer.TabIndex = 4
		Me.picplayer.TabStop = False
		'
		'lblrotateleft
		'
		Me.lblrotateleft.AutoSize = True
		Me.lblrotateleft.BackColor = System.Drawing.Color.Transparent
		Me.lblrotateleft.Font = New System.Drawing.Font("Microsoft Uighur", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblrotateleft.ForeColor = System.Drawing.Color.White
		Me.lblrotateleft.Location = New System.Drawing.Point(332, 111)
		Me.lblrotateleft.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblrotateleft.Name = "lblrotateleft"
		Me.lblrotateleft.Size = New System.Drawing.Size(219, 68)
		Me.lblrotateleft.TabIndex = 5
		Me.lblrotateleft.Text = "A - Turn Left"
		'
		'lblrotateright
		'
		Me.lblrotateright.AutoSize = True
		Me.lblrotateright.BackColor = System.Drawing.Color.Transparent
		Me.lblrotateright.Font = New System.Drawing.Font("Microsoft Uighur", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblrotateright.ForeColor = System.Drawing.Color.White
		Me.lblrotateright.Location = New System.Drawing.Point(332, 178)
		Me.lblrotateright.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblrotateright.Name = "lblrotateright"
		Me.lblrotateright.Size = New System.Drawing.Size(237, 68)
		Me.lblrotateright.TabIndex = 6
		Me.lblrotateright.Text = "S - Turn Right"
		'
		'lblshoot
		'
		Me.lblshoot.AutoSize = True
		Me.lblshoot.BackColor = System.Drawing.Color.Transparent
		Me.lblshoot.Font = New System.Drawing.Font("Microsoft Uighur", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblshoot.ForeColor = System.Drawing.Color.White
		Me.lblshoot.Location = New System.Drawing.Point(332, 257)
		Me.lblshoot.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblshoot.Name = "lblshoot"
		Me.lblshoot.Size = New System.Drawing.Size(271, 68)
		Me.lblshoot.TabIndex = 7
		Me.lblshoot.Text = "Spacebar - Shoot"
		'
		'picwolf2
		'
		Me.picwolf2.BackColor = System.Drawing.Color.Transparent
		Me.picwolf2.Image = Global.KevinISUGame.My.Resources.Resources.wolfright
		Me.picwolf2.Location = New System.Drawing.Point(1143, 345)
		Me.picwolf2.Name = "picwolf2"
		Me.picwolf2.Size = New System.Drawing.Size(90, 35)
		Me.picwolf2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picwolf2.TabIndex = 9
		Me.picwolf2.TabStop = False
		'
		'picwolf3
		'
		Me.picwolf3.BackColor = System.Drawing.Color.Transparent
		Me.picwolf3.Image = Global.KevinISUGame.My.Resources.Resources.wolfup
		Me.picwolf3.Location = New System.Drawing.Point(543, 769)
		Me.picwolf3.Name = "picwolf3"
		Me.picwolf3.Size = New System.Drawing.Size(34, 92)
		Me.picwolf3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picwolf3.TabIndex = 11
		Me.picwolf3.TabStop = False
		'
		'picwolf4
		'
		Me.picwolf4.BackColor = System.Drawing.Color.Transparent
		Me.picwolf4.Image = Global.KevinISUGame.My.Resources.Resources.wolfleft
		Me.picwolf4.Location = New System.Drawing.Point(-90, 342)
		Me.picwolf4.Name = "picwolf4"
		Me.picwolf4.Size = New System.Drawing.Size(90, 35)
		Me.picwolf4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picwolf4.TabIndex = 13
		Me.picwolf4.TabStop = False
		'
		'picwolf1
		'
		Me.picwolf1.BackColor = System.Drawing.Color.Transparent
		Me.picwolf1.Image = Global.KevinISUGame.My.Resources.Resources.wolfdown
		Me.picwolf1.Location = New System.Drawing.Point(543, -92)
		Me.picwolf1.Name = "picwolf1"
		Me.picwolf1.Size = New System.Drawing.Size(34, 92)
		Me.picwolf1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picwolf1.TabIndex = 14
		Me.picwolf1.TabStop = False
		'
		'picrockup
		'
		Me.picrockup.BackColor = System.Drawing.Color.Transparent
		Me.picrockup.Image = Global.KevinISUGame.My.Resources.Resources.rock
		Me.picrockup.Location = New System.Drawing.Point(537, 352)
		Me.picrockup.Name = "picrockup"
		Me.picrockup.Size = New System.Drawing.Size(32, 28)
		Me.picrockup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picrockup.TabIndex = 16
		Me.picrockup.TabStop = False
		'
		'picrockdown
		'
		Me.picrockdown.BackColor = System.Drawing.Color.Transparent
		Me.picrockdown.Image = Global.KevinISUGame.My.Resources.Resources.rock
		Me.picrockdown.Location = New System.Drawing.Point(537, 352)
		Me.picrockdown.Name = "picrockdown"
		Me.picrockdown.Size = New System.Drawing.Size(32, 28)
		Me.picrockdown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picrockdown.TabIndex = 17
		Me.picrockdown.TabStop = False
		'
		'picrockright
		'
		Me.picrockright.BackColor = System.Drawing.Color.Transparent
		Me.picrockright.Image = Global.KevinISUGame.My.Resources.Resources.rock
		Me.picrockright.Location = New System.Drawing.Point(537, 352)
		Me.picrockright.Name = "picrockright"
		Me.picrockright.Size = New System.Drawing.Size(32, 28)
		Me.picrockright.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picrockright.TabIndex = 20
		Me.picrockright.TabStop = False
		'
		'picrockleft
		'
		Me.picrockleft.BackColor = System.Drawing.Color.Transparent
		Me.picrockleft.Image = Global.KevinISUGame.My.Resources.Resources.rock
		Me.picrockleft.Location = New System.Drawing.Point(537, 352)
		Me.picrockleft.Name = "picrockleft"
		Me.picrockleft.Size = New System.Drawing.Size(32, 28)
		Me.picrockleft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picrockleft.TabIndex = 21
		Me.picrockleft.TabStop = False
		'
		'picrockdirection
		'
		Me.picrockdirection.BackColor = System.Drawing.Color.Transparent
		Me.picrockdirection.Image = Global.KevinISUGame.My.Resources.Resources.rock
		Me.picrockdirection.Location = New System.Drawing.Point(546, 312)
		Me.picrockdirection.Name = "picrockdirection"
		Me.picrockdirection.Size = New System.Drawing.Size(32, 28)
		Me.picrockdirection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picrockdirection.TabIndex = 22
		Me.picrockdirection.TabStop = False
		'
		'tmrrockmovingup
		'
		Me.tmrrockmovingup.Interval = 10
		'
		'tmrrockmovingright
		'
		Me.tmrrockmovingright.Interval = 10
		'
		'tmrrockmovingdown
		'
		Me.tmrrockmovingdown.Interval = 10
		'
		'tmrrockmovingleft
		'
		Me.tmrrockmovingleft.Interval = 10
		'
		'tmrwolfmovedown
		'
		Me.tmrwolfmovedown.Interval = 7
		'
		'tmrwolfmoveleft
		'
		Me.tmrwolfmoveleft.Interval = 7
		'
		'tmrwolfmoveup
		'
		Me.tmrwolfmoveup.Interval = 7
		'
		'tmrwolfmoveright
		'
		Me.tmrwolfmoveright.Interval = 7
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
		Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(1128, 763)
		Me.PictureBox1.TabIndex = 23
		Me.PictureBox1.TabStop = False
		'
		'tmrfinaltext
		'
		'
		'lblwolvesgone
		'
		Me.lblwolvesgone.AutoSize = True
		Me.lblwolvesgone.BackColor = System.Drawing.Color.Transparent
		Me.lblwolvesgone.Font = New System.Drawing.Font("Microsoft Uighur", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblwolvesgone.ForeColor = System.Drawing.Color.White
		Me.lblwolvesgone.Location = New System.Drawing.Point(213, 245)
		Me.lblwolvesgone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblwolvesgone.Name = "lblwolvesgone"
		Me.lblwolvesgone.Size = New System.Drawing.Size(790, 63)
		Me.lblwolvesgone.TabIndex = 24
		Me.lblwolvesgone.Text = "The wolves are gone... It's so cold... I need to build a fire..."
		'
		'shooterlevel
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.KevinISUGame.My.Resources.Resources.forestfloor
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(1107, 705)
		Me.Controls.Add(Me.picplayer)
		Me.Controls.Add(Me.picrockdirection)
		Me.Controls.Add(Me.picrockleft)
		Me.Controls.Add(Me.picrockright)
		Me.Controls.Add(Me.picrockdown)
		Me.Controls.Add(Me.picrockup)
		Me.Controls.Add(Me.picwolf1)
		Me.Controls.Add(Me.picwolf4)
		Me.Controls.Add(Me.picwolf3)
		Me.Controls.Add(Me.picwolf2)
		Me.Controls.Add(Me.lblshoot)
		Me.Controls.Add(Me.lblrotateright)
		Me.Controls.Add(Me.lblrotateleft)
		Me.Controls.Add(Me.lblstartingtext)
		Me.Controls.Add(Me.lblwolvesgone)
		Me.Controls.Add(Me.PictureBox1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MaximumSize = New System.Drawing.Size(1129, 761)
		Me.MinimumSize = New System.Drawing.Size(1129, 761)
		Me.Name = "shooterlevel"
		Me.Text = "Stranded in Minnemore"
		CType(Me.picplayer, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picwolf2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picwolf3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picwolf4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picwolf1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picrockup, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picrockdown, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picrockright, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picrockleft, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picrockdirection, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblstartingtext As Label
	Friend WithEvents tmrtextdisplay As Timer
	Friend WithEvents picplayer As PictureBox
	Friend WithEvents lblrotateleft As Label
	Friend WithEvents lblrotateright As Label
	Friend WithEvents lblshoot As Label
	Friend WithEvents picwolf2 As PictureBox
	Friend WithEvents picwolf3 As PictureBox
	Friend WithEvents picwolf4 As PictureBox
	Friend WithEvents picwolf1 As PictureBox
	Friend WithEvents picrockup As PictureBox
	Friend WithEvents picrockdown As PictureBox
	Friend WithEvents picrockright As PictureBox
	Friend WithEvents picrockleft As PictureBox
	Friend WithEvents picrockdirection As PictureBox
	Friend WithEvents tmrrockmovingup As Timer
	Friend WithEvents tmrrockmovingright As Timer
	Friend WithEvents tmrrockmovingdown As Timer
	Friend WithEvents tmrrockmovingleft As Timer
	Friend WithEvents tmrwolfmovedown As Timer
	Friend WithEvents tmrwolfmoveleft As Timer
	Friend WithEvents tmrwolfmoveup As Timer
	Friend WithEvents tmrwolfmoveright As Timer
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents tmrfinaltext As Timer
	Friend WithEvents lblwolvesgone As Label
End Class
