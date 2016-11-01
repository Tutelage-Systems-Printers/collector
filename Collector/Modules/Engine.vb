Public Class Engine
    ' Public Variables
    Public bln_scanAbort As Boolean = False
    Public col_Mib_Results As New Collection

    ' Private Variables
    Private device_ip_address As Net.IPAddress
    Private device_community_string As String
    Private device_timeout As String
    Private device_reties As Integer = 1

    ' Events
    Public Event UpdateStatus(ByVal message As String)
    Public Event SNMPError(ByVal message As String)
    Public Event Complete()

    Public Sub New(ByVal ip_address As Net.IPAddress, ByVal community_string As String, ByVal timeout As String)
        device_ip_address = ip_address
        device_community_string = community_string
        device_timeout = timeout
    End Sub

    Public Sub Scan()
        ' Tells the software when the scan is complete
        Dim bln_scanComplete As Boolean = False
        ' Results of the Oid Query
        Dim oid_results As Dictionary(Of SnmpSharpNet.Oid, SnmpSharpNet.AsnType)
        ' Oid to Start At
        Dim oid_start As SnmpSharpNet.Oid = New SnmpSharpNet.Oid("1.3.6")
        ' Next Oid
        Dim oid_next As SnmpSharpNet.Oid = oid_start

        ' Send Status
        RaiseEvent UpdateStatus("Starting Scan")

        ' Create the SNMP Client to Scan
        Dim snmp As New SnmpSharpNet.SimpleSnmp(device_ip_address.ToString, 161, device_community_string, device_timeout, device_reties)


        If Not snmp.Valid Then
            RaiseEvent SNMPError("Device IP Address and/or Community String is invalid")
        End If

        While bln_scanComplete = False
            If bln_scanAbort Then
                Exit While
            End If

            oid_results = snmp.GetNext(SnmpSharpNet.SnmpVersion.Ver1, New String() {oid_next.ToString})
            ' Validate Results
            If oid_results IsNot Nothing Then
                Dim kvp As KeyValuePair(Of SnmpSharpNet.Oid, SnmpSharpNet.AsnType)

                For Each kvp In oid_results
                    ' Check to see if we need to keep going
                    If oid_start.IsRootOf(kvp.Key) Then
                        RaiseEvent UpdateStatus("Scanning ... Current Count: " & col_Mib_Results.Count)

                        Dim oid_result As New MIB_Definition
                        oid_result.oid = kvp.Key.ToString
                        oid_result.value = kvp.Value.ToString

                        col_Mib_Results.Add(oid_result)

                        ' Set next oid
                        oid_next = kvp.Key
                    Else
                        bln_scanComplete = True
                    End If
                Next
            Else
                bln_scanComplete = True
            End If
        End While

        If col_Mib_Results.Count > 0 Then
            RaiseEvent Complete()
        Else
            RaiseEvent SNMPError("Count not contact Device")
        End If
    End Sub

End Class
