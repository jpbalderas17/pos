Imports System.Data.SqlClient
Imports DevComponents.DotNetBar
Imports System.Data
Imports System.IO

Public Class Reports
    Dim db As New DBHelper(My.Settings.DBconn)
    Dim dr As SqlClient.SqlDataReader
    Dim parameters As New Dictionary(Of String, Object)
    Dim stringBuilder As String

End Class