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
        Me.btnSalvesta = New System.Windows.Forms.Button()
        Me.chkUleKirjutamine = New System.Windows.Forms.CheckBox()
        Me.chkFailiLoppu = New System.Windows.Forms.CheckBox()
        Me.chkVali = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnKuvaKaardil
        '
        Me.btnKuvaKaardil.Location = New System.Drawing.Point(643, 144)
        Me.btnKuvaKaardil.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnKuvaKaardil.Name = "btnKuvaKaardil"
        Me.btnKuvaKaardil.Size = New System.Drawing.Size(125, 88)
        Me.btnKuvaKaardil.TabIndex = 32
        Me.btnKuvaKaardil.Text = "KUVA KAART"
        Me.btnKuvaKaardil.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(377, 423)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 21)
        Me.Label3.TabIndex = 19
        '
        'btnKuvaPeatused
        '
        Me.btnKuvaPeatused.Enabled = False
        Me.btnKuvaPeatused.Location = New System.Drawing.Point(643, 252)
        Me.btnKuvaPeatused.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnKuvaPeatused.Name = "btnKuvaPeatused"
        Me.btnKuvaPeatused.Size = New System.Drawing.Size(125, 82)
        Me.btnKuvaPeatused.TabIndex = 37
        Me.btnKuvaPeatused.Text = " KUVA KÕIK PEATUSED"
        Me.btnKuvaPeatused.UseVisualStyleBackColor = True
        '
        'UMap
        '
        Me.UMap.Location = New System.Drawing.Point(777, 17)
        Me.UMap.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.UMap.Name = "UMap"
        Me.UMap.Size = New System.Drawing.Size(1858, 1220)
        Me.UMap.TabIndex = 36
        Me.UMap.Visible = False
        '
        'ULiinidJaPeatusedList1
        '
        Me.ULiinidJaPeatusedList1.liiniInfo = Nothing
        Me.ULiinidJaPeatusedList1.liiniList = Nothing
        Me.ULiinidJaPeatusedList1.liiniValik = Nothing
        Me.ULiinidJaPeatusedList1.Location = New System.Drawing.Point(46, 104)
        Me.ULiinidJaPeatusedList1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ULiinidJaPeatusedList1.Name = "ULiinidJaPeatusedList1"
        Me.ULiinidJaPeatusedList1.pensionaarCheckBox = False
        Me.ULiinidJaPeatusedList1.Size = New System.Drawing.Size(516, 304)
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
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "KAART"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "LIINIDE LOETELU"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(348, 69)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "VALITUD LIINI PEATUSED"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(567, 69)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 13)
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
        Me.btnVaatamisvaarsused.Location = New System.Drawing.Point(642, 349)
        Me.btnVaatamisvaarsused.Name = "btnVaatamisvaarsused"
        Me.btnVaatamisvaarsused.Size = New System.Drawing.Size(126, 82)
        Me.btnVaatamisvaarsused.TabIndex = 43
        Me.btnVaatamisvaarsused.UseVisualStyleBackColor = True
        '
        'chkBoxReaal
        '
        Me.chkBoxReaal.AutoSize = True
        Me.chkBoxReaal.Location = New System.Drawing.Point(83, 414)
        Me.chkBoxReaal.Name = "chkBoxReaal"
        Me.chkBoxReaal.Size = New System.Drawing.Size(123, 17)
        Me.chkBoxReaal.TabIndex = 44
        Me.chkBoxReaal.Text = "Reaal aja väljumised"
        Me.chkBoxReaal.UseVisualStyleBackColor = True
        '
        'btnSalvesta
        '
        Me.btnSalvesta.Enabled = False
        Me.btnSalvesta.Location = New System.Drawing.Point(494, 487)
        Me.btnSalvesta.Name = "btnSalvesta"
        Me.btnSalvesta.Size = New System.Drawing.Size(150, 28)
        Me.btnSalvesta.TabIndex = 45
        Me.btnSalvesta.Text = "SALVESTA VÄLJUMISED"
        Me.btnSalvesta.UseVisualStyleBackColor = True
        '
        'chkUleKirjutamine
        '
        Me.chkUleKirjutamine.AutoSize = True
        Me.chkUleKirjutamine.Location = New System.Drawing.Point(410, 413)
        Me.chkUleKirjutamine.Name = "chkUleKirjutamine"
        Me.chkUleKirjutamine.Size = New System.Drawing.Size(88, 17)
        Me.chkUleKirjutamine.TabIndex = 46
        Me.chkUleKirjutamine.Text = "Kirjuta fail üle"
        Me.chkUleKirjutamine.UseVisualStyleBackColor = True
        '
        'chkFailiLoppu
        '
        Me.chkFailiLoppu.AutoSize = True
        Me.chkFailiLoppu.Location = New System.Drawing.Point(410, 437)
        Me.chkFailiLoppu.Name = "chkFailiLoppu"
        Me.chkFailiLoppu.Size = New System.Drawing.Size(92, 17)
        Me.chkFailiLoppu.TabIndex = 47
        Me.chkFailiLoppu.Text = "Lisa faili lõppu"
        Me.chkFailiLoppu.UseVisualStyleBackColor = True
        '
        'chkVali
        '
        Me.chkVali.AutoSize = True
        Me.chkVali.Enabled = False
        Me.chkVali.Location = New System.Drawing.Point(504, 413)
        Me.chkVali.Name = "chkVali"
        Me.chkVali.Size = New System.Drawing.Size(132, 17)
        Me.chkVali.TabIndex = 48
        Me.chkVali.Text = "Valin salvestamisel faili"
        Me.chkVali.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.chkVali)
        Me.Controls.Add(Me.chkFailiLoppu)
        Me.Controls.Add(Me.chkUleKirjutamine)
        Me.Controls.Add(Me.btnSalvesta)
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
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents btnSalvesta As Button
    Friend WithEvents chkUleKirjutamine As CheckBox
    Friend WithEvents chkFailiLoppu As CheckBox
    Friend WithEvents chkVali As CheckBox
End Class
