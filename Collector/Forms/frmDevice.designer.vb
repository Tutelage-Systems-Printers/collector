<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevice))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_PublicIPAddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_SerialNumber = New System.Windows.Forms.TextBox()
        Me.txt_Manufacturer = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ModelName = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_Toner_Yellow_Cartridge = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_Toner_Yellow_Level = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_Toner_Magenta_Cartridge = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_Toner_Magenta_Level = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_Toner_Cyan_Cartridge = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_Toner_Cyan_Level = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Toner_Black_Cartridge = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Toner_Black_Level = New System.Windows.Forms.TextBox()
        Me.txt_IsColourDevice = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_Counter_Mono = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_Counter_Colour = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_Counter_Total = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_Notes = New System.Windows.Forms.TextBox()
        Me.cmd_Cancel = New System.Windows.Forms.Button()
        Me.cmd_Upload = New System.Windows.Forms.Button()
        Me.cmd_Save = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_PublicIPAddress)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_SerialNumber)
        Me.GroupBox1.Controls.Add(Me.txt_Manufacturer)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_ModelName)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 125)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Device Information"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Public IP Address"
        '
        'txt_PublicIPAddress
        '
        Me.txt_PublicIPAddress.Location = New System.Drawing.Point(126, 97)
        Me.txt_PublicIPAddress.Name = "txt_PublicIPAddress"
        Me.txt_PublicIPAddress.Size = New System.Drawing.Size(158, 22)
        Me.txt_PublicIPAddress.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Serial Number"
        '
        'txt_SerialNumber
        '
        Me.txt_SerialNumber.Location = New System.Drawing.Point(126, 71)
        Me.txt_SerialNumber.Name = "txt_SerialNumber"
        Me.txt_SerialNumber.Size = New System.Drawing.Size(158, 22)
        Me.txt_SerialNumber.TabIndex = 5
        '
        'txt_Manufacturer
        '
        Me.txt_Manufacturer.FormattingEnabled = True
        Me.txt_Manufacturer.Items.AddRange(New Object() {"Brother", "Canon", "Dell", "Epson", "Hewlett Packard", "Lexmark", "Panasonic", "Ricoh", "Samsung", "Sharp", "Toshiba", "Xerox"})
        Me.txt_Manufacturer.Location = New System.Drawing.Point(126, 44)
        Me.txt_Manufacturer.Name = "txt_Manufacturer"
        Me.txt_Manufacturer.Size = New System.Drawing.Size(158, 24)
        Me.txt_Manufacturer.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Manufacturer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Model Name"
        '
        'txt_ModelName
        '
        Me.txt_ModelName.Location = New System.Drawing.Point(126, 18)
        Me.txt_ModelName.Name = "txt_ModelName"
        Me.txt_ModelName.Size = New System.Drawing.Size(158, 22)
        Me.txt_ModelName.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txt_Toner_Yellow_Cartridge)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txt_Toner_Yellow_Level)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txt_Toner_Magenta_Cartridge)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txt_Toner_Magenta_Level)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txt_Toner_Cyan_Cartridge)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txt_Toner_Cyan_Level)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_Toner_Black_Cartridge)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_Toner_Black_Level)
        Me.GroupBox2.Controls.Add(Me.txt_IsColourDevice)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 143)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(293, 253)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Toner Information"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 231)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 16)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Yellow Cartridge"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(158, 205)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(20, 16)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "%"
        '
        'txt_Toner_Yellow_Cartridge
        '
        Me.txt_Toner_Yellow_Cartridge.Location = New System.Drawing.Point(126, 228)
        Me.txt_Toner_Yellow_Cartridge.Name = "txt_Toner_Yellow_Cartridge"
        Me.txt_Toner_Yellow_Cartridge.Size = New System.Drawing.Size(158, 22)
        Me.txt_Toner_Yellow_Cartridge.TabIndex = 21
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 205)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 16)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Yellow Level"
        '
        'txt_Toner_Yellow_Level
        '
        Me.txt_Toner_Yellow_Level.Location = New System.Drawing.Point(126, 202)
        Me.txt_Toner_Yellow_Level.MaxLength = 3
        Me.txt_Toner_Yellow_Level.Name = "txt_Toner_Yellow_Level"
        Me.txt_Toner_Yellow_Level.Size = New System.Drawing.Size(26, 22)
        Me.txt_Toner_Yellow_Level.TabIndex = 18
        Me.txt_Toner_Yellow_Level.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 179)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 16)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Magenta Cartridge"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(158, 153)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 16)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "%"
        '
        'txt_Toner_Magenta_Cartridge
        '
        Me.txt_Toner_Magenta_Cartridge.Location = New System.Drawing.Point(126, 176)
        Me.txt_Toner_Magenta_Cartridge.Name = "txt_Toner_Magenta_Cartridge"
        Me.txt_Toner_Magenta_Cartridge.Size = New System.Drawing.Size(158, 22)
        Me.txt_Toner_Magenta_Cartridge.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 153)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 16)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Magenta Level"
        '
        'txt_Toner_Magenta_Level
        '
        Me.txt_Toner_Magenta_Level.Location = New System.Drawing.Point(126, 150)
        Me.txt_Toner_Magenta_Level.MaxLength = 3
        Me.txt_Toner_Magenta_Level.Name = "txt_Toner_Magenta_Level"
        Me.txt_Toner_Magenta_Level.Size = New System.Drawing.Size(26, 22)
        Me.txt_Toner_Magenta_Level.TabIndex = 13
        Me.txt_Toner_Magenta_Level.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Cyan Cartridge"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(158, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 16)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "%"
        '
        'txt_Toner_Cyan_Cartridge
        '
        Me.txt_Toner_Cyan_Cartridge.Location = New System.Drawing.Point(126, 124)
        Me.txt_Toner_Cyan_Cartridge.Name = "txt_Toner_Cyan_Cartridge"
        Me.txt_Toner_Cyan_Cartridge.Size = New System.Drawing.Size(158, 22)
        Me.txt_Toner_Cyan_Cartridge.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 16)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Cyan Level"
        '
        'txt_Toner_Cyan_Level
        '
        Me.txt_Toner_Cyan_Level.Location = New System.Drawing.Point(126, 98)
        Me.txt_Toner_Cyan_Level.MaxLength = 3
        Me.txt_Toner_Cyan_Level.Name = "txt_Toner_Cyan_Level"
        Me.txt_Toner_Cyan_Level.Size = New System.Drawing.Size(26, 22)
        Me.txt_Toner_Cyan_Level.TabIndex = 8
        Me.txt_Toner_Cyan_Level.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 16)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Black Cartridge"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(158, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "%"
        '
        'txt_Toner_Black_Cartridge
        '
        Me.txt_Toner_Black_Cartridge.Location = New System.Drawing.Point(126, 72)
        Me.txt_Toner_Black_Cartridge.Name = "txt_Toner_Black_Cartridge"
        Me.txt_Toner_Black_Cartridge.Size = New System.Drawing.Size(158, 22)
        Me.txt_Toner_Black_Cartridge.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Black Level"
        '
        'txt_Toner_Black_Level
        '
        Me.txt_Toner_Black_Level.Location = New System.Drawing.Point(126, 46)
        Me.txt_Toner_Black_Level.MaxLength = 3
        Me.txt_Toner_Black_Level.Name = "txt_Toner_Black_Level"
        Me.txt_Toner_Black_Level.Size = New System.Drawing.Size(26, 22)
        Me.txt_Toner_Black_Level.TabIndex = 3
        Me.txt_Toner_Black_Level.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_IsColourDevice
        '
        Me.txt_IsColourDevice.FormattingEnabled = True
        Me.txt_IsColourDevice.Items.AddRange(New Object() {"No", "Yes"})
        Me.txt_IsColourDevice.Location = New System.Drawing.Point(126, 19)
        Me.txt_IsColourDevice.Name = "txt_IsColourDevice"
        Me.txt_IsColourDevice.Size = New System.Drawing.Size(158, 24)
        Me.txt_IsColourDevice.TabIndex = 1
        Me.txt_IsColourDevice.Text = "No"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Colour Device"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_Counter_Mono)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txt_Counter_Colour)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.txt_Counter_Total)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 402)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(293, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Usage Information"
        '
        'txt_Counter_Mono
        '
        Me.txt_Counter_Mono.Location = New System.Drawing.Point(126, 45)
        Me.txt_Counter_Mono.Name = "txt_Counter_Mono"
        Me.txt_Counter_Mono.Size = New System.Drawing.Size(158, 22)
        Me.txt_Counter_Mono.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 75)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(115, 16)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Colour Pagecount"
        '
        'txt_Counter_Colour
        '
        Me.txt_Counter_Colour.Location = New System.Drawing.Point(126, 71)
        Me.txt_Counter_Colour.Name = "txt_Counter_Colour"
        Me.txt_Counter_Colour.Size = New System.Drawing.Size(158, 22)
        Me.txt_Counter_Colour.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 48)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(110, 16)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Mono Pagecount"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 22)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(107, 16)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Total Pagecount"
        '
        'txt_Counter_Total
        '
        Me.txt_Counter_Total.Location = New System.Drawing.Point(126, 18)
        Me.txt_Counter_Total.Name = "txt_Counter_Total"
        Me.txt_Counter_Total.Size = New System.Drawing.Size(158, 22)
        Me.txt_Counter_Total.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_Notes)
        Me.GroupBox4.Location = New System.Drawing.Point(311, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(268, 384)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Other Information"
        '
        'txt_Notes
        '
        Me.txt_Notes.Location = New System.Drawing.Point(9, 19)
        Me.txt_Notes.Multiline = True
        Me.txt_Notes.Name = "txt_Notes"
        Me.txt_Notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Notes.Size = New System.Drawing.Size(251, 359)
        Me.txt_Notes.TabIndex = 0
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.Image = Global.Collector.My.Resources.Resources.icon_cancel
        Me.cmd_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Cancel.Location = New System.Drawing.Point(495, 439)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(84, 39)
        Me.cmd_Cancel.TabIndex = 6
        Me.cmd_Cancel.Text = "Cancel"
        Me.cmd_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Cancel.UseVisualStyleBackColor = True
        '
        'cmd_Upload
        '
        Me.cmd_Upload.Enabled = False
        Me.cmd_Upload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmd_Upload.Image = Global.Collector.My.Resources.Resources.icon_upload
        Me.cmd_Upload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Upload.Location = New System.Drawing.Point(405, 439)
        Me.cmd_Upload.Name = "cmd_Upload"
        Me.cmd_Upload.Size = New System.Drawing.Size(84, 39)
        Me.cmd_Upload.TabIndex = 5
        Me.cmd_Upload.Text = "Upload"
        Me.cmd_Upload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Upload.UseVisualStyleBackColor = True
        '
        'cmd_Save
        '
        Me.cmd_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmd_Save.Image = CType(resources.GetObject("cmd_Save.Image"), System.Drawing.Image)
        Me.cmd_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Save.Location = New System.Drawing.Point(315, 439)
        Me.cmd_Save.Name = "cmd_Save"
        Me.cmd_Save.Size = New System.Drawing.Size(84, 39)
        Me.cmd_Save.TabIndex = 4
        Me.cmd_Save.Text = "Save"
        Me.cmd_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Save.UseVisualStyleBackColor = True
        '
        'frmDevice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 510)
        Me.Controls.Add(Me.cmd_Cancel)
        Me.Controls.Add(Me.cmd_Upload)
        Me.Controls.Add(Me.cmd_Save)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDevice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Device Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Toner_Black_Cartridge As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_Toner_Black_Level As System.Windows.Forms.TextBox
    Friend WithEvents txt_IsColourDevice As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_PublicIPAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_SerialNumber As System.Windows.Forms.TextBox
    Friend WithEvents txt_Manufacturer As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_ModelName As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_Toner_Yellow_Cartridge As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_Toner_Yellow_Level As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_Toner_Magenta_Cartridge As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_Toner_Magenta_Level As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_Toner_Cyan_Cartridge As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_Toner_Cyan_Level As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Counter_Mono As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_Counter_Colour As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txt_Counter_Total As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Notes As System.Windows.Forms.TextBox
    Friend WithEvents cmd_Save As System.Windows.Forms.Button
    Friend WithEvents cmd_Upload As System.Windows.Forms.Button
    Friend WithEvents cmd_Cancel As System.Windows.Forms.Button
End Class
