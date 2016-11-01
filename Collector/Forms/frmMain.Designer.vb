<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.menuMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSNMPTimeout = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSNMPPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIPAddress = New System.Windows.Forms.TextBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.statusbar = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnScan = New System.Windows.Forms.Button()
        Me.menuMain.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuMain
        '
        Me.menuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menuMain.Location = New System.Drawing.Point(0, 0)
        Me.menuMain.Name = "menuMain"
        Me.menuMain.Size = New System.Drawing.Size(342, 24)
        Me.menuMain.TabIndex = 0
        Me.menuMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtSNMPTimeout)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSNMPPassword)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtIPAddress)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 128)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Device Information"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "SNMP Timeout (ms)"
        '
        'txtSNMPTimeout
        '
        Me.txtSNMPTimeout.Location = New System.Drawing.Point(210, 78)
        Me.txtSNMPTimeout.MaxLength = 5
        Me.txtSNMPTimeout.Name = "txtSNMPTimeout"
        Me.txtSNMPTimeout.Size = New System.Drawing.Size(92, 22)
        Me.txtSNMPTimeout.TabIndex = 4
        Me.txtSNMPTimeout.Text = "2000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SNMP Password"
        '
        'txtSNMPPassword
        '
        Me.txtSNMPPassword.Location = New System.Drawing.Point(210, 50)
        Me.txtSNMPPassword.MaxLength = 16
        Me.txtSNMPPassword.Name = "txtSNMPPassword"
        Me.txtSNMPPassword.Size = New System.Drawing.Size(92, 22)
        Me.txtSNMPPassword.TabIndex = 2
        Me.txtSNMPPassword.Text = "public"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IP Address"
        '
        'txtIPAddress
        '
        Me.txtIPAddress.Location = New System.Drawing.Point(153, 22)
        Me.txtIPAddress.MaxLength = 16
        Me.txtIPAddress.Name = "txtIPAddress"
        Me.txtIPAddress.Size = New System.Drawing.Size(149, 22)
        Me.txtIPAddress.TabIndex = 0
        Me.txtIPAddress.Text = "192.168.1.1"
        '
        'btnStop
        '
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.btnStop.Image = CType(resources.GetObject("btnStop.Image"), System.Drawing.Image)
        Me.btnStop.Location = New System.Drawing.Point(182, 161)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(148, 101)
        Me.btnStop.TabIndex = 3
        Me.btnStop.Text = "Stop Scan"
        Me.btnStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusbar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 269)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(342, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statusbar
        '
        Me.statusbar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.statusbar.Name = "statusbar"
        Me.statusbar.Size = New System.Drawing.Size(327, 17)
        Me.statusbar.Spring = True
        Me.statusbar.Text = "Application Ready ..."
        Me.statusbar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnScan
        '
        Me.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnScan.Image = Global.Collector.My.Resources.Resources.icon_scan
        Me.btnScan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnScan.Location = New System.Drawing.Point(12, 161)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(148, 101)
        Me.btnScan.TabIndex = 2
        Me.btnScan.Text = "Scan Device"
        Me.btnScan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnScan.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 291)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnScan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.menuMain)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuMain
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Collector"
        Me.menuMain.ResumeLayout(False)
        Me.menuMain.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuMain As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSNMPTimeout As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSNMPPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIPAddress As TextBox
    Friend WithEvents btnScan As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents statusbar As ToolStripStatusLabel
End Class
