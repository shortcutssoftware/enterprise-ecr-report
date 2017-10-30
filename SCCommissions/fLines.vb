Public Class fLines
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
    Friend WithEvents lbSelectCompany As System.Windows.Forms.Label
    Friend WithEvents cbComp As System.Windows.Forms.ComboBox
    Friend WithEvents dg1 As System.Windows.Forms.DataGrid
    Friend WithEvents lbName As System.Windows.Forms.Label
    Friend WithEvents lbSelectRate As System.Windows.Forms.Label
    Friend WithEvents cbBand As System.Windows.Forms.ComboBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents lbRetail As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSave As System.Windows.Forms.PictureBox
    Friend WithEvents lbSave As System.Windows.Forms.Label
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fLines))
        Me.cbComp = New System.Windows.Forms.ComboBox
        Me.lbSelectCompany = New System.Windows.Forms.Label
        Me.dg1 = New System.Windows.Forms.DataGrid
        Me.lbName = New System.Windows.Forms.Label
        Me.lbSelectRate = New System.Windows.Forms.Label
        Me.cbBand = New System.Windows.Forms.ComboBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.lbRetail = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnSave = New System.Windows.Forms.PictureBox
        Me.lbSave = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbComp
        '
        Me.cbComp.AccessibleDescription = Nothing
        Me.cbComp.AccessibleName = Nothing
        resources.ApplyResources(Me.cbComp, "cbComp")
        Me.cbComp.BackgroundImage = Nothing
        Me.cbComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbComp.Font = Nothing
        Me.cbComp.Name = "cbComp"
        '
        'lbSelectCompany
        '
        Me.lbSelectCompany.AccessibleDescription = Nothing
        Me.lbSelectCompany.AccessibleName = Nothing
        resources.ApplyResources(Me.lbSelectCompany, "lbSelectCompany")
        Me.lbSelectCompany.Name = "lbSelectCompany"
        '
        'dg1
        '
        Me.dg1.AccessibleDescription = Nothing
        Me.dg1.AccessibleName = Nothing
        resources.ApplyResources(Me.dg1, "dg1")
        Me.dg1.BackgroundImage = Nothing
        Me.dg1.CaptionBackColor = System.Drawing.Color.Black
        Me.dg1.CaptionFont = Nothing
        Me.dg1.DataMember = ""
        Me.dg1.Font = Nothing
        Me.dg1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dg1.Name = "dg1"
        Me.dg1.ReadOnly = True
        '
        'lbName
        '
        Me.lbName.AccessibleDescription = Nothing
        Me.lbName.AccessibleName = Nothing
        resources.ApplyResources(Me.lbName, "lbName")
        Me.lbName.BackColor = System.Drawing.Color.Transparent
        Me.lbName.Font = Nothing
        Me.lbName.ForeColor = System.Drawing.Color.White
        Me.lbName.Name = "lbName"
        '
        'lbSelectRate
        '
        Me.lbSelectRate.AccessibleDescription = Nothing
        Me.lbSelectRate.AccessibleName = Nothing
        resources.ApplyResources(Me.lbSelectRate, "lbSelectRate")
        Me.lbSelectRate.Name = "lbSelectRate"
        '
        'cbBand
        '
        Me.cbBand.AccessibleDescription = Nothing
        Me.cbBand.AccessibleName = Nothing
        resources.ApplyResources(Me.cbBand, "cbBand")
        Me.cbBand.BackgroundImage = Nothing
        Me.cbBand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBand.Font = Nothing
        Me.cbBand.Name = "cbBand"
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
        'btnEdit
        '
        Me.btnEdit.AccessibleDescription = Nothing
        Me.btnEdit.AccessibleName = Nothing
        resources.ApplyResources(Me.btnEdit, "btnEdit")
        Me.btnEdit.BackColor = System.Drawing.Color.Silver
        Me.btnEdit.BackgroundImage = Nothing
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Font = Nothing
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'Panel12
        '
        Me.Panel12.AccessibleDescription = Nothing
        Me.Panel12.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel12, "Panel12")
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.lbRetail)
        Me.Panel12.Controls.Add(Me.lbName)
        Me.Panel12.Font = Nothing
        Me.Panel12.Name = "Panel12"
        '
        'lbRetail
        '
        Me.lbRetail.AccessibleDescription = Nothing
        Me.lbRetail.AccessibleName = Nothing
        resources.ApplyResources(Me.lbRetail, "lbRetail")
        Me.lbRetail.BackColor = System.Drawing.Color.Transparent
        Me.lbRetail.ForeColor = System.Drawing.Color.White
        Me.lbRetail.Name = "lbRetail"
        '
        'PictureBox1
        '
        Me.PictureBox1.AccessibleDescription = Nothing
        Me.PictureBox1.AccessibleName = Nothing
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.BackgroundImage = Nothing
        Me.PictureBox1.Font = Nothing
        Me.PictureBox1.ImageLocation = Nothing
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.AccessibleDescription = Nothing
        Me.btnSave.AccessibleName = Nothing
        resources.ApplyResources(Me.btnSave, "btnSave")
        Me.btnSave.BackgroundImage = Nothing
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = Nothing
        Me.btnSave.ImageLocation = Nothing
        Me.btnSave.Name = "btnSave"
        Me.btnSave.TabStop = False
        '
        'lbSave
        '
        Me.lbSave.AccessibleDescription = Nothing
        Me.lbSave.AccessibleName = Nothing
        resources.ApplyResources(Me.lbSave, "lbSave")
        Me.lbSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbSave.Name = "lbSave"
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = Nothing
        Me.Label3.AccessibleName = Nothing
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Font = Nothing
        Me.Label3.Name = "Label3"
        '
        'fLines
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbSave)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.cbBand)
        Me.Controls.Add(Me.lbSelectRate)
        Me.Controls.Add(Me.dg1)
        Me.Controls.Add(Me.lbSelectCompany)
        Me.Controls.Add(Me.cbComp)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = Nothing
        Me.Name = "fLines"
        Me.ShowInTaskbar = False
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private dt1 As DataTable
    Private dt2 As DataTable
    Private dtLines As DataTable
    Private iSelectID As Integer
    Private iSelectIDdg As Integer
    Private bDataGridFormatting As Boolean = False 'formatting flag




    'Populat on load for performance
    Private Sub fLines_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FadeInDialog(Me)
        dgPopulate()       'On load populate table
        CommRatePopulate() '..and comm drop down
    End Sub


    Private Sub dgPopulate()
        SDA.strSqlSP = "dbo.usp_BIComReportCompSelect"
        dt1 = SDA.SqlDataSet.Tables(0)
    End Sub


    Private Sub CommRatePopulate()
        SDA.strSqlSP = "dbo.usp_BIComReportLineRate"
        SDA.AddParam("@BandID", 1, SqlDbType.Int) 'Not used
        SDA.AddParam("@Comm", 1, SqlDbType.Float) 'Not used
        SDA.AddParam("@Type", 0, SqlDbType.Int) 'Read
        dtLines = SDA.SqlDataSet.Tables(0)
    End Sub

    Private Sub cbComp_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbComp.DropDown
        Me.cbComp.DataSource = dt1
        Me.cbComp.ValueMember = dt1.Columns(1).ToString
        Me.cbComp.DisplayMember = dt1.Columns(0).ToString
    End Sub

    Private Sub cbBand_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbBand.DropDown
        Me.cbBand.DataSource = dtLines
        Me.cbBand.ValueMember = dtLines.Columns(0).ToString
        Me.cbBand.DisplayMember = dtLines.Columns(1).ToString
        Me.btnSave.Enabled = True
    End Sub

    Private Sub cbComp_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbComp.SelectionChangeCommitted
        iSelectID = Me.cbComp.SelectedValue

        'Populate Lines
        PopulateTable()

        'HCI
        Me.cbBand.Enabled = True
    End Sub

    Private Sub dg1_Navigate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dg1.Click, dg1.CurrentCellChanged, dg1.Enter
        Dim row As Integer
        row = Me.dg1.CurrentCell.RowNumber

        Me.dg1.Select(row)
        lbName.Text = Me.dg1.Item(row, 0)
        iSelectIDdg = Me.dg1.Item(row, 1)
        Me.cbBand.Text = Me.dg1.Item(row, 2)
    End Sub

    'Populate DG
    Private Sub PopulateTable()
        SDA.strSqlSP = "dbo.usp_BIComReportLineSelect"
        SDA.AddParam("@CompID", iSelectID, SqlDbType.Int)
        dt2 = SDA.SqlDataSet.Tables(0)
        Me.dg1.DataSource = dt2

        'Format Grid
        If bDataGridFormatting = False Then
            bDataGridFormatting = True

            Dim grdTableStyle1 As New DataGridTableStyle
            With grdTableStyle1
                '   .HeaderFont = New Font("Tahoma", 10.0!, FontStyle.Bold)
                .MappingName = dt2.TableName
            End With

            'Datagrid1 Column Formatting
            Dim grdColStyle1 As New DataGridTextBoxColumn
            With grdColStyle1
                .MappingName = dt2.Columns(0).ColumnName
                .HeaderText = "Line"
                .Alignment = HorizontalAlignment.Left
                .Width = 145
            End With

            Dim grdColStyle2 As New DataGridTextBoxColumn
            With grdColStyle2
                .MappingName = dt2.Columns(1).ColumnName
                .Width = 0
            End With

            Dim grdColStyle3 As New DataGridTextBoxColumn
            With grdColStyle3
                .HeaderText = "Value (%)"
                .Alignment = HorizontalAlignment.Center
                .MappingName = dt2.Columns(3).ColumnName
                .Width = 55
            End With

            ' Add the style objects to the table style's collection of 
            ' column styles. Without this the styles do not take effect.        
            grdTableStyle1.GridColumnStyles.AddRange _
                (New DataGridColumnStyle() {grdColStyle1, grdColStyle2, grdColStyle3})
            dg1.TableStyles.Add(grdTableStyle1)
        End If
    End Sub


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        FadeOutDialog(Me)
        Me.Close()
    End Sub

    Private Sub Save(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click, lbSave.Click
        If Me.cbBand.SelectedValue <> Nothing Then
            SDA.strSqlSP = "dbo.usp_BIComReportLineUpdate"
            SDA.AddParam("@IdNumber", iSelectIDdg, SqlDbType.Int)
            SDA.AddParam("@Value", Me.cbBand.SelectedValue.Replace("Line", Nothing), SqlDbType.Int)
            SDA.SqlExecute()

            If SDA.iReturn = 1 Then
                PopulateTable()
                Dim msgbox As New fMsgBox(0, "Saved", "Settings Saved")
                MsgBox.ShowDialog()
                Me.btnSave.Enabled = False
            Else
                Dim msgbox As New fMsgBox(2, "System Error", "There has been an error, data not saves")
                MsgBox.ShowDialog()
            End If
        Else
            Dim msgbox As New fMsgBox(2, "System Error", "Please select a value from the dropdown menu")
            MsgBox.ShowDialog()
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim form As New fRateEdit
        form.ShowDialog()
        Me.cbBand.Text = "..."
        CommRatePopulate()
        PopulateTable()
    End Sub

  
End Class
