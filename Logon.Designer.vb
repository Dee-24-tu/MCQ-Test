<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogon
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
        Me.btnrosebrown = New System.Windows.Forms.CheckBox
        Me.btnlightblue = New System.Windows.Forms.RadioButton
        Me.cmbusers = New System.Windows.Forms.ComboBox
        Me.txtpassword = New System.Windows.Forms.TextBox
        Me.cmdlogin = New System.Windows.Forms.Button
        Me.lblusers = New System.Windows.Forms.Label
        Me.lblpassword = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnrosebrown
        '
        Me.btnrosebrown.AutoSize = True
        Me.btnrosebrown.BackColor = System.Drawing.Color.RosyBrown
        Me.btnrosebrown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnrosebrown.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnrosebrown.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnrosebrown.Location = New System.Drawing.Point(42, 48)
        Me.btnrosebrown.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnrosebrown.Name = "btnrosebrown"
        Me.btnrosebrown.Size = New System.Drawing.Size(103, 24)
        Me.btnrosebrown.TabIndex = 1
        Me.btnrosebrown.Text = "& Rose Brown"
        Me.btnrosebrown.UseVisualStyleBackColor = False
        '
        'btnlightblue
        '
        Me.btnlightblue.AutoSize = True
        Me.btnlightblue.BackColor = System.Drawing.Color.LightBlue
        Me.btnlightblue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnlightblue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnlightblue.Location = New System.Drawing.Point(41, 97)
        Me.btnlightblue.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnlightblue.Name = "btnlightblue"
        Me.btnlightblue.Size = New System.Drawing.Size(85, 24)
        Me.btnlightblue.TabIndex = 2
        Me.btnlightblue.Text = "&Light Blue"
        Me.btnlightblue.UseVisualStyleBackColor = False
        '
        'cmbusers
        '
        Me.cmbusers.BackColor = System.Drawing.Color.MintCream
        Me.cmbusers.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbusers.FormattingEnabled = True
        Me.cmbusers.Location = New System.Drawing.Point(476, 202)
        Me.cmbusers.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbusers.Name = "cmbusers"
        Me.cmbusers.Size = New System.Drawing.Size(160, 28)
        Me.cmbusers.TabIndex = 4
        Me.cmbusers.Text = "Select user"
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.MintCream
        Me.txtpassword.Location = New System.Drawing.Point(476, 285)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(160, 26)
        Me.txtpassword.TabIndex = 6
        Me.txtpassword.Text = "password"
        '
        'cmdlogin
        '
        Me.cmdlogin.BackColor = System.Drawing.Color.MediumTurquoise
        Me.cmdlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdlogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdlogin.Location = New System.Drawing.Point(323, 386)
        Me.cmdlogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdlogin.Name = "cmdlogin"
        Me.cmdlogin.Size = New System.Drawing.Size(100, 35)
        Me.cmdlogin.TabIndex = 7
        Me.cmdlogin.Text = "&Log on"
        Me.cmdlogin.UseVisualStyleBackColor = False
        '
        'lblusers
        '
        Me.lblusers.AutoSize = True
        Me.lblusers.Location = New System.Drawing.Point(203, 202)
        Me.lblusers.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblusers.Name = "lblusers"
        Me.lblusers.Size = New System.Drawing.Size(107, 20)
        Me.lblusers.TabIndex = 3
        Me.lblusers.Text = "Enter user name"
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Location = New System.Drawing.Point(203, 291)
        Me.lblpassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(109, 20)
        Me.lblpassword.TabIndex = 5
        Me.lblpassword.Text = "Key in password"
        '
        'frmlogon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.lblusers)
        Me.Controls.Add(Me.cmdlogin)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.cmbusers)
        Me.Controls.Add(Me.btnlightblue)
        Me.Controls.Add(Me.btnrosebrown)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmlogon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log On"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnrosebrown As System.Windows.Forms.CheckBox
    Friend WithEvents cmbusers As System.Windows.Forms.ComboBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents cmdlogin As System.Windows.Forms.Button
    Friend WithEvents lblusers As System.Windows.Forms.Label
    Friend WithEvents lblpassword As System.Windows.Forms.Label
    Friend WithEvents btnlightblue As System.Windows.Forms.RadioButton

End Class
