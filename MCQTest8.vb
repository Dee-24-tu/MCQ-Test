Public Class frmMCQTest8

    Private Sub frmMCQTest8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.LightCyan 'Default background color

        counter = 25
        user = frmlogon.cmbusers.Text

        'setting for the tester to see correct answers 
        If user = "Tester" Then
            lblanswerfeedb.Text = "Correct answer: " & correct_answer(7)
            tmrcountdown.Enabled = False
            lblqcount.Visible = False
        Else
            lblanswerfeedb.Text = "How did you do...?"
            tmrcountdown.Enabled = True
        End If

        lblqindex.Text = Q_number(7)
        lblquestion.Text = question(7)
        lbloption1.Text = optionA(7)
        lbloption2.Text = optionB(7)
        lbloption3.Text = optionC(7)
        lbloption4.Text = optionD(7)

        txtanswer.Focus()

    End Sub

    Private Sub tmrcontdown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrcountdown.Tick
        counter -= 1
        lblcounter.Text = counter & " seconds left!"

        If counter < 6 Then
            lblcounter.Text = "Running out of time! " & user & " " & counter & " seconds left!"
        End If

        If counter = 0 Then
            tmrcountdown.Enabled = False
            'When time reach 0 the window will close and leading window opened
            Call cmdnext_Click_1(cmdnext, New System.EventArgs())
        End If

    End Sub

    Private Sub cmdnext_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnext.Click
        On Error Resume Next
        accumulator1 += counter 'seconds to complete test

        frmMCQTest9.Show()
        tmrcountdown.Enabled = False
        Me.Hide()
        txtanswer.Text = ""
        lblqcount.Text = "Score so far is " & score
        lblcounter.Text = "You have 25 seconds"

    End Sub

    Private Sub txtanswer_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtanswer.TextChanged
        answer_choosen = txtanswer.Text.ToUpper() 'Convert the input into an uppercase letter for case sensitive

        If answer_choosen = "B" Then
            score += 1
            lblanswerfeedb.Text = "Correct"
            lblqcount.Text = "Your score " & score
        Else
            lblanswerfeedb.Text = "Wrong Answer! "
            lblqcount.Text = "Your score " & score
        End If

    End Sub

    Private Sub cmbexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbexit.Click
        On Error Resume Next
        frmTestResults.Show()
        Me.Hide()

    End Sub
End Class