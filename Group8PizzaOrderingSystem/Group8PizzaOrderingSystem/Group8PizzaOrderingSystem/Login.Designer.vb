<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.lblWrong = New System.Windows.Forms.Label()
        Me.lblForgot = New System.Windows.Forms.Label()
        Me.btnSign = New System.Windows.Forms.Button()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'lblWrong
        '
        Me.lblWrong.AutoSize = True
        Me.lblWrong.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWrong.ForeColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.lblWrong.Location = New System.Drawing.Point(41, 266)
        Me.lblWrong.Name = "lblWrong"
        Me.lblWrong.Size = New System.Drawing.Size(0, 17)
        Me.lblWrong.TabIndex = 36
        '
        'lblForgot
        '
        Me.lblForgot.AutoSize = True
        Me.lblForgot.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForgot.Location = New System.Drawing.Point(25, 335)
        Me.lblForgot.Name = "lblForgot"
        Me.lblForgot.Size = New System.Drawing.Size(127, 17)
        Me.lblForgot.TabIndex = 34
        Me.lblForgot.Text = "Forgot Password? "
        '
        'btnSign
        '
        Me.btnSign.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSign.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSign.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnSign.Location = New System.Drawing.Point(28, 287)
        Me.btnSign.Name = "btnSign"
        Me.btnSign.Size = New System.Drawing.Size(273, 45)
        Me.btnSign.TabIndex = 33
        Me.btnSign.Text = "SIGN IN"
        Me.btnSign.UseVisualStyleBackColor = False
        '
        'panel3
        '
        Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel3.Location = New System.Drawing.Point(28, 250)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(273, 1)
        Me.panel3.TabIndex = 32
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPass.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(28, 227)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(273, 24)
        Me.txtPass.TabIndex = 31
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label3.Location = New System.Drawing.Point(24, 192)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(96, 23)
        Me.label3.TabIndex = 30
        Me.label3.Text = "Password"
        '
        'panel2
        '
        Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel2.Location = New System.Drawing.Point(28, 171)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(273, 1)
        Me.panel2.TabIndex = 29
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label2.Location = New System.Drawing.Point(24, 113)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(103, 23)
        Me.label2.TabIndex = 28
        Me.label2.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(28, 148)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(273, 24)
        Me.txtUsername.TabIndex = 27
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(32, 29)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(154, 44)
        Me.label1.TabIndex = 26
        Me.label1.Text = "SIGN IN"
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.panel1.Location = New System.Drawing.Point(0, 22)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(21, 56)
        Me.panel1.TabIndex = 25
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(332, 393)
        Me.Controls.Add(Me.lblWrong)
        Me.Controls.Add(Me.lblForgot)
        Me.Controls.Add(Me.btnSign)
        Me.Controls.Add(Me.panel3)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pizza Pizzeria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblWrong As Label
    Private WithEvents lblForgot As Label
    Private WithEvents btnSign As Button
    Private WithEvents panel3 As Panel
    Private WithEvents txtPass As TextBox
    Private WithEvents label3 As Label
    Private WithEvents panel2 As Panel
    Private WithEvents label2 As Label
    Private WithEvents txtUsername As TextBox
    Private WithEvents label1 As Label
    Private WithEvents panel1 As Panel
End Class
