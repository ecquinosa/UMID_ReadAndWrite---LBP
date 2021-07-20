
Public Class ChipData

    Private IsHaveChanges As Boolean = False

    Private dtElement As DataTable
    Private dtSector As DataTable

    Private Sub Settings_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        gridCommonElement.AutoGenerateColumns = False
        gridSector.AutoGenerateColumns = False

        SharedFunction.CreateTable(dtElement)
        SharedFunction.CreateTable(dtSector)

        SharedFunction.PopulateTable_UMID_Element(dtElement)
        SharedFunction.PopulateTable_Sector(dtSector)

        SharedFunction.BindSelected_UMID_Element(dtElement)
        SharedFunction.BindSelected_Sector(dtSector)

        gridCommonElement.DataSource = dtElement
        gridSector.DataSource = dtSector

        If dtElement.Select("IsSelected=0").Length = 0 Then
            chkElements.Text = "Uncheck All"
            chkElements.Checked = True
        End If

        If dtSector.Select("IsSelected=0").Length = 0 Then
            chkSectors.Text = "Uncheck All"
            chkSectors.Checked = True
        End If
    End Sub

    Private Sub Save()
        Dim sb1 As New System.Text.StringBuilder
        For Each gridSelectedItem As DataGridViewRow In gridCommonElement.Rows
            If CBool(gridSelectedItem.Cells("gridColIsRead").Value) Then
                If sb1.ToString = "" Then
                    'exclude PIN
                    If gridSelectedItem.Cells("gridColCode").Value <> 43 Then
                        sb1.Append(gridSelectedItem.Cells("gridColCode").Value)
                    End If
                Else
                    'exclude PIN
                    If gridSelectedItem.Cells("gridColCode").Value <> 43 Then
                        sb1.Append("," & gridSelectedItem.Cells("gridColCode").Value)
                    End If
                End If
            End If
        Next

        Dim sb2 As New System.Text.StringBuilder
        For Each gridSelectedItem As DataGridViewRow In gridSector.Rows
            If CBool(gridSelectedItem.Cells("gridColSectorIsRead").Value) Then
                If sb2.ToString = "" Then
                    sb2.Append(gridSelectedItem.Cells("gridColSectorCode").Value)
                Else
                    sb2.Append("," & gridSelectedItem.Cells("gridColSectorCode").Value)
                End If
            End If
        Next

        My.Settings.UMID_Element_Visible = sb1.ToString
        My.Settings.Sector_Visible = sb2.ToString
        My.Settings.Save()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If Not IsCheckUMIDElementTable() Then
            SharedFunction.ShowErrorMessage("Please select at least one umid element")
        Else
            Save()
            SharedFunction.ShowInfoMessage("Changes has been saved")
            IsHaveChanges = False
        End If
    End Sub

    Private Sub chkSectors_CheckStateChanged(sender As Object, e As System.EventArgs) Handles chkSectors.CheckStateChanged
        Cursor.Hide()
        Me.Enabled = False

        For Each rw As DataRow In dtSector.Rows
            rw("IsSelected") = chkSectors.Checked
        Next

        gridSector.DataSource = dtSector

        chkSectors.Text = IIf(Not chkSectors.Checked, "Check All", "Uncheck All")

        Cursor.Show()
        Me.Enabled = True
    End Sub

    Private Sub chkElements_CheckStateChanged(sender As System.Object, e As System.EventArgs) Handles chkElements.CheckStateChanged
        Cursor.Hide()
        Me.Enabled = False

        For Each rw As DataRow In dtElement.Rows
            rw("IsSelected") = chkElements.Checked
        Next

        gridCommonElement.DataSource = dtElement

        chkElements.Text = IIf(Not chkElements.Checked, "Check All", "Uncheck All")

        Cursor.Show()
        Me.Enabled = True
    End Sub

    Private Sub ChipData_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'check first if at least one element is selected
        If Not IsCheckUMIDElementTable() Then
            SharedFunction.ShowErrorMessage("Please select at least one umid element")
            e.Cancel = True
            Return
        End If

        If IsHaveChanges Then
            If SharedFunction.ShowMessage("Do you want to save changes made?") = Windows.Forms.DialogResult.Yes Then Save()
        End If
    End Sub

    Private Function IsCheckUMIDElementTable() As Boolean
        For i As Integer = 0 To gridCommonElement.Rows.Count - 1
            If CBool(DirectCast(gridCommonElement.Rows(i).Cells("gridColIsRead"), DataGridViewCheckBoxCell).Value) Then Return True
        Next

        Return False
    End Function

    Private Sub GetTableItemsCount(ByVal grid As DataGridView, ByRef intCount As Integer)
        For i As Integer = 0 To grid.Rows.Count - 1
            If CBool(DirectCast(grid.Rows(i).Cells(2), DataGridViewCheckBoxCell).Value) Then intCount += 1
        Next
    End Sub

    Private Sub gridCommonElement_CurrentCellDirtyStateChanged(sender As Object, e As System.EventArgs) Handles gridCommonElement.CurrentCellDirtyStateChanged
        If gridCommonElement.IsCurrentCellDirty Then
            IsHaveChanges = True
            gridCommonElement.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
   
End Class