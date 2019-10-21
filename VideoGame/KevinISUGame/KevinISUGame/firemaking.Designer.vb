<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class firemaking
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(firemaking))
		Me.picplough = New System.Windows.Forms.PictureBox()
		Me.picsmooth = New System.Windows.Forms.PictureBox()
		Me.tmrploughspeed = New System.Windows.Forms.Timer(Me.components)
		Me.lblspaceprompt = New System.Windows.Forms.Label()
		Me.tmrwordtime = New System.Windows.Forms.Timer(Me.components)
		Me.picprogressbar = New System.Windows.Forms.PictureBox()
		Me.lblprogress = New System.Windows.Forms.Label()
		Me.picfire = New System.Windows.Forms.PictureBox()
		Me.tmrlastwordtimer = New System.Windows.Forms.Timer(Me.components)
		Me.picblackslide = New System.Windows.Forms.PictureBox()
		Me.btnhome = New System.Windows.Forms.Button()
		CType(Me.picplough, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picsmooth, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picprogressbar, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picfire, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picblackslide, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'picplough
		'
		Me.picplough.BackColor = System.Drawing.Color.Transparent
		Me.picplough.Image = Global.KevinISUGame.My.Resources.Resources.fireploughposition1
		Me.picplough.Location = New System.Drawing.Point(9, 0)
		Me.picplough.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.picplough.Name = "picplough"
		Me.picplough.Size = New System.Drawing.Size(1096, 311)
		Me.picplough.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picplough.TabIndex = 0
		Me.picplough.TabStop = False
		'
		'picsmooth
		'
		Me.picsmooth.BackColor = System.Drawing.Color.Transparent
		Me.picsmooth.Location = New System.Drawing.Point(-4, 0)
		Me.picsmooth.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.picsmooth.Name = "picsmooth"
		Me.picsmooth.Size = New System.Drawing.Size(1128, 742)
		Me.picsmooth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picsmooth.TabIndex = 1
		Me.picsmooth.TabStop = False
		'
		'tmrploughspeed
		'
		Me.tmrploughspeed.Interval = 300
		'
		'lblspaceprompt
		'
		Me.lblspaceprompt.AutoSize = True
		Me.lblspaceprompt.BackColor = System.Drawing.Color.Transparent
		Me.lblspaceprompt.Font = New System.Drawing.Font("Microsoft Uighur", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblspaceprompt.ForeColor = System.Drawing.Color.Transparent
		Me.lblspaceprompt.Location = New System.Drawing.Point(338, 388)
		Me.lblspaceprompt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblspaceprompt.Name = "lblspaceprompt"
		Me.lblspaceprompt.Size = New System.Drawing.Size(449, 63)
		Me.lblspaceprompt.TabIndex = 2
		Me.lblspaceprompt.Text = "Press space to get the fire going!"
		'
		'tmrwordtime
		'
		'
		'picprogressbar
		'
		Me.picprogressbar.BackColor = System.Drawing.Color.YellowGreen
		Me.picprogressbar.Location = New System.Drawing.Point(225, 466)
		Me.picprogressbar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.picprogressbar.Name = "picprogressbar"
		Me.picprogressbar.Size = New System.Drawing.Size(0, 42)
		Me.picprogressbar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picprogressbar.TabIndex = 3
		Me.picprogressbar.TabStop = False
		'
		'lblprogress
		'
		Me.lblprogress.AutoSize = True
		Me.lblprogress.BackColor = System.Drawing.Color.Transparent
		Me.lblprogress.Font = New System.Drawing.Font("Microsoft Uighur", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblprogress.ForeColor = System.Drawing.Color.Transparent
		Me.lblprogress.Location = New System.Drawing.Point(455, 388)
		Me.lblprogress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblprogress.Name = "lblprogress"
		Me.lblprogress.Size = New System.Drawing.Size(203, 63)
		Me.lblprogress.TabIndex = 4
		Me.lblprogress.Text = "Progress: 0%"
		'
		'picfire
		'
		Me.picfire.BackColor = System.Drawing.Color.Transparent
		Me.picfire.Image = Global.KevinISUGame.My.Resources.Resources.fire
		Me.picfire.Location = New System.Drawing.Point(550, 48)
		Me.picfire.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.picfire.Name = "picfire"
		Me.picfire.Size = New System.Drawing.Size(509, 157)
		Me.picfire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picfire.TabIndex = 5
		Me.picfire.TabStop = False
		'
		'tmrlastwordtimer
		'
		'
		'picblackslide
		'
		Me.picblackslide.BackColor = System.Drawing.Color.Black
		Me.picblackslide.Location = New System.Drawing.Point(-1500, 0)
		Me.picblackslide.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.picblackslide.Name = "picblackslide"
		Me.picblackslide.Size = New System.Drawing.Size(1500, 714)
		Me.picblackslide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picblackslide.TabIndex = 6
		Me.picblackslide.TabStop = False
		'
		'btnhome
		'
		Me.btnhome.Location = New System.Drawing.Point(466, 561)
		Me.btnhome.Name = "btnhome"
		Me.btnhome.Size = New System.Drawing.Size(156, 66)
		Me.btnhome.TabIndex = 7
		Me.btnhome.Text = "Home"
		Me.btnhome.UseVisualStyleBackColor = True
		'
		'firemaking
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.KevinISUGame.My.Resources.Resources.forestfloor
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(1107, 705)
		Me.Controls.Add(Me.btnhome)
		Me.Controls.Add(Me.lblprogress)
		Me.Controls.Add(Me.picblackslide)
		Me.Controls.Add(Me.picfire)
		Me.Controls.Add(Me.picprogressbar)
		Me.Controls.Add(Me.lblspaceprompt)
		Me.Controls.Add(Me.picplough)
		Me.Controls.Add(Me.picsmooth)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MaximumSize = New System.Drawing.Size(1129, 761)
		Me.MinimumSize = New System.Drawing.Size(1129, 761)
		Me.Name = "firemaking"
		Me.Text = "Stranded in Minnemore"
		CType(Me.picplough, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picsmooth, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picprogressbar, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picfire, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picblackslide, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents picplough As PictureBox
	Friend WithEvents picsmooth As PictureBox
	Friend WithEvents tmrploughspeed As Timer
	Friend WithEvents lblspaceprompt As Label
	Friend WithEvents tmrwordtime As Timer
	Friend WithEvents picprogressbar As PictureBox
	Friend WithEvents lblprogress As Label
	Friend WithEvents picfire As PictureBox
	Friend WithEvents tmrlastwordtimer As Timer
	Friend WithEvents picblackslide As PictureBox
	Friend WithEvents btnhome As Button
End Class
