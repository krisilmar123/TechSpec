<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ULiinidJaPeatusedList
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.ListLiinid = New System.Windows.Forms.ListBox()
        Me.ListPeatused = New System.Windows.Forms.ListBox()
        Me.ListValjumised = New System.Windows.Forms.ListBox()
        Me.CheckBoxPensionaar = New System.Windows.Forms.CheckBox()
        Me.btnInimesteHulk = New System.Windows.Forms.Button()
        Me.txtInimesteHulk = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.chkMadal = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ListLiinid
        '
        Me.ListLiinid.FormattingEnabled = True
        Me.ListLiinid.Location = New System.Drawing.Point(0, 65)
        Me.ListLiinid.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListLiinid.Name = "ListLiinid"
        Me.ListLiinid.Size = New System.Drawing.Size(185, 212)
        Me.ListLiinid.TabIndex = 0
        '
        'ListPeatused
        '
        Me.ListPeatused.FormattingEnabled = True
        Me.ListPeatused.Location = New System.Drawing.Point(207, 65)
        Me.ListPeatused.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListPeatused.Name = "ListPeatused"
        Me.ListPeatused.Size = New System.Drawing.Size(138, 212)
        Me.ListPeatused.TabIndex = 1
        '
        'ListValjumised
        '
        Me.ListValjumised.FormattingEnabled = True
        Me.ListValjumised.Location = New System.Drawing.Point(363, 65)
        Me.ListValjumised.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListValjumised.Name = "ListValjumised"
        Me.ListValjumised.Size = New System.Drawing.Size(137, 212)
        Me.ListValjumised.TabIndex = 2
        '
        'CheckBoxPensionaar
        '
        Me.CheckBoxPensionaar.AutoSize = True
        Me.CheckBoxPensionaar.Location = New System.Drawing.Point(307, 31)
        Me.CheckBoxPensionaar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckBoxPensionaar.Name = "CheckBoxPensionaar"
        Me.CheckBoxPensionaar.Size = New System.Drawing.Size(153, 17)
        Me.CheckBoxPensionaar.TabIndex = 3
        Me.CheckBoxPensionaar.Text = "3 JÄRGMIST BUSSIAEGA"
        Me.CheckBoxPensionaar.UseVisualStyleBackColor = True
        '
        'btnInimesteHulk
        '
        Me.btnInimesteHulk.BackColor = System.Drawing.SystemColors.Control
        Me.btnInimesteHulk.Location = New System.Drawing.Point(9, 14)
        Me.btnInimesteHulk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnInimesteHulk.Name = "btnInimesteHulk"
        Me.btnInimesteHulk.Size = New System.Drawing.Size(158, 34)
        Me.btnInimesteHulk.TabIndex = 4
        Me.btnInimesteHulk.Text = "VAATA INIMESTE HULKA ÜHISTRANSPORDIS"
        Me.btnInimesteHulk.UseVisualStyleBackColor = False
        '
        'txtInimesteHulk
        '
        Me.txtInimesteHulk.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtInimesteHulk.Location = New System.Drawing.Point(179, 22)
        Me.txtInimesteHulk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtInimesteHulk.Name = "txtInimesteHulk"
        Me.txtInimesteHulk.ReadOnly = True
        Me.txtInimesteHulk.Size = New System.Drawing.Size(96, 20)
        Me.txtInimesteHulk.TabIndex = 5
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'chkMadal
        '
        Me.chkMadal.AutoSize = True
        Me.chkMadal.Location = New System.Drawing.Point(307, 10)
        Me.chkMadal.Name = "chkMadal"
        Me.chkMadal.Size = New System.Drawing.Size(195, 17)
        Me.chkMadal.TabIndex = 6
        Me.chkMadal.Text = "AINULT MADALA SISENEMISEGA"
        Me.chkMadal.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.chkMadal.UseVisualStyleBackColor = True
        '
        'ULiinidJaPeatusedList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.chkMadal)
        Me.Controls.Add(Me.txtInimesteHulk)
        Me.Controls.Add(Me.btnInimesteHulk)
        Me.Controls.Add(Me.CheckBoxPensionaar)
        Me.Controls.Add(Me.ListValjumised)
        Me.Controls.Add(Me.ListPeatused)
        Me.Controls.Add(Me.ListLiinid)
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Name = "ULiinidJaPeatusedList"
        Me.Size = New System.Drawing.Size(502, 281)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListLiinid As ListBox
    Friend WithEvents ListPeatused As ListBox
    Friend WithEvents ListValjumised As ListBox
    Friend WithEvents CheckBoxPensionaar As CheckBox
    Friend WithEvents btnInimesteHulk As Button
    Friend WithEvents txtInimesteHulk As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents chkMadal As CheckBox
End Class
