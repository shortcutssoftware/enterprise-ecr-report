Public Class fPinScreen
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents lbPinHeading As System.Windows.Forms.Label
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btnC As System.Windows.Forms.Button
    Friend WithEvents btn0 As System.Windows.Forms.Button
    Friend WithEvents tbPinNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lbEnterPin As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fPinScreen))
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbPinHeading = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.lbEnterPin = New System.Windows.Forms.Label
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnC = New System.Windows.Forms.Button
        Me.btn0 = New System.Windows.Forms.Button
        Me.btn9 = New System.Windows.Forms.Button
        Me.btn8 = New System.Windows.Forms.Button
        Me.btn7 = New System.Windows.Forms.Button
        Me.btn6 = New System.Windows.Forms.Button
        Me.btn5 = New System.Windows.Forms.Button
        Me.btn4 = New System.Windows.Forms.Button
        Me.btn3 = New System.Windows.Forms.Button
        Me.btn2 = New System.Windows.Forms.Button
        Me.btn1 = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.tbPinNumber = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbPinHeading)
        Me.Panel1.Name = "Panel1"
        '
        'lbPinHeading
        '
        Me.lbPinHeading.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lbPinHeading, "lbPinHeading")
        Me.lbPinHeading.ForeColor = System.Drawing.Color.White
        Me.lbPinHeading.Name = "lbPinHeading"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel1)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.btnBack)
        Me.Panel3.Controls.Add(Me.btnC)
        Me.Panel3.Controls.Add(Me.btn0)
        Me.Panel3.Controls.Add(Me.btn9)
        Me.Panel3.Controls.Add(Me.btn8)
        Me.Panel3.Controls.Add(Me.btn7)
        Me.Panel3.Controls.Add(Me.btn6)
        Me.Panel3.Controls.Add(Me.btn5)
        Me.Panel3.Controls.Add(Me.btn4)
        Me.Panel3.Controls.Add(Me.btn3)
        Me.Panel3.Controls.Add(Me.btn2)
        Me.Panel3.Controls.Add(Me.btn1)
        Me.Panel3.Controls.Add(Me.btnCancel)
        Me.Panel3.Controls.Add(Me.tbPinNumber)
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.Controls.Add(Me.lbEnterPin)
        Me.Panel4.Name = "Panel4"
        '
        'lbEnterPin
        '
        Me.lbEnterPin.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lbEnterPin, "lbEnterPin")
        Me.lbEnterPin.ForeColor = System.Drawing.Color.White
        Me.lbEnterPin.Name = "lbEnterPin"
        '
        'btnBack
        '
        resources.ApplyResources(Me.btnBack, "btnBack")
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Name = "btnBack"
        '
        'btnC
        '
        resources.ApplyResources(Me.btnC, "btnC")
        Me.btnC.ForeColor = System.Drawing.Color.White
        Me.btnC.Name = "btnC"
        '
        'btn0
        '
        resources.ApplyResources(Me.btn0, "btn0")
        Me.btn0.ForeColor = System.Drawing.Color.White
        Me.btn0.Name = "btn0"
        '
        'btn9
        '
        resources.ApplyResources(Me.btn9, "btn9")
        Me.btn9.ForeColor = System.Drawing.Color.White
        Me.btn9.Name = "btn9"
        '
        'btn8
        '
        resources.ApplyResources(Me.btn8, "btn8")
        Me.btn8.ForeColor = System.Drawing.Color.White
        Me.btn8.Name = "btn8"
        '
        'btn7
        '
        resources.ApplyResources(Me.btn7, "btn7")
        Me.btn7.ForeColor = System.Drawing.Color.White
        Me.btn7.Name = "btn7"
        '
        'btn6
        '
        resources.ApplyResources(Me.btn6, "btn6")
        Me.btn6.ForeColor = System.Drawing.Color.White
        Me.btn6.Name = "btn6"
        '
        'btn5
        '
        resources.ApplyResources(Me.btn5, "btn5")
        Me.btn5.ForeColor = System.Drawing.Color.White
        Me.btn5.Name = "btn5"
        '
        'btn4
        '
        resources.ApplyResources(Me.btn4, "btn4")
        Me.btn4.ForeColor = System.Drawing.Color.White
        Me.btn4.Name = "btn4"
        '
        'btn3
        '
        resources.ApplyResources(Me.btn3, "btn3")
        Me.btn3.ForeColor = System.Drawing.Color.White
        Me.btn3.Name = "btn3"
        '
        'btn2
        '
        resources.ApplyResources(Me.btn2, "btn2")
        Me.btn2.ForeColor = System.Drawing.Color.White
        Me.btn2.Name = "btn2"
        '
        'btn1
        '
        resources.ApplyResources(Me.btn1, "btn1")
        Me.btn1.ForeColor = System.Drawing.Color.White
        Me.btn1.Name = "btn1"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Silver
        resources.ApplyResources(Me.btnCancel, "btnCancel")
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'tbPinNumber
        '
        resources.ApplyResources(Me.tbPinNumber, "tbPinNumber")
        Me.tbPinNumber.Name = "tbPinNumber"
        '
        'fPinScreen
        '
        resources.ApplyResources(Me, "$this")
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fPinScreen"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        Me.tbPinNumber.Text = Me.tbPinNumber.Text & "1"
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        Me.tbPinNumber.Text = Me.tbPinNumber.Text & "2"
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        Me.tbPinNumber.Text = Me.tbPinNumber.Text & "3"
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        Me.tbPinNumber.Text = Me.tbPinNumber.Text & "4"
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        Me.tbPinNumber.Text = Me.tbPinNumber.Text & "5"
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        Me.tbPinNumber.Text = Me.tbPinNumber.Text & "6"
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        Me.tbPinNumber.Text = Me.tbPinNumber.Text & "7"
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        Me.tbPinNumber.Text = Me.tbPinNumber.Text & "8"
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        Me.tbPinNumber.Text = Me.tbPinNumber.Text & "9"
    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        Me.tbPinNumber.Text = Me.tbPinNumber.Text & "0"
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

        If Me.tbPinNumber.Text.Length > 0 Then
            Me.tbPinNumber.Text = Me.tbPinNumber.Text.Remove(Me.tbPinNumber.Text.Length - 1, 1)
        End If

    End Sub

    Private Sub btnC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC.Click
        Me.tbPinNumber.Text = ""
    End Sub

    Private Sub tbPinNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbPinNumber.TextChanged
        If Me.tbPinNumber.Text.Length = 4 Then
            SDA.strSqlSP = "dbo.usp_BIComReportSecurityCheck"
            SDA.AddParam("@Pin", Me.tbPinNumber.Text, SqlDbType.Text)
            SDA.SqlGetDataSingleRow()

            If SDA.SqlSingleRow(0) <> 0 Then

                'Put entry into log table
                SDA.strSqlSP = "dbo.usp_BIComReportLogInsert"
                SDA.AddParam("@Msg", "Commissions Program - User logged in", SqlDbType.Text)
                SDA.AddParam("@EmpID", SDA.SqlSingleRow(0), SqlDbType.Int)
                SDA.SqlExecute()

                FadeOut(Me)
                Dim fMain As Form = New fMain
                fMain.Show()

            Else
                Me.tbPinNumber.Text = Nothing
            End If
        End If


    End Sub



    Private Sub fPinScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.tbPinNumber.Focus()
        Me.tbPinNumber.Select()
    End Sub

End Class
