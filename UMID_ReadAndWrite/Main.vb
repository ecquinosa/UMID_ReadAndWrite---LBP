
Imports System.IO

Public Class Main

    Private AppVersion As String
    Private ErrorMessage As String
    Private OutputData As String
    Private dtSectors As DataTable

    Private OldPin As String
    Private NewPin As String

    Private dtElement As DataTable
    Private dtElementSelected As DataTable
    Private dtSector As DataTable
    Private dtSectorSelected As DataTable

    Private Sub Main_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        HouseKeeping()
    End Sub

    Private Sub HouseKeeping()
        If File.Exists(AllcardUMID.CARD_PHOTO) Then File.Delete(AllcardUMID.CARD_PHOTO)
        If File.Exists(AllcardUMID.CARD_SIGNATURE) Then File.Delete(AllcardUMID.CARD_SIGNATURE)
        If File.Exists(AllcardUMID.CARD_LP) Then File.Delete(AllcardUMID.CARD_LP)
        If File.Exists(AllcardUMID.CARD_LB) Then File.Delete(AllcardUMID.CARD_LB)
        If File.Exists(AllcardUMID.CARD_RP) Then File.Delete(AllcardUMID.CARD_RP)
        If File.Exists(AllcardUMID.CARD_RB) Then File.Delete(AllcardUMID.CARD_RB)
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If cboInstitution.Items.Count > 0 Then cboInstitution.SelectedIndex = 0
        'CreateSectorTable()

        gridCommonElement.AutoGenerateColumns = False
        gridSector.AutoGenerateColumns = False

        ResetTables
     
        gridCommonElement.DataSource = dtElementSelected.Select(ElementTableFiltering).CopyToDataTable
        gridSector.DataSource = dtSectorSelected
    End Sub

    Private Function ElementTableFiltering() As String
        Return "IsSelected=True AND Code NOT IN (37,38,39,40,41,42)"
    End Function

    Private Sub ResetTables()
        SharedFunction.CreateTable(dtElement)
        SharedFunction.CreateTable(dtSector)

        SharedFunction.PopulateTable_UMID_Element(dtElement)
        SharedFunction.PopulateTable_Sector(dtSector)

        SharedFunction.BindSelected_UMID_Element(dtElement)
        SharedFunction.BindSelected_Sector(dtSector)

        If dtElement.Select("IsSelected=True").Length > 0 Then
            dtElementSelected = dtElement.Select("IsSelected=True").CopyToDataTable
        Else
            dtElementSelected = dtElement.Clone
        End If
        Application.DoEvents()

        If dtSector.Select("IsSelected=True").Length > 0 Then
            dtSectorSelected = dtSector.Select("IsSelected=True").CopyToDataTable
        Else
            dtSectorSelected = dtSector.Clone
        End If

        gridCommonElement.DataSource = dtElementSelected.Select(ElementTableFiltering).CopyToDataTable
        gridSector.DataSource = dtSectorSelected

        Application.DoEvents()
        System.Threading.Thread.Sleep(500)
    End Sub

    Private Sub ReadCard()
        Cursor = Cursors.WaitCursor
        Dim AppVersion As String = AllcardUMID.CheckAppVersion(ErrorMessage)

        If AppVersion <> "Error" Then
            If AppVersion = "2" Then txtCardType.Text = "NEW UMID CARD"

            Dim data As String = ""
            Dim errMsg As String = ""

            Dim Leftprimaryfingercode As String = ""
            Dim Rightprimaryfingercode As String = ""
            Dim Leftbackupfingercode As String = ""
            Dim Rightbackupfingercode As String = ""

            If AllcardUMID.ReadData_Table(dtElementSelected, Leftprimaryfingercode, Rightprimaryfingercode, Leftbackupfingercode, Rightbackupfingercode, txtNewPin.Text, errMsg) Then
                gridCommonElement.DataSource = dtElementSelected.Select(ElementTableFiltering).CopyToDataTable

                If File.Exists(AllcardUMID.CARD_PHOTO) Then
                    Using ms As New MemoryStream(File.ReadAllBytes(AllcardUMID.CARD_PHOTO))
                        picPhoto.BackgroundImage = Image.FromStream(ms)
                    End Using
                End If

                If File.Exists(AllcardUMID.CARD_SIGNATURE) Then
                    Using ms2 As New MemoryStream(File.ReadAllBytes(AllcardUMID.CARD_SIGNATURE))
                        picSignature.BackgroundImage = Image.FromStream(ms2)
                    End Using
                End If

                If Leftprimaryfingercode.ToUpper = "I" Then
                    If File.Exists(AllcardUMID.CARD_LP) Then
                        Using ms2 As New MemoryStream(File.ReadAllBytes("fingerprint_template.jpg"))
                            picLP.BackgroundImage = Image.FromStream(ms2)
                        End Using
                    End If
                End If

                If Rightprimaryfingercode.ToUpper = "I" Then
                    If File.Exists(AllcardUMID.CARD_RP) Then
                        Using ms2 As New MemoryStream(File.ReadAllBytes("fingerprint_template.jpg"))
                            picRP.BackgroundImage = Image.FromStream(ms2)
                        End Using
                    End If
                End If

                If Leftbackupfingercode.ToUpper = "T" Then
                    If File.Exists(AllcardUMID.CARD_LB) Then
                        Using ms2 As New MemoryStream(File.ReadAllBytes("fingerprint_template.jpg"))
                            picLB.BackgroundImage = Image.FromStream(ms2)
                        End Using
                    End If
                End If

                If Rightbackupfingercode.ToUpper = "T" Then
                    If File.Exists(AllcardUMID.CARD_RB) Then
                        Using ms2 As New MemoryStream(File.ReadAllBytes("fingerprint_template.jpg"))
                            picRB.BackgroundImage = Image.FromStream(ms2)
                        End Using
                    End If
                End If

                ReadInstitutionSectors()

                SystemStatus("")
            Else
                SystemStatus("Failed to read card", 2)
                SharedFunction.SaveToErrorLog(SharedFunction.TimeStamp & errMsg)
            End If
        Else
            SystemStatus("Unable to get applet version. " & ErrorMessage, 2)
        End If

        Cursor = Cursors.Default
    End Sub

    Private Sub ReadInstitutionSectors()
        Cursor = Cursors.WaitCursor
        SystemStatus("PROCESSING...")

        If AllcardUMID.ReadSectors(dtSectorSelected, txtSystemStatus) Then
            gridSector.DataSource = dtSectorSelected
        End If

        SystemStatus("")
        Cursor = Cursors.Default
    End Sub

    Public Sub AuthenticationSL1(ByVal bln As Boolean)
        tsslAuth1.Text = "Authentication SL1: " & IIf(bln, "PASSED", "FAILED")
    End Sub

    Public Sub AuthenticationSL2(ByVal bln As Boolean)
        tsslAuth2.Text = "Authentication SL2: " & IIf(bln, "PASSED", "FAILED")
    End Sub

    Public Sub AuthenticationSL3(ByVal bln As Boolean)
        tsslAuth3.Text = "Authentication SL3: " & IIf(bln, "PASSED", "FAILED")
    End Sub

    Private Sub SystemStatus(ByVal status As String, Optional ByVal intColor As Short = 0)
        Select Case intColor
            Case 0
                txtSystemStatus.ForeColor = Color.Black
            Case 1
                txtSystemStatus.ForeColor = Color.Green
            Case 2
                txtSystemStatus.ForeColor = Color.OrangeRed
        End Select

        txtSystemStatus.Text = status.ToUpper
        Application.DoEvents()
    End Sub


    Private Sub ResetForm()
        picPhoto.BackgroundImage = Nothing
        picSignature.BackgroundImage = Nothing
        picLB.BackgroundImage = Nothing
        picRB.BackgroundImage = Nothing
        picRP.BackgroundImage = Nothing
        picLP.BackgroundImage = Nothing

        tsslAuth1.Text = "Authentication SL1: NA"
        tsslAuth2.Text = "Authentication SL2: NA"
        tsslAuth3.Text = "Authentication SL3: NA"

        SystemStatus("")
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        HouseKeeping()
        ResetTables()
        ResetForm()
        SystemStatus("PROCESSING...")
        System.Threading.Thread.Sleep(500)
        ReadCard()
    End Sub

    Private Function AgencySector(ByVal Counter As Integer) As Integer
        Return Counter + 36
    End Function

    Private Sub ToolStripButton2_Click_1(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Dim frm As New ChipData
        frm.ShowDialog()
    End Sub

    Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
        Dim frm As New Write
        frm.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        Dim frm As New Setting
        frm.ShowDialog()
    End Sub

End Class
