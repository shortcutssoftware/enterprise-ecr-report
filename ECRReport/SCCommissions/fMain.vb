Imports System.Threading

Public Class fMain
    Inherits System.Windows.Forms.Form

    Private bIsLoad As Boolean = True  'to stop sub forms loading too!
    Private bChangesMade As Boolean = False 'Set if the user clicks anything
    Private bHasChange As Boolean = False 'Has there been a change made?
    Public sCurrency As String = System.Globalization.RegionInfo.CurrentRegion.CurrencySymbol.ToString

    Private bRunningBand As Boolean = False
    Private bRunningSave As Boolean = False
    Private bRunningHelp As Boolean = False
    Private bRunningExit As Boolean = False


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
    Friend WithEvents rbTaxInclude As System.Windows.Forms.RadioButton
    Friend WithEvents rbTaxExclude As System.Windows.Forms.RadioButton
    Friend WithEvents lbTax As System.Windows.Forms.Label
    Friend WithEvents lbCalcPeriod As System.Windows.Forms.Label
    Friend WithEvents rbPeriodPay As System.Windows.Forms.RadioButton
    Friend WithEvents rbPeriodWeekly As System.Windows.Forms.RadioButton
    Friend WithEvents lbBandingType As System.Windows.Forms.Label
    Friend WithEvents rbBandTarget As System.Windows.Forms.RadioButton
    Friend WithEvents rbBandCum As System.Windows.Forms.RadioButton
    Friend WithEvents rbTypeChem As System.Windows.Forms.RadioButton
    Friend WithEvents rbTypeSun As System.Windows.Forms.RadioButton
    Friend WithEvents lbAdditionalType As System.Windows.Forms.Label
    Friend WithEvents rbTypeRef As System.Windows.Forms.RadioButton
    Friend WithEvents rbRefN As System.Windows.Forms.RadioButton
    Friend WithEvents rbRefY As System.Windows.Forms.RadioButton
    Friend WithEvents gbRefChem As System.Windows.Forms.GroupBox
    Friend WithEvents lbRemoveCostService As System.Windows.Forms.Label
    Friend WithEvents rbCostY As System.Windows.Forms.RadioButton
    Friend WithEvents rbCostN As System.Windows.Forms.RadioButton
    Friend WithEvents lbSetFeeBill As System.Windows.Forms.Label
    Friend WithEvents tbServiceTaken As System.Windows.Forms.TextBox
    Friend WithEvents lbFallBackWage As System.Windows.Forms.Label
    Friend WithEvents rbFallY As System.Windows.Forms.RadioButton
    Friend WithEvents rbFallN As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbRetailSplit As System.Windows.Forms.Label
    Friend WithEvents lbReceptionist As System.Windows.Forms.Label
    Friend WithEvents tbSplitRecep As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbStylist As System.Windows.Forms.Label
    Friend WithEvents tbSplitStyle As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbWageSchedule As System.Windows.Forms.Label
    Friend WithEvents lbRequestClientTarget As System.Windows.Forms.Label
    Friend WithEvents gbClient As System.Windows.Forms.GroupBox
    Friend WithEvents lbRetailComm As System.Windows.Forms.Label
    Friend WithEvents rbRetailLine As System.Windows.Forms.RadioButton
    Friend WithEvents rbWageRos As System.Windows.Forms.RadioButton
    Friend WithEvents rbWageLog As System.Windows.Forms.RadioButton
    Friend WithEvents rbGoalNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbGoalY As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents tbTipFee As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents rbTypeClienC As System.Windows.Forms.RadioButton
    Friend WithEvents lbReferChemOnly As System.Windows.Forms.Label
    Friend WithEvents pbRefChem As System.Windows.Forms.PictureBox
    Friend WithEvents pbClientTar As System.Windows.Forms.PictureBox
    Friend WithEvents rbSerBand As System.Windows.Forms.RadioButton
    Friend WithEvents rbMoney As System.Windows.Forms.RadioButton
    Friend WithEvents rbPercent As System.Windows.Forms.RadioButton
    Friend WithEvents lbPercent As System.Windows.Forms.Label
    Friend WithEvents lbMoney As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents rbPayServiceY As System.Windows.Forms.RadioButton
    Friend WithEvents rbPayServiceN As System.Windows.Forms.RadioButton
    Friend WithEvents lbPayServiceSales As System.Windows.Forms.Label
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents lbTitle As System.Windows.Forms.Label
    Friend WithEvents lbExit As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.PictureBox
    Friend WithEvents btnSave As System.Windows.Forms.PictureBox
    Friend WithEvents lbSave As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lbBands As System.Windows.Forms.Label
    Friend WithEvents lbHelp As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.PictureBox
    Friend WithEvents btnBands As System.Windows.Forms.PictureBox
    Friend WithEvents pbRecComm As System.Windows.Forms.PictureBox
    Friend WithEvents PBpAYsERVICE As System.Windows.Forms.PictureBox
    Friend WithEvents pbFall As System.Windows.Forms.PictureBox
    Friend WithEvents pbCost As System.Windows.Forms.PictureBox
    Friend WithEvents pbSplit As System.Windows.Forms.PictureBox
    Friend WithEvents pbServiceFee As System.Windows.Forms.PictureBox
    Friend WithEvents pbWage As System.Windows.Forms.PictureBox
    Friend WithEvents pbBandType As System.Windows.Forms.PictureBox
    Friend WithEvents pbHelpPeriod As System.Windows.Forms.PictureBox
    Friend WithEvents pbHelpTax As System.Windows.Forms.PictureBox
    Friend WithEvents pbSunComm As System.Windows.Forms.PictureBox
    Friend WithEvents pbStockCost As System.Windows.Forms.PictureBox
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents rbCostStockY As System.Windows.Forms.RadioButton
    Friend WithEvents rbCostStockN As System.Windows.Forms.RadioButton
    Friend WithEvents lbRemoveCostProd As System.Windows.Forms.Label
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents lbTipsProcessing As System.Windows.Forms.Label
    Friend WithEvents lbPayTips As System.Windows.Forms.Label
    Friend WithEvents lbTipsFee As System.Windows.Forms.Label
    Friend WithEvents pbTipFee As System.Windows.Forms.PictureBox
    Friend WithEvents gbTips As System.Windows.Forms.GroupBox
    Friend WithEvents pbTipsPayCom As System.Windows.Forms.PictureBox
    Friend WithEvents rbIncludeTips As System.Windows.Forms.RadioButton
    Friend WithEvents rbExcludeTips As System.Windows.Forms.RadioButton
    Friend WithEvents rbTipComY As System.Windows.Forms.RadioButton
    Friend WithEvents rbTipComN As System.Windows.Forms.RadioButton
    Friend WithEvents pbTipsProcessing As System.Windows.Forms.PictureBox
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fMain))
        Me.rbTaxInclude = New System.Windows.Forms.RadioButton
        Me.rbTaxExclude = New System.Windows.Forms.RadioButton
        Me.lbTax = New System.Windows.Forms.Label
        Me.lbCalcPeriod = New System.Windows.Forms.Label
        Me.rbPeriodPay = New System.Windows.Forms.RadioButton
        Me.rbPeriodWeekly = New System.Windows.Forms.RadioButton
        Me.lbBandingType = New System.Windows.Forms.Label
        Me.rbBandTarget = New System.Windows.Forms.RadioButton
        Me.rbBandCum = New System.Windows.Forms.RadioButton
        Me.rbTypeChem = New System.Windows.Forms.RadioButton
        Me.rbTypeSun = New System.Windows.Forms.RadioButton
        Me.lbAdditionalType = New System.Windows.Forms.Label
        Me.rbTypeRef = New System.Windows.Forms.RadioButton
        Me.rbRefN = New System.Windows.Forms.RadioButton
        Me.pbRefChem = New System.Windows.Forms.PictureBox
        Me.rbRefY = New System.Windows.Forms.RadioButton
        Me.gbRefChem = New System.Windows.Forms.GroupBox
        Me.lbReferChemOnly = New System.Windows.Forms.Label
        Me.lbRemoveCostService = New System.Windows.Forms.Label
        Me.rbCostY = New System.Windows.Forms.RadioButton
        Me.rbCostN = New System.Windows.Forms.RadioButton
        Me.lbSetFeeBill = New System.Windows.Forms.Label
        Me.tbServiceTaken = New System.Windows.Forms.TextBox
        Me.lbFallBackWage = New System.Windows.Forms.Label
        Me.rbFallY = New System.Windows.Forms.RadioButton
        Me.rbFallN = New System.Windows.Forms.RadioButton
        Me.tbTipFee = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbRetailSplit = New System.Windows.Forms.Label
        Me.lbReceptionist = New System.Windows.Forms.Label
        Me.tbSplitRecep = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.lbStylist = New System.Windows.Forms.Label
        Me.tbSplitStyle = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.rbWageRos = New System.Windows.Forms.RadioButton
        Me.rbWageLog = New System.Windows.Forms.RadioButton
        Me.lbWageSchedule = New System.Windows.Forms.Label
        Me.gbClient = New System.Windows.Forms.GroupBox
        Me.lbRequestClientTarget = New System.Windows.Forms.Label
        Me.rbGoalNo = New System.Windows.Forms.RadioButton
        Me.rbGoalY = New System.Windows.Forms.RadioButton
        Me.pbClientTar = New System.Windows.Forms.PictureBox
        Me.lbRetailComm = New System.Windows.Forms.Label
        Me.rbRetailLine = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.rbTypeClienC = New System.Windows.Forms.RadioButton
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.rbSerBand = New System.Windows.Forms.RadioButton
        Me.PictureBox9 = New System.Windows.Forms.PictureBox
        Me.rbMoney = New System.Windows.Forms.RadioButton
        Me.rbPercent = New System.Windows.Forms.RadioButton
        Me.lbPercent = New System.Windows.Forms.Label
        Me.lbMoney = New System.Windows.Forms.Label
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.rbPayServiceY = New System.Windows.Forms.RadioButton
        Me.rbPayServiceN = New System.Windows.Forms.RadioButton
        Me.lbPayServiceSales = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.PictureBox
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.Label20 = New System.Windows.Forms.Label
        Me.lbTitle = New System.Windows.Forms.Label
        Me.pbRecComm = New System.Windows.Forms.PictureBox
        Me.lbExit = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.PictureBox
        Me.lbSave = New System.Windows.Forms.Label
        Me.btnHelp = New System.Windows.Forms.PictureBox
        Me.btnBands = New System.Windows.Forms.PictureBox
        Me.lbBands = New System.Windows.Forms.Label
        Me.lbHelp = New System.Windows.Forms.Label
        Me.PBpAYsERVICE = New System.Windows.Forms.PictureBox
        Me.pbFall = New System.Windows.Forms.PictureBox
        Me.pbCost = New System.Windows.Forms.PictureBox
        Me.pbSplit = New System.Windows.Forms.PictureBox
        Me.pbServiceFee = New System.Windows.Forms.PictureBox
        Me.pbWage = New System.Windows.Forms.PictureBox
        Me.pbBandType = New System.Windows.Forms.PictureBox
        Me.pbHelpPeriod = New System.Windows.Forms.PictureBox
        Me.pbHelpTax = New System.Windows.Forms.PictureBox
        Me.pbSunComm = New System.Windows.Forms.PictureBox
        Me.pbStockCost = New System.Windows.Forms.PictureBox
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.rbCostStockY = New System.Windows.Forms.RadioButton
        Me.rbCostStockN = New System.Windows.Forms.RadioButton
        Me.lbRemoveCostProd = New System.Windows.Forms.Label
        Me.pbTipsProcessing = New System.Windows.Forms.PictureBox
        Me.Panel13 = New System.Windows.Forms.Panel
        Me.rbIncludeTips = New System.Windows.Forms.RadioButton
        Me.rbExcludeTips = New System.Windows.Forms.RadioButton
        Me.lbTipsProcessing = New System.Windows.Forms.Label
        Me.gbTips = New System.Windows.Forms.GroupBox
        Me.lbTipsFee = New System.Windows.Forms.Label
        Me.pbTipFee = New System.Windows.Forms.PictureBox
        Me.rbTipComY = New System.Windows.Forms.RadioButton
        Me.rbTipComN = New System.Windows.Forms.RadioButton
        Me.lbPayTips = New System.Windows.Forms.Label
        Me.pbTipsPayCom = New System.Windows.Forms.PictureBox
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.Panel16 = New System.Windows.Forms.Panel
        Me.Panel17 = New System.Windows.Forms.Panel
        CType(Me.pbRefChem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRefChem.SuspendLayout()
        Me.gbClient.SuspendLayout()
        CType(Me.pbClientTar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        CType(Me.pbRecComm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBands, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBpAYsERVICE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSplit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbServiceFee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbWage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBandType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHelpPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHelpTax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSunComm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStockCost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.pbTipsProcessing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        Me.gbTips.SuspendLayout()
        CType(Me.pbTipFee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTipsPayCom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbTaxInclude
        '
        Me.rbTaxInclude.AccessibleDescription = Nothing
        Me.rbTaxInclude.AccessibleName = Nothing
        resources.ApplyResources(Me.rbTaxInclude, "rbTaxInclude")
        Me.rbTaxInclude.BackgroundImage = Nothing
        Me.rbTaxInclude.ForeColor = System.Drawing.Color.Black
        Me.rbTaxInclude.Name = "rbTaxInclude"
        '
        'rbTaxExclude
        '
        Me.rbTaxExclude.AccessibleDescription = Nothing
        Me.rbTaxExclude.AccessibleName = Nothing
        resources.ApplyResources(Me.rbTaxExclude, "rbTaxExclude")
        Me.rbTaxExclude.BackgroundImage = Nothing
        Me.rbTaxExclude.Checked = True
        Me.rbTaxExclude.ForeColor = System.Drawing.Color.Black
        Me.rbTaxExclude.Name = "rbTaxExclude"
        Me.rbTaxExclude.TabStop = True
        '
        'lbTax
        '
        Me.lbTax.AccessibleDescription = Nothing
        Me.lbTax.AccessibleName = Nothing
        resources.ApplyResources(Me.lbTax, "lbTax")
        Me.lbTax.ForeColor = System.Drawing.Color.White
        Me.lbTax.Name = "lbTax"
        '
        'lbCalcPeriod
        '
        Me.lbCalcPeriod.AccessibleDescription = Nothing
        Me.lbCalcPeriod.AccessibleName = Nothing
        resources.ApplyResources(Me.lbCalcPeriod, "lbCalcPeriod")
        Me.lbCalcPeriod.BackColor = System.Drawing.Color.Transparent
        Me.lbCalcPeriod.ForeColor = System.Drawing.Color.White
        Me.lbCalcPeriod.Name = "lbCalcPeriod"
        '
        'rbPeriodPay
        '
        Me.rbPeriodPay.AccessibleDescription = Nothing
        Me.rbPeriodPay.AccessibleName = Nothing
        resources.ApplyResources(Me.rbPeriodPay, "rbPeriodPay")
        Me.rbPeriodPay.BackgroundImage = Nothing
        Me.rbPeriodPay.Checked = True
        Me.rbPeriodPay.ForeColor = System.Drawing.Color.Black
        Me.rbPeriodPay.Name = "rbPeriodPay"
        Me.rbPeriodPay.TabStop = True
        '
        'rbPeriodWeekly
        '
        Me.rbPeriodWeekly.AccessibleDescription = Nothing
        Me.rbPeriodWeekly.AccessibleName = Nothing
        resources.ApplyResources(Me.rbPeriodWeekly, "rbPeriodWeekly")
        Me.rbPeriodWeekly.BackgroundImage = Nothing
        Me.rbPeriodWeekly.ForeColor = System.Drawing.Color.Black
        Me.rbPeriodWeekly.Name = "rbPeriodWeekly"
        '
        'lbBandingType
        '
        Me.lbBandingType.AccessibleDescription = Nothing
        Me.lbBandingType.AccessibleName = Nothing
        resources.ApplyResources(Me.lbBandingType, "lbBandingType")
        Me.lbBandingType.ForeColor = System.Drawing.Color.White
        Me.lbBandingType.Name = "lbBandingType"
        '
        'rbBandTarget
        '
        Me.rbBandTarget.AccessibleDescription = Nothing
        Me.rbBandTarget.AccessibleName = Nothing
        resources.ApplyResources(Me.rbBandTarget, "rbBandTarget")
        Me.rbBandTarget.BackgroundImage = Nothing
        Me.rbBandTarget.ForeColor = System.Drawing.Color.Black
        Me.rbBandTarget.Name = "rbBandTarget"
        '
        'rbBandCum
        '
        Me.rbBandCum.AccessibleDescription = Nothing
        Me.rbBandCum.AccessibleName = Nothing
        resources.ApplyResources(Me.rbBandCum, "rbBandCum")
        Me.rbBandCum.BackgroundImage = Nothing
        Me.rbBandCum.Checked = True
        Me.rbBandCum.ForeColor = System.Drawing.Color.Black
        Me.rbBandCum.Name = "rbBandCum"
        Me.rbBandCum.TabStop = True
        '
        'rbTypeChem
        '
        Me.rbTypeChem.AccessibleDescription = Nothing
        Me.rbTypeChem.AccessibleName = Nothing
        resources.ApplyResources(Me.rbTypeChem, "rbTypeChem")
        Me.rbTypeChem.BackgroundImage = Nothing
        Me.rbTypeChem.Name = "rbTypeChem"
        '
        'rbTypeSun
        '
        Me.rbTypeSun.AccessibleDescription = Nothing
        Me.rbTypeSun.AccessibleName = Nothing
        resources.ApplyResources(Me.rbTypeSun, "rbTypeSun")
        Me.rbTypeSun.BackgroundImage = Nothing
        Me.rbTypeSun.Checked = True
        Me.rbTypeSun.Name = "rbTypeSun"
        Me.rbTypeSun.TabStop = True
        '
        'lbAdditionalType
        '
        Me.lbAdditionalType.AccessibleDescription = Nothing
        Me.lbAdditionalType.AccessibleName = Nothing
        resources.ApplyResources(Me.lbAdditionalType, "lbAdditionalType")
        Me.lbAdditionalType.BackColor = System.Drawing.Color.Transparent
        Me.lbAdditionalType.ForeColor = System.Drawing.Color.White
        Me.lbAdditionalType.Name = "lbAdditionalType"
        '
        'rbTypeRef
        '
        Me.rbTypeRef.AccessibleDescription = Nothing
        Me.rbTypeRef.AccessibleName = Nothing
        resources.ApplyResources(Me.rbTypeRef, "rbTypeRef")
        Me.rbTypeRef.BackgroundImage = Nothing
        Me.rbTypeRef.Name = "rbTypeRef"
        '
        'rbRefN
        '
        Me.rbRefN.AccessibleDescription = Nothing
        Me.rbRefN.AccessibleName = Nothing
        resources.ApplyResources(Me.rbRefN, "rbRefN")
        Me.rbRefN.BackgroundImage = Nothing
        Me.rbRefN.Checked = True
        Me.rbRefN.Name = "rbRefN"
        Me.rbRefN.TabStop = True
        '
        'pbRefChem
        '
        Me.pbRefChem.AccessibleDescription = Nothing
        Me.pbRefChem.AccessibleName = Nothing
        resources.ApplyResources(Me.pbRefChem, "pbRefChem")
        Me.pbRefChem.BackgroundImage = Nothing
        Me.pbRefChem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRefChem.Font = Nothing
        Me.pbRefChem.ImageLocation = Nothing
        Me.pbRefChem.Name = "pbRefChem"
        Me.pbRefChem.TabStop = False
        '
        'rbRefY
        '
        Me.rbRefY.AccessibleDescription = Nothing
        Me.rbRefY.AccessibleName = Nothing
        resources.ApplyResources(Me.rbRefY, "rbRefY")
        Me.rbRefY.BackgroundImage = Nothing
        Me.rbRefY.Name = "rbRefY"
        '
        'gbRefChem
        '
        Me.gbRefChem.AccessibleDescription = Nothing
        Me.gbRefChem.AccessibleName = Nothing
        resources.ApplyResources(Me.gbRefChem, "gbRefChem")
        Me.gbRefChem.BackColor = System.Drawing.Color.Transparent
        Me.gbRefChem.BackgroundImage = Nothing
        Me.gbRefChem.Controls.Add(Me.rbRefY)
        Me.gbRefChem.Controls.Add(Me.rbRefN)
        Me.gbRefChem.Controls.Add(Me.lbReferChemOnly)
        Me.gbRefChem.Controls.Add(Me.pbRefChem)
        Me.gbRefChem.Font = Nothing
        Me.gbRefChem.Name = "gbRefChem"
        Me.gbRefChem.TabStop = False
        '
        'lbReferChemOnly
        '
        Me.lbReferChemOnly.AccessibleDescription = Nothing
        Me.lbReferChemOnly.AccessibleName = Nothing
        resources.ApplyResources(Me.lbReferChemOnly, "lbReferChemOnly")
        Me.lbReferChemOnly.ForeColor = System.Drawing.Color.White
        Me.lbReferChemOnly.Name = "lbReferChemOnly"
        '
        'lbRemoveCostService
        '
        Me.lbRemoveCostService.AccessibleDescription = Nothing
        Me.lbRemoveCostService.AccessibleName = Nothing
        resources.ApplyResources(Me.lbRemoveCostService, "lbRemoveCostService")
        Me.lbRemoveCostService.BackColor = System.Drawing.Color.Transparent
        Me.lbRemoveCostService.ForeColor = System.Drawing.Color.White
        Me.lbRemoveCostService.Name = "lbRemoveCostService"
        '
        'rbCostY
        '
        Me.rbCostY.AccessibleDescription = Nothing
        Me.rbCostY.AccessibleName = Nothing
        resources.ApplyResources(Me.rbCostY, "rbCostY")
        Me.rbCostY.BackgroundImage = Nothing
        Me.rbCostY.ForeColor = System.Drawing.Color.Black
        Me.rbCostY.Name = "rbCostY"
        '
        'rbCostN
        '
        Me.rbCostN.AccessibleDescription = Nothing
        Me.rbCostN.AccessibleName = Nothing
        resources.ApplyResources(Me.rbCostN, "rbCostN")
        Me.rbCostN.BackgroundImage = Nothing
        Me.rbCostN.Checked = True
        Me.rbCostN.ForeColor = System.Drawing.Color.Black
        Me.rbCostN.Name = "rbCostN"
        Me.rbCostN.TabStop = True
        '
        'lbSetFeeBill
        '
        Me.lbSetFeeBill.AccessibleDescription = Nothing
        Me.lbSetFeeBill.AccessibleName = Nothing
        resources.ApplyResources(Me.lbSetFeeBill, "lbSetFeeBill")
        Me.lbSetFeeBill.BackColor = System.Drawing.Color.Transparent
        Me.lbSetFeeBill.ForeColor = System.Drawing.Color.White
        Me.lbSetFeeBill.Name = "lbSetFeeBill"
        '
        'tbServiceTaken
        '
        Me.tbServiceTaken.AccessibleDescription = Nothing
        Me.tbServiceTaken.AccessibleName = Nothing
        resources.ApplyResources(Me.tbServiceTaken, "tbServiceTaken")
        Me.tbServiceTaken.BackgroundImage = Nothing
        Me.tbServiceTaken.Name = "tbServiceTaken"
        '
        'lbFallBackWage
        '
        Me.lbFallBackWage.AccessibleDescription = Nothing
        Me.lbFallBackWage.AccessibleName = Nothing
        resources.ApplyResources(Me.lbFallBackWage, "lbFallBackWage")
        Me.lbFallBackWage.ForeColor = System.Drawing.Color.White
        Me.lbFallBackWage.Name = "lbFallBackWage"
        '
        'rbFallY
        '
        Me.rbFallY.AccessibleDescription = Nothing
        Me.rbFallY.AccessibleName = Nothing
        resources.ApplyResources(Me.rbFallY, "rbFallY")
        Me.rbFallY.BackgroundImage = Nothing
        Me.rbFallY.Name = "rbFallY"
        '
        'rbFallN
        '
        Me.rbFallN.AccessibleDescription = Nothing
        Me.rbFallN.AccessibleName = Nothing
        resources.ApplyResources(Me.rbFallN, "rbFallN")
        Me.rbFallN.BackgroundImage = Nothing
        Me.rbFallN.Checked = True
        Me.rbFallN.Name = "rbFallN"
        Me.rbFallN.TabStop = True
        '
        'tbTipFee
        '
        Me.tbTipFee.AccessibleDescription = Nothing
        Me.tbTipFee.AccessibleName = Nothing
        resources.ApplyResources(Me.tbTipFee, "tbTipFee")
        Me.tbTipFee.BackgroundImage = Nothing
        Me.tbTipFee.Name = "tbTipFee"
        '
        'Label9
        '
        Me.Label9.AccessibleDescription = Nothing
        Me.Label9.AccessibleName = Nothing
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Font = Nothing
        Me.Label9.Name = "Label9"
        '
        'lbRetailSplit
        '
        Me.lbRetailSplit.AccessibleDescription = Nothing
        Me.lbRetailSplit.AccessibleName = Nothing
        resources.ApplyResources(Me.lbRetailSplit, "lbRetailSplit")
        Me.lbRetailSplit.ForeColor = System.Drawing.Color.White
        Me.lbRetailSplit.Name = "lbRetailSplit"
        '
        'lbReceptionist
        '
        Me.lbReceptionist.AccessibleDescription = Nothing
        Me.lbReceptionist.AccessibleName = Nothing
        resources.ApplyResources(Me.lbReceptionist, "lbReceptionist")
        Me.lbReceptionist.Name = "lbReceptionist"
        '
        'tbSplitRecep
        '
        Me.tbSplitRecep.AccessibleDescription = Nothing
        Me.tbSplitRecep.AccessibleName = Nothing
        resources.ApplyResources(Me.tbSplitRecep, "tbSplitRecep")
        Me.tbSplitRecep.BackgroundImage = Nothing
        Me.tbSplitRecep.Name = "tbSplitRecep"
        Me.tbSplitRecep.ReadOnly = True
        '
        'Label12
        '
        Me.Label12.AccessibleDescription = Nothing
        Me.Label12.AccessibleName = Nothing
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'lbStylist
        '
        Me.lbStylist.AccessibleDescription = Nothing
        Me.lbStylist.AccessibleName = Nothing
        resources.ApplyResources(Me.lbStylist, "lbStylist")
        Me.lbStylist.Name = "lbStylist"
        '
        'tbSplitStyle
        '
        Me.tbSplitStyle.AccessibleDescription = Nothing
        Me.tbSplitStyle.AccessibleName = Nothing
        resources.ApplyResources(Me.tbSplitStyle, "tbSplitStyle")
        Me.tbSplitStyle.BackgroundImage = Nothing
        Me.tbSplitStyle.Name = "tbSplitStyle"
        '
        'Label14
        '
        Me.Label14.AccessibleDescription = Nothing
        Me.Label14.AccessibleName = Nothing
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'rbWageRos
        '
        Me.rbWageRos.AccessibleDescription = Nothing
        Me.rbWageRos.AccessibleName = Nothing
        resources.ApplyResources(Me.rbWageRos, "rbWageRos")
        Me.rbWageRos.BackgroundImage = Nothing
        Me.rbWageRos.ForeColor = System.Drawing.Color.Black
        Me.rbWageRos.Name = "rbWageRos"
        '
        'rbWageLog
        '
        Me.rbWageLog.AccessibleDescription = Nothing
        Me.rbWageLog.AccessibleName = Nothing
        resources.ApplyResources(Me.rbWageLog, "rbWageLog")
        Me.rbWageLog.BackgroundImage = Nothing
        Me.rbWageLog.Checked = True
        Me.rbWageLog.ForeColor = System.Drawing.Color.Black
        Me.rbWageLog.Name = "rbWageLog"
        Me.rbWageLog.TabStop = True
        '
        'lbWageSchedule
        '
        Me.lbWageSchedule.AccessibleDescription = Nothing
        Me.lbWageSchedule.AccessibleName = Nothing
        resources.ApplyResources(Me.lbWageSchedule, "lbWageSchedule")
        Me.lbWageSchedule.ForeColor = System.Drawing.Color.White
        Me.lbWageSchedule.Name = "lbWageSchedule"
        '
        'gbClient
        '
        Me.gbClient.AccessibleDescription = Nothing
        Me.gbClient.AccessibleName = Nothing
        resources.ApplyResources(Me.gbClient, "gbClient")
        Me.gbClient.BackgroundImage = Nothing
        Me.gbClient.Controls.Add(Me.lbRequestClientTarget)
        Me.gbClient.Controls.Add(Me.rbGoalNo)
        Me.gbClient.Controls.Add(Me.rbGoalY)
        Me.gbClient.Controls.Add(Me.pbClientTar)
        Me.gbClient.Font = Nothing
        Me.gbClient.Name = "gbClient"
        Me.gbClient.TabStop = False
        '
        'lbRequestClientTarget
        '
        Me.lbRequestClientTarget.AccessibleDescription = Nothing
        Me.lbRequestClientTarget.AccessibleName = Nothing
        resources.ApplyResources(Me.lbRequestClientTarget, "lbRequestClientTarget")
        Me.lbRequestClientTarget.ForeColor = System.Drawing.Color.White
        Me.lbRequestClientTarget.Name = "lbRequestClientTarget"
        '
        'rbGoalNo
        '
        Me.rbGoalNo.AccessibleDescription = Nothing
        Me.rbGoalNo.AccessibleName = Nothing
        resources.ApplyResources(Me.rbGoalNo, "rbGoalNo")
        Me.rbGoalNo.BackgroundImage = Nothing
        Me.rbGoalNo.Checked = True
        Me.rbGoalNo.Name = "rbGoalNo"
        Me.rbGoalNo.TabStop = True
        '
        'rbGoalY
        '
        Me.rbGoalY.AccessibleDescription = Nothing
        Me.rbGoalY.AccessibleName = Nothing
        resources.ApplyResources(Me.rbGoalY, "rbGoalY")
        Me.rbGoalY.BackgroundImage = Nothing
        Me.rbGoalY.Name = "rbGoalY"
        '
        'pbClientTar
        '
        Me.pbClientTar.AccessibleDescription = Nothing
        Me.pbClientTar.AccessibleName = Nothing
        resources.ApplyResources(Me.pbClientTar, "pbClientTar")
        Me.pbClientTar.BackColor = System.Drawing.Color.Transparent
        Me.pbClientTar.BackgroundImage = Nothing
        Me.pbClientTar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbClientTar.Font = Nothing
        Me.pbClientTar.ImageLocation = Nothing
        Me.pbClientTar.Name = "pbClientTar"
        Me.pbClientTar.TabStop = False
        '
        'lbRetailComm
        '
        Me.lbRetailComm.AccessibleDescription = Nothing
        Me.lbRetailComm.AccessibleName = Nothing
        resources.ApplyResources(Me.lbRetailComm, "lbRetailComm")
        Me.lbRetailComm.BackColor = System.Drawing.Color.Transparent
        Me.lbRetailComm.ForeColor = System.Drawing.Color.White
        Me.lbRetailComm.Name = "lbRetailComm"
        '
        'rbRetailLine
        '
        Me.rbRetailLine.AccessibleDescription = Nothing
        Me.rbRetailLine.AccessibleName = Nothing
        resources.ApplyResources(Me.rbRetailLine, "rbRetailLine")
        Me.rbRetailLine.BackgroundImage = Nothing
        Me.rbRetailLine.Name = "rbRetailLine"
        '
        'Panel1
        '
        Me.Panel1.AccessibleDescription = Nothing
        Me.Panel1.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Nothing
        Me.Panel1.Controls.Add(Me.rbTaxInclude)
        Me.Panel1.Controls.Add(Me.rbTaxExclude)
        Me.Panel1.Font = Nothing
        Me.Panel1.Name = "Panel1"
        '
        'Panel2
        '
        Me.Panel2.AccessibleDescription = Nothing
        Me.Panel2.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Nothing
        Me.Panel2.Controls.Add(Me.rbTypeChem)
        Me.Panel2.Controls.Add(Me.rbTypeSun)
        Me.Panel2.Controls.Add(Me.rbTypeRef)
        Me.Panel2.Controls.Add(Me.rbTypeClienC)
        Me.Panel2.Font = Nothing
        Me.Panel2.Name = "Panel2"
        '
        'rbTypeClienC
        '
        Me.rbTypeClienC.AccessibleDescription = Nothing
        Me.rbTypeClienC.AccessibleName = Nothing
        resources.ApplyResources(Me.rbTypeClienC, "rbTypeClienC")
        Me.rbTypeClienC.BackgroundImage = Nothing
        Me.rbTypeClienC.Name = "rbTypeClienC"
        '
        'Panel3
        '
        Me.Panel3.AccessibleDescription = Nothing
        Me.Panel3.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = Nothing
        Me.Panel3.Controls.Add(Me.rbPeriodPay)
        Me.Panel3.Controls.Add(Me.rbPeriodWeekly)
        Me.Panel3.Font = Nothing
        Me.Panel3.Name = "Panel3"
        '
        'Panel4
        '
        Me.Panel4.AccessibleDescription = Nothing
        Me.Panel4.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImage = Nothing
        Me.Panel4.Controls.Add(Me.rbBandTarget)
        Me.Panel4.Controls.Add(Me.rbBandCum)
        Me.Panel4.Font = Nothing
        Me.Panel4.Name = "Panel4"
        '
        'Panel5
        '
        Me.Panel5.AccessibleDescription = Nothing
        Me.Panel5.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel5, "Panel5")
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImage = Nothing
        Me.Panel5.Controls.Add(Me.rbCostY)
        Me.Panel5.Controls.Add(Me.rbCostN)
        Me.Panel5.Font = Nothing
        Me.Panel5.Name = "Panel5"
        '
        'Panel6
        '
        Me.Panel6.AccessibleDescription = Nothing
        Me.Panel6.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel6, "Panel6")
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.BackgroundImage = Nothing
        Me.Panel6.Controls.Add(Me.rbFallY)
        Me.Panel6.Controls.Add(Me.rbFallN)
        Me.Panel6.Font = Nothing
        Me.Panel6.Name = "Panel6"
        '
        'Panel7
        '
        Me.Panel7.AccessibleDescription = Nothing
        Me.Panel7.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel7, "Panel7")
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.BackgroundImage = Nothing
        Me.Panel7.Controls.Add(Me.rbWageRos)
        Me.Panel7.Controls.Add(Me.rbWageLog)
        Me.Panel7.Font = Nothing
        Me.Panel7.ForeColor = System.Drawing.Color.Black
        Me.Panel7.Name = "Panel7"
        '
        'Panel8
        '
        Me.Panel8.AccessibleDescription = Nothing
        Me.Panel8.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel8, "Panel8")
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.BackgroundImage = Nothing
        Me.Panel8.Controls.Add(Me.rbSerBand)
        Me.Panel8.Controls.Add(Me.rbRetailLine)
        Me.Panel8.Font = Nothing
        Me.Panel8.Name = "Panel8"
        '
        'rbSerBand
        '
        Me.rbSerBand.AccessibleDescription = Nothing
        Me.rbSerBand.AccessibleName = Nothing
        resources.ApplyResources(Me.rbSerBand, "rbSerBand")
        Me.rbSerBand.BackgroundImage = Nothing
        Me.rbSerBand.Name = "rbSerBand"
        '
        'PictureBox9
        '
        Me.PictureBox9.AccessibleDescription = Nothing
        Me.PictureBox9.AccessibleName = Nothing
        resources.ApplyResources(Me.PictureBox9, "PictureBox9")
        Me.PictureBox9.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.PictureBox9.BackgroundImage = Nothing
        Me.PictureBox9.Font = Nothing
        Me.PictureBox9.ImageLocation = Nothing
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.TabStop = False
        '
        'rbMoney
        '
        Me.rbMoney.AccessibleDescription = Nothing
        Me.rbMoney.AccessibleName = Nothing
        resources.ApplyResources(Me.rbMoney, "rbMoney")
        Me.rbMoney.BackgroundImage = Nothing
        Me.rbMoney.Font = Nothing
        Me.rbMoney.Name = "rbMoney"
        '
        'rbPercent
        '
        Me.rbPercent.AccessibleDescription = Nothing
        Me.rbPercent.AccessibleName = Nothing
        resources.ApplyResources(Me.rbPercent, "rbPercent")
        Me.rbPercent.BackgroundImage = Nothing
        Me.rbPercent.Checked = True
        Me.rbPercent.Font = Nothing
        Me.rbPercent.Name = "rbPercent"
        Me.rbPercent.TabStop = True
        '
        'lbPercent
        '
        Me.lbPercent.AccessibleDescription = Nothing
        Me.lbPercent.AccessibleName = Nothing
        resources.ApplyResources(Me.lbPercent, "lbPercent")
        Me.lbPercent.Name = "lbPercent"
        '
        'lbMoney
        '
        Me.lbMoney.AccessibleDescription = Nothing
        Me.lbMoney.AccessibleName = Nothing
        resources.ApplyResources(Me.lbMoney, "lbMoney")
        Me.lbMoney.Font = Nothing
        Me.lbMoney.Name = "lbMoney"
        '
        'Panel10
        '
        Me.Panel10.AccessibleDescription = Nothing
        Me.Panel10.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel10, "Panel10")
        Me.Panel10.BackgroundImage = Nothing
        Me.Panel10.Controls.Add(Me.rbPercent)
        Me.Panel10.Controls.Add(Me.rbMoney)
        Me.Panel10.Font = Nothing
        Me.Panel10.Name = "Panel10"
        '
        'Panel11
        '
        Me.Panel11.AccessibleDescription = Nothing
        Me.Panel11.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel11, "Panel11")
        Me.Panel11.BackColor = System.Drawing.Color.Transparent
        Me.Panel11.BackgroundImage = Nothing
        Me.Panel11.Controls.Add(Me.rbPayServiceY)
        Me.Panel11.Controls.Add(Me.rbPayServiceN)
        Me.Panel11.Font = Nothing
        Me.Panel11.Name = "Panel11"
        '
        'rbPayServiceY
        '
        Me.rbPayServiceY.AccessibleDescription = Nothing
        Me.rbPayServiceY.AccessibleName = Nothing
        resources.ApplyResources(Me.rbPayServiceY, "rbPayServiceY")
        Me.rbPayServiceY.BackgroundImage = Nothing
        Me.rbPayServiceY.Name = "rbPayServiceY"
        '
        'rbPayServiceN
        '
        Me.rbPayServiceN.AccessibleDescription = Nothing
        Me.rbPayServiceN.AccessibleName = Nothing
        resources.ApplyResources(Me.rbPayServiceN, "rbPayServiceN")
        Me.rbPayServiceN.BackgroundImage = Nothing
        Me.rbPayServiceN.Checked = True
        Me.rbPayServiceN.Name = "rbPayServiceN"
        Me.rbPayServiceN.TabStop = True
        '
        'lbPayServiceSales
        '
        Me.lbPayServiceSales.AccessibleDescription = Nothing
        Me.lbPayServiceSales.AccessibleName = Nothing
        resources.ApplyResources(Me.lbPayServiceSales, "lbPayServiceSales")
        Me.lbPayServiceSales.ForeColor = System.Drawing.Color.White
        Me.lbPayServiceSales.Name = "lbPayServiceSales"
        '
        'btnExit
        '
        Me.btnExit.AccessibleDescription = Nothing
        Me.btnExit.AccessibleName = Nothing
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.BackgroundImage = Nothing
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = Nothing
        Me.btnExit.ImageLocation = Nothing
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabStop = False
        '
        'Panel12
        '
        Me.Panel12.AccessibleDescription = Nothing
        Me.Panel12.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel12, "Panel12")
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.Label20)
        Me.Panel12.Controls.Add(Me.lbTitle)
        Me.Panel12.Controls.Add(Me.PictureBox9)
        Me.Panel12.Font = Nothing
        Me.Panel12.Name = "Panel12"
        '
        'Label20
        '
        Me.Label20.AccessibleDescription = Nothing
        Me.Label20.AccessibleName = Nothing
        resources.ApplyResources(Me.Label20, "Label20")
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Name = "Label20"
        '
        'lbTitle
        '
        Me.lbTitle.AccessibleDescription = Nothing
        Me.lbTitle.AccessibleName = Nothing
        resources.ApplyResources(Me.lbTitle, "lbTitle")
        Me.lbTitle.BackColor = System.Drawing.Color.Transparent
        Me.lbTitle.ForeColor = System.Drawing.Color.White
        Me.lbTitle.Name = "lbTitle"
        '
        'pbRecComm
        '
        Me.pbRecComm.AccessibleDescription = Nothing
        Me.pbRecComm.AccessibleName = Nothing
        resources.ApplyResources(Me.pbRecComm, "pbRecComm")
        Me.pbRecComm.BackgroundImage = Nothing
        Me.pbRecComm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRecComm.Font = Nothing
        Me.pbRecComm.ImageLocation = Nothing
        Me.pbRecComm.Name = "pbRecComm"
        Me.pbRecComm.TabStop = False
        '
        'lbExit
        '
        Me.lbExit.AccessibleDescription = Nothing
        Me.lbExit.AccessibleName = Nothing
        resources.ApplyResources(Me.lbExit, "lbExit")
        Me.lbExit.BackColor = System.Drawing.Color.Transparent
        Me.lbExit.Name = "lbExit"
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
        Me.lbSave.BackColor = System.Drawing.Color.Transparent
        Me.lbSave.Name = "lbSave"
        '
        'btnHelp
        '
        Me.btnHelp.AccessibleDescription = Nothing
        Me.btnHelp.AccessibleName = Nothing
        resources.ApplyResources(Me.btnHelp, "btnHelp")
        Me.btnHelp.BackgroundImage = Nothing
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHelp.Font = Nothing
        Me.btnHelp.ImageLocation = Nothing
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.TabStop = False
        '
        'btnBands
        '
        Me.btnBands.AccessibleDescription = Nothing
        Me.btnBands.AccessibleName = Nothing
        resources.ApplyResources(Me.btnBands, "btnBands")
        Me.btnBands.BackgroundImage = Nothing
        Me.btnBands.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBands.Font = Nothing
        Me.btnBands.ImageLocation = Nothing
        Me.btnBands.Name = "btnBands"
        Me.btnBands.TabStop = False
        '
        'lbBands
        '
        Me.lbBands.AccessibleDescription = Nothing
        Me.lbBands.AccessibleName = Nothing
        resources.ApplyResources(Me.lbBands, "lbBands")
        Me.lbBands.Name = "lbBands"
        '
        'lbHelp
        '
        Me.lbHelp.AccessibleDescription = Nothing
        Me.lbHelp.AccessibleName = Nothing
        resources.ApplyResources(Me.lbHelp, "lbHelp")
        Me.lbHelp.Name = "lbHelp"
        '
        'PBpAYsERVICE
        '
        Me.PBpAYsERVICE.AccessibleDescription = Nothing
        Me.PBpAYsERVICE.AccessibleName = Nothing
        resources.ApplyResources(Me.PBpAYsERVICE, "PBpAYsERVICE")
        Me.PBpAYsERVICE.BackgroundImage = Nothing
        Me.PBpAYsERVICE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBpAYsERVICE.Font = Nothing
        Me.PBpAYsERVICE.ImageLocation = Nothing
        Me.PBpAYsERVICE.Name = "PBpAYsERVICE"
        Me.PBpAYsERVICE.TabStop = False
        '
        'pbFall
        '
        Me.pbFall.AccessibleDescription = Nothing
        Me.pbFall.AccessibleName = Nothing
        resources.ApplyResources(Me.pbFall, "pbFall")
        Me.pbFall.BackgroundImage = Nothing
        Me.pbFall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbFall.Font = Nothing
        Me.pbFall.ImageLocation = Nothing
        Me.pbFall.Name = "pbFall"
        Me.pbFall.TabStop = False
        '
        'pbCost
        '
        Me.pbCost.AccessibleDescription = Nothing
        Me.pbCost.AccessibleName = Nothing
        resources.ApplyResources(Me.pbCost, "pbCost")
        Me.pbCost.BackgroundImage = Nothing
        Me.pbCost.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbCost.Font = Nothing
        Me.pbCost.ImageLocation = Nothing
        Me.pbCost.Name = "pbCost"
        Me.pbCost.TabStop = False
        '
        'pbSplit
        '
        Me.pbSplit.AccessibleDescription = Nothing
        Me.pbSplit.AccessibleName = Nothing
        resources.ApplyResources(Me.pbSplit, "pbSplit")
        Me.pbSplit.BackgroundImage = Nothing
        Me.pbSplit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbSplit.Font = Nothing
        Me.pbSplit.ImageLocation = Nothing
        Me.pbSplit.Name = "pbSplit"
        Me.pbSplit.TabStop = False
        '
        'pbServiceFee
        '
        Me.pbServiceFee.AccessibleDescription = Nothing
        Me.pbServiceFee.AccessibleName = Nothing
        resources.ApplyResources(Me.pbServiceFee, "pbServiceFee")
        Me.pbServiceFee.BackgroundImage = Nothing
        Me.pbServiceFee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbServiceFee.Font = Nothing
        Me.pbServiceFee.ImageLocation = Nothing
        Me.pbServiceFee.Name = "pbServiceFee"
        Me.pbServiceFee.TabStop = False
        '
        'pbWage
        '
        Me.pbWage.AccessibleDescription = Nothing
        Me.pbWage.AccessibleName = Nothing
        resources.ApplyResources(Me.pbWage, "pbWage")
        Me.pbWage.BackgroundImage = Nothing
        Me.pbWage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbWage.Font = Nothing
        Me.pbWage.ImageLocation = Nothing
        Me.pbWage.Name = "pbWage"
        Me.pbWage.TabStop = False
        '
        'pbBandType
        '
        Me.pbBandType.AccessibleDescription = Nothing
        Me.pbBandType.AccessibleName = Nothing
        resources.ApplyResources(Me.pbBandType, "pbBandType")
        Me.pbBandType.BackgroundImage = Nothing
        Me.pbBandType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBandType.Font = Nothing
        Me.pbBandType.ImageLocation = Nothing
        Me.pbBandType.Name = "pbBandType"
        Me.pbBandType.TabStop = False
        '
        'pbHelpPeriod
        '
        Me.pbHelpPeriod.AccessibleDescription = Nothing
        Me.pbHelpPeriod.AccessibleName = Nothing
        resources.ApplyResources(Me.pbHelpPeriod, "pbHelpPeriod")
        Me.pbHelpPeriod.BackgroundImage = Nothing
        Me.pbHelpPeriod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbHelpPeriod.Font = Nothing
        Me.pbHelpPeriod.ImageLocation = Nothing
        Me.pbHelpPeriod.Name = "pbHelpPeriod"
        Me.pbHelpPeriod.TabStop = False
        '
        'pbHelpTax
        '
        Me.pbHelpTax.AccessibleDescription = Nothing
        Me.pbHelpTax.AccessibleName = Nothing
        resources.ApplyResources(Me.pbHelpTax, "pbHelpTax")
        Me.pbHelpTax.BackgroundImage = Nothing
        Me.pbHelpTax.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbHelpTax.Font = Nothing
        Me.pbHelpTax.ImageLocation = Nothing
        Me.pbHelpTax.Name = "pbHelpTax"
        Me.pbHelpTax.TabStop = False
        '
        'pbSunComm
        '
        Me.pbSunComm.AccessibleDescription = Nothing
        Me.pbSunComm.AccessibleName = Nothing
        resources.ApplyResources(Me.pbSunComm, "pbSunComm")
        Me.pbSunComm.BackgroundImage = Nothing
        Me.pbSunComm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbSunComm.Font = Nothing
        Me.pbSunComm.ImageLocation = Nothing
        Me.pbSunComm.Name = "pbSunComm"
        Me.pbSunComm.TabStop = False
        '
        'pbStockCost
        '
        Me.pbStockCost.AccessibleDescription = Nothing
        Me.pbStockCost.AccessibleName = Nothing
        resources.ApplyResources(Me.pbStockCost, "pbStockCost")
        Me.pbStockCost.BackgroundImage = Nothing
        Me.pbStockCost.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbStockCost.Font = Nothing
        Me.pbStockCost.ImageLocation = Nothing
        Me.pbStockCost.Name = "pbStockCost"
        Me.pbStockCost.TabStop = False
        '
        'Panel9
        '
        Me.Panel9.AccessibleDescription = Nothing
        Me.Panel9.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel9, "Panel9")
        Me.Panel9.BackColor = System.Drawing.Color.Transparent
        Me.Panel9.BackgroundImage = Nothing
        Me.Panel9.Controls.Add(Me.rbCostStockY)
        Me.Panel9.Controls.Add(Me.rbCostStockN)
        Me.Panel9.Font = Nothing
        Me.Panel9.Name = "Panel9"
        '
        'rbCostStockY
        '
        Me.rbCostStockY.AccessibleDescription = Nothing
        Me.rbCostStockY.AccessibleName = Nothing
        resources.ApplyResources(Me.rbCostStockY, "rbCostStockY")
        Me.rbCostStockY.BackgroundImage = Nothing
        Me.rbCostStockY.ForeColor = System.Drawing.Color.Black
        Me.rbCostStockY.Name = "rbCostStockY"
        '
        'rbCostStockN
        '
        Me.rbCostStockN.AccessibleDescription = Nothing
        Me.rbCostStockN.AccessibleName = Nothing
        resources.ApplyResources(Me.rbCostStockN, "rbCostStockN")
        Me.rbCostStockN.BackgroundImage = Nothing
        Me.rbCostStockN.Checked = True
        Me.rbCostStockN.ForeColor = System.Drawing.Color.Black
        Me.rbCostStockN.Name = "rbCostStockN"
        Me.rbCostStockN.TabStop = True
        '
        'lbRemoveCostProd
        '
        Me.lbRemoveCostProd.AccessibleDescription = Nothing
        Me.lbRemoveCostProd.AccessibleName = Nothing
        resources.ApplyResources(Me.lbRemoveCostProd, "lbRemoveCostProd")
        Me.lbRemoveCostProd.BackColor = System.Drawing.Color.Transparent
        Me.lbRemoveCostProd.ForeColor = System.Drawing.Color.White
        Me.lbRemoveCostProd.Name = "lbRemoveCostProd"
        '
        'pbTipsProcessing
        '
        Me.pbTipsProcessing.AccessibleDescription = Nothing
        Me.pbTipsProcessing.AccessibleName = Nothing
        resources.ApplyResources(Me.pbTipsProcessing, "pbTipsProcessing")
        Me.pbTipsProcessing.BackgroundImage = Nothing
        Me.pbTipsProcessing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbTipsProcessing.Font = Nothing
        Me.pbTipsProcessing.ImageLocation = Nothing
        Me.pbTipsProcessing.Name = "pbTipsProcessing"
        Me.pbTipsProcessing.TabStop = False
        '
        'Panel13
        '
        Me.Panel13.AccessibleDescription = Nothing
        Me.Panel13.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel13, "Panel13")
        Me.Panel13.BackColor = System.Drawing.Color.Transparent
        Me.Panel13.BackgroundImage = Nothing
        Me.Panel13.Controls.Add(Me.rbIncludeTips)
        Me.Panel13.Controls.Add(Me.rbExcludeTips)
        Me.Panel13.Font = Nothing
        Me.Panel13.Name = "Panel13"
        '
        'rbIncludeTips
        '
        Me.rbIncludeTips.AccessibleDescription = Nothing
        Me.rbIncludeTips.AccessibleName = Nothing
        resources.ApplyResources(Me.rbIncludeTips, "rbIncludeTips")
        Me.rbIncludeTips.BackgroundImage = Nothing
        Me.rbIncludeTips.Name = "rbIncludeTips"
        '
        'rbExcludeTips
        '
        Me.rbExcludeTips.AccessibleDescription = Nothing
        Me.rbExcludeTips.AccessibleName = Nothing
        resources.ApplyResources(Me.rbExcludeTips, "rbExcludeTips")
        Me.rbExcludeTips.BackgroundImage = Nothing
        Me.rbExcludeTips.Checked = True
        Me.rbExcludeTips.Name = "rbExcludeTips"
        Me.rbExcludeTips.TabStop = True
        '
        'lbTipsProcessing
        '
        Me.lbTipsProcessing.AccessibleDescription = Nothing
        Me.lbTipsProcessing.AccessibleName = Nothing
        resources.ApplyResources(Me.lbTipsProcessing, "lbTipsProcessing")
        Me.lbTipsProcessing.BackColor = System.Drawing.Color.Transparent
        Me.lbTipsProcessing.ForeColor = System.Drawing.Color.White
        Me.lbTipsProcessing.Name = "lbTipsProcessing"
        '
        'gbTips
        '
        Me.gbTips.AccessibleDescription = Nothing
        Me.gbTips.AccessibleName = Nothing
        resources.ApplyResources(Me.gbTips, "gbTips")
        Me.gbTips.BackColor = System.Drawing.Color.Transparent
        Me.gbTips.BackgroundImage = Nothing
        Me.gbTips.Controls.Add(Me.lbTipsFee)
        Me.gbTips.Controls.Add(Me.pbTipFee)
        Me.gbTips.Controls.Add(Me.rbTipComY)
        Me.gbTips.Controls.Add(Me.rbTipComN)
        Me.gbTips.Controls.Add(Me.lbPayTips)
        Me.gbTips.Controls.Add(Me.pbTipsPayCom)
        Me.gbTips.Controls.Add(Me.tbTipFee)
        Me.gbTips.Controls.Add(Me.Label9)
        Me.gbTips.Font = Nothing
        Me.gbTips.Name = "gbTips"
        Me.gbTips.TabStop = False
        '
        'lbTipsFee
        '
        Me.lbTipsFee.AccessibleDescription = Nothing
        Me.lbTipsFee.AccessibleName = Nothing
        resources.ApplyResources(Me.lbTipsFee, "lbTipsFee")
        Me.lbTipsFee.ForeColor = System.Drawing.Color.White
        Me.lbTipsFee.Name = "lbTipsFee"
        '
        'pbTipFee
        '
        Me.pbTipFee.AccessibleDescription = Nothing
        Me.pbTipFee.AccessibleName = Nothing
        resources.ApplyResources(Me.pbTipFee, "pbTipFee")
        Me.pbTipFee.BackgroundImage = Nothing
        Me.pbTipFee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbTipFee.Font = Nothing
        Me.pbTipFee.ImageLocation = Nothing
        Me.pbTipFee.Name = "pbTipFee"
        Me.pbTipFee.TabStop = False
        '
        'rbTipComY
        '
        Me.rbTipComY.AccessibleDescription = Nothing
        Me.rbTipComY.AccessibleName = Nothing
        resources.ApplyResources(Me.rbTipComY, "rbTipComY")
        Me.rbTipComY.BackgroundImage = Nothing
        Me.rbTipComY.Checked = True
        Me.rbTipComY.Name = "rbTipComY"
        Me.rbTipComY.TabStop = True
        '
        'rbTipComN
        '
        Me.rbTipComN.AccessibleDescription = Nothing
        Me.rbTipComN.AccessibleName = Nothing
        resources.ApplyResources(Me.rbTipComN, "rbTipComN")
        Me.rbTipComN.BackgroundImage = Nothing
        Me.rbTipComN.Name = "rbTipComN"
        '
        'lbPayTips
        '
        Me.lbPayTips.AccessibleDescription = Nothing
        Me.lbPayTips.AccessibleName = Nothing
        resources.ApplyResources(Me.lbPayTips, "lbPayTips")
        Me.lbPayTips.ForeColor = System.Drawing.Color.White
        Me.lbPayTips.Name = "lbPayTips"
        '
        'pbTipsPayCom
        '
        Me.pbTipsPayCom.AccessibleDescription = Nothing
        Me.pbTipsPayCom.AccessibleName = Nothing
        resources.ApplyResources(Me.pbTipsPayCom, "pbTipsPayCom")
        Me.pbTipsPayCom.BackgroundImage = Nothing
        Me.pbTipsPayCom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbTipsPayCom.Font = Nothing
        Me.pbTipsPayCom.ImageLocation = Nothing
        Me.pbTipsPayCom.Name = "pbTipsPayCom"
        Me.pbTipsPayCom.TabStop = False
        '
        'Panel14
        '
        Me.Panel14.AccessibleDescription = Nothing
        Me.Panel14.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel14, "Panel14")
        Me.Panel14.BackgroundImage = Nothing
        Me.Panel14.Controls.Add(Me.btnBands)
        Me.Panel14.Controls.Add(Me.lbBands)
        Me.Panel14.Font = Nothing
        Me.Panel14.Name = "Panel14"
        '
        'Panel15
        '
        Me.Panel15.AccessibleDescription = Nothing
        Me.Panel15.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel15, "Panel15")
        Me.Panel15.BackgroundImage = Nothing
        Me.Panel15.Controls.Add(Me.btnHelp)
        Me.Panel15.Controls.Add(Me.lbHelp)
        Me.Panel15.Font = Nothing
        Me.Panel15.Name = "Panel15"
        '
        'Panel16
        '
        Me.Panel16.AccessibleDescription = Nothing
        Me.Panel16.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel16, "Panel16")
        Me.Panel16.BackgroundImage = Nothing
        Me.Panel16.Controls.Add(Me.btnSave)
        Me.Panel16.Controls.Add(Me.lbSave)
        Me.Panel16.Font = Nothing
        Me.Panel16.Name = "Panel16"
        '
        'Panel17
        '
        Me.Panel17.AccessibleDescription = Nothing
        Me.Panel17.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel17, "Panel17")
        Me.Panel17.BackgroundImage = Nothing
        Me.Panel17.Controls.Add(Me.btnExit)
        Me.Panel17.Controls.Add(Me.lbExit)
        Me.Panel17.Font = Nothing
        Me.Panel17.Name = "Panel17"
        '
        'fMain
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.Panel17)
        Me.Controls.Add(Me.Panel16)
        Me.Controls.Add(Me.Panel15)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.gbClient)
        Me.Controls.Add(Me.gbTips)
        Me.Controls.Add(Me.pbTipsProcessing)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.lbTipsProcessing)
        Me.Controls.Add(Me.pbStockCost)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.lbRemoveCostProd)
        Me.Controls.Add(Me.pbSunComm)
        Me.Controls.Add(Me.pbHelpTax)
        Me.Controls.Add(Me.pbHelpPeriod)
        Me.Controls.Add(Me.pbBandType)
        Me.Controls.Add(Me.pbWage)
        Me.Controls.Add(Me.pbServiceFee)
        Me.Controls.Add(Me.pbSplit)
        Me.Controls.Add(Me.pbCost)
        Me.Controls.Add(Me.pbFall)
        Me.Controls.Add(Me.PBpAYsERVICE)
        Me.Controls.Add(Me.pbRecComm)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.lbPayServiceSales)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.lbMoney)
        Me.Controls.Add(Me.lbPercent)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbRetailComm)
        Me.Controls.Add(Me.lbWageSchedule)
        Me.Controls.Add(Me.lbReceptionist)
        Me.Controls.Add(Me.tbSplitRecep)
        Me.Controls.Add(Me.tbSplitStyle)
        Me.Controls.Add(Me.tbServiceTaken)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lbStylist)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lbRetailSplit)
        Me.Controls.Add(Me.lbFallBackWage)
        Me.Controls.Add(Me.lbSetFeeBill)
        Me.Controls.Add(Me.lbRemoveCostService)
        Me.Controls.Add(Me.gbRefChem)
        Me.Controls.Add(Me.lbAdditionalType)
        Me.Controls.Add(Me.lbBandingType)
        Me.Controls.Add(Me.lbCalcPeriod)
        Me.Controls.Add(Me.lbTax)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "fMain"
        CType(Me.pbRefChem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRefChem.ResumeLayout(False)
        Me.gbClient.ResumeLayout(False)
        CType(Me.pbClientTar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        CType(Me.pbRecComm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBands, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBpAYsERVICE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSplit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbServiceFee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbWage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBandType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHelpPeriod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHelpTax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSunComm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStockCost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        CType(Me.pbTipsProcessing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.gbTips.ResumeLayout(False)
        Me.gbTips.PerformLayout()
        CType(Me.pbTipFee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTipsPayCom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


#Region " Check/Text Change "
    Private Sub ChageMade()
        bHasChange = True
        Me.btnSave.Enabled = True
    End Sub

    Private Sub rbCostStockN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCostStockN.CheckedChanged
        'Enable save button if form is not loading
        If bIsLoad = False Then
            ChageMade()
        End If
    End Sub

    Private Sub rbCostStockY_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCostStockY.CheckedChanged
        'Enable save button if form is not loading
        If bIsLoad = False Then
            ChageMade()
        End If
    End Sub

    Private Sub tbTipFee_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbTipFee.TextChanged
        'Enable save button if form is not loading
        If bIsLoad = False Then
            ChageMade()
        End If

        If tbTipFee.Text.Trim(" ") <> "" And tbTipFee.Text.Length > 0 Then
            Try
                Dim i As Integer = Me.tbTipFee.Text
                If i > 100 Then

                    Dim msgbox As New fMsgBox(0, "Error", "There was an error, please enter a number between 0 and 100")
                    msgbox.ShowDialog()

                    tbTipFee.Text = 0

                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub rbTypeRef_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTypeRef.CheckedChanged
        iSunSelect = 3

        If rbTypeRef.Checked = True Then
            gbRefChem.Visible = True
        Else
            gbRefChem.Visible = False
        End If

        'Enable save button if form is not loading
        If bIsLoad = False Then
            Me.ChageMade()
        End If
    End Sub


    Private Sub tbSplitStyle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSplitStyle.TextChanged


        If tbSplitStyle.Text.Trim(" ") <> "" And tbSplitStyle.Text.Length > 0 Then
            Try
                Dim i As Integer = Me.tbSplitStyle.Text
                If i > 100 Then
                    Dim msgbox As New fMsgBox(0, "Error", "There was an error, please enter a number between 0 and 100")
                    msgbox.ShowDialog()
                    tbSplitStyle.Text = 100
                End If
                tbSplitRecep.Text = 100 - Me.tbSplitStyle.Text

            Catch ex As Exception
                Dim msgbox As New fMsgBox(0, "Error", "There was an error, please enter a number between 0 and 100")
                msgbox.ShowDialog()
                tbSplitStyle.Text = 100
            End Try
        End If


        'Enable save button if form is not loading
        If bIsLoad = False Then
            Me.ChageMade()
        End If
    End Sub


    Private Sub rbRetailLine_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRetailLine.CheckedChanged

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        If rbRetailLine.Checked = True And bIsLoad = False Then 'need to make sure its not loading or else will start on load
            Dim form As New fLines
            form.ShowDialog()
        End If

        'Enable save button if form is not loading
        If bIsLoad = False Then
            Me.ChageMade()
        End If

        Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub



    Private Sub rbTypeClienC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTypeClienC.CheckedChanged

        iSunSelect = 4
        If rbTypeClienC.Checked = True Then
            Me.gbClient.Visible = True
        Else
            Me.gbClient.Visible = False
        End If

        'Enable save button if form is not loading
        If bIsLoad = False Then
            Me.ChageMade()
        End If
    End Sub

    Private Sub rbTypeSun_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTypeSun.CheckedChanged
        iSunSelect = 1
        'Enable save button if form is not loading
        If bIsLoad = False Then
            ChageMade()
        End If
    End Sub

    Private Sub rbTypeChem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTypeChem.CheckedChanged
        iSunSelect = 2
        'Enable save button if form is not loading
        If bIsLoad = False Then
            ChageMade()
        End If
    End Sub


    Private Sub rbCostN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCostN.CheckedChanged

        'Enable save button if form is not loading
        If bIsLoad = False Then
            ChageMade()
        End If
    End Sub

    Private Sub rbCostY_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCostY.CheckedChanged
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        'need to make sure its not loading or else will start on load
        If rbCostY.Checked = True And bIsLoad = False Then
            Dim form As New fServiceCost(sCurrency)

            form.ShowDialog(Me)
        End If

        'Enable save button if form is not loading
        If bIsLoad = False Then
            ChageMade()
        End If

        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub rbFallN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFallN.CheckedChanged

        'Enable save button if form is not loading
        If bIsLoad = False And rbFallN.Checked = True Then

            Dim msgboxYN As New fMsgBoxYN("Wage Settings", "Are you sure you want to set all members of staff to calculate using Wage + Commission?")
            msgboxYN.ShowDialog()


            If msgboxYN.DialogResult = DialogResult.Yes Then
                'Update Database
                SDA.strSqlSP = "dbo.usp_BIComReportWage"
                SDA.AddParam("@StructureID", 0, SqlDbType.Int) 'not used
                SDA.AddParam("@Value", True, SqlDbType.Bit) 'not used
                SDA.AddParam("@Type", 2, SqlDbType.Int)
                SDA.SqlExecute()

                ChageMade()
            Else
                'Need to cheat to stop pop-up screen event firing
                'to do this use the isload flag
                bIsLoad = True
                Me.rbFallY.Checked = True
                bIsLoad = False
            End If

        End If
    End Sub

    Private Sub rbFallY_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFallY.CheckedChanged
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        'Enable save button if form is not loading
        If rbFallY.Checked = True And bIsLoad = False Then
            Dim fWage As New fWageOption
            fWage.ShowDialog()

            ChageMade()
        End If

        Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub rbRetailBand_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        '##Taken out for version 2.0##
        '## Flat % ##

        ''Enable save button if form is not loading
        'If bIsLoad = False Then
        '    ChageMade()
        'End If
    End Sub


    Private Sub rbTaxExclude_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTaxExclude.CheckedChanged
        'Enable save button if form is not loading
        If bIsLoad = False Then
            ChageMade()
        End If
    End Sub

    Private Sub rbTaxInclude_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTaxInclude.CheckedChanged
        'Enable save False if form is not loading
        If bIsLoad = False Then
            ChageMade()
        End If
    End Sub

    Private Sub rbPeriodWeekly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPeriodWeekly.CheckedChanged
        'Enable save button if form is not loading
        If bIsLoad = False Then
            ChageMade()
        End If
    End Sub

    Private Sub rbPeriodPay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPeriodPay.CheckedChanged
        'Enable save button if form is not loading
        If bIsLoad = False Then
            ChageMade()
        End If
    End Sub

    Private Sub rbBandCum_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbBandCum.CheckedChanged
        'Enable save button if form is not loading
        If bIsLoad = False Then
            ChageMade()
        End If
    End Sub

    Private Sub rbBandTarget_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbBandTarget.CheckedChanged
        'Enable save button if form is not loading
        If bIsLoad = False Then
            ChageMade()
        End If
    End Sub

    Private Sub rbRefN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRefN.CheckedChanged
        'Enable save button if form is not loading
        If bIsLoad = False Then
            ChageMade()
        End If
    End Sub

    Private Sub rbRefY_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRefY.CheckedChanged
        'Enable save button if form is not loading
        If bIsLoad = False Then
            ChageMade()
        End If
    End Sub


    Private Sub rbGoalNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbGoalNo.CheckedChanged
        'Enable save button if form is not loading
        If bIsLoad = False Then
            ChageMade()
        End If

    End Sub

    Private Sub rbGoalY_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbGoalY.CheckedChanged
        'Enable save button if form is not loading
        If bIsLoad = False Then
            ChageMade()
        End If
    End Sub

    Private Sub rbWageLog_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbWageLog.CheckedChanged
        'Enable save button if form is not loading
        If bIsLoad = False Then
            ChageMade()
        End If
    End Sub

    Private Sub rbWageRos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbWageRos.CheckedChanged
        'Enable save button if form is not loading
        If bIsLoad = False Then
            ChageMade()
        End If
    End Sub

    Private Sub tbServiceTaken_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbServiceTaken.TextChanged
        'Enable save button if form is not loading
        If bIsLoad = False Then
            ChageMade()
        End If

        SetGlobalFigs()

    End Sub


    Private Sub rbPercent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPercent.CheckedChanged
        'Enable save button if form is not loading
        If bIsLoad = False Then
            ChageMade()
        End If

        SetGlobalFigs()
    End Sub

    Private Sub rbMoney_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMoney.CheckedChanged
        'Enable save button if form is not loading
        If bIsLoad = False Then
            ChageMade()
        End If

        SetGlobalFigs()
    End Sub


    Private Sub rbPayServiceN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPayServiceN.CheckedChanged
        'Enable save button if form is not loading
        If bIsLoad = False Then
            ChageMade()
        End If
    End Sub

    Private Sub rbPayServiceY_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPayServiceY.CheckedChanged
        'Enable save button if form is not loading
        If bIsLoad = False Then
            ChageMade()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbIncludeTips.CheckedChanged
        Me.gbTips.Visible = True

        'Enable save button if form is not loading
        If bIsLoad = False Then
            Me.ChageMade()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbExcludeTips.CheckedChanged
        Me.gbTips.Visible = False
        tbTipFee.Text = 0 'reset just incase

        'Enable save button if form is not loading
        If bIsLoad = False Then
            Me.ChageMade()
        End If
    End Sub


    Private Sub rbTipComN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTipComN.CheckedChanged
        'Enable save button if form is not loading
        If bIsLoad = False Then
            Me.ChageMade()
        End If
    End Sub

    Private Sub rbTipComY_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTipComY.CheckedChanged
        'Enable save button if form is not loading
        If bIsLoad = False Then
            Me.ChageMade()
        End If
    End Sub

#End Region


#Region " Mouse Move "
    'Private Sub fMain_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter


    '    'Bad programming but stops the strange pop-up isse on drag
    '    'Temp until have better fix
    '    If Me.btnHelp.BorderStyle <> BorderStyle.None Then
    '        Me.btnHelp.BorderStyle = BorderStyle.None
    '        Me.Focus()
    '    End If
    '    If Me.btnBands.BorderStyle <> BorderStyle.None Then
    '        Me.btnBands.BorderStyle = BorderStyle.None
    '        Me.Focus()
    '    End If
    '    If Me.btnSave.BorderStyle <> BorderStyle.None Then
    '        Me.btnSave.BorderStyle = BorderStyle.None
    '        Me.Focus()
    '    End If
    '    If Me.btnExit.BorderStyle <> BorderStyle.None Then
    '        Me.btnExit.BorderStyle = BorderStyle.None
    '        Me.Focus()
    '    End If

    'End Sub

    Private Sub btnBands_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnBands.MouseMove
        ' Me.btnBands.BorderStyle = BorderStyle.Fixed3D
    End Sub



    Private Sub btnSave_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSave.MouseMove
        '     Me.btnSave.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub btnHelp_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnHelp.MouseMove
        '     Me.btnHelp.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub btnExit_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnExit.MouseMove
        '   Me.btnExit.BorderStyle = BorderStyle.Fixed3D
    End Sub








#End Region


#Region " Help Buttons "
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRecComm.Click
        Dim form As New fHelp("Select 'Lines' to pay different commission rates for different product lines" & vbNewLine & vbNewLine _
             & "Select 'Bands' to pay retail commission based on the various retail percentages but using the same takings bands that are used for Service")
        form.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBpAYsERVICE.Click
        Dim form As New fHelp("Credit staff for series sales at the individual treatment price")
        form.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbFall.Click
        Dim form As New fHelp("Wage + Comm – This option will set all employees to get their wage and all of their commissions" & vbNewLine & vbNewLine & "Variable – within the pop-up screen you can customize which commission structures get their wage + commission or alternatively wage OR commission (which ever is greater)")
        form.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click_4(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbCost.Click
        Dim form As New fHelp("Select ‘Yes’ to remove a variable 'service cost' for each job before commissions are calculated. Enter the cost of the individual service in the pop-up screen")
        form.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click_5(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbSplit.Click
        Dim form As New fHelp("Split the retail commissions between the specific stylist and the receptionist who processed the bill")
        form.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbServiceFee.Click
        Dim form As New fHelp("This is a fixed amount per bill, which is removed from the takings before commission is calculated")
        form.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbWage.Click
        Dim form As New fHelp("Tick logged hours if using the Shortcuts log-on/log-off system otherwise the Roster times will be used")
        form.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbBandType.Click
        Dim form As New fHelp("Cumulative means commissions are calulated for each band and then added together" & vbNewLine & vbNewLine & "Target means a single commission is paid based on the highest band achieved (the 'target')")
        form.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click_4(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbHelpPeriod.Click
        Dim form As New fHelp("The period of time for which the commission is calculated (may be less than the pay period)" & vbNewLine _
               & vbNewLine & "e.g. staff can be paid for a 4 week total but commission can be calculated weekly" & vbNewLine & vbNewLine & "NOTE - if you are displaying one day the 'Same as Report Period' option needs to be selected")
        form.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click_5(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbHelpTax.Click
        Dim form As New fHelp("Use this option to include or exclude tax on the report")
        form.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click_6(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbSunComm.Click
        Dim form As New fHelp("Sundry: Miscelaneous items such as vouchers" & vbNewLine & vbNewLine _
        & "Chemical: Colors and Perms etc ('Need Visit Details' ticked in Shortcuts)" & vbNewLine & vbNewLine _
        & "Referal: For example: work done by a technican for which the stylist also gets commission" & vbNewLine & vbNewLine _
        & "Client Count: % Service commission is based on the number of clients processd (enter target client counts using 'Bands' button)")
        form.ShowDialog()
    End Sub

    Private Sub pbStockCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbStockCost.Click
        Dim form As New fHelp("Select ‘Yes’ to remove the purchase cost of retail items used before commissions are calculated" & vbNewLine & vbNewLine & "For example, if a retail product is purchased for " & sCurrency & "4 and sold for " & sCurrency & "10, then the commission will be on the difference i.e. " & sCurrency & "6")
        form.ShowDialog()
    End Sub

    Private Sub pbRefChem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRefChem.Click
        Dim form As New fHelp("Referals only valid for 'Chemical' Services" & vbNewLine & "('Need Visit Details' ticked in Shortcuts)")
        form.ShowDialog()
    End Sub

    Private Sub pbClientTar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbClientTar.Click
        Dim form As New fHelp("When using client counts for commission, only count Request Clients")
        form.ShowDialog()
    End Sub

    Private Sub pbTipFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTipFee.Click
        Dim form As New fHelp("Remove a set percentage from the final tips total, for example for tax purposes")
        form.ShowDialog()
    End Sub

    Private Sub pbTipsPayCom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTipsPayCom.Click
        Dim form As New fHelp("Select ‘Yes’ if you wish to pay commission on employee tips. If you choose ‘No’ tips will be displayed on the report but will not be factored into any commission calculations")
        form.ShowDialog()
    End Sub

    Private Sub pbTipsProcessing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTipsProcessing.Click
        Dim form As New fHelp("Exclude Tips – This will ignore all tips within the report" & vbNewLine & vbNewLine & _
        "Include Tips – This will factor tips calculations into the report")
        form.ShowDialog()
    End Sub



#End Region


#Region " Load Keys for Settings"

    Public Sub LoadKeys()
        'Populate Keys
        'TAX
        SDA.strSqlSP = "dbo.usp_BIComReportProcessSettings"
        SDA.AddParam("@Key", "Tax", SqlDbType.Text)
        SDA.AddParam("@Value", 0, SqlDbType.Int)
        SDA.AddParam("@Type", 0, SqlDbType.Int)
        SDA.SqlGetDataSingleRow()

        If SDA.SqlSingleRow(0) = 1 Then
            rbTaxExclude.Checked = True
        Else
            rbTaxInclude.Checked = True
        End If

        'Commission Calculation Period
        SDA.strSqlSP = "dbo.usp_BIComReportProcessSettings"
        SDA.AddParam("@Key", "Period", SqlDbType.Text)
        SDA.AddParam("@Value", 0, SqlDbType.Int)
        SDA.AddParam("@Type", 0, SqlDbType.Int)
        SDA.SqlGetDataSingleRow()

        If SDA.SqlSingleRow(0) = 1 Then
            rbPeriodWeekly.Checked = True
        Else
            rbPeriodPay.Checked = True
        End If

        'Banding Type
        SDA.strSqlSP = "dbo.usp_BIComReportProcessSettings"
        SDA.AddParam("@Key", "Type", SqlDbType.Text)
        SDA.AddParam("@Value", 0, SqlDbType.Int)
        SDA.AddParam("@Type", 0, SqlDbType.Int)
        SDA.SqlGetDataSingleRow()

        If SDA.SqlSingleRow(0) = 1 Then
            rbBandCum.Checked = True
        Else
            rbBandTarget.Checked = True
        End If

        'Sundry Commission Type
        SDA.strSqlSP = "dbo.usp_BIComReportProcessSettings"
        SDA.AddParam("@Key", "Sundry", SqlDbType.Text)
        SDA.AddParam("@Value", 0, SqlDbType.Int)
        SDA.AddParam("@Type", 0, SqlDbType.Int)
        SDA.SqlGetDataSingleRow()

        If SDA.SqlSingleRow(0) = 1 Then
            rbTypeSun.Checked = True
        ElseIf SDA.SqlSingleRow(0) = 2 Then
            rbTypeChem.Checked = True
        ElseIf SDA.SqlSingleRow(0) = 3 Then
            rbTypeRef.Checked = True
        ElseIf SDA.SqlSingleRow(0) = 4 Then
            rbTypeClienC.Checked = True
        End If

        'Ref Chem Only
        SDA.strSqlSP = "dbo.usp_BIComReportProcessSettings"
        SDA.AddParam("@Key", "Ref", SqlDbType.Text)
        SDA.AddParam("@Value", 0, SqlDbType.Int)
        SDA.AddParam("@Type", 0, SqlDbType.Int)
        SDA.SqlGetDataSingleRow()

        If SDA.SqlSingleRow(0) = 1 Then
            rbRefY.Checked = True
        Else
            rbRefN.Checked = True
        End If

        'Remove The Cost of a Service
        SDA.strSqlSP = "dbo.usp_BIComReportProcessSettings"
        SDA.AddParam("@Key", "ServiceCost", SqlDbType.Text)
        SDA.AddParam("@Value", 0, SqlDbType.Int)
        SDA.AddParam("@Type", 0, SqlDbType.Int)
        SDA.SqlGetDataSingleRow()

        If SDA.SqlSingleRow(0) = 1 Then
            rbCostY.Checked = True
        Else
            rbCostN.Checked = True
        End If

        'Fall Back Wage
        SDA.strSqlSP = "dbo.usp_BIComReportProcessSettings"
        SDA.AddParam("@Key", "Wage", SqlDbType.Text)
        SDA.AddParam("@Value", 0, SqlDbType.Int)
        SDA.AddParam("@Type", 0, SqlDbType.Int)
        SDA.SqlGetDataSingleRow()

        If SDA.SqlSingleRow(0) = 1 Then
            rbFallY.Checked = True
        Else
            rbFallN.Checked = True
        End If



        'Wage Schedule
        SDA.strSqlSP = "dbo.usp_BIComReportProcessSettings"
        SDA.AddParam("@Key", "Logged", SqlDbType.Text)
        SDA.AddParam("@Value", 0, SqlDbType.Int)
        SDA.AddParam("@Type", 0, SqlDbType.Int)
        SDA.SqlGetDataSingleRow()

        If SDA.SqlSingleRow(0) = 1 Then
            rbWageLog.Checked = True
        Else
            rbWageRos.Checked = True
        End If

        'Client Count Commission
        SDA.strSqlSP = "dbo.usp_BIComReportProcessSettings"
        SDA.AddParam("@Key", "Count", SqlDbType.Text)
        SDA.AddParam("@Value", 0, SqlDbType.Int)
        SDA.AddParam("@Type", 0, SqlDbType.Int)
        SDA.SqlGetDataSingleRow()

        If SDA.SqlSingleRow(0) = 1 Then
            rbGoalY.Checked = True
        Else
            rbGoalNo.Checked = True
        End If

        'Set Fee Per Bill Type (% or $)
        SDA.strSqlSP = "dbo.usp_BIComReportProcessSettings"
        SDA.AddParam("@Key", "BillFeePerOrMon", SqlDbType.Text)
        SDA.AddParam("@Value", 0, SqlDbType.Int)
        SDA.AddParam("@Type", 0, SqlDbType.Int)
        SDA.SqlGetDataSingleRow()

        If SDA.SqlSingleRow(0) = 0 Then
            rbPercent.Checked = True
        Else
            rbMoney.Checked = True
        End If


        'Set Fee Per Bill
        SDA.strSqlSP = "dbo.usp_BIComReportProcessSettings"
        SDA.AddParam("@Key", "BillFee", SqlDbType.Text)
        SDA.AddParam("@Value", 0, SqlDbType.Int)
        SDA.AddParam("@Type", 0, SqlDbType.Int)
        SDA.SqlGetDataSingleRow()

        tbServiceTaken.Text = SDA.SqlSingleRow(0)


        'Commission Split
        SDA.strSqlSP = "dbo.usp_BIComReportProcessSettings"
        SDA.AddParam("@Key", "Split", SqlDbType.Text)
        SDA.AddParam("@Value", 0, SqlDbType.Int)
        SDA.AddParam("@Type", 0, SqlDbType.Int)
        SDA.SqlGetDataSingleRow()

        tbSplitStyle.Text = SDA.SqlSingleRow(0)


        'Retail Commissions
        SDA.strSqlSP = "dbo.usp_BIComReportProcessSettings"
        SDA.AddParam("@Key", "Retail", SqlDbType.Text)
        SDA.AddParam("@Value", 0, SqlDbType.Int)
        SDA.AddParam("@Type", 0, SqlDbType.Int)
        SDA.SqlGetDataSingleRow()

        '##Removed tickbox for version 2 ##
        'If SDA.iReturn = 0 Then
        ' rbRetailBand.Checked = True
        'Else
        If SDA.SqlSingleRow(0) = 1 Then
            rbRetailLine.Checked = True
        ElseIf SDA.SqlSingleRow(0) = 2 Then
            rbSerBand.Checked = True
        End If

        'Need below as events would have already fired to set these the other way
        Me.btnSave.Enabled = False
        Me.bHasChange = False

        'Pay Service Sales
        SDA.strSqlSP = "dbo.usp_BIComReportProcessSettings"
        SDA.AddParam("@Key", "PaySeriesFull", SqlDbType.Text)
        SDA.AddParam("@Value", 0, SqlDbType.Int)
        SDA.AddParam("@Type", 0, SqlDbType.Int)
        SDA.SqlGetDataSingleRow()

        If SDA.SqlSingleRow(0) = 0 Then
            rbPayServiceN.Checked = True
        Else
            rbPayServiceY.Checked = True
        End If


        'Remove cost of Stock
        SDA.strSqlSP = "dbo.usp_BIComReportProcessSettings"
        SDA.AddParam("@Key", "StockCost", SqlDbType.Text)
        SDA.AddParam("@Value", 0, SqlDbType.Int)
        SDA.AddParam("@Type", 0, SqlDbType.Int)
        SDA.SqlGetDataSingleRow()

        If SDA.SqlSingleRow(0) = 0 Then
            rbCostStockN.Checked = True
        Else
            rbCostStockY.Checked = True
        End If


        'Tips Options
        SDA.strSqlSP = "dbo.usp_BIComReportProcessSettings"
        SDA.AddParam("@Key", "Tips", SqlDbType.Text)
        SDA.AddParam("@Value", 0, SqlDbType.Int)
        SDA.AddParam("@Type", 0, SqlDbType.Int)
        SDA.SqlGetDataSingleRow()

        If SDA.SqlSingleRow(0) = 0 Then
            rbExcludeTips.Checked = True
        ElseIf (SDA.SqlSingleRow(0) = 1) Then
            rbIncludeTips.Checked = True
            rbTipComY.Checked = True
        ElseIf (SDA.SqlSingleRow(0) = 2) Then
            rbCostStockY.Checked = True
            rbIncludeTips.Checked = True
            rbTipComN.Checked = True
        End If


        'Tips Fee
        SDA.strSqlSP = "dbo.usp_BIComReportProcessSettings"
        SDA.AddParam("@Key", "TipFee", SqlDbType.Text)
        SDA.AddParam("@Value", 0, SqlDbType.Int)
        SDA.AddParam("@Type", 0, SqlDbType.Int)
        SDA.SqlGetDataSingleRow()

        tbTipFee.Text = SDA.SqlSingleRow(0)

    End Sub

#End Region


    Private Sub miExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If bHasChange = True Then


            Dim msgboxYN As New fMsgBoxYN("Exit", "There has been changes made, are you sure you want to exit without saving?")
            msgboxYN.ShowDialog()
            If msgboxYN.DialogResult = DialogResult.Yes Then
                ExitProg()
            End If
        Else
            ExitProg()
        End If
    End Sub

    Private Sub ExitProg()

        If bChangesMade = False Then
            If bFX = True Then
                FadeOut(Me)
            Else
                Me.Close()
            End If

            Application.Exit()
        Else

            Dim msgboxYN As New fMsgBoxYN("Exit", "There has been changes made, are you sure you want to exit without saving?")
            msgboxYN.ShowDialog()
            If msgboxYN.DialogResult = DialogResult.Yes Then
                If bFX = True Then
                    FadeOut(Me)
                Else
                    Me.Close()
                End If
                Application.Exit()
            End If
        End If
    End Sub



    Private Sub fMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'Set loading flag
        bIsLoad = True

        'Set version to display
        Me.Text = Me.Text + " - " + sVersion

        'Set currency
        Me.rbMoney.Text = sCurrency
        Me.lbMoney.Text = sCurrency

        'Retrieve all settings from the database
        LoadKeys()

        '#####  NEEDS TO BE AT THE END  #######
        'Turn off fade effect for slow performance machines
        SDA.strSqlSP = "dbo.usp_BIComReportProcessSettings"
        SDA.AddParam("@Key", "FX", SqlDbType.Text)
        SDA.AddParam("@Value", 0, SqlDbType.Int)
        SDA.AddParam("@Type", 0, SqlDbType.Int)
        SDA.SqlGetDataSingleRow()

        If SDA.SqlSingleRow(0) = 1 Then
            bFX = True
            'show form
            FadeIn(Me)
        Else
            bFX = False
        End If


        'Load Complete, set flag
        bIsLoad = False

        Me.tbServiceTaken.Select(0, 0)

        'Need to kill off if there is an error,
        'does not totally remove from memory - needs fixing
        'If bError = True Then
        '    Application.Exit()
        '    MyBase.Dispose()
        '    MyBase.Finalize()
        '    MyBase.Close()
        'End If

    End Sub

    Private Sub fMain_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub


    Private Sub rbRetailLine_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbRetailLine.MouseDown
        If rbRetailLine.Checked = True And bIsLoad = False Then 'need to make sure its not loading or else will start on load
            Dim form As New fLines
            form.ShowDialog()
        End If
    End Sub


    Private Sub SetGlobalFigs()
        'Set correct lable
        If rbPercent.Checked = True Then
            Me.lbPercent.Visible = True
            Me.lbMoney.Visible = False
        Else
            Me.lbMoney.Visible = True
            Me.lbPercent.Visible = False
        End If
    End Sub


    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If bHasChange = True Then

            Dim msgboxYN As New fMsgBoxYN("Exit", "There has been changes made, are you sure you want to exit without saving?")
            msgboxYN.ShowDialog()
            If msgboxYN.DialogResult = DialogResult.Yes Then
                ExitProg()
            End If
        Else
            ExitProg()
        End If
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If CheckInteger(Me) = False Then
            'Need another check as this is in a group box and can not be passed in the normal way
            If CheckIntegerBox(tbTipFee) = False Then 'Put on diff. line so that if both are letters does no pop up twice

                Dim bTempChange As Boolean 'for JB change!
                Dim temp As Integer 'for use below


                'TAX
                SettingWrite("Tax", rbTaxExclude.Checked, 1)

                'Commission Calculation Period
                SettingWrite("Period", rbPeriodWeekly.Checked, 1)

                'Banding Type
                SettingWrite("Type", rbBandCum.Checked, 1)

                'Sundry Commission Type
                If rbTypeSun.Checked = True Then
                    temp = 1
                ElseIf rbTypeChem.Checked = True Then
                    temp = 2
                ElseIf rbTypeRef.Checked = True Then
                    temp = 3
                ElseIf rbTypeClienC.Checked = True Then
                    temp = 4
                End If
                SettingWrite("Sundry", temp, 1)

                'Ref Chem Only
                If rbRefN.Checked = True Then
                    bTempChange = False
                Else
                    bTempChange = True
                End If
                SettingWrite("Ref", bTempChange, 1)

                'Remove The Cost of a Service
                If rbCostN.Checked = True Then
                    bTempChange = False
                Else
                    bTempChange = True
                End If
                SettingWrite("ServiceCost", bTempChange, 1)

                'Fall Back Wage
                If rbFallN.Checked = True Then
                    bTempChange = False
                Else
                    bTempChange = True
                End If
                SettingWrite("Wage", rbFallY.Checked, 1)

                'Wage Schedule
                SettingWrite("Logged", rbWageLog.Checked, 1)

                'Client Count Commission
                If rbGoalNo.Checked = True Then
                    bTempChange = False
                Else
                    bTempChange = True
                End If
                SettingWrite("Count", bTempChange, 1)


                'Set Fee Per Bill
                If tbServiceTaken.Text.Trim(" ") = "" Then    'Error checking
                    tbServiceTaken.Text = 0
                End If
                SettingWrite("BillFee", tbServiceTaken.Text, 1)


                'Set Fee Per Bill % or $
                Dim iTemp As Integer 'May need to add more in the future so is an int not float
                If rbPercent.Checked = True Then
                    iTemp = 0
                Else
                    iTemp = 1
                End If
                SettingWrite("BillFeePerOrMon", iTemp, 1)


                'Tips Fee
                If tbTipFee.Text.Trim(" ") = "" Then 'Error checking
                    tbTipFee.Text = 0
                End If
                SettingWrite("TipFee", tbTipFee.Text, 1)


                'Commission Split
                If tbSplitStyle.Text.Trim(" ") = "" Or tbSplitStyle.Text.Length = 0 Then  'Error check
                    tbSplitStyle.Text = 0
                End If
                SettingWrite("Split", tbSplitStyle.Text, 1)

                'Retail Commissions
                '## removed box for version 1 ##
                ' If rbRetailBand.Checked = True Then
                ' temp = 0
                'Else
                If rbRetailLine.Checked = True Then
                    temp = 1
                ElseIf rbSerBand.Checked = True Then
                    temp = 2
                End If
                SettingWrite("Retail", temp, 1)

                'Pay Service Sales
                SettingWrite("PaySeriesFull", rbPayServiceY.Checked, 1)

                'Stock Cost
                SettingWrite("StockCost", rbCostStockY.Checked, 1)

                'Retail Commissions
                If rbExcludeTips.Checked = True Then
                    temp = 0
                ElseIf (rbIncludeTips.Checked = True) And (rbTipComY.Checked = True) Then
                    temp = 1
                ElseIf (rbIncludeTips.Checked = True) And (rbTipComY.Checked = False) Then
                    temp = 2
                End If
                SettingWrite("Tips", temp, 1)


                '#### MUST BE AT END ######
                bHasChange = False 'as is saved can now exit


                Dim msgbox As New fMsgBox(0, "Saved", "System settings saved")
                msgbox.ShowDialog()

                Me.btnSave.Enabled = False
            End If
        End If
    End Sub

    Public Sub SettingWrite(ByVal Key As String, ByVal Value As Single, ByVal Type As Integer)
        'Needed for version 2 conversion from boolean, ints and floats
        'to floats only
        If Value = -1 Then
            Value = 1
        End If

        SDA.strSqlSP = "dbo.usp_BIComReportProcessSettings"
        SDA.AddParam("@Key", Key, SqlDbType.Text)
        SDA.AddParam("@Value", Value, SqlDbType.Float)
        SDA.AddParam("@Type", Type, SqlDbType.Int)
        SDA.SqlExecute()
    End Sub

    Private Sub btnBands_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBands.Click
        Dim form As New fBands(sCurrency)
        form.ShowDialog()
    End Sub


    Private Sub rbCostY_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbCostY.MouseDown

        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        'need to make sure its not loading or else will start on load
        If rbCostY.Checked = True And bIsLoad = False Then
            Dim form As New fServiceCost(sCurrency)
            form.ShowDialog()
        End If
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub btnBands_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBands.MouseEnter
        If bRunningBand = False Then
            bRunningBand = True
            Dim th As New Thread(AddressOf BandThread)
            th.Start()
            bRunningBand = False
        End If
    End Sub

    Private Sub btnHelp_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHelp.MouseEnter
        If bRunningHelp = False Then
            bRunningHelp = True
            Dim th As New Thread(AddressOf HelpThread)
            th.Start()
            bRunningHelp = False
        End If
    End Sub


    Private Sub btnSave_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.MouseEnter
        If bRunningSave = False And Me.btnSave.Enabled = True Then
            bRunningSave = True
            Dim th As New Thread(AddressOf SaveThread)
            th.Start()
            bRunningSave = False
        End If
    End Sub

    Private Sub btnExit_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.MouseEnter
        If bRunningExit = False = True Then
            bRunningExit = True
            Dim th As New Thread(AddressOf ExitThread)
            th.Start()
            bRunningExit = False
        End If
    End Sub

    Private Sub BandThread()
        Animate(Me.btnBands)
    End Sub

    Private Sub HelpThread()
        Animate(Me.btnHelp)
    End Sub

    Private Sub SaveThread()
        Animate(Me.btnSave)
    End Sub

    Private Sub ExitThread()
        Animate(Me.btnExit)
    End Sub

    Private Delegate Sub AnimateDelegate(ByVal ctrl As Control)

    Private Sub Animate(ByVal ctrl As Control)
        If Me.InvokeRequired Then
            Dim delegate1 As New AnimateDelegate(AddressOf Animate)
            Dim parameters(0) As Object
            parameters(0) = ctrl
            Me.Invoke(delegate1, parameters)
        Else
            ctrl.Location = New System.Drawing.Point(2, 6)
            Thread.Sleep(200)
            ctrl.Location = New System.Drawing.Point(4, 4)
            Thread.Sleep(200)
            ctrl.Location = New System.Drawing.Point(6, 6)
            Thread.Sleep(200)
            ctrl.Location = New System.Drawing.Point(4, 4)
        End If
    End Sub


    'Private Sub HelpAnimate()
    '    bRunningHelp = True
    '    Me.btnHelp.Location = New System.Drawing.Point(2, 6)
    '    Thread.Sleep(200)
    '    Me.btnHelp.Location = New System.Drawing.Point(4, 4)
    '    Thread.Sleep(200)
    '    Me.btnHelp.Location = New System.Drawing.Point(6, 6)
    '    Thread.Sleep(200)
    '    Me.btnHelp.Location = New System.Drawing.Point(4, 4)
    '    bRunningHelp = False
    'End Sub

    'Private Sub SaveAnimate()
    '    bRunningSave = True
    '    Me.btnSave.Location = New System.Drawing.Point(2, 6)
    '    Thread.Sleep(200)
    '    Me.btnSave.Location = New System.Drawing.Point(4, 4)
    '    Thread.Sleep(200)
    '    Me.btnSave.Location = New System.Drawing.Point(6, 6)
    '    Thread.Sleep(200)
    '    Me.btnSave.Location = New System.Drawing.Point(4, 4)
    '    bRunningSave = False
    'End Sub

    'Private Sub ExitAnimate()
    '    bRunningExit = True
    '    Me.btnExit.Location = New System.Drawing.Point(2, 6)
    '    Thread.Sleep(200)
    '    Me.btnExit.Location = New System.Drawing.Point(4, 4)
    '    Thread.Sleep(200)
    '    Me.btnExit.Location = New System.Drawing.Point(6, 6)
    '    Thread.Sleep(200)
    '    Me.btnExit.Location = New System.Drawing.Point(4, 4)
    '    bRunningExit = False
    'End Sub


    Private Sub rbFallY_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbFallY.MouseDown
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        If rbFallY.Checked = True And bIsLoad = False Then 'need to make sure its not loading or else will start on load
            Dim form As New fWageOption
            form.ShowDialog()
        End If

        Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Dim form As New fHelpMenu
        form.ShowDialog()

        If form.DialogResult = DialogResult.Yes Then 'reload if defaults set
            bIsLoad = True 'to stop popups
            LoadKeys()
            bIsLoad = False
        ElseIf form.DialogResult = DialogResult.No Then
            ChageMade()

            ''Dont write below, just prompt them to save as above
            ''can change in the future though
            'Dim temp As Integer
            'If bFX = True Then
            '    temp = 1
            'Else
            '    temp = 0
            'End If
            'SettingWrite("FX", temp, 1)
        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)
        bRunningSave = True
        Me.btnSave.Location = New System.Drawing.Point(2, 6)
        Thread.Sleep(200)
        Me.btnSave.Location = New System.Drawing.Point(4, 4)
        Thread.Sleep(200)
        Me.btnSave.Location = New System.Drawing.Point(6, 6)
        Thread.Sleep(200)
        Me.btnSave.Location = New System.Drawing.Point(4, 4)
        bRunningSave = False

    End Sub





    '' prototype for the delegate 
    'Private Delegate Sub AddControlToFormDelegate(ByVal ctrl As Control)

    'Private Sub AddControlToForm(ByVal ctrl As Control)
    '    'Add string control ctrl to form me

    '    'InvokeRequired lets us know if we are in the wrong thread to
    '    'access form Me
    '    If Me.InvokeRequired Then
    '        ' make a delegate that will fire this sub again
    '        Dim delegate1 As New AddControlToFormDelegate(AddressOf _
    '    AddControlToForm)
    '        ' hold the parameters - the control being sent
    '        Dim parameters(0) As Object
    '        parameters(0) = ctrl
    '        'Ask form me to call this sub using the delegate with the parameters.
    '        Me.Invoke(delegate1, parameters)
    '        'it will call from the correct thread
    '    Else
    '        'InvokeRequired lets us know we are in the correct thread
    '        'so we can use listview1.add safely
    '        Me.Controls.Add(ctrl)
    '    End If









End Class
