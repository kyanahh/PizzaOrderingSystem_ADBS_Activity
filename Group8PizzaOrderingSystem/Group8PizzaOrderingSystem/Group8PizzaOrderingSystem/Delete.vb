Imports MySql.Data.MySqlClient

Public Class Delete

    Public MysqlConn As MySqlConnection
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public result As Integer

    Private Sub Delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDataGridView()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Check if a cell is selected
        If dgvHistory.SelectedCells.Count > 0 Then
            ' Get the selected row index and the Order_ID value
            Dim rowIndex As Integer = dgvHistory.SelectedCells(0).RowIndex
            Dim orderId As Integer = Convert.ToInt32(dgvHistory.Rows(rowIndex).Cells("Order_ID").Value)

            ' Prompt the user for confirmation
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete order " & orderId & "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                ' Delete the record
                Try
                    MysqlConn = New MySqlConnection("server=localhost;userid=root;password=;database=dbcitcs")
                    MysqlConn.Open()

                    Dim query As String = "DELETE FROM tblorder WHERE orderid= '" & orderId & "'"
                    cmd = New MySqlCommand(query, MysqlConn)
                    cmd.ExecuteNonQuery()

                    MysqlConn.Close()

                    MessageBox.Show("Order " & orderId & " has been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'Refresh the DataGridView
                    RefreshDataGridView()
                Catch ex As Exception
                    MessageBox.Show("Error deleting record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Please select a record to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub RefreshDataGridView()
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

    Private Sub dgvHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHistory.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            dgvHistory.Rows(e.RowIndex).Selected = True
        End If
    End Sub
End Class
