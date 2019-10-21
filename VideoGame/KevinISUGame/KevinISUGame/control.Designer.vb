<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class control
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(control))
		Me.btnGotit = New System.Windows.Forms.Button()
		Me.lblup = New System.Windows.Forms.Label()
		Me.lbldown = New System.Windows.Forms.Label()
		Me.lblright = New System.Windows.Forms.Label()
		Me.lblleft = New System.Windows.Forms.Label()
		Me.lblspace = New System.Windows.Forms.Label()
		Me.btntryitout = New System.Windows.Forms.Button()
		Me.tmrwalking = New System.Windows.Forms.Timer(Me.components)
		Me.picup = New System.Windows.Forms.PictureBox()
		Me.picleft = New System.Windows.Forms.PictureBox()
		Me.picright = New System.Windows.Forms.PictureBox()
		Me.picdown = New System.Windows.Forms.PictureBox()
		CType(Me.picup, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picleft, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picright, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picdown, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnGotit
		'
		Me.btnGotit.BackColor = System.Drawing.Color.ForestGreen
		Me.btnGotit.Font = New System.Drawing.Font("Microsoft Uighur", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnGotit.ForeColor = System.Drawing.Color.White
		Me.btnGotit.Location = New System.Drawing.Point(102, 495)
		Me.btnGotit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.btnGotit.Name = "btnGotit"
		Me.btnGotit.Size = New System.Drawing.Size(202, 62)
		Me.btnGotit.TabIndex = 0
		Me.btnGotit.Text = "OK, got it!"
		Me.btnGotit.UseVisualStyleBackColor = False
		'
		'lblup
		'
		Me.lblup.AutoSize = True
		Me.lblup.BackColor = System.Drawing.Color.Transparent
		Me.lblup.Font = New System.Drawing.Font("Microsoft Uighur", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblup.ForeColor = System.Drawing.Color.White
		Me.lblup.Location = New System.Drawing.Point(194, 25)
		Me.lblup.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblup.Name = "lblup"
		Me.lblup.Size = New System.Drawing.Size(155, 48)
		Me.lblup.TabIndex = 1
		Me.lblup.Text = "W - Move Up"
		'
		'lbldown
		'
		Me.lbldown.AutoSize = True
		Me.lbldown.BackColor = System.Drawing.Color.Transparent
		Me.lbldown.Font = New System.Drawing.Font("Microsoft Uighur", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbldown.ForeColor = System.Drawing.Color.White
		Me.lbldown.Location = New System.Drawing.Point(194, 229)
		Me.lbldown.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lbldown.Name = "lbldown"
		Me.lbldown.Size = New System.Drawing.Size(175, 48)
		Me.lbldown.TabIndex = 2
		Me.lbldown.Text = "S - Move Down"
		'
		'lblright
		'
		Me.lblright.AutoSize = True
		Me.lblright.BackColor = System.Drawing.Color.Transparent
		Me.lblright.Font = New System.Drawing.Font("Microsoft Uighur", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblright.ForeColor = System.Drawing.Color.White
		Me.lblright.Location = New System.Drawing.Point(194, 326)
		Me.lblright.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblright.Name = "lblright"
		Me.lblright.Size = New System.Drawing.Size(176, 48)
		Me.lblright.TabIndex = 3
		Me.lblright.Text = "D - Move Right"
		'
		'lblleft
		'
		Me.lblleft.AutoSize = True
		Me.lblleft.BackColor = System.Drawing.Color.Transparent
		Me.lblleft.Font = New System.Drawing.Font("Microsoft Uighur", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblleft.ForeColor = System.Drawing.Color.White
		Me.lblleft.Location = New System.Drawing.Point(194, 125)
		Me.lblleft.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblleft.Name = "lblleft"
		Me.lblleft.Size = New System.Drawing.Size(157, 48)
		Me.lblleft.TabIndex = 4
		Me.lblleft.Text = "A - Move Left"
		'
		'lblspace
		'
		Me.lblspace.AutoSize = True
		Me.lblspace.BackColor = System.Drawing.Color.Transparent
		Me.lblspace.Font = New System.Drawing.Font("Microsoft Uighur", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblspace.ForeColor = System.Drawing.Color.White
		Me.lblspace.Location = New System.Drawing.Point(194, 418)
		Me.lblspace.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblspace.Name = "lblspace"
		Me.lblspace.Size = New System.Drawing.Size(322, 48)
		Me.lblspace.TabIndex = 5
		Me.lblspace.Text = "Space Bar - Minigame Actions"
		'
		'btntryitout
		'
		Me.btntryitout.BackColor = System.Drawing.Color.ForestGreen
		Me.btntryitout.Font = New System.Drawing.Font("Microsoft Uighur", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btntryitout.ForeColor = System.Drawing.Color.White
		Me.btntryitout.Location = New System.Drawing.Point(435, 495)
		Me.btntryitout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.btntryitout.Name = "btntryitout"
		Me.btntryitout.Size = New System.Drawing.Size(258, 62)
		Me.btntryitout.TabIndex = 6
		Me.btntryitout.Text = "Try out the controls!"
		Me.btntryitout.UseVisualStyleBackColor = False
		'
		'tmrwalking
		'
		'
		'picup
		'
		Me.picup.BackColor = System.Drawing.Color.Transparent
		Me.picup.Image = Global.KevinISUGame.My.Resources.Resources.facingback
		Me.picup.Location = New System.Drawing.Point(126, -5)
		Me.picup.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.picup.Name = "picup"
		Me.picup.Size = New System.Drawing.Size(40, 97)
		Me.picup.TabIndex = 7
		Me.picup.TabStop = False
		'
		'picleft
		'
		Me.picleft.BackColor = System.Drawing.Color.Transparent
		Me.picleft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.picleft.Image = Global.KevinISUGame.My.Resources.Resources.facingleft
		Me.picleft.Location = New System.Drawing.Point(126, 102)
		Me.picleft.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.picleft.Name = "picleft"
		Me.picleft.Size = New System.Drawing.Size(40, 97)
		Me.picleft.TabIndex = 8
		Me.picleft.TabStop = False
		'
		'picright
		'
		Me.picright.BackColor = System.Drawing.Color.Transparent
		Me.picright.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.picright.Image = Global.KevinISUGame.My.Resources.Resources.facingright
		Me.picright.Location = New System.Drawing.Point(126, 314)
		Me.picright.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.picright.Name = "picright"
		Me.picright.Size = New System.Drawing.Size(40, 97)
		Me.picright.TabIndex = 9
		Me.picright.TabStop = False
		'
		'picdown
		'
		Me.picdown.BackColor = System.Drawing.Color.Transparent
		Me.picdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.picdown.Image = Global.KevinISUGame.My.Resources.Resources.facingfront
		Me.picdown.Location = New System.Drawing.Point(126, 208)
		Me.picdown.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.picdown.Name = "picdown"
		Me.picdown.Size = New System.Drawing.Size(40, 97)
		Me.picdown.TabIndex = 10
		Me.picdown.TabStop = False
		'
		'control
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.KevinISUGame.My.Resources.Resources._1_ngSya_x_boD9SlUupI0_kA
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(890, 605)
		Me.Controls.Add(Me.picdown)
		Me.Controls.Add(Me.picright)
		Me.Controls.Add(Me.picleft)
		Me.Controls.Add(Me.picup)
		Me.Controls.Add(Me.btntryitout)
		Me.Controls.Add(Me.lblspace)
		Me.Controls.Add(Me.lblleft)
		Me.Controls.Add(Me.lblright)
		Me.Controls.Add(Me.lbldown)
		Me.Controls.Add(Me.lblup)
		Me.Controls.Add(Me.btnGotit)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.MaximizeBox = False
		Me.MaximumSize = New System.Drawing.Size(912, 661)
		Me.MinimumSize = New System.Drawing.Size(912, 661)
		Me.Name = "control"
		Me.Text = "Stranded in Minnemore"
		CType(Me.picup, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picleft, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picright, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picdown, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnGotit As Button
	Friend WithEvents lblup As Label
	Friend WithEvents lbldown As Label
	Friend WithEvents lblright As Label
	Friend WithEvents lblleft As Label
	Friend WithEvents lblspace As Label
	Friend WithEvents btntryitout As Button
	Friend WithEvents tmrwalking As Timer
	Friend WithEvents picup As PictureBox
	Friend WithEvents picleft As PictureBox
	Friend WithEvents picright As PictureBox
	Friend WithEvents picdown As PictureBox
End Class
