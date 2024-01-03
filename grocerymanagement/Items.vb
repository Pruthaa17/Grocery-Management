Imports System.Data.SqlClient
Public Class Items
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rajma\Documents\GroceryDbVb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayItem()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim Obj = New login
        Obj.Show()
        Me.Hide()
    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles FilterByCategoryLbl.Click

    End Sub
    Private Sub Store2_Click(sender As Object, e As EventArgs) Handles Store2.Click

    End Sub

    Private Sub StockLbl_Click(sender As Object, e As EventArgs) Handles StockLbl.Click

    End Sub
    Private Sub DisplayItem()
        Con.Open()
        Dim query = "select * from ItemTbl "
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub FilterByCat()
        Con.Open()
        Dim query = "select * from ItemTbl where ItCat = '" & SearchCb.SelectedItem.ToString() & "'"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Dim key = 0
    Private Sub ItemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        ItnameTb.Text = row.Cells(1).Value.ToString
        QtyTb.Text = row.Cells(2).Value.ToString
        PriceTb.Text = row.Cells(3).Value.ToString
        CatCb.SelectedItem = row.Cells(4).Value.ToString
        If ItnameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        DisplayItem()
    End Sub

    Private Sub ComboBox2_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles SearchCb.SelectionChangeCommitted
        FilterByCat()

    End Sub

    Private Sub LogoutLbl_Click(sender As Object, e As EventArgs) Handles LogoutLbl.Click
        Dim Obj = New login
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ItnameTb.Text = "" Or QtyTb.Text = "" Or CatCb.SelectedIndex = -1 Or PriceTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                Con.Open()
                Dim query = "insert into ItemTbl values('" & ItnameTb.Text & "'," & QtyTb.Text & "," & PriceTb.Text & ",'" & CatCb.SelectedItem.ToString() & "') "
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Item Saved Successfully")
                Con.Close()
                DisplayItem()
                Clear()
            Catch ex As Exception

            End Try
        End If

    End Sub
    Private Sub Clear()
        ItnameTb.Text = ""
        QtyTb.Text = ""
        PriceTb.Text = ""
        CatCb.SelectedIndex = 0
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Clear()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If ItnameTb.Text = "" Or QtyTb.Text = "" Or CatCb.SelectedIndex = -1 Or PriceTb.Text = "" Then
            MsgBox("Select Item To Delete")
        Else
            Try
                Con.Open()
                Dim query = "Delete from ItemTbl where ItId= " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Item Deleted Successfully")
                Con.Close()
                DisplayItem()
                Clear()
            Catch ex As Exception

            End Try
        End If


    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ItnameTb.Text = "" Or QtyTb.Text = "" Or CatCb.SelectedIndex = -1 Or PriceTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                Con.Open()
                Dim query = "Update ItemTbl set ItName='" & ItnameTb.Text & "',ItQty=" & QtyTb.Text & ",ItPrice=" & PriceTb.Text & ",ItCat='" & CatCb.SelectedItem.ToString() & "' where ItId " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Item Updated Successfully")
                Con.Close()
                DisplayItem()
                Clear()
            Catch ex As Exception

            End Try
        End If

    End Sub
End Class