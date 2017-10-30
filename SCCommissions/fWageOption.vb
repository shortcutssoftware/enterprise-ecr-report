Public Class fWageOption
    Inherits System.Windows.Forms.Form

    Private bDataGridFormatting As Boolean = False
    Private bafterCurrentCellChanged As Boolean = False
    Private bafterCurrentCellChanged2 As Boolean = False


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
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents lbFallBackWage As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lbWageComm As System.Windows.Forms.Label
    Friend WithEvents lbWageOrComm As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fWageOption))
        Me.dataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.lbFallBackWage = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.lbWageComm = New System.Windows.Forms.Label
        Me.lbWageOrComm = New System.Windows.Forms.Label
        CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        Me.SuspendLayout()
        '
        'dataGrid1
        '
        Me.dataGrid1.AccessibleDescription = Nothing
        Me.dataGrid1.AccessibleName = Nothing
        Me.dataGrid1.AllowNavigation = False
        Me.dataGrid1.AllowSorting = False
        resources.ApplyResources(Me.dataGrid1, "dataGrid1")
        Me.dataGrid1.BackgroundImage = Nothing
        Me.dataGrid1.CaptionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dataGrid1.CaptionFont = Nothing
        Me.dataGrid1.CaptionVisible = False
        Me.dataGrid1.ColumnHeadersVisible = False
        Me.dataGrid1.DataMember = ""
        Me.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dataGrid1.Name = "dataGrid1"
        Me.dataGrid1.ParentRowsVisible = False
        Me.dataGrid1.ReadOnly = True
        Me.dataGrid1.RowHeadersVisible = False
        '
        'DataGridTextBoxColumn1
        '
        resources.ApplyResources(Me.DataGridTextBoxColumn1, "DataGridTextBoxColumn1")
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
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
        'Panel12
        '
        Me.Panel12.AccessibleDescription = Nothing
        Me.Panel12.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel12, "Panel12")
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.lbFallBackWage)
        Me.Panel12.Font = Nothing
        Me.Panel12.Name = "Panel12"
        '
        'lbFallBackWage
        '
        Me.lbFallBackWage.AccessibleDescription = Nothing
        Me.lbFallBackWage.AccessibleName = Nothing
        resources.ApplyResources(Me.lbFallBackWage, "lbFallBackWage")
        Me.lbFallBackWage.BackColor = System.Drawing.Color.Transparent
        Me.lbFallBackWage.ForeColor = System.Drawing.Color.White
        Me.lbFallBackWage.Name = "lbFallBackWage"
        '
        'btnClose
        '
        Me.btnClose.AccessibleDescription = Nothing
        Me.btnClose.AccessibleName = Nothing
        resources.ApplyResources(Me.btnClose, "btnClose")
        Me.btnClose.BackColor = System.Drawing.Color.Silver
        Me.btnClose.BackgroundImage = Nothing
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Name = "btnClose"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lbWageComm
        '
        Me.lbWageComm.AccessibleDescription = Nothing
        Me.lbWageComm.AccessibleName = Nothing
        resources.ApplyResources(Me.lbWageComm, "lbWageComm")
        Me.lbWageComm.ForeColor = System.Drawing.Color.White
        Me.lbWageComm.Name = "lbWageComm"
        '
        'lbWageOrComm
        '
        Me.lbWageOrComm.AccessibleDescription = Nothing
        Me.lbWageOrComm.AccessibleName = Nothing
        resources.ApplyResources(Me.lbWageOrComm, "lbWageOrComm")
        Me.lbWageOrComm.ForeColor = System.Drawing.Color.White
        Me.lbWageOrComm.Name = "lbWageOrComm"
        '
        'fWageOption
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.lbWageOrComm)
        Me.Controls.Add(Me.lbWageComm)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dataGrid1)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = Nothing
        Me.Name = "fWageOption"
        Me.ShowInTaskbar = False
        CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub PopulateDatagrid()
        SDA.strSqlSP = "dbo.usp_BIComReportWage"
        SDA.AddParam("@StructureID", 0, SqlDbType.Int) 'not used
        SDA.AddParam("@Value", True, SqlDbType.Bit) 'not used
        SDA.AddParam("@Type", 0, SqlDbType.Int)

        Dim dt1 As DataTable = SDA.SqlDataSet.Tables(0)
        Me.dataGrid1.DataSource = dt1

        'Format Grid
        If bDataGridFormatting = False Then
            bDataGridFormatting = True

            Dim grdTableStyle1 As New DataGridTableStyle
            With grdTableStyle1
                '.AlternatingBackColor = Color.GhostWhite
                '.BackColor = Color.GhostWhite
                '.ForeColor = Color.MidnightBlue
                '.GridLineColor = Color.RoyalBlue
                '.HeaderBackColor = Color.MidnightBlue
                .HeaderFont = New Font("Tahoma", 8.0!, FontStyle.Regular)
                '.HeaderForeColor = Color.Lavender
                '.SelectionBackColor = Color.GhostWhite
                '.SelectionForeColor = System.Drawing.Color.FromArgb(237, 23, 31)
                '.PreferredRowHeight = 22
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
                .HeaderText = "Structure"
                .Alignment = HorizontalAlignment.Left
                .Width = 140
            End With

            Dim grdColStyle3 As New DataGridBoolColumn
            With grdColStyle3
                .MappingName = dt1.Columns(2).ColumnName
                .HeaderText = "Wage + Comm."
                .Width = 85
                .AllowNull = False
                .ReadOnly = False
            End With

            Dim grdColStyle4 As New DataGridBoolColumn
            With grdColStyle4
                .MappingName = dt1.Columns(3).ColumnName
                .HeaderText = "Wage OR Comm."
                .Width = 85
                .AllowNull = False
                .ReadOnly = True
            End With

            ' Add the style objects to the table style's collection of 
            ' column styles. Without this the styles do not take effect.        
            grdTableStyle1.GridColumnStyles.AddRange _
                (New DataGridColumnStyle() {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4})
            dataGrid1.TableStyles.Add(grdTableStyle1)
        End If


    End Sub

    'Below subs are so add single clicks & highlight on click

    'dataGrid1_Click
    Private Sub dataGrid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dataGrid1.Click, dataGrid1.DoubleClick  ', dataGrid1.ParentChanged

        Try

            If Me.dataGrid1.CurrentCell.ColumnNumber = 2 Then
                dataGrid1.Item(Me.dataGrid1.CurrentRowIndex, 2) = Not Me.dataGrid1.Item(Me.dataGrid1.CurrentRowIndex, 2)
            End If
            If Me.dataGrid1.CurrentCell.ColumnNumber = 3 Then
                dataGrid1.Item(Me.dataGrid1.CurrentRowIndex, 2) = Not Me.dataGrid1.Item(Me.dataGrid1.CurrentRowIndex, 3)
            End If

            Dim discontinuedColumn As Integer = 2
            Dim pt As Point = Me.dataGrid1.PointToClient(Control.MousePosition)
            Dim hti As DataGrid.HitTestInfo = Me.dataGrid1.HitTest(pt)
            Dim bmb As BindingManagerBase = Me.BindingContext(Me.dataGrid1.DataSource, Me.dataGrid1.DataMember)

            If bafterCurrentCellChanged _
            AndAlso hti.Row < bmb.Count AndAlso hti.Type = DataGrid.HitTestType.Cell AndAlso hti.Column = discontinuedColumn Then
                Me.dataGrid1(hti.Row, discontinuedColumn) = _
                Not CBool(Me.dataGrid1(hti.Row, discontinuedColumn))
            End If
            bafterCurrentCellChanged = False


            Dim discontinuedColumn2 As Integer = 3
            Dim pt2 As Point = Me.dataGrid1.PointToClient(Control.MousePosition)
            Dim hti2 As DataGrid.HitTestInfo = Me.dataGrid1.HitTest(pt2)
            Dim bmb2 As BindingManagerBase = Me.BindingContext(Me.dataGrid1.DataSource, Me.dataGrid1.DataMember)

            If bafterCurrentCellChanged2 _
            AndAlso hti2.Row < bmb2.Count AndAlso hti2.Type = DataGrid.HitTestType.Cell AndAlso hti2.Column = discontinuedColumn2 Then
                Me.dataGrid1(hti2.Row, discontinuedColumn2) = _
                Not CBool(Me.dataGrid1(hti2.Row, discontinuedColumn2))
            End If
            bafterCurrentCellChanged2 = False

            SDA.strSqlSP = "dbo.usp_BIComReportWage"
            SDA.AddParam("@StructureID", dataGrid1.Item(Me.dataGrid1.CurrentRowIndex, 0), SqlDbType.Int)
            SDA.AddParam("@Value", Not dataGrid1.Item(Me.dataGrid1.CurrentRowIndex, 2), SqlDbType.Bit)
            SDA.AddParam("@Type", 1, SqlDbType.Int)
            SDA.SqlExecute()

            PopulateDatagrid()
        Catch ex As Exception
      
        End Try
    End Sub

    'dataGrid1_CurrentCellChanged
    Private Sub dataGrid1_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dataGrid1.CurrentCellChanged


        If Me.dataGrid1.CurrentCell.ColumnNumber = 2 Then
            dataGrid1.Item(Me.dataGrid1.CurrentRowIndex, 2) = Not Me.dataGrid1.Item(Me.dataGrid1.CurrentRowIndex, 2)
        End If
        If Me.dataGrid1.CurrentCell.ColumnNumber = 3 Then
            dataGrid1.Item(Me.dataGrid1.CurrentRowIndex, 3) = Not Me.dataGrid1.Item(Me.dataGrid1.CurrentRowIndex, 3)
            dataGrid1.Item(Me.dataGrid1.CurrentRowIndex, 2) = Not Me.dataGrid1.Item(Me.dataGrid1.CurrentRowIndex, 3)
        End If

        'if click on a discontinued row, then set 
        'currentcell to checkbox
        Dim discontinuedColumn As Integer = 2
        Dim val As Object = Me.dataGrid1(Me.dataGrid1.CurrentRowIndex, discontinuedColumn)
        Dim productDiscontinued As Boolean = CBool(val)
        If productDiscontinued Then
            Me.dataGrid1.CurrentCell = New DataGridCell(Me.dataGrid1.CurrentRowIndex, discontinuedColumn)
        End If

        bafterCurrentCellChanged = True
    End Sub

    Private Sub fWageOption_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FadeInDialog(Me)
        PopulateDatagrid()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        FadeOutDialog(Me)
        Me.Close()
    End Sub

    Private Sub dataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dataGrid1.Navigate

    End Sub
End Class
