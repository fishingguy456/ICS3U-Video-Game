<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lakeshore
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lakeshore))
		Me.tmrtextanimation = New System.Windows.Forms.Timer(Me.components)
		Me.lblfirstsentence = New System.Windows.Forms.Label()
		Me.lblsecondsentence = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'tmrtextanimation
		'
		'
		'lblfirstsentence
		'
		Me.lblfirstsentence.AutoSize = True
		Me.lblfirstsentence.BackColor = System.Drawing.Color.Transparent
		Me.lblfirstsentence.Font = New System.Drawing.Font("Microsoft Uighur", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblfirstsentence.ForeColor = System.Drawing.Color.White
		Me.lblfirstsentence.Location = New System.Drawing.Point(350, 74)
		Me.lblfirstsentence.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblfirstsentence.Name = "lblfirstsentence"
		Me.lblfirstsentence.Size = New System.Drawing.Size(450, 68)
		Me.lblfirstsentence.TabIndex = 3
		Me.lblfirstsentence.Text = "Wow. What a beautiful river."
		'
		'lblsecondsentence
		'
		Me.lblsecondsentence.AutoSize = True
		Me.lblsecondsentence.BackColor = System.Drawing.Color.Transparent
		Me.lblsecondsentence.Font = New System.Drawing.Font("Microsoft Uighur", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblsecondsentence.ForeColor = System.Drawing.Color.White
		Me.lblsecondsentence.Location = New System.Drawing.Point(195, 142)
		Me.lblsecondsentence.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblsecondsentence.Name = "lblsecondsentence"
		Me.lblsecondsentence.Size = New System.Drawing.Size(769, 68)
		Me.lblsecondsentence.TabIndex = 4
		Me.lblsecondsentence.Text = "Quite the hidden gem, but how should I get across?"
		'
		'lakeshore
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.KevinISUGame.My.Resources.Resources.home_headshot
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(1122, 751)
		Me.Controls.Add(Me.lblsecondsentence)
		Me.Controls.Add(Me.lblfirstsentence)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.MaximizeBox = False
		Me.MaximumSize = New System.Drawing.Size(1144, 807)
		Me.MinimumSize = New System.Drawing.Size(1144, 807)
		Me.Name = "lakeshore"
		Me.Text = "Stranded in Minnemore"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents tmrtextanimation As Timer
	Friend WithEvents lblfirstsentence As Label
	Friend WithEvents lblsecondsentence As Label
End Class
