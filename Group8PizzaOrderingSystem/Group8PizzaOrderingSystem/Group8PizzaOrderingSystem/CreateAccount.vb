Imports MySql.Data.MySqlClient
Public Class CreateAccount

    Public MysqlConn As MySqlConnection
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public result As Integer

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        Try
            MysqlConn = New MySqlConnection("server=localhost;userid=root;password=;database=dbcitcs")
            MysqlConn.Open()

            ' Check if username exists in the database
            Dim query As String = "SELECT COUNT(*) FROM tblaccount WHERE user = '" & txtUsername.Text & "'"
            Dim cmdCheck As New MySqlCommand(query, MysqlConn)
            Dim count As Integer = cmdCheck.ExecuteScalar()

            If count > 0 Then
                lblUsername.Text = "Username already exists"
            Else
                ' Insert data into the database
                Dim insertQuery As String = "INSERT INTO tblaccount (user, password, type) VALUES('" & txtUsername.Text & "', '" & txtPassword.Text & "', " & cbType.SelectedIndex & ")"
                Dim cmdInsert As New MySqlCommand(insertQuery, MysqlConn)
                result = cmdInsert.ExecuteNonQuery()

                ' Check if data was added successfully
                If result > 0 Then
                    lblUsername.Text = "Account created successfully!"
                Else
                    lblUsername.Text = "Failed to create account!"
                End If
            End If

            ClearAll()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Close()
        End Try
    End Sub

    Public Sub ClearAll()
        cbType.SelectedIndex = 0
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub CreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbType.SelectedIndex = 0
    End Sub

End Class
