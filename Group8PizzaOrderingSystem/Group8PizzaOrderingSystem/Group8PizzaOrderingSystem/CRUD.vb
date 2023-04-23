Imports MySql.Data.MySqlClient
Public Class CRUD

    Public MysqlConn As MySqlConnection
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public result As Integer

    Private _user As String
    Dim uid As Integer

    Public Sub connect()
        ' Retrieve the user's UID from the database
        MysqlConn = New MySqlConnection("server=localhost;userid=root;password=;database=dbcitcs")
        MysqlConn.Open()

        Using cmd As New MySqlCommand("SELECT uid FROM tblaccount WHERE username = '" & lblUser.Text & "'", MysqlConn)
            uid = CInt(cmd.ExecuteScalar())
        End Using
    End Sub

    Public Property User() As String
        Get
            Return _user
        End Get
        Set(ByVal value As String)
            _user = value
        End Set
    End Property

    Private Sub CRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUser.Text = _user

    End Sub

    Private Sub AddUserControl(ByVal uc As UserControl)
        ucPanel.Controls.Clear()
        ucPanel.Controls.Add(uc)
    End Sub

    Private Sub pbLogout_Click(sender As Object, e As EventArgs) Handles pbLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'If user clicks "Yes", navigate to login form
        If result = DialogResult.Yes Then
            Login.Show()
            User = ""
            Me.Close()
        End If
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Dim ucOrder As New Order()
        ucOrder.User = lblUser.Text
        AddUserControl(ucOrder)
    End Sub

    Private Sub btnCreateAcc_Click(sender As Object, e As EventArgs) Handles btnCreateAcc.Click
        Dim ucCreateAcc As New CreateAccount()
        AddUserControl(ucCreateAcc)
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Dim ucHistory As New History()
        AddUserControl(ucHistory)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim ucDelete As New Delete()
        AddUserControl(ucDelete)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim ucUpdate As New Update()
        AddUserControl(ucUpdate)
    End Sub
End Class