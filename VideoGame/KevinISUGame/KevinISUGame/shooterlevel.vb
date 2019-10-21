'kevin qu
'january 13
'wolf shooter
Public Class shooterlevel
	Dim txt(5) As String
	Dim texttimerinterval As Integer = 0 'declare variables
	Dim position As Integer = 0
	Dim wolves(99) As Integer
	Dim currentindex As Integer = 0
	Dim wordanimationdone As Boolean = False
	Dim wolvesgone As Boolean = False
	Dim wordanimationlast As Integer = 0
	Dim pressedonce As Boolean = True
	Private Sub tmrtextdisplay_Tick(sender As Object, e As EventArgs) Handles tmrtextdisplay.Tick
		texttimerinterval += 1
		If texttimerinterval >= 10 And texttimerinterval <= 41 Then
			Me.lblstartingtext.Text = txt(0).Substring(0, texttimerinterval - 10) 'letter by letter
		End If
		If texttimerinterval >= 51 And texttimerinterval <= 61 Then
			Me.lblstartingtext.Left = 321
			Me.lblstartingtext.Text = txt(1)
			Me.picwolf1.Top += 6 'wolves show up
			Me.picwolf2.Left -= 6
			Me.picwolf3.Top -= 6
			Me.picwolf4.Left += 6
		End If
		If texttimerinterval >= 100 Then
			Me.lblstartingtext.Hide() 'show and hide the controls
			Me.lblrotateleft.Text = txt(2)
			Me.lblrotateright.Text = txt(3)
			Me.lblshoot.Text = txt(4)
		End If
		If texttimerinterval >= 150 Then
			Me.lblshoot.Hide() 'hide the controls
			Me.lblrotateleft.Hide()
			Me.lblrotateright.Hide()
			wordanimationdone = True
			Me.picrockdirection.Show()
			If wolves(currentindex) = 1 Then 'get the game started
				Me.tmrwolfmovedown.Start()
			ElseIf wolves(currentindex) = 2 Then
				Me.tmrwolfmoveleft.Start()
			ElseIf wolves(currentindex) = 3 Then
				Me.tmrwolfmoveup.Start()
			ElseIf wolves(currentindex) = 4 Then
				Me.tmrwolfmoveright.Start()
			End If
		End If
	End Sub
	Private Sub shooterlevel_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
		If wordanimationdone = True And wolvesgone = False And pressedonce = True Then 'check these so that the user cannot move during cutscenes, etc
			Select Case e.KeyCode
				Case Keys.A
					pressedonce = False
					position -= 90
					position = (360 + position) Mod 360 'find the angle at which the person is facing
					If position = 0 Then 'adjust the rock pointing direction
						Me.picrockdirection.Left = Me.picplayer.Left + Me.picplayer.Width - Me.picrockdirection.Width
						Me.picrockdirection.Top = Me.picplayer.Top - Me.picrockdirection.Height
					ElseIf position = 90 Then
						Me.picrockdirection.Left = Me.picplayer.Left + Me.picplayer.Width
						Me.picrockdirection.Top = Me.picplayer.Top + Me.picplayer.Height - Me.picrockdirection.Height
					ElseIf position = 180 Then
						Me.picrockdirection.Left = Me.picplayer.Left
						Me.picrockdirection.Top = Me.picplayer.Top + Me.picplayer.Height
					ElseIf position = 270 Then
						Me.picrockdirection.Left = Me.picplayer.Left - Me.picrockdirection.Width
						Me.picrockdirection.Top = Me.picplayer.Top
					End If
				Case Keys.D
					pressedonce = False
					position += 90
					position = position Mod 360
					If position = 0 Then
						Me.picrockdirection.Left = Me.picplayer.Left + Me.picplayer.Width - Me.picrockdirection.Width
						Me.picrockdirection.Top = Me.picplayer.Top - Me.picrockdirection.Height
					ElseIf position = 90 Then
						Me.picrockdirection.Left = Me.picplayer.Left + Me.picplayer.Width
						Me.picrockdirection.Top = Me.picplayer.Top + Me.picplayer.Height - Me.picrockdirection.Height
					ElseIf position = 180 Then
						Me.picrockdirection.Left = Me.picplayer.Left
						Me.picrockdirection.Top = Me.picplayer.Top + Me.picplayer.Height
					ElseIf position = 270 Then
						Me.picrockdirection.Left = Me.picplayer.Left - Me.picrockdirection.Width
						Me.picrockdirection.Top = Me.picplayer.Top
					End If
				Case Keys.Space
					pressedonce = False
					If position = 0 Then
						tmrrockmovingup.Start() 'shoot the rocks
						Me.picrockup.Show()
					ElseIf position = 90 Then
						tmrrockmovingright.Start()
						Me.picrockright.Show()
					ElseIf position = 180 Then
						tmrrockmovingdown.Start()
						Me.picrockdown.Show()
					ElseIf position = 270 Then
						tmrrockmovingleft.Start()
						Me.picrockleft.Show()
					End If
			End Select
		End If
	End Sub
	Private Sub shooterlevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.tmrtextdisplay.Start()
		txt(0) = Me.lblstartingtext.Text
		txt(1) = "Wolves!"
		txt(2) = Me.lblrotateleft.Text
		txt(3) = Me.lblrotateright.Text
		txt(4) = Me.lblshoot.Text
		txt(5) = Me.lblwolvesgone.Text
		Me.lblwolvesgone.Text = Nothing
		Me.lblstartingtext.Text = Nothing
		Me.lblrotateleft.Text = Nothing
		Me.lblrotateright.Text = Nothing
		Me.lblshoot.Text = Nothing 'all of the above is for letter by letter
		For i = 0 To 99
			Randomize()
			wolves(i) = CInt((4 - 1 + 1) * Rnd() + 1) 'create random positions for the wolves
		Next
		Me.picrockdirection.Hide()
	End Sub

	Private Sub tmrrockmovingup_Tick(sender As Object, e As EventArgs) Handles tmrrockmovingup.Tick
		Me.picrockup.Top -= 8 'movements
		If Me.picrockup.Bounds.IntersectsWith(Me.picwolf1.Bounds) Then 'reset if a wolf is hit
			Me.tmrrockmovingup.Stop()
			Me.picrockup.Top = Me.picwolf2.Top
			Me.picrockup.Left = Me.picwolf1.Left 'adjust picturebox positions
			Me.picwolf1.Top = -Me.picwolf1.Height
			Me.tmrwolfmovedown.Stop()
			Me.picrockup.Hide()
			If currentindex < 99 Then 'keep wolves coming until the limit is reached
				currentindex += 1
			Else
				wolvesgone = True
				Me.tmrfinaltext.Start()
				Me.tmrwolfmovedown.Stop()
				Me.tmrwolfmoveleft.Stop()
				Me.tmrwolfmoveup.Stop()
				Me.tmrwolfmoveright.Stop()
			End If
			If wolves(currentindex) = 1 Then 'next wolf
				Me.tmrwolfmovedown.Start()
				Me.picwolf1.Show()
			ElseIf wolves(currentindex) = 2 Then
				Me.tmrwolfmoveleft.Start()
				Me.picwolf2.Show()
			ElseIf wolves(currentindex) = 3 Then
				Me.tmrwolfmoveup.Start()
				Me.picwolf3.Show()
			ElseIf wolves(currentindex) = 4 Then
				Me.tmrwolfmoveright.Start()
				Me.picwolf4.Show()
			End If
		End If
	End Sub

	Private Sub tmrrockmovingright_Tick(sender As Object, e As EventArgs) Handles tmrrockmovingright.Tick
		Me.picrockright.Left += 8
		If Me.picrockright.Bounds.IntersectsWith(Me.picwolf2.Bounds) Then
			Me.tmrrockmovingright.Stop()
			Me.picrockright.Top = Me.picwolf2.Top
			Me.picrockright.Left = Me.picwolf1.Left
			Me.picwolf2.Left = Me.Width + Me.picwolf2.Width
			Me.tmrwolfmoveleft.Stop()
			Me.picrockright.Hide()
			If currentindex < 99 Then
				currentindex += 1
			Else
				wolvesgone = True
				Me.tmrfinaltext.Start()
				Me.tmrwolfmovedown.Stop()
				Me.tmrwolfmoveleft.Stop()
				Me.tmrwolfmoveup.Stop()
				Me.tmrwolfmoveright.Stop()
			End If
			If wolves(currentindex) = 1 Then
				Me.tmrwolfmovedown.Start()
				Me.picwolf1.Show()
			ElseIf wolves(currentindex) = 2 Then
				Me.tmrwolfmoveleft.Start()
				Me.picwolf2.Show()
			ElseIf wolves(currentindex) = 3 Then
				Me.tmrwolfmoveup.Start()
				Me.picwolf3.Show()
			ElseIf wolves(currentindex) = 4 Then
				Me.tmrwolfmoveright.Start()
				Me.picwolf4.Show()
			End If
		End If
	End Sub

	Private Sub tmrrockmovingdown_Tick(sender As Object, e As EventArgs) Handles tmrrockmovingdown.Tick
		Me.picrockdown.Top += 8
		If Me.picrockdown.Bounds.IntersectsWith(Me.picwolf3.Bounds) Then
			Me.tmrrockmovingdown.Stop()
			Me.picrockdown.Top = Me.picwolf2.Top
			Me.picrockdown.Left = Me.picwolf1.Left
			Me.picwolf3.Top = Me.Height
			Me.tmrwolfmoveup.Stop()
			Me.picrockdown.Hide()
			If currentindex < 99 Then
				currentindex += 1
			Else
				wolvesgone = True
				Me.tmrfinaltext.Start()
				Me.tmrwolfmovedown.Stop()
				Me.tmrwolfmoveleft.Stop()
				Me.tmrwolfmoveup.Stop()
				Me.tmrwolfmoveright.Stop()
			End If
			If wolves(currentindex) = 1 Then
				Me.tmrwolfmovedown.Start()
				Me.picwolf1.Show()
			ElseIf wolves(currentindex) = 2 Then
				Me.tmrwolfmoveleft.Start()
				Me.picwolf2.Show()
			ElseIf wolves(currentindex) = 3 Then
				Me.tmrwolfmoveup.Start()
				Me.picwolf3.Show()
			ElseIf wolves(currentindex) = 4 Then
				Me.tmrwolfmoveright.Start()
				Me.picwolf4.Show()
			End If
		End If
	End Sub

	Private Sub tmrrockmovingleft_Tick(sender As Object, e As EventArgs) Handles tmrrockmovingleft.Tick
		Me.picrockleft.Left -= 8
		If Me.picrockleft.Bounds.IntersectsWith(Me.picwolf4.Bounds) Or Me.picrockleft.Left < -Me.picrockleft.Width Then
			Me.tmrrockmovingleft.Stop()
			Me.picrockleft.Top = Me.picwolf2.Top
			Me.picrockleft.Left = Me.picwolf1.Left
			Me.picwolf4.Left = -Me.picwolf4.Width
			Me.tmrwolfmoveright.Stop()
			Me.picrockleft.Hide()
			If currentindex < 99 Then
				currentindex += 1
			Else
				wolvesgone = True
				Me.tmrfinaltext.Start()
				Me.tmrwolfmovedown.Stop()
				Me.tmrwolfmoveleft.Stop()
				Me.tmrwolfmoveup.Stop()
				Me.tmrwolfmoveright.Stop()
			End If
			If wolves(currentindex) = 1 Then
				Me.tmrwolfmovedown.Start()
				Me.picwolf1.Show()
			ElseIf wolves(currentindex) = 2 Then
				Me.tmrwolfmoveleft.Start()
				Me.picwolf2.Show()
			ElseIf wolves(currentindex) = 3 Then
				Me.tmrwolfmoveup.Start()
				Me.picwolf3.Show()
			ElseIf wolves(currentindex) = 4 Then
				Me.tmrwolfmoveright.Start()
				Me.picwolf4.Show()
			End If
		End If
	End Sub

	Private Sub tmrwolfmovedown_Tick(sender As Object, e As EventArgs) Handles tmrwolfmovedown.Tick
		Me.picwolf1.Top += 2
		If Me.picwolf1.Bounds.IntersectsWith(Me.picplayer.Bounds) Then
			Me.tmrfinaltext.Stop()
			Me.tmrrockmovingdown.Stop()
			Me.tmrrockmovingup.Stop()
			Me.tmrrockmovingleft.Stop()
			Me.tmrrockmovingright.Stop()
			Me.tmrtextdisplay.Stop()
			Me.tmrwolfmovedown.Stop()
			Me.tmrwolfmoveleft.Stop()
			Me.tmrwolfmovedown.Stop()
			Me.tmrwolfmoveup.Stop()
			levelnumber += 1
			MsgBox("You have been killed by the wolves.", vbOKOnly) 'game resets
			home.Show()
			Me.Close()
		End If
	End Sub

	Private Sub tmrwolfmoveleft_Tick(sender As Object, e As EventArgs) Handles tmrwolfmoveleft.Tick
		Me.picwolf2.Left -= 2
		If Me.picwolf2.Bounds.IntersectsWith(Me.picplayer.Bounds) Then
			Me.tmrfinaltext.Stop()
			Me.tmrrockmovingdown.Stop()
			Me.tmrrockmovingup.Stop()
			Me.tmrrockmovingleft.Stop()
			Me.tmrrockmovingright.Stop()
			Me.tmrtextdisplay.Stop()
			Me.tmrwolfmovedown.Stop()
			Me.tmrwolfmoveleft.Stop()
			Me.tmrwolfmovedown.Stop()
			Me.tmrwolfmoveup.Stop()
			levelnumber += 1
			MsgBox("You have been killed by the wolves.", vbOKOnly)
			home.Show()
			Me.Close()
		End If
	End Sub

	Private Sub tmrwolfmoveup_Tick(sender As Object, e As EventArgs) Handles tmrwolfmoveup.Tick
		Me.picwolf3.Top -= 2
		If Me.picwolf3.Bounds.IntersectsWith(Me.picplayer.Bounds) Then
			Me.tmrfinaltext.Stop()
			Me.tmrrockmovingdown.Stop()
			Me.tmrrockmovingup.Stop()
			Me.tmrrockmovingleft.Stop()
			Me.tmrrockmovingright.Stop()
			Me.tmrtextdisplay.Stop()
			Me.tmrwolfmovedown.Stop()
			Me.tmrwolfmoveleft.Stop()
			Me.tmrwolfmovedown.Stop()
			Me.tmrwolfmoveup.Stop()
			levelnumber += 1
			MsgBox("You have been killed by the wolves.", vbOKOnly)
			home.Show()
			Me.Close()
		End If
	End Sub

	Private Sub tmrwolfmoveright_Tick(sender As Object, e As EventArgs) Handles tmrwolfmoveright.Tick
		Me.picwolf4.Left += 2
		If Me.picwolf4.Bounds.IntersectsWith(Me.picplayer.Bounds) Then
			Me.tmrfinaltext.Stop()
			Me.tmrrockmovingdown.Stop()
			Me.tmrrockmovingup.Stop()
			Me.tmrrockmovingleft.Stop()
			Me.tmrrockmovingright.Stop()
			Me.tmrtextdisplay.Stop()
			Me.tmrwolfmovedown.Stop()
			Me.tmrwolfmoveleft.Stop()
			Me.tmrwolfmovedown.Stop()
			Me.tmrwolfmoveup.Stop()
			levelnumber += 1
			MsgBox("You have been killed by the wolves.", vbOKOnly)
			home.Show()
			Me.Close()
		End If
	End Sub

	Private Sub tmrfinaltext_Tick(sender As Object, e As EventArgs) Handles tmrfinaltext.Tick
		wordanimationlast += 1
		If wordanimationlast > 5 And wordanimationlast < 64 + 5 Then
			Me.lblwolvesgone.Text = txt(5).Substring(0, wordanimationlast - 5) 'letter by letter
			Me.tmrwolfmovedown.Stop()
			Me.tmrwolfmoveleft.Stop()
			Me.tmrwolfmovedown.Stop()
			Me.tmrwolfmoveup.Stop()
		ElseIf wordanimationlast > 64 + 5 + 15 Then
			Me.tmrfinaltext.Stop()
			Me.tmrrockmovingdown.Stop()
			Me.tmrrockmovingup.Stop()
			Me.tmrrockmovingleft.Stop()
			Me.tmrrockmovingright.Stop()
			Me.tmrtextdisplay.Stop()
			Me.tmrwolfmovedown.Stop()
			Me.tmrwolfmoveleft.Stop()
			Me.tmrwolfmovedown.Stop()
			Me.tmrwolfmoveup.Stop()
			firemaking.Show()
			Me.Close()
		End If
	End Sub

	Private Sub shooterlevel_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
		Select Case e.KeyCode
			Case Keys.A
				pressedonce = True
			Case Keys.D
				pressedonce = True
			Case Keys.Space
				pressedonce = True
		End Select
	End Sub
End Class