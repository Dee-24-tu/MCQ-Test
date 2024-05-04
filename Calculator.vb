Public Class frmcalculator

    Private Sub frmcalculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.LightCyan 'Default background color

    End Sub

    Private Sub cmd0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd0.Click
        On Error Resume Next
        lblresults.Text = ""
        txtdisplay.Text = txtdisplay.Text & "0"

    End Sub

    Private Sub cmd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click
        On Error Resume Next
        lblresults.Text = ""
        txtdisplay.Text = txtdisplay.Text & "1"

    End Sub

    Private Sub cmd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd2.Click
        On Error Resume Next
        lblresults.Text = ""
        txtdisplay.Text = txtdisplay.Text & "2"

    End Sub

    Private Sub cmd3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd3.Click
        On Error Resume Next
        lblresults.Text = ""
        txtdisplay.Text = txtdisplay.Text & "3"

    End Sub

    Private Sub cmd4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd4.Click
        On Error Resume Next
        lblresults.Text = ""
        txtdisplay.Text = txtdisplay.Text & "4"

    End Sub

    Private Sub cmd5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd5.Click
        On Error Resume Next
        lblresults.Text = ""
        txtdisplay.Text = txtdisplay.Text & "5"

    End Sub

    Private Sub cmd6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd6.Click
        On Error Resume Next
        lblresults.Text = ""
        txtdisplay.Text = txtdisplay.Text & "6"

    End Sub

    Private Sub cmd7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd7.Click
        On Error Resume Next
        lblresults.Text = ""
        txtdisplay.Text = txtdisplay.Text & "7"

    End Sub

    Private Sub cmd8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd8.Click
        On Error Resume Next
        lblresults.Text = ""
        txtdisplay.Text = txtdisplay.Text & "8"

    End Sub

    Private Sub cmd9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd9.Click
        On Error Resume Next
        lblresults.Text = ""
        txtdisplay.Text = txtdisplay.Text & "9"

    End Sub

    Private Sub cmdDecimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDecimal.Click
        On Error Resume Next
        countdecimal = countdecimal + 1 'Set to remove the repeat of decimal

        If countdecimal = 1 Then
            lblresults.Text = ""
            txtdisplay.Text = txtdisplay.Text & "."
        End If

    End Sub

    Private Sub cmdequals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdequals.Click
        On Error Resume Next
        number2 = txtdisplay.Text

        If an_operator = 1 Then
            calc_answer = number1 + number2
            txtdisplay.Text = ""
            lblresults.Text = calc_answer
        End If

        If an_operator = 2 Then
            calc_answer = number1 * number2
            txtdisplay.Text = ""
            lblresults.Text = calc_answer
        End If

        If an_operator = 3 Then
            calc_answer = number1 / number2
            txtdisplay.Text = ""
            lblresults.Text = calc_answer
        End If

        If an_operator = 4 Then
            calc_answer = number1 - number2
            txtdisplay.Text = ""
            lblresults.Text = calc_answer
        End If

    End Sub

    Private Sub cmdplus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplus.Click
        On Error Resume Next
        countdecimal = 0 'Set to remove the repeat of decimal
        number1 = txtdisplay.Text
        an_operator = 1
        txtdisplay.Text = ""

    End Sub

    Private Sub cmdminus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdminus.Click
        On Error Resume Next
        countdecimal = 0 'Set to remove the repeat of decimal
        number1 = txtdisplay.Text
        an_operator = 4
        txtdisplay.Text = ""

    End Sub

    Private Sub cmddivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddivide.Click
        On Error Resume Next
        countdecimal = 0 'Set to remove the repeat of decimal
        number1 = txtdisplay.Text
        an_operator = 3
        txtdisplay.Text = ""

    End Sub

    Private Sub cmdmultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmultiply.Click
        On Error Resume Next
        countdecimal = 0 'Set to remove the repeat of decimal
        number1 = txtdisplay.Text
        an_operator = 2
        txtdisplay.Text = ""

    End Sub

    Private Sub cmdsquareroot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsquareroot.Click
        On Error Resume Next
        sqrt_number = txtdisplay.Text
        sqrt = System.Math.Sqrt(sqrt_number)
        Me.lblresults.Text = sqrt
        txtdisplay.Text = "√" & txtdisplay.Text

    End Sub

    Private Sub cmdmemoryplus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmemoryplus.Click
        On Error Resume Next
        memPlus += calc_answer
        txtdisplay.Text = ""

    End Sub

    Private Sub cmdMemoryRecall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMemoryRecall.Click
        On Error Resume Next
        lblresults.Text = memPlus

    End Sub

    Private Sub cmdclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclear.Click
        On Error Resume Next
        txtdisplay.Text = ""
        lblresults.Text = ""

    End Sub

    Private Sub cmdreturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdreturn.Click
        On Error Resume Next

        Dim reply As Byte
        'To make sure the user does not exit by mistake
        reply = MsgBox("Are you sure ", MsgBoxStyle.YesNo, "Exit Calculator")

        If reply = MsgBoxResult.Yes Then
            Me.Hide()
        End If

    End Sub

End Class