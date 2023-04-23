<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Order
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rbOverload = New System.Windows.Forms.RadioButton()
        Me.rbHawaiian = New System.Windows.Forms.RadioButton()
        Me.rbPepperoni = New System.Windows.Forms.RadioButton()
        Me.rbCheese = New System.Windows.Forms.RadioButton()
        Me.rbVeggie = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.rbXL = New System.Windows.Forms.RadioButton()
        Me.rbLarge = New System.Windows.Forms.RadioButton()
        Me.rbMedium = New System.Windows.Forms.RadioButton()
        Me.rbSmall = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cbMushrooms = New System.Windows.Forms.CheckBox()
        Me.cbOnions = New System.Windows.Forms.CheckBox()
        Me.cbCoke = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.cmbQty = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtGrandTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtPhone)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1121, 104)
        Me.Panel1.TabIndex = 0
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(279, 58)
        Me.txtPhone.MaxLength = 11
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(225, 27)
        Me.txtPhone.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(26, 58)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(225, 27)
        Me.txtName.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(275, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Phone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Information :"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.rbOverload)
        Me.Panel2.Controls.Add(Me.rbHawaiian)
        Me.Panel2.Controls.Add(Me.rbPepperoni)
        Me.Panel2.Controls.Add(Me.rbCheese)
        Me.Panel2.Controls.Add(Me.rbVeggie)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(4, 114)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(265, 215)
        Me.Panel2.TabIndex = 1
        '
        'rbOverload
        '
        Me.rbOverload.AutoSize = True
        Me.rbOverload.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbOverload.Location = New System.Drawing.Point(33, 167)
        Me.rbOverload.Name = "rbOverload"
        Me.rbOverload.Size = New System.Drawing.Size(183, 24)
        Me.rbOverload.TabIndex = 10
        Me.rbOverload.TabStop = True
        Me.rbOverload.Text = "Overload Pizza (P160)"
        Me.rbOverload.UseVisualStyleBackColor = True
        '
        'rbHawaiian
        '
        Me.rbHawaiian.AutoSize = True
        Me.rbHawaiian.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHawaiian.Location = New System.Drawing.Point(33, 137)
        Me.rbHawaiian.Name = "rbHawaiian"
        Me.rbHawaiian.Size = New System.Drawing.Size(181, 24)
        Me.rbHawaiian.TabIndex = 9
        Me.rbHawaiian.TabStop = True
        Me.rbHawaiian.Text = "Hawaiian Pizza (P150)"
        Me.rbHawaiian.UseVisualStyleBackColor = True
        '
        'rbPepperoni
        '
        Me.rbPepperoni.AutoSize = True
        Me.rbPepperoni.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPepperoni.Location = New System.Drawing.Point(33, 107)
        Me.rbPepperoni.Name = "rbPepperoni"
        Me.rbPepperoni.Size = New System.Drawing.Size(188, 24)
        Me.rbPepperoni.TabIndex = 8
        Me.rbPepperoni.TabStop = True
        Me.rbPepperoni.Text = "Pepperoni Pizza (P140)"
        Me.rbPepperoni.UseVisualStyleBackColor = True
        '
        'rbCheese
        '
        Me.rbCheese.AutoSize = True
        Me.rbCheese.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCheese.Location = New System.Drawing.Point(33, 77)
        Me.rbCheese.Name = "rbCheese"
        Me.rbCheese.Size = New System.Drawing.Size(169, 24)
        Me.rbCheese.TabIndex = 7
        Me.rbCheese.TabStop = True
        Me.rbCheese.Text = "Cheese Pizza (P130)"
        Me.rbCheese.UseVisualStyleBackColor = True
        '
        'rbVeggie
        '
        Me.rbVeggie.AutoSize = True
        Me.rbVeggie.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVeggie.Location = New System.Drawing.Point(33, 47)
        Me.rbVeggie.Name = "rbVeggie"
        Me.rbVeggie.Size = New System.Drawing.Size(166, 24)
        Me.rbVeggie.TabIndex = 6
        Me.rbVeggie.TabStop = True
        Me.rbVeggie.Text = "Veggie Pizza (P120)"
        Me.rbVeggie.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Flavor :"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.rbXL)
        Me.Panel3.Controls.Add(Me.rbLarge)
        Me.Panel3.Controls.Add(Me.rbMedium)
        Me.Panel3.Controls.Add(Me.rbSmall)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(275, 114)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(253, 215)
        Me.Panel3.TabIndex = 2
        '
        'rbXL
        '
        Me.rbXL.AutoSize = True
        Me.rbXL.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbXL.Location = New System.Drawing.Point(36, 137)
        Me.rbXL.Name = "rbXL"
        Me.rbXL.Size = New System.Drawing.Size(156, 24)
        Me.rbXL.TabIndex = 14
        Me.rbXL.TabStop = True
        Me.rbXL.Text = "Extra Large (+P60)"
        Me.rbXL.UseVisualStyleBackColor = True
        '
        'rbLarge
        '
        Me.rbLarge.AutoSize = True
        Me.rbLarge.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLarge.Location = New System.Drawing.Point(36, 107)
        Me.rbLarge.Name = "rbLarge"
        Me.rbLarge.Size = New System.Drawing.Size(117, 24)
        Me.rbLarge.TabIndex = 13
        Me.rbLarge.TabStop = True
        Me.rbLarge.Text = "Large (+P40)"
        Me.rbLarge.UseVisualStyleBackColor = True
        '
        'rbMedium
        '
        Me.rbMedium.AutoSize = True
        Me.rbMedium.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMedium.Location = New System.Drawing.Point(36, 77)
        Me.rbMedium.Name = "rbMedium"
        Me.rbMedium.Size = New System.Drawing.Size(135, 24)
        Me.rbMedium.TabIndex = 12
        Me.rbMedium.TabStop = True
        Me.rbMedium.Text = "Medium (+P20)"
        Me.rbMedium.UseVisualStyleBackColor = True
        '
        'rbSmall
        '
        Me.rbSmall.AutoSize = True
        Me.rbSmall.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSmall.Location = New System.Drawing.Point(36, 47)
        Me.rbSmall.Name = "rbSmall"
        Me.rbSmall.Size = New System.Drawing.Size(63, 24)
        Me.rbSmall.TabIndex = 11
        Me.rbSmall.TabStop = True
        Me.rbSmall.Text = "Small"
        Me.rbSmall.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Size :"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.cbMushrooms)
        Me.Panel4.Controls.Add(Me.cbOnions)
        Me.Panel4.Controls.Add(Me.cbCoke)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Location = New System.Drawing.Point(534, 114)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(232, 215)
        Me.Panel4.TabIndex = 3
        '
        'cbMushrooms
        '
        Me.cbMushrooms.AutoSize = True
        Me.cbMushrooms.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMushrooms.Location = New System.Drawing.Point(29, 107)
        Me.cbMushrooms.Name = "cbMushrooms"
        Me.cbMushrooms.Size = New System.Drawing.Size(159, 24)
        Me.cbMushrooms.TabIndex = 18
        Me.cbMushrooms.Text = "Mushrooms (+P10)"
        Me.cbMushrooms.UseVisualStyleBackColor = True
        '
        'cbOnions
        '
        Me.cbOnions.AutoSize = True
        Me.cbOnions.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOnions.Location = New System.Drawing.Point(29, 77)
        Me.cbOnions.Name = "cbOnions"
        Me.cbOnions.Size = New System.Drawing.Size(126, 24)
        Me.cbOnions.TabIndex = 17
        Me.cbOnions.Text = "Onions (+P10)"
        Me.cbOnions.UseVisualStyleBackColor = True
        '
        'cbCoke
        '
        Me.cbCoke.AutoSize = True
        Me.cbCoke.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCoke.Location = New System.Drawing.Point(29, 47)
        Me.cbCoke.Name = "cbCoke"
        Me.cbCoke.Size = New System.Drawing.Size(116, 24)
        Me.cbCoke.TabIndex = 16
        Me.cbCoke.Text = "Coke (+P60)"
        Me.cbCoke.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Others: "
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.txtSubTotal)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.cmbQty)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Location = New System.Drawing.Point(772, 114)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(353, 102)
        Me.Panel5.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Location = New System.Drawing.Point(9, 101)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(0, 0)
        Me.Panel6.TabIndex = 4
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(25, 50)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(143, 26)
        Me.txtSubTotal.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 19)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Total : "
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.Location = New System.Drawing.Point(192, 6)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1, 90)
        Me.Panel7.TabIndex = 18
        '
        'cmbQty
        '
        Me.cmbQty.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbQty.FormattingEnabled = True
        Me.cmbQty.Items.AddRange(New Object() {"Select", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbQty.Location = New System.Drawing.Point(217, 48)
        Me.cmbQty.Name = "cmbQty"
        Me.cmbQty.Size = New System.Drawing.Size(103, 28)
        Me.cmbQty.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(199, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 19)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Quantity :"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(226, 53)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 35)
        Me.btnCancel.TabIndex = 51
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOrder
        '
        Me.btnOrder.BackColor = System.Drawing.Color.Green
        Me.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOrder.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnOrder.Location = New System.Drawing.Point(226, 12)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(95, 35)
        Me.btnOrder.TabIndex = 50
        Me.btnOrder.Text = "ORDER"
        Me.btnOrder.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Black
        Me.Panel8.Location = New System.Drawing.Point(192, 9)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1, 90)
        Me.Panel8.TabIndex = 18
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrandTotal.Location = New System.Drawing.Point(26, 51)
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.ReadOnly = True
        Me.txtGrandTotal.Size = New System.Drawing.Size(143, 26)
        Me.txtGrandTotal.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 19)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Grand Total : "
        '
        'Panel9
        '
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Label9)
        Me.Panel9.Controls.Add(Me.btnCancel)
        Me.Panel9.Controls.Add(Me.txtGrandTotal)
        Me.Panel9.Controls.Add(Me.btnOrder)
        Me.Panel9.Controls.Add(Me.Panel8)
        Me.Panel9.Location = New System.Drawing.Point(772, 222)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(353, 107)
        Me.Panel9.TabIndex = 4
        '
        'Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Order"
        Me.Size = New System.Drawing.Size(1128, 507)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rbOverload As RadioButton
    Friend WithEvents rbHawaiian As RadioButton
    Friend WithEvents rbPepperoni As RadioButton
    Friend WithEvents rbCheese As RadioButton
    Friend WithEvents rbVeggie As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents rbXL As RadioButton
    Friend WithEvents rbLarge As RadioButton
    Friend WithEvents rbMedium As RadioButton
    Friend WithEvents rbSmall As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents cbMushrooms As CheckBox
    Friend WithEvents cbOnions As CheckBox
    Friend WithEvents cbCoke As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbQty As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtGrandTotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel7 As Panel
    Public WithEvents btnCancel As Button
    Public WithEvents btnOrder As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel9 As Panel
End Class
