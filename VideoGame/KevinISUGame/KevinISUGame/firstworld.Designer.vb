<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class firstworld
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(firstworld))
		Me.picplayer = New System.Windows.Forms.PictureBox()
		Me.tmrstandingup = New System.Windows.Forms.Timer(Me.components)
		Me.tmrup = New System.Windows.Forms.Timer(Me.components)
		Me.tmrleft = New System.Windows.Forms.Timer(Me.components)
		Me.tmrdown = New System.Windows.Forms.Timer(Me.components)
		Me.tmrright = New System.Windows.Forms.Timer(Me.components)
		Me.picboundary = New System.Windows.Forms.PictureBox()
		Me.picstablizer = New System.Windows.Forms.PictureBox()
		CType(Me.picplayer, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picboundary, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picstablizer, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'picplayer
		'
		Me.picplayer.BackColor = System.Drawing.Color.Transparent
		Me.picplayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.picplayer.Image = Global.KevinISUGame.My.Resources.Resources.lyingdown
		Me.picplayer.Location = New System.Drawing.Point(126, 628)
		Me.picplayer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.picplayer.Name = "picplayer"
		Me.picplayer.Size = New System.Drawing.Size(90, 48)
		Me.picplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picplayer.TabIndex = 0
		Me.picplayer.TabStop = False
		'
		'tmrstandingup
		'
		Me.tmrstandingup.Interval = 200
		'
		'tmrup
		'
		'
		'tmrleft
		'
		'
		'tmrdown
		'
		'
		'tmrright
		'
		'
		'picboundary
		'
		Me.picboundary.BackColor = System.Drawing.Color.Transparent
		Me.picboundary.Location = New System.Drawing.Point(-3, -6)
		Me.picboundary.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.picboundary.Name = "picboundary"
		Me.picboundary.Size = New System.Drawing.Size(1137, 511)
		Me.picboundary.TabIndex = 1
		Me.picboundary.TabStop = False
		'
		'picstablizer
		'
		Me.picstablizer.BackColor = System.Drawing.Color.Transparent
		Me.picstablizer.Location = New System.Drawing.Point(-3, 482)
		Me.picstablizer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.picstablizer.Name = "picstablizer"
		Me.picstablizer.Size = New System.Drawing.Size(1150, 298)
		Me.picstablizer.TabIndex = 2
		Me.picstablizer.TabStop = False
		'
		'firstworld
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.KevinISUGame.My.Resources.Resources.pixel_art_forest_vector_12492952
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(1122, 751)
		Me.Controls.Add(Me.picboundary)
		Me.Controls.Add(Me.picplayer)
		Me.Controls.Add(Me.picstablizer)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.MaximizeBox = False
		Me.MaximumSize = New System.Drawing.Size(1144, 807)
		Me.MinimumSize = New System.Drawing.Size(1144, 807)
		Me.Name = "firstworld"
		Me.Text = "Stranded in Minnemore"
		CType(Me.picplayer, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picboundary, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picstablizer, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents picplayer As PictureBox
	Friend WithEvents tmrstandingup As Timer
	Friend WithEvents tmrup As Timer
	Friend WithEvents tmrleft As Timer
	Friend WithEvents tmrdown As Timer
	Friend WithEvents tmrright As Timer
	Friend WithEvents picboundary As PictureBox
	Friend WithEvents picstablizer As PictureBox
End Class
