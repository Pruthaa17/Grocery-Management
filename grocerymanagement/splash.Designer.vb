<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Splash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splash))
        Me.GroceryStoreImg1 = New System.Windows.Forms.PictureBox()
        Me.GroceryStoreLbl1 = New System.Windows.Forms.Label()
        Me.LblStatustext = New System.Windows.Forms.Label()
        Me.LblReportProgress = New System.Windows.Forms.Label()
        Me.Myprogress = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.GroceryStoreImg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroceryStoreImg1
        '
        Me.GroceryStoreImg1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.GroceryStoreImg1.Image = CType(resources.GetObject("GroceryStoreImg1.Image"), System.Drawing.Image)
        Me.GroceryStoreImg1.Location = New System.Drawing.Point(28, 12)
        Me.GroceryStoreImg1.Name = "GroceryStoreImg1"
        Me.GroceryStoreImg1.Size = New System.Drawing.Size(727, 396)
        Me.GroceryStoreImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GroceryStoreImg1.TabIndex = 0
        Me.GroceryStoreImg1.TabStop = False
        '
        'GroceryStoreLbl1
        '
        Me.GroceryStoreLbl1.AutoSize = True
        Me.GroceryStoreLbl1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroceryStoreLbl1.Location = New System.Drawing.Point(323, 23)
        Me.GroceryStoreLbl1.Name = "GroceryStoreLbl1"
        Me.GroceryStoreLbl1.Size = New System.Drawing.Size(225, 38)
        Me.GroceryStoreLbl1.TabIndex = 1
        Me.GroceryStoreLbl1.Text = "GROCERY STORE"
        '
        'LblStatustext
        '
        Me.LblStatustext.AutoSize = True
        Me.LblStatustext.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblStatustext.Location = New System.Drawing.Point(28, 436)
        Me.LblStatustext.Name = "LblStatustext"
        Me.LblStatustext.Size = New System.Drawing.Size(95, 23)
        Me.LblStatustext.TabIndex = 2
        Me.LblStatustext.Text = "LOADING..."
        Me.LblStatustext.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'LblReportProgress
        '
        Me.LblReportProgress.AutoSize = True
        Me.LblReportProgress.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblReportProgress.Location = New System.Drawing.Point(722, 436)
        Me.LblReportProgress.Name = "LblReportProgress"
        Me.LblReportProgress.Size = New System.Drawing.Size(33, 23)
        Me.LblReportProgress.TabIndex = 3
        Me.LblReportProgress.Text = "0%"
        Me.LblReportProgress.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Myprogress
        '
        Me.Myprogress.BackColor = System.Drawing.Color.White
        Me.Myprogress.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Myprogress.Location = New System.Drawing.Point(28, 411)
        Me.Myprogress.Name = "Myprogress"
        Me.Myprogress.Size = New System.Drawing.Size(727, 22)
        Me.Myprogress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.Myprogress.TabIndex = 4
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(785, 471)
        Me.Controls.Add(Me.Myprogress)
        Me.Controls.Add(Me.LblReportProgress)
        Me.Controls.Add(Me.LblStatustext)
        Me.Controls.Add(Me.GroceryStoreLbl1)
        Me.Controls.Add(Me.GroceryStoreImg1)
        Me.ForeColor = System.Drawing.Color.Crimson
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Splash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Splash"
        CType(Me.GroceryStoreImg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroceryStoreImg1 As PictureBox
    Friend WithEvents GroceryStoreLbl1 As Label
    Friend WithEvents LblStatustext As Label
    Friend WithEvents LblReportProgress As Label
    Friend WithEvents Myprogress As ProgressBar
    Friend WithEvents Timer1 As Timer
End Class
