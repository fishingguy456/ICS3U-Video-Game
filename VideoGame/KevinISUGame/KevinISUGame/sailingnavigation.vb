'kevin qu
'january 7
'raftlevel
Public Class sailingnavigation
	Dim txt(2) As String
	Dim intervalanimation As Integer = 0 'declare variables
	Dim logspeed(4) As Integer
	Dim raftfront As Image = My.Resources.raftforwards
	Dim raftup As Image = My.Resources.raftgoingup
	Dim raftdown As Image = My.Resources.raftgoingdown
	Dim health As Integer = 25
	Dim staggerinterval As Integer = 0
	Dim gametimer As Integer = 0
	Dim timesup As Boolean = False
	Dim logdone As Integer = 0
	Dim raftdone As Boolean = False
	Dim upimages(3) As Image
	Dim downimages(3) As Image
	Dim leftimages(3) As Image
	Dim rightimages(3) As Image
	Dim upcounter As Integer = 0
	Dim downcounter As Integer = 0
	Dim leftcounter As Integer = 0
	Dim rightcounter As Integer = 0
	Dim groundleft As Integer = 0
	Dim invincibility As Boolean = False
	Dim nohitinterval As Integer = 0
	Dim startanimationdone As Boolean = False
	Private Sub tmranimate_Tick(sender As Object, e As EventArgs) Handles tmranimate.Tick
		intervalanimation += 1
		If intervalanimation > 5 And intervalanimation < 40 + 5 Then
			Me.lblfoundboat.Text = txt(0).Substring(0, intervalanimation - 5) 'timer to set when the labels show up
		ElseIf intervalanimation = 40 + 15 Then
			Me.lblfoundboat.Text = Nothing 'clear text for new label
		ElseIf intervalanimation > 40 + 5 + 15 And intervalanimation < 60 + 40 + 5 + 15 Then
			Me.lblsteerup.Text = txt(1)
			Me.lblsteerdown.Text = txt(2)
		ElseIf intervalanimation > 60 + 40 + 5 + 15 Then
			intervalanimation = 0
			Me.picraft.Show()
			Me.tmraccelerate.Start()
			Me.tmranimate.Stop() 'move the raft to the middle
		End If
	End Sub

	Private Sub sailingnavigation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		txt(0) = Me.lblfoundboat.Text
		txt(1) = Me.lblsteerup.Text
		txt(2) = Me.lblsteerdown.Text
		Me.lblfoundboat.Text = Nothing 'clear the label and store its values
		Me.lblsteerdown.Text = Nothing
		Me.lblsteerup.Text = Nothing
		Me.tmranimate.Start() 'start the animation
		Me.picraft.Hide()
		Randomize()
		logspeed(0) = CInt((9 - 2 + 1) * Rnd() + 2) 'create random speeds for the logs
		Randomize()
		logspeed(1) = CInt((9 - 2 + 1) * Rnd() + 2)
		Randomize()
		logspeed(2) = CInt((9 - 2 + 1) * Rnd() + 2)
		Randomize()
		logspeed(3) = CInt((9 - 2 + 1) * Rnd() + 2)
		Randomize()
		logspeed(4) = CInt((9 - 2 + 1) * Rnd() + 2)
		Me.tmrgamelogic.Start()
		Me.lblhealth.Hide()
		Me.piclog1.Hide()
		Me.piclog2.Hide()
		Me.piclog3.Hide()
		Me.piclog4.Hide() 'hide some itmes for now
		Me.piclog5.Hide()
		downimages(0) = My.Resources.facingfront  'put the pictures into the the arrays
		downimages(1) = My.Resources.facingfrontleftleg
		downimages(2) = My.Resources.facingfront
		downimages(3) = My.Resources.facingfrontrightleg
		upimages(0) = My.Resources.facingback
		upimages(1) = My.Resources.facingbackleftleg
		upimages(2) = My.Resources.facingback
		upimages(3) = My.Resources.facingbackrightleg
		leftimages(0) = My.Resources.facingleft
		leftimages(1) = My.Resources.facingleftfrontleg
		leftimages(2) = My.Resources.facingleft
		leftimages(3) = My.Resources.facingleftbackleg
		rightimages(0) = My.Resources.facingright
		rightimages(1) = My.Resources.facingrightfrontleg
		rightimages(2) = My.Resources.facingright
		rightimages(3) = My.Resources.facingrightbackleg
	End Sub

	Private Sub tmraccelerate_Tick(sender As Object, e As EventArgs) Handles tmraccelerate.Tick
		Me.picraft.Top -= 5
		Me.pichitbox1.Top -= 5 'move the hitboxes as well
		Me.pichitbox2.Top -= 5
		Me.pichitbox3.Top -= 5
		Me.pichitbox4.Top -= 5
		Me.pichitbox5.Top -= 5
		Me.pichitbox6.Top -= 5
		Me.pichitbox7.Top -= 5
		Me.pichitbox8.Top -= 5
		Me.pichitbox9.Top -= 5
		Me.pichitbox10.Top -= 5
		Me.pichitbox11.Top -= 5
		Me.pichitboxforwards.Top -= 5
		Me.pichitboxgoingdown1.Top -= 5
		Me.pichitboxgoingdown2.Top -= 5
		Me.pichitboxgoingdown3.Top -= 5
		Me.pichitboxgoingdown4.Top -= 5
		Me.pichitboxgoingdown5.Top -= 5
		Me.pichitboxgoingdown6.Top -= 5
		Me.pichitboxgoingdown7.Top -= 5
		Me.pichitboxgoingdown8.Top -= 5
		Me.pichitboxgoingdown9.Top -= 5
		Me.pichitboxgoingdown10.Top -= 5
		If Me.picraft.Top < 225 Then'stop the animation and start the level
			Me.picraft.Width = 90
			Me.picraft.Height = 46
			Me.picraft.Image = raftfront
			Me.lblsteerup.Text = Nothing
			Me.lblsteerdown.Text = Nothing 'hide the controls and start the game
			Me.tmraccelerate.Stop()
			startanimationdone = True
			Me.tmrlog1move.Start()
			Me.tmrgametimer.Start()
			Me.lblhealth.Show()
			Me.piclog1.Show()
			Me.piclog1.Left = Me.Width
			Me.tmrstagger.Start()
		End If
	End Sub

	Private Sub sailingnavigation_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
		If raftdone = False And startanimationdone = True Then
			Select Case e.KeyCode 'stop walking when the button is released
				Case Keys.W
					Me.picraft.Height = 80
					Me.picraft.Width = 80
					Me.picraft.Image = raftup 'change the raft image and resize it to not look funky
					Me.tmrup.Start()
				Case Keys.S
					Me.picraft.Height = 80
					Me.picraft.Width = 80
					Me.picraft.Image = raftdown
					Me.tmrdown.Start()
			End Select
		ElseIf raftdone = True Then
			Select Case e.KeyCode 'stop walking when the button is released
				Case Keys.W
					Me.tmrwalkup.Start()
				Case Keys.A
					Me.tmrwalkleft.Start()
				Case Keys.S
					Me.tmrwalkdown.Start()
				Case Keys.D
					Me.tmrwalkright.Start()
			End Select
		End If
	End Sub

	Private Sub tmrdown_Tick(sender As Object, e As EventArgs) Handles tmrdown.Tick
		If Me.picraft.Top < Me.Height - Me.picraft.Height - 20 Then 'keep within the boundary
			Me.picraft.Top += 10 'move the raft
			Me.pichitbox1.Top += 10 'move the hitboxes as well
			Me.pichitbox2.Top += 10
			Me.pichitbox3.Top += 10
			Me.pichitbox4.Top += 10
			Me.pichitbox5.Top += 10
			Me.pichitbox6.Top += 10
			Me.pichitbox7.Top += 10
			Me.pichitbox8.Top += 10
			Me.pichitbox9.Top += 10
			Me.pichitbox10.Top += 10
			Me.pichitbox11.Top += 10
			Me.pichitboxforwards.Top += 10
			Me.pichitboxgoingdown1.Top += 10
			Me.pichitboxgoingdown2.Top += 10
			Me.pichitboxgoingdown3.Top += 10
			Me.pichitboxgoingdown4.Top += 10
			Me.pichitboxgoingdown5.Top += 10
			Me.pichitboxgoingdown6.Top += 10
			Me.pichitboxgoingdown7.Top += 10
			Me.pichitboxgoingdown8.Top += 10
			Me.pichitboxgoingdown9.Top += 10
			Me.pichitboxgoingdown10.Top += 10
		End If
	End Sub

	Private Sub tmrup_Tick(sender As Object, e As EventArgs) Handles tmrup.Tick
		If Me.picraft.Top > 0 Then
			Me.picraft.Top -= 10
			Me.pichitbox1.Top -= 10 'move the hitboxes as well
			Me.pichitbox2.Top -= 10
			Me.pichitbox3.Top -= 10
			Me.pichitbox4.Top -= 10
			Me.pichitbox5.Top -= 10
			Me.pichitbox6.Top -= 10
			Me.pichitbox7.Top -= 10
			Me.pichitbox8.Top -= 10
			Me.pichitbox9.Top -= 10
			Me.pichitbox10.Top -= 10
			Me.pichitbox11.Top -= 10
			Me.pichitboxforwards.Top -= 10
			Me.pichitboxgoingdown1.Top -= 10
			Me.pichitboxgoingdown2.Top -= 10
			Me.pichitboxgoingdown3.Top -= 10
			Me.pichitboxgoingdown4.Top -= 10
			Me.pichitboxgoingdown5.Top -= 10
			Me.pichitboxgoingdown6.Top -= 10
			Me.pichitboxgoingdown7.Top -= 10
			Me.pichitboxgoingdown8.Top -= 10
			Me.pichitboxgoingdown9.Top -= 10
			Me.pichitboxgoingdown10.Top -= 10
		End If
	End Sub

	Private Sub sailingnavigation_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
		If raftdone = False And startanimationdone = True Then
			Select Case e.KeyCode 'stop walking when the button is released
				Case Keys.W
					Me.tmrup.Stop()
					Me.picraft.Width = 90
					Me.picraft.Height = 46
					Me.picraft.Image = raftfront 'change the raft image and resize it to not look funky
				Case Keys.S
					Me.tmrdown.Stop()
					Me.picraft.Width = 90
					Me.picraft.Height = 46
					Me.picraft.Image = raftfront
			End Select
		ElseIf raftdone = True Then 'only if the player is off of the raft
			Select Case e.KeyCode 'stop walking when the button is released
				Case Keys.W
					Me.tmrwalkup.Stop()
				Case Keys.A
					Me.tmrwalkleft.Stop()
				Case Keys.S
					Me.tmrwalkdown.Stop()
				Case Keys.D
					Me.tmrwalkright.Stop()
			End Select
		End If
	End Sub

	Private Sub tmrlog1move_Tick(sender As Object, e As EventArgs) Handles tmrlog1move.Tick
		Me.piclog1.Left -= logspeed(0) 'move the log
		If Me.piclog1.Left <= -Me.piclog1.Width And timesup = True Then 'let all the logs trickle away before solid ground
			logdone += 1
			Me.tmrlog1move.Stop()
		End If
		If Me.piclog1.Left <= -Me.piclog1.Width Then
			Randomize() 'random speed
			logspeed(0) = CInt((9 - 2 + 1) * Rnd() + 2)
			Randomize() 'make a random position and size
			Dim logsize As Integer = CInt((350 - 150 + 1) * Rnd() + 150)
			Dim logposition As Integer = CInt((100 - 0 + 1) * Rnd() + 0)
			Me.piclog1.Height = logsize
			Me.piclog1.Top = logposition
			Me.piclog1.Left = Me.Width - Me.piclog1.Left
		End If
	End Sub

	Private Sub tmrlog2move_Tick(sender As Object, e As EventArgs) Handles tmrlog2move.Tick
		Me.piclog2.Left -= logspeed(1)
		If Me.piclog2.Left <= -Me.piclog2.Width And timesup = True Then 'let all the logs trickle away before solid ground
			logdone += 1
			Me.tmrlog2move.Stop()
		End If
		If Me.piclog2.Left <= -Me.piclog2.Width Then
			Randomize()
			logspeed(1) = CInt((9 - 2 + 1) * Rnd() + 2)
			Randomize()
			Dim logsize As Integer = CInt((300 - 150 + 1) * Rnd() + 150)
			Dim logposition As Integer = CInt((200 - 100 + 1) * Rnd() + 100)
			Me.piclog2.Height = logsize
			Me.piclog2.Top = logposition
			Me.piclog2.Left = Me.Width - Me.piclog2.Left
		End If
	End Sub

	Private Sub tmrlog3move_Tick(sender As Object, e As EventArgs) Handles tmrlog3move.Tick
		Me.piclog3.Left -= logspeed(2)
		If Me.piclog3.Left <= -Me.piclog3.Width And timesup = True Then 'let all the logs trickle away before solid ground
			logdone += 1
			Me.tmrlog3move.Stop()
		End If
		If Me.piclog3.Left <= -Me.piclog3.Width Then
			Randomize()
			logspeed(2) = CInt((9 - 2 + 1) * Rnd() + 2)
			Randomize()
			Dim logsize As Integer = CInt((200 - 50 + 1) * Rnd() + 50)
			Dim logposition As Integer = CInt((300 - 50 + 1) * Rnd() + 50)
			Me.piclog3.Height = logsize
			Me.piclog3.Top = logposition
			Me.piclog3.Left = Me.Width - Me.piclog3.Left
		End If
	End Sub

	Private Sub tmrlog4move_Tick(sender As Object, e As EventArgs) Handles tmrlog4move.Tick
		Me.piclog4.Left -= logspeed(3)
		If Me.piclog4.Left <= -Me.piclog4.Width And timesup = True Then 'let all the logs trickle away before solid ground
			logdone += 1
			Me.tmrlog4move.Stop()
		End If
		If Me.piclog4.Left <= -Me.piclog4.Width Then
			Randomize()
			logspeed(3) = CInt((9 - 2 + 1) * Rnd() + 2)
			Randomize()
			Dim logsize As Integer = CInt((200 - 100 + 1) * Rnd() + 100)
			Dim logposition As Integer = CInt((300 - 100 + 1) * Rnd() + 100)
			Me.piclog4.Height = logsize
			Me.piclog4.Top = logposition
			Me.piclog4.Left = Me.Width - Me.piclog4.Left
		End If
	End Sub

	Private Sub tmrlog5move_Tick(sender As Object, e As EventArgs) Handles tmrlog5move.Tick
		Me.piclog5.Left -= logspeed(4)
		If Me.piclog5.Left <= -Me.piclog5.Width And timesup = True Then 'let all the logs trickle away before solid ground
			logdone += 1
			Me.tmrlog5move.Stop()
		End If
		If Me.piclog5.Left <= -Me.piclog5.Width Then
			Randomize()
			logspeed(4) = CInt((9 - 2 + 1) * Rnd() + 2)
			Randomize()
			Dim logsize As Integer = CInt((100 - 50 + 1) * Rnd() + 50)
			Dim logposition As Integer = CInt((275 - 175 + 1) * Rnd() + 175)
			Me.piclog5.Height = logsize
			Me.piclog5.Top = logposition
			Me.piclog5.Left = Me.Width - Me.piclog5.Left
		End If
	End Sub

	Private Sub tmrgamelogic_Tick(sender As Object, e As EventArgs) Handles tmrgamelogic.Tick
		If Me.picraft.Image Is raftfront Then 'check for collision in all hitboxes
			If (pichitbox1.Bounds.IntersectsWith(piclog1.Bounds) Or pichitbox1.Bounds.IntersectsWith(piclog2.Bounds) Or pichitbox1.Bounds.IntersectsWith(piclog3.Bounds) Or pichitbox1.Bounds.IntersectsWith(piclog4.Bounds) Or pichitbox1.Bounds.IntersectsWith(piclog5.Bounds)) And invincibility = False Then
				health -= 1
				Me.lblhealth.Text = "Health: " & health 'cahnge the health
				Me.tmrnohitframes.Start() 'these are obsolete
			ElseIf (pichitbox2.Bounds.IntersectsWith(piclog1.Bounds) Or pichitbox2.Bounds.IntersectsWith(piclog2.Bounds) Or pichitbox2.Bounds.IntersectsWith(piclog3.Bounds) Or pichitbox2.Bounds.IntersectsWith(piclog4.Bounds) Or pichitbox2.Bounds.IntersectsWith(piclog5.Bounds)) And invincibility = False Then
				health -= 1
				Me.lblhealth.Text = "Health: " & health
				Me.tmrnohitframes.Start()
			ElseIf (pichitbox3.Bounds.IntersectsWith(piclog1.Bounds) Or pichitbox3.Bounds.IntersectsWith(piclog2.Bounds) Or pichitbox3.Bounds.IntersectsWith(piclog3.Bounds) Or pichitbox3.Bounds.IntersectsWith(piclog4.Bounds) Or pichitbox3.Bounds.IntersectsWith(piclog5.Bounds)) And invincibility = False Then
				health -= 1
				Me.lblhealth.Text = "Health: " & health
				Me.tmrnohitframes.Start()
			ElseIf (pichitbox4.Bounds.IntersectsWith(piclog1.Bounds) Or pichitbox4.Bounds.IntersectsWith(piclog2.Bounds) Or pichitbox4.Bounds.IntersectsWith(piclog3.Bounds) Or pichitbox4.Bounds.IntersectsWith(piclog4.Bounds) Or pichitbox4.Bounds.IntersectsWith(piclog5.Bounds)) And invincibility = False Then
				health -= 1
				Me.lblhealth.Text = "Health: " & health
				Me.tmrnohitframes.Start()
			ElseIf (pichitbox5.Bounds.IntersectsWith(piclog1.Bounds) Or pichitbox5.Bounds.IntersectsWith(piclog2.Bounds) Or pichitbox5.Bounds.IntersectsWith(piclog3.Bounds) Or pichitbox5.Bounds.IntersectsWith(piclog4.Bounds) Or pichitbox5.Bounds.IntersectsWith(piclog5.Bounds)) And invincibility = False Then
				health -= 1
				Me.lblhealth.Text = "Health: " & health
				Me.tmrnohitframes.Start()
			ElseIf (pichitbox6.Bounds.IntersectsWith(piclog1.Bounds) Or pichitbox6.Bounds.IntersectsWith(piclog2.Bounds) Or pichitbox6.Bounds.IntersectsWith(piclog3.Bounds) Or pichitbox6.Bounds.IntersectsWith(piclog4.Bounds) Or pichitbox6.Bounds.IntersectsWith(piclog5.Bounds)) And invincibility = False Then
				health -= 1
				Me.lblhealth.Text = "Health: " & health
				Me.tmrnohitframes.Start()
			ElseIf (pichitbox7.Bounds.IntersectsWith(piclog1.Bounds) Or pichitbox7.Bounds.IntersectsWith(piclog2.Bounds) Or pichitbox7.Bounds.IntersectsWith(piclog3.Bounds) Or pichitbox7.Bounds.IntersectsWith(piclog4.Bounds) Or pichitbox7.Bounds.IntersectsWith(piclog5.Bounds)) And invincibility = False Then
				health -= 1
				Me.lblhealth.Text = "Health: " & health
				Me.tmrnohitframes.Start()
			ElseIf (pichitbox8.Bounds.IntersectsWith(piclog1.Bounds) Or pichitbox8.Bounds.IntersectsWith(piclog2.Bounds) Or pichitbox8.Bounds.IntersectsWith(piclog3.Bounds) Or pichitbox8.Bounds.IntersectsWith(piclog4.Bounds) Or pichitbox8.Bounds.IntersectsWith(piclog5.Bounds)) And invincibility = False Then
				health -= 1
				Me.lblhealth.Text = "Health: " & health
				Me.tmrnohitframes.Start()
			ElseIf (pichitbox9.Bounds.IntersectsWith(piclog1.Bounds) Or pichitbox9.Bounds.IntersectsWith(piclog2.Bounds) Or pichitbox9.Bounds.IntersectsWith(piclog3.Bounds) Or pichitbox9.Bounds.IntersectsWith(piclog4.Bounds) Or pichitbox9.Bounds.IntersectsWith(piclog5.Bounds)) And invincibility = False Then
				health -= 1
				Me.lblhealth.Text = "Health: " & health
				Me.tmrnohitframes.Start()
			ElseIf (pichitbox10.Bounds.IntersectsWith(piclog1.Bounds) Or pichitbox10.Bounds.IntersectsWith(piclog2.Bounds) Or pichitbox10.Bounds.IntersectsWith(piclog3.Bounds) Or pichitbox10.Bounds.IntersectsWith(piclog4.Bounds) Or pichitbox10.Bounds.IntersectsWith(piclog5.Bounds)) And invincibility = False Then
				health -= 1
				Me.lblhealth.Text = "Health: " & health
				Me.tmrnohitframes.Start()
			ElseIf (pichitbox11.Bounds.IntersectsWith(piclog1.Bounds) Or pichitbox11.Bounds.IntersectsWith(piclog2.Bounds) Or pichitbox11.Bounds.IntersectsWith(piclog3.Bounds) Or pichitbox11.Bounds.IntersectsWith(piclog4.Bounds) Or pichitbox11.Bounds.IntersectsWith(piclog5.Bounds)) And invincibility = False Then
				health -= 1
				Me.lblhealth.Text = "Health: " & health
				Me.tmrnohitframes.Start()
			ElseIf (pichitbox12.Bounds.IntersectsWith(piclog1.Bounds) Or pichitbox12.Bounds.IntersectsWith(piclog2.Bounds) Or pichitbox12.Bounds.IntersectsWith(piclog3.Bounds) Or pichitbox12.Bounds.IntersectsWith(piclog4.Bounds) Or pichitbox12.Bounds.IntersectsWith(piclog5.Bounds)) And invincibility = False Then
				health -= 1
				Me.lblhealth.Text = "Health: " & health
				Me.tmrnohitframes.Start()
			ElseIf (pichitbox13.Bounds.IntersectsWith(piclog1.Bounds) Or pichitbox13.Bounds.IntersectsWith(piclog2.Bounds) Or pichitbox13.Bounds.IntersectsWith(piclog3.Bounds) Or pichitbox13.Bounds.IntersectsWith(piclog4.Bounds) Or pichitbox13.Bounds.IntersectsWith(piclog5.Bounds)) And invincibility = False Then
				health -= 1
				Me.lblhealth.Text = "Health: " & health
				Me.tmrnohitframes.Start()
			ElseIf (pichitbox14.Bounds.IntersectsWith(piclog1.Bounds) Or pichitbox14.Bounds.IntersectsWith(piclog2.Bounds) Or pichitbox14.Bounds.IntersectsWith(piclog3.Bounds) Or pichitbox14.Bounds.IntersectsWith(piclog4.Bounds) Or pichitbox14.Bounds.IntersectsWith(piclog5.Bounds)) And invincibility = False Then
				health -= 1
				Me.lblhealth.Text = "Health: " & health
				Me.tmrnohitframes.Start()
			End If
		End If
		If Me.picraft.Image Is raftdown Then
			If (pichitboxgoingdown1.Bounds.IntersectsWith(piclog1.Bounds) Or pichitboxgoingdown1.Bounds.IntersectsWith(piclog2.Bounds) Or pichitboxgoingdown1.Bounds.IntersectsWith(piclog3.Bounds) Or pichitboxgoingdown1.Bounds.IntersectsWith(piclog4.Bounds) Or pichitboxgoingdown1.Bounds.IntersectsWith(piclog5.Bounds)) And invincibility = False Then
				health -= 1
				Me.lblhealth.Text = "Health: " & health
				Me.tmrnohitframes.Start()
			ElseIf (pichitboxgoingdown2.Bounds.IntersectsWith(piclog1.Bounds) Or pichitboxgoingdown2.Bounds.IntersectsWith(piclog2.Bounds) Or pichitboxgoingdown2.Bounds.IntersectsWith(piclog3.Bounds) Or pichitboxgoingdown2.Bounds.IntersectsWith(piclog4.Bounds) Or pichitboxgoingdown2.Bounds.IntersectsWith(piclog5.Bounds)) And invincibility = False Then
				health -= 1
				Me.lblhealth.Text = "Health: " & health
				Me.tmrnohitframes.Start()
			ElseIf (pichitboxgoingdown3.Bounds.IntersectsWith(piclog1.Bounds) Or pichitboxgoingdown3.Bounds.IntersectsWith(piclog2.Bounds) Or pichitboxgoingdown3.Bounds.IntersectsWith(piclog3.Bounds) Or pichitboxgoingdown3.Bounds.IntersectsWith(piclog4.Bounds) Or pichitboxgoingdown3.Bounds.IntersectsWith(piclog5.Bounds)) And invincibility = False Then
				health -= 1
				Me.lblhealth.Text = "Health: " & health
				Me.tmrnohitframes.Start()
			ElseIf (pichitboxgoingdown4.Bounds.IntersectsWith(piclog1.Bounds) Or pichitboxgoingdown4.Bounds.IntersectsWith(piclog2.Bounds) Or pichitboxgoingdown4.Bounds.IntersectsWith(piclog3.Bounds) Or pichitboxgoingdown4.Bounds.IntersectsWith(piclog4.Bounds) Or pichitboxgoingdown4.Bounds.IntersectsWith(piclog5.Bounds)) And invincibility = False Then
				health -= 1
				Me.lblhealth.Text = "Health: " & health
				Me.tmrnohitframes.Start()
			ElseIf (pichitboxgoingdown5.Bounds.IntersectsWith(piclog1.Bounds) Or pichitboxgoingdown5.Bounds.IntersectsWith(piclog2.Bounds) Or pichitboxgoingdown5.Bounds.IntersectsWith(piclog3.Bounds) Or pichitboxgoingdown5.Bounds.IntersectsWith(piclog4.Bounds) Or pichitboxgoingdown5.Bounds.IntersectsWith(piclog5.Bounds)) And invincibility = False Then
				health -= 1
				Me.lblhealth.Text = "Health: " & health
				Me.tmrnohitframes.Start()
			ElseIf (pichitboxgoingdown6.Bounds.IntersectsWith(piclog1.Bounds) Or pichitboxgoingdown6.Bounds.IntersectsWith(piclog2.Bounds) Or pichitboxgoingdown6.Bounds.IntersectsWith(piclog3.Bounds) Or pichitboxgoingdown6.Bounds.IntersectsWith(piclog4.Bounds) Or pichitboxgoingdown6.Bounds.IntersectsWith(piclog5.Bounds)) And invincibility = False Then
				health -= 1
				Me.lblhealth.Text = "Health: " & health
				Me.tmrnohitframes.Start()
			ElseIf (pichitboxgoingdown7.Bounds.IntersectsWith(piclog1.Bounds) Or pichitboxgoingdown7.Bounds.IntersectsWith(piclog2.Bounds) Or pichitboxgoingdown7.Bounds.IntersectsWith(piclog3.Bounds) Or pichitboxgoingdown7.Bounds.IntersectsWith(piclog4.Bounds) Or pichitboxgoingdown7.Bounds.IntersectsWith(piclog5.Bounds)) And invincibility = False Then
				health -= 1
				Me.lblhealth.Text = "Health: " & health
				Me.tmrnohitframes.Start()
			ElseIf (pichitboxgoingdown8.Bounds.IntersectsWith(piclog1.Bounds) Or pichitboxgoingdown8.Bounds.IntersectsWith(piclog2.Bounds) Or pichitboxgoingdown8.Bounds.IntersectsWith(piclog3.Bounds) Or pichitboxgoingdown8.Bounds.IntersectsWith(piclog4.Bounds) Or pichitboxgoingdown8.Bounds.IntersectsWith(piclog5.Bounds)) And invincibility = False Then
				health -= 1
				Me.lblhealth.Text = "Health: " & health
				Me.tmrnohitframes.Start()
			ElseIf (pichitboxgoingdown9.Bounds.IntersectsWith(piclog1.Bounds) Or pichitboxgoingdown9.Bounds.IntersectsWith(piclog2.Bounds) Or pichitboxgoingdown9.Bounds.IntersectsWith(piclog3.Bounds) Or pichitboxgoingdown9.Bounds.IntersectsWith(piclog4.Bounds) Or pichitboxgoingdown9.Bounds.IntersectsWith(piclog5.Bounds)) And invincibility = False Then
				health -= 1
				Me.lblhealth.Text = "Health: " & health
				Me.tmrnohitframes.Start()
			ElseIf (pichitboxgoingdown10.Bounds.IntersectsWith(piclog1.Bounds) Or pichitboxgoingdown10.Bounds.IntersectsWith(piclog2.Bounds) Or pichitboxgoingdown10.Bounds.IntersectsWith(piclog3.Bounds) Or pichitboxgoingdown10.Bounds.IntersectsWith(piclog4.Bounds) Or pichitboxgoingdown10.Bounds.IntersectsWith(piclog5.Bounds)) And invincibility = False Then
				health -= 1
				Me.lblhealth.Text = "Health: " & health
				Me.tmrnohitframes.Start()
			End If
		End If
		If Me.picraft.Image Is raftfront Then
			If (pichitboxforwards.Bounds.IntersectsWith(piclog1.Bounds) Or pichitboxforwards.Bounds.IntersectsWith(piclog2.Bounds) Or pichitboxforwards.Bounds.IntersectsWith(piclog3.Bounds) Or pichitboxforwards.Bounds.IntersectsWith(piclog4.Bounds) Or pichitboxforwards.Bounds.IntersectsWith(piclog5.Bounds)) And invincibility = False Then
				health -= 1
				Me.lblhealth.Text = "Health: " & health
				Me.tmrnohitframes.Start()
			End If
		End If
		If health <= 0 Then 'game is over
			Me.tmrgamelogic.Stop()
			Me.tmrlog1move.Stop()
			Me.tmrlog2move.Stop()
			Me.tmrlog3move.Stop()
			Me.tmrlog4move.Stop()
			Me.tmrlog5move.Stop()
			MsgBox("Game Over. Your raft sank", vbOKOnly, "Game Over")
			levelnumber = 1 'when start is pressed at home, this will come up
			home.Show()
			Me.tmrgamelogic.Stop()
			Me.Close()
		End If
		If logdone = 5 Then 'start turning log1 into solid ground
			Me.picraft.Image = raftfront
			Me.piclog1.Top = 0
			Me.piclog1.Height = Me.Height
			Me.tmrfinalanimation.Start()
		End If
		If raftdone = True Then 'use walking images
			Me.picraft.Height = 63
			Me.picraft.Width = 27
			Me.picraft.Image = rightimages(0)
			Me.tmrgamelogic.Stop()
		End If
	End Sub

	Private Sub tmrstagger_Tick(sender As Object, e As EventArgs) Handles tmrstagger.Tick 'stagger the logs so that they don't come at once
		staggerinterval += 1
		If staggerinterval = 5 Then
			Me.tmrlog2move.Start()
			Me.piclog2.Left = Me.Width
			Me.piclog2.Show()
		End If
		If staggerinterval = 8 Then
			Me.tmrlog3move.Start()
			Me.piclog3.Left = Me.Width
			Me.piclog3.Show()
		End If
		If staggerinterval = 12 Then
			Me.tmrlog4move.Start()
			Me.piclog4.Left = Me.Width
			Me.piclog4.Show()
		End If
		If staggerinterval = 15 Then
			Me.tmrlog5move.Start()
			Me.piclog5.Left = Me.Width
			Me.piclog5.Show()
		End If
	End Sub

	Private Sub tmrgametimer_Tick(sender As Object, e As EventArgs) Handles tmrgametimer.Tick
		gametimer += 1
		If gametimer > 600 Then 'end at one minute
			timesup = True
			Me.tmrgametimer.Stop()
		End If
	End Sub

	Private Sub tmrfinalanimation_Tick(sender As Object, e As EventArgs) Handles tmrfinalanimation.Tick
		Me.piclog1.Left -= 2
		Me.piclog1.Width += 2
		Me.picraft.Left += 1
		If Me.picraft.Left >= Me.piclog1.Left Then 'change the raft to a person
			raftdone = True
			groundleft = Me.piclog1.Left
			Me.picraft.BackColor = Color.Maroon
			Me.tmrfinalanimation.Stop()
		End If
	End Sub

	Private Sub tmrwalkup_Tick(sender As Object, e As EventArgs) Handles tmrwalkup.Tick
		upcounter += 1 'keep track of which picture it is on
		If upcounter = 4 Then
			upcounter = 0
		End If
		Me.picraft.Image = upimages(upcounter)
		If Me.picraft.Top > 0 Then 'set bounds so that the sprite cannot exit the form
			Me.picraft.Top -= 5
		End If
	End Sub

	Private Sub tmrwalkdown_Tick(sender As Object, e As EventArgs) Handles tmrwalkdown.Tick
		downcounter += 1 'keep track of the frame
		If downcounter = 4 Then
			downcounter = 0
		End If
		Me.picraft.Image = downimages(downcounter)
		If Me.picraft.Top < Me.Height - Me.picraft.Height Then 'move 5 pixels with boundaries
			Me.picraft.Top += 5
		End If
	End Sub

	Private Sub tmrwalkleft_Tick(sender As Object, e As EventArgs) Handles tmrwalkleft.Tick
		leftcounter += 1
		If leftcounter = 4 Then
			leftcounter = 0
		End If
		Me.picraft.Image = leftimages(leftcounter)
		If Me.picraft.Left > groundleft - 5 Then
			Me.picraft.Left -= 5
		End If
	End Sub

	Private Sub tmrwalkright_Tick(sender As Object, e As EventArgs) Handles tmrwalkright.Tick
		rightcounter += 1
		If rightcounter = 4 Then
			rightcounter = 0
		End If
		Me.picraft.Image = rightimages(rightcounter)
		Me.picraft.Left += 5
		If Me.picraft.Left > Me.Width - Me.picraft.Width Then 'when the player reaches the end, the next form shows
			Me.tmrgamelogic.Stop()
			Me.tmrwalkright.Stop()
			walkingintoshooter.Show()
			Me.Close()
		End If
	End Sub

	Private Sub tmrnohitframes_Tick(sender As Object, e As EventArgs) Handles tmrnohitframes.Tick
		nohitinterval += 1 'OBSOLETE, PLEASE IGNORE ANYTHING WITH THIS 
		If nohitinterval = 50 Then
			invincibility = False
			nohitinterval = 0
			Me.tmrnohitframes.Stop()
		End If
	End Sub
End Class