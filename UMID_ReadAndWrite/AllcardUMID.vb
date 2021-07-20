
Public Class AllcardUMID

    Public Shared CARD_PHOTO As String = "Photo.jpg"
    Public Shared CARD_SIGNATURE As String = "Signature.tiff"
    Public Shared CARD_LP As String = "LP.ansi-fmr"
    Public Shared CARD_LB As String = "LB.ansi-fmr"
    Public Shared CARD_RP As String = "RP.ansi-fmr"
    Public Shared CARD_RB As String = "RB.ansi-fmr"

    Public Shared Function ReadData_Table(ByRef dt As DataTable,
                                          ByRef Leftprimaryfingercode As String,
                                          ByRef Rightprimaryfingercode As String,
                                          ByRef Leftbackupfingercode As String,
                                          ByRef Rightbackupfingercode As String,
                                          Optional ByVal UserPIN As String = "",
                                          Optional ByVal ErrorMessage As String = "") As Boolean
        Dim sb As New System.Text.StringBuilder

        Try
            Dim sc As UMIDLibrary.AllCardTech_Smart_Card
            Init(sc)

            If IsHaveReadSecurityLevel(dt, 3) Then
                If sc.AuthenticateSL1 Then
                    Main.AuthenticationSL1(True)

                    If UserPIN = "" Then UserPIN = GetUMIDCardPIN()
                    Dim PIN() As Byte = System.Text.ASCIIEncoding.ASCII.GetBytes(UserPIN)
                    If sc.AuthenticateSL2(PIN) Then
                        If Not sc.AuthenticateSL3() Then
                            Main.AuthenticationSL3(False)
                            ErrorMessage = "ReadData_Table(): SL3 failed"
                        Else
                            Main.AuthenticationSL3(True)
                        End If
                    Else
                        Main.AuthenticationSL2(False)
                        ErrorMessage = "ReadData_Table(): SL2 failed"
                    End If
                Else
                    Main.AuthenticationSL1(False)
                    ErrorMessage = "ReadData_Table(): SL1 failed"
                End If
            ElseIf IsHaveReadSecurityLevel(dt, 2) Then
                If sc.AuthenticateSL1 Then
                    Main.AuthenticationSL1(True)

                    If UserPIN = "" Then UserPIN = GetUMIDCardPIN()
                    Dim PIN() As Byte = System.Text.ASCIIEncoding.ASCII.GetBytes(UserPIN)
                    If Not sc.AuthenticateSL2(PIN) Then
                        Main.AuthenticationSL2(False)
                        ErrorMessage = "ReadData_Table(): SL2 failed"
                    Else
                        Main.AuthenticationSL2(True)
                    End If
                Else
                    Main.AuthenticationSL1(False)
                    ErrorMessage = "ReadData_Table(): SL1 failed"
                End If
            ElseIf IsHaveReadSecurityLevel(dt, 1) Then
                If Not sc.AuthenticateSL1 Then
                    Main.AuthenticationSL1(False)
                    ErrorMessage = "ReadData_Table(): SL1 failed"
                Else
                    Main.AuthenticationSL1(True)
                End If
            End If

            Try
                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Cardcreationdate) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Cardcreationdate, GetCCDT(, sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.CRN) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.CRN, GetCRN(, sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Firstname) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Firstname, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.FIRST_NAME, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Middlename) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Middlename, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.MIDDLE_NAME, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Lastname) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Lastname, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.LAST_NAME, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Suffix) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Suffix, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.SUFFIX, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Postalcode) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Postalcode, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_POSTAL_CODE, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.CountryCode) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.CountryCode, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_COUNTRY, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Province_State) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Province_State, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_PROVINCIAL_OR_STATE, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.City_Municipality) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.City_Municipality, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_CITY_OR_MUNICIPALITY, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Barangay_District_Locality) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Barangay_District_Locality, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_BARANGAY_OR_DISTRIC_OR_LOCALITY, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Subdivision) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Subdivision, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_SUBDIVISION, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Streetname) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Streetname, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_SUBDIVISION, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Houseorlotandblocknumber) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Houseorlotandblocknumber, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_HOUSE_OR_LOT_AND_BLOCK_NUMBER, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Rm_Flr_Unitnoandbldgname) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Rm_Flr_Unitnoandbldgname, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.ADDRESS_ROOM_OR_FLOOR_OR_UNIT_NO_AND_BUILDING_NAME, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Gender) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Gender, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.GENDER, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Dateofbirth) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Dateofbirth, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.DATE_OF_BIRTH, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.City_Municipality_Birth) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.City_Municipality_Birth, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.PLACE_OF_BIRTH_CITY, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Province_State_Birth) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Province_State_Birth, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.PLACE_OF_BIRTH_PROVINCE, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Country_Birth) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Country_Birth, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.PLACE_OF_BIRTH_COUNTRY, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Maritalstatus) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Maritalstatus, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.MARITAL_STATUS, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Firstname_Father) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Firstname_Father, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.FATHER_FIRST_NAME, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Middlename_Father) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Middlename_Father, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.FATHER_MIDDLE_NAME, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Lastname_Father) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Lastname_Father, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.FATHER_LAST_NAME, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Suffix_Father) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Suffix_Father, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.FATHER_SUFFIX, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Firstname_Mother) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Firstname_Mother, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.MOTHER_FIRST_NAME, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Middlename_Mother) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Middlename_Mother, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.MOTHER_MIDDLE_NAME, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Lastname_Mother) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Lastname_Mother, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.MOTHER_LAST_NAME, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Suffix_Mother) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Suffix_Mother, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.MOTHER_SUFFIX, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Height) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Height, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.HEIGHT, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Weight) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Weight, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.WEIGHT, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Distinguishingfeatures) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Distinguishingfeatures, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.DISTINGUISHING_FEATURES, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Tin) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Tin, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.TIN, , sc))

                Leftprimaryfingercode = ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.LEFT_PRIMARY_FINGER_CODE, , sc)
                Rightprimaryfingercode = ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.RIGHT_PRIMARY_FINGER_CODE, , sc)
                Leftbackupfingercode = ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.LEFT_SECONDARY_FINGER_CODE, , sc)
                Rightbackupfingercode = ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.RIGHT_SECONDARY_FINGER_CODE, , sc)

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Leftprimaryfingercode) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Leftprimaryfingercode, Leftprimaryfingercode)

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Rightprimaryfingercode) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Rightprimaryfingercode, Rightprimaryfingercode)

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Leftbackupfingercode) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Leftbackupfingercode, Leftbackupfingercode)

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Rightbackupfingercode) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Rightbackupfingercode, Rightbackupfingercode)

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.CSN_Agency) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.CSN_Agency, ReadUMID_Fields(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.CSN, , sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Cardstatus) Then _
                    SaveElementValueInTable(dt, SharedFunction.UMID_Element.Cardstatus, GetCardStatus(, sc))

                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Picture_Biometric) Then GetPhoto()
                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Signature_Biometric) Then GetSignature(UserPIN)
                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Leftprimaryfinger_Biometric) Then GetLeftPrimaryANSI()
                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Leftbackupfinger_Biometric) Then GetLeftBackupANSI()
                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Rightprimaryfinger_Biometric) Then GetRightPrimaryANSI()
                If IsElementExistInTable(dt, SharedFunction.UMID_Element.Rightbackupfinger_Biometric) Then GetRightBackupANSI()

                Return True
            Catch ex As Exception
                ErrorMessage = String.Format("ReadData_Table(2): Runtime error catched {0}", ex.Message)

                Return False
            End Try
        Catch ex As Exception
            ErrorMessage = String.Format("ReadData_Table(1): Runtime error catched {0}", ex.Message)

            Return False
        End Try
    End Function

    Private Shared Function IsElementExistInTable(ByVal dt As DataTable, ByVal UMID_Element As SharedFunction.UMID_Element) As Boolean
        If dt.Select("IsSelected=True AND Code=" & UMID_Element).Length > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Shared Function IsHaveReadSecurityLevel(ByVal dt As DataTable, ByVal intReadSecurityLevel As Short) As Boolean
        If dt.Select("IsSelected=True AND ReadSecurityLevel=" & intReadSecurityLevel).Length > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Shared Sub SaveElementValueInTable(ByVal dt As DataTable, ByVal UMID_Element As SharedFunction.UMID_Element, ByVal value As String)
        dt.Select("Code=" & UMID_Element)(0)("Value") = value
    End Sub

    Public Shared Function GetCRN(Optional ByVal ErrorMessage As String = "", Optional ByVal sc As UMIDLibrary.AllCardTech_Smart_Card = Nothing) As String
        Try
            Init(sc)

            Return Util.ByteArrayToAscii(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.CRN))
        Catch ex As Exception
            ErrorMessage = String.Format("GetCRN(1): Runtime error catched {0}", ex.Message)

            Return "Error"
        End Try
    End Function

    Public Shared Function GetCSN(Optional ByVal ErrorMessage As String = "", Optional ByVal sc As UMIDLibrary.AllCardTech_Smart_Card = Nothing) As String
        Try
            Init(sc)

            Try
                Return Util.ByteArrayToAscii(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.CSN))
            Catch ex As Exception
                ErrorMessage = String.Format("GetCSN(2): Runtime error catched {0}", ex.Message)

                Return "Error"
            End Try
        Catch ex As Exception
            ErrorMessage = String.Format("GetCSN(1): Runtime error catched {0}", ex.Message)

            Return "Error"
        End Try
    End Function

    Public Shared Function ReadUMID_Fields(ByVal umidfield As UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields,
                                           Optional ByRef ErrorMessage As String = "", _
                                           Optional ByVal sc As UMIDLibrary.AllCardTech_Smart_Card = Nothing) As String
        Try
            Init(sc)

            Return Util.ByteArrayToAscii(sc.getUmidData(umidfield))
        Catch ex As Exception
            ErrorMessage = String.Format("ReadUMID_Fields(): Runtime error catched {0}", ex.Message)

            Return "Error"
        End Try
    End Function

    Public Shared Function GetCardStatus(Optional ByRef ErrorMessage As String = "", Optional ByVal sc As UMIDLibrary.AllCardTech_Smart_Card = Nothing) As String
        Try
            Init(sc)

            Dim status As String = ""
            If sc.GetCardStatus(status) Then
                Return status
            Else
                If status = "" Then
                    Return "CARD_BLOCKED"
                Else
                    Return "Error"
                End If
            End If
        Catch ex As Exception
            ErrorMessage = String.Format("GetCardStatus(): Runtime error catched {0}", ex.Message)

            Return "Error"
        End Try
    End Function

    Public Shared Function GetCCDT(Optional ByRef ErrorMessage As String = "", Optional ByVal sc As UMIDLibrary.AllCardTech_Smart_Card = Nothing) As String
        Try
            Init(sc)

            Dim CCDT As String

            Try
                Dim tByte(0) As Byte
                Dim CCDT_ASCII As String = System.Text.ASCIIEncoding.ASCII.GetString(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.CARD_CREATION_DATE)).Replace(System.Text.ASCIIEncoding.ASCII.GetString(tByte), "").Trim
                Dim CCDT_BCD As String = ByteArrayToHexString(sc.getUmidData(UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.CARD_CREATION_DATE)).Replace(System.Text.ASCIIEncoding.ASCII.GetString(tByte), "").Trim
                Try
                    IsDate(String.Format("{0}/{1}/{2}", CCDT_ASCII.Substring(4, 2), CCDT_ASCII.Substring(6, 2), CCDT_ASCII.Substring(0, 4)))
                    CCDT = CCDT_ASCII
                Catch ex As Exception
                    CCDT = CCDT_BCD.Substring(0, 8)
                End Try

                Return CCDT
            Catch ex As Exception
                ErrorMessage = String.Format("GetCCDT(2): Runtime error catched {0}", ex.Message)

                Return "Error"
            End Try
        Catch ex As Exception
            ErrorMessage = String.Format("GetCCDT(1): Runtime error catched {0}", ex.Message)

            Return "Error"
        End Try
    End Function

    Public Shared Function ReadSector(ByVal intSector As Integer,
                                      Optional ByRef ErrorMessage As String = "", _
                                      Optional ByVal sc As UMIDLibrary.AllCardTech_Smart_Card = Nothing) As String
        Try
            Init(sc)

            Dim byteSector() As Byte = sc.ReadSector(intSector, 0, 32)

            If CInt(byteSector.GetValue(0)) > 0 Then
                Return System.Text.ASCIIEncoding.ASCII.GetString(byteSector)
            Else
                Return ""
            End If
        Catch ex As Exception
            ErrorMessage = String.Format("ReadSector(): Runtime error catched {0}", ex.Message)

            Return "Error"
        End Try
    End Function

    Public Shared Function ReadSectors(ByRef dtSectors As DataTable,
                                       ByRef txtStatus As TextBox,
                                       Optional ByRef ErrorMessage As String = "", _
                                       Optional ByVal sc As UMIDLibrary.AllCardTech_Smart_Card = Nothing) As Boolean
        Try
            Init(sc)


            For Each rw As DataRow In dtSectors.Rows
                Dim byteSector() As Byte = sc.ReadSector(rw("Code"), 0, 32)
                SaveElementValueInTable(dtSectors, rw("Code"), System.Text.ASCIIEncoding.ASCII.GetString(byteSector))

                txtStatus.Text = String.Format("Reading sector {0}", CInt(rw("Code") - 36).ToString)
                Application.DoEvents()
            Next

            Return True
        Catch ex As Exception
            ErrorMessage = String.Format("ReadSector(): Runtime error catched {0}", ex.Message)

            Return False
        End Try
    End Function


    Public Shared Function WriteSectorData(ByVal intSectorID As Integer, ByVal strData As String, _
                                           Optional ByRef ErrorMessage As String = "", _
                                           Optional ByVal sc As UMIDLibrary.AllCardTech_Smart_Card = Nothing) As Boolean
        Try
            Init(sc)

            If sc.AuthenticateSL1() Then
                strData = strData.PadRight(32, " ")

                Dim Data() As Byte = System.Text.ASCIIEncoding.ASCII.GetBytes(strData)

                Return sc.WriteSector(intSectorID, 0, Data.Length, Data)
            End If
        Catch ex As Exception
            ErrorMessage = String.Format("WriteSectorData(): Runtime error catched {0}", ex.Message)

            Return False
        End Try
    End Function

    Public Shared Function CheckAppVersion(Optional ByRef ErrorMessage As String = "", _
                                           Optional ByVal sc As UMIDLibrary.AllCardTech_Smart_Card = Nothing) As String
        Try
            Init(sc)

            Try
                Return sc.CheckVersion()
            Catch ex As Exception
                ErrorMessage = String.Format("CheckAppVersion(2): Runtime error catched {0}", ex.Message)

                Return "Error"
            End Try
        Catch ex As Exception
            ErrorMessage = String.Format("CheckAppVersion(1): Runtime error catched {0}", ex.Message)

            Return "Error"
        End Try
    End Function

    Public Shared Function GetUMIDCardPIN(Optional ByRef ErrorMessage As String = "", _
                                          Optional ByVal sc As UMIDLibrary.AllCardTech_Smart_Card = Nothing) As String
        Try
            Init(sc)

            Select Case CheckAppVersion(, sc)
                Case AllcardUMID.UMIDType.UMID_NEW
                    Return "123456"
                Case Else
                    Return "Error"
            End Select
        Catch ex As Exception
            ErrorMessage = String.Format("GetUMIDCardPIN(): Runtime error catched {0}", ex.Message)

            Return "Error"
        End Try
    End Function

    Private Shared Function DetermineRespose(ByVal Result As Boolean, ByRef Data() As Byte, ByRef Err() As Byte) As String
        Try

            Dim NullByte(0) As Byte

            If Result Then
                Return System.Text.ASCIIEncoding.ASCII.GetString(Data).Replace(System.Text.ASCIIEncoding.ASCII.GetString(NullByte), "").Trim
            Else
                Return System.Text.ASCIIEncoding.ASCII.GetString(Err).Replace(System.Text.ASCIIEncoding.ASCII.GetString(NullByte), "").Trim
            End If

        Catch ex As Exception
            Return "Unable to read data."
        End Try

    End Function

    Public Shared Function ConnectSmartCard() As Boolean
        Dim ErrorMessage As Byte() = New Byte(1023) {}
        Dim Result As Boolean = False

        Result = UMIDSAM_QC.SmartReader_Connect_Debug(My.Settings.UMID, My.Settings.SAM, ErrorMessage)

        Return Result
    End Function

    Public Shared Function ConnectSAM() As Boolean

        Dim ErrorMessage As Byte() = New Byte(1023) {}
        Dim Result As Boolean = False

        Result = UMIDSAM_QC.UMIDSAM_Connect(ErrorMessage)

        Return Result

    End Function

    Public Shared Function ConnectUMID() As Boolean

        Dim ErrorMessage As Byte() = New Byte(1023) {}
        Dim Result As Boolean = False

        Result = UMIDSAM_QC.UMIDCard_Connect(ErrorMessage)

        Return Result

    End Function

    Public Shared Function DisConnectUMID() As Boolean
        UMIDSAM_QC.UMIDCard_DisConnect()
    End Function

    Public Shared Function GetPhoto(Optional ByRef ErrorMessage As String = "", Optional ByVal sc As UMIDLibrary.AllCardTech_Smart_Card = Nothing) As String
        Try
            Dim result As Boolean

            Init(sc)

            If sc.AuthenticateSL1() Then
                Main.AuthenticationSL1(True)

                result = sc.getUmidFile(CARD_PHOTO, UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.BIOMETRIC_PICTURE)

                If Not result Then
                    ErrorMessage = "GetPhoto(): Failed to get photo"
                    result = False
                End If
            Else
                Main.AuthenticationSL1(False)
                ErrorMessage = "GetPhoto(): SL1 failed"
                result = False
            End If

            Return result
        Catch ex As Exception
            ErrorMessage = String.Format("GetPhoto(): Runtime error catched {0}", ex.Message)

            Return "Error"
        End Try
    End Function

    Public Shared Function GetSignature(Optional ByVal UserPIN As String = "",
                                        Optional ByRef ErrorMessage As String = "",
                                        Optional ByVal sc As UMIDLibrary.AllCardTech_Smart_Card = Nothing) As String
        Try
            Dim result As Boolean

            Init(sc)

            If sc.AuthenticateSL1() Then
                Main.AuthenticationSL1(True)
                If UserPIN = "" Then UserPIN = GetUMIDCardPIN()
                Dim PIN() As Byte = System.Text.ASCIIEncoding.ASCII.GetBytes(UserPIN)
                If sc.AuthenticateSL2(PIN) Then
                    Main.AuthenticationSL2(True)
                    result = sc.getUmidFile(CARD_SIGNATURE, UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.BIOMETRIC_SIGNATURE)

                    If Not result Then
                        ErrorMessage = "GetSignature(): Failed to get signature"
                        result = False
                    End If
                Else
                    Main.AuthenticationSL2(False)
                    ErrorMessage = "GetSignature(): SL2 failed"

                    result = False
                End If
            Else
                Main.AuthenticationSL1(False)
                ErrorMessage = "GetSignature(): SL1 failed"
                result = False
            End If

            Return result
        Catch ex As Exception
            ErrorMessage = String.Format("GetPhoto(): Runtime error catched {0}", ex.Message)

            Return "Error"
        End Try
    End Function

    Public Shared Function GetLeftPrimaryANSI(Optional ByRef ErrorMessage As String = "", Optional ByVal sc As UMIDLibrary.AllCardTech_Smart_Card = Nothing) As String
        Try
            Dim result As Boolean

            Init(sc)

            If sc.AuthenticateSL1() Then
                Main.AuthenticationSL1(True)

                result = sc.getUmidFile(CARD_LP, UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.BIOMETRIC_LEFT_PRIMARY_FINGER)

                If Not result Then
                    ErrorMessage = "GetLeftPrimaryANSI(): Failed to get left primary fingerprint"
                    result = False
                End If
            Else
                Main.AuthenticationSL1(False)
                ErrorMessage = "GetLeftPrimaryANSI(): SL1 failed"
                result = False
            End If

            Return result
        Catch ex As Exception
            ErrorMessage = String.Format("GetLeftPrimaryANSI(): Runtime error catched {0}", ex.Message)

            Return "Error"
        End Try
    End Function

    Public Shared Function GetLeftBackupANSI(Optional ByRef ErrorMessage As String = "", Optional ByVal sc As UMIDLibrary.AllCardTech_Smart_Card = Nothing) As String
        Try
            Dim result As Boolean

            Init(sc)

            If sc.AuthenticateSL1() Then
                Main.AuthenticationSL1(True)

                result = sc.getUmidFile(CARD_LB, UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.BIOMETRIC_LEFT_SECONDARY_FINGER)

                If Not result Then
                    ErrorMessage = "GetLeftBackupANSI(): Failed to get left backup fingerprint"
                    result = False
                End If
            Else
                Main.AuthenticationSL1(False)
                ErrorMessage = "GetLeftBackupANSI(): SL1 failed"
                result = False
            End If

            Return result
        Catch ex As Exception
            ErrorMessage = String.Format("GetLeftBackupANSI(): Runtime error catched {0}", ex.Message)

            Return "Error"
        End Try
    End Function

    Public Shared Function GetRightPrimaryANSI(Optional ByRef ErrorMessage As String = "", Optional ByVal sc As UMIDLibrary.AllCardTech_Smart_Card = Nothing) As String
        Try
            Dim result As Boolean

            Init(sc)

            If sc.AuthenticateSL1() Then
                Main.AuthenticationSL1(True)

                result = sc.getUmidFile(CARD_RP, UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.BIOMETRIC_RIGHT_PRIMARY_FINGER)

                If Not result Then
                    ErrorMessage = "GetRightPrimaryANSI(): Failed to get Right primary fingerprint"
                    result = False
                End If
            Else
                Main.AuthenticationSL1(False)
                ErrorMessage = "GetRightPrimaryANSI(): SL1 failed"
                result = False
            End If

            Return result
        Catch ex As Exception
            ErrorMessage = String.Format("GetRightPrimaryANSI(): Runtime error catched {0}", ex.Message)

            Return "Error"
        End Try
    End Function

    Public Shared Function GetRightBackupANSI(Optional ByRef ErrorMessage As String = "", Optional ByVal sc As UMIDLibrary.AllCardTech_Smart_Card = Nothing) As String
        Try
            Dim result As Boolean

            Init(sc)

            If sc.AuthenticateSL1() Then
                Main.AuthenticationSL1(True)

                result = sc.getUmidFile(CARD_RB, UMIDLibrary.AllCardTech_Smart_Card.UMID_Fields.BIOMETRIC_RIGHT_SECONDARY_FINGER)

                If Not result Then
                    ErrorMessage = "GetRightBackupANSI(): Failed to get Right backup fingerprint"
                    result = False
                End If
            Else
                Main.AuthenticationSL1(False)
                ErrorMessage = "GetRightBackupANSI(): SL1 failed"
                result = False
            End If

            Return result
        Catch ex As Exception
            ErrorMessage = String.Format("GetRightBackupANSI(): Runtime error catched {0}", ex.Message)

            Return "Error"
        End Try
    End Function

#Region " Others "

    Public Enum UMIDType
        UMID_NEW = 2
    End Enum

    Public Enum UMID_Element
        CRN = 1
        FirstName
        MiddleName
        LastName
        Suffix
        PostalCode
        CountryCode
        Province_State
        City_Municipality
        Barangay_District_Locality
        Subdivision
        StreetName
        HouseLotBlock
        Rm_Flr_Unit_Bldg
        Gender
        DateofBirth
        City_Municipality_Birth
        Province_State_Birth
        CountryCode_Birth
        MaritalStatus
        FirstName_Father
        MiddleName_Father
        LastName_Father
        Suffix_Father
        FirstName_Mother
        MiddleName_Mother
        LastName_Mother
        Suffix_Mother
        Height
        Weight
        DistinguishingFeatures
        TIN
        LeftPrimaryFingerCode
        RightPrimaryFingerCode
        LeftBackupFingerCode
        RightBackupFingerCode
        LeftPrimaryFinger_Biometric
        RightPrimaryFinger_Biometric
        LeftBackupFinger_Biometric
        RightBackupFinger_Biometric
        Picture_Biometric
        Signature_Biometric
        PIN
        CSN
        CardCreationDate = 48
        CardStatus
    End Enum

    Public Shared Function GetElementDescription(ByVal UMID_Element As UMID_Element) As String
        Select Case UMID_Element
            Case AllcardUMID.UMID_Element.CRN
                Return "CRN"
            Case AllcardUMID.UMID_Element.FirstName
                Return "FirstName"
            Case AllcardUMID.UMID_Element.MiddleName
                Return "MiddleName"
            Case AllcardUMID.UMID_Element.LastName
                Return "LastName"
            Case AllcardUMID.UMID_Element.Suffix
                Return "Suffix"
            Case AllcardUMID.UMID_Element.PostalCode
                Return "Postal Code"
            Case AllcardUMID.UMID_Element.CountryCode
                Return "Country Code"
            Case AllcardUMID.UMID_Element.Province_State
                Return "Province/ State"
            Case AllcardUMID.UMID_Element.City_Municipality
                Return "City/ Municipality"
            Case AllcardUMID.UMID_Element.Barangay_District_Locality
                Return "Barangay/ District/ Locality"
            Case AllcardUMID.UMID_Element.Subdivision
                Return "Subdivision"
            Case AllcardUMID.UMID_Element.StreetName
                Return "StreetName"
            Case AllcardUMID.UMID_Element.HouseLotBlock
                Return "House/ Lot/ Block"
            Case AllcardUMID.UMID_Element.Rm_Flr_Unit_Bldg
                Return "Room/ Floor/ Unit/ Bldg"
            Case AllcardUMID.UMID_Element.Gender
                Return "Gender"
            Case AllcardUMID.UMID_Element.DateofBirth
                Return "Date of Birth"
            Case AllcardUMID.UMID_Element.City_Municipality_Birth
                Return "City/ Municipality (Birth)"
            Case AllcardUMID.UMID_Element.Province_State_Birth
                Return "Province/ State (Birth)"
            Case AllcardUMID.UMID_Element.CountryCode_Birth
                Return "Country Code (Birth)"
            Case AllcardUMID.UMID_Element.MaritalStatus
                Return "Marital Status"
            Case AllcardUMID.UMID_Element.FirstName_Father
                Return "FirstName (Father)"
            Case AllcardUMID.UMID_Element.MiddleName_Father
                Return "MiddleName (Father)"
            Case AllcardUMID.UMID_Element.LastName_Father
                Return "LastName (Father)"
            Case AllcardUMID.UMID_Element.Suffix_Father
                Return "Suffix (Father"
            Case AllcardUMID.UMID_Element.FirstName_Mother
                Return "FirstName (Mother)"
            Case AllcardUMID.UMID_Element.MiddleName_Mother
                Return "MiddleName (Mother)"
            Case AllcardUMID.UMID_Element.LastName_Mother
                Return "LastName (Mother)"
            Case AllcardUMID.UMID_Element.Suffix_Mother
                Return "Suffix (Mother)"
            Case AllcardUMID.UMID_Element.Height
                Return "Height"
            Case AllcardUMID.UMID_Element.Weight
                Return "Weight"
            Case AllcardUMID.UMID_Element.DistinguishingFeatures
                Return "Features"
            Case AllcardUMID.UMID_Element.TIN
                Return "TIN"
            Case AllcardUMID.UMID_Element.LeftPrimaryFingerCode
                Return "Left Primary Finger Code"
            Case AllcardUMID.UMID_Element.RightPrimaryFingerCode
                Return "Right Primary Finger Code"
            Case AllcardUMID.UMID_Element.LeftBackupFingerCode
                Return "Left Backup Finger Code"
            Case AllcardUMID.UMID_Element.RightBackupFingerCode
                Return "Right Backup Finger Code"
            Case AllcardUMID.UMID_Element.LeftPrimaryFinger_Biometric
                Return "Left Primary Finger Biometric"
            Case AllcardUMID.UMID_Element.RightPrimaryFinger_Biometric
                Return "Right Primary Finger Biometric"
            Case AllcardUMID.UMID_Element.LeftBackupFinger_Biometric
                Return "Left Backup Finger Biometric"
            Case AllcardUMID.UMID_Element.RightBackupFinger_Biometric
                Return "Right Backup Finger Biometric"
            Case AllcardUMID.UMID_Element.Picture_Biometric
                Return "Picture Biometric"
            Case AllcardUMID.UMID_Element.Signature_Biometric
                Return "Signature Biometric"
            Case AllcardUMID.UMID_Element.PIN
                Return "PIN"
            Case AllcardUMID.UMID_Element.CSN
                Return "CSN"
            Case AllcardUMID.UMID_Element.CardCreationDate
                Return "Card Creation Date"
            Case AllcardUMID.UMID_Element.CardStatus
                Return "Card Status"
        End Select
    End Function

    Private Shared Sub Init(ByRef sc As UMIDLibrary.AllCardTech_Smart_Card)
        If sc Is Nothing Then
            sc = New UMIDLibrary.AllCardTech_Smart_Card()
            sc.InitializeReaders()
            sc.SelectApplet(My.Settings.UMID, My.Settings.SAM)
        End If
    End Sub

    Public Shared Function accSC() As UMIDLibrary.AllCardTech_Smart_Card
        Return New UMIDLibrary.AllCardTech_Smart_Card
    End Function

    Private Shared Function Util() As UMIDLibrary.AllCardTech_Util
        Return New UMIDLibrary.AllCardTech_Util()
    End Function

    Private Function AgencySector(ByVal Counter As Integer, ByVal Agency As String) As Integer
        Return Counter + 36
    End Function

#End Region

End Class
