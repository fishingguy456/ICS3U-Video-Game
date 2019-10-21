'kevin qu
'december 14
'controls
Public Class control
	Dim counter As Integer = 0 'declare variables
	Dim upimages(3) As Image
	Dim downimages(3) As Image
	Dim leftimages(3) As Image
	Dim rightimages(3) As Image
	Private Sub btnGotit_Click(sender As Object, e As EventArgs) Handles btnGotit.Click
		home.Show()
		Me.Hide() 'close the controls
	End Sub

	Private Sub btntryitout_Click(sender As Object, e As EventArgs) Handles btntryitout.Click
		movementtest.Show() 'show the trying out controls form
		Me.Hide()
	End Sub

	Private Sub control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.tmrwalking.Start()
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

	Private Sub tmrup_Tick(sender As Object, e As EventArgs) Handles tmrwalking.Tick
		counter += 1 'keep track of which frame it is on
		If counter > 3 Then
			counter = 0
		End If
		Me.picup.Image = upimages(counter)
		Me.picdown.Image = downimages(counter)
		Me.picright.Image = rightimages(counter)
		Me.picleft.Image = leftimages(counter)
	End Sub
End Class