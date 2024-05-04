﻿Public Class frmMCQTest9

    Private Sub frmMCQTest9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.LightCyan 'Default background color

        counter = 25
        user = frmlogon.cmbusers.Text

        'setting for the tester to see correct answers 
        If user = "Tester" Then
            lblanswerfeedb.Text = "Correct answer: " & correct_answer(8)
            tmrcountdown.Enabled = False
            lblqcount.Visible = False
        Else
            lblanswerfeedb.Text = "How did you do...?"
            tmrcountdown.Enabled = True
        End If

        lblqindex.Text = Q_number(8)
        lblquestion.Text = question(8)
        lbloption1.Text = optionA(8)
        lbloption2.Text = optionB(8)
        lbloption3.Text = optionC(8)
        lbloption4.Text = optionD(8)

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

        frmMCQTest10.Show()
        tmrcountdown.Enabled = False
        Me.Hide()
        txtanswer.Text = ""
        lblqcount.Text = "Score so far is " & score
        lblcounter.Text = "You have 25 seconds"

    End Sub

    Private Sub txtanswer_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtanswer.TextChanged
        answer_choosen = txtanswer.Text.ToUpper() 'Convert the input into an uppercase letter for case sensitive

        If answer_choosen = "C" Then
            score += 1
            lblanswerfeedb.Text = "Correct"
            lblqcount.Text = "Your score " & score
        Else
            lblanswerfeedb.Text = "Wrong Answer! "
            lblqcount.Text = "Your score " & score
        End If

    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        On Error Resume Next
        frmTestResults.Show()
        Me.Hide()
    End Sub
End Class