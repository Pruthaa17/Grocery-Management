<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Items
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Items))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Store2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CatCb = New System.Windows.Forms.ComboBox()
        Me.PriceTb = New System.Windows.Forms.TextBox()
        Me.QtyTb = New System.Windows.Forms.TextBox()
        Me.ItnameTb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ItemDGV = New System.Windows.Forms.DataGridView()
        Me.StockLbl = New System.Windows.Forms.Label()
        Me.SearchCb = New System.Windows.Forms.ComboBox()
        Me.FilterByCategoryLbl = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.LogoutLbl = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.Store2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.ItemDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel1.Controls.Add(Me.Store2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1425, 106)
        Me.Panel1.TabIndex = 2
        '
        'Store2
        '
        Me.Store2.Image = CType(resources.GetObject("Store2.Image"), System.Drawing.Image)
        Me.Store2.Location = New System.Drawing.Point(530, 26)
        Me.Store2.Name = "Store2"
        Me.Store2.Size = New System.Drawing.Size(80, 67)
        Me.Store2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Store2.TabIndex = 21
        Me.Store2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1360, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(616, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "GROCERY STORE"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 803)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1425, 17)
        Me.Panel2.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.CatCb)
        Me.Panel3.Controls.Add(Me.PriceTb)
        Me.Panel3.Controls.Add(Me.QtyTb)
        Me.Panel3.Controls.Add(Me.ItnameTb)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(12, 163)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1401, 232)
        Me.Panel3.TabIndex = 4
        '
        'CatCb
        '
        Me.CatCb.FormattingEnabled = True
        Me.CatCb.Items.AddRange(New Object() {"FRUIT", "VEGETABLE", "MEAT", "SEA-FOOD", "BAKERY", "FOOD-OIL", "BEANS"})
        Me.CatCb.Location = New System.Drawing.Point(1087, 76)
        Me.CatCb.Name = "CatCb"
        Me.CatCb.Size = New System.Drawing.Size(258, 28)
        Me.CatCb.TabIndex = 19
        '
        'PriceTb
        '
        Me.PriceTb.ForeColor = System.Drawing.Color.Crimson
        Me.PriceTb.Location = New System.Drawing.Point(745, 77)
        Me.PriceTb.Name = "PriceTb"
        Me.PriceTb.Size = New System.Drawing.Size(258, 27)
        Me.PriceTb.TabIndex = 13
        '
        'QtyTb
        '
        Me.QtyTb.ForeColor = System.Drawing.Color.Crimson
        Me.QtyTb.Location = New System.Drawing.Point(381, 77)
        Me.QtyTb.Name = "QtyTb"
        Me.QtyTb.Size = New System.Drawing.Size(258, 27)
        Me.QtyTb.TabIndex = 12
        '
        'ItnameTb
        '
        Me.ItnameTb.ForeColor = System.Drawing.Color.Crimson
        Me.ItnameTb.Location = New System.Drawing.Point(51, 77)
        Me.ItnameTb.Name = "ItnameTb"
        Me.ItnameTb.Size = New System.Drawing.Size(258, 27)
        Me.ItnameTb.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Crimson
        Me.Label6.Location = New System.Drawing.Point(1087, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 38)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Categories"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Crimson
        Me.Label5.Location = New System.Drawing.Point(745, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 38)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(381, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 38)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(51, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 38)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Item Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(586, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 45)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Manage Items"
        '
        'ItemDGV
        '
        Me.ItemDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemDGV.Location = New System.Drawing.Point(300, 480)
        Me.ItemDGV.Name = "ItemDGV"
        Me.ItemDGV.RowHeadersWidth = 51
        Me.ItemDGV.RowTemplate.Height = 29
        Me.ItemDGV.Size = New System.Drawing.Size(856, 264)
        Me.ItemDGV.TabIndex = 6
        '
        'StockLbl
        '
        Me.StockLbl.AutoSize = True
        Me.StockLbl.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StockLbl.ForeColor = System.Drawing.Color.Crimson
        Me.StockLbl.Location = New System.Drawing.Point(669, 398)
        Me.StockLbl.Name = "StockLbl"
        Me.StockLbl.Size = New System.Drawing.Size(98, 45)
        Me.StockLbl.TabIndex = 7
        Me.StockLbl.Text = "Stock"
        '
        'SearchCb
        '
        Me.SearchCb.FormattingEnabled = True
        Me.SearchCb.Items.AddRange(New Object() {"FRUIT", "VEGETABLE", "MEAT", "SEA-FOOD", "BAKERY", "FOOD-OIL", "BEANS"})
        Me.SearchCb.Location = New System.Drawing.Point(627, 446)
        Me.SearchCb.Name = "SearchCb"
        Me.SearchCb.Size = New System.Drawing.Size(258, 28)
        Me.SearchCb.TabIndex = 20
        '
        'FilterByCategoryLbl
        '
        Me.FilterByCategoryLbl.AutoSize = True
        Me.FilterByCategoryLbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FilterByCategoryLbl.ForeColor = System.Drawing.Color.Crimson
        Me.FilterByCategoryLbl.Location = New System.Drawing.Point(454, 446)
        Me.FilterByCategoryLbl.Name = "FilterByCategoryLbl"
        Me.FilterByCategoryLbl.Size = New System.Drawing.Size(167, 28)
        Me.FilterByCategoryLbl.TabIndex = 21
        Me.FilterByCategoryLbl.Text = "Filter By Category"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(890, 446)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(819, 126)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(35, 31)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'LogoutLbl
        '
        Me.LogoutLbl.BackColor = System.Drawing.Color.LightGreen
        Me.LogoutLbl.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LogoutLbl.ForeColor = System.Drawing.Color.Crimson
        Me.LogoutLbl.Location = New System.Drawing.Point(669, 750)
        Me.LogoutLbl.Name = "LogoutLbl"
        Me.LogoutLbl.Size = New System.Drawing.Size(112, 48)
        Me.LogoutLbl.TabIndex = 24
        Me.LogoutLbl.Text = "Logout"
        Me.LogoutLbl.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGreen
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.Crimson
        Me.Button1.Location = New System.Drawing.Point(159, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 62)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightGreen
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.Crimson
        Me.Button2.Location = New System.Drawing.Point(457, 136)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(182, 62)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightGreen
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.Crimson
        Me.Button3.Location = New System.Drawing.Point(745, 136)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(182, 62)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightGreen
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button4.ForeColor = System.Drawing.Color.Crimson
        Me.Button4.Location = New System.Drawing.Point(1053, 136)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(182, 62)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(1425, 820)
        Me.Controls.Add(Me.LogoutLbl)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.FilterByCategoryLbl)
        Me.Controls.Add(Me.SearchCb)
        Me.Controls.Add(Me.StockLbl)
        Me.Controls.Add(Me.ItemDGV)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Items"
        Me.Text = "ITem"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Store2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ItemDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Store2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PriceTb As TextBox
    Friend WithEvents QtyTb As TextBox
    Friend WithEvents ItnameTb As TextBox
    Friend WithEvents CatCb As ComboBox
    Friend WithEvents ItemDGV As DataGridView
    Friend WithEvents StockLbl As Label
    Friend WithEvents SearchCb As ComboBox
    Friend WithEvents FilterByCategoryLbl As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LogoutLbl As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
