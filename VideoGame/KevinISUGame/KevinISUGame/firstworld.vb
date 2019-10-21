'kevin qu
'december 19
'first scene
Public Class firstworld
	Dim pictureframes(4) As Image
	Dim counter As Integer = -1
	Dim lastframe As Boolean = False
	Dim upcounter As Integer = 0 'declare variables
	Dim downcounter As Integer = 0
	Dim leftcounter As Integer = 0
	Dim rightcounter As Integer = 0
	Dim upimages(3) As Image
	Dim downimages(3) As Image
	Dim leftimages(3) As Image
	Dim rightimages(3) As Image
	Private Sub firstworld_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown  'when the keys is pressed, a timer waits until the key is released
		Select Case e.KeyCode
			Case Keys.W
				Me.tmrup.Start() 'execute the commands inside of the timer
			Case Keys.A
				Me.tmrleft.Start()
			Case Keys.S
				Me.tmrdown.Start()
			Case Keys.D
				Me.tmrright.Start()
		End Select
	End Sub

	Private Sub tmrup_Tick(sender As Object, e As EventArgs) Handles tmrup.Tick
		upcounter += 1 'keep track of which picture it is on
		If upcounter = 4 Then
			upcounter = 0
		End If
		Me.picplayer.Image = upimages(upcounter)
		If Me.picplayer.Top > 0 And Not Me.picplayer.Bounds.IntersectsWith(Me.picboundary.Bounds) Then 'set bounds so that the sprite cannot exit the form
			Me.picplayer.Top -= 5
		End If
	End Sub

	Private Sub tmrdown_Tick(sender As Object, e As EventArgs) Handles tmrdown.Tick
		downcounter += 1 'keep track of the frame
		If downcounter = 4 Then
			downcounter = 0
		End If
		Me.picplayer.Image = downimages(downcounter)
		If Me.picplayer.Top < Me.Height - Me.picplayer.Height Then 'move 5 pixels with boundaries
			Me.picplayer.Top += 5
		End If
	End Sub

	Private Sub tmrleft_Tick(sender As Object, e As EventArgs) Handles tmrleft.Tick
		leftcounter += 1
		If leftcounter = 4 Then
			leftcounter = 0
		End If
		Me.picplayer.Image = leftimages(leftcounter)
		If Me.picplayer.Left > 0 Then
			Me.picplayer.Left -= 5
		End If
	End Sub

	Private Sub tmrright_Tick(sender As Object, e As EventArgs) Handles tmrright.Tick
		rightcounter += 1
		If rightcounter = 4 Then
			rightcounter = 0
		End If
		Me.picplayer.Image = rightimages(rightcounter)
		Me.picplayer.Left += 5
		If Me.picplayer.Left > Me.Width - Me.picplayer.Width Then 'when the player reaches the end, the next form shows
			finalposition = Me.picplayer.Top
			firstworldsecondpart.Show()
			Me.tmrright.Stop()
			Me.Hide()
		End If
	End Sub

	Private Sub firstworld_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp  'stop moving when the key is released
		Select Case e.KeyCode
			Case Keys.W
				Me.tmrup.Stop()
			Case Keys.A
				Me.tmrleft.Stop()
			Case Keys.S
				Me.tmrdown.Stop()
			Case Keys.D
				Me.tmrright.Stop()
		End Select
	End Sub
	Private Sub tmrstandingup_Tick(sender As Object, e As EventArgs) Handles tmrstandingup.Tick
		counter += 1
		If counter = 5 Then
			Me.tmrstandingup.Stop()
			lastframe = True
		End If
		If counter = 0 Then
			Me.picplayer.Width = 63 'adjust the picturebox size when there is a new picture
			Me.picplayer.Height = 27
		ElseIf counter = 1 Then
			Me.picplayer.Width = 63
			Me.picplayer.Height = 27
		ElseIf counter = 2 Then
			Me.picplayer.Width = 36
			Me.picplayer.Height = 36
		ElseIf counter = 3 Then
			Me.picplayer.Width = 36
			Me.picplayer.Height = 36
		ElseIf counter = 4 Then
			Me.picplayer.Width = 27
			Me.picplayer.Height = 63
		End If
		If lastframe = False Then
			Me.picplayer.Image = pictureframes(counter)
		End If
	End Sub

	Private Sub firstworld_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
		pictureframes(0) = My.Resources.lyingdown
		pictureframes(1) = My.Resources.gettingup
		pictureframes(2) = My.Resources.satup
		pictureframes(3) = My.Resources.legsbent
		pictureframes(4) = My.Resources.facingleft
		Me.tmrstandingup.Start()
	End Sub
End Class