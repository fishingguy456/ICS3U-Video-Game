'kevin qu
'january 12
Public Class walkingintoshooter
	Dim pictureframes(4) As Image
	Dim upcounter As Integer = 0 'declare variables
	Dim downcounter As Integer = 0
	Dim leftcounter As Integer = 0
	Dim rightcounter As Integer = 0
	Dim upimages(3) As Image
	Dim downimages(3) As Image
	Dim leftimages(3) As Image
	Dim rightimages(3) As Image
	Dim allowdownmovement As Boolean = False
	Dim allowleftmovement As Boolean = False
	Dim allowrightmovement As Boolean = False
	Dim allowupmovement As Boolean = False
	Private Sub walkingintoshooter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
		Me.tmrgamelogic.Start()
	End Sub

	Private Sub walkingintoshooter_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
		Select Case e.KeyCode 'stop walking when the button is released
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

	Private Sub walkingintoshooter_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
		If Not Me.picplayer.Bounds.IntersectsWith(Me.picboundary1.Bounds) And Not Me.picplayer.Bounds.IntersectsWith(Me.picboundary2.Bounds) And Not Me.picplayer.Bounds.IntersectsWith(Me.picboundary3.Bounds) And Not Me.picplayer.Bounds.IntersectsWith(Me.picboundary4.Bounds) And Not Me.picplayer.Bounds.IntersectsWith(Me.picboundary5.Bounds) And Not Me.picplayer.Bounds.IntersectsWith(Me.picboundary6.Bounds) And Not Me.picplayer.Bounds.IntersectsWith(Me.picboundary7.Bounds) Then 'set bounds so that the sprite cannot exit the form
			Me.picplayer.Top -= 5
		Else
			allowdownmovement = True
		End If
		If allowdownmovement = True Then
			Me.picplayer.Top += 5
			allowdownmovement = False
			Me.tmrup.Stop()
		End If
	End Sub

	Private Sub tmrdown_Tick(sender As Object, e As EventArgs) Handles tmrdown.Tick
		downcounter += 1 'keep track of the frame
		If downcounter = 4 Then
			downcounter = 0
		End If
		Me.picplayer.Image = downimages(downcounter)
		If Me.picplayer.Top < Me.Height - Me.picplayer.Height And Not Me.picplayer.Bounds.IntersectsWith(Me.picboundary1.Bounds) And Not Me.picplayer.Bounds.IntersectsWith(Me.picboundary2.Bounds) And Not Me.picplayer.Bounds.IntersectsWith(Me.picboundary3.Bounds) And Not Me.picplayer.Bounds.IntersectsWith(Me.picboundary4.Bounds) And Not Me.picplayer.Bounds.IntersectsWith(Me.picboundary5.Bounds) And Not Me.picplayer.Bounds.IntersectsWith(Me.picboundary6.Bounds) And Not Me.picplayer.Bounds.IntersectsWith(Me.picboundary7.Bounds) Then 'move 5 pixels with boundaries
			Me.picplayer.Top += 5
		Else
			allowupmovement = True
		End If
		If allowupmovement = True Then
			Me.picplayer.Top -= 5
			allowupmovement = False
			Me.tmrdown.Stop()
		End If
	End Sub

	Private Sub tmrleft_Tick(sender As Object, e As EventArgs) Handles tmrleft.Tick
		leftcounter += 1
		If leftcounter = 4 Then
			leftcounter = 0
		End If
		Me.picplayer.Image = leftimages(leftcounter)
		If Me.picplayer.Left > 0 And Not Me.picplayer.Bounds.IntersectsWith(Me.picboundary1.Bounds) And Not Me.picplayer.Bounds.IntersectsWith(Me.picboundary2.Bounds) And Not Me.picplayer.Bounds.IntersectsWith(Me.picboundary3.Bounds) And Not Me.picplayer.Bounds.IntersectsWith(Me.picboundary4.Bounds) And Not Me.picplayer.Bounds.IntersectsWith(Me.picboundary5.Bounds) And Not Me.picplayer.Bounds.IntersectsWith(Me.picboundary6.Bounds) And Not Me.picplayer.Bounds.IntersectsWith(Me.picboundary7.Bounds) Then
			Me.picplayer.Left -= 5
		Else
			allowrightmovement = True
		End If
		If allowrightmovement = True Then
			Me.picplayer.Left += 5
			allowrightmovement = False
			Me.tmrleft.Stop()
		End If
	End Sub

	Private Sub tmrright_Tick(sender As Object, e As EventArgs) Handles tmrright.Tick
		rightcounter += 1
		If rightcounter = 4 Then
			rightcounter = 0
		End If
		Me.picplayer.Image = rightimages(rightcounter)
		If Me.picplayer.Left < Me.Width - Me.picplayer.Width And Not Me.picplayer.Bounds.IntersectsWith(Me.picboundary1.Bounds) And Not Me.picplayer.Bounds.IntersectsWith(Me.picboundary2.Bounds) And Not Me.picplayer.Bounds.IntersectsWith(Me.picboundary3.Bounds) And Not Me.picplayer.Bounds.IntersectsWith(Me.picboundary4.Bounds) And Not Me.picplayer.Bounds.IntersectsWith(Me.picboundary5.Bounds) And Not Me.picplayer.Bounds.IntersectsWith(Me.picboundary6.Bounds) And Not Me.picplayer.Bounds.IntersectsWith(Me.picboundary7.Bounds) Then
			Me.picplayer.Left += 5
		Else
			allowleftmovement = True
		End If
		If allowleftmovement = True Then
			Me.picplayer.Left -= 5
			allowleftmovement = False
			Me.tmrright.Stop()
		End If
	End Sub

	Private Sub tmrgamelogic_Tick(sender As Object, e As EventArgs) Handles tmrgamelogic.Tick
		If Me.picplayer.Bounds.IntersectsWith(Me.picendoftheroad.Bounds) Then
			shooterlevel.Show()
			Me.tmrgamelogic.Stop()
			Me.Hide()
		End If
	End Sub
End Class