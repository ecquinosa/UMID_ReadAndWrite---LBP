Public Class SharedFunction

    Const MsgHeader = "UMID - READ AND WRITE"

    Public Shared Function ShowMessage(ByVal strMsg As String, Optional ByVal msgBoxBtn As MessageBoxButtons = MessageBoxButtons.YesNo, Optional ByVal msgBoxIcn As MessageBoxIcon = MessageBoxIcon.Question) As DialogResult
        Return MessageBox.Show(strMsg, MsgHeader, msgBoxBtn, msgBoxIcn)
    End Function

    Public Shared Function ShowInfoMessage(ByVal strMsg As String, Optional ByVal msgBoxBtn As MessageBoxButtons = MessageBoxButtons.OK) As DialogResult
        Return MessageBox.Show(strMsg, MsgHeader, msgBoxBtn, MessageBoxIcon.Information)
    End Function

    Public Shared Function ShowErrorMessage(ByVal strMsg As String, Optional ByVal msgBoxBtn As MessageBoxButtons = MessageBoxButtons.OK) As DialogResult
        Return MessageBox.Show(strMsg, MsgHeader, msgBoxBtn, MessageBoxIcon.Error)
    End Function

    Public Shared Sub CreateTable(ByRef dt As DataTable)
        If dt Is Nothing Then
            dt = New DataTable
            dt.Columns.Add("Code", Type.GetType("System.Int16"))
            dt.Columns.Add("Element", Type.GetType("System.String"))
            dt.Columns.Add("Value", Type.GetType("System.String"))
            dt.Columns.Add("ReadSecurityLevel", Type.GetType("System.Int16"))
            dt.Columns.Add("IsSelected", Type.GetType("System.Boolean"))
        Else
            dt.Clear()
        End If
    End Sub

    Public Shared Sub PopulateTable_UMID_Element(ByRef dt As DataTable)
        For i As Short = 1 To 46
            Dim i2 As Integer
            Select Case i
                Case 45
                    i2 = 48
                Case 46
                    i2 = 49
                Case Else
                    i2 = i
            End Select

            If i <> 43 Then
                Dim rw As DataRow = dt.NewRow
                rw("Code") = i2
                rw("Element") = AllcardUMID.GetElementDescription(i2)

                Select Case i2
                    Case 1, 44, 45, 46, 47, 48, 49
                        rw("ReadSecurityLevel") = 0
                    Case 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 29, 30, 31, 33, 34, 35, 36, 37, 38, 39, 40, 41
                        rw("ReadSecurityLevel") = 1
                    Case 20, 42, 43
                        rw("ReadSecurityLevel") = 2
                    Case 17, 18, 19, 21, 22, 23, 24, 25, 26, 27, 28, 32
                        rw("ReadSecurityLevel") = 3
                End Select

                rw("IsSelected") = False
                dt.Rows.Add(rw)
            End If
        Next
    End Sub

    Public Shared Sub PopulateTable_Sector(ByRef dt As DataTable)
        Dim intCounter As Short = 1
        Dim intInstCounter As Short = 1
        Dim strInst As String = "GSIS"
        For i As Short = 37 To 72
            Dim rw As DataRow = dt.NewRow
            rw("Code") = i
            rw("Element") = String.Format("{0} Sector {1}", strInst, intCounter.ToString)
            rw("IsSelected") = False
            dt.Rows.Add(rw)
            intCounter += 1
        Next
    End Sub

    Public Shared Sub BindSelected_UMID_Element(ByRef dt As DataTable)
        If My.Settings.UMID_Element_Visible.Length > 0 Then
            For Each intCode As Short In My.Settings.UMID_Element_Visible.Split(",")
                If dt.Select("Code=" & intCode.ToString).Length > 0 Then
                    dt.Select("Code=" & intCode.ToString)(0)("IsSelected") = True
                End If
            Next
        End If
    End Sub

    Public Shared Sub BindSelected_Sector(ByRef dt As DataTable)
        If My.Settings.Sector_Visible.Length > 0 Then
            For Each intCode As Short In My.Settings.Sector_Visible.Split(",")
                If dt.Select("Code=" & intCode.ToString).Length > 0 Then
                    dt.Select("Code=" & intCode.ToString)(0)("IsSelected") = True
                End If
            Next
        End If
    End Sub

    Public Enum UMID_Element
        CRN = 1
        Firstname = 2
        Middlename = 3
        Lastname = 4
        Suffix = 5
        Postalcode = 6
        CountryCode = 7
        Province_State = 8
        City_Municipality = 9
        Barangay_District_Locality = 10
        Subdivision = 11
        Streetname = 12
        Houseorlotandblocknumber = 13
        Rm_Flr_Unitnoandbldgname = 14
        Gender = 15
        Dateofbirth = 16
        City_Municipality_Birth = 17
        Province_State_Birth = 18
        Country_Birth = 19
        Maritalstatus = 20
        Firstname_Father = 21
        Middlename_Father = 22
        Lastname_Father = 23
        Suffix_Father = 24
        Firstname_Mother = 25
        Middlename_Mother = 26
        Lastname_Mother = 27
        Suffix_Mother = 28
        Height = 29
        Weight = 30
        Distinguishingfeatures = 31
        Tin = 32
        Leftprimaryfingercode = 33
        Rightprimaryfingercode = 34
        Leftbackupfingercode = 35
        Rightbackupfingercode = 36
        Leftprimaryfinger_Biometric = 37
        Rightprimaryfinger_Biometric = 38
        Leftbackupfinger_Biometric = 39
        Rightbackupfinger_Biometric = 40
        Picture_Biometric = 41
        Signature_Biometric = 42
        CSN_Agency = 44
        CSN_EnrollDate = 45
        CSN_StationID = 46
        CSN_Sequence = 47
        Cardcreationdate = 48
        Cardstatus = 49
    End Enum

#Region " Logs "

    Private Shared SystemLog As String = "Logs\" & Now.ToString("MMddyyyy") & "\System.log"
    Private Shared ErrorLog As String = "Logs\" & Now.ToString("MMddyyyy") & "\Error.log"

    Private Shared Sub InitLogFolder()
        If Not IO.Directory.Exists("Logs\" & Now.ToString("MMddyyyy")) Then IO.Directory.CreateDirectory("Logs\" & Now.ToString("MMddyyyy"))
    End Sub

    Public Shared Sub SaveToLog(ByVal strData As String)
        Try
            InitLogFolder()
            Dim sw As New IO.StreamWriter(SystemLog, True)
            sw.WriteLine(strData)
            sw.Dispose()
            sw.Close()
        Catch ex As Exception
        End Try
    End Sub

    Public Shared Sub SaveToErrorLog(ByVal strData As String)
        Try
            InitLogFolder()
            Dim sw As New IO.StreamWriter(ErrorLog, True)
            sw.WriteLine(strData)
            sw.Dispose()
            sw.Close()
        Catch ex As Exception
        End Try
    End Sub

    Public Shared Function TimeStamp() As String
        Return Now.ToString("MM/dd/yy hh:mm:ss tt").PadRight(25, " ")
    End Function

#End Region

End Class
