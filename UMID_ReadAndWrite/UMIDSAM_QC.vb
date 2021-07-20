
Imports System.Runtime.InteropServices

Public Class UMIDSAM_QC

    Private Const _dll As String = "UMIDSAM.dll"

    <DllImport(_dll)> _
    Public Shared Function SmartReader_Connect_Debug(ByVal iUMID As Integer, ByVal iSAM As Integer, ByVal ErrorMessage As Byte()) As [Boolean]
    End Function

    <DllImport(_dll)> _
    Public Shared Function UMIDCard_Connect(ByVal ErrorMessage As Byte()) As [Boolean]
    End Function

    <DllImport(_dll)> _
    Public Shared Function UMIDSAM_Connect(ByVal ErrorMessage As Byte()) As [Boolean]
    End Function

    <DllImport(_dll)> _
    Public Shared Sub UMIDCard_DisConnect()
    End Sub

End Class
