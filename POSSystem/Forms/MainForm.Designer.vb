<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.SlidePanel2 = New DevComponents.DotNetBar.Controls.SlidePanel()
        Me.lblSelectedForm = New System.Windows.Forms.Label()
        Me.MetroTilePanel1 = New DevComponents.DotNetBar.Metro.MetroTilePanel()
        Me.ItemContainer1 = New DevComponents.DotNetBar.ItemContainer()
        Me.MetroTileItem1 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem2 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem3 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem4 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem6 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem5 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.SuspendLayout()
        '
        'SlidePanel2
        '
        Me.SlidePanel2.BackColor = System.Drawing.Color.White
        Me.SlidePanel2.ForeColor = System.Drawing.Color.Black
        Me.SlidePanel2.Location = New System.Drawing.Point(229, 10)
        Me.SlidePanel2.Name = "SlidePanel2"
        Me.SlidePanel2.Size = New System.Drawing.Size(752, 780)
        Me.SlidePanel2.TabIndex = 1
        Me.SlidePanel2.UsesBlockingAnimation = False
        '
        'lblSelectedForm
        '
        Me.lblSelectedForm.AutoSize = True
        Me.lblSelectedForm.BackColor = System.Drawing.Color.Goldenrod
        Me.lblSelectedForm.ForeColor = System.Drawing.Color.Black
        Me.lblSelectedForm.Location = New System.Drawing.Point(180, 13)
        Me.lblSelectedForm.Name = "lblSelectedForm"
        Me.lblSelectedForm.Size = New System.Drawing.Size(0, 13)
        Me.lblSelectedForm.TabIndex = 2
        Me.lblSelectedForm.Visible = False
        '
        'MetroTilePanel1
        '
        Me.MetroTilePanel1.BackColor = System.Drawing.Color.Snow
        Me.MetroTilePanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        '
        '
        '
        Me.MetroTilePanel1.BackgroundStyle.Class = "MetroTilePanel"
        Me.MetroTilePanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTilePanel1.ContainerControlProcessDialogKey = True
        Me.MetroTilePanel1.ForeColor = System.Drawing.Color.Black
        Me.MetroTilePanel1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer1})
        Me.MetroTilePanel1.Location = New System.Drawing.Point(3, 10)
        Me.MetroTilePanel1.Name = "MetroTilePanel1"
        Me.MetroTilePanel1.Size = New System.Drawing.Size(220, 526)
        Me.MetroTilePanel1.TabIndex = 3
        Me.MetroTilePanel1.Text = "MetroTilePanel1"
        '
        'ItemContainer1
        '
        '
        '
        '
        Me.ItemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer1.MultiLine = True
        Me.ItemContainer1.Name = "ItemContainer1"
        Me.ItemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.MetroTileItem1, Me.MetroTileItem2, Me.MetroTileItem3, Me.MetroTileItem4, Me.MetroTileItem6})
        '
        '
        '
        Me.ItemContainer1.TitleStyle.Class = "MetroTileGroupTitle"
        Me.ItemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer1.TitleText = "Menu"
        Me.ItemContainer1.TitleVisible = False
        '
        'MetroTileItem1
        '
        Me.MetroTileItem1.Name = "MetroTileItem1"
        Me.MetroTileItem1.Symbol = ""
        Me.MetroTileItem1.SymbolColor = System.Drawing.Color.White
        Me.MetroTileItem1.SymbolSize = 30.0!
        Me.MetroTileItem1.Text = "<br><b>Inventory</b></br>"
        Me.MetroTileItem1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Yellowish
        '
        '
        '
        Me.MetroTileItem1.TileStyle.BackgroundImage = CType(resources.GetObject("MetroTileItem1.TileStyle.BackgroundImage"), System.Drawing.Image)
        Me.MetroTileItem1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'MetroTileItem2
        '
        Me.MetroTileItem2.Name = "MetroTileItem2"
        Me.MetroTileItem2.Symbol = ""
        Me.MetroTileItem2.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem2.SymbolSize = 30.0!
        Me.MetroTileItem2.Text = "<br><b>Transactions</b></br>"
        Me.MetroTileItem2.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Yellowish
        '
        '
        '
        Me.MetroTileItem2.TileStyle.BackgroundImage = CType(resources.GetObject("MetroTileItem2.TileStyle.BackgroundImage"), System.Drawing.Image)
        Me.MetroTileItem2.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'MetroTileItem3
        '
        Me.MetroTileItem3.Name = "MetroTileItem3"
        Me.MetroTileItem3.Symbol = ""
        Me.MetroTileItem3.SymbolColor = System.Drawing.Color.White
        Me.MetroTileItem3.SymbolSize = 30.0!
        Me.MetroTileItem3.Text = "<br><b>Users</b></br>"
        Me.MetroTileItem3.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Yellowish
        '
        '
        '
        Me.MetroTileItem3.TileStyle.BackgroundImage = CType(resources.GetObject("MetroTileItem3.TileStyle.BackgroundImage"), System.Drawing.Image)
        Me.MetroTileItem3.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'MetroTileItem4
        '
        Me.MetroTileItem4.Name = "MetroTileItem4"
        Me.MetroTileItem4.Symbol = ""
        Me.MetroTileItem4.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem4.SymbolSize = 30.0!
        Me.MetroTileItem4.Text = "<br><b>Reports</b></br>"
        Me.MetroTileItem4.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Yellowish
        '
        '
        '
        Me.MetroTileItem4.TileStyle.BackgroundImage = CType(resources.GetObject("MetroTileItem4.TileStyle.BackgroundImage"), System.Drawing.Image)
        Me.MetroTileItem4.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'MetroTileItem6
        '
        Me.MetroTileItem6.Name = "MetroTileItem6"
        Me.MetroTileItem6.Symbol = ""
        Me.MetroTileItem6.SymbolColor = System.Drawing.Color.White
        Me.MetroTileItem6.SymbolSize = 30.0!
        Me.MetroTileItem6.Text = "<br><b>Logout</b></br>"
        Me.MetroTileItem6.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Yellowish
        '
        '
        '
        Me.MetroTileItem6.TileStyle.BackgroundImage = CType(resources.GetObject("MetroTileItem6.TileStyle.BackgroundImage"), System.Drawing.Image)
        Me.MetroTileItem6.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'MetroTileItem5
        '
        Me.MetroTileItem5.Name = "MetroTileItem5"
        Me.MetroTileItem5.Symbol = ""
        Me.MetroTileItem5.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem5.SymbolSize = 30.0!
        Me.MetroTileItem5.Text = "<br><b>Reports</b></br>"
        Me.MetroTileItem5.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Yellowish
        '
        '
        '
        Me.MetroTileItem5.TileStyle.BackgroundImage = CType(resources.GetObject("MetroTileItem5.TileStyle.BackgroundImage"), System.Drawing.Image)
        Me.MetroTileItem5.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(991, 780)
        Me.Controls.Add(Me.MetroTilePanel1)
        Me.Controls.Add(Me.lblSelectedForm)
        Me.Controls.Add(Me.SlidePanel2)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MetroForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SlidePanel2 As DevComponents.DotNetBar.Controls.SlidePanel
    Friend WithEvents lblSelectedForm As System.Windows.Forms.Label
    Friend WithEvents MetroTilePanel1 As DevComponents.DotNetBar.Metro.MetroTilePanel
    Friend WithEvents ItemContainer1 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents MetroTileItem1 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem2 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem3 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem4 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem6 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem5 As DevComponents.DotNetBar.Metro.MetroTileItem
End Class
