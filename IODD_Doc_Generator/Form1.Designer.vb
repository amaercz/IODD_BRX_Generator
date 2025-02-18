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
        Me.WebView22 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.gbSettings = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.gbMode = New System.Windows.Forms.GroupBox()
        Me.cbGenerateSR = New System.Windows.Forms.CheckBox()
        Me.cbGenerateSRCall = New System.Windows.Forms.CheckBox()
        Me.gbGlobalUdtName = New System.Windows.Forms.GroupBox()
        Me.tbMainUdtName = New System.Windows.Forms.TextBox()
        Me.gbSubRoutineName = New System.Windows.Forms.GroupBox()
        Me.tbSubRoutineName = New System.Windows.Forms.TextBox()
        Me.gbDeviceName = New System.Windows.Forms.GroupBox()
        Me.tbUdtHeapItem = New System.Windows.Forms.TextBox()
        Me.gbOutTargetData = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudTargetStartElement = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbOutTargetBlock = New System.Windows.Forms.TextBox()
        Me.gbInSourceData = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudSourceStartElement = New System.Windows.Forms.NumericUpDown()
        Me.tbInSourceBlock = New System.Windows.Forms.TextBox()
        Me.gbProcessDataOptions = New System.Windows.Forms.GroupBox()
        Me.cbSelectedOption = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gbAdvancedOptions = New System.Windows.Forms.GroupBox()
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
        Me.gbOutUdtName = New System.Windows.Forms.GroupBox()
        Me.tbOutUdtName = New System.Windows.Forms.TextBox()
        Me.gbInUdtName = New System.Windows.Forms.GroupBox()
        Me.tbInUdtName = New System.Windows.Forms.TextBox()
        Me.msBrxExport = New System.Windows.Forms.MenuStrip()
        Me.ExportBRXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.mainTabDoc.SuspendLayout()
        Me.mainTabBrxExport.SuspendLayout()
        Me.tabCtrlBrxExport.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.WebView22, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSettings.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.gbMode.SuspendLayout()
        Me.gbGlobalUdtName.SuspendLayout()
        Me.gbSubRoutineName.SuspendLayout()
        Me.gbDeviceName.SuspendLayout()
        Me.gbOutTargetData.SuspendLayout()
        CType(Me.nudTargetStartElement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInSourceData.SuspendLayout()
        CType(Me.nudSourceStartElement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbProcessDataOptions.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gbAdvancedOptions.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvOutUdt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInUdt.SuspendLayout()
        CType(Me.dgvInUdt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOutPD.SuspendLayout()
        CType(Me.dgvOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInPD.SuspendLayout()
        CType(Me.dgvIn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOutUdtName.SuspendLayout()
        Me.gbInUdtName.SuspendLayout()
        Me.msBrxExport.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadToolStripMenuItem, Me.OptionallySelectMasterToolStripMenuItem, Me.tscbIolMasters, Me.tscbIolMasterPorts, Me.ToolStripMenuItem1, Me.SaveToolStripMenuItem, Me.tstbVer, Me.LicenseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(2129, 48)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(189, 44)
        Me.LoadToolStripMenuItem.Text = "load IODD File"
        '
        'OptionallySelectMasterToolStripMenuItem
        '
        Me.OptionallySelectMasterToolStripMenuItem.Enabled = False
        Me.OptionallySelectMasterToolStripMenuItem.Name = "OptionallySelectMasterToolStripMenuItem"
        Me.OptionallySelectMasterToolStripMenuItem.Size = New System.Drawing.Size(376, 44)
        Me.OptionallySelectMasterToolStripMenuItem.Text = "Optionally select Master/Port-> "
        '
        'tscbIolMasters
        '
        Me.tscbIolMasters.AutoSize = False
        Me.tscbIolMasters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscbIolMasters.Name = "tscbIolMasters"
        Me.tscbIolMasters.Size = New System.Drawing.Size(356, 40)
        '
        'tscbIolMasterPorts
        '
        Me.tscbIolMasterPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscbIolMasterPorts.Name = "tscbIolMasterPorts"
        Me.tscbIolMasterPorts.Size = New System.Drawing.Size(238, 44)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(20, 44)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveHtmlToolStripMenuItem, Me.PdfWithBackgroundToolStripMenuItem, Me.PdfNoBackgroundColorToolStripMenuItem})
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(370, 44)
        Me.SaveToolStripMenuItem.Text = "save generated Documentation"
        '
        'SaveHtmlToolStripMenuItem
        '
        Me.SaveHtmlToolStripMenuItem.Name = "SaveHtmlToolStripMenuItem"
        Me.SaveHtmlToolStripMenuItem.Size = New System.Drawing.Size(412, 44)
        Me.SaveHtmlToolStripMenuItem.Text = "save html"
        '
        'PdfWithBackgroundToolStripMenuItem
        '
        Me.PdfWithBackgroundToolStripMenuItem.Name = "PdfWithBackgroundToolStripMenuItem"
        Me.PdfWithBackgroundToolStripMenuItem.Size = New System.Drawing.Size(412, 44)
        Me.PdfWithBackgroundToolStripMenuItem.Text = "pdf with background"
        '
        'PdfNoBackgroundColorToolStripMenuItem
        '
        Me.PdfNoBackgroundColorToolStripMenuItem.Name = "PdfNoBackgroundColorToolStripMenuItem"
        Me.PdfNoBackgroundColorToolStripMenuItem.Size = New System.Drawing.Size(412, 44)
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
        Me.tstbVer.Size = New System.Drawing.Size(110, 44)
        Me.tstbVer.Text = "1.1.4b"
        Me.tstbVer.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LicenseToolStripMenuItem
        '
        Me.LicenseToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.LicenseToolStripMenuItem.Name = "LicenseToolStripMenuItem"
        Me.LicenseToolStripMenuItem.Size = New System.Drawing.Size(112, 44)
        Me.LicenseToolStripMenuItem.Text = "License"
        '
        'WebView21
        '
        Me.WebView21.AllowExternalDrop = True
        Me.WebView21.CreationProperties = Nothing
        Me.WebView21.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebView21.Location = New System.Drawing.Point(3, 3)
        Me.WebView21.Margin = New System.Windows.Forms.Padding(2)
        Me.WebView21.Name = "WebView21"
        Me.WebView21.Size = New System.Drawing.Size(2107, 1276)
        Me.WebView21.TabIndex = 3
        Me.WebView21.ZoomFactor = 1.0R
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.mainTabDoc)
        Me.TabControl1.Controls.Add(Me.mainTabBrxExport)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(2129, 2071)
        Me.TabControl1.TabIndex = 4
        '
        'mainTabDoc
        '
        Me.mainTabDoc.Controls.Add(Me.WebView21)
        Me.mainTabDoc.Location = New System.Drawing.Point(8, 39)
        Me.mainTabDoc.Name = "mainTabDoc"
        Me.mainTabDoc.Padding = New System.Windows.Forms.Padding(3)
        Me.mainTabDoc.Size = New System.Drawing.Size(2113, 1282)
        Me.mainTabDoc.TabIndex = 0
        Me.mainTabDoc.Text = "Documentation"
        Me.mainTabDoc.UseVisualStyleBackColor = True
        '
        'mainTabBrxExport
        '
        Me.mainTabBrxExport.Controls.Add(Me.tabCtrlBrxExport)
        Me.mainTabBrxExport.Controls.Add(Me.msBrxExport)
        Me.mainTabBrxExport.Location = New System.Drawing.Point(8, 39)
        Me.mainTabBrxExport.Name = "mainTabBrxExport"
        Me.mainTabBrxExport.Padding = New System.Windows.Forms.Padding(3)
        Me.mainTabBrxExport.Size = New System.Drawing.Size(2113, 2024)
        Me.mainTabBrxExport.TabIndex = 1
        Me.mainTabBrxExport.Text = "BRX Export "
        Me.mainTabBrxExport.UseVisualStyleBackColor = True
        '
        'tabCtrlBrxExport
        '
        Me.tabCtrlBrxExport.Controls.Add(Me.TabPage1)
        Me.tabCtrlBrxExport.Controls.Add(Me.TabPage2)
        Me.tabCtrlBrxExport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCtrlBrxExport.Enabled = False
        Me.tabCtrlBrxExport.Location = New System.Drawing.Point(3, 43)
        Me.tabCtrlBrxExport.Name = "tabCtrlBrxExport"
        Me.tabCtrlBrxExport.SelectedIndex = 0
        Me.tabCtrlBrxExport.Size = New System.Drawing.Size(2107, 1978)
        Me.tabCtrlBrxExport.TabIndex = 13
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.WebView22)
        Me.TabPage1.Controls.Add(Me.gbSettings)
        Me.TabPage1.Location = New System.Drawing.Point(8, 39)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(2091, 1931)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Common Settings"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'WebView22
        '
        Me.WebView22.AllowExternalDrop = True
        Me.WebView22.CreationProperties = Nothing
        Me.WebView22.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebView22.Location = New System.Drawing.Point(3, 844)
        Me.WebView22.Name = "WebView22"
        Me.WebView22.Size = New System.Drawing.Size(2085, 1084)
        Me.WebView22.TabIndex = 11
        Me.WebView22.ZoomFactor = 1.0R
        '
        'gbSettings
        '
        Me.gbSettings.AutoSize = True
        Me.gbSettings.Controls.Add(Me.TableLayoutPanel2)
        Me.gbSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSettings.Location = New System.Drawing.Point(3, 3)
        Me.gbSettings.Name = "gbSettings"
        Me.gbSettings.Size = New System.Drawing.Size(2085, 841)
        Me.gbSettings.TabIndex = 9
        Me.gbSettings.TabStop = False
        Me.gbSettings.Text = "Settings (Edit to match the Input and Output data blocks used in the EIP scanner)" &
    ""
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.gbMode, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.gbGlobalUdtName, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.gbSubRoutineName, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.gbDeviceName, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.gbOutTargetData, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.gbInSourceData, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.gbProcessDataOptions, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 28)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 7
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(2079, 810)
        Me.TableLayoutPanel2.TabIndex = 10
        '
        'gbMode
        '
        Me.gbMode.AutoSize = True
        Me.gbMode.Controls.Add(Me.cbGenerateSR)
        Me.gbMode.Controls.Add(Me.cbGenerateSRCall)
        Me.gbMode.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMode.Location = New System.Drawing.Point(3, 108)
        Me.gbMode.Name = "gbMode"
        Me.gbMode.Size = New System.Drawing.Size(2073, 140)
        Me.gbMode.TabIndex = 8
        Me.gbMode.TabStop = False
        Me.gbMode.Text = "Mode"
        '
        'cbGenerateSR
        '
        Me.cbGenerateSR.AutoSize = True
        Me.cbGenerateSR.Checked = True
        Me.cbGenerateSR.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbGenerateSR.Location = New System.Drawing.Point(21, 36)
        Me.cbGenerateSR.Name = "cbGenerateSR"
        Me.cbGenerateSR.Size = New System.Drawing.Size(500, 30)
        Me.cbGenerateSR.TabIndex = 3
        Me.cbGenerateSR.Text = "Generate SubRoutine and corresponding UDTs"
        Me.cbGenerateSR.UseVisualStyleBackColor = True
        '
        'cbGenerateSRCall
        '
        Me.cbGenerateSRCall.AutoSize = True
        Me.cbGenerateSRCall.Checked = True
        Me.cbGenerateSRCall.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbGenerateSRCall.Location = New System.Drawing.Point(21, 79)
        Me.cbGenerateSRCall.Name = "cbGenerateSRCall"
        Me.cbGenerateSRCall.Size = New System.Drawing.Size(747, 30)
        Me.cbGenerateSRCall.TabIndex = 2
        Me.cbGenerateSRCall.Text = "Generate Call to SubRoutine with selected In/Out data blocks and offsets"
        Me.cbGenerateSRCall.UseVisualStyleBackColor = True
        '
        'gbGlobalUdtName
        '
        Me.gbGlobalUdtName.AutoSize = True
        Me.gbGlobalUdtName.Controls.Add(Me.tbMainUdtName)
        Me.gbGlobalUdtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbGlobalUdtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGlobalUdtName.Location = New System.Drawing.Point(3, 704)
        Me.gbGlobalUdtName.Name = "gbGlobalUdtName"
        Me.gbGlobalUdtName.Size = New System.Drawing.Size(2073, 103)
        Me.gbGlobalUdtName.TabIndex = 4
        Me.gbGlobalUdtName.TabStop = False
        Me.gbGlobalUdtName.Text = "Device Udt Name"
        '
        'tbMainUdtName
        '
        Me.tbMainUdtName.Location = New System.Drawing.Point(12, 40)
        Me.tbMainUdtName.Name = "tbMainUdtName"
        Me.tbMainUdtName.Size = New System.Drawing.Size(631, 32)
        Me.tbMainUdtName.TabIndex = 0
        '
        'gbSubRoutineName
        '
        Me.gbSubRoutineName.AutoSize = True
        Me.gbSubRoutineName.Controls.Add(Me.tbSubRoutineName)
        Me.gbSubRoutineName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbSubRoutineName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSubRoutineName.Location = New System.Drawing.Point(3, 598)
        Me.gbSubRoutineName.Name = "gbSubRoutineName"
        Me.gbSubRoutineName.Size = New System.Drawing.Size(2073, 100)
        Me.gbSubRoutineName.TabIndex = 3
        Me.gbSubRoutineName.TabStop = False
        Me.gbSubRoutineName.Text = "SubRoutine Name"
        '
        'tbSubRoutineName
        '
        Me.tbSubRoutineName.Location = New System.Drawing.Point(12, 37)
        Me.tbSubRoutineName.Name = "tbSubRoutineName"
        Me.tbSubRoutineName.Size = New System.Drawing.Size(631, 32)
        Me.tbSubRoutineName.TabIndex = 0
        '
        'gbDeviceName
        '
        Me.gbDeviceName.AutoSize = True
        Me.gbDeviceName.Controls.Add(Me.tbUdtHeapItem)
        Me.gbDeviceName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbDeviceName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDeviceName.Location = New System.Drawing.Point(3, 489)
        Me.gbDeviceName.Name = "gbDeviceName"
        Me.gbDeviceName.Size = New System.Drawing.Size(2073, 103)
        Me.gbDeviceName.TabIndex = 2
        Me.gbDeviceName.TabStop = False
        Me.gbDeviceName.Text = "Device Name (for UDT Heap Item)"
        '
        'tbUdtHeapItem
        '
        Me.tbUdtHeapItem.Location = New System.Drawing.Point(12, 40)
        Me.tbUdtHeapItem.Name = "tbUdtHeapItem"
        Me.tbUdtHeapItem.Size = New System.Drawing.Size(631, 32)
        Me.tbUdtHeapItem.TabIndex = 0
        '
        'gbOutTargetData
        '
        Me.gbOutTargetData.AutoSize = True
        Me.gbOutTargetData.Controls.Add(Me.Label4)
        Me.gbOutTargetData.Controls.Add(Me.nudTargetStartElement)
        Me.gbOutTargetData.Controls.Add(Me.Label3)
        Me.gbOutTargetData.Controls.Add(Me.tbOutTargetBlock)
        Me.gbOutTargetData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbOutTargetData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOutTargetData.Location = New System.Drawing.Point(3, 360)
        Me.gbOutTargetData.Name = "gbOutTargetData"
        Me.gbOutTargetData.Size = New System.Drawing.Size(2073, 123)
        Me.gbOutTargetData.TabIndex = 1
        Me.gbOutTargetData.TabStop = False
        Me.gbOutTargetData.Text = "Output data target data block (has to be byte array)"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(206, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(518, 55)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "<- Edit to match scanner output block name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudTargetStartElement
        '
        Me.nudTargetStartElement.Location = New System.Drawing.Point(926, 51)
        Me.nudTargetStartElement.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudTargetStartElement.Name = "nudTargetStartElement"
        Me.nudTargetStartElement.Size = New System.Drawing.Size(120, 32)
        Me.nudTargetStartElement.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(751, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 26)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Starting index"
        '
        'tbOutTargetBlock
        '
        Me.tbOutTargetBlock.Location = New System.Drawing.Point(12, 51)
        Me.tbOutTargetBlock.Name = "tbOutTargetBlock"
        Me.tbOutTargetBlock.Size = New System.Drawing.Size(188, 32)
        Me.tbOutTargetBlock.TabIndex = 0
        Me.tbOutTargetBlock.Text = "OutData"
        '
        'gbInSourceData
        '
        Me.gbInSourceData.AutoSize = True
        Me.gbInSourceData.Controls.Add(Me.Label1)
        Me.gbInSourceData.Controls.Add(Me.Label2)
        Me.gbInSourceData.Controls.Add(Me.nudSourceStartElement)
        Me.gbInSourceData.Controls.Add(Me.tbInSourceBlock)
        Me.gbInSourceData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbInSourceData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInSourceData.Location = New System.Drawing.Point(3, 254)
        Me.gbInSourceData.Name = "gbInSourceData"
        Me.gbInSourceData.Size = New System.Drawing.Size(2073, 100)
        Me.gbInSourceData.TabIndex = 0
        Me.gbInSourceData.TabStop = False
        Me.gbInSourceData.Text = "Input data source data block (has to be byte array)"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(206, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(539, 33)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "<- Edit to match scanner input block name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(751, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Starting index"
        '
        'nudSourceStartElement
        '
        Me.nudSourceStartElement.Location = New System.Drawing.Point(926, 35)
        Me.nudSourceStartElement.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudSourceStartElement.Name = "nudSourceStartElement"
        Me.nudSourceStartElement.Size = New System.Drawing.Size(120, 32)
        Me.nudSourceStartElement.TabIndex = 1
        '
        'tbInSourceBlock
        '
        Me.tbInSourceBlock.Location = New System.Drawing.Point(12, 37)
        Me.tbInSourceBlock.Name = "tbInSourceBlock"
        Me.tbInSourceBlock.Size = New System.Drawing.Size(188, 32)
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
        Me.gbProcessDataOptions.Location = New System.Drawing.Point(3, 3)
        Me.gbProcessDataOptions.Name = "gbProcessDataOptions"
        Me.gbProcessDataOptions.Size = New System.Drawing.Size(2073, 99)
        Me.gbProcessDataOptions.TabIndex = 7
        Me.gbProcessDataOptions.TabStop = False
        Me.gbProcessDataOptions.Text = "Process Data Options (if any)"
        '
        'cbSelectedOption
        '
        Me.cbSelectedOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSelectedOption.FormattingEnabled = True
        Me.cbSelectedOption.Location = New System.Drawing.Point(17, 34)
        Me.cbSelectedOption.Name = "cbSelectedOption"
        Me.cbSelectedOption.Size = New System.Drawing.Size(801, 34)
        Me.cbSelectedOption.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gbAdvancedOptions)
        Me.TabPage2.Location = New System.Drawing.Point(8, 39)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(2091, 1177)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Advanced settings and diag"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gbAdvancedOptions
        '
        Me.gbAdvancedOptions.Controls.Add(Me.TableLayoutPanel1)
        Me.gbAdvancedOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbAdvancedOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAdvancedOptions.Location = New System.Drawing.Point(3, 3)
        Me.gbAdvancedOptions.Name = "gbAdvancedOptions"
        Me.gbAdvancedOptions.Size = New System.Drawing.Size(2085, 1171)
        Me.gbAdvancedOptions.TabIndex = 10
        Me.gbAdvancedOptions.TabStop = False
        Me.gbAdvancedOptions.Text = "Advanced Options ( Don't change anything unless you know you need to )"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.gbInUdt, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.gbOutPD, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.gbInPD, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.gbOutUdtName, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.gbInUdtName, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 28)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(2079, 1140)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvOutUdt)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(1042, 598)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1034, 539)
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
        Me.dgvOutUdt.Location = New System.Drawing.Point(3, 28)
        Me.dgvOutUdt.Name = "dgvOutUdt"
        Me.dgvOutUdt.RowHeadersWidth = 5
        Me.dgvOutUdt.Size = New System.Drawing.Size(1028, 508)
        Me.dgvOutUdt.TabIndex = 0
        '
        'gbInUdt
        '
        Me.gbInUdt.Controls.Add(Me.dgvInUdt)
        Me.gbInUdt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbInUdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInUdt.Location = New System.Drawing.Point(3, 598)
        Me.gbInUdt.Name = "gbInUdt"
        Me.gbInUdt.Size = New System.Drawing.Size(1033, 539)
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
        Me.dgvInUdt.Location = New System.Drawing.Point(3, 28)
        Me.dgvInUdt.Name = "dgvInUdt"
        Me.dgvInUdt.RowHeadersWidth = 5
        Me.dgvInUdt.Size = New System.Drawing.Size(1027, 508)
        Me.dgvInUdt.TabIndex = 0
        '
        'gbOutPD
        '
        Me.gbOutPD.Controls.Add(Me.dgvOut)
        Me.gbOutPD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbOutPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOutPD.Location = New System.Drawing.Point(1042, 53)
        Me.gbOutPD.Name = "gbOutPD"
        Me.gbOutPD.Size = New System.Drawing.Size(1034, 539)
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
        Me.dgvOut.Location = New System.Drawing.Point(3, 28)
        Me.dgvOut.Name = "dgvOut"
        Me.dgvOut.RowHeadersWidth = 5
        Me.dgvOut.Size = New System.Drawing.Size(1028, 508)
        Me.dgvOut.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "UDT Field"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 154
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 104
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "BitOffset"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 141
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "BitLength"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 149
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "MinValue"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 148
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "MaxValue"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 154
        '
        'gbInPD
        '
        Me.gbInPD.Controls.Add(Me.dgvIn)
        Me.gbInPD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbInPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInPD.Location = New System.Drawing.Point(3, 53)
        Me.gbInPD.Name = "gbInPD"
        Me.gbInPD.Size = New System.Drawing.Size(1033, 539)
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
        Me.dgvIn.Location = New System.Drawing.Point(3, 28)
        Me.dgvIn.Name = "dgvIn"
        Me.dgvIn.RowHeadersWidth = 5
        Me.dgvIn.Size = New System.Drawing.Size(1027, 508)
        Me.dgvIn.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "UDT Field"
        Me.Column1.MinimumWidth = 10
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 154
        '
        'Column2
        '
        Me.Column2.HeaderText = "Type"
        Me.Column2.MinimumWidth = 10
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 104
        '
        'Column3
        '
        Me.Column3.HeaderText = "BitOffset"
        Me.Column3.MinimumWidth = 10
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 141
        '
        'Column4
        '
        Me.Column4.HeaderText = "BitLength"
        Me.Column4.MinimumWidth = 10
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 149
        '
        'Column5
        '
        Me.Column5.HeaderText = "MinValue"
        Me.Column5.MinimumWidth = 10
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 148
        '
        'Column6
        '
        Me.Column6.HeaderText = "MaxValue"
        Me.Column6.MinimumWidth = 10
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 154
        '
        'gbOutUdtName
        '
        Me.gbOutUdtName.Controls.Add(Me.tbOutUdtName)
        Me.gbOutUdtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbOutUdtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOutUdtName.Location = New System.Drawing.Point(1042, 3)
        Me.gbOutUdtName.MinimumSize = New System.Drawing.Size(0, 42)
        Me.gbOutUdtName.Name = "gbOutUdtName"
        Me.gbOutUdtName.Size = New System.Drawing.Size(1034, 44)
        Me.gbOutUdtName.TabIndex = 2
        Me.gbOutUdtName.TabStop = False
        Me.gbOutUdtName.Text = "Output UDT Name"
        '
        'tbOutUdtName
        '
        Me.tbOutUdtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbOutUdtName.Location = New System.Drawing.Point(3, 28)
        Me.tbOutUdtName.Name = "tbOutUdtName"
        Me.tbOutUdtName.Size = New System.Drawing.Size(1028, 32)
        Me.tbOutUdtName.TabIndex = 1
        '
        'gbInUdtName
        '
        Me.gbInUdtName.Controls.Add(Me.tbInUdtName)
        Me.gbInUdtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbInUdtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInUdtName.Location = New System.Drawing.Point(3, 3)
        Me.gbInUdtName.MinimumSize = New System.Drawing.Size(0, 42)
        Me.gbInUdtName.Name = "gbInUdtName"
        Me.gbInUdtName.Size = New System.Drawing.Size(1033, 44)
        Me.gbInUdtName.TabIndex = 2
        Me.gbInUdtName.TabStop = False
        Me.gbInUdtName.Text = "Input UDT Name"
        '
        'tbInUdtName
        '
        Me.tbInUdtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbInUdtName.Location = New System.Drawing.Point(3, 28)
        Me.tbInUdtName.Name = "tbInUdtName"
        Me.tbInUdtName.Size = New System.Drawing.Size(1027, 32)
        Me.tbInUdtName.TabIndex = 1
        '
        'msBrxExport
        '
        Me.msBrxExport.Enabled = False
        Me.msBrxExport.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.msBrxExport.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.msBrxExport.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportBRXToolStripMenuItem})
        Me.msBrxExport.Location = New System.Drawing.Point(3, 3)
        Me.msBrxExport.Name = "msBrxExport"
        Me.msBrxExport.Size = New System.Drawing.Size(2107, 40)
        Me.msBrxExport.TabIndex = 14
        Me.msBrxExport.Text = "MenuStrip2"
        '
        'ExportBRXToolStripMenuItem
        '
        Me.ExportBRXToolStripMenuItem.Name = "ExportBRXToolStripMenuItem"
        Me.ExportBRXToolStripMenuItem.Size = New System.Drawing.Size(151, 36)
        Me.ExportBRXToolStripMenuItem.Text = "export BRX"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(2129, 2119)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(0, 1400)
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
        Me.TabPage1.PerformLayout()
        CType(Me.WebView22, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSettings.ResumeLayout(False)
        Me.gbSettings.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.gbMode.ResumeLayout(False)
        Me.gbMode.PerformLayout()
        Me.gbGlobalUdtName.ResumeLayout(False)
        Me.gbGlobalUdtName.PerformLayout()
        Me.gbSubRoutineName.ResumeLayout(False)
        Me.gbSubRoutineName.PerformLayout()
        Me.gbDeviceName.ResumeLayout(False)
        Me.gbDeviceName.PerformLayout()
        Me.gbOutTargetData.ResumeLayout(False)
        Me.gbOutTargetData.PerformLayout()
        CType(Me.nudTargetStartElement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInSourceData.ResumeLayout(False)
        Me.gbInSourceData.PerformLayout()
        CType(Me.nudSourceStartElement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbProcessDataOptions.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.gbAdvancedOptions.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvOutUdt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInUdt.ResumeLayout(False)
        CType(Me.dgvInUdt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOutPD.ResumeLayout(False)
        CType(Me.dgvOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInPD.ResumeLayout(False)
        CType(Me.dgvIn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOutUdtName.ResumeLayout(False)
        Me.gbOutUdtName.PerformLayout()
        Me.gbInUdtName.ResumeLayout(False)
        Me.gbInUdtName.PerformLayout()
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
    Friend WithEvents nudTargetStartElement As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents tbOutTargetBlock As TextBox
    Friend WithEvents gbInSourceData As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nudSourceStartElement As NumericUpDown
    Friend WithEvents tbInSourceBlock As TextBox
    Friend WithEvents gbProcessDataOptions As GroupBox
    Friend WithEvents cbSelectedOption As ComboBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents gbAdvancedOptions As GroupBox
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
End Class
