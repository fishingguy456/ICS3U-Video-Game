<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class firstworldsecondpart
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(firstworldsecondpart))
		Me.picboundary = New System.Windows.Forms.PictureBox()
		Me.picplayer = New System.Windows.Forms.PictureBox()
		Me.tmrup = New System.Windows.Forms.Timer(Me.components)
		Me.tmrleft = New System.Windows.Forms.Timer(Me.components)
		Me.tmrdown = New System.Windows.Forms.Timer(Me.components)
		Me.tmrright = New System.Windows.Forms.Timer(Me.components)
		Me.picstablizer = New System.Windows.Forms.PictureBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		CType(Me.picboundary, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picplayer, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picstablizer, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'picboundary
		'
		Me.picboundary.BackColor = System.Drawing.Color.Transparent
		Me.picboundary.Location = New System.Drawing.Point(-3, -6)
		Me.picboundary.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.picboundary.Name = "picboundary"
		Me.picboundary.Size = New System.Drawing.Size(1137, 511)
		Me.picboundary.TabIndex = 2
		Me.picboundary.TabStop = False
		'
		'picplayer
		'
		Me.picplayer.BackColor = System.Drawing.Color.Transparent
		Me.picplayer.Location = New System.Drawing.Point(0, 568)
		Me.picplayer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.picplayer.Name = "picplayer"
		Me.picplayer.Size = New System.Drawing.Size(40, 97)
		Me.picplayer.TabIndex = 3
		Me.picplayer.TabStop = False
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
		'picstablizer
		'
		Me.picstablizer.BackColor = System.Drawing.Color.Transparent
		Me.picstablizer.Location = New System.Drawing.Point(0, 497)
		Me.picstablizer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.picstablizer.Name = "picstablizer"
		Me.picstablizer.Size = New System.Drawing.Size(1148, 285)
		Me.picstablizer.TabIndex = 4
		Me.picstablizer.TabStop = False
		'
		'PictureBox1
		'
		Me.PictureBox1.BackgroundImage = Global.KevinISUGame.My.Resources.Resources.Assembly_point_right__96218_1519049359
		Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.PictureBox1.Location = New System.Drawing.Point(814, 578)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(160, 86)
		Me.PictureBox1.TabIndex = 5
		Me.PictureBox1.TabStop = False
		'
		'PictureBox2
		'
		Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
		Me.PictureBox2.BackgroundImage = Global.KevinISUGame.My.Resources.Resources.Bamboo_Stick_PNG_Pic
		Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.PictureBox2.Image = Global.KevinISUGame.My.Resources.Resources.Bamboo_Stick_PNG_Pic
		Me.PictureBox2.Location = New System.Drawing.Point(814, 654)
		Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(150, 105)
		Me.PictureBox2.TabIndex = 6
		Me.PictureBox2.TabStop = False
		'
		'firstworldsecondpart
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.KevinISUGame.My.Resources.Resources.pixel_art_forest_vector_12492952
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(1119, 742)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.PictureBox2)
		Me.Controls.Add(Me.picplayer)
		Me.Controls.Add(Me.picboundary)
		Me.Controls.Add(Me.picstablizer)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.MaximizeBox = False
		Me.MaximumSize = New System.Drawing.Size(1141, 798)
		Me.MinimumSize = New System.Drawing.Size(1141, 798)
		Me.Name = "firstworldsecondpart"
		Me.Text = "Stranded in Minnemore"
		CType(Me.picboundary, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picplayer, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picstablizer, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents picboundary As PictureBox
	Friend WithEvents picplayer As PictureBox
	Friend WithEvents tmrup As Timer
	Friend WithEvents tmrleft As Timer
	Friend WithEvents tmrdown As Timer
	Friend WithEvents tmrright As Timer
	Friend WithEvents picstablizer As PictureBox
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents PictureBox2 As PictureBox
End Class
