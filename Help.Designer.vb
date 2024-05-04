<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhelp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmhelp))
        Me.Button1 = New System.Windows.Forms.Button
        Me.lblstudentinfo = New System.Windows.Forms.Label
        Me.lbltesterinfo = New System.Windows.Forms.Label
        Me.lblstudentinstruc = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmdbckmenu = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(309, 438)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(0, 0)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblstudentinfo
        '
        Me.lblstudentinfo.AutoSize = True
        Me.lblstudentinfo.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblstudentinfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblstudentinfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblstudentinfo.Location = New System.Drawing.Point(96, 67)
        Me.lblstudentinfo.Name = "lblstudentinfo"
        Me.lblstudentinfo.Size = New System.Drawing.Size(124, 22)
        Me.lblstudentinfo.TabIndex = 1
        Me.lblstudentinfo.Text = "Student Information"
        '
        'lbltesterinfo
        '
        Me.lbltesterinfo.AutoSize = True
        Me.lbltesterinfo.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lbltesterinfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltesterinfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbltesterinfo.Location = New System.Drawing.Point(96, 326)
        Me.lbltesterinfo.Name = "lbltesterinfo"
        Me.lbltesterinfo.Size = New System.Drawing.Size(116, 22)
        Me.lbltesterinfo.TabIndex = 3
        Me.lbltesterinfo.Text = "Tester Information"
        '
        'lblstudentinstruc
        '
        Me.lblstudentinstruc.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblstudentinstruc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblstudentinstruc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblstudentinstruc.Location = New System.Drawing.Point(355, 67)
        Me.lblstudentinstruc.Name = "lblstudentinstruc"
        Me.lblstudentinstruc.Size = New System.Drawing.Size(280, 218)
        Me.lblstudentinstruc.TabIndex = 2
        Me.lblstudentinstruc.Text = resources.GetString("lblstudentinstruc.Text")
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Location = New System.Drawing.Point(355, 325)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(280, 46)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tester can view the answers and test the system. "
        '
        'cmdbckmenu
        '
        Me.cmdbckmenu.BackColor = System.Drawing.Color.MediumTurquoise
        Me.cmdbckmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdbckmenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdbckmenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdbckmenu.Location = New System.Drawing.Point(309, 421)
        Me.cmdbckmenu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdbckmenu.Name = "cmdbckmenu"
        Me.cmdbckmenu.Size = New System.Drawing.Size(100, 35)
        Me.cmdbckmenu.TabIndex = 5
        Me.cmdbckmenu.Text = "&Return Home"
        Me.cmdbckmenu.UseVisualStyleBackColor = False
        '
        'frmhelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.cmdbckmenu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblstudentinstruc)
        Me.Controls.Add(Me.lbltesterinfo)
        Me.Controls.Add(Me.lblstudentinfo)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmhelp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Help"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblstudentinfo As System.Windows.Forms.Label
    Friend WithEvents lbltesterinfo As System.Windows.Forms.Label
    Friend WithEvents lblstudentinstruc As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdbckmenu As System.Windows.Forms.Button
End Class
