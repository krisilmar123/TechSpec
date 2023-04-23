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
        Me.btnOtsi = New System.Windows.Forms.Button()
        Me.btnKuvaKaardil = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxVali = New System.Windows.Forms.ComboBox()
        Me.lblPeatus = New System.Windows.Forms.Label()
        Me.cbxPeatus = New System.Windows.Forms.ComboBox()
        Me.lblSihtpeatus = New System.Windows.Forms.Label()
        Me.lblAlguspeatus = New System.Windows.Forms.Label()
        Me.txtLopppeatus = New System.Windows.Forms.MaskedTextBox()
        Me.txtAlgpeatus = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UMap = New PrjKaardistaja.UserControl1()
        Me.ULiinidJaPeatusedList1 = New LiinidJaPeatusedList.ULiinidJaPeatusedList()
        Me.SuspendLayout()
        '
        'btnOtsi
        '
        Me.btnOtsi.Location = New System.Drawing.Point(25, 180)
        Me.btnOtsi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnOtsi.Name = "btnOtsi"
        Me.btnOtsi.Size = New System.Drawing.Size(66, 48)
        Me.btnOtsi.TabIndex = 35
        Me.btnOtsi.Text = "OTSI"
        Me.btnOtsi.UseVisualStyleBackColor = True
        '
        'btnKuvaKaardil
        '
        Me.btnKuvaKaardil.Location = New System.Drawing.Point(357, 18)
        Me.btnKuvaKaardil.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnKuvaKaardil.Name = "btnKuvaKaardil"
        Me.btnKuvaKaardil.Size = New System.Drawing.Size(124, 88)
        Me.btnKuvaKaardil.TabIndex = 32
        Me.btnKuvaKaardil.Text = "KUVA KAART"
        Me.btnKuvaKaardil.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(377, 396)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 22)
        Me.Label3.TabIndex = 19
        '
        'cbxVali
        '
        Me.cbxVali.Location = New System.Drawing.Point(126, 180)
        Me.cbxVali.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxVali.Name = "cbxVali"
        Me.cbxVali.Size = New System.Drawing.Size(224, 28)
        Me.cbxVali.TabIndex = 27
        '
        'lblPeatus
        '
        Me.lblPeatus.Location = New System.Drawing.Point(21, 129)
        Me.lblPeatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPeatus.Name = "lblPeatus"
        Me.lblPeatus.Size = New System.Drawing.Size(58, 20)
        Me.lblPeatus.TabIndex = 25
        Me.lblPeatus.Text = "Peatus"
        '
        'cbxPeatus
        '
        Me.cbxPeatus.Location = New System.Drawing.Point(164, 125)
        Me.cbxPeatus.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxPeatus.Name = "cbxPeatus"
        Me.cbxPeatus.Size = New System.Drawing.Size(186, 28)
        Me.cbxPeatus.TabIndex = 24
        '
        'lblSihtpeatus
        '
        Me.lblSihtpeatus.Location = New System.Drawing.Point(21, 28)
        Me.lblSihtpeatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSihtpeatus.Name = "lblSihtpeatus"
        Me.lblSihtpeatus.Size = New System.Drawing.Size(112, 20)
        Me.lblSihtpeatus.TabIndex = 23
        Me.lblSihtpeatus.Text = "Vali sihtpeatus"
        '
        'lblAlguspeatus
        '
        Me.lblAlguspeatus.Location = New System.Drawing.Point(21, 84)
        Me.lblAlguspeatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAlguspeatus.Name = "lblAlguspeatus"
        Me.lblAlguspeatus.Size = New System.Drawing.Size(123, 20)
        Me.lblAlguspeatus.TabIndex = 22
        Me.lblAlguspeatus.Text = "Vali lähtepeatus"
        '
        'txtLopppeatus
        '
        Me.txtLopppeatus.Location = New System.Drawing.Point(164, 28)
        Me.txtLopppeatus.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLopppeatus.Name = "txtLopppeatus"
        Me.txtLopppeatus.Size = New System.Drawing.Size(186, 26)
        Me.txtLopppeatus.TabIndex = 21
        '
        'txtAlgpeatus
        '
        Me.txtAlgpeatus.Location = New System.Drawing.Point(164, 78)
        Me.txtAlgpeatus.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAlgpeatus.Name = "txtAlgpeatus"
        Me.txtAlgpeatus.Size = New System.Drawing.Size(186, 26)
        Me.txtAlgpeatus.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(357, 110)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 68)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "KÕIK PEATUSED"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UMap
        '
        Me.UMap.Location = New System.Drawing.Point(663, 3)
        Me.UMap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UMap.Name = "UMap"
        Me.UMap.Size = New System.Drawing.Size(761, 593)
        Me.UMap.TabIndex = 36
        '
        'ULiinidJaPeatusedList1
        '
        Me.ULiinidJaPeatusedList1.Location = New System.Drawing.Point(2, 250)
        Me.ULiinidJaPeatusedList1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ULiinidJaPeatusedList1.Name = "ULiinidJaPeatusedList1"
        Me.ULiinidJaPeatusedList1.Size = New System.Drawing.Size(624, 346)
        Me.ULiinidJaPeatusedList1.TabIndex = 38
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1422, 723)
        Me.Controls.Add(Me.ULiinidJaPeatusedList1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.UMap)
        Me.Controls.Add(Me.btnOtsi)
        Me.Controls.Add(Me.btnKuvaKaardil)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbxVali)
        Me.Controls.Add(Me.lblPeatus)
        Me.Controls.Add(Me.cbxPeatus)
        Me.Controls.Add(Me.lblSihtpeatus)
        Me.Controls.Add(Me.lblAlguspeatus)
        Me.Controls.Add(Me.txtLopppeatus)
        Me.Controls.Add(Me.txtAlgpeatus)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOtsi As Button
    Friend WithEvents btnKuvaKaardil As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxVali As ComboBox
    Friend WithEvents lblPeatus As Label
    Friend WithEvents cbxPeatus As ComboBox
    Friend WithEvents lblSihtpeatus As Label
    Friend WithEvents lblAlguspeatus As Label
    Friend WithEvents txtLopppeatus As MaskedTextBox
    Friend WithEvents txtAlgpeatus As TextBox
    Friend WithEvents UMap As PrjKaardistaja.UserControl1
    Friend WithEvents Button1 As Button
    Friend WithEvents ULiinidJaPeatusedList1 As LiinidJaPeatusedList.ULiinidJaPeatusedList
End Class
