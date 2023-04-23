Imports MySql.Data.MySqlClient

Public Class Order
    Dim flavor As Integer
    Dim fprice As Double
    Dim sprice As Double
    Dim oprice As Double
    Dim subtotal As Double
    Dim gtotal As Double
    Dim s As Integer
    Dim coke As Integer
    Dim onions As Integer
    Dim mushrooms As Integer

    Public MysqlConn As MySqlConnection
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public result As Integer

    Dim datetime As Date

    Private _user As String

    Public Property User() As String
        Get
            Return _user
        End Get
        Set(ByVal value As String)
            _user = value
        End Set
    End Property


    Private Sub Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbQty.SelectedIndex = 0
        txtSubTotal.Text = "0"
    End Sub

    Public Sub rbFlavor()
        If (rbVeggie.Checked) Then
            flavor = 1
            fprice = 120.0
        ElseIf (rbCheese.Checked) Then
            flavor = 2
            fprice = 130.0
        ElseIf (rbPepperoni.Checked) Then
            flavor = 3
            fprice = 140.0
        ElseIf (rbHawaiian.Checked) Then
            flavor = 4
            fprice = 150.0
        ElseIf (rbOverload.Checked) Then
            flavor = 5
            fprice = 160.0
        End If
    End Sub

    Public Sub rbSize()
        If (rbSmall.Checked) Then
            s = 1
            sprice = 0.0
        ElseIf (rbMedium.Checked) Then
            s = 2
            sprice = 20.0
        ElseIf (rbLarge.Checked) Then
            s = 3
            sprice = 40.0
        ElseIf (rbXL.Checked) Then
            s = 4
            sprice = 60.0
        End If
    End Sub

    Public Sub cbOthers()
        oprice = 0.0 ' Initialize oprice to 0

        If (cbCoke.Checked) Then
            coke = 1
            oprice += 60.0 ' Add 60 to oprice
        Else
            coke = 0
        End If

        If (cbOnions.Checked) Then
            onions = 1
            oprice += 10.0 ' Add 10 to oprice
        Else
            onions = 0
        End If

        If (cbMushrooms.Checked) Then
            mushrooms = 1
            oprice += 10.0 ' Add 10 to oprice
        Else
            mushrooms = 0
        End If
    End Sub


    Public Sub ClearAll()
        txtName.Clear()
        txtPhone.Clear()
        cmbQty.SelectedIndex = 0
        rbVeggie.Checked = False
        rbCheese.Checked = False
        rbPepperoni.Checked = False
        rbHawaiian.Checked = False
        rbOverload.Checked = False
        rbSmall.Checked = False
        rbMedium.Checked = False
        rbLarge.Checked = False
        rbXL.Checked = False
        cbCoke.Checked = False
        cbOnions.Checked = False
        cbMushrooms.Checked = False
        txtSubTotal.Text = "0"
        txtGrandTotal.Text = "0"
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearAll()
    End Sub

    Public Sub UpdateSubtotal()
        rbFlavor()
        rbSize()
        cbOthers()

        subtotal = fprice + sprice + oprice
        txtSubTotal.Text = subtotal.ToString()
    End Sub

    Private Sub rbFlavor_CheckedChanged(sender As Object, e As EventArgs) Handles rbVeggie.CheckedChanged, rbCheese.CheckedChanged, rbPepperoni.CheckedChanged, rbHawaiian.CheckedChanged, rbOverload.CheckedChanged
        UpdateSubtotal()
    End Sub

    Private Sub rbSize_CheckedChanged(sender As Object, e As EventArgs) Handles rbSmall.CheckedChanged, rbMedium.CheckedChanged, rbLarge.CheckedChanged, rbXL.CheckedChanged
        UpdateSubtotal()
    End Sub

    Private Sub cbOthers_CheckedChanged(sender As Object, e As EventArgs) Handles cbCoke.CheckedChanged, cbOnions.CheckedChanged, cbMushrooms.CheckedChanged
        UpdateSubtotal()
    End Sub

    Public Sub GrandTotal()
        gtotal = subtotal * Convert.ToDouble(cmbQty.SelectedIndex)
        txtGrandTotal.Text = gtotal.ToString()
    End Sub

    Private Sub cmbQty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbQty.SelectedIndexChanged
        GrandTotal()
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Try
            MysqlConn = New MySqlConnection("server=localhost;userid=root;password=;database=dbcitcs")
            MysqlConn.Open()

            'Retrieve the UID from tblaccount using lblUser.Text
            Dim uid As Integer
            Dim selectCmd As MySqlCommand = New MySqlCommand("SELECT uid FROM tblaccount WHERE user = '" & User & "'", MysqlConn)
            Dim reader As MySqlDataReader = selectCmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                uid = reader.GetInt32(0)
            End If

            reader.Close()

            With cmd
                .Connection = MysqlConn
                .CommandText = "INSERT INTO tblorder (name, phone, flavorid, sizeid, has_coke, has_onions, has_mushrooms, qty, grandtotal, uid) VALUES(" _
                            & "'" & txtName.Text & "', " _
                            & "'" & txtPhone.Text & "', " _
                            & "'" & flavor & "', " _
                            & "'" & s & "', " _
                            & "'" & coke & "', " _
                            & "'" & onions & "', " _
                            & "'" & mushrooms & "', " _
                            & "'" & cmbQty.SelectedIndex & "', " _
                            & "'" & gtotal & "', " _
                            & "" & uid & ")"

                'in this line it Executes a transact-SQL statements against the connection and returns the number of rows affected 
                result = cmd.ExecuteNonQuery()
            End With

            'Retrieve the order ID of the newly inserted record
            Dim orderId As Integer
            Dim selectOrderIdCmd As MySqlCommand = New MySqlCommand("SELECT LAST_INSERT_ID()", MysqlConn)
            orderId = selectOrderIdCmd.ExecuteScalar()

            getDateTime()

            ' Insert the timestamp and order ID into tblordertime
            With cmd
                .Connection = MysqlConn
                .CommandText = "INSERT INTO tblordertime (datetime, orderid) VALUES(" _
                            & "'" & datetime.ToString("yyyy-MM-dd HH:mm:ss") & "', " _
                            & "" & orderId & ")"

                'in this line it Executes a transact-SQL statements against the connection and returns the number of rows affected 
                result = cmd.ExecuteNonQuery()
            End With

            If result > 0 Then
                MessageBox.Show("Order created successfully!")
            Else
                MessageBox.Show("Failed to create order!")
            End If

            ClearAll()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Close()
        End Try
    End Sub

    Public Sub getDateTime()

        Dim sql As String
        Dim TempTable As New DataTable

        sql = "SELECT NOW()"

        'bind the connection and query
        With cmd
            .Connection = MysqlConn
            .CommandText = sql
        End With

        da.SelectCommand = cmd
        da.Fill(TempTable)

        datetime = TempTable.Rows(0).Item(0)
    End Sub

    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
