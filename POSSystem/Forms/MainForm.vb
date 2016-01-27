Public Class MainForm

    Private Sub MetroTileItem1_Click(sender As Object, e As EventArgs) Handles MetroTileItem1.Click
        lblSelectedForm.Text = "Inventory"
        selectpage()
    End Sub
    Private Sub MetroTileItem2_Click(sender As Object, e As EventArgs) Handles MetroTileItem2.Click
        lblSelectedForm.Text = "Transactions"
        selectpage()
    End Sub

    Private Sub MetroTileItem3_Click(sender As Object, e As EventArgs) Handles MetroTileItem3.Click
        lblSelectedForm.Text = "Users"
        selectpage()
    End Sub
    Private Sub MetroTileItem6_Click(sender As Object, e As EventArgs) Handles MetroTileItem6.Click
        lblSelectedForm.Text = "Reports"
        selectpage()
    End Sub
    Private Sub selectpage()
        Select Case lblSelectedForm.Text
            Case Is = "Inventory"
                SlidePanel2.Visible = False
                SlidePanel2.IsOpen = False
                SlidePanel2.Controls.Clear()
                Inventory.TopLevel = False
                Me.SlidePanel2.Controls.Add(Inventory)
                SlidePanel2.Visible = True
                Inventory.Show()
                SlidePanel2.IsOpen = True
                Inventory.Left = (SlidePanel2.Width - Inventory.Width) / 2
                Inventory.Top = (SlidePanel2.Height - Inventory.Height) / 2
            Case Is = "Transactions"
                SlidePanel2.Visible = False
                SlidePanel2.IsOpen = False
                SlidePanel2.Controls.Clear()
                Transactions.TopLevel = False
                Me.SlidePanel2.Controls.Add(Transactions)
                SlidePanel2.Visible = True
                Transactions.Show()
                SlidePanel2.IsOpen = True
                Inventory.Left = (SlidePanel2.Width - Transactions.Width) / 2
                Inventory.Top = (SlidePanel2.Height - Transactions.Height) / 2
            Case Is = "Users"
                SlidePanel2.Visible = False
                SlidePanel2.IsOpen = False
                SlidePanel2.Controls.Clear()
                Users.TopLevel = False
                Me.SlidePanel2.Controls.Add(Users)
                SlidePanel2.Visible = True
                Users.Show()
                SlidePanel2.IsOpen = True
                Users.Left = (SlidePanel2.Width - Users.Width) / 2
                Users.Top = (SlidePanel2.Height - Users.Height) / 2
            Case Is = "Reports"
                SlidePanel2.Visible = False
                SlidePanel2.IsOpen = False
                SlidePanel2.Controls.Clear()
                Reports.TopLevel = False
                Me.SlidePanel2.Controls.Add(Reports)
                SlidePanel2.Visible = True
                Reports.Show()
                SlidePanel2.IsOpen = True
                Reports.Left = (SlidePanel2.Width - Reports.Width) / 2
                Reports.Top = (SlidePanel2.Height - Reports.Height) / 2
        End Select
    End Sub

    Private Sub MainForm_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Dim db As New DBHelper(My.Settings.DBconn)
        Dim parameters As New Dictionary(Of String, Object)()
        parameters.Add("username", Login.userName)
        db.ExecuteNonQuery("UPDATE Users SET loggedin='NO' WHERE username=@username", parameters)
    End Sub

End Class