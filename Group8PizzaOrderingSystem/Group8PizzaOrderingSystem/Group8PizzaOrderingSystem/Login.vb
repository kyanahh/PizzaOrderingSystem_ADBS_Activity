Imports MySql.Data.MySqlClient

Public Class Login

    Public currentUser As String

    Public MysqlConn As MySqlConnection
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public result As Integer


    Dim uid As Integer
    Dim user As String
    Dim utype As Integer

    Dim datetime As Date
    Private Sub btnSign_Click(sender As Object, e As EventArgs) Handles btnSign.Click

        MysqlConn = New MySqlConnection("server=localhost;userid=root;password=;database=dbcitcs")


        VerifyUser()
    End Sub


    Private Sub lblForgot_Click(sender As Object, e As EventArgs) Handles lblForgot.Click
        MessageBox.Show("Your password can only be changed by the admin. Please contact the admin to reset your password.", "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Public Sub saveLogDateTime()
        Try
            MysqlConn = New MySqlConnection("server=localhost;userid=root;password=;database=dbcitcs")
            MysqlConn.Open()

            With cmd
                .Connection = MysqlConn
                .CommandText = "INSERT INTO tblLog (datein,userid) VALUES(" _
                            & "'" & datetime.ToString("yyyy-MM-dd HH:mm:ss") & "', " _
                            & "" & uid & ")"

                'in this line it Executes a transact-SQL statements against the connection and returns the number of rows affected 
                result = cmd.ExecuteNonQuery()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Close()
        End Try
    End Sub


    Public Sub VerifyUser()
        Dim sql As String
        Dim publictable As New DataTable

        Try
            'check if the textbox is equal to nothing then it will display the message below!.
            If txtUsername.Text = "" And txtPass.Text = "" Then
                MessageBox.Show("Please enter username and pass code", "Pizza Pizzeria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtUsername.Focus()

            Else

                'bind the MysqlConnnection and query

                sql = "select tblaccount.* from tblaccount  " _
                    & "where tblaccount.user ='" & txtUsername.Text & "' and tblaccount.password = '" & txtPass.Text & "'"
                With cmd
                    .Connection = MysqlConn
                    .CommandText = sql
                End With

                da.SelectCommand = cmd
                da.Fill(publictable)

                'check if theres a result by getting the count number of rows
                If publictable.Rows.Count > 0 Then
                    'it gets the data from specific column and assign to the variable
                    'Dim utype, user As String
                    utype = publictable.Rows(0).Item("type")
                    user = publictable.Rows(0).Item("user")
                    uid = publictable.Rows(0).Item("uid")

                    currentUser = txtUsername.Text

                    'check if the type of user is admin
                    If utype = "1" Then
                        'welcomes the user as Admiistrator
                        MessageBox.Show("Welcome " & user & ". Administrator Mode, all access.", "Pizza Pizzeria", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        txtUsername.Text = ""
                        txtPass.Text = ""

                        CRUD.btnOrder.Enabled = True
                        CRUD.btnHistory.Enabled = True
                        CRUD.btnUpdate.Enabled = True
                        CRUD.btnDelete.Enabled = True
                        CRUD.btnCreateAcc.Enabled = True


                    ElseIf utype = "2" Then
                        MessageBox.Show("Welcome " & user & ". Manager Privileges only", "Pizza Pizzeria", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        txtUsername.Text = ""
                        txtPass.Text = ""

                        CRUD.btnOrder.Enabled = True
                        CRUD.btnHistory.Enabled = True
                        CRUD.btnUpdate.Enabled = True
                        CRUD.btnDelete.Enabled = True


                    ElseIf utype = "3" Then
                        MessageBox.Show("Welcome " & user & ". Staff Privileges only", "Pizza Pizzeria", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        txtUsername.Text = ""
                        txtPass.Text = ""

                        CRUD.btnOrder.Enabled = True
                        CRUD.btnHistory.Enabled = True
                        CRUD.btnUpdate.Enabled = True

                    Else
                        MessageBox.Show("You login as Guest!")
                        CRUD.btnHistory.Enabled = True
                    End If

                    getDateTime()
                    saveLogDateTime()

                    txtUsername.Text = ""
                    txtPass.Text = ""
                    txtUsername.Focus()

                    CRUD.User = currentUser
                    CRUD.Show()
                    Me.Hide()

                Else
                    MessageBox.Show("Account not valid. Please contact your administrator for assistance", "Pizza Pizzeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtUsername.Text = ""
                    txtPass.Text = ""
                    txtUsername.Focus()
                End If

                da.Dispose()
                cmd.Dispose()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub



End Class
