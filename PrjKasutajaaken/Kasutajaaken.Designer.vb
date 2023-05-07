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
        Me.SuspendLayout
        '
        'btnKuvaKaardil
        '
        Me.btnKuvaKaardil.Location = New System.Drawing.Point(582, 45)
        Me.btnKuvaKaardil.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnKuvaKaardil.Name = "btnKuvaKaardil"
        Me.btnKuvaKaardil.Size = New System.Drawing.Size(83, 57)
        Me.btnKuvaKaardil.TabIndex = 32
        Me.btnKuvaKaardil.Text = "KUVA KAART"
        Me.btnKuvaKaardil.UseVisualStyleBackColor = true
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(251, 275)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 14)
        Me.Label3.TabIndex = 19
        '
        'btnKuvaPeatused
        '
        Me.btnKuvaPeatused.Enabled = false
        Me.btnKuvaPeatused.Location = New System.Drawing.Point(582, 161)
        Me.btnKuvaPeatused.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnKuvaPeatused.Name = "btnKuvaPeatused"
        Me.btnKuvaPeatused.Size = New System.Drawing.Size(83, 53)
        Me.btnKuvaPeatused.TabIndex = 37
        Me.btnKuvaPeatused.Text = " KUVA KÕIK PEATUSED"
        Me.btnKuvaPeatused.UseVisualStyleBackColor = true
        '
        'UMap
        '
        Me.UMap.Location = New System.Drawing.Point(689, 45)
        Me.UMap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UMap.Name = "UMap"
        Me.UMap.Size = New System.Drawing.Size(1239, 793)
        Me.UMap.TabIndex = 36
        Me.UMap.Visible = false
        '
        'ULiinidJaPeatusedList1
        '
        Me.ULiinidJaPeatusedList1.liiniInfo = Nothing
        Me.ULiinidJaPeatusedList1.liiniValik = Nothing
        Me.ULiinidJaPeatusedList1.Location = New System.Drawing.Point(12, 71)
        Me.ULiinidJaPeatusedList1.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.ULiinidJaPeatusedList1.Name = "ULiinidJaPeatusedList1"
        Me.ULiinidJaPeatusedList1.pensionaarCheckBox = false
        Me.ULiinidJaPeatusedList1.Size = New System.Drawing.Size(506, 369)
        Me.ULiinidJaPeatusedList1.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(1330, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "KAART"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(53, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "LIINIDE LOETELU"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(213, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "VALITUD LIINI PEATUSED"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(359, 45)
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
        Me.btnVaatamisvaarsused.Enabled = false
        Me.btnVaatamisvaarsused.Image = Global.PrjKasutajaaken.My.Resources.Resources.kaamera
        Me.btnVaatamisvaarsused.Location = New System.Drawing.Point(581, 275)
        Me.btnVaatamisvaarsused.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVaatamisvaarsused.Name = "btnVaatamisvaarsused"
        Me.btnVaatamisvaarsused.Size = New System.Drawing.Size(84, 53)
        Me.btnVaatamisvaarsused.TabIndex = 43
        Me.btnVaatamisvaarsused.UseVisualStyleBackColor = true
        '
        'chkBoxReaal
        '
        Me.chkBoxReaal.AutoSize = true
        Me.chkBoxReaal.Location = New System.Drawing.Point(12, 390)
        Me.chkBoxReaal.Margin = New System.Windows.Forms.Padding(2)
        Me.chkBoxReaal.Name = "chkBoxReaal"
        Me.chkBoxReaal.Size = New System.Drawing.Size(184, 17)
        Me.chkBoxReaal.TabIndex = 44
        Me.chkBoxReaal.Text = "NÄITA SÕIDUKEID REAALAJAS"
        Me.chkBoxReaal.UseVisualStyleBackColor = true
        '
        'Kasutajaaken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1283, 682)
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
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "Kasutajaaken"
        Me.Text = "Form1"
        Me.ResumeLayout(false)
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
End Class
