﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnOtsi = New System.Windows.Forms.Button()
        Me.btnKuvaKaardil = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLahtepeatus = New System.Windows.Forms.Label()
        Me.lblLopppeatus = New System.Windows.Forms.Label()
        Me.txtAlgpeatus = New System.Windows.Forms.MaskedTextBox()
        Me.txtLoppPeatus = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UMap = New PrjKaardistaja.UserControl1()
        Me.ULiinidJaPeatusedList1 = New LiinidJaPeatusedList.ULiinidJaPeatusedList()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'btnOtsi
        '
        Me.btnOtsi.Location = New System.Drawing.Point(243, 121)
        Me.btnOtsi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnOtsi.Name = "btnOtsi"
        Me.btnOtsi.Size = New System.Drawing.Size(139, 48)
        Me.btnOtsi.TabIndex = 35
        Me.btnOtsi.Text = "OTSI"
        Me.btnOtsi.UseVisualStyleBackColor = true
        '
        'btnKuvaKaardil
        '
        Me.btnKuvaKaardil.Location = New System.Drawing.Point(479, 133)
        Me.btnKuvaKaardil.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnKuvaKaardil.Name = "btnKuvaKaardil"
        Me.btnKuvaKaardil.Size = New System.Drawing.Size(83, 57)
        Me.btnKuvaKaardil.TabIndex = 32
        Me.btnKuvaKaardil.Text = "KUVA KAART"
        Me.btnKuvaKaardil.UseVisualStyleBackColor = true
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(251, 257)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 14)
        Me.Label3.TabIndex = 19
        '
        'lblLahtepeatus
        '
        Me.lblLahtepeatus.Location = New System.Drawing.Point(21, 28)
        Me.lblLahtepeatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLahtepeatus.Name = "lblLahtepeatus"
        Me.lblLahtepeatus.Size = New System.Drawing.Size(209, 20)
        Me.lblLahtepeatus.TabIndex = 23
        Me.lblLahtepeatus.Text = "KIRJUTA LÄHTEPEATUS"
        '
        'lblLopppeatus
        '
        Me.lblLopppeatus.Location = New System.Drawing.Point(21, 78)
        Me.lblLopppeatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLopppeatus.Name = "lblLopppeatus"
        Me.lblLopppeatus.Size = New System.Drawing.Size(198, 20)
        Me.lblLopppeatus.TabIndex = 22
        Me.lblLopppeatus.Text = "KIRJUTA SIHTPEATUS"
        '
        'txtAlgpeatus
        '
        Me.txtAlgpeatus.Location = New System.Drawing.Point(234, 28)
        Me.txtAlgpeatus.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAlgpeatus.Name = "txtAlgpeatus"
        Me.txtAlgpeatus.Size = New System.Drawing.Size(125, 20)
        Me.txtAlgpeatus.TabIndex = 21
        '
        'txtLoppPeatus
        '
        Me.txtLoppPeatus.Location = New System.Drawing.Point(234, 78)
        Me.txtLoppPeatus.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLoppPeatus.Name = "txtLoppPeatus"
        Me.txtLoppPeatus.Size = New System.Drawing.Size(125, 20)
        Me.txtLoppPeatus.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(682, 133)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 88)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = " KUVA KÕIK PEATUSED"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'UMap
        '
        Me.UMap.Location = New System.Drawing.Point(813, 100)
        Me.UMap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UMap.Name = "UMap"
        Me.UMap.Size = New System.Drawing.Size(1343, 751)
        Me.UMap.TabIndex = 36
        '
        'ULiinidJaPeatusedList1
        '
        Me.ULiinidJaPeatusedList1.Location = New System.Drawing.Point(26, 346)
        Me.ULiinidJaPeatusedList1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ULiinidJaPeatusedList1.Name = "ULiinidJaPeatusedList1"
        Me.ULiinidJaPeatusedList1.Size = New System.Drawing.Size(771, 346)
        Me.ULiinidJaPeatusedList1.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(1189, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "KAART"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(80, 324)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "LIINIDE LOETELU"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(305, 324)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "VALITUD LIINI PEATUSED"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(533, 324)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "VALITUD PEATUSE VÄLJUMISED"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.Location = New System.Drawing.Point(624, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 15)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "--->"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2205, 1058)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ULiinidJaPeatusedList1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.UMap)
        Me.Controls.Add(Me.btnOtsi)
        Me.Controls.Add(Me.btnKuvaKaardil)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblLahtepeatus)
        Me.Controls.Add(Me.lblLopppeatus)
        Me.Controls.Add(Me.txtAlgpeatus)
        Me.Controls.Add(Me.txtLoppPeatus)
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents btnOtsi As Button
    Friend WithEvents btnKuvaKaardil As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblLahtepeatus As Label
    Friend WithEvents lblLopppeatus As Label
    Friend WithEvents txtAlgpeatus As MaskedTextBox
    Friend WithEvents txtLoppPeatus As TextBox
    Friend WithEvents UMap As PrjKaardistaja.UserControl1
    Friend WithEvents Button1 As Button
    Friend WithEvents ULiinidJaPeatusedList1 As LiinidJaPeatusedList.ULiinidJaPeatusedList
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
