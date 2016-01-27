Imports System.Data.SqlClient
Imports DevComponents.DotNetBar
Imports System
Imports System.Data
Imports System.IO
Imports System.Data.OleDb

Public Class Transactions
    Dim db As New DBHelper(My.Settings.DBconn)
    Dim dr As SqlClient.SqlDataReader
    Dim DS As New DataSet
    Dim DA As New SqlDataAdapter
    Dim DT As New DataTable
    Dim parameters As New Dictionary(Of String, Object)
    Dim cmd As SqlCommand
    Dim sql As String = ""
    Dim index As String = ""
    Dim valuePName As String = ""
    Dim search As String = ""
    Dim valuePrice As String = ""
    Dim valuePCode As String = ""
    Dim valueStock As String = ""
    Dim stockHolder As String = ""
    Dim stockCheck As Integer
    Dim sum As Integer
    Dim count As Integer
    Dim exists As Boolean
    Dim updateStatement As String
    Dim insertStatement As String
    Dim itm As ListViewItem
    Dim transactionDate As Date
    Dim transactionID As String


    'cmd.Connection = cn
    'Dim cmd As SqlClient.SqlCommand
    Private Sub Transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.ForeColor = Color.White
        Label1.BackColor = Color.FromArgb(221, 170, 32)
        lblSearch.ForeColor = Color.FromArgb(43, 87, 154)
        lblTotalItems.ForeColor = Color.White
        lblTotalItems.BackColor = Color.FromArgb(117, 112, 107)
        Label2.ForeColor = Color.White
        Label2.BackColor = Color.FromArgb(117, 112, 107)
        Label3.ForeColor = Color.White
        Label3.BackColor = Color.FromArgb(221, 170, 32)
        'Label15.ForeColor = Color.White
        'Label15.BackColor = Color.FromArgb(221, 170, 32)
        'lblItemFig.ForeColor = Color.FromArgb(119, 187, 20)
        lblItemFig.ForeColor = Color.White
        lblItemFig.BackColor = Color.FromArgb(117, 112, 107)
        'lblAmtFig.ForeColor = Color.FromArgb(119, 187, 20)
        lblAmtFig.ForeColor = Color.White
        lblAmtFig.BackColor = Color.FromArgb(117, 112, 107)
        btnCash.ForeColor = Color.White
        'dgvSummary.ForeColor = Color.FromArgb(117, 112, 107)
        'dgvProducts.ForeColor = Color.FromArgb(117, 112, 107)
        dgvSummary.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvSummary.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke


        GetProducts()
        ClearGridFocus()
        'PopulateProductSummary()
        txtSearch.Focus()

    End Sub

    Public Sub GetProducts()
        search = txtSearch.Text
        sql = "SELECT * FROM Products WHERE ProductCode LIKE '%" & search.ToString() & "%' or ProductName LIKE '%" & search.ToString() & "%'"
        DS = New DataSet
        DA = New SqlClient.SqlDataAdapter(sql, My.Settings.DBconn)
        DA.Fill(DS, 0)
        If Not DS.Tables.Count = 0 Then
            dgvProducts.DataSource = DS.Tables(0)
        End If

        'Try



        '    dr = db.ExecuteReader("SELECT * FROM Products")
        '    If dr.HasRows Then
        '        Do While dr.Read
        '            itm = lvMenu.Items.Add(dr.Item("productcode"))
        '            itm.SubItems.Add(dr.Item("productname"))
        '            itm.SubItems.Add(dr.Item("price"))
        '            itm.SubItems.Add(dr.Item("stock"))
        '        Loop

        '    Else
        '        MsgBox("No item found!", vbExclamation + vbOKOnly, "No record(s)")
        '    End If

        'Catch ex As Exception
        '    MsgBox("Error occured!" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error")
        'Finally
        '    db.Dispose()
        'End Try
    End Sub


    Public Sub AddTotal()
        sum = 0
        count = 0
        For index As Integer = 0 To dgvSummary.RowCount - 1
            sum += Convert.ToInt32(dgvSummary.Rows(index).Cells(4).Value)
            count += Convert.ToInt32(dgvSummary.Rows(index).Cells(3).Value)
        Next

        lblAmtFig.Text = sum.ToString()
        lblItemFig.Text = count.ToString()

    End Sub

    Public Sub dgvProducts_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProducts.CellContentClick
        'check it the button column being clicked, and check they are not clicking the column heading
        If e.RowIndex >= 0 Then
            'dgvProducts.Rows.RemoveAt(e.RowIndex)
            index = e.RowIndex
            'itm = lvSummary.Items.Add(dgvProducts.Rows(index).Cells(1).Value)
            'itm.SubItems.Add(dgvProducts.Rows(index).Cells(3).Value)

            'dgvSummary.Rows.Insert(1, (valuePCode.ToString), (valuePrice.ToString), (valuePrice.ToString))

            'Dim R As DataRow = DT.NewRow
            'R("ProductCode") = valuePCode
            'R("ProductName") = valuePName
            'R("Price") = valuePrice
            'DT.Rows.Add(R)
            'dgvSummary.DataSource = DT
            OrderProducts(index)
            'Me.dgvProducts.Rows(0).Cells(4).Selected = True
        End If
    End Sub

    Private Sub dgvSummary_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSummary.CellDoubleClick
        If e.ColumnIndex = 1 And e.RowIndex >= 0 Then
            RemoveItem(index)
        End If
    End Sub

    Public Function PopulateProductSummary()
        'DT.Columns.Add("ProductCode")
        'DT.Columns.Add("ProductName")
        'dt.Columns.Add("Price")
    End Function

    Private Sub dgvSummary_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSummary.CellValueChanged
        If dgvSummary.Rows.Count > 0 And e.ColumnIndex = 3 Then
            index = e.RowIndex

            'eto yung next part,dat ma equal sa dgvprod yung quantity
            'For Each row As DataGridViewRow In dgvSummary.Rows
            '    If row.Cells(0).Value = valuePCode AndAlso Convert.ToInt32(row.Cells(5).Value) < Convert.ToInt32(row.Cells(3).Value) Then
            '        exists = True
            '    End If
            'Next

            'If exists = True Then

            '    Dim ResponseDialogResult As DialogResult
            '    ResponseDialogResult = MsgBox("Quantity placed exceeds stock!", vbExclamation + vbOKOnly, "")
            '    If ResponseDialogResult = DialogResult.OK Then
            '        stockHolder = index
            '        stockCheck = Convert.ToInt32(stockHolder)
            '        dgvSummary.Rows(index).Cells(3).Value = ""
            '        ClearGridFocus()
            '        dgvSummary.ClearSelection()
            '        RemoveItem(index)
            '        dgvSummary.CurrentCell = dgvSummary.Item("Quantity", stockCheck)
            '        dgvSummary.BeginEdit(True)
            '    End If

            'Else
            Dim iCell1 As Integer
            Dim icell2 As Integer
            Dim icellResult As Integer

            iCell1 = dgvSummary.Rows(index).Cells(2).Value
            icell2 = dgvSummary.Rows(index).Cells(3).Value
            icellResult = iCell1 * icell2
            'dgvSummary.Rows.Insert(2, icellResult.ToString)
            dgvSummary.Rows(index).Cells(4).Value = icellResult
            AddTotal()
            ClearGridFocus()
            txtSearch.Text = ""
            txtSearch.Focus()
            'End If
            'exists = False
        End If
    End Sub

    Private Sub dgvSummary_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        ''#See if the left mouse button was clicked
        If e.Button = MouseButtons.Left Then
            ''#Check the HitTest information for this click location
            'If dgvSummary.HitTest(e.X, e.Y) = HitTestInfo.Nowhere Then
            'dgvSummary.ClearSelection()
            'dgvSummary.CurrentCell = Nothing
        End If
    End Sub

    Protected Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        GetProducts()
        ClearGridFocus()
    End Sub

    Private Sub textBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvProducts.KeyDown
        If e.KeyCode = Keys.Enter Then
            index = dgvProducts.CurrentRow.Index
            OrderProducts(index)
        End If
    End Sub

    Public Sub OrderProducts(index)
        valuePCode = dgvProducts.Rows(index).Cells(0).Value
        valuePName = dgvProducts.Rows(index).Cells(1).Value
        valuePrice = dgvProducts.Rows(index).Cells(3).Value
        valueStock = dgvProducts.Rows(index).Cells(2).Value

        search = index
        'For search As Integer = 0 To dgvSummary.RowCount = 0
        'sum += Convert.ToInt32(dgvSummary.Rows(index).Cells(4).Value)
        'count += Convert.ToInt32(dgvSummary.Rows(index).Cells(3).Value)
        'If valuePCode = dgvSummary.Rows(index).Cells(0).Value Then

        'End If
        'Next

        'For Each row As DataGridViewRow In dgvSummary.Rows
        '    If row.Cells(0).Value = valuePCode Then
        '        exists = True
        '    End If
        'Next

        'If exists = True Then

        '    Dim ResponseDialogResult As DialogResult
        '    ResponseDialogResult = MsgBox("Already ordered!", vbExclamation + vbOKOnly, "")
        '    If ResponseDialogResult = DialogResult.OK Then
        '        ClearGridFocus()
        '        txtSearch.Text = ""
        '        txtSearch.Focus()
        '    End If

        'Else
        dgvSummary.Rows.Insert(0, New String() {valuePCode, valuePName, valuePrice, 0, 0, valueStock})
        dgvSummary.Rows(index).Cells(3).Value = "1"
        ClearGridFocus()

        'dgvProducts.ClearSelection()
        'dgvProducts.CurrentCell = Nothing
        'txtSearch.Text = ""
        'txtSearch.Focus()
        'dgvSummary.CurrentCell = dgvSummary.Item("Quantity", 0)
        'dgvSummary.BeginEdit(True)
        'End If
        'exists = False
    End Sub

    Public Sub ClearGridFocus()
        dgvSummary.ClearSelection()
        dgvSummary.CurrentCell = Nothing
        dgvProducts.ClearSelection()
        dgvProducts.CurrentCell = Nothing
    End Sub

    'Private Sub SearcHotkey(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
    '    If (e.Alt AndAlso (e.KeyCode = Keys.S)) Then
    '    If Keys.S AndAlso Keys.ControlKey Then
    '        txtSearch.Focus()
    '    End If
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        SlidePanel3.Visible = False
        SlidePanel3.IsOpen = False
        SlidePanel3.Controls.Clear()
        'panelPayment.TopLevel = False
        Me.SlidePanel3.Controls.Add(panelPayment)
        SlidePanel3.Visible = True
        SlidePanel3.Show()
        SlidePanel3.IsOpen = True
        SlidePanel3.Left = (SlidePanel3.Width - panelPayment.Width) / 2
        SlidePanel3.Top = (SlidePanel3.Height - panelPayment.Height) / 2
    End Sub


    Private Sub btnCash_Click_1(sender As Object, e As EventArgs) Handles btnCash.Click
        SlidePanel3.Visible = False
        SlidePanel3.IsOpen = False
        SlidePanel3.Controls.Clear()
        'panelPayment.TopLevel = False
        Me.SlidePanel3.Controls.Add(panelPayment)
        SlidePanel3.Visible = False
        panelPayment.Show()
        SlidePanel3.IsOpen = True
        panelPayment.Left = (SlidePanel3.Width - panelPayment.Width) / 2
        panelPayment.Top = (SlidePanel3.Height - panelPayment.Height) / 2
        txtCashPayment.Focus()
        lblCashNumberItems.Text = lblItemFig.Text
        lblCashAmtDue.Text = lblAmtFig.Text
    End Sub

    Private Sub btnCancelCash_Click(sender As Object, e As EventArgs) Handles btnCancelCash.Click
        SlidePanel3.Visible = False
        SlidePanel3.IsOpen = False
        txtSearch.Focus()
    End Sub

    Protected Sub txtCashPayment_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCashPayment.TextChanged
        If txtCashPayment.Text = "" Then
            lblCashChange.Text = 0
        Else
            lblCashChange.Text = Convert.ToDouble(txtCashPayment.Text) - Convert.ToDouble(lblCashAmtDue.Text)
            If Convert.ToDouble(txtCashPayment.Text) = 0 Or Convert.ToDouble(lblCashAmtDue.Text) = 0 Or Convert.ToDouble(lblCashChange.Text) < 0 Then
                btnCashSubmit.Enabled = False
            Else
                btnCashSubmit.Enabled = True
            End If
        End If
    End Sub

    Public Sub RemoveItem(index)
        dgvSummary.Rows.RemoveAt(index)
        AddTotal()
        ClearGridFocus()
        txtSearch.Text = ""
        txtSearch.Focus()
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dgvSummary.Rows.Clear()
    End Sub

    Private Sub btnCashSubmit_Click(sender As Object, e As EventArgs) Handles btnCashSubmit.Click
        SaveCashPayment()
        MsgBox("Transaction successful!", vbExclamation + vbOKOnly, "")
        SlidePanel3.Visible = False
        SlidePanel3.IsOpen = False
        txtSearch.Text = ""
        txtSearch.Focus()
        dgvSummary.Rows.Clear()
        ClearGridFocus()
        GetProducts()
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs)
        'SlidePanel4.Visible = False
        'SlidePanel4.IsOpen = False
        'SlidePanel4.Controls.Clear()
        ''panelPayment.TopLevel = False
        'Me.SlidePanel4.Controls.Add(panelCheck)
        'SlidePanel4.Visible = False
        'panelCheck.Show()
        'SlidePanel4.IsOpen = True
        'panelCheck.Left = (SlidePanel3.Width - panelCheck.Width) / 2
        'panelCheck.Top = (SlidePanel3.Height - panelCheck.Height) / 2
        'txtCashPayment.Focus()
        'lblCashNumberItems.Text = lblItemFig.Text
        'lblCashAmtDue.Text = lblAmtFig.Text
    End Sub

    Private Sub btnCancelCheck_Click_1(sender As Object, e As EventArgs)
        'SlidePanel4.Visible = False
        'SlidePanel4.IsOpen = False
        'txtSearch.Focus()
    End Sub

    Public Sub SaveCashPayment()
        transactionDate = DateTime.Now.ToString
        transactionID = transactionDate.ToString("yyyyMMddhmmss") + Login.userNumber
        parameters.Add("AmountDue", lblCashAmtDue.Text)
        parameters.Add("PaymentAmount", txtCashPayment.Text)
        parameters.Add("ChangeAmount", lblCashChange.Text)
        parameters.Add("ItemsSold", lblCashNumberItems.Text)
        parameters.Add("PaymentType", "CASH")
        parameters.Add("TransactionDate", transactionDate)
        parameters.Add("TransactionID", transactionID)
        parameters.Add("UserName", Login.userName)
        db.ExecuteNonQuery("INSERT INTO Transactions(TransactionID,AmountDue,PaymentAmount,ChangeAmount,ItemsSold,PaymentType,TransactionDate, UserName) VALUES(@TransactionID, @AmountDue, @PaymentAmount, @ChangeAmount, @ItemsSold, @PaymentType, @TransactionDate, @UserName)", parameters)

        ' db.ExecuteNonQuery("UPDATE Products SET name=@name, percentage=@percentage WHERE car_brand_id=@car_brand_id", parameters)

        For Each row As DataGridViewRow In dgvSummary.Rows
            insertStatement = insertStatement + "INSERT INTO SalesLogs (TransactionID, ProductCode, Quantity) VALUES(" + "'" + transactionID + "', '" + row.Cells(0).Value + "'" + ", '" + row.Cells(3).Value + "')" + vbCrLf
        Next
        db.ExecuteNonQuery(insertStatement)


        For Each row As DataGridViewRow In dgvSummary.Rows
            stockHolder = Convert.ToInt32(row.Cells(5).Value) - Convert.ToInt32(row.Cells(3).Value)
            updateStatement = updateStatement + "UPDATE Products SET Stock=" + stockHolder.ToString() + " WHERE ProductCode=" + "'" + row.Cells(0).Value + "'" + vbCrLf
        Next
        db.ExecuteNonQuery(updateStatement)
        parameters.Clear()
    End Sub

    Public Sub PopulateComboBox()
        GetProducts()
        If Not DS.Tables(0).Rows.Count = 0 Then
            cmbProductCode.DataSource = DS.Tables(0)
            cmbProductCode.ValueMember = "ProductCode"
            cmbProductCode.DisplayMember = "ProductCode"

            Dim col As New AutoCompleteStringCollection
            Dim i As Integer
            For i = 0 To DS.Tables(0).Rows.Count - 1
                col.Add(DS.Tables(0).Rows(i)("ProductCode").ToString())
            Next
            cmbProductCode.AutoCompleteSource = AutoCompleteSource.CustomSource
            cmbProductCode.AutoCompleteCustomSource = col
            cmbProductCode.AutoCompleteMode = AutoCompleteMode.Suggest
        End If
    End Sub


End Class