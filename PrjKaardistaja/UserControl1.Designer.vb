<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GMapControl1 = New GMap.NET.WindowsForms.GMapControl()
        Me.SuspendLayout
        '
        'GMapControl1
        '
        Me.GMapControl1.Bearing = 0!
        Me.GMapControl1.CanDragMap = true
        Me.GMapControl1.EmptyTileColor = System.Drawing.Color.Navy
        Me.GMapControl1.GrayScaleMode = false
        Me.GMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.GMapControl1.LevelsKeepInMemory = 5
        Me.GMapControl1.Location = New System.Drawing.Point(0, 0)
        Me.GMapControl1.MarkersEnabled = true
        Me.GMapControl1.MaxZoom = 2
        Me.GMapControl1.MinZoom = 2
        Me.GMapControl1.MouseWheelZoomEnabled = true
        Me.GMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.GMapControl1.Name = "GMapControl1"
        Me.GMapControl1.NegativeMode = false
        Me.GMapControl1.PolygonsEnabled = true
        Me.GMapControl1.RetryLoadTile = 0
        Me.GMapControl1.RoutesEnabled = true
        Me.GMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.GMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(65,Byte),Integer), CType(CType(105,Byte),Integer), CType(CType(225,Byte),Integer))
        Me.GMapControl1.ShowTileGridLines = false
        Me.GMapControl1.Size = New System.Drawing.Size(797, 447)
        Me.GMapControl1.TabIndex = 0
        Me.GMapControl1.Zoom = 0R
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GMapControl1)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(800, 450)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents GMapControl1 As GMap.NET.WindowsForms.GMapControl
End Class
