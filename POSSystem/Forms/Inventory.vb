Imports System.Data.SqlClient
Imports DevComponents.DotNetBar
Imports System
Imports System.Data
Imports System.IO
Imports System.Data.OleDb

Public Class Inventory
    Dim db As New DBHelper(My.Settings.DBconn)
    Dim dr As SqlClient.SqlDataReader
    Dim DS As New DataSet
    Dim DA As New SqlDataAdapter
    Dim DT As New DataTable
    Dim sql As String = ""
    Dim parameters As New Dictionary(Of String, Object)
    Dim stringBuilder As String
    Dim search As String
    Dim index As String = ""

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetProducts()
        txtSearch.Focus()
        'If Not DS.Tables(0).Rows.Count = 0 Then
        '    cmbProductCode.DataSource = DS.Tables(0)
        '    cmbProductCode.ValueMember = "ProductCode"
        '    cmbProductCode.DisplayMember = "ProductCode"

        '    Dim col As New AutoCompleteStringCollection
        '    Dim i As Integer
        '    For i = 0 To DS.Tables(0).Rows.Count - 1
        '        col.Add(DS.Tables(0).Rows(i)("ProductCode").ToString())
        '    Next
        '    cmbProductCode.AutoCompleteSource = AutoCompleteSource.CustomSource
        '    cmbProductCode.AutoCompleteCustomSource = col
        '    cmbProductCode.AutoCompleteMode = AutoCompleteMode.Suggest
        'End If

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        parameters.Add("ProductCode", txtProductCode.Text)
        parameters.Add("ProductName", txtProductName.Text)
        parameters.Add("Stock", txtQuantity.Text)
        parameters.Add("Price", txtPrice.Text)
        stringBuilder = "if exists(select 1 from products where PRODUCTCODE = @ProductCode)" + vbCrLf
        stringBuilder += "update Products set PRODUCTNAME=UPPER(@ProductName), STOCK=@Stock, PRICE=@Price where PRODUCTCODE=@ProductCode" + vbCrLf
        stringBuilder += "else insert into Products (PRODUCTCODE, PRODUCTNAME, STOCK, PRICE) values (UPPER(@ProductCode), @ProductName, @Stock, @Price)" + vbCrLf
        db.ExecuteNonQuery(stringBuilder, parameters)
        parameters.Clear()
        GetProducts()
        ClearTextBoxes()
        txtSearch.Text = Nothing
        txtSearch.Focus()
        MsgBox("Transaction successful!", vbExclamation + vbOKOnly, "")
    End Sub

    Public Sub GetProducts()
        search = txtSearch.Text
        sql = "SELECT * FROM Products WHERE ProductCode LIKE '%" & search.ToString() & "%' or ProductName LIKE '%" & search.ToString() & "%'"
        'sql = "SELECT * FROM Products"
        DS = New DataSet
        DA = New SqlClient.SqlDataAdapter(sql, My.Settings.DBconn)
        DA.Fill(DS, 0)
        If Not DS.Tables.Count = 0 Then
            dgvProducts.DataSource = DS.Tables(0)
        End If
    End Sub
    Protected Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        GetProducts()
    End Sub

    Public Sub addItems(ByVal col As AutoCompleteStringCollection)
        For Each row As DataGridViewRow In dgvProducts.Rows
            col.Add(row.Cells(0).Value.ToString())
        Next
    End Sub
    Private Sub textBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvProducts.KeyDown
        If e.KeyCode = Keys.Enter Then
            index = dgvProducts.CurrentRow.Index
            OrderProducts(index)
            txtProductCode.Focus()
        End If
    End Sub

    Public Sub OrderProducts(index)
        txtProductCode.Text = dgvProducts.Rows(index).Cells(0).Value
        txtProductName.Text = dgvProducts.Rows(index).Cells(1).Value
        txtPrice.Text = dgvProducts.Rows(index).Cells(3).Value
        txtQuantity.Text = dgvProducts.Rows(index).Cells(2).Value

        'search = index

        'dgvSummary.Rows.Insert(0, New String() {valuePCode, valuePName, valuePrice, 0, 0, valueStock})
        'dgvSummary.Rows(index).Cells(3).Value = "1"
        'ClearGridFocus()
    End Sub

    Private Sub ButtonX1_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        parameters.Add("ProductCode", txtProductCode.Text)
        db.ExecuteNonQuery("delete from products where productcode=@ProductCode", parameters)
        GetProducts()
        ClearTextBoxes()
        txtSearch.Text = Nothing
        txtSearch.Focus()
        parameters.Clear()
        MsgBox("Item Successfully Deleted!", vbExclamation + vbOKOnly, "")
    End Sub
    Public Sub ClearTextBoxes()
        txtProductCode.Text = Nothing
        txtProductName.Text = Nothing
        txtPrice.Text = Nothing
        txtQuantity.Text = Nothing
    End Sub
End Class