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
        Me.SuspendLayout
        '
        'ListLiinid
        '
        Me.ListLiinid.FormattingEnabled = true
        Me.ListLiinid.Location = New System.Drawing.Point(2, 8)
        Me.ListLiinid.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListLiinid.Name = "ListLiinid"
        Me.ListLiinid.Size = New System.Drawing.Size(185, 212)
        Me.ListLiinid.TabIndex = 0
        '
        'ListPeatused
        '
        Me.ListPeatused.FormattingEnabled = true
        Me.ListPeatused.Location = New System.Drawing.Point(209, 8)
        Me.ListPeatused.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListPeatused.Name = "ListPeatused"
        Me.ListPeatused.Size = New System.Drawing.Size(138, 212)
        Me.ListPeatused.TabIndex = 1
        '
        'ListValjumised
        '
        Me.ListValjumised.FormattingEnabled = true
        Me.ListValjumised.Location = New System.Drawing.Point(365, 8)
        Me.ListValjumised.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListValjumised.Name = "ListValjumised"
        Me.ListValjumised.Size = New System.Drawing.Size(137, 212)
        Me.ListValjumised.TabIndex = 2
        '
        'ULiinidJaPeatusedList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ListValjumised)
        Me.Controls.Add(Me.ListPeatused)
        Me.Controls.Add(Me.ListLiinid)
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Name = "ULiinidJaPeatusedList"
        Me.Size = New System.Drawing.Size(536, 256)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents ListLiinid As ListBox
    Friend WithEvents ListPeatused As ListBox
    Friend WithEvents ListValjumised As ListBox
End Class
