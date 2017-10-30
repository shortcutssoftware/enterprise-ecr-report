Public Class fServiceCost
    Inherits System.Windows.Forms.Form

    Private dt2 As DataTable 'Comm structures
    Private sCurrency As String
    Private bDataGridFormatting As Boolean = False 'formatting flag
    Private iSelectedID As Integer 'What is selected on the datagrid
    Private iSelectedCost As String 'For placing in the tectbox for alteration
    Private iSelectedName As String
    Friend WithEvents lbSelectStructure As System.Windows.Forms.Label
    Friend WithEvents cbCommSelect As System.Windows.Forms.ComboBox
    Friend WithEvents rbPercent As System.Windows.Forms.RadioButton
    Friend WithEvents rbMoney As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbBlock1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbBlockAll As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label 'For the service name
    Private bFormLoad As Boolean = True 'Set load flag


#Region " Windows Form Designer generated code "

    Public Sub New(ByVal GlobalCurrency As String)
        MyBase.New()

        sCurrency = GlobalCurrency

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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents lbServiceCost As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents dg1 As System.Windows.Forms.DataGrid
    Friend WithEvents lbSelectService As System.Windows.Forms.Label
    Friend WithEvents tbMoney As System.Windows.Forms.TextBox
    Friend WithEvents lbeg As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fServiceCost))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.lbServiceCost = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.dg1 = New System.Windows.Forms.DataGrid
        Me.lbSelectService = New System.Windows.Forms.Label
        Me.tbMoney = New System.Windows.Forms.TextBox
        Me.lbeg = New System.Windows.Forms.Label
        Me.lbSelectStructure = New System.Windows.Forms.Label
        Me.cbCommSelect = New System.Windows.Forms.ComboBox
        Me.rbPercent = New System.Windows.Forms.RadioButton
        Me.rbMoney = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.rbBlock1 = New System.Windows.Forms.RadioButton
        Me.rbBlockAll = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'Panel12
        '
        resources.ApplyResources(Me.Panel12, "Panel12")
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.lbServiceCost)
        Me.Panel12.Name = "Panel12"
        '
        'lbServiceCost
        '
        Me.lbServiceCost.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lbServiceCost, "lbServiceCost")
        Me.lbServiceCost.ForeColor = System.Drawing.Color.White
        Me.lbServiceCost.Name = "lbServiceCost"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Silver
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnSave, "btnSave")
        Me.btnSave.Name = "btnSave"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Silver
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnClose, "btnClose")
        Me.btnClose.Name = "btnClose"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'dg1
        '
        Me.dg1.CaptionBackColor = System.Drawing.Color.Black
        Me.dg1.DataMember = ""
        Me.dg1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.dg1, "dg1")
        Me.dg1.Name = "dg1"
        Me.dg1.ReadOnly = True
        '
        'lbSelectService
        '
        resources.ApplyResources(Me.lbSelectService, "lbSelectService")
        Me.lbSelectService.ForeColor = System.Drawing.Color.Navy
        Me.lbSelectService.Name = "lbSelectService"
        '
        'tbMoney
        '
        resources.ApplyResources(Me.tbMoney, "tbMoney")
        Me.tbMoney.Name = "tbMoney"
        '
        'lbeg
        '
        resources.ApplyResources(Me.lbeg, "lbeg")
        Me.lbeg.Name = "lbeg"
        '
        'lbSelectStructure
        '
        resources.ApplyResources(Me.lbSelectStructure, "lbSelectStructure")
        Me.lbSelectStructure.ForeColor = System.Drawing.Color.Navy
        Me.lbSelectStructure.Name = "lbSelectStructure"
        '
        'cbCommSelect
        '
        Me.cbCommSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cbCommSelect, "cbCommSelect")
        Me.cbCommSelect.Name = "cbCommSelect"
        '
        'rbPercent
        '
        Me.rbPercent.Checked = True
        resources.ApplyResources(Me.rbPercent, "rbPercent")
        Me.rbPercent.Name = "rbPercent"
        Me.rbPercent.TabStop = True
        '
        'rbMoney
        '
        resources.ApplyResources(Me.rbMoney, "rbMoney")
        Me.rbMoney.Name = "rbMoney"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'rbBlock1
        '
        Me.rbBlock1.Checked = True
        resources.ApplyResources(Me.rbBlock1, "rbBlock1")
        Me.rbBlock1.Name = "rbBlock1"
        Me.rbBlock1.TabStop = True
        '
        'rbBlockAll
        '
        resources.ApplyResources(Me.rbBlockAll, "rbBlockAll")
        Me.rbBlockAll.Name = "rbBlockAll"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbBlock1)
        Me.Panel1.Controls.Add(Me.rbBlockAll)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Name = "Label4"
        '
        'fServiceCost
        '
        resources.ApplyResources(Me, "$this")
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rbPercent)
        Me.Controls.Add(Me.rbMoney)
        Me.Controls.Add(Me.lbSelectStructure)
        Me.Controls.Add(Me.cbCommSelect)
        Me.Controls.Add(Me.lbeg)
        Me.Controls.Add(Me.tbMoney)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dg1)
        Me.Controls.Add(Me.lbSelectService)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fServiceCost"
        Me.ShowInTaskbar = False
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub fServiceCost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bFormLoad = True

        'Set currency that is passed into the form
        Me.rbMoney.Text = sCurrency

        'The comm structures and their ID's
        SDA.strSqlSP = "dbo.usp_BIComReportServiceUpdate"
        SDA.AddParam("@Select", 3, SqlDbType.Int)
        SDA.AddParam("@ID", 0, SqlDbType.Int)
        SDA.AddParam("@Value", 0, SqlDbType.Float)
        SDA.AddParam("@LevID", 0, SqlDbType.Int)

        dt2 = SDA.SqlDataSet.Tables(0)


        'Added 06/04/10
        SDA.strSqlSP = "dbo.usp_BIComReportProcessSettings"
        SDA.AddParam("@Key", "SerCostType", SqlDbType.Text)
        SDA.AddParam("@Value", 0, SqlDbType.Int)
        SDA.AddParam("@Type", 0, SqlDbType.Int)
        SDA.SqlGetDataSingleRow()

        If SDA.SqlSingleRow(0) = 0 Then
            Me.rbMoney.Checked = True
        Else
            Me.rbPercent.Checked = True
        End If


        'Added 06/04/10
        SDA.strSqlSP = "dbo.usp_BIComReportProcessSettings"
        SDA.AddParam("@Key", "SerCostBlock", SqlDbType.Text)
        SDA.AddParam("@Value", 0, SqlDbType.Int)
        SDA.AddParam("@Type", 0, SqlDbType.Int)
        SDA.SqlGetDataSingleRow()

        If SDA.SqlSingleRow(0) = 1 Then
            Me.rbBlock1.Checked = True
        Else
            Me.rbBlockAll.Checked = True
        End If




        FadeInDialog(Me)

        bFormLoad = False
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click


        'Save setting just incase its changed
        'Added 06/04/10
        SDA.strSqlSP = "dbo.usp_BIComReportProcessSettings"
        SDA.AddParam("@Key", "SerCostType", SqlDbType.Text)
        SDA.AddParam("@Value", CInt(Me.rbPercent.Checked) * -1, SqlDbType.Float)
        SDA.AddParam("@Type", 1, SqlDbType.Int)
        SDA.SqlExecute()

        'Added 06/04/10
        SDA.strSqlSP = "dbo.usp_BIComReportProcessSettings"
        SDA.AddParam("@Key", "SerCostBlock", SqlDbType.Text)
        SDA.AddParam("@Value", CInt(Me.rbBlock1.Checked) * -1, SqlDbType.Float)
        SDA.AddParam("@Type", 1, SqlDbType.Int)
        SDA.SqlExecute()



        FadeOutDialog(Me)
        Me.Close()
    End Sub


    Private Sub cbCommSelect_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCommSelect.DropDown
        Me.cbCommSelect.DataSource = dt2
        Me.cbCommSelect.ValueMember = dt2.Columns(0).ToString
        Me.cbCommSelect.DisplayMember = dt2.Columns(1).ToString
    End Sub


    Private Sub dg1_Navigate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dg1.Click, dg1.CurrentCellChanged, dg1.Enter, dg1.Navigate

        If bFormLoad = False Then
            Dim row As Integer = Me.dg1.CurrentCell.RowNumber

            If Me.dg1.VisibleRowCount > 0 Then
                Me.dg1.Select(row)
                iSelectedID = Me.dg1.Item(row, 0)
                iSelectedCost = Me.dg1.Item(row, 2)
                iSelectedName = Me.dg1.Item(row, 1)

                Me.tbMoney.Text = iSelectedCost
            End If

        End If
    End Sub


    Private Sub PopulateList()
        SDA.strSqlSP = "dbo.usp_BIComReportServiceUpdate"
        SDA.AddParam("@Select", 1, SqlDbType.Int) '1 because only want to select
        SDA.AddParam("@ID", 0, SqlDbType.Int)
        SDA.AddParam("@Value", 0, SqlDbType.Float)
        SDA.AddParam("@LevID", Me.cbCommSelect.SelectedValue, SqlDbType.Int)  '20/4/09 paid work
        Dim dt1 As DataTable = SDA.SqlDataSet.Tables(0)
        Me.dg1.DataSource = dt1

        'Now do levels
        SDA.strSqlSP = "dbo.usp_BIComReportServiceUpdate"
        SDA.AddParam("@Select", 3, SqlDbType.Int) '1 because only want to select
        SDA.AddParam("@ID", 0, SqlDbType.Int)
        SDA.AddParam("@Value", 0, SqlDbType.Float)
        SDA.AddParam("@LevID", Me.cbCommSelect.SelectedValue, SqlDbType.Int)  '20/4/09 paid work
        dt2 = SDA.SqlDataSet.Tables(0)

        'Format Grid
        If bDataGridFormatting = False Then
            bDataGridFormatting = True

            Dim grdTableStyle1 As New DataGridTableStyle
            With grdTableStyle1
                .MappingName = dt1.TableName
            End With

            'Datagrid1 Column Formatting
            Dim grdColStyle1 As New DataGridTextBoxColumn
            With grdColStyle1
                .MappingName = dt1.Columns(0).ColumnName
                .Width = 0
            End With

            Dim grdColStyle2 As New DataGridTextBoxColumn
            With grdColStyle2
                .MappingName = dt1.Columns(1).ColumnName
                .Alignment = HorizontalAlignment.Left
                .HeaderText = "Service"
                .Width = 160
            End With

            Dim grdColStyle3 As New DataGridTextBoxColumn
            With grdColStyle3
                .MappingName = dt1.Columns(2).ColumnName
                .Alignment = HorizontalAlignment.Left
                .HeaderText = "Cost"
                .Width = 40
            End With

            grdTableStyle1.GridColumnStyles.AddRange _
                (New DataGridColumnStyle() {grdColStyle1, grdColStyle2, grdColStyle3})
            dg1.TableStyles.Add(grdTableStyle1)
        End If
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If Not String.IsNullOrEmpty(Me.tbMoney.Text) Then
            If CheckInteger(Me) = False Then

                'Save data to the table
                SDA.strSqlSP = "dbo.usp_BIComReportServiceUpdate"
                SDA.AddParam("@Select", 0, SqlDbType.Int) '1 because only want to select
                SDA.AddParam("@ID", iSelectedID, SqlDbType.Int)
                SDA.AddParam("@Value", Me.tbMoney.Text, SqlDbType.Float)  'Combine together (as instruced by Jon!)
                SDA.AddParam("@LevID", Me.cbCommSelect.SelectedValue, SqlDbType.Int)  '20/4/09 paid work
                SDA.SqlExecute()

                'Refresh table
                PopulateList()
            End If
        End If




    End Sub


    Private Sub cbCommSelect_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCommSelect.SelectionChangeCommitted

        'Populate service list by level!
        PopulateList()

    End Sub



End Class
