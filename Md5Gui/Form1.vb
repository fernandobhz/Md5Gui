Imports System.Text
Imports System.Security.Cryptography

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.HashResultTextBox.Text = GeraHashMD5(Me.TextoToHashTextBox.Text)
    End Sub

    Public Function GeraHashMD5(ByVal texto As String) As String
        Dim btyScr() As Byte = ASCIIEncoding.ASCII.GetBytes(texto)
        Dim objMd5 As New MD5CryptoServiceProvider()
        Dim btyRes() As Byte = objMd5.ComputeHash(btyScr)
        Dim intTotal As Integer = (CInt(btyRes.Length * 2) + CInt((btyRes.Length / 8)))
        Dim strRes As StringBuilder = New StringBuilder(intTotal)
        Dim intI As Integer

        For intI = 0 To btyRes.Length - 1
            strRes.Append(BitConverter.ToString(btyRes, intI, 1))
        Next intI

        Return strRes.ToString().TrimEnd(New Char() {" "c}).ToLower
    End Function

End Class
