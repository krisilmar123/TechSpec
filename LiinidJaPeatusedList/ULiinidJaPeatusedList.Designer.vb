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
        Me.ListLiinid = New System.Windows.Forms.ListBox()
        Me.ListPeatused = New System.Windows.Forms.ListBox()
        Me.ListValjumised = New System.Windows.Forms.ListBox()
        Me.CheckBoxPensionaar = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ListLiinid
        '
        Me.ListLiinid.FormattingEnabled = True
        Me.ListLiinid.ItemHeight = 20
        Me.ListLiinid.Location = New System.Drawing.Point(0, 100)
        Me.ListLiinid.Name = "ListLiinid"
        Me.ListLiinid.Size = New System.Drawing.Size(276, 324)
        Me.ListLiinid.TabIndex = 0
        '
        'ListPeatused
        '
        Me.ListPeatused.FormattingEnabled = True
        Me.ListPeatused.ItemHeight = 20
        Me.ListPeatused.Location = New System.Drawing.Point(311, 100)
        Me.ListPeatused.Name = "ListPeatused"
        Me.ListPeatused.Size = New System.Drawing.Size(205, 324)
        Me.ListPeatused.TabIndex = 1
        '
        'ListValjumised
        '
        Me.ListValjumised.FormattingEnabled = True
        Me.ListValjumised.ItemHeight = 20
        Me.ListValjumised.Location = New System.Drawing.Point(545, 100)
        Me.ListValjumised.Name = "ListValjumised"
        Me.ListValjumised.Size = New System.Drawing.Size(204, 324)
        Me.ListValjumised.TabIndex = 2
        '
        'CheckBoxPensionaar
        '
        Me.CheckBoxPensionaar.AutoSize = True
        Me.CheckBoxPensionaar.Location = New System.Drawing.Point(545, 49)
        Me.CheckBoxPensionaar.Name = "CheckBoxPensionaar"
        Me.CheckBoxPensionaar.Size = New System.Drawing.Size(185, 24)
        Me.CheckBoxPensionaar.TabIndex = 3
        Me.CheckBoxPensionaar.Text = "3 Järgmist bussiaega"
        Me.CheckBoxPensionaar.UseVisualStyleBackColor = True
        '
        'ULiinidJaPeatusedList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CheckBoxPensionaar)
        Me.Controls.Add(Me.ListValjumised)
        Me.Controls.Add(Me.ListPeatused)
        Me.Controls.Add(Me.ListLiinid)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ULiinidJaPeatusedList"
        Me.Size = New System.Drawing.Size(759, 429)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListLiinid As ListBox
    Friend WithEvents ListPeatused As ListBox
    Friend WithEvents ListValjumised As ListBox
    Friend WithEvents CheckBoxPensionaar As CheckBox
End Class
