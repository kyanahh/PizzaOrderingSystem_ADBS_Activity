<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAccount
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.panel12 = New System.Windows.Forms.Panel()
        Me.panel11 = New System.Windows.Forms.Panel()
        Me.label12 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(437, 308)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(0, 17)
        Me.lblUsername.TabIndex = 122
        '
        'cbType
        '
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbType.FormattingEnabled = True
        Me.cbType.Items.AddRange(New Object() {"Select Type", "Admin", "Manager", "Staff"})
        Me.cbType.Location = New System.Drawing.Point(496, 102)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(217, 29)
        Me.cbType.TabIndex = 121
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(436, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 23)
        Me.Label8.TabIndex = 120
        Me.Label8.Text = "Type"
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCreateAccount.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnCreateAccount.Location = New System.Drawing.Point(440, 344)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(273, 45)
        Me.btnCreateAccount.TabIndex = 119
        Me.btnCreateAccount.Text = "CREATE"
        Me.btnCreateAccount.UseVisualStyleBackColor = False
        '
        'panel12
        '
        Me.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel12.Location = New System.Drawing.Point(440, 295)
        Me.panel12.Name = "panel12"
        Me.panel12.Size = New System.Drawing.Size(273, 1)
        Me.panel12.TabIndex = 118
        '
        'panel11
        '
        Me.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel11.Location = New System.Drawing.Point(440, 211)
        Me.panel11.Name = "panel11"
        Me.panel11.Size = New System.Drawing.Size(273, 1)
        Me.panel11.TabIndex = 115
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label12.Location = New System.Drawing.Point(436, 237)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(96, 23)
        Me.label12.TabIndex = 117
        Me.label12.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(440, 272)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(273, 24)
        Me.txtPassword.TabIndex = 116
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label11.Location = New System.Drawing.Point(436, 153)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(103, 23)
        Me.label11.TabIndex = 114
        Me.label11.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(440, 188)
        Me.txtUsername.MaxLength = 25
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(273, 24)
        Me.txtUsername.TabIndex = 113
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(432, 31)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(292, 44)
        Me.label1.TabIndex = 112
        Me.label1.Text = "NEW ACCOUNT"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(402, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(352, 416)
        Me.Panel1.TabIndex = 123
        '
        'CreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.cbType)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Controls.Add(Me.panel12)
        Me.Controls.Add(Me.panel11)
        Me.Controls.Add(Me.label12)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CreateAccount"
        Me.Size = New System.Drawing.Size(1128, 507)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents cbType As ComboBox
    Private WithEvents Label8 As Label
    Private WithEvents btnCreateAccount As Button
    Private WithEvents panel12 As Panel
    Private WithEvents panel11 As Panel
    Private WithEvents label12 As Label
    Private WithEvents txtPassword As TextBox
    Private WithEvents label11 As Label
    Private WithEvents txtUsername As TextBox
    Private WithEvents label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
