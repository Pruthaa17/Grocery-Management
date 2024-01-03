Imports System.Data.SqlClient

Public Class Billing
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rajma\Documents\GroceryDbVb.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub AddBill()
        Try
            Con.Open()
            Dim query = "insert into BillTbl values ('" & CustomerNameTb.Text & "'," & PriceTb.Text & ",'" & DateTime.Today.Date & "') "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Bill Saved Successfully")
            Con.Close()
            TotalLbl.Text = "Total"
            DisplayItem()
            'Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles ItNameTb.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles QtyTb.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
    Private Sub Reset1()
        ItNameTb.Text = ""
        PriceTb.Text = ""
        QtyTb.Text = ""
        'TotalLbl.Text = "Total"
        key = 0
        Stock = 0

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Reset()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BillDGV.CellContentClick

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles PrintLb.Click
        If CustomerNameTb.Text = "" Then
            MsgBox("Enter Customer Name")
        Else
            AddBill()

        End If
    End Sub

    Private Sub Billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayItem()
    End Sub

    Private Sub Store2_Click(sender As Object, e As EventArgs) Handles Store2.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles PriceTb.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles CustomerNameTb.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
    Private Sub UpdateItem()
        Dim newQty = Stock - Convert.ToInt32(QtyTb.Text)
        Try
            Con.Open()
            Dim query = "Update ItemTbl set ItQty =" & newQty & " where ItId=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Item Updated Successfully")
            Con.Close()
            DisplayItem()
        Catch ex As Exception

        End Try

    End Sub

    Dim i = 0, GrdTotal = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If PriceTb.Text = "" Or QtyTb.Text = "" Then
            MsgBox("Enter the Quantity")
        ElseIf ItNameTb.Text = "" Then
            MsgBox("Select the Item")
        Else
            Dim rnum As Integer = BillDGV.Rows.Add()
            i = i + 1
            Dim total = Convert.ToInt32(QtyTb.Text) * Convert.ToInt32(PriceTb.Text)
            BillDGV.Rows.Item(rnum).Cells("Column1").Value = i
            BillDGV.Rows.Item(rnum).Cells("Column2").Value = ItNameTb.Text
            BillDGV.Rows.Item(rnum).Cells("Column3").Value = PriceTb.Text
            BillDGV.Rows.Item(rnum).Cells("Column4").Value = total
            GrdTotal = GrdTotal + total
            Dim tot As String
            tot = "Rs" + Convert.ToString(GrdTotal)
            TotalLbl.Text = tot
            UpdateItem()
            DisplayItem()

        End If
    End Sub
    Private Sub DisplayItem()
        Con.close()
        Dim query = "select * from Itemtbl"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub
    Dim key = 0, Stock = 0

    Private Sub ItemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        ItNameTb.Text = row.Cells(1).Value.ToString
        PriceTb.Text = row.Cells(3).Value.ToString
        If ItNameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
            Stock = Convert.ToInt32(row.Cells(2).Value.ToString)

        End If

    End Sub

    Private Sub TotalLbl_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TotalLbl_Click_1(sender As Object, e As EventArgs) Handles TotalLbl.Click

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Obj = New login
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        TotalLbl.Text = "Total"
        BillDGV.Rows.Clear()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub Reset()
        ItNameTb.Text = ""
        PriceTb.Text = ""
        QtyTb.Text = ""
        'TotalLbl.Text = "Total"
        key = 0
        Stock = 0
    End Sub
    Private Sub BillDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles BillDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        ItNameTb.Text = row.Cells(1).Value.ToString
        PriceTb.Text = row.Cells(3).Value.ToString
        If ItNameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
            Stock = Convert.ToInt32(row.Cells(2).Value.ToString)

        End If

    End Sub
End Class