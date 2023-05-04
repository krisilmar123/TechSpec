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
        Me.SuspendLayout()
        '
        'btnKuvaKaardil
        '
        Me.btnKuvaKaardil.Location = New System.Drawing.Point(839, 169)
        Me.btnKuvaKaardil.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnKuvaKaardil.Name = "btnKuvaKaardil"
        Me.btnKuvaKaardil.Size = New System.Drawing.Size(122, 74)
        Me.btnKuvaKaardil.TabIndex = 32
        Me.btnKuvaKaardil.Text = "KUVA KAART"
        Me.btnKuvaKaardil.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(376, 395)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 22)
        Me.Label3.TabIndex = 19
        '
        'btnKuvaPeatused
        '
        Me.btnKuvaPeatused.Enabled = False
        Me.btnKuvaPeatused.Location = New System.Drawing.Point(837, 288)
        Me.btnKuvaPeatused.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnKuvaPeatused.Name = "btnKuvaPeatused"
        Me.btnKuvaPeatused.Size = New System.Drawing.Size(124, 74)
        Me.btnKuvaPeatused.TabIndex = 37
        Me.btnKuvaPeatused.Text = " KUVA KÕIK PEATUSED"
        Me.btnKuvaPeatused.UseVisualStyleBackColor = True
        '
        'UMap
        '
        Me.UMap.Location = New System.Drawing.Point(1052, 69)
        Me.UMap.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.UMap.Name = "UMap"
        Me.UMap.Size = New System.Drawing.Size(1858, 1220)
        Me.UMap.TabIndex = 36
        Me.UMap.Visible = False
        '
        'ULiinidJaPeatusedList1
        '
        Me.ULiinidJaPeatusedList1.liiniValik = Nothing
        Me.ULiinidJaPeatusedList1.Location = New System.Drawing.Point(72, 154)
        Me.ULiinidJaPeatusedList1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ULiinidJaPeatusedList1.Name = "ULiinidJaPeatusedList1"
        Me.ULiinidJaPeatusedList1.Size = New System.Drawing.Size(759, 343)
        Me.ULiinidJaPeatusedList1.TabIndex = 38
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
        Me.Label4.Location = New System.Drawing.Point(348, 69)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 20)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "VALITUD LIINI PEATUSED"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(567, 69)
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
        Me.btnVaatamisvaarsused.Image = Global.PrjKasutajaaken.My.Resources.Resources.foto__1___2_
        Me.btnVaatamisvaarsused.Location = New System.Drawing.Point(839, 395)
        Me.btnVaatamisvaarsused.Name = "btnVaatamisvaarsused"
        Me.btnVaatamisvaarsused.Size = New System.Drawing.Size(122, 85)
        Me.btnVaatamisvaarsused.TabIndex = 43
        Me.btnVaatamisvaarsused.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(646, 405)
        Me.Name = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnKuvaKaardil As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents UMap As PrjKaardistaja.UserControl1
    Friend WithEvents btnKuvaPeatused As Button
    Friend WithEvents ULiinidJaPeatusedList1 As LiinidJaPeatusedList.ULiinidJaPeatusedList
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnVaatamisvaarsused As Button
End Class
