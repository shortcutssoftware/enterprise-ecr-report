Public Class fRateEdit
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
    Friend WithEvents lbRate1 As System.Windows.Forms.Label
    Friend WithEvents lbRate3 As System.Windows.Forms.Label
    Friend WithEvents lbRate5 As System.Windows.Forms.Label
    Friend WithEvents lbRate4 As System.Windows.Forms.Label
    Friend WithEvents lbRate2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lbRateTitle As System.Windows.Forms.Label
    Friend WithEvents tb1 As System.Windows.Forms.TextBox
    Friend WithEvents tb2 As System.Windows.Forms.TextBox
    Friend WithEvents tb3 As System.Windows.Forms.TextBox
    Friend WithEvents tb4 As System.Windows.Forms.TextBox
    Friend WithEvents tb5 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fRateEdit))
        Me.tb1 = New System.Windows.Forms.TextBox
        Me.tb2 = New System.Windows.Forms.TextBox
        Me.tb3 = New System.Windows.Forms.TextBox
        Me.tb4 = New System.Windows.Forms.TextBox
        Me.tb5 = New System.Windows.Forms.TextBox
        Me.lbRate1 = New System.Windows.Forms.Label
        Me.lbRate3 = New System.Windows.Forms.Label
        Me.lbRate5 = New System.Windows.Forms.Label
        Me.lbRate4 = New System.Windows.Forms.Label
        Me.lbRate2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.lbRateTitle = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'tb1
        '
        Me.tb1.AccessibleDescription = Nothing
        Me.tb1.AccessibleName = Nothing
        resources.ApplyResources(Me.tb1, "tb1")
        Me.tb1.BackgroundImage = Nothing
        Me.tb1.Font = Nothing
        Me.tb1.Name = "tb1"
        '
        'tb2
        '
        Me.tb2.AccessibleDescription = Nothing
        Me.tb2.AccessibleName = Nothing
        resources.ApplyResources(Me.tb2, "tb2")
        Me.tb2.BackgroundImage = Nothing
        Me.tb2.Font = Nothing
        Me.tb2.Name = "tb2"
        '
        'tb3
        '
        Me.tb3.AccessibleDescription = Nothing
        Me.tb3.AccessibleName = Nothing
        resources.ApplyResources(Me.tb3, "tb3")
        Me.tb3.BackgroundImage = Nothing
        Me.tb3.Font = Nothing
        Me.tb3.Name = "tb3"
        '
        'tb4
        '
        Me.tb4.AccessibleDescription = Nothing
        Me.tb4.AccessibleName = Nothing
        resources.ApplyResources(Me.tb4, "tb4")
        Me.tb4.BackgroundImage = Nothing
        Me.tb4.Font = Nothing
        Me.tb4.Name = "tb4"
        '
        'tb5
        '
        Me.tb5.AccessibleDescription = Nothing
        Me.tb5.AccessibleName = Nothing
        resources.ApplyResources(Me.tb5, "tb5")
        Me.tb5.BackgroundImage = Nothing
        Me.tb5.Font = Nothing
        Me.tb5.Name = "tb5"
        '
        'lbRate1
        '
        Me.lbRate1.AccessibleDescription = Nothing
        Me.lbRate1.AccessibleName = Nothing
        resources.ApplyResources(Me.lbRate1, "lbRate1")
        Me.lbRate1.ForeColor = System.Drawing.Color.White
        Me.lbRate1.Name = "lbRate1"
        '
        'lbRate3
        '
        Me.lbRate3.AccessibleDescription = Nothing
        Me.lbRate3.AccessibleName = Nothing
        resources.ApplyResources(Me.lbRate3, "lbRate3")
        Me.lbRate3.ForeColor = System.Drawing.Color.White
        Me.lbRate3.Name = "lbRate3"
        '
        'lbRate5
        '
        Me.lbRate5.AccessibleDescription = Nothing
        Me.lbRate5.AccessibleName = Nothing
        resources.ApplyResources(Me.lbRate5, "lbRate5")
        Me.lbRate5.ForeColor = System.Drawing.Color.White
        Me.lbRate5.Name = "lbRate5"
        '
        'lbRate4
        '
        Me.lbRate4.AccessibleDescription = Nothing
        Me.lbRate4.AccessibleName = Nothing
        resources.ApplyResources(Me.lbRate4, "lbRate4")
        Me.lbRate4.ForeColor = System.Drawing.Color.White
        Me.lbRate4.Name = "lbRate4"
        '
        'lbRate2
        '
        Me.lbRate2.AccessibleDescription = Nothing
        Me.lbRate2.AccessibleName = Nothing
        resources.ApplyResources(Me.lbRate2, "lbRate2")
        Me.lbRate2.ForeColor = System.Drawing.Color.White
        Me.lbRate2.Name = "lbRate2"
        '
        'Label6
        '
        Me.Label6.AccessibleDescription = Nothing
        Me.Label6.AccessibleName = Nothing
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Font = Nothing
        Me.Label6.Name = "Label6"
        '
        'Label7
        '
        Me.Label7.AccessibleDescription = Nothing
        Me.Label7.AccessibleName = Nothing
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Font = Nothing
        Me.Label7.Name = "Label7"
        '
        'Label8
        '
        Me.Label8.AccessibleDescription = Nothing
        Me.Label8.AccessibleName = Nothing
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Font = Nothing
        Me.Label8.Name = "Label8"
        '
        'Label9
        '
        Me.Label9.AccessibleDescription = Nothing
        Me.Label9.AccessibleName = Nothing
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Font = Nothing
        Me.Label9.Name = "Label9"
        '
        'Label10
        '
        Me.Label10.AccessibleDescription = Nothing
        Me.Label10.AccessibleName = Nothing
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Font = Nothing
        Me.Label10.Name = "Label10"
        '
        'btnClose
        '
        Me.btnClose.AccessibleDescription = Nothing
        Me.btnClose.AccessibleName = Nothing
        resources.ApplyResources(Me.btnClose, "btnClose")
        Me.btnClose.BackColor = System.Drawing.Color.Silver
        Me.btnClose.BackgroundImage = Nothing
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Font = Nothing
        Me.btnClose.Name = "btnClose"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.AccessibleDescription = Nothing
        Me.btnSave.AccessibleName = Nothing
        resources.ApplyResources(Me.btnSave, "btnSave")
        Me.btnSave.BackColor = System.Drawing.Color.Silver
        Me.btnSave.BackgroundImage = Nothing
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = Nothing
        Me.btnSave.Name = "btnSave"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lbRateTitle
        '
        Me.lbRateTitle.AccessibleDescription = Nothing
        Me.lbRateTitle.AccessibleName = Nothing
        resources.ApplyResources(Me.lbRateTitle, "lbRateTitle")
        Me.lbRateTitle.Name = "lbRateTitle"
        '
        'fRateEdit
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.lbRateTitle)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbRate2)
        Me.Controls.Add(Me.lbRate4)
        Me.Controls.Add(Me.lbRate5)
        Me.Controls.Add(Me.lbRate3)
        Me.Controls.Add(Me.lbRate1)
        Me.Controls.Add(Me.tb5)
        Me.Controls.Add(Me.tb4)
        Me.Controls.Add(Me.tb3)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.tb1)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = Nothing
        Me.Name = "fRateEdit"
        Me.ShowInTaskbar = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If CheckInteger(Me) = False Then
            'Quick check to stop any errors
            If Trim(Me.tb1.Text) = "" Then
                Me.tb1.Text = "0"
            End If
            If Trim(Me.tb2.Text) = "" Then
                Me.tb2.Text = "0"
            End If
            If Trim(Me.tb3.Text) = "" Then
                Me.tb3.Text = "0"
            End If
            If Trim(Me.tb4.Text) = "" Then
                Me.tb4.Text = "0"
            End If
            If Trim(Me.tb5.Text) = "" Then
                Me.tb5.Text = "0"
            End If

            Band("Line1", Trim(Me.tb1.Text), 2, Me.tb1)
            Band("Line2", Trim(Me.tb2.Text), 2, Me.tb2)
            Band("Line3", Trim(Me.tb3.Text), 2, Me.tb3)
            Band("Line4", Trim(Me.tb4.Text), 2, Me.tb4)
            Band("Line5", Trim(Me.tb5.Text), 2, Me.tb5)

            Dim msgbox As New fMsgBox(0, "Saved", "Settings Saved")
            msgbox.ShowDialog()

            Me.Close()
        End If
    End Sub

    Private Sub fRateEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Band("Line1", 0, 1, Me.tb1)
        Band("Line2", 0, 1, Me.tb2)
        Band("Line3", 0, 1, Me.tb3)
        Band("Line4", 0, 1, Me.tb4)
        Band("Line5", 0, 1, Me.tb5)
    End Sub

    Public Overloads Function Band(ByVal BandID As String, ByVal comm As Single, ByVal Type As Integer, ByVal tbMe As TextBox) As Integer
        SDA.strSqlSP = "dbo.usp_BIComReportLineRate"
        SDA.AddParam("@BandID", BandID, SqlDbType.Text)
        SDA.AddParam("@Comm", comm, SqlDbType.Float)
        SDA.AddParam("@Type", Type, SqlDbType.Int)
        SDA.SqlGetDataSingleRow()

        'Dont update if saving
        If Type <> 2 Then
            tbMe.Text = SDA.SqlSingleRow(1)
        End If
    End Function

End Class
