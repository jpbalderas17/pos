Imports System.Data.SqlClient
Imports DevComponents.DotNetBar
Imports System.Data
Imports System.IO
Imports System.Security.Cryptography
Imports System.Runtime.InteropServices
Imports System.Text

Public Class Users
    Dim db As New DBHelper(My.Settings.DBconn)
    Dim dr As SqlClient.SqlDataReader
    Dim parameters As New Dictionary(Of String, Object)
    Dim stringBuilder As String

    Private Shared DES As New TripleDESCryptoServiceProvider
    Private Shared MD5 As New MD5CryptoServiceProvider
    Public Shared Function MD5Hash(ByVal value As String) As Byte()
        Return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))
    End Function

    Public Shared Function Encrypt(ByVal stringToEncrypt As String, ByVal key As String) As String
        DES.Key = Login.MD5Hash(key)
        DES.Mode = CipherMode.ECB
        Dim Buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(stringToEncrypt)
        Return Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Function

    Public Shared Function Decrypt(ByVal encryptedString As String, ByVal key As String) As String

        DES.Key = Login.MD5Hash(key)
        DES.Mode = CipherMode.ECB

        Dim Buffer As Byte() = Convert.FromBase64String(encryptedString)
        Return ASCIIEncoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Function

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim encryptPass = Encrypt(txtPassword.Text, "Keys")
        parameters.Add("UserName", txtUsername.Text)
        parameters.Add("Password", encryptPass)
        parameters.Add("UserLevel", txtUserType.Text)
        parameters.Add("FirstName", txtFirstName.Text)
        parameters.Add("MiddleName", txtMiddleName.Text)
        parameters.Add("LastName", txtLastName.Text)
        stringBuilder = "INSERT INTO USERS (UserName, Password, UserLevel, FirstName, MiddleName, LastName) VALUES(@UserName, @Password, @UserLevel, @FirstName, @MiddleName, @LastName)"
        
        db.ExecuteNonQuery(stringBuilder, parameters)
        parameters.Clear()
        MsgBox("Registration successful!", vbExclamation + vbOKOnly, "")
    End Sub
End Class