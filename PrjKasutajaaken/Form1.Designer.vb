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
        Me.lblTranspordiLiik = New System.Windows.Forms.Label()
        Me.lblEeldatavAjakulu = New System.Windows.Forms.Label()
        Me.btnKuvaKaardil = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblKellaaeg = New System.Windows.Forms.Label()
        Me.lblLiiniNr = New System.Windows.Forms.Label()
        Me.lblPeatuseLiinid = New System.Windows.Forms.Label()
        Me.lblLiiniPeatused = New System.Windows.Forms.Label()
        Me.cbxVali = New System.Windows.Forms.ComboBox()
        Me.lblVali = New System.Windows.Forms.Label()
        Me.lblPeatus = New System.Windows.Forms.Label()
        Me.cbxPeatus = New System.Windows.Forms.ComboBox()
        Me.lblSihtpeatus = New System.Windows.Forms.Label()
        Me.lblAlguspeatus = New System.Windows.Forms.Label()
        Me.txtLopppeatus = New System.Windows.Forms.MaskedTextBox()
        Me.txtAlgpeatus = New System.Windows.Forms.TextBox()
        Me.UMap = New PrjKaardistaja.UserControl1()
        Me.SuspendLayout()
        '
        'btnOtsi
        '
        Me.btnOtsi.Location = New System.Drawing.Point(191, 421)
        Me.btnOtsi.Name = "btnOtsi"
        Me.btnOtsi.Size = New System.Drawing.Size(66, 48)
        Me.btnOtsi.TabIndex = 35
        Me.btnOtsi.Text = "OTSI"
        Me.btnOtsi.UseVisualStyleBackColor = True
        '
        'lblTranspordiLiik
        '
        Me.lblTranspordiLiik.Location = New System.Drawing.Point(12, 346)
        Me.lblTranspordiLiik.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTranspordiLiik.Name = "lblTranspordiLiik"
        Me.lblTranspordiLiik.Size = New System.Drawing.Size(109, 31)
        Me.lblTranspordiLiik.TabIndex = 34
        Me.lblTranspordiLiik.Text = "Transpordi liik"
        '
        'lblEeldatavAjakulu
        '
        Me.lblEeldatavAjakulu.Location = New System.Drawing.Point(329, 344)
        Me.lblEeldatavAjakulu.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEeldatavAjakulu.Name = "lblEeldatavAjakulu"
        Me.lblEeldatavAjakulu.Size = New System.Drawing.Size(134, 33)
        Me.lblEeldatavAjakulu.TabIndex = 33
        Me.lblEeldatavAjakulu.Text = "Eeldatav ajakulu"
        '
        'btnKuvaKaardil
        '
        Me.btnKuvaKaardil.Location = New System.Drawing.Point(35, 215)
        Me.btnKuvaKaardil.Name = "btnKuvaKaardil"
        Me.btnKuvaKaardil.Size = New System.Drawing.Size(124, 87)
        Me.btnKuvaKaardil.TabIndex = 32
        Me.btnKuvaKaardil.Text = "KUVA KAART"
        Me.btnKuvaKaardil.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(377, 396)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(44, 489)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 20
        '
        'lblKellaaeg
        '
        Me.lblKellaaeg.Location = New System.Drawing.Point(230, 344)
        Me.lblKellaaeg.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKellaaeg.Name = "lblKellaaeg"
        Me.lblKellaaeg.Size = New System.Drawing.Size(70, 20)
        Me.lblKellaaeg.TabIndex = 31
        Me.lblKellaaeg.Text = "Kellaaeg"
        '
        'lblLiiniNr
        '
        Me.lblLiiniNr.Location = New System.Drawing.Point(151, 344)
        Me.lblLiiniNr.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLiiniNr.Name = "lblLiiniNr"
        Me.lblLiiniNr.Size = New System.Drawing.Size(54, 20)
        Me.lblLiiniNr.TabIndex = 30
        Me.lblLiiniNr.Text = "Liini nr"
        '
        'lblPeatuseLiinid
        '
        Me.lblPeatuseLiinid.Location = New System.Drawing.Point(375, 512)
        Me.lblPeatuseLiinid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPeatuseLiinid.Name = "lblPeatuseLiinid"
        Me.lblPeatuseLiinid.Size = New System.Drawing.Size(105, 20)
        Me.lblPeatuseLiinid.TabIndex = 29
        Me.lblPeatuseLiinid.Text = "Liinide loetelu"
        '
        'lblLiiniPeatused
        '
        Me.lblLiiniPeatused.Location = New System.Drawing.Point(142, 512)
        Me.lblLiiniPeatused.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLiiniPeatused.Name = "lblLiiniPeatused"
        Me.lblLiiniPeatused.Size = New System.Drawing.Size(124, 20)
        Me.lblLiiniPeatused.TabIndex = 28
        Me.lblLiiniPeatused.Text = "Peatuste loetelu"
        '
        'cbxVali
        '
        Me.cbxVali.Location = New System.Drawing.Point(206, 391)
        Me.cbxVali.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxVali.Name = "cbxVali"
        Me.cbxVali.Size = New System.Drawing.Size(224, 28)
        Me.cbxVali.TabIndex = 27
        '
        'lblVali
        '
        Me.lblVali.AutoSize = True
        Me.lblVali.Location = New System.Drawing.Point(31, 391)
        Me.lblVali.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVali.Name = "lblVali"
        Me.lblVali.Size = New System.Drawing.Size(112, 20)
        Me.lblVali.TabIndex = 26
        Me.lblVali.Text = "Vali otsinguviis"
        '
        'lblPeatus
        '
        Me.lblPeatus.Location = New System.Drawing.Point(31, 171)
        Me.lblPeatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPeatus.Name = "lblPeatus"
        Me.lblPeatus.Size = New System.Drawing.Size(59, 20)
        Me.lblPeatus.TabIndex = 25
        Me.lblPeatus.Text = "Peatus"
        '
        'cbxPeatus
        '
        Me.cbxPeatus.Location = New System.Drawing.Point(141, 168)
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
        Me.lblSihtpeatus.Size = New System.Drawing.Size(113, 20)
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
        'UMap
        '
        Me.UMap.Location = New System.Drawing.Point(485, 6)
        Me.UMap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UMap.Name = "UMap"
        Me.UMap.Size = New System.Drawing.Size(737, 576)
        Me.UMap.TabIndex = 36
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1224, 594)
        Me.Controls.Add(Me.UMap)
        Me.Controls.Add(Me.btnOtsi)
        Me.Controls.Add(Me.lblTranspordiLiik)
        Me.Controls.Add(Me.lblEeldatavAjakulu)
        Me.Controls.Add(Me.btnKuvaKaardil)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblKellaaeg)
        Me.Controls.Add(Me.lblLiiniNr)
        Me.Controls.Add(Me.lblPeatuseLiinid)
        Me.Controls.Add(Me.lblLiiniPeatused)
        Me.Controls.Add(Me.cbxVali)
        Me.Controls.Add(Me.lblVali)
        Me.Controls.Add(Me.lblPeatus)
        Me.Controls.Add(Me.cbxPeatus)
        Me.Controls.Add(Me.lblSihtpeatus)
        Me.Controls.Add(Me.lblAlguspeatus)
        Me.Controls.Add(Me.txtLopppeatus)
        Me.Controls.Add(Me.txtAlgpeatus)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOtsi As Button
    Friend WithEvents lblTranspordiLiik As Label
    Friend WithEvents lblEeldatavAjakulu As Label
    Friend WithEvents btnKuvaKaardil As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblKellaaeg As Label
    Friend WithEvents lblLiiniNr As Label
    Friend WithEvents lblPeatuseLiinid As Label
    Friend WithEvents lblLiiniPeatused As Label
    Friend WithEvents cbxVali As ComboBox
    Friend WithEvents lblVali As Label
    Friend WithEvents lblPeatus As Label
    Friend WithEvents cbxPeatus As ComboBox
    Friend WithEvents lblSihtpeatus As Label
    Friend WithEvents lblAlguspeatus As Label
    Friend WithEvents txtLopppeatus As MaskedTextBox
    Friend WithEvents txtAlgpeatus As TextBox
    Friend WithEvents UMap As PrjKaardistaja.UserControl1
End Class
