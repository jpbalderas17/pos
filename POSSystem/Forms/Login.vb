Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Web.HttpContext

Public Class Login
    Dim exists As Boolean = False
    Public userName As String
    Public userNumber As String
    Dim passWord As String
    Dim db As New DBHelper(My.Settings.DBconn)
    Dim dr As SqlClient.SqlDataReader
    Dim parameters As New Dictionary(Of String, Object)()

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

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Dim encryptPass = Encrypt(txtPassWord.Text, "Keys")
            parameters.Add("username", txtUserName.Text)
            parameters.Add("password", encryptPass)
            dr = db.ExecuteReader("SELECT usernumber, username, password, loggedin FROM USERS WHERE username=@username AND password=@password", parameters)
            If dr.HasRows Then
                dr.Read()
                Dim isLoggedIn = dr("loggedin").ToString()
                
                If isLoggedIn = "NO" Then
                    Me.Hide()
                    MainForm.Show()
                    db.ExecuteNonQuery("UPDATE Users SET loggedin='YES' WHERE username=@username", parameters)
                    userName = dr("username").ToString()
                    userNumber = dr("usernumber").ToString()
                Else
                    MsgBox("Invalid Username/Password", MsgBoxStyle.Exclamation, "Invalid Username/Password")
                    txtUserName.Text = ""
                    txtPassWord.Text = ""
                    txtUserName.Focus()
                    parameters.Clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            parameters.Clear()
        Finally
            db.Dispose() '<--------CHECK THIS!
            parameters.Clear()
        End Try
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class