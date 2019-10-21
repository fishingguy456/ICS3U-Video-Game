<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class walkingintoshooter
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(walkingintoshooter))
		Me.picplayer = New System.Windows.Forms.PictureBox()
		Me.picendoftheroad = New System.Windows.Forms.PictureBox()
		Me.picboundary1 = New System.Windows.Forms.PictureBox()
		Me.picboundary2 = New System.Windows.Forms.PictureBox()
		Me.picboundary3 = New System.Windows.Forms.PictureBox()
		Me.picboundary4 = New System.Windows.Forms.PictureBox()
		Me.picboundary5 = New System.Windows.Forms.PictureBox()
		Me.picboundary6 = New System.Windows.Forms.PictureBox()
		Me.picboundary7 = New System.Windows.Forms.PictureBox()
		Me.tmrup = New System.Windows.Forms.Timer(Me.components)
		Me.tmrdown = New System.Windows.Forms.Timer(Me.components)
		Me.tmrleft = New System.Windows.Forms.Timer(Me.components)
		Me.tmrright = New System.Windows.Forms.Timer(Me.components)
		Me.tmrgamelogic = New System.Windows.Forms.Timer(Me.components)
		Me.picsmooth = New System.Windows.Forms.PictureBox()
		Me.picwalkhere = New System.Windows.Forms.Label()
		CType(Me.picplayer, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picendoftheroad, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picboundary1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picboundary2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picboundary3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picboundary4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picboundary5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picboundary6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picboundary7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picsmooth, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'picplayer
		'
		Me.picplayer.BackColor = System.Drawing.Color.Transparent
		Me.picplayer.Image = Global.KevinISUGame.My.Resources.Resources.facingback
		Me.picplayer.Location = New System.Drawing.Point(380, 427)
		Me.picplayer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.picplayer.Name = "picplayer"
		Me.picplayer.Size = New System.Drawing.Size(18, 41)
		Me.picplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picplayer.TabIndex = 0
		Me.picplayer.TabStop = False
		'
		'picendoftheroad
		'
		Me.picendoftheroad.BackColor = System.Drawing.Color.Transparent
		Me.picendoftheroad.Location = New System.Drawing.Point(380, 304)
		Me.picendoftheroad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.picendoftheroad.Name = "picendoftheroad"
		Me.picendoftheroad.Size = New System.Drawing.Size(68, 34)
		Me.picendoftheroad.TabIndex = 1
		Me.picendoftheroad.TabStop = False
		'
		'picboundary1
		'
		Me.picboundary1.BackColor = System.Drawing.Color.Transparent
		Me.picboundary1.Location = New System.Drawing.Point(-3, -3)
		Me.picboundary1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.picboundary1.Name = "picboundary1"
		Me.picboundary1.Size = New System.Drawing.Size(746, 303)
		Me.picboundary1.TabIndex = 2
		Me.picboundary1.TabStop = False
		'
		'picboundary2
		'
		Me.picboundary2.BackColor = System.Drawing.Color.Transparent
		Me.picboundary2.Location = New System.Drawing.Point(-3, 294)
		Me.picboundary2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.picboundary2.Name = "picboundary2"
		Me.picboundary2.Size = New System.Drawing.Size(245, 123)
		Me.picboundary2.TabIndex = 4
		Me.picboundary2.TabStop = False
		'
		'picboundary3
		'
		Me.picboundary3.BackColor = System.Drawing.Color.Transparent
		Me.picboundary3.Location = New System.Drawing.Point(-3, 413)
		Me.picboundary3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.picboundary3.Name = "picboundary3"
		Me.picboundary3.Size = New System.Drawing.Size(118, 64)
		Me.picboundary3.TabIndex = 5
		Me.picboundary3.TabStop = False
		'
		'picboundary4
		'
		Me.picboundary4.BackColor = System.Drawing.Color.Transparent
		Me.picboundary4.Location = New System.Drawing.Point(237, 294)
		Me.picboundary4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.picboundary4.Name = "picboundary4"
		Me.picboundary4.Size = New System.Drawing.Size(134, 73)
		Me.picboundary4.TabIndex = 6
		Me.picboundary4.TabStop = False
		'
		'picboundary5
		'
		Me.picboundary5.BackColor = System.Drawing.Color.Transparent
		Me.picboundary5.Location = New System.Drawing.Point(668, 294)
		Me.picboundary5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.picboundary5.Name = "picboundary5"
		Me.picboundary5.Size = New System.Drawing.Size(83, 133)
		Me.picboundary5.TabIndex = 7
		Me.picboundary5.TabStop = False
		'
		'picboundary6
		'
		Me.picboundary6.BackColor = System.Drawing.Color.Transparent
		Me.picboundary6.Location = New System.Drawing.Point(452, 289)
		Me.picboundary6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.picboundary6.Name = "picboundary6"
		Me.picboundary6.Size = New System.Drawing.Size(220, 58)
		Me.picboundary6.TabIndex = 8
		Me.picboundary6.TabStop = False
		'
		'picboundary7
		'
		Me.picboundary7.BackColor = System.Drawing.Color.Transparent
		Me.picboundary7.Location = New System.Drawing.Point(508, 341)
		Me.picboundary7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.picboundary7.Name = "picboundary7"
		Me.picboundary7.Size = New System.Drawing.Size(57, 60)
		Me.picboundary7.TabIndex = 9
		Me.picboundary7.TabStop = False
		'
		'tmrup
		'
		'
		'tmrdown
		'
		'
		'tmrleft
		'
		'
		'tmrright
		'
		'
		'tmrgamelogic
		'
		'
		'picsmooth
		'
		Me.picsmooth.BackColor = System.Drawing.Color.Transparent
		Me.picsmooth.Location = New System.Drawing.Point(-3, 181)
		Me.picsmooth.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.picsmooth.Name = "picsmooth"
		Me.picsmooth.Size = New System.Drawing.Size(746, 303)
		Me.picsmooth.TabIndex = 10
		Me.picsmooth.TabStop = False
		'
		'picwalkhere
		'
		Me.picwalkhere.AutoSize = True
		Me.picwalkhere.BackColor = System.Drawing.Color.Transparent
		Me.picwalkhere.Font = New System.Drawing.Font("Microsoft Uighur", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picwalkhere.ForeColor = System.Drawing.Color.White
		Me.picwalkhere.Location = New System.Drawing.Point(376, 289)
		Me.picwalkhere.Name = "picwalkhere"
		Me.picwalkhere.Size = New System.Drawing.Size(60, 23)
		Me.picwalkhere.TabIndex = 11
		Me.picwalkhere.Text = "Walk here!"
		'
		'walkingintoshooter
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.KevinISUGame.My.Resources.Resources.forestatnight
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(748, 487)
		Me.Controls.Add(Me.picwalkhere)
		Me.Controls.Add(Me.picplayer)
		Me.Controls.Add(Me.picboundary7)
		Me.Controls.Add(Me.picboundary6)
		Me.Controls.Add(Me.picboundary5)
		Me.Controls.Add(Me.picboundary4)
		Me.Controls.Add(Me.picboundary3)
		Me.Controls.Add(Me.picboundary2)
		Me.Controls.Add(Me.picboundary1)
		Me.Controls.Add(Me.picendoftheroad)
		Me.Controls.Add(Me.picsmooth)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.MaximizeBox = False
		Me.MaximumSize = New System.Drawing.Size(764, 526)
		Me.MinimumSize = New System.Drawing.Size(764, 526)
		Me.Name = "walkingintoshooter"
		Me.Text = "Stranded in Minnemore"
		CType(Me.picplayer, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picendoftheroad, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picboundary1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picboundary2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picboundary3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picboundary4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picboundary5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picboundary6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picboundary7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picsmooth, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents picplayer As PictureBox
	Friend WithEvents picendoftheroad As PictureBox
	Friend WithEvents picboundary1 As PictureBox
	Friend WithEvents picboundary2 As PictureBox
	Friend WithEvents picboundary3 As PictureBox
	Friend WithEvents picboundary4 As PictureBox
	Friend WithEvents picboundary5 As PictureBox
	Friend WithEvents picboundary6 As PictureBox
	Friend WithEvents picboundary7 As PictureBox
	Friend WithEvents tmrup As Timer
	Friend WithEvents tmrdown As Timer
	Friend WithEvents tmrleft As Timer
	Friend WithEvents tmrright As Timer
	Friend WithEvents tmrgamelogic As Timer
	Friend WithEvents picsmooth As PictureBox
	Friend WithEvents picwalkhere As Label
End Class
