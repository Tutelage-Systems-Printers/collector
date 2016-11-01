Public Class frmDevice

    Private Sub SaveFile(ByVal FileName As String, ByVal Device As Device_Definition)
        Dim objWriter As New System.IO.StreamWriter(FileName)

        objWriter.WriteLine("Printer Data Software: " & ProductName)
        objWriter.WriteLine("Version: " & ProductVersion)
        objWriter.WriteLine("Scan Date: " & Date.Today.ToString())
        objWriter.WriteLine("--------------------------------------------------------------------------------")
        objWriter.WriteLine("Other Information")
        objWriter.WriteLine(txt_Notes.Text)
        objWriter.WriteLine("--------------------------------------------------------------------------------")
        objWriter.WriteLine("Device Information")
        objWriter.WriteLine("Public IP Address   : " & Device.General_Public_IP_Address)
        objWriter.WriteLine("Manufacture         : " & Device.General_Manufacture)
        objWriter.WriteLine("Model               : " & Device.General_Model)
        objWriter.WriteLine("Serial Number       : " & Device.General_Serial_Number)
        objWriter.WriteLine("----------------------------------------")
        objWriter.WriteLine("Counter Mono Total  : " & Device.Counter_Mono_Total)
        objWriter.WriteLine("Counter Color Total : " & Device.Counter_Color_Total)
        objWriter.WriteLine("Counter Total       : " & Device.Counter_Total)
        objWriter.WriteLine("----------------------------------------")
        objWriter.WriteLine("Is Color Device     : " & Device.General_Is_Color)
        objWriter.WriteLine("Supplies Black      : " & Device.Supplies_Black_Level)
        objWriter.WriteLine("Cartridge Black     : " & Device.Supplies_Black_Cartridge)
        objWriter.WriteLine("Supplies Cyan       : " & Device.Supplies_Cyan_Level)
        objWriter.WriteLine("Cartridge Cyan      : " & Device.Supplies_Cyan_Cartridge)
        objWriter.WriteLine("Supplies Magenta    : " & Device.Supplies_Magenta_Level)
        objWriter.WriteLine("Cartridge Magenta   : " & Device.Supplies_Magenta_Cartridge)
        objWriter.WriteLine("Supplies Yellow     : " & Device.Supplies_Yellow_Level)
        objWriter.WriteLine("Cartridge Yellow    : " & Device.Supplies_Yellow_Cartridge)
        objWriter.WriteLine("--------------------------------------------------------------------------------")

        Dim oid_result As MIB_Definition
        For Each oid_result In col_MibResults
            objWriter.WriteLine(oid_result.oid & ":" & oid_result.value)
        Next

        objWriter.Close()
    End Sub

#Region "Action Buttons"

    Private Sub cmd_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Save.Click

        ' Throw Information Into a Definition
        Dim device_information As New Device_Definition

        device_information.General_Manufacture = txt_Manufacturer.Text
        device_information.General_Model = txt_ModelName.Text
        device_information.General_Serial_Number = txt_SerialNumber.Text
        device_information.General_Public_IP_Address = txt_PublicIPAddress.Text
        device_information.General_Is_Color = txt_IsColourDevice.Text
        device_information.Supplies_Black_Level = txt_Toner_Black_Level.Text
        device_information.Supplies_Black_Cartridge = txt_Toner_Black_Cartridge.Text
        device_information.Supplies_Cyan_Level = txt_Toner_Cyan_Level.Text
        device_information.Supplies_Cyan_Cartridge = txt_Toner_Cyan_Cartridge.Text
        device_information.Supplies_Magenta_Level = txt_Toner_Magenta_Level.Text
        device_information.Supplies_Magenta_Cartridge = txt_Toner_Magenta_Cartridge.Text
        device_information.Supplies_Yellow_Level = txt_Toner_Yellow_Level.Text
        device_information.Supplies_Yellow_Cartridge = txt_Toner_Yellow_Cartridge.Text
        device_information.Counter_Total = txt_Counter_Total.Text
        device_information.Counter_Mono_Total = txt_Counter_Mono.Text
        device_information.Counter_Color_Total = txt_Counter_Colour.Text

        ' Validate MIB Results
        If col_MibResults.Count <= 0 Then
            MessageBox.Show("No Results have been found.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Exit Sub
            Exit Sub
        End If



        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.AddExtension = True
        saveFileDialog.DefaultExt = ".mib.txt"
        saveFileDialog.Filter = "MIB Files|*.mib.txt"
        saveFileDialog.OverwritePrompt = True
        saveFileDialog.Title = "Save Device Query Results"
        ' Assign Default Filename (Based on Input by user)
        saveFileDialog.FileName = device_information.General_Manufacture & "." & device_information.General_Model
        If saveFileDialog.ShowDialog(Me) = DialogResult.OK Then
            SaveFile(saveFileDialog.FileName, device_information)

            Me.Close()
        End If
    End Sub

    Private Sub cmd_Upload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Upload.Click
        ' Save File
        ' Throw Information Into a Definition
        Dim device_information As New Device_Definition

        device_information.General_Manufacture = txt_Manufacturer.Text
        device_information.General_Model = txt_ModelName.Text
        device_information.General_Serial_Number = txt_SerialNumber.Text
        device_information.General_Public_IP_Address = txt_PublicIPAddress.Text
        device_information.General_Is_Color = txt_IsColourDevice.Text
        device_information.Supplies_Black_Level = txt_Toner_Black_Level.Text
        device_information.Supplies_Black_Cartridge = txt_Toner_Black_Cartridge.Text
        device_information.Supplies_Cyan_Level = txt_Toner_Cyan_Level.Text
        device_information.Supplies_Cyan_Cartridge = txt_Toner_Cyan_Cartridge.Text
        device_information.Supplies_Magenta_Level = txt_Toner_Magenta_Level.Text
        device_information.Supplies_Magenta_Cartridge = txt_Toner_Magenta_Cartridge.Text
        device_information.Supplies_Yellow_Level = txt_Toner_Yellow_Level.Text
        device_information.Supplies_Yellow_Cartridge = txt_Toner_Yellow_Cartridge.Text
        device_information.Counter_Total = txt_Counter_Total.Text
        device_information.Counter_Mono_Total = txt_Counter_Mono.Text
        device_information.Counter_Color_Total = txt_Counter_Colour.Text

        Dim tmpFileName As String = System.IO.Path.GetTempPath & "/" & device_information.General_Manufacture & "." & device_information.General_Model & ".mib.txt"

        SaveFile(tmpFileName, device_information)

        Dim url As String = "http://www.printerdatasoftware.com/upload_printer.php"
        Dim boundary As String = IO.Path.GetRandomFileName
        Dim header As New System.Text.StringBuilder()
        header.AppendLine("--" & boundary)
        header.Append("Content-Disposition: form-data; name=""uploaded_file"";")
        header.AppendFormat("filename=""{0}""", IO.Path.GetFileName(tmpFileName))
        header.AppendLine()
        header.AppendLine("Content-Type: application/octet-stream")
        header.AppendLine()

        Dim headerbytes() As Byte = System.Text.Encoding.UTF8.GetBytes(header.ToString)
        Dim endboundarybytes() As Byte = System.Text.Encoding.ASCII.GetBytes(vbNewLine & "--" & boundary & "--" & vbNewLine)

        Dim req As Net.HttpWebRequest = Net.HttpWebRequest.Create(url)
        req.ContentType = "multipart/form-data; boundary=" & boundary
        req.ContentLength = headerbytes.Length + New IO.FileInfo(tmpFileName).Length + endboundarybytes.Length
        req.Method = "POST"

        Dim s As IO.Stream = req.GetRequestStream
        s.Write(headerbytes, 0, headerbytes.Length)
        Dim filebytes() As Byte = My.Computer.FileSystem.ReadAllBytes(tmpFileName)
        s.Write(filebytes, 0, filebytes.Length)
        s.Write(endboundarybytes, 0, endboundarybytes.Length)
        s.Close()

        MessageBox.Show("Your file has been uploaded successfully", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub cmd_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Cancel.Click
        Me.Close()
    End Sub

#End Region



    Private Sub frmDevice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Fill in some General Information
        txt_PublicIPAddress.Text = s_DeviceIPAddress

        ' Try to guess at the information
        txt_ModelName.Text = getModelName()
        txt_SerialNumber.Text = getSerialNumber()

        txt_ModelName.Focus()
    End Sub

    Private Function getModelName() As String
        Dim oid_result As MIB_Definition
        Dim value As String = ""

        For Each oid_result In col_MibResults
            If oid_result.oid = "1.3.6.1.2.1.25.3.2.1.3.1" Then
                value = oid_result.value.ToString.Trim
                Exit For
            End If
        Next

        Return value
    End Function

    Private Function getSerialNumber() As String
        Dim oid_result As MIB_Definition
        Dim value As String = ""

        For Each oid_result In col_MibResults
            If oid_result.oid = "1.3.6.1.2.1.43.5.1.1.17.1" Then
                value = oid_result.value.ToString.Trim
                Exit For
            End If
        Next

        Return value
    End Function
End Class