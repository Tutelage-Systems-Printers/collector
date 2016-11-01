Public Class frmMain

    ' Tells the program if a scan is running
    Private bln_ScanIsRunning As Boolean = False
    ' Threads
    Private thread_Engine As New Threading.Thread(AddressOf StartScanEngine)
    ' Scanner Engine
    Private WithEvents engine_Scanner As Engine
    ' Delegates
    Private Delegate Sub engineInvoked_UpdateStatus(ByVal message As String)
    Private Delegate Sub engineInvoked_SNMPError(ByVal message As String)
    Private Delegate Sub engineInvoked_Complete()

#Region "Menu"

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim s_message As String = Application.ProductName & vbNewLine & vbNewLine & "Version: " & Application.ProductVersion & vbNewLine & vbNewLine & Application.CompanyName

        MessageBox.Show(s_message, "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

#End Region

    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        s_DeviceIPAddress = txtIPAddress.Text

        StartScan()
    End Sub

#Region "Subprocedures"
    Private Sub StartScan()
        Dim device_ip_address As Net.IPAddress
        Dim device_community_string As String = txtSNMPPassword.Text
        Dim device_timeout As String = txtSNMPTimeout.Text

        ' Validate IP Address
        Try
            Dim ip_address As String = txtIPAddress.Text
            device_ip_address = Net.IPAddress.Parse(ip_address)
        Catch
            MessageBox.Show("Invalid Device IP Address", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Focus On IP Address
            txtIPAddress.Focus()
            ' Exit Sub
            Exit Sub
        End Try

        ' Disable Scan Button
        btnScan.Enabled = False
        ' Enable Cancel Button
        btnStop.Enabled = True

        engine_Scanner = New Engine(device_ip_address, device_community_string, device_timeout)
        thread_Engine = New Threading.Thread(AddressOf StartScanEngine)
        thread_Engine.Start()
    End Sub

    Private Sub StartScanEngine()
        bln_ScanIsRunning = True
        engine_Scanner.Scan()
    End Sub
#End Region

#Region "Delegates"
    Private Sub engine_UpdateStatus(ByVal message As String) Handles engine_Scanner.UpdateStatus
        If Me.InvokeRequired Then
            ' Make variable to hold parameters
            Dim parameter As New Object
            parameter = message

            ' Run Delegate
            Dim run_delegate As New engineInvoked_UpdateStatus(AddressOf engine_UpdateStatus)
            Me.Invoke(run_delegate, parameter)
        Else
            statusbar.Text = message
        End If
    End Sub

    Private Sub engine_SNMPError(ByVal message As String) Handles engine_Scanner.SNMPError
        If Me.InvokeRequired Then
            ' Make variable to hold parameters
            Dim parameter As New Object
            parameter = message

            ' Run Delegate
            Dim run_delegate As New engineInvoked_SNMPError(AddressOf engine_SNMPError)
            Me.Invoke(run_delegate, parameter)
        Else
            statusbar.Text = message
            btnScan.Enabled = True
            btnStop.Enabled = False
        End If
    End Sub

    Private Sub engine_Complete() Handles engine_Scanner.Complete
        If Me.InvokeRequired Then

            ' Run Delegate
            Dim run_delegate As New engineInvoked_Complete(AddressOf engine_Complete)
            Me.Invoke(run_delegate)
        Else
            ' Save MIB List
            col_MibResults = engine_Scanner.col_Mib_Results
            ' Tell the Program we are no longer running a scan
            bln_ScanIsRunning = False
            ' Enable Scan Button
            btnScan.Enabled = True
            ' Disable Cancel Button
            btnStop.Enabled = False

            ' Validate Results
            If col_MibResults.Count <= 0 Then
                ' Update Status
                statusbar.Text = "Could Not Contact Device Using IP Address/Community String"
            Else
                ' Update Status
                statusbar.Text = "Scan Completed Successful, " & col_MibResults.Count & " Scanned."
            End If

            ' Play Sound
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)

            ' Open Device Form
            Dim frmDeviceInformation As New frmDevice
            frmDeviceInformation.Show(Me)
        End If
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        engine_Scanner.bln_scanAbort = True
    End Sub

#End Region

End Class
