<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblUserName = New DevComponents.DotNetBar.LabelX()
        Me.lblPassWord = New DevComponents.DotNetBar.LabelX()
        Me.txtUserName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPassWord = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnLogin = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'lblUserName
        '
        '
        '
        '
        Me.lblUserName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblUserName.Location = New System.Drawing.Point(40, 47)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(75, 23)
        Me.lblUserName.TabIndex = 0
        Me.lblUserName.Text = "Username"
        '
        'lblPassWord
        '
        '
        '
        '
        Me.lblPassWord.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblPassWord.Location = New System.Drawing.Point(40, 75)
        Me.lblPassWord.Name = "lblPassWord"
        Me.lblPassWord.Size = New System.Drawing.Size(75, 23)
        Me.lblPassWord.TabIndex = 1
        Me.lblPassWord.Text = "Password"
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtUserName.Border.Class = "TextBoxBorder"
        Me.txtUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUserName.ForeColor = System.Drawing.Color.Black
        Me.txtUserName.Location = New System.Drawing.Point(109, 47)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.PreventEnterBeep = True
        Me.txtUserName.Size = New System.Drawing.Size(230, 22)
        Me.txtUserName.TabIndex = 2
        '
        'txtPassWord
        '
        Me.txtPassWord.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPassWord.Border.Class = "TextBoxBorder"
        Me.txtPassWord.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPassWord.ForeColor = System.Drawing.Color.Black
        Me.txtPassWord.Location = New System.Drawing.Point(109, 77)
        Me.txtPassWord.Name = "txtPassWord"
        Me.txtPassWord.PreventEnterBeep = True
        Me.txtPassWord.Size = New System.Drawing.Size(230, 22)
        Me.txtPassWord.TabIndex = 3
        '
        'btnLogin
        '
        Me.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnLogin.Location = New System.Drawing.Point(264, 105)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2)
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 157)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassWord)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.lblPassWord)
        Me.Controls.Add(Me.lblUserName)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblUserName As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblPassWord As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtUserName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPassWord As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnLogin As DevComponents.DotNetBar.ButtonX
End Class
