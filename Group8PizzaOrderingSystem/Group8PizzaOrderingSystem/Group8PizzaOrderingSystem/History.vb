Imports MySql.Data.MySqlClient

Public Class History

    Public MysqlConn As MySqlConnection
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public result As Integer

    Private Sub History_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection("server=localhost;userid=root;password=;database=dbcitcs")
        MysqlConn.Open()

        Dim query As String = "SELECT tblorder.orderid as Order_ID, tblorder.name as CustomerName," _
            & "tblorder.phone, tblflavor.flavor as Flavor, tblsize.size as Size," _
            & "tblorder.has_coke, tblorder.has_onions, tblorder.has_mushrooms," _
            & "tblorder.qty as Qty, tblorder.grandtotal as GrandTotal," _
            & "tblaccount.user as Cashier " _
            & "FROM (((tblorder INNER JOIN tblflavor on tblorder.flavorid = tblflavor.flavorid)" _
            & "INNER JOIN tblsize on tblorder.sizeid = tblsize.sizeid)" _
            & "INNER JOIN tblaccount on tblorder.uid = tblaccount.uid) " _
            & "ORDER BY tblorder.orderid;"

        cmd = New MySqlCommand(query, MysqlConn)

        da = New MySqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)

        dgvHistory.DataSource = dt

        MysqlConn.Close()
    End Sub
End Class
