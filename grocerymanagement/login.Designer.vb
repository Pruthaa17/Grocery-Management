﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UnameTb = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PasswordTb = New System.Windows.Forms.TextBox()
        Me.store1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.store1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Honeydew
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(339, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 41)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "GROCERY STORE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(733, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 106)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(324, 245)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(329, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 38)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Username"
        '
        'UnameTb
        '
        Me.UnameTb.ForeColor = System.Drawing.Color.Crimson
        Me.UnameTb.HideSelection = False
        Me.UnameTb.Location = New System.Drawing.Point(467, 132)
        Me.UnameTb.Name = "UnameTb"
        Me.UnameTb.PlaceholderText = "Username"
        Me.UnameTb.Size = New System.Drawing.Size(321, 27)
        Me.UnameTb.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGreen
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.Crimson
        Me.Button1.Location = New System.Drawing.Point(425, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 62)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightGreen
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(396, 385)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(240, 38)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Continue as Seller"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(339, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 38)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Password"
        '
        'PasswordTb
        '
        Me.PasswordTb.ForeColor = System.Drawing.Color.Crimson
        Me.PasswordTb.Location = New System.Drawing.Point(467, 211)
        Me.PasswordTb.Name = "PasswordTb"
        Me.PasswordTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTb.PlaceholderText = "Password"
        Me.PasswordTb.Size = New System.Drawing.Size(321, 27)
        Me.PasswordTb.TabIndex = 12
        '
        'store1
        '
        Me.store1.Image = CType(resources.GetObject("store1.Image"), System.Drawing.Image)
        Me.store1.Location = New System.Drawing.Point(276, 16)
        Me.store1.Name = "store1"
        Me.store1.Size = New System.Drawing.Size(68, 50)
        Me.store1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.store1.TabIndex = 20
        Me.store1.TabStop = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(800, 471)
        Me.Controls.Add(Me.store1)
        Me.Controls.Add(Me.PasswordTb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.UnameTb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.store1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents UnameTb As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PasswordTb As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents store1 As PictureBox
End Class
