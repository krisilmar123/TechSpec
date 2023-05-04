<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.components = New System.ComponentModel.Container()
        Me.btnOtsi = New System.Windows.Forms.Button()
        Me.btnKuvaKaardil = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLahtepeatus = New System.Windows.Forms.Label()
        Me.lblLopppeatus = New System.Windows.Forms.Label()
        Me.txtLopppeatus = New System.Windows.Forms.MaskedTextBox()
        Me.txtAlgpeatus = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UMap = New PrjKaardistaja.UserControl1()
        Me.ULiinidJaPeatusedList1 = New LiinidJaPeatusedList.ULiinidJaPeatusedList()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOtsi
        '
        Me.btnOtsi.Location = New System.Drawing.Point(162, 79)
        Me.btnOtsi.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnOtsi.Name = "btnOtsi"
        Me.btnOtsi.Size = New System.Drawing.Size(93, 31)
        Me.btnOtsi.TabIndex = 35
        Me.btnOtsi.Text = "OTSI"
        Me.btnOtsi.UseVisualStyleBackColor = True
        '
        'btnKuvaKaardil
        '
        Me.btnKuvaKaardil.Location = New System.Drawing.Point(319, 86)
        Me.btnKuvaKaardil.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnKuvaKaardil.Name = "btnKuvaKaardil"
        Me.btnKuvaKaardil.Size = New System.Drawing.Size(83, 57)
        Me.btnKuvaKaardil.TabIndex = 32
        Me.btnKuvaKaardil.Text = "KUVA KAART"
        Me.btnKuvaKaardil.UseVisualStyleBackColor = True
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
        Me.lblLahtepeatus.Location = New System.Drawing.Point(14, 18)
        Me.lblLahtepeatus.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblLahtepeatus.Name = "lblLahtepeatus"
        Me.lblLahtepeatus.Size = New System.Drawing.Size(139, 13)
        Me.lblLahtepeatus.TabIndex = 23
        Me.lblLahtepeatus.Text = "KIRJUTA LÄHTEPEATUS"
        '
        'lblLopppeatus
        '
        Me.lblLopppeatus.Location = New System.Drawing.Point(14, 51)
        Me.lblLopppeatus.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblLopppeatus.Name = "lblLopppeatus"
        Me.lblLopppeatus.Size = New System.Drawing.Size(132, 13)
        Me.lblLopppeatus.TabIndex = 22
        Me.lblLopppeatus.Text = "KIRJUTA SIHTPEATUS"
        '
        'txtLopppeatus
        '
        Me.txtLopppeatus.Location = New System.Drawing.Point(156, 18)
        Me.txtLopppeatus.Margin = New System.Windows.Forms.Padding(1)
        Me.txtLopppeatus.Name = "txtLopppeatus"
        Me.txtLopppeatus.Size = New System.Drawing.Size(125, 20)
        Me.txtLopppeatus.TabIndex = 21
        '
        'txtAlgpeatus
        '
        Me.txtAlgpeatus.Location = New System.Drawing.Point(156, 51)
        Me.txtAlgpeatus.Margin = New System.Windows.Forms.Padding(1)
        Me.txtAlgpeatus.Name = "txtAlgpeatus"
        Me.txtAlgpeatus.Size = New System.Drawing.Size(125, 20)
        Me.txtAlgpeatus.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(449, 86)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 57)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = " KUVA KÕIK PEATUSED"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UMap
        '
        Me.UMap.Location = New System.Drawing.Point(553, 64)
        Me.UMap.Name = "UMap"
        Me.UMap.Size = New System.Drawing.Size(507, 385)
        Me.UMap.TabIndex = 36
        '
        'ULiinidJaPeatusedList1
        '
        Me.ULiinidJaPeatusedList1.liiniList = Nothing
        Me.ULiinidJaPeatusedList1.liiniValik = Nothing
        Me.ULiinidJaPeatusedList1.Location = New System.Drawing.Point(17, 225)
        Me.ULiinidJaPeatusedList1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.ULiinidJaPeatusedList1.Name = "ULiinidJaPeatusedList1"
        Me.ULiinidJaPeatusedList1.Size = New System.Drawing.Size(514, 225)
        Me.ULiinidJaPeatusedList1.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(793, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "KAART"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 211)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "LIINIDE LOETELU"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(203, 211)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "VALITUD LIINI PEATUSED"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(355, 211)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "VALITUD PEATUSE VÄLJUMISED"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(416, 107)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 15)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "--->"
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(17, 114)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 29)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Save As"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(114, 158)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(19, 20)
        Me.TextBox1.TabIndex = 45
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(115, 184)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(18, 20)
        Me.TextBox2.TabIndex = 46
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(174, 156)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(88, 17)
        Me.CheckBox1.TabIndex = 47
        Me.CheckBox1.Text = "Kirjuta fail üle"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(174, 184)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(92, 17)
        Me.CheckBox2.TabIndex = 48
        Me.CheckBox2.Text = "Lisa faili lõppu"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Väljade eraldaja"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Kvalifikaator"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 561)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
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
        Me.Controls.Add(Me.txtLopppeatus)
        Me.Controls.Add(Me.txtAlgpeatus)
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOtsi As Button
    Friend WithEvents btnKuvaKaardil As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblLahtepeatus As Label
    Friend WithEvents lblLopppeatus As Label
    Friend WithEvents txtLopppeatus As MaskedTextBox
    Friend WithEvents txtAlgpeatus As TextBox
    Friend WithEvents UMap As PrjKaardistaja.UserControl1
    Friend WithEvents Button1 As Button
    Friend WithEvents ULiinidJaPeatusedList1 As LiinidJaPeatusedList.ULiinidJaPeatusedList
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
