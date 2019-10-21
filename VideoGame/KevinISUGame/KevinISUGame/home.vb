'kevin qu
'december 13
'isu game
Public Class home
    Dim labeltext(2) As String
    Dim intervalnumber As Integer = 0  'number to keep track of which frame it is on
    Dim position As Integer = 0
	Private Sub btnControls_Click(sender As Object, e As EventArgs) Handles btnControls.Click
		control.Show() 'show controls
	End Sub
	Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		labeltext(0) = Me.lbldate.Text 'store the label values into array
		labeltext(1) = Me.lblsen1.Text
		labeltext(2) = Me.lbllastsen.Text
		Me.lbldate.Text = Nothing 'label starts as empty
		Me.lblsen1.Text = Nothing
		Me.lbllastsen.Text = Nothing
		My.Computer.Audio.Stop()
		Me.tmranimation.Start()  'start the animation timer
		Me.btnControls.Hide() 'do not make the buttons or the title appear
		Me.btnStartGame.Hide()
		Me.btnexit.Hide()
		Me.lbltitle.Hide()
	End Sub

	Private Sub tmranimation_Tick(sender As Object, e As EventArgs) Handles tmranimation.Tick
		intervalnumber += 1
		If intervalnumber = 1 Then
			My.Computer.Audio.Play(My.Resources.Pencil, AudioPlayMode.Background) 'start the audio
		End If
		If intervalnumber <= 23 And intervalnumber >= 10 Then 'text movement is delayed
			Me.lbldate.Text = labeltext(0).Substring(0, intervalnumber - 10) 'letter by letter
		ElseIf intervalnumber <= 94 And intervalnumber > 10 Then
			Me.lblsen1.Text = labeltext(1).Substring(0, intervalnumber - 23)
		ElseIf intervalnumber <= 135 And intervalnumber > 10 Then
			Me.lbllastsen.Text = labeltext(2).Substring(0, intervalnumber - 94)
		ElseIf intervalnumber = 150 And intervalnumber > 10 Then
			Me.tmranimation.Stop() 'stop text movement and start moving animation
			My.Computer.Audio.Play(My.Resources.Undertale___031___Waterfall, AudioPlayMode.BackgroundLoop)
			Me.tmrmoveup.Start()
			Me.lbltitle.Show()
			Me.btnControls.Show() 'make the 3 buttons appear
			Me.btnStartGame.Show()
			Me.btnexit.Show()
		End If
		If intervalnumber = 135 Then
			My.Computer.Audio.Stop() 'stop the audio
		End If
	End Sub
	Private Sub tmrmoveup_Tick(sender As Object, e As EventArgs) Handles tmrmoveup.Tick
		position += 10 'distance to move each interval
		If position <= 550 Then
			Me.btnControls.Top -= 10 'everything moves up until it has moved 600 pixels
			Me.btnStartGame.Top -= 10
			Me.btnexit.Top -= 10
			Me.lbltitle.Top -= 10
			Me.lbldate.Top -= 10
			Me.lblsen1.Top -= 10
			Me.lbllastsen.Top -= 10
			Me.picbackground.Top -= 10
		End If
	End Sub

	Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
		Application.Exit() 'exit the application
	End Sub

	Private Sub btnStartGame_Click(sender As Object, e As EventArgs) Handles btnStartGame.Click 'start the game according to levels
		If levelnumber = 0 Then
			firstworld.Show()
			Me.Hide()
		ElseIf levelnumber = 1 Then
			sailingnavigation.Show()
			Me.Hide()
		ElseIf levelnumber = 2 Then
			shooterlevel.Show()
			Me.Hide()
		End If
	End Sub
End Class