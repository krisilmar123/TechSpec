<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Kasutajaaken
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
        Me.btnKuvaKaardil = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnKuvaPeatused = New System.Windows.Forms.Button()
        Me.UMap = New PrjKaardistaja.Kaart()
        Me.ULiinidJaPeatusedList1 = New LiinidJaPeatusedList.ULiinidJaPeatusedList()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnVaatamisvaarsused = New System.Windows.Forms.Button()
        Me.chkBoxReaal = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEraldaja = New System.Windows.Forms.TextBox()
        Me.txtTunnus = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFailiNimi = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFailiAsukoht = New System.Windows.Forms.TextBox()
        Me.rdioFailiLoppu = New System.Windows.Forms.RadioButton()
        Me.rdioUleKirjutamine = New System.Windows.Forms.RadioButton()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSaveAs = New System.Windows.Forms.Button()
        Me.lblValjumisteTekst = New System.Windows.Forms.Label()
        Me.lblValjumisteArv = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnKuvaKaardil
        '
        Me.btnKuvaKaardil.Location = New System.Drawing.Point(873, 69)
        Me.btnKuvaKaardil.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnKuvaKaardil.Name = "btnKuvaKaardil"
        Me.btnKuvaKaardil.Size = New System.Drawing.Size(124, 88)
        Me.btnKuvaKaardil.TabIndex = 32
        Me.btnKuvaKaardil.Text = "KUVA KAART"
        Me.btnKuvaKaardil.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(376, 423)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 22)
        Me.Label3.TabIndex = 19
        '
        'btnKuvaPeatused
        '
        Me.btnKuvaPeatused.Enabled = False
        Me.btnKuvaPeatused.Location = New System.Drawing.Point(873, 248)
        Me.btnKuvaPeatused.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnKuvaPeatused.Name = "btnKuvaPeatused"
        Me.btnKuvaPeatused.Size = New System.Drawing.Size(124, 82)
        Me.btnKuvaPeatused.TabIndex = 37
        Me.btnKuvaPeatused.Text = " KUVA KÕIK PEATUSED"
        Me.btnKuvaPeatused.UseVisualStyleBackColor = True
        '
        'UMap
        '
        Me.UMap.Location = New System.Drawing.Point(1034, 69)
        Me.UMap.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.UMap.Name = "UMap"
        Me.UMap.Size = New System.Drawing.Size(1858, 1220)
        Me.UMap.TabIndex = 36
        Me.UMap.Visible = False
        '
        'ULiinidJaPeatusedList1
        '
        Me.ULiinidJaPeatusedList1.liiniInfo = Nothing
        Me.ULiinidJaPeatusedList1.liiniValik = Nothing
        Me.ULiinidJaPeatusedList1.Location = New System.Drawing.Point(18, 109)
        Me.ULiinidJaPeatusedList1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ULiinidJaPeatusedList1.Name = "ULiinidJaPeatusedList1"
        Me.ULiinidJaPeatusedList1.pensionaarCheckBox = False
        Me.ULiinidJaPeatusedList1.Size = New System.Drawing.Size(759, 568)
        Me.ULiinidJaPeatusedList1.TabIndex = 38
        Me.ULiinidJaPeatusedList1.valjumisteList = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1995, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 29)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "KAART"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 20)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "LIINIDE LOETELU"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(320, 69)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 20)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "VALITUD LIINI PEATUSED"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(538, 69)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(264, 20)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "VALITUD PEATUSE VÄLJUMISED"
        '
        'Timer1
        '
        '
        'btnVaatamisvaarsused
        '
        Me.btnVaatamisvaarsused.Enabled = False
        Me.btnVaatamisvaarsused.Image = Global.PrjKasutajaaken.My.Resources.Resources.kaamera
        Me.btnVaatamisvaarsused.Location = New System.Drawing.Point(872, 423)
        Me.btnVaatamisvaarsused.Name = "btnVaatamisvaarsused"
        Me.btnVaatamisvaarsused.Size = New System.Drawing.Size(126, 82)
        Me.btnVaatamisvaarsused.TabIndex = 43
        Me.btnVaatamisvaarsused.UseVisualStyleBackColor = True
        '
        'chkBoxReaal
        '
        Me.chkBoxReaal.AutoSize = True
        Me.chkBoxReaal.Location = New System.Drawing.Point(18, 600)
        Me.chkBoxReaal.Name = "chkBoxReaal"
        Me.chkBoxReaal.Size = New System.Drawing.Size(275, 24)
        Me.chkBoxReaal.TabIndex = 44
        Me.chkBoxReaal.Text = "NÄITA SÕIDUKEID REAALAJAS"
        Me.chkBoxReaal.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtEraldaja)
        Me.GroupBox1.Controls.Add(Me.txtTunnus)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtFailiNimi)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtFailiAsukoht)
        Me.GroupBox1.Controls.Add(Me.rdioFailiLoppu)
        Me.GroupBox1.Controls.Add(Me.rdioUleKirjutamine)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnSaveAs)
        Me.GroupBox1.Location = New System.Drawing.Point(324, 600)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(699, 277)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "VÄLJUMISTE SALVESTAMINE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(408, 117)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Väljade eraldaja"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(408, 68)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Teksti tunnus"
        '
        'txtEraldaja
        '
        Me.txtEraldaja.Location = New System.Drawing.Point(540, 109)
        Me.txtEraldaja.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEraldaja.Name = "txtEraldaja"
        Me.txtEraldaja.Size = New System.Drawing.Size(28, 26)
        Me.txtEraldaja.TabIndex = 11
        Me.txtEraldaja.Text = ","
        '
        'txtTunnus
        '
        Me.txtTunnus.Location = New System.Drawing.Point(540, 63)
        Me.txtTunnus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTunnus.Name = "txtTunnus"
        Me.txtTunnus.Size = New System.Drawing.Size(28, 26)
        Me.txtTunnus.TabIndex = 10
        Me.txtTunnus.Text = "'"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 195)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Viimase faili nimi"
        '
        'txtFailiNimi
        '
        Me.txtFailiNimi.Enabled = False
        Me.txtFailiNimi.Location = New System.Drawing.Point(14, 237)
        Me.txtFailiNimi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFailiNimi.Name = "txtFailiNimi"
        Me.txtFailiNimi.Size = New System.Drawing.Size(175, 26)
        Me.txtFailiNimi.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(339, 195)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Viimase faili asukoht"
        '
        'txtFailiAsukoht
        '
        Me.txtFailiAsukoht.Enabled = False
        Me.txtFailiAsukoht.Location = New System.Drawing.Point(200, 237)
        Me.txtFailiAsukoht.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFailiAsukoht.Name = "txtFailiAsukoht"
        Me.txtFailiAsukoht.Size = New System.Drawing.Size(446, 26)
        Me.txtFailiAsukoht.TabIndex = 6
        '
        'rdioFailiLoppu
        '
        Me.rdioFailiLoppu.AutoSize = True
        Me.rdioFailiLoppu.Location = New System.Drawing.Point(219, 114)
        Me.rdioFailiLoppu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdioFailiLoppu.Name = "rdioFailiLoppu"
        Me.rdioFailiLoppu.Size = New System.Drawing.Size(158, 24)
        Me.rdioFailiLoppu.TabIndex = 5
        Me.rdioFailiLoppu.TabStop = True
        Me.rdioFailiLoppu.Text = "KIRJUTA LÕPPU"
        Me.rdioFailiLoppu.UseVisualStyleBackColor = True
        '
        'rdioUleKirjutamine
        '
        Me.rdioUleKirjutamine.AutoSize = True
        Me.rdioUleKirjutamine.Checked = True
        Me.rdioUleKirjutamine.Location = New System.Drawing.Point(219, 63)
        Me.rdioUleKirjutamine.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdioUleKirjutamine.Name = "rdioUleKirjutamine"
        Me.rdioUleKirjutamine.Size = New System.Drawing.Size(137, 24)
        Me.rdioUleKirjutamine.TabIndex = 4
        Me.rdioUleKirjutamine.TabStop = True
        Me.rdioUleKirjutamine.Text = "KIRJUTA ÜLE"
        Me.rdioUleKirjutamine.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(22, 132)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 35)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnSaveAs
        '
        Me.btnSaveAs.Location = New System.Drawing.Point(22, 57)
        Me.btnSaveAs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSaveAs.Name = "btnSaveAs"
        Me.btnSaveAs.Size = New System.Drawing.Size(112, 35)
        Me.btnSaveAs.TabIndex = 0
        Me.btnSaveAs.Text = "SAVE AS"
        Me.btnSaveAs.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSaveAs.UseVisualStyleBackColor = True
        '
        'lblValjumisteTekst
        '
        Me.lblValjumisteTekst.AutoSize = True
        Me.lblValjumisteTekst.Location = New System.Drawing.Point(559, 444)
        Me.lblValjumisteTekst.Name = "lblValjumisteTekst"
        Me.lblValjumisteTekst.Size = New System.Drawing.Size(111, 20)
        Me.lblValjumisteTekst.TabIndex = 46
        Me.lblValjumisteTekst.Text = "Väljumiste arv:"
        '
        'lblValjumisteArv
        '
        Me.lblValjumisteArv.AutoSize = True
        Me.lblValjumisteArv.Location = New System.Drawing.Point(667, 444)
        Me.lblValjumisteArv.Name = "lblValjumisteArv"
        Me.lblValjumisteArv.Size = New System.Drawing.Size(18, 20)
        Me.lblValjumisteArv.TabIndex = 47
        Me.lblValjumisteArv.Text = "0"
        '
        'Kasutajaaken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1049)
        Me.Controls.Add(Me.lblValjumisteArv)
        Me.Controls.Add(Me.lblValjumisteTekst)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkBoxReaal)
        Me.Controls.Add(Me.btnVaatamisvaarsused)
        Me.Controls.Add(Me.ULiinidJaPeatusedList1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnKuvaPeatused)
        Me.Controls.Add(Me.UMap)
        Me.Controls.Add(Me.btnKuvaKaardil)
        Me.Controls.Add(Me.Label3)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Kasutajaaken"
        Me.Text = "Linnatranspordi rakendus"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents btnKuvaKaardil As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents UMap As PrjKaardistaja.Kaart
    Friend WithEvents btnKuvaPeatused As Button
    Friend WithEvents ULiinidJaPeatusedList1 As LiinidJaPeatusedList.ULiinidJaPeatusedList
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnVaatamisvaarsused As Button
    Friend WithEvents chkBoxReaal As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnSaveAs As Button
    Friend WithEvents rdioFailiLoppu As RadioButton
    Friend WithEvents rdioUleKirjutamine As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFailiAsukoht As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFailiNimi As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEraldaja As TextBox
    Friend WithEvents txtTunnus As TextBox
    Friend WithEvents lblValjumisteTekst As Label
    Friend WithEvents lblValjumisteArv As Label
End Class
