<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transactions
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transactions))
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.dgvSummary = New System.Windows.Forms.DataGridView()
        Me.ProductCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblAmtFig = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.lblItemFig = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalItems = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.SlidePanel3 = New DevComponents.DotNetBar.Controls.SlidePanel()
        Me.panelPayment = New DevComponents.DotNetBar.PanelEx()
        Me.btnCancelCash = New DevComponents.DotNetBar.ButtonX()
        Me.btnCashSubmit = New DevComponents.DotNetBar.ButtonX()
        Me.lblCashNumberItems = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblCashChange = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblCashAmtDue = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCashPayment = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCash = New DevComponents.DotNetBar.ButtonX()
        Me.btnClear = New DevComponents.DotNetBar.ButtonX()
        Me.GalleryContainer1 = New DevComponents.DotNetBar.GalleryContainer()
        Me.SlidePanel1 = New DevComponents.DotNetBar.Controls.SlidePanel()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.cmbProductCode = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.dgvSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SlidePanel3.SuspendLayout()
        Me.panelPayment.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SlidePanel1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabItem1
        '
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "TabItem1"
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.AttachedControl = Me.SuperTabControlPanel2
        Me.SuperTabItem2.GlobalItem = False
        Me.SuperTabItem2.Name = "SuperTabItem2"
        Me.SuperTabItem2.Text = "SuperTabItem2"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(791, 461)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me.SuperTabItem2
        '
        'dgvSummary
        '
        Me.dgvSummary.AllowUserToAddRows = False
        Me.dgvSummary.AllowUserToDeleteRows = False
        Me.dgvSummary.AllowUserToResizeColumns = False
        Me.dgvSummary.AllowUserToResizeRows = False
        Me.dgvSummary.BackgroundColor = System.Drawing.Color.White
        Me.dgvSummary.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSummary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvSummary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSummary.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSummary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductCode, Me.ProductName, Me.Price, Me.Quantity, Me.Amount, Me.Stock})
        Me.dgvSummary.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSummary.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSummary.Location = New System.Drawing.Point(12, 104)
        Me.dgvSummary.MultiSelect = False
        Me.dgvSummary.Name = "dgvSummary"
        Me.dgvSummary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvSummary.RowHeadersVisible = False
        Me.dgvSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvSummary.Size = New System.Drawing.Size(297, 512)
        Me.dgvSummary.TabIndex = 3
        '
        'ProductCode
        '
        Me.ProductCode.HeaderText = "Product Code"
        Me.ProductCode.Name = "ProductCode"
        Me.ProductCode.ReadOnly = True
        Me.ProductCode.Visible = False
        '
        'ProductName
        '
        Me.ProductName.HeaderText = "Product Name"
        Me.ProductName.Name = "ProductName"
        Me.ProductName.ReadOnly = True
        '
        'Price
        '
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Visible = False
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        '
        'Stock
        '
        Me.Stock.HeaderText = "Stock"
        Me.Stock.Name = "Stock"
        Me.Stock.Visible = False
        '
        'lblAmtFig
        '
        Me.lblAmtFig.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmtFig.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblAmtFig.Location = New System.Drawing.Point(144, 15)
        Me.lblAmtFig.Name = "lblAmtFig"
        Me.lblAmtFig.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAmtFig.Size = New System.Drawing.Size(146, 37)
        Me.lblAmtFig.TabIndex = 3
        Me.lblAmtFig.Text = "0"
        Me.lblAmtFig.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PanelEx1)
        Me.Panel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Location = New System.Drawing.Point(12, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(297, 42)
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(2, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Order Summary"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.UseCompatibleTextRendering = True
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Location = New System.Drawing.Point(325, 49)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelEx1.Size = New System.Drawing.Size(399, 440)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackgroundImage = CType(resources.GetObject("PanelEx1.Style.BackgroundImage"), System.Drawing.Image)
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 95
        Me.PanelEx1.Text = "PanelEx1"
        '
        'lblItemFig
        '
        Me.lblItemFig.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemFig.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblItemFig.Location = New System.Drawing.Point(15, 15)
        Me.lblItemFig.Name = "lblItemFig"
        Me.lblItemFig.Size = New System.Drawing.Size(120, 37)
        Me.lblItemFig.TabIndex = 2
        Me.lblItemFig.Text = "0"
        Me.lblItemFig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(190, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Amount"
        '
        'lblTotalItems
        '
        Me.lblTotalItems.AutoSize = True
        Me.lblTotalItems.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalItems.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTotalItems.Location = New System.Drawing.Point(19, 52)
        Me.lblTotalItems.Name = "lblTotalItems"
        Me.lblTotalItems.Size = New System.Drawing.Size(43, 19)
        Me.lblTotalItems.TabIndex = 0
        Me.lblTotalItems.Text = "Items"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.lblAmtFig)
        Me.Panel2.Controls.Add(Me.lblItemFig)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblTotalItems)
        Me.Panel2.Location = New System.Drawing.Point(12, 622)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(297, 71)
        Me.Panel2.TabIndex = 7
        '
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToAddRows = False
        Me.dgvProducts.AllowUserToDeleteRows = False
        Me.dgvProducts.AllowUserToResizeColumns = False
        Me.dgvProducts.AllowUserToResizeRows = False
        Me.dgvProducts.BackgroundColor = System.Drawing.Color.White
        Me.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.GridColor = System.Drawing.Color.White
        Me.dgvProducts.Location = New System.Drawing.Point(337, 105)
        Me.dgvProducts.MultiSelect = False
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.ReadOnly = True
        Me.dgvProducts.RowHeadersVisible = False
        Me.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvProducts.ShowEditingIcon = False
        Me.dgvProducts.Size = New System.Drawing.Size(403, 440)
        Me.dgvProducts.TabIndex = 2
        Me.dgvProducts.VirtualMode = True
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.BackColor = System.Drawing.Color.Snow
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblSearch.Location = New System.Drawing.Point(616, 75)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(48, 17)
        Me.lblSearch.TabIndex = 86
        Me.lblSearch.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtSearch.Border.Class = "TextBoxBorder"
        Me.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(339, 73)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PreventEnterBeep = True
        Me.txtSearch.Size = New System.Drawing.Size(258, 22)
        Me.txtSearch.TabIndex = 1
        Me.txtSearch.WatermarkFont = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.txtSearch.WatermarkText = "Search here"
        '
        'SlidePanel3
        '
        Me.SlidePanel3.BackColor = System.Drawing.Color.DimGray
        Me.SlidePanel3.BackgroundImage = CType(resources.GetObject("SlidePanel3.BackgroundImage"), System.Drawing.Image)
        Me.SlidePanel3.Controls.Add(Me.panelPayment)
        Me.SlidePanel3.Location = New System.Drawing.Point(363, 125)
        Me.SlidePanel3.Name = "SlidePanel3"
        Me.SlidePanel3.Size = New System.Drawing.Size(316, 322)
        Me.SlidePanel3.SlideOutButtonVisible = False
        Me.SlidePanel3.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Bottom
        Me.SlidePanel3.TabIndex = 88
        Me.SlidePanel3.Text = "SlidePanel1"
        Me.SlidePanel3.UsesBlockingAnimation = False
        Me.SlidePanel3.Visible = False
        '
        'panelPayment
        '
        Me.panelPayment.AntiAlias = False
        Me.panelPayment.CanvasColor = System.Drawing.SystemColors.Control
        Me.panelPayment.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panelPayment.Controls.Add(Me.btnCancelCash)
        Me.panelPayment.Controls.Add(Me.btnCashSubmit)
        Me.panelPayment.Controls.Add(Me.lblCashNumberItems)
        Me.panelPayment.Controls.Add(Me.Label10)
        Me.panelPayment.Controls.Add(Me.lblCashChange)
        Me.panelPayment.Controls.Add(Me.Label8)
        Me.panelPayment.Controls.Add(Me.lblCashAmtDue)
        Me.panelPayment.Controls.Add(Me.Label5)
        Me.panelPayment.Controls.Add(Me.txtCashPayment)
        Me.panelPayment.Controls.Add(Me.Label4)
        Me.panelPayment.Controls.Add(Me.Panel4)
        Me.panelPayment.Location = New System.Drawing.Point(4, 5)
        Me.panelPayment.Name = "panelPayment"
        Me.panelPayment.Size = New System.Drawing.Size(307, 314)
        Me.panelPayment.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelPayment.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panelPayment.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Center
        Me.panelPayment.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panelPayment.Style.CornerDiameter = 1
        Me.panelPayment.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelPayment.Style.GradientAngle = 90
        Me.panelPayment.TabIndex = 0
        '
        'btnCancelCash
        '
        Me.btnCancelCash.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancelCash.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelCash.BackgroundImage = CType(resources.GetObject("btnCancelCash.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelCash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelCash.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnCancelCash.Font = New System.Drawing.Font("Futura LT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelCash.Location = New System.Drawing.Point(152, 247)
        Me.btnCancelCash.Name = "btnCancelCash"
        Me.btnCancelCash.PulseSpeed = 100
        Me.btnCancelCash.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10)
        Me.btnCancelCash.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltF2)
        Me.btnCancelCash.Size = New System.Drawing.Size(137, 36)
        Me.btnCancelCash.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnCancelCash.TabIndex = 94
        Me.btnCancelCash.Text = "CANCEL"
        Me.btnCancelCash.TextColor = System.Drawing.Color.White
        '
        'btnCashSubmit
        '
        Me.btnCashSubmit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCashSubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnCashSubmit.BackgroundImage = CType(resources.GetObject("btnCashSubmit.BackgroundImage"), System.Drawing.Image)
        Me.btnCashSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCashSubmit.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnCashSubmit.Enabled = False
        Me.btnCashSubmit.Font = New System.Drawing.Font("Futura LT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCashSubmit.Location = New System.Drawing.Point(17, 247)
        Me.btnCashSubmit.Name = "btnCashSubmit"
        Me.btnCashSubmit.PulseSpeed = 100
        Me.btnCashSubmit.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10)
        Me.btnCashSubmit.Size = New System.Drawing.Size(125, 36)
        Me.btnCashSubmit.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnCashSubmit.TabIndex = 93
        Me.btnCashSubmit.Text = "SUBMIT"
        Me.btnCashSubmit.TextColor = System.Drawing.Color.White
        '
        'lblCashNumberItems
        '
        Me.lblCashNumberItems.AutoSize = True
        Me.lblCashNumberItems.Font = New System.Drawing.Font("Segoe UI Emoji", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashNumberItems.Location = New System.Drawing.Point(149, 115)
        Me.lblCashNumberItems.Name = "lblCashNumberItems"
        Me.lblCashNumberItems.Size = New System.Drawing.Size(28, 20)
        Me.lblCashNumberItems.TabIndex = 9
        Me.lblCashNumberItems.Text = "0.0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(34, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 17)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Number of Items"
        '
        'lblCashChange
        '
        Me.lblCashChange.AutoSize = True
        Me.lblCashChange.Font = New System.Drawing.Font("Segoe UI Emoji", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashChange.Location = New System.Drawing.Point(149, 201)
        Me.lblCashChange.Name = "lblCashChange"
        Me.lblCashChange.Size = New System.Drawing.Size(28, 20)
        Me.lblCashChange.TabIndex = 7
        Me.lblCashChange.Text = "0.0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(89, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 17)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Change"
        '
        'lblCashAmtDue
        '
        Me.lblCashAmtDue.AutoSize = True
        Me.lblCashAmtDue.Font = New System.Drawing.Font("Segoe UI Emoji", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashAmtDue.Location = New System.Drawing.Point(149, 158)
        Me.lblCashAmtDue.Name = "lblCashAmtDue"
        Me.lblCashAmtDue.Size = New System.Drawing.Size(28, 20)
        Me.lblCashAmtDue.TabIndex = 5
        Me.lblCashAmtDue.Text = "0.0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(61, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Amount Due"
        '
        'txtCashPayment
        '
        Me.txtCashPayment.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashPayment.Location = New System.Drawing.Point(148, 69)
        Me.txtCashPayment.Name = "txtCashPayment"
        Me.txtCashPayment.Size = New System.Drawing.Size(130, 25)
        Me.txtCashPayment.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Payment Amount"
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(-2, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(311, 43)
        Me.Panel4.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(18, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cash Payment"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.UseCompatibleTextRendering = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Location = New System.Drawing.Point(-3, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(755, 40)
        Me.Panel3.TabIndex = 89
        '
        'btnCash
        '
        Me.btnCash.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCash.BackColor = System.Drawing.Color.Transparent
        Me.btnCash.BackgroundImage = CType(resources.GetObject("btnCash.BackgroundImage"), System.Drawing.Image)
        Me.btnCash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCash.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnCash.Font = New System.Drawing.Font("Futura LT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCash.Location = New System.Drawing.Point(12, 703)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.PulseSpeed = 100
        Me.btnCash.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10)
        Me.btnCash.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltF1)
        Me.btnCash.Size = New System.Drawing.Size(125, 36)
        Me.btnCash.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnCash.TabIndex = 90
        Me.btnCash.Text = "CASH"
        Me.btnCash.TextColor = System.Drawing.Color.White
        '
        'btnClear
        '
        Me.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.BackgroundImage = CType(resources.GetObject("btnClear.BackgroundImage"), System.Drawing.Image)
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnClear.Font = New System.Drawing.Font("Futura LT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(172, 703)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.PulseSpeed = 100
        Me.btnClear.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10)
        Me.btnClear.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F1)
        Me.btnClear.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC)
        Me.btnClear.Size = New System.Drawing.Size(137, 36)
        Me.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnClear.TabIndex = 93
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.TextColor = System.Drawing.Color.White
        '
        'GalleryContainer1
        '
        '
        '
        '
        Me.GalleryContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GalleryContainer1.EnableGalleryPopup = False
        Me.GalleryContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.GalleryContainer1.MinimumSize = New System.Drawing.Size(150, 200)
        Me.GalleryContainer1.MultiLine = False
        Me.GalleryContainer1.Name = "GalleryContainer1"
        Me.GalleryContainer1.PopupUsesStandardScrollbars = False
        '
        '
        '
        Me.GalleryContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'SlidePanel1
        '
        Me.SlidePanel1.BackColor = System.Drawing.Color.DimGray
        Me.SlidePanel1.BackgroundImage = CType(resources.GetObject("SlidePanel1.BackgroundImage"), System.Drawing.Image)
        Me.SlidePanel1.Controls.Add(Me.PanelEx2)
        Me.SlidePanel1.Location = New System.Drawing.Point(134, 179)
        Me.SlidePanel1.Name = "SlidePanel1"
        Me.SlidePanel1.Size = New System.Drawing.Size(316, 322)
        Me.SlidePanel1.SlideOutButtonVisible = False
        Me.SlidePanel1.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Bottom
        Me.SlidePanel1.TabIndex = 95
        Me.SlidePanel1.Text = "SlidePanel1"
        Me.SlidePanel1.UsesBlockingAnimation = False
        Me.SlidePanel1.Visible = False
        '
        'PanelEx2
        '
        Me.PanelEx2.AntiAlias = False
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.Label6)
        Me.PanelEx2.Controls.Add(Me.TextBox2)
        Me.PanelEx2.Controls.Add(Me.cmbProductCode)
        Me.PanelEx2.Controls.Add(Me.ButtonX1)
        Me.PanelEx2.Controls.Add(Me.ButtonX2)
        Me.PanelEx2.Controls.Add(Me.Label7)
        Me.PanelEx2.Controls.Add(Me.TextBox1)
        Me.PanelEx2.Controls.Add(Me.Label14)
        Me.PanelEx2.Controls.Add(Me.Panel5)
        Me.PanelEx2.Location = New System.Drawing.Point(4, 5)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(307, 314)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Center
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.CornerDiameter = 1
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 17)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Number of Items"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(148, 149)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(142, 25)
        Me.TextBox2.TabIndex = 96
        '
        'cmbProductCode
        '
        Me.cmbProductCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbProductCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbProductCode.DisplayMember = "Text"
        Me.cmbProductCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbProductCode.FormattingEnabled = True
        Me.cmbProductCode.ItemHeight = 16
        Me.cmbProductCode.Location = New System.Drawing.Point(147, 72)
        Me.cmbProductCode.Name = "cmbProductCode"
        Me.cmbProductCode.Size = New System.Drawing.Size(142, 22)
        Me.cmbProductCode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbProductCode.TabIndex = 95
        Me.cmbProductCode.Visible = False
        Me.cmbProductCode.WatermarkText = "Search here..."
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.BackColor = System.Drawing.Color.Transparent
        Me.ButtonX1.BackgroundImage = CType(resources.GetObject("ButtonX1.BackgroundImage"), System.Drawing.Image)
        Me.ButtonX1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.ButtonX1.Font = New System.Drawing.Font("Futura LT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(152, 247)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.PulseSpeed = 100
        Me.ButtonX1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10)
        Me.ButtonX1.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltF2)
        Me.ButtonX1.Size = New System.Drawing.Size(137, 36)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.ButtonX1.TabIndex = 94
        Me.ButtonX1.Text = "CANCEL"
        Me.ButtonX1.TextColor = System.Drawing.Color.White
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.BackColor = System.Drawing.Color.Transparent
        Me.ButtonX2.BackgroundImage = CType(resources.GetObject("ButtonX2.BackgroundImage"), System.Drawing.Image)
        Me.ButtonX2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.ButtonX2.Enabled = False
        Me.ButtonX2.Font = New System.Drawing.Font("Futura LT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.Location = New System.Drawing.Point(17, 247)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.PulseSpeed = 100
        Me.ButtonX2.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10)
        Me.ButtonX2.Size = New System.Drawing.Size(125, 36)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.ButtonX2.TabIndex = 93
        Me.ButtonX2.Text = "SUBMIT"
        Me.ButtonX2.TextColor = System.Drawing.Color.White
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Product Name"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(147, 110)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(142, 25)
        Me.TextBox1.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(35, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 17)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Product Code"
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), System.Drawing.Image)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Location = New System.Drawing.Point(-2, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(311, 43)
        Me.Panel5.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Emoji", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Image = CType(resources.GetObject("Label15.Image"), System.Drawing.Image)
        Me.Label15.Location = New System.Drawing.Point(18, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(179, 31)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Multiple Quantities"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label15.UseCompatibleTextRendering = True
        '
        'Transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(752, 741)
        Me.Controls.Add(Me.SlidePanel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.SlidePanel3)
        Me.Controls.Add(Me.dgvProducts)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgvSummary)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCash)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Transactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MetroForm"
        CType(Me.dgvSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SlidePanel3.ResumeLayout(False)
        Me.panelPayment.ResumeLayout(False)
        Me.panelPayment.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.SlidePanel1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents SuperTabItem2 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents dgvSummary As System.Windows.Forms.DataGridView
    Friend WithEvents lblAmtFig As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblItemFig As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotalItems As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgvProducts As System.Windows.Forms.DataGridView
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents SlidePanel3 As DevComponents.DotNetBar.Controls.SlidePanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents panelPayment As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCash As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtCashPayment As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ProductCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblCashNumberItems As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblCashChange As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblCashAmtDue As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCancelCash As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCashSubmit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GalleryContainer1 As DevComponents.DotNetBar.GalleryContainer
    Friend WithEvents SlidePanel1 As DevComponents.DotNetBar.Controls.SlidePanel
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents cmbProductCode As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Private WithEvents Label15 As System.Windows.Forms.Label
End Class
