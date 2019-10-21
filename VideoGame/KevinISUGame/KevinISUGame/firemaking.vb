'Kevin qu
'fire plough
'january 17
Public Class firemaking
	Dim images(3) As Image
	Dim imagenumber As Integer = 0
	Dim progress As Integer = 0
	Dim singlepress As Boolean = True
	Dim wordtimecounter As Integer = 0
	Dim lastwordcounter As Integer = 0
	Dim noprogress As Boolean = False
	Dim ploughing = False
	Dim lastword As String = "To be continued..." 'declare variables
	Private Sub firemaking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		images(0) = My.Resources.fireploughposition1 'put images into array
		images(1) = My.Resources.fireploughposition2
		images(2) = My.Resources.fireploughposition3
		images(3) = My.Resources.fireploughposition2
		Me.lblprogress.Hide()
		Me.picfire.Hide()
		Me.btnhome.Hide()
		Me.tmrwordtime.Start() 'set everything up
	End Sub

	Private Sub firemaking_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
		If singlepress = True And ploughing = True Then 'make sure that the user is not moving at unfit times
			Select Case e.KeyCode
				Case Keys.Space
					progress += 1
					noprogress = False
					singlepress = False
					imagenumber += 1
					If imagenumber > 3 Then
						imagenumber = 0 'reset animations
					End If
					Me.picplough.Image = images(imagenumber)
			End Select
		End If
	End Sub

	Private Sub tmrploughspeed_Tick(sender As Object, e As EventArgs) Handles tmrploughspeed.Tick
		If noprogress = False Then
			progress -= 1
		End If
		Me.picprogressbar.Width = progress * 5 'move the progress bar
		Me.lblprogress.Text = "Progress: " & progress & "%"
		If progress <= 0 Then
			noprogress = True
			Me.lblprogress.Text = "Progress: 0%" 'cannot go below 0
		End If
		If progress >= 100 Then
			Me.lblprogress.Text = "Progress: 100%!" 'end at 100, fire starts, ending screen rolls
			ploughing = False
			Me.picplough.Image = images(0)
			Me.picfire.Show()
			Me.tmrlastwordtimer.Start()
			Me.tmrploughspeed.Stop()
		End If
	End Sub

	Private Sub firemaking_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
		Select Case e.KeyCode
			Case Keys.Space
				singlepress = True
		End Select
	End Sub

	Private Sub tmrwordtime_Tick(sender As Object, e As EventArgs) Handles tmrwordtime.Tick
		wordtimecounter += 1 'stagger between the black slide and the end of the level
		If wordtimecounter > 35 Then
			Me.lblspaceprompt.Hide()
			Me.lblprogress.Show()
			Me.tmrploughspeed.Start()
			ploughing = True
			Me.tmrwordtime.Stop()
		End If
	End Sub

	Private Sub tmrlastwordtimer_Tick(sender As Object, e As EventArgs) Handles tmrlastwordtimer.Tick
		lastwordcounter += 1
		If lastwordcounter >= 10 And lastwordcounter <= 42 Then
			Me.picblackslide.Left += 30 'sliding black screen
			Me.lblprogress.Hide()
		End If
		If lastwordcounter >= 46 And lastwordcounter <= 46 + 18 Then
			Me.lblprogress.Show()
			Me.BackgroundImage = Nothing
			Me.BackColor = Color.Black
			Me.lblprogress.Text = lastword.Substring(0, lastwordcounter - 46) 'letter by letter
		End If
		If lastwordcounter >= 170 Then
			Me.lblprogress.Text = "To be continued...     ?   -Kevin"
		End If
		If lastwordcounter >= 180 Then
			Me.btnhome.Show() 'the end
		End If
	End Sub

	Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
		levelnumber = 0
		home.Show()
		Me.Hide()
	End Sub
End Class