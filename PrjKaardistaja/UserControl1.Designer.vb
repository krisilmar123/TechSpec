<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserControl1
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
        Me.GMapControl1 = New GMap.NET.WindowsForms.GMapControl()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TxtAlgusPeatus = New System.Windows.Forms.TextBox()
        Me.txtLoppPeatus = New System.Windows.Forms.TextBox()
        Me.btnOtsiPeatused = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'GMapControl1
        '
        Me.GMapControl1.Bearing = 0!
        Me.GMapControl1.CanDragMap = True
        Me.GMapControl1.EmptyTileColor = System.Drawing.Color.Navy
        Me.GMapControl1.GrayScaleMode = False
        Me.GMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.GMapControl1.LevelsKeepInMemory = 5
        Me.GMapControl1.Location = New System.Drawing.Point(0, 0)
        Me.GMapControl1.MarkersEnabled = True
        Me.GMapControl1.MaxZoom = 2
        Me.GMapControl1.MinZoom = 2
        Me.GMapControl1.MouseWheelZoomEnabled = True
        Me.GMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.GMapControl1.Name = "GMapControl1"
        Me.GMapControl1.NegativeMode = False
        Me.GMapControl1.PolygonsEnabled = True
        Me.GMapControl1.RetryLoadTile = 0
        Me.GMapControl1.RoutesEnabled = True
        Me.GMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.GMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GMapControl1.ShowTileGridLines = False
        Me.GMapControl1.Size = New System.Drawing.Size(797, 447)
        Me.GMapControl1.TabIndex = 0
        Me.GMapControl1.Zoom = 0R
        '
        'TxtAlgusPeatus
        '
        Me.TxtAlgusPeatus.Location = New System.Drawing.Point(3, 12)
        Me.TxtAlgusPeatus.Name = "TxtAlgusPeatus"
        Me.TxtAlgusPeatus.Size = New System.Drawing.Size(100, 20)
        Me.TxtAlgusPeatus.TabIndex = 1
        '
        'txtLoppPeatus
        '
        Me.txtLoppPeatus.Location = New System.Drawing.Point(3, 38)
        Me.txtLoppPeatus.Name = "txtLoppPeatus"
        Me.txtLoppPeatus.Size = New System.Drawing.Size(100, 20)
        Me.txtLoppPeatus.TabIndex = 2
        '
        'btnOtsiPeatused
        '
        Me.btnOtsiPeatused.Location = New System.Drawing.Point(13, 64)
        Me.btnOtsiPeatused.Name = "btnOtsiPeatused"
        Me.btnOtsiPeatused.Size = New System.Drawing.Size(75, 23)
        Me.btnOtsiPeatused.TabIndex = 3
        Me.btnOtsiPeatused.Text = "Otsi"
        Me.btnOtsiPeatused.UseVisualStyleBackColor = True
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnOtsiPeatused)
        Me.Controls.Add(Me.txtLoppPeatus)
        Me.Controls.Add(Me.TxtAlgusPeatus)
        Me.Controls.Add(Me.GMapControl1)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(800, 450)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GMapControl1 As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TxtAlgusPeatus As TextBox
    Friend WithEvents txtLoppPeatus As TextBox
    Friend WithEvents btnOtsiPeatused As Button
End Class
