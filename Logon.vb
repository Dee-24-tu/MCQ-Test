Public Class frmlogon
    Dim counter As Byte
    Dim user_password As String
    Dim user_tester As String
    Dim user_Student As String
    Dim tester_pass As String
    Dim student_pass As String

    Private Sub Logon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.LightCyan 'Default background color

        cmbusers.Items.Add("Tester")
        cmbusers.Items.Add("Student")
        FileOpen(1, My.Application.Info.DirectoryPath & "\validpassword.dat", OpenMode.Input)

        Do Until EOF(1)
            Input(1, user_tester)
            Input(1, tester_pass)
            Input(1, user_Student)
            Input(1, student_pass)
        Loop

        FileClose(1)

    End Sub

    Private Sub btlightblue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrosebrown.CheckedChanged
        On Error Resume Next
        If btnrosebrown.Checked Then
            Me.BackColor = Color.RosyBrown

        ElseIf Not btnrosebrown.Checked Then
            Me.BackColor = Color.LightCyan 'Default background color

        End If

    End Sub

    Private Sub btnrosebrown_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlightblue.CheckedChanged
        On Error Resume Next
        If btnlightblue.Checked Then
            Me.BackColor = Color.LightBlue

        ElseIf Not btnlightblue.Checked Then
            Me.BackColor = Color.LightCyan 'Default background color

        End If

    End Sub

    Private Sub cmbusers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbusers.SelectedIndexChanged
        user = cmbusers.Text
        txtpassword.Focus()
    End Sub

    Private Sub cmdlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlogin.Click
        On Error Resume Next
        user_password = txtpassword.Text

        If user = user_tester And user_password = tester_pass Or user = user_Student And user_password = student_pass Then
            frmmenuoptions.Show()

        Else : MsgBox("Invalid Username and/or password! Please try gain!")
        End If
    End Sub

End Class
