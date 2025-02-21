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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionallySelectMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tscbIolMasters = New System.Windows.Forms.ToolStripComboBox()
        Me.tscbIolMasterPorts = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveHtmlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PdfWithBackgroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PdfNoBackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tstbVer = New System.Windows.Forms.ToolStripTextBox()
        Me.LicenseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.mainTabDoc = New System.Windows.Forms.TabPage()
        Me.mainTabBrxExport = New System.Windows.Forms.TabPage()
        Me.tabCtrlBrxExport = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.gbSettings = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.gbInSourceData = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudSourceStartElement = New System.Windows.Forms.NumericUpDown()
        Me.lbSourcePortByteOffset = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudSourcePortByteOffset = New System.Windows.Forms.NumericUpDown()
        Me.tbInSourceBlock = New System.Windows.Forms.TextBox()
        Me.gbProcessDataOptions = New System.Windows.Forms.GroupBox()
        Me.cbSelectedOption = New System.Windows.Forms.ComboBox()
        Me.gbDeviceName = New System.Windows.Forms.GroupBox()
        Me.tbUdtHeapItem = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbPreDefinedDefaults = New System.Windows.Forms.GroupBox()
        Me.gbInUdtName = New System.Windows.Forms.GroupBox()
        Me.tbInUdtName = New System.Windows.Forms.TextBox()
        Me.gbOutUdtName = New System.Windows.Forms.GroupBox()
        Me.tbOutUdtName = New System.Windows.Forms.TextBox()
        Me.gbGlobalUdtName = New System.Windows.Forms.GroupBox()
        Me.tbMainUdtName = New System.Windows.Forms.TextBox()
        Me.gbSubRoutineName = New System.Windows.Forms.GroupBox()
        Me.tbSubRoutineName = New System.Windows.Forms.TextBox()
        Me.cbEditDefaults = New System.Windows.Forms.CheckBox()
        Me.gbMode = New System.Windows.Forms.GroupBox()
        Me.cbGenerateSR = New System.Windows.Forms.CheckBox()
        Me.cbGenerateSRCall = New System.Windows.Forms.CheckBox()
        Me.gbOutTargetData = New System.Windows.Forms.GroupBox()
        Me.nudTargetStartElement = New System.Windows.Forms.NumericUpDown()
        Me.lbTargetPortByteOffset = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudTargetPortByteOffset = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbOutTargetBlock = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvOutUdt = New System.Windows.Forms.DataGridView()
        Me.gbInUdt = New System.Windows.Forms.GroupBox()
        Me.dgvInUdt = New System.Windows.Forms.DataGridView()
        Me.gbOutPD = New System.Windows.Forms.GroupBox()
        Me.dgvOut = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbInPD = New System.Windows.Forms.GroupBox()
        Me.dgvIn = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.WebView22 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.msBrxExport = New System.Windows.Forms.MenuStrip()
        Me.ExportBRXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.mainTabDoc.SuspendLayout()
        Me.mainTabBrxExport.SuspendLayout()
        Me.tabCtrlBrxExport.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbSettings.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.gbInSourceData.SuspendLayout()
        CType(Me.nudSourceStartElement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSourcePortByteOffset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbProcessDataOptions.SuspendLayout()
        Me.gbDeviceName.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gbPreDefinedDefaults.SuspendLayout()
        Me.gbInUdtName.SuspendLayout()
        Me.gbOutUdtName.SuspendLayout()
        Me.gbGlobalUdtName.SuspendLayout()
        Me.gbSubRoutineName.SuspendLayout()
        Me.gbMode.SuspendLayout()
        Me.gbOutTargetData.SuspendLayout()
        CType(Me.nudTargetStartElement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTargetPortByteOffset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvOutUdt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInUdt.SuspendLayout()
        CType(Me.dgvInUdt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOutPD.SuspendLayout()
        CType(Me.dgvOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInPD.SuspendLayout()
        CType(Me.dgvIn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.WebView22, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.msBrxExport.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadToolStripMenuItem, Me.OptionallySelectMasterToolStripMenuItem, Me.tscbIolMasters, Me.tscbIolMasterPorts, Me.ToolStripMenuItem1, Me.SaveToolStripMenuItem, Me.tstbVer, Me.LicenseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(792, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(94, 23)
        Me.LoadToolStripMenuItem.Text = "load IODD File"
        '
        'OptionallySelectMasterToolStripMenuItem
        '
        Me.OptionallySelectMasterToolStripMenuItem.Enabled = False
        Me.OptionallySelectMasterToolStripMenuItem.Name = "OptionallySelectMasterToolStripMenuItem"
        Me.OptionallySelectMasterToolStripMenuItem.Size = New System.Drawing.Size(189, 23)
        Me.OptionallySelectMasterToolStripMenuItem.Text = "Optionally select Master/Port-> "
        '
        'tscbIolMasters
        '
        Me.tscbIolMasters.AutoSize = False
        Me.tscbIolMasters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscbIolMasters.Name = "tscbIolMasters"
        Me.tscbIolMasters.Size = New System.Drawing.Size(200, 23)
        '
        'tscbIolMasterPorts
        '
        Me.tscbIolMasterPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscbIolMasterPorts.Name = "tscbIolMasterPorts"
        Me.tscbIolMasterPorts.Size = New System.Drawing.Size(120, 23)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 23)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveHtmlToolStripMenuItem, Me.PdfWithBackgroundToolStripMenuItem, Me.PdfNoBackgroundColorToolStripMenuItem})
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(66, 23)
        Me.SaveToolStripMenuItem.Text = "save Doc"
        '
        'SaveHtmlToolStripMenuItem
        '
        Me.SaveHtmlToolStripMenuItem.Name = "SaveHtmlToolStripMenuItem"
        Me.SaveHtmlToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.SaveHtmlToolStripMenuItem.Text = "save html"
        '
        'PdfWithBackgroundToolStripMenuItem
        '
        Me.PdfWithBackgroundToolStripMenuItem.Name = "PdfWithBackgroundToolStripMenuItem"
        Me.PdfWithBackgroundToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.PdfWithBackgroundToolStripMenuItem.Text = "pdf with background"
        '
        'PdfNoBackgroundColorToolStripMenuItem
        '
        Me.PdfNoBackgroundColorToolStripMenuItem.Name = "PdfNoBackgroundColorToolStripMenuItem"
        Me.PdfNoBackgroundColorToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.PdfNoBackgroundColorToolStripMenuItem.Text = "pdf no background color"
        '
        'tstbVer
        '
        Me.tstbVer.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tstbVer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tstbVer.Enabled = False
        Me.tstbVer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tstbVer.Name = "tstbVer"
        Me.tstbVer.ReadOnly = True
        Me.tstbVer.Size = New System.Drawing.Size(64, 23)
        Me.tstbVer.Text = "1.1.5b"
        Me.tstbVer.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LicenseToolStripMenuItem
        '
        Me.LicenseToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.LicenseToolStripMenuItem.Name = "LicenseToolStripMenuItem"
        Me.LicenseToolStripMenuItem.Size = New System.Drawing.Size(58, 23)
        Me.LicenseToolStripMenuItem.Text = "License"
        '
        'WebView21
        '
        Me.WebView21.AllowExternalDrop = True
        Me.WebView21.CreationProperties = Nothing
        Me.WebView21.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebView21.Location = New System.Drawing.Point(2, 2)
        Me.WebView21.Margin = New System.Windows.Forms.Padding(1)
        Me.WebView21.Name = "WebView21"
        Me.WebView21.Size = New System.Drawing.Size(662, 645)
        Me.WebView21.TabIndex = 3
        Me.WebView21.ZoomFactor = 1.0R
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.mainTabDoc)
        Me.TabControl1.Controls.Add(Me.mainTabBrxExport)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(792, 677)
        Me.TabControl1.TabIndex = 4
        '
        'mainTabDoc
        '
        Me.mainTabDoc.Controls.Add(Me.WebView21)
        Me.mainTabDoc.Location = New System.Drawing.Point(4, 24)
        Me.mainTabDoc.Margin = New System.Windows.Forms.Padding(2)
        Me.mainTabDoc.Name = "mainTabDoc"
        Me.mainTabDoc.Padding = New System.Windows.Forms.Padding(2)
        Me.mainTabDoc.Size = New System.Drawing.Size(666, 649)
        Me.mainTabDoc.TabIndex = 0
        Me.mainTabDoc.Text = "Documentation"
        Me.mainTabDoc.UseVisualStyleBackColor = True
        '
        'mainTabBrxExport
        '
        Me.mainTabBrxExport.Controls.Add(Me.tabCtrlBrxExport)
        Me.mainTabBrxExport.Controls.Add(Me.msBrxExport)
        Me.mainTabBrxExport.Location = New System.Drawing.Point(4, 24)
        Me.mainTabBrxExport.Margin = New System.Windows.Forms.Padding(2)
        Me.mainTabBrxExport.Name = "mainTabBrxExport"
        Me.mainTabBrxExport.Padding = New System.Windows.Forms.Padding(2)
        Me.mainTabBrxExport.Size = New System.Drawing.Size(784, 649)
        Me.mainTabBrxExport.TabIndex = 1
        Me.mainTabBrxExport.Text = "BRX Export "
        Me.mainTabBrxExport.UseVisualStyleBackColor = True
        '
        'tabCtrlBrxExport
        '
        Me.tabCtrlBrxExport.Controls.Add(Me.TabPage1)
        Me.tabCtrlBrxExport.Controls.Add(Me.TabPage2)
        Me.tabCtrlBrxExport.Controls.Add(Me.TabPage3)
        Me.tabCtrlBrxExport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCtrlBrxExport.Enabled = False
        Me.tabCtrlBrxExport.Location = New System.Drawing.Point(2, 26)
        Me.tabCtrlBrxExport.Margin = New System.Windows.Forms.Padding(2)
        Me.tabCtrlBrxExport.Name = "tabCtrlBrxExport"
        Me.tabCtrlBrxExport.SelectedIndex = 0
        Me.tabCtrlBrxExport.Size = New System.Drawing.Size(780, 621)
        Me.tabCtrlBrxExport.TabIndex = 13
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gbSettings)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(772, 593)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Common Settings"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'gbSettings
        '
        Me.gbSettings.Controls.Add(Me.TableLayoutPanel2)
        Me.gbSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSettings.Location = New System.Drawing.Point(2, 2)
        Me.gbSettings.Margin = New System.Windows.Forms.Padding(2)
        Me.gbSettings.Name = "gbSettings"
        Me.gbSettings.Padding = New System.Windows.Forms.Padding(2)
        Me.gbSettings.Size = New System.Drawing.Size(768, 589)
        Me.gbSettings.TabIndex = 9
        Me.gbSettings.TabStop = False
        Me.gbSettings.Text = "Settings (Edit to match the Input and Output data blocks used in the EIP scanner)" &
    ""
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.gbInSourceData, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.gbProcessDataOptions, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.gbDeviceName, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.gbMode, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.gbOutTargetData, 0, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(2, 15)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 149.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(764, 570)
        Me.TableLayoutPanel2.TabIndex = 10
        '
        'gbInSourceData
        '
        Me.gbInSourceData.AutoSize = True
        Me.gbInSourceData.Controls.Add(Me.Label5)
        Me.gbInSourceData.Controls.Add(Me.nudSourceStartElement)
        Me.gbInSourceData.Controls.Add(Me.lbSourcePortByteOffset)
        Me.gbInSourceData.Controls.Add(Me.Label1)
        Me.gbInSourceData.Controls.Add(Me.Label2)
        Me.gbInSourceData.Controls.Add(Me.nudSourcePortByteOffset)
        Me.gbInSourceData.Controls.Add(Me.tbInSourceBlock)
        Me.gbInSourceData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbInSourceData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInSourceData.Location = New System.Drawing.Point(2, 137)
        Me.gbInSourceData.Margin = New System.Windows.Forms.Padding(2)
        Me.gbInSourceData.Name = "gbInSourceData"
        Me.gbInSourceData.Padding = New System.Windows.Forms.Padding(2)
        Me.gbInSourceData.Size = New System.Drawing.Size(760, 76)
        Me.gbInSourceData.TabIndex = 0
        Me.gbInSourceData.TabStop = False
        Me.gbInSourceData.Text = "Input data source data block (has to be byte array)"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(176, 47)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(423, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "<- Edit to match scanner input block start index (if it does not start at 0)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudSourceStartElement
        '
        Me.nudSourceStartElement.Location = New System.Drawing.Point(102, 49)
        Me.nudSourceStartElement.Margin = New System.Windows.Forms.Padding(2)
        Me.nudSourceStartElement.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudSourceStartElement.Name = "nudSourceStartElement"
        Me.nudSourceStartElement.Size = New System.Drawing.Size(70, 20)
        Me.nudSourceStartElement.TabIndex = 7
        '
        'lbSourcePortByteOffset
        '
        Me.lbSourcePortByteOffset.AutoSize = True
        Me.lbSourcePortByteOffset.Location = New System.Drawing.Point(599, 26)
        Me.lbSourcePortByteOffset.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbSourcePortByteOffset.Name = "lbSourcePortByteOffset"
        Me.lbSourcePortByteOffset.Size = New System.Drawing.Size(81, 13)
        Me.lbSourcePortByteOffset.TabIndex = 6
        Me.lbSourcePortByteOffset.Text = "Port Byte Offset"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(176, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "<- Edit to match scanner input block name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Block Start Index "
        '
        'nudSourcePortByteOffset
        '
        Me.nudSourcePortByteOffset.Location = New System.Drawing.Point(684, 22)
        Me.nudSourcePortByteOffset.Margin = New System.Windows.Forms.Padding(2)
        Me.nudSourcePortByteOffset.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudSourcePortByteOffset.Name = "nudSourcePortByteOffset"
        Me.nudSourcePortByteOffset.Size = New System.Drawing.Size(70, 20)
        Me.nudSourcePortByteOffset.TabIndex = 1
        '
        'tbInSourceBlock
        '
        Me.tbInSourceBlock.Location = New System.Drawing.Point(7, 22)
        Me.tbInSourceBlock.Margin = New System.Windows.Forms.Padding(2)
        Me.tbInSourceBlock.Name = "tbInSourceBlock"
        Me.tbInSourceBlock.Size = New System.Drawing.Size(165, 20)
        Me.tbInSourceBlock.TabIndex = 0
        Me.tbInSourceBlock.Text = "InData"
        '
        'gbProcessDataOptions
        '
        Me.gbProcessDataOptions.AutoSize = True
        Me.gbProcessDataOptions.CausesValidation = False
        Me.gbProcessDataOptions.Controls.Add(Me.cbSelectedOption)
        Me.gbProcessDataOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbProcessDataOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbProcessDataOptions.Location = New System.Drawing.Point(2, 2)
        Me.gbProcessDataOptions.Margin = New System.Windows.Forms.Padding(2)
        Me.gbProcessDataOptions.Name = "gbProcessDataOptions"
        Me.gbProcessDataOptions.Padding = New System.Windows.Forms.Padding(2)
        Me.gbProcessDataOptions.Size = New System.Drawing.Size(760, 51)
        Me.gbProcessDataOptions.TabIndex = 7
        Me.gbProcessDataOptions.TabStop = False
        Me.gbProcessDataOptions.Text = "Process Data Options (if any)"
        '
        'cbSelectedOption
        '
        Me.cbSelectedOption.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbSelectedOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSelectedOption.FormattingEnabled = True
        Me.cbSelectedOption.Location = New System.Drawing.Point(2, 15)
        Me.cbSelectedOption.Margin = New System.Windows.Forms.Padding(2)
        Me.cbSelectedOption.Name = "cbSelectedOption"
        Me.cbSelectedOption.Size = New System.Drawing.Size(756, 21)
        Me.cbSelectedOption.TabIndex = 0
        '
        'gbDeviceName
        '
        Me.gbDeviceName.AutoSize = True
        Me.gbDeviceName.Controls.Add(Me.tbUdtHeapItem)
        Me.gbDeviceName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbDeviceName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDeviceName.Location = New System.Drawing.Point(2, 297)
        Me.gbDeviceName.Margin = New System.Windows.Forms.Padding(2)
        Me.gbDeviceName.Name = "gbDeviceName"
        Me.gbDeviceName.Padding = New System.Windows.Forms.Padding(2)
        Me.gbDeviceName.Size = New System.Drawing.Size(760, 51)
        Me.gbDeviceName.TabIndex = 2
        Me.gbDeviceName.TabStop = False
        Me.gbDeviceName.Text = "Device Name (for UDT Heap Item)"
        '
        'tbUdtHeapItem
        '
        Me.tbUdtHeapItem.Location = New System.Drawing.Point(7, 17)
        Me.tbUdtHeapItem.Margin = New System.Windows.Forms.Padding(2)
        Me.tbUdtHeapItem.Name = "tbUdtHeapItem"
        Me.tbUdtHeapItem.Size = New System.Drawing.Size(370, 20)
        Me.tbUdtHeapItem.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.gbPreDefinedDefaults)
        Me.Panel1.Controls.Add(Me.cbEditDefaults)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 353)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(758, 214)
        Me.Panel1.TabIndex = 10
        '
        'gbPreDefinedDefaults
        '
        Me.gbPreDefinedDefaults.Controls.Add(Me.gbInUdtName)
        Me.gbPreDefinedDefaults.Controls.Add(Me.gbOutUdtName)
        Me.gbPreDefinedDefaults.Controls.Add(Me.gbGlobalUdtName)
        Me.gbPreDefinedDefaults.Controls.Add(Me.gbSubRoutineName)
        Me.gbPreDefinedDefaults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbPreDefinedDefaults.Enabled = False
        Me.gbPreDefinedDefaults.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPreDefinedDefaults.Location = New System.Drawing.Point(0, 17)
        Me.gbPreDefinedDefaults.Name = "gbPreDefinedDefaults"
        Me.gbPreDefinedDefaults.Padding = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.gbPreDefinedDefaults.Size = New System.Drawing.Size(758, 197)
        Me.gbPreDefinedDefaults.TabIndex = 9
        Me.gbPreDefinedDefaults.TabStop = False
        Me.gbPreDefinedDefaults.Text = "Predefined defaults"
        '
        'gbInUdtName
        '
        Me.gbInUdtName.Controls.Add(Me.tbInUdtName)
        Me.gbInUdtName.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbInUdtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInUdtName.Location = New System.Drawing.Point(10, 146)
        Me.gbInUdtName.Margin = New System.Windows.Forms.Padding(2)
        Me.gbInUdtName.MinimumSize = New System.Drawing.Size(0, 25)
        Me.gbInUdtName.Name = "gbInUdtName"
        Me.gbInUdtName.Padding = New System.Windows.Forms.Padding(2)
        Me.gbInUdtName.Size = New System.Drawing.Size(745, 45)
        Me.gbInUdtName.TabIndex = 2
        Me.gbInUdtName.TabStop = False
        Me.gbInUdtName.Text = "Input UDT Name"
        '
        'tbInUdtName
        '
        Me.tbInUdtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbInUdtName.Location = New System.Drawing.Point(2, 15)
        Me.tbInUdtName.Margin = New System.Windows.Forms.Padding(2)
        Me.tbInUdtName.Name = "tbInUdtName"
        Me.tbInUdtName.Size = New System.Drawing.Size(741, 20)
        Me.tbInUdtName.TabIndex = 1
        '
        'gbOutUdtName
        '
        Me.gbOutUdtName.Controls.Add(Me.tbOutUdtName)
        Me.gbOutUdtName.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbOutUdtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOutUdtName.Location = New System.Drawing.Point(10, 103)
        Me.gbOutUdtName.Margin = New System.Windows.Forms.Padding(2)
        Me.gbOutUdtName.MinimumSize = New System.Drawing.Size(0, 25)
        Me.gbOutUdtName.Name = "gbOutUdtName"
        Me.gbOutUdtName.Padding = New System.Windows.Forms.Padding(2)
        Me.gbOutUdtName.Size = New System.Drawing.Size(745, 43)
        Me.gbOutUdtName.TabIndex = 2
        Me.gbOutUdtName.TabStop = False
        Me.gbOutUdtName.Text = "Output UDT Name"
        '
        'tbOutUdtName
        '
        Me.tbOutUdtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbOutUdtName.Location = New System.Drawing.Point(2, 15)
        Me.tbOutUdtName.Margin = New System.Windows.Forms.Padding(2)
        Me.tbOutUdtName.Name = "tbOutUdtName"
        Me.tbOutUdtName.Size = New System.Drawing.Size(741, 20)
        Me.tbOutUdtName.TabIndex = 1
        '
        'gbGlobalUdtName
        '
        Me.gbGlobalUdtName.Controls.Add(Me.tbMainUdtName)
        Me.gbGlobalUdtName.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbGlobalUdtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGlobalUdtName.Location = New System.Drawing.Point(10, 59)
        Me.gbGlobalUdtName.Margin = New System.Windows.Forms.Padding(2)
        Me.gbGlobalUdtName.Name = "gbGlobalUdtName"
        Me.gbGlobalUdtName.Padding = New System.Windows.Forms.Padding(2)
        Me.gbGlobalUdtName.Size = New System.Drawing.Size(745, 44)
        Me.gbGlobalUdtName.TabIndex = 4
        Me.gbGlobalUdtName.TabStop = False
        Me.gbGlobalUdtName.Text = "Device Udt Name"
        '
        'tbMainUdtName
        '
        Me.tbMainUdtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbMainUdtName.Location = New System.Drawing.Point(2, 15)
        Me.tbMainUdtName.Margin = New System.Windows.Forms.Padding(2)
        Me.tbMainUdtName.Name = "tbMainUdtName"
        Me.tbMainUdtName.Size = New System.Drawing.Size(741, 20)
        Me.tbMainUdtName.TabIndex = 0
        '
        'gbSubRoutineName
        '
        Me.gbSubRoutineName.Controls.Add(Me.tbSubRoutineName)
        Me.gbSubRoutineName.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbSubRoutineName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSubRoutineName.Location = New System.Drawing.Point(10, 16)
        Me.gbSubRoutineName.Margin = New System.Windows.Forms.Padding(2)
        Me.gbSubRoutineName.Name = "gbSubRoutineName"
        Me.gbSubRoutineName.Padding = New System.Windows.Forms.Padding(2)
        Me.gbSubRoutineName.Size = New System.Drawing.Size(745, 43)
        Me.gbSubRoutineName.TabIndex = 3
        Me.gbSubRoutineName.TabStop = False
        Me.gbSubRoutineName.Text = "SubRoutine Name"
        '
        'tbSubRoutineName
        '
        Me.tbSubRoutineName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbSubRoutineName.Location = New System.Drawing.Point(2, 15)
        Me.tbSubRoutineName.Margin = New System.Windows.Forms.Padding(2)
        Me.tbSubRoutineName.Name = "tbSubRoutineName"
        Me.tbSubRoutineName.Size = New System.Drawing.Size(741, 20)
        Me.tbSubRoutineName.TabIndex = 0
        '
        'cbEditDefaults
        '
        Me.cbEditDefaults.AutoSize = True
        Me.cbEditDefaults.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbEditDefaults.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEditDefaults.Location = New System.Drawing.Point(0, 0)
        Me.cbEditDefaults.Name = "cbEditDefaults"
        Me.cbEditDefaults.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.cbEditDefaults.Size = New System.Drawing.Size(758, 17)
        Me.cbEditDefaults.TabIndex = 10
        Me.cbEditDefaults.Text = "Edit predefined defaults"
        Me.cbEditDefaults.UseVisualStyleBackColor = True
        '
        'gbMode
        '
        Me.gbMode.AutoSize = True
        Me.gbMode.Controls.Add(Me.cbGenerateSR)
        Me.gbMode.Controls.Add(Me.cbGenerateSRCall)
        Me.gbMode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMode.Location = New System.Drawing.Point(2, 57)
        Me.gbMode.Margin = New System.Windows.Forms.Padding(2)
        Me.gbMode.Name = "gbMode"
        Me.gbMode.Padding = New System.Windows.Forms.Padding(2)
        Me.gbMode.Size = New System.Drawing.Size(760, 76)
        Me.gbMode.TabIndex = 8
        Me.gbMode.TabStop = False
        Me.gbMode.Text = "Mode"
        '
        'cbGenerateSR
        '
        Me.cbGenerateSR.AutoSize = True
        Me.cbGenerateSR.Checked = True
        Me.cbGenerateSR.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbGenerateSR.Location = New System.Drawing.Point(12, 22)
        Me.cbGenerateSR.Margin = New System.Windows.Forms.Padding(2)
        Me.cbGenerateSR.Name = "cbGenerateSR"
        Me.cbGenerateSR.Size = New System.Drawing.Size(251, 17)
        Me.cbGenerateSR.TabIndex = 3
        Me.cbGenerateSR.Text = "Generate SubRoutine and corresponding UDTs"
        Me.cbGenerateSR.UseVisualStyleBackColor = True
        '
        'cbGenerateSRCall
        '
        Me.cbGenerateSRCall.AutoSize = True
        Me.cbGenerateSRCall.Checked = True
        Me.cbGenerateSRCall.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbGenerateSRCall.Location = New System.Drawing.Point(12, 47)
        Me.cbGenerateSRCall.Margin = New System.Windows.Forms.Padding(2)
        Me.cbGenerateSRCall.Name = "cbGenerateSRCall"
        Me.cbGenerateSRCall.Size = New System.Drawing.Size(373, 17)
        Me.cbGenerateSRCall.TabIndex = 2
        Me.cbGenerateSRCall.Text = "Generate Call to SubRoutine with selected In/Out data blocks and offsets"
        Me.cbGenerateSRCall.UseVisualStyleBackColor = True
        '
        'gbOutTargetData
        '
        Me.gbOutTargetData.AutoSize = True
        Me.gbOutTargetData.Controls.Add(Me.Label6)
        Me.gbOutTargetData.Controls.Add(Me.nudTargetStartElement)
        Me.gbOutTargetData.Controls.Add(Me.lbTargetPortByteOffset)
        Me.gbOutTargetData.Controls.Add(Me.Label4)
        Me.gbOutTargetData.Controls.Add(Me.nudTargetPortByteOffset)
        Me.gbOutTargetData.Controls.Add(Me.Label3)
        Me.gbOutTargetData.Controls.Add(Me.tbOutTargetBlock)
        Me.gbOutTargetData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbOutTargetData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOutTargetData.Location = New System.Drawing.Point(2, 217)
        Me.gbOutTargetData.Margin = New System.Windows.Forms.Padding(2)
        Me.gbOutTargetData.Name = "gbOutTargetData"
        Me.gbOutTargetData.Padding = New System.Windows.Forms.Padding(2)
        Me.gbOutTargetData.Size = New System.Drawing.Size(760, 76)
        Me.gbOutTargetData.TabIndex = 1
        Me.gbOutTargetData.TabStop = False
        Me.gbOutTargetData.Text = "Output data target data block (has to be byte array)"
        '
        'nudTargetStartElement
        '
        Me.nudTargetStartElement.Location = New System.Drawing.Point(102, 51)
        Me.nudTargetStartElement.Margin = New System.Windows.Forms.Padding(2)
        Me.nudTargetStartElement.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudTargetStartElement.Name = "nudTargetStartElement"
        Me.nudTargetStartElement.Size = New System.Drawing.Size(70, 20)
        Me.nudTargetStartElement.TabIndex = 9
        '
        'lbTargetPortByteOffset
        '
        Me.lbTargetPortByteOffset.AutoSize = True
        Me.lbTargetPortByteOffset.Location = New System.Drawing.Point(599, 25)
        Me.lbTargetPortByteOffset.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTargetPortByteOffset.Name = "lbTargetPortByteOffset"
        Me.lbTargetPortByteOffset.Size = New System.Drawing.Size(81, 13)
        Me.lbTargetPortByteOffset.TabIndex = 8
        Me.lbTargetPortByteOffset.Text = "Port Byte Offset"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(176, 20)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(257, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "<- Edit to match scanner output block name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudTargetPortByteOffset
        '
        Me.nudTargetPortByteOffset.Location = New System.Drawing.Point(684, 23)
        Me.nudTargetPortByteOffset.Margin = New System.Windows.Forms.Padding(2)
        Me.nudTargetPortByteOffset.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudTargetPortByteOffset.Name = "nudTargetPortByteOffset"
        Me.nudTargetPortByteOffset.Size = New System.Drawing.Size(70, 20)
        Me.nudTargetPortByteOffset.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 53)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Block Start Index "
        '
        'tbOutTargetBlock
        '
        Me.tbOutTargetBlock.Location = New System.Drawing.Point(7, 23)
        Me.tbOutTargetBlock.Margin = New System.Windows.Forms.Padding(2)
        Me.tbOutTargetBlock.Name = "tbOutTargetBlock"
        Me.tbOutTargetBlock.Size = New System.Drawing.Size(165, 20)
        Me.tbOutTargetBlock.TabIndex = 0
        Me.tbOutTargetBlock.Text = "OutData"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(654, 593)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Diag"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.gbInUdt, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.gbOutPD, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.gbInPD, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(650, 589)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvOutUdt)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(327, 296)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(321, 291)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Output UDT"
        '
        'dgvOutUdt
        '
        Me.dgvOutUdt.AllowUserToAddRows = False
        Me.dgvOutUdt.AllowUserToDeleteRows = False
        Me.dgvOutUdt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvOutUdt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOutUdt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOutUdt.Location = New System.Drawing.Point(2, 15)
        Me.dgvOutUdt.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvOutUdt.Name = "dgvOutUdt"
        Me.dgvOutUdt.ReadOnly = True
        Me.dgvOutUdt.RowHeadersWidth = 5
        Me.dgvOutUdt.Size = New System.Drawing.Size(317, 274)
        Me.dgvOutUdt.TabIndex = 0
        '
        'gbInUdt
        '
        Me.gbInUdt.Controls.Add(Me.dgvInUdt)
        Me.gbInUdt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbInUdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInUdt.Location = New System.Drawing.Point(2, 296)
        Me.gbInUdt.Margin = New System.Windows.Forms.Padding(2)
        Me.gbInUdt.Name = "gbInUdt"
        Me.gbInUdt.Padding = New System.Windows.Forms.Padding(2)
        Me.gbInUdt.Size = New System.Drawing.Size(321, 291)
        Me.gbInUdt.TabIndex = 6
        Me.gbInUdt.TabStop = False
        Me.gbInUdt.Text = "Input UDT"
        '
        'dgvInUdt
        '
        Me.dgvInUdt.AllowUserToAddRows = False
        Me.dgvInUdt.AllowUserToDeleteRows = False
        Me.dgvInUdt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvInUdt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInUdt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvInUdt.Location = New System.Drawing.Point(2, 15)
        Me.dgvInUdt.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvInUdt.Name = "dgvInUdt"
        Me.dgvInUdt.ReadOnly = True
        Me.dgvInUdt.RowHeadersWidth = 5
        Me.dgvInUdt.Size = New System.Drawing.Size(317, 274)
        Me.dgvInUdt.TabIndex = 0
        '
        'gbOutPD
        '
        Me.gbOutPD.Controls.Add(Me.dgvOut)
        Me.gbOutPD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbOutPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOutPD.Location = New System.Drawing.Point(327, 2)
        Me.gbOutPD.Margin = New System.Windows.Forms.Padding(2)
        Me.gbOutPD.Name = "gbOutPD"
        Me.gbOutPD.Padding = New System.Windows.Forms.Padding(2)
        Me.gbOutPD.Size = New System.Drawing.Size(321, 290)
        Me.gbOutPD.TabIndex = 3
        Me.gbOutPD.TabStop = False
        Me.gbOutPD.Text = "Process Data OUT"
        '
        'dgvOut
        '
        Me.dgvOut.AllowUserToAddRows = False
        Me.dgvOut.AllowUserToDeleteRows = False
        Me.dgvOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOut.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.dgvOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOut.Location = New System.Drawing.Point(2, 15)
        Me.dgvOut.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvOut.Name = "dgvOut"
        Me.dgvOut.ReadOnly = True
        Me.dgvOut.RowHeadersWidth = 5
        Me.dgvOut.Size = New System.Drawing.Size(317, 273)
        Me.dgvOut.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "UDT Field"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 56
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "BitOffset"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 72
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "BitLength"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 77
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "MinValue"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 76
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "MaxValue"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 79
        '
        'gbInPD
        '
        Me.gbInPD.Controls.Add(Me.dgvIn)
        Me.gbInPD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbInPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInPD.Location = New System.Drawing.Point(2, 2)
        Me.gbInPD.Margin = New System.Windows.Forms.Padding(2)
        Me.gbInPD.Name = "gbInPD"
        Me.gbInPD.Padding = New System.Windows.Forms.Padding(2)
        Me.gbInPD.Size = New System.Drawing.Size(321, 290)
        Me.gbInPD.TabIndex = 2
        Me.gbInPD.TabStop = False
        Me.gbInPD.Text = "Process Data IN"
        '
        'dgvIn
        '
        Me.dgvIn.AllowUserToAddRows = False
        Me.dgvIn.AllowUserToDeleteRows = False
        Me.dgvIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgvIn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvIn.Location = New System.Drawing.Point(2, 15)
        Me.dgvIn.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvIn.Name = "dgvIn"
        Me.dgvIn.ReadOnly = True
        Me.dgvIn.RowHeadersWidth = 5
        Me.dgvIn.Size = New System.Drawing.Size(317, 273)
        Me.dgvIn.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "UDT Field"
        Me.Column1.MinimumWidth = 10
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 80
        '
        'Column2
        '
        Me.Column2.HeaderText = "Type"
        Me.Column2.MinimumWidth = 10
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 56
        '
        'Column3
        '
        Me.Column3.HeaderText = "BitOffset"
        Me.Column3.MinimumWidth = 10
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 72
        '
        'Column4
        '
        Me.Column4.HeaderText = "BitLength"
        Me.Column4.MinimumWidth = 10
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 77
        '
        'Column5
        '
        Me.Column5.HeaderText = "MinValue"
        Me.Column5.MinimumWidth = 10
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 76
        '
        'Column6
        '
        Me.Column6.HeaderText = "MaxValue"
        Me.Column6.MinimumWidth = 10
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 79
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.WebView22)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(654, 593)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Help"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'WebView22
        '
        Me.WebView22.AllowExternalDrop = True
        Me.WebView22.CreationProperties = Nothing
        Me.WebView22.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebView22.Location = New System.Drawing.Point(0, 0)
        Me.WebView22.Margin = New System.Windows.Forms.Padding(2)
        Me.WebView22.Name = "WebView22"
        Me.WebView22.Size = New System.Drawing.Size(654, 593)
        Me.WebView22.TabIndex = 11
        Me.WebView22.ZoomFactor = 1.0R
        '
        'msBrxExport
        '
        Me.msBrxExport.Enabled = False
        Me.msBrxExport.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.msBrxExport.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportBRXToolStripMenuItem})
        Me.msBrxExport.Location = New System.Drawing.Point(2, 2)
        Me.msBrxExport.Name = "msBrxExport"
        Me.msBrxExport.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.msBrxExport.Size = New System.Drawing.Size(780, 24)
        Me.msBrxExport.TabIndex = 14
        Me.msBrxExport.Text = "MenuStrip2"
        '
        'ExportBRXToolStripMenuItem
        '
        Me.ExportBRXToolStripMenuItem.Name = "ExportBRXToolStripMenuItem"
        Me.ExportBRXToolStripMenuItem.Size = New System.Drawing.Size(77, 22)
        Me.ExportBRXToolStripMenuItem.Text = "export BRX"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(176, 49)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(423, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "<- Edit to match scanner output block start index (if it does not start at 0)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(792, 702)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.MinimumSize = New System.Drawing.Size(690, 690)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IODD Brx Exporter - BETA - internal use only"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.mainTabDoc.ResumeLayout(False)
        Me.mainTabBrxExport.ResumeLayout(False)
        Me.mainTabBrxExport.PerformLayout()
        Me.tabCtrlBrxExport.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.gbSettings.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.gbInSourceData.ResumeLayout(False)
        Me.gbInSourceData.PerformLayout()
        CType(Me.nudSourceStartElement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSourcePortByteOffset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbProcessDataOptions.ResumeLayout(False)
        Me.gbDeviceName.ResumeLayout(False)
        Me.gbDeviceName.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbPreDefinedDefaults.ResumeLayout(False)
        Me.gbInUdtName.ResumeLayout(False)
        Me.gbInUdtName.PerformLayout()
        Me.gbOutUdtName.ResumeLayout(False)
        Me.gbOutUdtName.PerformLayout()
        Me.gbGlobalUdtName.ResumeLayout(False)
        Me.gbGlobalUdtName.PerformLayout()
        Me.gbSubRoutineName.ResumeLayout(False)
        Me.gbSubRoutineName.PerformLayout()
        Me.gbMode.ResumeLayout(False)
        Me.gbMode.PerformLayout()
        Me.gbOutTargetData.ResumeLayout(False)
        Me.gbOutTargetData.PerformLayout()
        CType(Me.nudTargetStartElement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTargetPortByteOffset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvOutUdt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInUdt.ResumeLayout(False)
        CType(Me.dgvInUdt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOutPD.ResumeLayout(False)
        CType(Me.dgvOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInPD.ResumeLayout(False)
        CType(Me.dgvIn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.WebView22, System.ComponentModel.ISupportInitialize).EndInit()
        Me.msBrxExport.ResumeLayout(False)
        Me.msBrxExport.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LoadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tscbIolMasters As ToolStripComboBox
    Friend WithEvents tscbIolMasterPorts As ToolStripComboBox
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveHtmlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PdfWithBackgroundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PdfNoBackgroundColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents OptionallySelectMasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tstbVer As ToolStripTextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents mainTabDoc As TabPage
    Friend WithEvents mainTabBrxExport As TabPage
    Friend WithEvents tabCtrlBrxExport As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents WebView22 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents gbSettings As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents gbMode As GroupBox
    Friend WithEvents gbGlobalUdtName As GroupBox
    Friend WithEvents tbMainUdtName As TextBox
    Friend WithEvents gbSubRoutineName As GroupBox
    Friend WithEvents tbSubRoutineName As TextBox
    Friend WithEvents gbDeviceName As GroupBox
    Friend WithEvents tbUdtHeapItem As TextBox
    Friend WithEvents gbOutTargetData As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents nudTargetPortByteOffset As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents tbOutTargetBlock As TextBox
    Friend WithEvents gbInSourceData As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nudSourcePortByteOffset As NumericUpDown
    Friend WithEvents tbInSourceBlock As TextBox
    Friend WithEvents gbProcessDataOptions As GroupBox
    Friend WithEvents cbSelectedOption As ComboBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvOutUdt As DataGridView
    Friend WithEvents gbInUdt As GroupBox
    Friend WithEvents dgvInUdt As DataGridView
    Friend WithEvents gbOutPD As GroupBox
    Friend WithEvents dgvOut As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents gbInPD As GroupBox
    Friend WithEvents dgvIn As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents gbOutUdtName As GroupBox
    Friend WithEvents tbOutUdtName As TextBox
    Friend WithEvents gbInUdtName As GroupBox
    Friend WithEvents tbInUdtName As TextBox
    Friend WithEvents msBrxExport As MenuStrip
    Friend WithEvents ExportBRXToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cbGenerateSR As CheckBox
    Friend WithEvents cbGenerateSRCall As CheckBox
    Friend WithEvents LicenseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbEditDefaults As CheckBox
    Friend WithEvents gbPreDefinedDefaults As GroupBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lbSourcePortByteOffset As Label
    Friend WithEvents nudSourceStartElement As NumericUpDown
    Friend WithEvents nudTargetStartElement As NumericUpDown
    Friend WithEvents lbTargetPortByteOffset As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
