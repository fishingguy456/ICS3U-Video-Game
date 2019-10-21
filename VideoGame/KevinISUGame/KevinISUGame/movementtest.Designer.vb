<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class movementtest
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(movementtest))
		Me.picplayer = New System.Windows.Forms.PictureBox()
		Me.tmrup = New System.Windows.Forms.Timer(Me.components)
		Me.tmrdown = New System.Windows.Forms.Timer(Me.components)
		Me.tmrleft = New System.Windows.Forms.Timer(Me.components)
		Me.tmrright = New System.Windows.Forms.Timer(Me.components)
		Me.exitmenustrip = New System.Windows.Forms.MenuStrip()
		Me.WowGreatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.picstablizer = New System.Windows.Forms.PictureBox()
		CType(Me.picplayer, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.exitmenustrip.SuspendLayout()
		CType(Me.picstablizer, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'picplayer
		'
		Me.picplayer.BackColor = System.Drawing.Color.Transparent
		Me.picplayer.Image = Global.KevinISUGame.My.Resources.Resources.facingfront
		Me.picplayer.Location = New System.Drawing.Point(411, 292)
		Me.picplayer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.picplayer.Name = "picplayer"
		Me.picplayer.Size = New System.Drawing.Size(27, 63)
		Me.picplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.picplayer.TabIndex = 0
		Me.picplayer.TabStop = False
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
		'exitmenustrip
		'
		Me.exitmenustrip.ImageScalingSize = New System.Drawing.Size(24, 24)
		Me.exitmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WowGreatToolStripMenuItem})
		Me.exitmenustrip.Location = New System.Drawing.Point(0, 0)
		Me.exitmenustrip.Name = "exitmenustrip"
		Me.exitmenustrip.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
		Me.exitmenustrip.Size = New System.Drawing.Size(890, 35)
		Me.exitmenustrip.TabIndex = 1
		Me.exitmenustrip.Text = "MenuStrip1"
		'
		'WowGreatToolStripMenuItem
		'
		Me.WowGreatToolStripMenuItem.Name = "WowGreatToolStripMenuItem"
		Me.WowGreatToolStripMenuItem.Size = New System.Drawing.Size(121, 29)
		Me.WowGreatToolStripMenuItem.Text = "Wow, Great!"
		'
		'picstablizer
		'
		Me.picstablizer.BackColor = System.Drawing.Color.Transparent
		Me.picstablizer.Location = New System.Drawing.Point(0, 20)
		Me.picstablizer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.picstablizer.Name = "picstablizer"
		Me.picstablizer.Size = New System.Drawing.Size(915, 617)
		Me.picstablizer.TabIndex = 2
		Me.picstablizer.TabStop = False
		'
		'movementtest
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.KevinISUGame.My.Resources.Resources._1_ngSya_x_boD9SlUupI0_kA
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(890, 605)
		Me.Controls.Add(Me.picplayer)
		Me.Controls.Add(Me.exitmenustrip)
		Me.Controls.Add(Me.picstablizer)
		Me.ForeColor = System.Drawing.Color.Black
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.exitmenustrip
		Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.MaximizeBox = False
		Me.MaximumSize = New System.Drawing.Size(912, 661)
		Me.MinimumSize = New System.Drawing.Size(912, 661)
		Me.Name = "movementtest"
		Me.Text = "Stranded in Minnemore"
		CType(Me.picplayer, System.ComponentModel.ISupportInitialize).EndInit()
		Me.exitmenustrip.ResumeLayout(False)
		Me.exitmenustrip.PerformLayout()
		CType(Me.picstablizer, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents picplayer As PictureBox
	Friend WithEvents tmrup As Timer
	Friend WithEvents tmrdown As Timer
	Friend WithEvents tmrleft As Timer
	Friend WithEvents tmrright As Timer
	Friend WithEvents exitmenustrip As MenuStrip
	Friend WithEvents WowGreatToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents picstablizer As PictureBox
End Class
