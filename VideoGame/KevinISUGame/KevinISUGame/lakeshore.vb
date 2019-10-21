'kevin qu
'december 21
'lakeside cutscene
Public Class lakeshore
	Dim txt(1) As String
	Dim timerinterval As Integer = 0
	Private Sub lakeshore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.tmrtextanimation.Start()
		txt(0) = Me.lblfirstsentence.Text 'store the labels and empty them
		txt(1) = Me.lblsecondsentence.Text
		Me.lblfirstsentence.Text = Nothing
		Me.lblsecondsentence.Text = Nothing
	End Sub

	Private Sub tmrtextanimation_Tick(sender As Object, e As EventArgs) Handles tmrtextanimation.Tick
		timerinterval += 1
		If timerinterval >= 30 And timerinterval <= 28 + 30 Then 'letter by letter with a delay
			Me.lblfirstsentence.Text = txt(0).Substring(0, timerinterval - 30)
		ElseIf timerinterval > 28 + 30 And timerinterval <= 28 + 50 + 30 Then
			Me.lblsecondsentence.Text = txt(1).Substring(0, timerinterval - 28 - 30)
		ElseIf timerinterval > 20 + 28 + 50 + 30 Then
			sailingnavigation.Show()
			Me.tmrtextanimation.Stop()
			Me.Hide() 'next form
		End If
	End Sub
End Class