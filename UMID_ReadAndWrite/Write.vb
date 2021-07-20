
Public Class Write

    Private Sub Write_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cboSector.Items.Add("-Select-")
        For i = 1 To 36
            cboSector.Items.Add("Sector " & i.ToString)
        Next
        cboSector.SelectedIndex = 0
    End Sub

    Private Sub btnRead_Click(sender As System.Object, e As System.EventArgs) Handles btnRead.Click
        cboSector.BackColor = Color.White
        txtValue.BackColor = Color.White

        If cboSector.SelectedIndex > 0 Then
            Dim errMsg As String = ""
            txtValue.Text = AllcardUMID.ReadSector(cboSector.SelectedIndex + 36, errMsg).Trim
            If errMsg <> "" Then SharedFunction.SaveToErrorLog(String.Format("{0}{1}", SharedFunction.TimeStamp, errMsg))

            SharedFunction.ShowInfoMessage("Done...")
        Else
            cboSector.BackColor = Color.Orange
        End If
    End Sub

    Private Sub btnWrite_Click(sender As System.Object, e As System.EventArgs) Handles btnWrite.Click
        cboSector.BackColor = Color.White
        txtValue.BackColor = Color.White

        If cboSector.SelectedIndex = 0 Then cboSector.BackColor = Color.Orange
        If txtValue.Text = "" Then txtValue.BackColor = Color.Orange

        If cboSector.BackColor = Color.White And txtValue.BackColor = Color.White Then
            If SharedFunction.ShowMessage("Continue writing?") = Windows.Forms.DialogResult.Yes Then
                Dim errMsg As String = ""
                If AllcardUMID.WriteSectorData(cboSector.SelectedIndex + 36, txtValue.Text, errMsg) Then
                    If errMsg <> "" Then SharedFunction.SaveToErrorLog(String.Format("{0}{1}", SharedFunction.TimeStamp, errMsg))
                    SharedFunction.ShowInfoMessage("Writing success...")
                    cboSector.SelectedIndex = 0
                    txtValue.Clear()
                Else
                    SharedFunction.ShowErrorMessage("Writing failed...")
                End If
            End If
        End If
    End Sub

End Class