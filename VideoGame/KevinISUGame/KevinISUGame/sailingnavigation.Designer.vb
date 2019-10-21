<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sailingnavigation
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sailingnavigation))
		Me.lblfoundboat = New System.Windows.Forms.Label()
		Me.tmranimate = New System.Windows.Forms.Timer(Me.components)
		Me.tmrup = New System.Windows.Forms.Timer(Me.components)
		Me.tmraccelerate = New System.Windows.Forms.Timer(Me.components)
		Me.lblsteerup = New System.Windows.Forms.Label()
		Me.lblsteerdown = New System.Windows.Forms.Label()
		Me.tmrdown = New System.Windows.Forms.Timer(Me.components)
		Me.tmrlog1move = New System.Windows.Forms.Timer(Me.components)
		Me.tmrlog2move = New System.Windows.Forms.Timer(Me.components)
		Me.tmrlog3move = New System.Windows.Forms.Timer(Me.components)
		Me.tmrlog4move = New System.Windows.Forms.Timer(Me.components)
		Me.tmrlog5move = New System.Windows.Forms.Timer(Me.components)
		Me.tmrgamelogic = New System.Windows.Forms.Timer(Me.components)
		Me.tmrstagger = New System.Windows.Forms.Timer(Me.components)
		Me.tmrgametimer = New System.Windows.Forms.Timer(Me.components)
		Me.lblhealth = New System.Windows.Forms.Label()
		Me.tmrfinalanimation = New System.Windows.Forms.Timer(Me.components)
		Me.tmrwalkup = New System.Windows.Forms.Timer(Me.components)
		Me.tmrwalkleft = New System.Windows.Forms.Timer(Me.components)
		Me.tmrwalkright = New System.Windows.Forms.Timer(Me.components)
		Me.tmrwalkdown = New System.Windows.Forms.Timer(Me.components)
		Me.tmrnohitframes = New System.Windows.Forms.Timer(Me.components)
		Me.picraft = New System.Windows.Forms.PictureBox()
		Me.piclog5 = New System.Windows.Forms.PictureBox()
		Me.piclog4 = New System.Windows.Forms.PictureBox()
		Me.piclog3 = New System.Windows.Forms.PictureBox()
		Me.piclog2 = New System.Windows.Forms.PictureBox()
		Me.piclog1 = New System.Windows.Forms.PictureBox()
		Me.picsmooth = New System.Windows.Forms.PictureBox()
		Me.pichitboxgoingdown10 = New System.Windows.Forms.PictureBox()
		Me.pichitboxgoingdown9 = New System.Windows.Forms.PictureBox()
		Me.pichitboxgoingdown8 = New System.Windows.Forms.PictureBox()
		Me.pichitboxgoingdown7 = New System.Windows.Forms.PictureBox()
		Me.pichitboxgoingdown6 = New System.Windows.Forms.PictureBox()
		Me.pichitboxgoingdown5 = New System.Windows.Forms.PictureBox()
		Me.pichitboxgoingdown4 = New System.Windows.Forms.PictureBox()
		Me.pichitboxgoingdown3 = New System.Windows.Forms.PictureBox()
		Me.pichitboxgoingdown2 = New System.Windows.Forms.PictureBox()
		Me.pichitboxgoingdown1 = New System.Windows.Forms.PictureBox()
		Me.pichitboxforwards = New System.Windows.Forms.PictureBox()
		Me.pichitbox12 = New System.Windows.Forms.PictureBox()
		Me.pichitbox14 = New System.Windows.Forms.PictureBox()
		Me.pichitbox13 = New System.Windows.Forms.PictureBox()
		Me.pichitbox11 = New System.Windows.Forms.PictureBox()
		Me.pichitbox10 = New System.Windows.Forms.PictureBox()
		Me.pichitbox9 = New System.Windows.Forms.PictureBox()
		Me.pichitbox8 = New System.Windows.Forms.PictureBox()
		Me.pichitbox7 = New System.Windows.Forms.PictureBox()
		Me.pichitbox5 = New System.Windows.Forms.PictureBox()
		Me.pichitbox6 = New System.Windows.Forms.PictureBox()
		Me.pichitbox4 = New System.Windows.Forms.PictureBox()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.pichitbox2 = New System.Windows.Forms.PictureBox()
		Me.pichitbox3 = New System.Windows.Forms.PictureBox()
		Me.pichitbox1 = New System.Windows.Forms.PictureBox()
		CType(Me.picraft, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.piclog5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.piclog4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.piclog3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.piclog2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.piclog1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picsmooth, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pichitboxgoingdown10, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pichitboxgoingdown9, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pichitboxgoingdown8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pichitboxgoingdown7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pichitboxgoingdown6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pichitboxgoingdown5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pichitboxgoingdown4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pichitboxgoingdown3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pichitboxgoingdown2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pichitboxgoingdown1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pichitboxforwards, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pichitbox12, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pichitbox14, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pichitbox13, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pichitbox11, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pichitbox10, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pichitbox9, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pichitbox8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pichitbox7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pichitbox5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pichitbox6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pichitbox4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pichitbox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pichitbox3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pichitbox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'lblfoundboat
		'
		Me.lblfoundboat.AutoSize = True
		Me.lblfoundboat.Font = New System.Drawing.Font("Microsoft Uighur", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblfoundboat.Location = New System.Drawing.Point(261, 148)
		Me.lblfoundboat.Name = "lblfoundboat"
		Me.lblfoundboat.Size = New System.Drawing.Size(553, 63)
		Me.lblfoundboat.TabIndex = 1
		Me.lblfoundboat.Text = "Looks like an old raft. How convenient!"
		'
		'tmranimate
		'
		'
		'tmrup
		'
		Me.tmrup.Interval = 5
		'
		'tmraccelerate
		'
		Me.tmraccelerate.Interval = 50
		'
		'lblsteerup
		'
		Me.lblsteerup.AutoSize = True
		Me.lblsteerup.Font = New System.Drawing.Font("Microsoft Uighur", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblsteerup.Location = New System.Drawing.Point(392, 148)
		Me.lblsteerup.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblsteerup.Name = "lblsteerup"
		Me.lblsteerup.Size = New System.Drawing.Size(199, 63)
		Me.lblsteerup.TabIndex = 3
		Me.lblsteerup.Text = "W - Steer Up"
		'
		'lblsteerdown
		'
		Me.lblsteerdown.AutoSize = True
		Me.lblsteerdown.Font = New System.Drawing.Font("Microsoft Uighur", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblsteerdown.Location = New System.Drawing.Point(392, 212)
		Me.lblsteerdown.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblsteerdown.Name = "lblsteerdown"
		Me.lblsteerdown.Size = New System.Drawing.Size(225, 63)
		Me.lblsteerdown.TabIndex = 4
		Me.lblsteerdown.Text = "S - Steer Down"
		'
		'tmrdown
		'
		Me.tmrdown.Interval = 5
		'
		'tmrlog1move
		'
		Me.tmrlog1move.Interval = 10
		'
		'tmrlog2move
		'
		Me.tmrlog2move.Interval = 10
		'
		'tmrlog3move
		'
		Me.tmrlog3move.Interval = 10
		'
		'tmrlog4move
		'
		Me.tmrlog4move.Interval = 10
		'
		'tmrlog5move
		'
		Me.tmrlog5move.Interval = 10
		'
		'tmrgamelogic
		'
		'
		'tmrstagger
		'
		'
		'tmrgametimer
		'
		'
		'lblhealth
		'
		Me.lblhealth.AutoSize = True
		Me.lblhealth.Font = New System.Drawing.Font("Microsoft Uighur", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblhealth.Location = New System.Drawing.Point(49, 9)
		Me.lblhealth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblhealth.Name = "lblhealth"
		Me.lblhealth.Size = New System.Drawing.Size(112, 42)
		Me.lblhealth.TabIndex = 38
		Me.lblhealth.Text = "Health: 25"
		'
		'tmrfinalanimation
		'
		Me.tmrfinalanimation.Interval = 10
		'
		'tmrwalkup
		'
		'
		'tmrwalkleft
		'
		'
		'tmrwalkright
		'
		'
		'tmrwalkdown
		'
		'
		'tmrnohitframes
		'
		'
		'picraft
		'
		Me.picraft.Image = Global.KevinISUGame.My.Resources.Resources.raftgoingup
		Me.picraft.Location = New System.Drawing.Point(132, 800)
		Me.picraft.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.picraft.Name = "picraft"
		Me.picraft.Size = New System.Drawing.Size(120, 123)
		Me.picraft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picraft.TabIndex = 2
		Me.picraft.TabStop = False
		'
		'piclog5
		'
		Me.piclog5.BackColor = System.Drawing.Color.Maroon
		Me.piclog5.Location = New System.Drawing.Point(1024, 372)
		Me.piclog5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.piclog5.Name = "piclog5"
		Me.piclog5.Size = New System.Drawing.Size(69, 346)
		Me.piclog5.TabIndex = 37
		Me.piclog5.TabStop = False
		'
		'piclog4
		'
		Me.piclog4.BackColor = System.Drawing.Color.Maroon
		Me.piclog4.Location = New System.Drawing.Point(890, 38)
		Me.piclog4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.piclog4.Name = "piclog4"
		Me.piclog4.Size = New System.Drawing.Size(69, 346)
		Me.piclog4.TabIndex = 36
		Me.piclog4.TabStop = False
		'
		'piclog3
		'
		Me.piclog3.BackColor = System.Drawing.Color.Maroon
		Me.piclog3.Location = New System.Drawing.Point(813, 216)
		Me.piclog3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.piclog3.Name = "piclog3"
		Me.piclog3.Size = New System.Drawing.Size(69, 346)
		Me.piclog3.TabIndex = 35
		Me.piclog3.TabStop = False
		'
		'piclog2
		'
		Me.piclog2.BackColor = System.Drawing.Color.Maroon
		Me.piclog2.Location = New System.Drawing.Point(922, 394)
		Me.piclog2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.piclog2.Name = "piclog2"
		Me.piclog2.Size = New System.Drawing.Size(69, 346)
		Me.piclog2.TabIndex = 34
		Me.piclog2.TabStop = False
		'
		'piclog1
		'
		Me.piclog1.BackColor = System.Drawing.Color.Maroon
		Me.piclog1.Location = New System.Drawing.Point(999, -3)
		Me.piclog1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.piclog1.Name = "piclog1"
		Me.piclog1.Size = New System.Drawing.Size(69, 346)
		Me.piclog1.TabIndex = 33
		Me.piclog1.TabStop = False
		'
		'picsmooth
		'
		Me.picsmooth.Location = New System.Drawing.Point(-10, -3)
		Me.picsmooth.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.picsmooth.Name = "picsmooth"
		Me.picsmooth.Size = New System.Drawing.Size(1146, 797)
		Me.picsmooth.TabIndex = 5
		Me.picsmooth.TabStop = False
		'
		'pichitboxgoingdown10
		'
		Me.pichitboxgoingdown10.Location = New System.Drawing.Point(228, 862)
		Me.pichitboxgoingdown10.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.pichitboxgoingdown10.Name = "pichitboxgoingdown10"
		Me.pichitboxgoingdown10.Size = New System.Drawing.Size(15, 26)
		Me.pichitboxgoingdown10.TabIndex = 32
		Me.pichitboxgoingdown10.TabStop = False
		Me.pichitboxgoingdown10.Tag = "hitboxgoingdown"
		'
		'pichitboxgoingdown9
		'
		Me.pichitboxgoingdown9.Location = New System.Drawing.Point(213, 849)
		Me.pichitboxgoingdown9.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.pichitboxgoingdown9.Name = "pichitboxgoingdown9"
		Me.pichitboxgoingdown9.Size = New System.Drawing.Size(15, 15)
		Me.pichitboxgoingdown9.TabIndex = 31
		Me.pichitboxgoingdown9.TabStop = False
		Me.pichitboxgoingdown9.Tag = "hitboxgoingdown"
		'
		'pichitboxgoingdown8
		'
		Me.pichitboxgoingdown8.Location = New System.Drawing.Point(171, 806)
		Me.pichitboxgoingdown8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.pichitboxgoingdown8.Name = "pichitboxgoingdown8"
		Me.pichitboxgoingdown8.Size = New System.Drawing.Size(15, 15)
		Me.pichitboxgoingdown8.TabIndex = 30
		Me.pichitboxgoingdown8.TabStop = False
		Me.pichitboxgoingdown8.Tag = "hitboxgoingdown"
		'
		'pichitboxgoingdown7
		'
		Me.pichitboxgoingdown7.Location = New System.Drawing.Point(136, 838)
		Me.pichitboxgoingdown7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.pichitboxgoingdown7.Name = "pichitboxgoingdown7"
		Me.pichitboxgoingdown7.Size = New System.Drawing.Size(15, 15)
		Me.pichitboxgoingdown7.TabIndex = 29
		Me.pichitboxgoingdown7.TabStop = False
		Me.pichitboxgoingdown7.Tag = "hitboxgoingdown"
		'
		'pichitboxgoingdown6
		'
		Me.pichitboxgoingdown6.Location = New System.Drawing.Point(189, 885)
		Me.pichitboxgoingdown6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.pichitboxgoingdown6.Name = "pichitboxgoingdown6"
		Me.pichitboxgoingdown6.Size = New System.Drawing.Size(38, 20)
		Me.pichitboxgoingdown6.TabIndex = 28
		Me.pichitboxgoingdown6.TabStop = False
		Me.pichitboxgoingdown6.Tag = "hitboxgoingdown"
		'
		'pichitboxgoingdown5
		'
		Me.pichitboxgoingdown5.Location = New System.Drawing.Point(198, 885)
		Me.pichitboxgoingdown5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.pichitboxgoingdown5.Name = "pichitboxgoingdown5"
		Me.pichitboxgoingdown5.Size = New System.Drawing.Size(21, 31)
		Me.pichitboxgoingdown5.TabIndex = 27
		Me.pichitboxgoingdown5.TabStop = False
		Me.pichitboxgoingdown5.Tag = "hitboxgoingdown"
		'
		'pichitboxgoingdown4
		'
		Me.pichitboxgoingdown4.Location = New System.Drawing.Point(150, 826)
		Me.pichitboxgoingdown4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.pichitboxgoingdown4.Name = "pichitboxgoingdown4"
		Me.pichitboxgoingdown4.Size = New System.Drawing.Size(26, 35)
		Me.pichitboxgoingdown4.TabIndex = 26
		Me.pichitboxgoingdown4.TabStop = False
		Me.pichitboxgoingdown4.Tag = "hitboxgoingdown"
		'
		'pichitboxgoingdown3
		'
		Me.pichitboxgoingdown3.Location = New System.Drawing.Point(176, 862)
		Me.pichitboxgoingdown3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.pichitboxgoingdown3.Name = "pichitboxgoingdown3"
		Me.pichitboxgoingdown3.Size = New System.Drawing.Size(60, 32)
		Me.pichitboxgoingdown3.TabIndex = 25
		Me.pichitboxgoingdown3.TabStop = False
		Me.pichitboxgoingdown3.Tag = "hitboxgoingdown"
		'
		'pichitboxgoingdown2
		'
		Me.pichitboxgoingdown2.Location = New System.Drawing.Point(176, 837)
		Me.pichitboxgoingdown2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.pichitboxgoingdown2.Name = "pichitboxgoingdown2"
		Me.pichitboxgoingdown2.Size = New System.Drawing.Size(42, 57)
		Me.pichitboxgoingdown2.TabIndex = 24
		Me.pichitboxgoingdown2.TabStop = False
		Me.pichitboxgoingdown2.Tag = "hitboxgoingdown"
		'
		'pichitboxgoingdown1
		'
		Me.pichitboxgoingdown1.Location = New System.Drawing.Point(159, 818)
		Me.pichitboxgoingdown1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.pichitboxgoingdown1.Name = "pichitboxgoingdown1"
		Me.pichitboxgoingdown1.Size = New System.Drawing.Size(42, 57)
		Me.pichitboxgoingdown1.TabIndex = 23
		Me.pichitboxgoingdown1.TabStop = False
		Me.pichitboxgoingdown1.Tag = "hitboxgoingdown"
		'
		'pichitboxforwards
		'
		Me.pichitboxforwards.Location = New System.Drawing.Point(152, 802)
		Me.pichitboxforwards.Name = "pichitboxforwards"
		Me.pichitboxforwards.Size = New System.Drawing.Size(116, 69)
		Me.pichitboxforwards.TabIndex = 22
		Me.pichitboxforwards.TabStop = False
		'
		'pichitbox12
		'
		Me.pichitbox12.Location = New System.Drawing.Point(171, 906)
		Me.pichitbox12.Name = "pichitbox12"
		Me.pichitbox12.Size = New System.Drawing.Size(10, 9)
		Me.pichitbox12.TabIndex = 21
		Me.pichitbox12.TabStop = False
		Me.pichitbox12.Tag = "goinguphitbox"
		'
		'pichitbox14
		'
		Me.pichitbox14.Location = New System.Drawing.Point(142, 860)
		Me.pichitbox14.Name = "pichitbox14"
		Me.pichitbox14.Size = New System.Drawing.Size(10, 9)
		Me.pichitbox14.TabIndex = 20
		Me.pichitbox14.TabStop = False
		Me.pichitbox14.Tag = "goinguphitbox"
		'
		'pichitbox13
		'
		Me.pichitbox13.Location = New System.Drawing.Point(152, 857)
		Me.pichitbox13.Name = "pichitbox13"
		Me.pichitbox13.Size = New System.Drawing.Size(44, 38)
		Me.pichitbox13.TabIndex = 19
		Me.pichitbox13.TabStop = False
		Me.pichitbox13.Tag = "goinguphitbox"
		'
		'pichitbox11
		'
		Me.pichitbox11.Location = New System.Drawing.Point(136, 866)
		Me.pichitbox11.Name = "pichitbox11"
		Me.pichitbox11.Size = New System.Drawing.Size(33, 9)
		Me.pichitbox11.TabIndex = 18
		Me.pichitbox11.TabStop = False
		Me.pichitbox11.Tag = "goinguphitbox"
		'
		'pichitbox10
		'
		Me.pichitbox10.Location = New System.Drawing.Point(186, 886)
		Me.pichitbox10.Name = "pichitbox10"
		Me.pichitbox10.Size = New System.Drawing.Size(10, 15)
		Me.pichitbox10.TabIndex = 17
		Me.pichitbox10.TabStop = False
		Me.pichitbox10.Tag = "goinguphitbox"
		'
		'pichitbox9
		'
		Me.pichitbox9.Location = New System.Drawing.Point(158, 846)
		Me.pichitbox9.Name = "pichitbox9"
		Me.pichitbox9.Size = New System.Drawing.Size(54, 38)
		Me.pichitbox9.TabIndex = 16
		Me.pichitbox9.TabStop = False
		Me.pichitbox9.Tag = "goinguphitbox"
		'
		'pichitbox8
		'
		Me.pichitbox8.Location = New System.Drawing.Point(142, 875)
		Me.pichitbox8.Name = "pichitbox8"
		Me.pichitbox8.Size = New System.Drawing.Size(10, 9)
		Me.pichitbox8.TabIndex = 15
		Me.pichitbox8.TabStop = False
		Me.pichitbox8.Tag = "goinguphitbox"
		'
		'pichitbox7
		'
		Me.pichitbox7.Location = New System.Drawing.Point(171, 828)
		Me.pichitbox7.Name = "pichitbox7"
		Me.pichitbox7.Size = New System.Drawing.Size(63, 35)
		Me.pichitbox7.TabIndex = 14
		Me.pichitbox7.TabStop = False
		Me.pichitbox7.Tag = "goinguphitbox"
		'
		'pichitbox5
		'
		Me.pichitbox5.Location = New System.Drawing.Point(232, 834)
		Me.pichitbox5.Name = "pichitbox5"
		Me.pichitbox5.Size = New System.Drawing.Size(10, 20)
		Me.pichitbox5.TabIndex = 13
		Me.pichitbox5.TabStop = False
		Me.pichitbox5.Tag = "goinguphitbox"
		'
		'pichitbox6
		'
		Me.pichitbox6.Location = New System.Drawing.Point(162, 838)
		Me.pichitbox6.Name = "pichitbox6"
		Me.pichitbox6.Size = New System.Drawing.Size(62, 35)
		Me.pichitbox6.TabIndex = 12
		Me.pichitbox6.TabStop = False
		Me.pichitbox6.Tag = "goinguphitbox"
		'
		'pichitbox4
		'
		Me.pichitbox4.Location = New System.Drawing.Point(182, 822)
		Me.pichitbox4.Name = "pichitbox4"
		Me.pichitbox4.Size = New System.Drawing.Size(42, 29)
		Me.pichitbox4.TabIndex = 10
		Me.pichitbox4.TabStop = False
		Me.pichitbox4.Tag = "goinguphitbox"
		'
		'PictureBox3
		'
		Me.PictureBox3.Location = New System.Drawing.Point(212, 825)
		Me.PictureBox3.Name = "PictureBox3"
		Me.PictureBox3.Size = New System.Drawing.Size(22, 26)
		Me.PictureBox3.TabIndex = 9
		Me.PictureBox3.TabStop = False
		Me.PictureBox3.Tag = "goinguphitbox"
		'
		'pichitbox2
		'
		Me.pichitbox2.Location = New System.Drawing.Point(190, 811)
		Me.pichitbox2.Name = "pichitbox2"
		Me.pichitbox2.Size = New System.Drawing.Size(33, 11)
		Me.pichitbox2.TabIndex = 8
		Me.pichitbox2.TabStop = False
		Me.pichitbox2.Tag = "goinguphitbox"
		'
		'pichitbox3
		'
		Me.pichitbox3.Location = New System.Drawing.Point(201, 803)
		Me.pichitbox3.Name = "pichitbox3"
		Me.pichitbox3.Size = New System.Drawing.Size(10, 9)
		Me.pichitbox3.TabIndex = 7
		Me.pichitbox3.TabStop = False
		Me.pichitbox3.Tag = "goinguphitbox"
		'
		'pichitbox1
		'
		Me.pichitbox1.Location = New System.Drawing.Point(164, 886)
		Me.pichitbox1.Name = "pichitbox1"
		Me.pichitbox1.Size = New System.Drawing.Size(24, 22)
		Me.pichitbox1.TabIndex = 6
		Me.pichitbox1.TabStop = False
		Me.pichitbox1.Tag = "goinguphitbox"
		'
		'sailingnavigation
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.PaleTurquoise
		Me.ClientSize = New System.Drawing.Size(1116, 732)
		Me.Controls.Add(Me.picraft)
		Me.Controls.Add(Me.lblhealth)
		Me.Controls.Add(Me.piclog5)
		Me.Controls.Add(Me.piclog4)
		Me.Controls.Add(Me.piclog3)
		Me.Controls.Add(Me.piclog2)
		Me.Controls.Add(Me.piclog1)
		Me.Controls.Add(Me.lblsteerdown)
		Me.Controls.Add(Me.lblsteerup)
		Me.Controls.Add(Me.lblfoundboat)
		Me.Controls.Add(Me.picsmooth)
		Me.Controls.Add(Me.pichitboxgoingdown10)
		Me.Controls.Add(Me.pichitboxgoingdown9)
		Me.Controls.Add(Me.pichitboxgoingdown8)
		Me.Controls.Add(Me.pichitboxgoingdown7)
		Me.Controls.Add(Me.pichitboxgoingdown6)
		Me.Controls.Add(Me.pichitboxgoingdown5)
		Me.Controls.Add(Me.pichitboxgoingdown4)
		Me.Controls.Add(Me.pichitboxgoingdown3)
		Me.Controls.Add(Me.pichitboxgoingdown2)
		Me.Controls.Add(Me.pichitboxgoingdown1)
		Me.Controls.Add(Me.pichitboxforwards)
		Me.Controls.Add(Me.pichitbox12)
		Me.Controls.Add(Me.pichitbox14)
		Me.Controls.Add(Me.pichitbox13)
		Me.Controls.Add(Me.pichitbox11)
		Me.Controls.Add(Me.pichitbox10)
		Me.Controls.Add(Me.pichitbox9)
		Me.Controls.Add(Me.pichitbox8)
		Me.Controls.Add(Me.pichitbox7)
		Me.Controls.Add(Me.pichitbox5)
		Me.Controls.Add(Me.pichitbox6)
		Me.Controls.Add(Me.pichitbox4)
		Me.Controls.Add(Me.PictureBox3)
		Me.Controls.Add(Me.pichitbox2)
		Me.Controls.Add(Me.pichitbox3)
		Me.Controls.Add(Me.pichitbox1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MaximumSize = New System.Drawing.Size(1138, 788)
		Me.MinimumSize = New System.Drawing.Size(1138, 788)
		Me.Name = "sailingnavigation"
		Me.Text = "Stranded in Minnemore"
		CType(Me.picraft, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.piclog5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.piclog4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.piclog3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.piclog2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.piclog1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picsmooth, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pichitboxgoingdown10, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pichitboxgoingdown9, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pichitboxgoingdown8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pichitboxgoingdown7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pichitboxgoingdown6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pichitboxgoingdown5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pichitboxgoingdown4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pichitboxgoingdown3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pichitboxgoingdown2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pichitboxgoingdown1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pichitboxforwards, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pichitbox12, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pichitbox14, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pichitbox13, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pichitbox11, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pichitbox10, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pichitbox9, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pichitbox8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pichitbox7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pichitbox5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pichitbox6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pichitbox4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pichitbox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pichitbox3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pichitbox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblfoundboat As Label
	Friend WithEvents picraft As PictureBox
	Friend WithEvents tmranimate As Timer
	Friend WithEvents tmrup As Timer
	Friend WithEvents tmraccelerate As Timer
	Friend WithEvents lblsteerup As Label
	Friend WithEvents lblsteerdown As Label
	Friend WithEvents picsmooth As PictureBox
	Friend WithEvents tmrdown As Timer
	Friend WithEvents pichitbox1 As PictureBox
	Friend WithEvents pichitbox3 As PictureBox
	Friend WithEvents pichitbox2 As PictureBox
	Friend WithEvents PictureBox3 As PictureBox
	Friend WithEvents pichitbox4 As PictureBox
	Friend WithEvents pichitbox5 As PictureBox
	Friend WithEvents pichitbox7 As PictureBox
	Friend WithEvents pichitbox8 As PictureBox
	Friend WithEvents pichitbox6 As PictureBox
	Friend WithEvents pichitbox9 As PictureBox
	Friend WithEvents pichitbox10 As PictureBox
	Friend WithEvents pichitbox11 As PictureBox
	Friend WithEvents pichitbox13 As PictureBox
	Friend WithEvents pichitbox14 As PictureBox
	Friend WithEvents pichitbox12 As PictureBox
	Friend WithEvents pichitboxforwards As PictureBox
	Friend WithEvents pichitboxgoingdown1 As PictureBox
	Friend WithEvents pichitboxgoingdown2 As PictureBox
	Friend WithEvents pichitboxgoingdown3 As PictureBox
	Friend WithEvents pichitboxgoingdown4 As PictureBox
	Friend WithEvents pichitboxgoingdown5 As PictureBox
	Friend WithEvents pichitboxgoingdown6 As PictureBox
	Friend WithEvents pichitboxgoingdown7 As PictureBox
	Friend WithEvents pichitboxgoingdown8 As PictureBox
	Friend WithEvents pichitboxgoingdown9 As PictureBox
	Friend WithEvents pichitboxgoingdown10 As PictureBox
	Friend WithEvents tmrlog1move As Timer
	Friend WithEvents tmrlog2move As Timer
	Friend WithEvents tmrlog3move As Timer
	Friend WithEvents tmrlog4move As Timer
	Friend WithEvents piclog1 As PictureBox
	Friend WithEvents piclog2 As PictureBox
	Friend WithEvents piclog3 As PictureBox
	Friend WithEvents piclog4 As PictureBox
	Friend WithEvents piclog5 As PictureBox
	Friend WithEvents tmrlog5move As Timer
	Friend WithEvents tmrgamelogic As Timer
	Friend WithEvents tmrstagger As Timer
	Friend WithEvents tmrgametimer As Timer
	Friend WithEvents lblhealth As Label
	Friend WithEvents tmrfinalanimation As Timer
	Friend WithEvents tmrwalkup As Timer
	Friend WithEvents tmrwalkleft As Timer
	Friend WithEvents tmrwalkright As Timer
	Friend WithEvents tmrwalkdown As Timer
	Friend WithEvents tmrnohitframes As Timer
End Class
