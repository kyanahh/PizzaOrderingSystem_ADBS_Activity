<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRUD
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
    <System.Diagnostics.DebuggerStepThrough()>
    Public Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CRUD))
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.pbLogout = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ucPanel = New System.Windows.Forms.Panel()
        Me.btnCreateAcc = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.pbLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOrder
        '
        Me.btnOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnOrder.Enabled = False
        Me.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOrder.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnOrder.Location = New System.Drawing.Point(35, 108)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(219, 45)
        Me.btnOrder.TabIndex = 49
        Me.btnOrder.Text = "ORDER PIZZA"
        Me.btnOrder.UseVisualStyleBackColor = False
        '
        'btnHistory
        '
        Me.btnHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnHistory.Enabled = False
        Me.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHistory.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnHistory.Location = New System.Drawing.Point(260, 108)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(219, 45)
        Me.btnHistory.TabIndex = 50
        Me.btnHistory.Text = "ORDER HISTORY"
        Me.btnHistory.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnUpdate.Location = New System.Drawing.Point(485, 108)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(219, 45)
        Me.btnUpdate.TabIndex = 51
        Me.btnUpdate.Text = "UPDATE ORDER"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Welcome,"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(101, 73)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(0, 17)
        Me.lblUser.TabIndex = 54
        '
        'pbLogout
        '
        Me.pbLogout.Image = CType(resources.GetObject("pbLogout.Image"), System.Drawing.Image)
        Me.pbLogout.Location = New System.Drawing.Point(1120, 27)
        Me.pbLogout.Name = "pbLogout"
        Me.pbLogout.Size = New System.Drawing.Size(34, 37)
        Me.pbLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogout.TabIndex = 57
        Me.pbLogout.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Distant Galaxy", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(27, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(410, 46)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "PIZZA PIZZERIA"
        '
        'ucPanel
        '
        Me.ucPanel.Location = New System.Drawing.Point(26, 180)
        Me.ucPanel.Name = "ucPanel"
        Me.ucPanel.Size = New System.Drawing.Size(1128, 522)
        Me.ucPanel.TabIndex = 59
        '
        'btnCreateAcc
        '
        Me.btnCreateAcc.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnCreateAcc.Enabled = False
        Me.btnCreateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCreateAcc.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateAcc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnCreateAcc.Location = New System.Drawing.Point(935, 108)
        Me.btnCreateAcc.Name = "btnCreateAcc"
        Me.btnCreateAcc.Size = New System.Drawing.Size(219, 45)
        Me.btnCreateAcc.TabIndex = 60
        Me.btnCreateAcc.Text = "CREATE ACCOUNT"
        Me.btnCreateAcc.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnDelete.Enabled = False
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(710, 108)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(219, 45)
        Me.btnDelete.TabIndex = 52
        Me.btnDelete.Text = "DELETE ORDER"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'CRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1175, 749)
        Me.Controls.Add(Me.btnCreateAcc)
        Me.Controls.Add(Me.ucPanel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pbLogout)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.btnOrder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "CRUD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pizza Pizzeria"
        CType(Me.pbLogout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents btnOrder As Button
    Public WithEvents btnHistory As Button
    Public WithEvents btnUpdate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents pbLogout As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ucPanel As Panel
    Public WithEvents btnCreateAcc As Button
    Public WithEvents btnDelete As Button
End Class
