Public Class frmMCQTest1

    Private Sub frmMCQQuiz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.LightCyan 'Default background color

        user = frmlogon.cmbusers.Text
        'setting for the tester to see correct answers 
        If user = "Tester" Then
            lblanswerfeedb.Text = "Correct answer: " & correct_answer(0)
            tmrcountdown.Enabled = False
            lblqcount.Visible = False
            lblsubh.Visible = False
            cmdstartest.Visible = False

            'display question on load only for the tester
            lblqindex.Text = Q_number(0)
            lblquestion.Text = question(0)
            lbloption1.Text = optionA(0)
            lbloption2.Text = optionB(0)
            lbloption3.Text = optionC(0)
            lbloption4.Text = optionD(0)

            txtanswer.Focus()
        Else
            score = 0
            counter = 25

            cmdstartest.Visible = True
            lblsubh.Visible = True
            lblanswerfeedb.Text = "How did you do...?"
        End If

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

        frmMCQTest2.Show()
        tmrcountdown.Enabled = False
        Me.Hide()
        txtanswer.Text = ""
        lblqcount.Text = "Score so far is " & score
        lblcounter.Text = "You have 25 seconds"

    End Sub

    Private Sub txtanswer_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtanswer.TextChanged
        answer_choosen = txtanswer.Text.ToUpper() 'Convert the input into an uppercase letter for case sensitive

        If answer_choosen = "A" Then
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

    Private Sub cmdstartest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstartest.Click
        On Error Resume Next
        lblsubh.Visible = False
        cmdstartest.Visible = False

        ' Show the question and options for student after pressing start
        lblqindex.Text = Q_number(0)
        lblquestion.Text = question(0)
        lbloption1.Text = optionA(0)
        lbloption2.Text = optionB(0)
        lbloption3.Text = optionC(0)
        lbloption4.Text = optionD(0)

        txtanswer.Focus()
        tmrcountdown.Enabled = True

    End Sub

End Class