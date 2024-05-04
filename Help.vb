Public Class frmhelp

    Private Sub frmhelp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.LightCyan 'Default background color

    End Sub

    Private Sub cmdbckmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbckmenu.Click
        On Error Resume Next
        Me.Hide()
        frmmenuoptions.Show()
    End Sub
End Class