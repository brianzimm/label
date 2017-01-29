<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.btnlocatepog = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAisle = New System.Windows.Forms.TextBox()
        Me.txtBay = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnlabelpog = New System.Windows.Forms.Button()
        Me.txtbin = New System.Windows.Forms.TextBox()
        Me.txtBeam = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gblocate = New System.Windows.Forms.GroupBox()
        Me.gblabels = New System.Windows.Forms.GroupBox()
        Me.cbdefault = New System.Windows.Forms.CheckBox()
        Me.cbpogdefault = New System.Windows.Forms.CheckBox()
        Me.btnallpog = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnindexload = New System.Windows.Forms.Button()
        Me.btnpdfread = New System.Windows.Forms.Button()
        Me.cboxbay = New System.Windows.Forms.ComboBox()
        Me.txtstop = New System.Windows.Forms.TextBox()
        Me.cbitemsnof = New System.Windows.Forms.CheckBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.lblcount = New System.Windows.Forms.Label()
        Me.btndatacheck = New System.Windows.Forms.Button()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.txtdone = New System.Windows.Forms.TextBox()
        Me.txtextras = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideAdvancedOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubmitSuggestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbadvanced = New System.Windows.Forms.GroupBox()
        Me.txtStartLoc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbsort = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbmiadefault = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtlbltime = New System.Windows.Forms.TextBox()
        Me.gbpricing = New System.Windows.Forms.GroupBox()
        Me.btnactivate = New System.Windows.Forms.Button()
        Me.tupdate = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblpog = New System.Windows.Forms.Label()
        Me.gblocate.SuspendLayout()
        Me.gblabels.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.gbadvanced.SuspendLayout()
        Me.gbpricing.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(368, 40)
        Me.txtItem.Multiline = True
        Me.txtItem.Name = "txtItem"
        Me.txtItem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtItem.Size = New System.Drawing.Size(337, 93)
        Me.txtItem.TabIndex = 0
        '
        'btnlocatepog
        '
        Me.btnlocatepog.Location = New System.Drawing.Point(6, 71)
        Me.btnlocatepog.Name = "btnlocatepog"
        Me.btnlocatepog.Size = New System.Drawing.Size(150, 26)
        Me.btnlocatepog.TabIndex = 1
        Me.btnlocatepog.Text = "Bin Locate"
        Me.btnlocatepog.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(371, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Item Numbers Here"
        '
        'txtAisle
        '
        Me.txtAisle.Location = New System.Drawing.Point(95, 19)
        Me.txtAisle.MaxLength = 3
        Me.txtAisle.Name = "txtAisle"
        Me.txtAisle.Size = New System.Drawing.Size(61, 20)
        Me.txtAisle.TabIndex = 3
        '
        'txtBay
        '
        Me.txtBay.Location = New System.Drawing.Point(95, 45)
        Me.txtBay.MaxLength = 2
        Me.txtBay.Name = "txtBay"
        Me.txtBay.Size = New System.Drawing.Size(61, 20)
        Me.txtBay.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Aisle"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Bay"
        '
        'btnlabelpog
        '
        Me.btnlabelpog.Location = New System.Drawing.Point(6, 103)
        Me.btnlabelpog.Name = "btnlabelpog"
        Me.btnlabelpog.Size = New System.Drawing.Size(150, 26)
        Me.btnlabelpog.TabIndex = 7
        Me.btnlabelpog.Text = "Make Labels"
        Me.btnlabelpog.UseVisualStyleBackColor = True
        '
        'txtbin
        '
        Me.txtbin.Location = New System.Drawing.Point(125, 52)
        Me.txtbin.MaxLength = 2
        Me.txtbin.Name = "txtbin"
        Me.txtbin.Size = New System.Drawing.Size(34, 20)
        Me.txtbin.TabIndex = 8
        Me.txtbin.Text = "00"
        '
        'txtBeam
        '
        Me.txtBeam.Location = New System.Drawing.Point(125, 77)
        Me.txtBeam.MaxLength = 2
        Me.txtBeam.Name = "txtBeam"
        Me.txtBeam.Size = New System.Drawing.Size(34, 20)
        Me.txtBeam.TabIndex = 9
        Me.txtBeam.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Bin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Beam"
        '
        'gblocate
        '
        Me.gblocate.Controls.Add(Me.btnlocatepog)
        Me.gblocate.Controls.Add(Me.txtAisle)
        Me.gblocate.Controls.Add(Me.txtBay)
        Me.gblocate.Controls.Add(Me.Label2)
        Me.gblocate.Controls.Add(Me.Label3)
        Me.gblocate.Enabled = False
        Me.gblocate.Location = New System.Drawing.Point(12, 43)
        Me.gblocate.Name = "gblocate"
        Me.gblocate.Size = New System.Drawing.Size(167, 106)
        Me.gblocate.TabIndex = 18
        Me.gblocate.TabStop = False
        Me.gblocate.Text = "5.7.4 Bin Locate"
        '
        'gblabels
        '
        Me.gblabels.Controls.Add(Me.cbdefault)
        Me.gblabels.Controls.Add(Me.cbpogdefault)
        Me.gblabels.Controls.Add(Me.btnlabelpog)
        Me.gblabels.Controls.Add(Me.txtbin)
        Me.gblabels.Controls.Add(Me.txtBeam)
        Me.gblabels.Controls.Add(Me.Label4)
        Me.gblabels.Controls.Add(Me.Label5)
        Me.gblabels.Enabled = False
        Me.gblabels.Location = New System.Drawing.Point(12, 155)
        Me.gblabels.Name = "gblabels"
        Me.gblabels.Size = New System.Drawing.Size(167, 144)
        Me.gblabels.TabIndex = 19
        Me.gblabels.TabStop = False
        Me.gblabels.Text = "5.7.1 Make Labels"
        '
        'cbdefault
        '
        Me.cbdefault.AutoSize = True
        Me.cbdefault.Checked = True
        Me.cbdefault.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbdefault.Location = New System.Drawing.Point(9, 37)
        Me.cbdefault.Name = "cbdefault"
        Me.cbdefault.Size = New System.Drawing.Size(113, 17)
        Me.cbdefault.TabIndex = 13
        Me.cbdefault.Text = "Set Label Defaults"
        Me.cbdefault.UseVisualStyleBackColor = True
        '
        'cbpogdefault
        '
        Me.cbpogdefault.AutoSize = True
        Me.cbpogdefault.Checked = True
        Me.cbpogdefault.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbpogdefault.Location = New System.Drawing.Point(9, 20)
        Me.cbpogdefault.Name = "cbpogdefault"
        Me.cbpogdefault.Size = New System.Drawing.Size(113, 17)
        Me.cbpogdefault.TabIndex = 12
        Me.cbpogdefault.Text = "Use POG Defaults"
        Me.cbpogdefault.UseVisualStyleBackColor = True
        '
        'btnallpog
        '
        Me.btnallpog.Enabled = False
        Me.btnallpog.Location = New System.Drawing.Point(6, 126)
        Me.btnallpog.Name = "btnallpog"
        Me.btnallpog.Size = New System.Drawing.Size(150, 26)
        Me.btnallpog.TabIndex = 30
        Me.btnallpog.Text = "Make All POG Labels"
        Me.btnallpog.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnallpog)
        Me.GroupBox3.Controls.Add(Me.btnindexload)
        Me.GroupBox3.Controls.Add(Me.btnpdfread)
        Me.GroupBox3.Controls.Add(Me.cboxbay)
        Me.GroupBox3.Controls.Add(Me.txtstop)
        Me.GroupBox3.Controls.Add(Me.cbitemsnof)
        Me.GroupBox3.Controls.Add(Me.btnclear)
        Me.GroupBox3.Controls.Add(Me.lblcount)
        Me.GroupBox3.Location = New System.Drawing.Point(185, 43)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(165, 256)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Options"
        '
        'btnindexload
        '
        Me.btnindexload.Enabled = False
        Me.btnindexload.Location = New System.Drawing.Point(90, 83)
        Me.btnindexload.Name = "btnindexload"
        Me.btnindexload.Size = New System.Drawing.Size(66, 23)
        Me.btnindexload.TabIndex = 28
        Me.btnindexload.Text = "Load Bay"
        Me.btnindexload.UseVisualStyleBackColor = True
        '
        'btnpdfread
        '
        Me.btnpdfread.Location = New System.Drawing.Point(6, 52)
        Me.btnpdfread.Name = "btnpdfread"
        Me.btnpdfread.Size = New System.Drawing.Size(150, 26)
        Me.btnpdfread.TabIndex = 29
        Me.btnpdfread.Text = "Open POG (PDF)"
        Me.btnpdfread.UseVisualStyleBackColor = True
        '
        'cboxbay
        '
        Me.cboxbay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxbay.Enabled = False
        Me.cboxbay.FormattingEnabled = True
        Me.cboxbay.Location = New System.Drawing.Point(6, 84)
        Me.cboxbay.Name = "cboxbay"
        Me.cboxbay.Size = New System.Drawing.Size(56, 21)
        Me.cboxbay.TabIndex = 27
        '
        'txtstop
        '
        Me.txtstop.BackColor = System.Drawing.Color.Red
        Me.txtstop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstop.ForeColor = System.Drawing.Color.White
        Me.txtstop.Location = New System.Drawing.Point(114, 19)
        Me.txtstop.Name = "txtstop"
        Me.txtstop.Size = New System.Drawing.Size(42, 22)
        Me.txtstop.TabIndex = 25
        Me.txtstop.Text = "STOP"
        '
        'cbitemsnof
        '
        Me.cbitemsnof.AutoSize = True
        Me.cbitemsnof.Enabled = False
        Me.cbitemsnof.Location = New System.Drawing.Point(6, 158)
        Me.cbitemsnof.Name = "cbitemsnof"
        Me.cbitemsnof.Size = New System.Drawing.Size(113, 17)
        Me.cbitemsnof.TabIndex = 2
        Me.cbitemsnof.Text = "Items Not On File?"
        Me.cbitemsnof.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Enabled = False
        Me.btnclear.Location = New System.Drawing.Point(6, 215)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(150, 26)
        Me.btnclear.TabIndex = 1
        Me.btnclear.Text = "Clear For Next POG"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'lblcount
        '
        Me.lblcount.AutoSize = True
        Me.lblcount.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcount.Location = New System.Drawing.Point(6, 16)
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(87, 33)
        Me.lblcount.TabIndex = 24
        Me.lblcount.Text = "0 Left"
        '
        'btndatacheck
        '
        Me.btndatacheck.Location = New System.Drawing.Point(6, 14)
        Me.btndatacheck.Name = "btndatacheck"
        Me.btndatacheck.Size = New System.Drawing.Size(150, 26)
        Me.btndatacheck.TabIndex = 0
        Me.btndatacheck.Text = "Data Check"
        Me.btndatacheck.UseVisualStyleBackColor = True
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Location = New System.Drawing.Point(475, 27)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(79, 13)
        Me.lbltime.TabIndex = 21
        Me.lbltime.Text = "Time Estimate: "
        '
        'txtdone
        '
        Me.txtdone.Location = New System.Drawing.Point(368, 139)
        Me.txtdone.Multiline = True
        Me.txtdone.Name = "txtdone"
        Me.txtdone.ReadOnly = True
        Me.txtdone.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdone.Size = New System.Drawing.Size(166, 56)
        Me.txtdone.TabIndex = 22
        Me.txtdone.Text = "000 Data Check"
        '
        'txtextras
        '
        Me.txtextras.Location = New System.Drawing.Point(540, 139)
        Me.txtextras.Multiline = True
        Me.txtextras.Name = "txtextras"
        Me.txtextras.ReadOnly = True
        Me.txtextras.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtextras.Size = New System.Drawing.Size(165, 56)
        Me.txtextras.TabIndex = 23
        Me.txtextras.Text = "Data Check - Duplicate Items"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(358, 24)
        Me.MenuStrip1.TabIndex = 24
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HideAdvancedOptionsToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'HideAdvancedOptionsToolStripMenuItem
        '
        Me.HideAdvancedOptionsToolStripMenuItem.Enabled = False
        Me.HideAdvancedOptionsToolStripMenuItem.Name = "HideAdvancedOptionsToolStripMenuItem"
        Me.HideAdvancedOptionsToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.HideAdvancedOptionsToolStripMenuItem.Text = "Hide Advanced Options"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.OptionsToolStripMenuItem.Text = "Show Advanced Options"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHelpToolStripMenuItem, Me.SubmitSuggestionToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ViewHelpToolStripMenuItem
        '
        Me.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
        Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ViewHelpToolStripMenuItem.Text = "View Help"
        '
        'SubmitSuggestionToolStripMenuItem
        '
        Me.SubmitSuggestionToolStripMenuItem.Name = "SubmitSuggestionToolStripMenuItem"
        Me.SubmitSuggestionToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.SubmitSuggestionToolStripMenuItem.Text = "Connections Page"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'gbadvanced
        '
        Me.gbadvanced.Controls.Add(Me.txtStartLoc)
        Me.gbadvanced.Controls.Add(Me.Label6)
        Me.gbadvanced.Controls.Add(Me.cbsort)
        Me.gbadvanced.Controls.Add(Me.Label9)
        Me.gbadvanced.Controls.Add(Me.cbmiadefault)
        Me.gbadvanced.Controls.Add(Me.Label8)
        Me.gbadvanced.Controls.Add(Me.Label7)
        Me.gbadvanced.Controls.Add(Me.txtlbltime)
        Me.gbadvanced.Location = New System.Drawing.Point(540, 198)
        Me.gbadvanced.Name = "gbadvanced"
        Me.gbadvanced.Size = New System.Drawing.Size(165, 101)
        Me.gbadvanced.TabIndex = 25
        Me.gbadvanced.TabStop = False
        Me.gbadvanced.Text = "Advanced Options"
        '
        'txtStartLoc
        '
        Me.txtStartLoc.Location = New System.Drawing.Point(104, 75)
        Me.txtStartLoc.MaxLength = 3
        Me.txtStartLoc.Name = "txtStartLoc"
        Me.txtStartLoc.Size = New System.Drawing.Size(36, 20)
        Me.txtStartLoc.TabIndex = 7
        Me.txtStartLoc.Text = "1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Start location"
        '
        'cbsort
        '
        Me.cbsort.AutoSize = True
        Me.cbsort.Location = New System.Drawing.Point(104, 62)
        Me.cbsort.Name = "cbsort"
        Me.cbsort.Size = New System.Drawing.Size(15, 14)
        Me.cbsort.TabIndex = 5
        Me.cbsort.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Do not sort"
        '
        'cbmiadefault
        '
        Me.cbmiadefault.AutoSize = True
        Me.cbmiadefault.Location = New System.Drawing.Point(104, 42)
        Me.cbmiadefault.Name = "cbmiadefault"
        Me.cbmiadefault.Size = New System.Drawing.Size(15, 14)
        Me.cbmiadefault.TabIndex = 3
        Me.cbmiadefault.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Missing Default"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Delay in ms"
        '
        'txtlbltime
        '
        Me.txtlbltime.Location = New System.Drawing.Point(104, 14)
        Me.txtlbltime.MaxLength = 3
        Me.txtlbltime.Name = "txtlbltime"
        Me.txtlbltime.Size = New System.Drawing.Size(36, 20)
        Me.txtlbltime.TabIndex = 0
        Me.txtlbltime.Text = "500"
        '
        'gbpricing
        '
        Me.gbpricing.Controls.Add(Me.btnactivate)
        Me.gbpricing.Location = New System.Drawing.Point(6, 46)
        Me.gbpricing.Name = "gbpricing"
        Me.gbpricing.Size = New System.Drawing.Size(150, 39)
        Me.gbpricing.TabIndex = 26
        Me.gbpricing.TabStop = False
        Me.gbpricing.Text = "Pricing"
        Me.gbpricing.Visible = False
        '
        'btnactivate
        '
        Me.btnactivate.Location = New System.Drawing.Point(6, 13)
        Me.btnactivate.Name = "btnactivate"
        Me.btnactivate.Size = New System.Drawing.Size(138, 23)
        Me.btnactivate.TabIndex = 0
        Me.btnactivate.Text = "5.10.3 per policy"
        Me.btnactivate.UseVisualStyleBackColor = True
        '
        'tupdate
        '
        Me.tupdate.Enabled = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btndatacheck)
        Me.GroupBox4.Controls.Add(Me.gbpricing)
        Me.GroupBox4.Location = New System.Drawing.Point(368, 198)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(166, 101)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Other"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "POG PDF|*.pdf"
        Me.OpenFileDialog1.Title = "Open POG PDF"
        '
        'lblpog
        '
        Me.lblpog.AutoSize = True
        Me.lblpog.Location = New System.Drawing.Point(12, 24)
        Me.lblpog.Name = "lblpog"
        Me.lblpog.Size = New System.Drawing.Size(36, 13)
        Me.lblpog.TabIndex = 28
        Me.lblpog.Text = "POG: "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 308)
        Me.Controls.Add(Me.lblpog)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.gbadvanced)
        Me.Controls.Add(Me.txtextras)
        Me.Controls.Add(Me.txtdone)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gblabels)
        Me.Controls.Add(Me.gblocate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Label Maker"
        Me.gblocate.ResumeLayout(False)
        Me.gblocate.PerformLayout()
        Me.gblabels.ResumeLayout(False)
        Me.gblabels.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbadvanced.ResumeLayout(False)
        Me.gbadvanced.PerformLayout()
        Me.gbpricing.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents btnlocatepog As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAisle As System.Windows.Forms.TextBox
    Friend WithEvents txtBay As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnlabelpog As System.Windows.Forms.Button
    Friend WithEvents txtbin As System.Windows.Forms.TextBox
    Friend WithEvents txtBeam As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gblocate As System.Windows.Forms.GroupBox
    Friend WithEvents gblabels As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents cbitemsnof As System.Windows.Forms.CheckBox
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btndatacheck As System.Windows.Forms.Button
    Friend WithEvents txtdone As System.Windows.Forms.TextBox
    Friend WithEvents txtextras As System.Windows.Forms.TextBox
    Friend WithEvents lblcount As System.Windows.Forms.Label
    Friend WithEvents txtstop As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HideAdvancedOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gbadvanced As System.Windows.Forms.GroupBox
    Friend WithEvents txtlbltime As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents gbpricing As System.Windows.Forms.GroupBox
    Friend WithEvents btnactivate As System.Windows.Forms.Button
    Friend WithEvents cbmiadefault As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbsort As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tupdate As System.Windows.Forms.Timer
    Friend WithEvents SubmitSuggestionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbdefault As System.Windows.Forms.CheckBox
    Friend WithEvents cbpogdefault As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cboxbay As System.Windows.Forms.ComboBox
    Friend WithEvents btnindexload As System.Windows.Forms.Button
    Friend WithEvents btnpdfread As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnallpog As System.Windows.Forms.Button
    Friend WithEvents lblpog As System.Windows.Forms.Label
    Friend WithEvents txtStartLoc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
