Public Class Setting

    Public SmartCardReaders(9) As String

    Private Sub Setting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitializeReaderList()

        Try
            If cboCardReader.Items.Count > 0 Then cboCardReader.SelectedIndex = cboCardReader.FindString(My.Settings.SmartCardReader)
            If cboSAM.Items.Count > 0 Then cboSAM.SelectedIndex = My.Settings.SAM
            If cboUMID.Items.Count > 0 Then cboUMID.SelectedIndex = My.Settings.UMID
        Catch ex As Exception
        End Try
    End Sub

    Sub InitializeReaderList()

        Dim sReaderList As String = ""
        Dim ReaderCount As Integer
        Dim ctr As Integer

        For ctr = 0 To 255
            sReaderList = sReaderList + vbNullChar
        Next

        ReaderCount = 255

        retCode = ModWinsCard.SCardEstablishContext(ModWinsCard.SCARD_SCOPE_USER, 0, 0, hContext)

        If retCode <> ModWinsCard.SCARD_S_SUCCESS Then Exit Sub

        retCode = ModWinsCard.SCardListReaders(hContext, "", sReaderList, ReaderCount)

        If retCode <> ModWinsCard.SCARD_S_SUCCESS Then Exit Sub

        LoadListToControl(SmartCardReaders, sReaderList)

        For Each strReader As String In SmartCardReaders
            If Not strReader Is Nothing Then
                cboCardReader.Items.Add(strReader)
                cboSAM.Items.Add(strReader)
                cboUMID.Items.Add(strReader)
            End If
        Next
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        My.Settings.SmartCardReader = cboCardReader.Text
        My.Settings.SAM = cboSAM.SelectedIndex
        My.Settings.UMID = cboUMID.SelectedIndex
        My.Settings.Save()

        SharedFunction.ShowInfoMessage("Changes has been saved...")
    End Sub

    Private Sub cboCardReader_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCardReader.SelectedIndexChanged
        cboUMID.SelectedIndex = cboCardReader.SelectedIndex
    End Sub
 
End Class