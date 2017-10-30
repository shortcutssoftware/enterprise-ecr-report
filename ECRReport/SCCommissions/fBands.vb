Public Class fBands
    Inherits System.Windows.Forms.Form

    Private dt1 As DataTable
    Private iSelectID As Integer = Nothing  'for combo box select
    Private bHasChange As Boolean = False
    Private iTypeSelected As Integer
    Private bIsLoad As Boolean  'to stop sub's loading too!
    Private sCurrencyFromMain As String 'Passed in from fMain on new

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal sCurrency As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        sCurrencyFromMain = sCurrency
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
    Friend WithEvents lbStructure As System.Windows.Forms.Label
    Friend WithEvents lbSelectStructure As System.Windows.Forms.Label
    Friend WithEvents cbCommSelect As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbBand As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents lbSelectType As System.Windows.Forms.Label
    Friend WithEvents lbCommission As System.Windows.Forms.Label
    Friend WithEvents lbTo As System.Windows.Forms.Label
    Friend WithEvents lbFrom As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents tbSercCom1 As System.Windows.Forms.TextBox
    Friend WithEvents tbSercCom3 As System.Windows.Forms.TextBox
    Friend WithEvents tbSercCom4 As System.Windows.Forms.TextBox
    Friend WithEvents tbSercCom2 As System.Windows.Forms.TextBox
    Friend WithEvents tbSercCom5 As System.Windows.Forms.TextBox
    Friend WithEvents tbSF1 As System.Windows.Forms.TextBox
    Friend WithEvents tbSF3 As System.Windows.Forms.TextBox
    Friend WithEvents tbSF4 As System.Windows.Forms.TextBox
    Friend WithEvents tbSF2 As System.Windows.Forms.TextBox
    Friend WithEvents tbSF5 As System.Windows.Forms.TextBox
    Friend WithEvents tbS1 As System.Windows.Forms.Label
    Friend WithEvents tbS2 As System.Windows.Forms.Label
    Friend WithEvents tbS3 As System.Windows.Forms.Label
    Friend WithEvents tbS4 As System.Windows.Forms.Label
    Friend WithEvents tbS5 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lbWarning As System.Windows.Forms.Label
    Friend WithEvents lbSundry As System.Windows.Forms.RadioButton
    Friend WithEvents lbService As System.Windows.Forms.RadioButton
    Friend WithEvents tbSercCom6 As System.Windows.Forms.TextBox
    Friend WithEvents tbSercCom7 As System.Windows.Forms.TextBox
    Friend WithEvents tbSercCom8 As System.Windows.Forms.TextBox
    Friend WithEvents tbSF6 As System.Windows.Forms.TextBox
    Friend WithEvents tbSF7 As System.Windows.Forms.TextBox
    Friend WithEvents tbSF8 As System.Windows.Forms.TextBox
    Friend WithEvents tbS6 As System.Windows.Forms.Label
    Friend WithEvents tbS7 As System.Windows.Forms.Label
    Friend WithEvents tbS8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rbProduct As System.Windows.Forms.RadioButton
    Friend WithEvents gb1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbRetUnits As System.Windows.Forms.RadioButton
    Friend WithEvents rbRetAmount As System.Windows.Forms.RadioButton
    Friend WithEvents pbRetailHelp As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fBands))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.lbStructure = New System.Windows.Forms.Label
        Me.lbSelectStructure = New System.Windows.Forms.Label
        Me.cbCommSelect = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbBand = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.rbProduct = New System.Windows.Forms.RadioButton
        Me.lbSelectType = New System.Windows.Forms.Label
        Me.lbService = New System.Windows.Forms.RadioButton
        Me.lbSundry = New System.Windows.Forms.RadioButton
        Me.lbCommission = New System.Windows.Forms.Label
        Me.lbTo = New System.Windows.Forms.Label
        Me.lbFrom = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.tbSercCom1 = New System.Windows.Forms.TextBox
        Me.tbSercCom3 = New System.Windows.Forms.TextBox
        Me.tbSercCom4 = New System.Windows.Forms.TextBox
        Me.tbSercCom2 = New System.Windows.Forms.TextBox
        Me.tbSercCom5 = New System.Windows.Forms.TextBox
        Me.tbSF1 = New System.Windows.Forms.TextBox
        Me.tbSF3 = New System.Windows.Forms.TextBox
        Me.tbSF4 = New System.Windows.Forms.TextBox
        Me.tbSF2 = New System.Windows.Forms.TextBox
        Me.tbSF5 = New System.Windows.Forms.TextBox
        Me.tbS1 = New System.Windows.Forms.Label
        Me.tbS2 = New System.Windows.Forms.Label
        Me.tbS3 = New System.Windows.Forms.Label
        Me.tbS4 = New System.Windows.Forms.Label
        Me.tbS5 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.tbSercCom6 = New System.Windows.Forms.TextBox
        Me.tbSercCom7 = New System.Windows.Forms.TextBox
        Me.tbSercCom8 = New System.Windows.Forms.TextBox
        Me.tbSF6 = New System.Windows.Forms.TextBox
        Me.tbSF7 = New System.Windows.Forms.TextBox
        Me.tbSF8 = New System.Windows.Forms.TextBox
        Me.tbS6 = New System.Windows.Forms.Label
        Me.tbS7 = New System.Windows.Forms.Label
        Me.tbS8 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.lbWarning = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.gb1 = New System.Windows.Forms.GroupBox
        Me.pbRetailHelp = New System.Windows.Forms.PictureBox
        Me.rbRetAmount = New System.Windows.Forms.RadioButton
        Me.rbRetUnits = New System.Windows.Forms.RadioButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.gb1.SuspendLayout()
        CType(Me.pbRetailHelp, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel12.Controls.Add(Me.lbStructure)
        Me.Panel12.Name = "Panel12"
        '
        'lbStructure
        '
        Me.lbStructure.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lbStructure, "lbStructure")
        Me.lbStructure.ForeColor = System.Drawing.Color.White
        Me.lbStructure.Name = "lbStructure"
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
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Name = "Label5"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Name = "Label1"
        '
        'lbBand
        '
        resources.ApplyResources(Me.lbBand, "lbBand")
        Me.lbBand.ForeColor = System.Drawing.Color.Navy
        Me.lbBand.Name = "lbBand"
        '
        'PictureBox2
        '
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        resources.ApplyResources(Me.PictureBox3, "PictureBox3")
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        resources.ApplyResources(Me.PictureBox4, "PictureBox4")
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.TabStop = False
        '
        'rbProduct
        '
        resources.ApplyResources(Me.rbProduct, "rbProduct")
        Me.rbProduct.Name = "rbProduct"
        '
        'lbSelectType
        '
        resources.ApplyResources(Me.lbSelectType, "lbSelectType")
        Me.lbSelectType.ForeColor = System.Drawing.Color.Navy
        Me.lbSelectType.Name = "lbSelectType"
        '
        'lbService
        '
        resources.ApplyResources(Me.lbService, "lbService")
        Me.lbService.Name = "lbService"
        '
        'lbSundry
        '
        resources.ApplyResources(Me.lbSundry, "lbSundry")
        Me.lbSundry.Name = "lbSundry"
        '
        'lbCommission
        '
        resources.ApplyResources(Me.lbCommission, "lbCommission")
        Me.lbCommission.ForeColor = System.Drawing.Color.Navy
        Me.lbCommission.Name = "lbCommission"
        '
        'lbTo
        '
        resources.ApplyResources(Me.lbTo, "lbTo")
        Me.lbTo.ForeColor = System.Drawing.Color.Navy
        Me.lbTo.Name = "lbTo"
        '
        'lbFrom
        '
        resources.ApplyResources(Me.lbFrom, "lbFrom")
        Me.lbFrom.ForeColor = System.Drawing.Color.Navy
        Me.lbFrom.Name = "lbFrom"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Name = "Label10"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Name = "Label11"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Name = "Label12"
        '
        'Label28
        '
        resources.ApplyResources(Me.Label28, "Label28")
        Me.Label28.Name = "Label28"
        '
        'Label29
        '
        resources.ApplyResources(Me.Label29, "Label29")
        Me.Label29.Name = "Label29"
        '
        'Label30
        '
        resources.ApplyResources(Me.Label30, "Label30")
        Me.Label30.Name = "Label30"
        '
        'Label31
        '
        resources.ApplyResources(Me.Label31, "Label31")
        Me.Label31.Name = "Label31"
        '
        'Label32
        '
        resources.ApplyResources(Me.Label32, "Label32")
        Me.Label32.Name = "Label32"
        '
        'tbSercCom1
        '
        resources.ApplyResources(Me.tbSercCom1, "tbSercCom1")
        Me.tbSercCom1.Name = "tbSercCom1"
        '
        'tbSercCom3
        '
        resources.ApplyResources(Me.tbSercCom3, "tbSercCom3")
        Me.tbSercCom3.Name = "tbSercCom3"
        '
        'tbSercCom4
        '
        resources.ApplyResources(Me.tbSercCom4, "tbSercCom4")
        Me.tbSercCom4.Name = "tbSercCom4"
        '
        'tbSercCom2
        '
        resources.ApplyResources(Me.tbSercCom2, "tbSercCom2")
        Me.tbSercCom2.Name = "tbSercCom2"
        '
        'tbSercCom5
        '
        resources.ApplyResources(Me.tbSercCom5, "tbSercCom5")
        Me.tbSercCom5.Name = "tbSercCom5"
        '
        'tbSF1
        '
        resources.ApplyResources(Me.tbSF1, "tbSF1")
        Me.tbSF1.Name = "tbSF1"
        '
        'tbSF3
        '
        resources.ApplyResources(Me.tbSF3, "tbSF3")
        Me.tbSF3.Name = "tbSF3"
        '
        'tbSF4
        '
        resources.ApplyResources(Me.tbSF4, "tbSF4")
        Me.tbSF4.Name = "tbSF4"
        '
        'tbSF2
        '
        resources.ApplyResources(Me.tbSF2, "tbSF2")
        Me.tbSF2.Name = "tbSF2"
        '
        'tbSF5
        '
        resources.ApplyResources(Me.tbSF5, "tbSF5")
        Me.tbSF5.Name = "tbSF5"
        '
        'tbS1
        '
        Me.tbS1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbS1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.tbS1.ForeColor = System.Drawing.Color.Blue
        resources.ApplyResources(Me.tbS1, "tbS1")
        Me.tbS1.Name = "tbS1"
        '
        'tbS2
        '
        Me.tbS2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbS2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.tbS2.ForeColor = System.Drawing.Color.Blue
        resources.ApplyResources(Me.tbS2, "tbS2")
        Me.tbS2.Name = "tbS2"
        '
        'tbS3
        '
        Me.tbS3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbS3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.tbS3.ForeColor = System.Drawing.Color.Blue
        resources.ApplyResources(Me.tbS3, "tbS3")
        Me.tbS3.Name = "tbS3"
        '
        'tbS4
        '
        Me.tbS4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbS4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.tbS4.ForeColor = System.Drawing.Color.Blue
        resources.ApplyResources(Me.tbS4, "tbS4")
        Me.tbS4.Name = "tbS4"
        '
        'tbS5
        '
        Me.tbS5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbS5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.tbS5.ForeColor = System.Drawing.Color.Blue
        resources.ApplyResources(Me.tbS5, "tbS5")
        Me.tbS5.Name = "tbS5"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.Name = "Label16"
        '
        'tbSercCom6
        '
        resources.ApplyResources(Me.tbSercCom6, "tbSercCom6")
        Me.tbSercCom6.Name = "tbSercCom6"
        '
        'tbSercCom7
        '
        resources.ApplyResources(Me.tbSercCom7, "tbSercCom7")
        Me.tbSercCom7.Name = "tbSercCom7"
        '
        'tbSercCom8
        '
        resources.ApplyResources(Me.tbSercCom8, "tbSercCom8")
        Me.tbSercCom8.Name = "tbSercCom8"
        '
        'tbSF6
        '
        resources.ApplyResources(Me.tbSF6, "tbSF6")
        Me.tbSF6.Name = "tbSF6"
        '
        'tbSF7
        '
        resources.ApplyResources(Me.tbSF7, "tbSF7")
        Me.tbSF7.Name = "tbSF7"
        '
        'tbSF8
        '
        resources.ApplyResources(Me.tbSF8, "tbSF8")
        Me.tbSF8.Name = "tbSF8"
        '
        'tbS6
        '
        Me.tbS6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbS6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.tbS6.ForeColor = System.Drawing.Color.Blue
        resources.ApplyResources(Me.tbS6, "tbS6")
        Me.tbS6.Name = "tbS6"
        '
        'tbS7
        '
        Me.tbS7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbS7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.tbS7.ForeColor = System.Drawing.Color.Blue
        resources.ApplyResources(Me.tbS7, "tbS7")
        Me.tbS7.Name = "tbS7"
        '
        'tbS8
        '
        Me.tbS8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbS8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.tbS8.ForeColor = System.Drawing.Color.Blue
        resources.ApplyResources(Me.tbS8, "tbS8")
        Me.tbS8.Name = "tbS8"
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
        'lbWarning
        '
        resources.ApplyResources(Me.lbWarning, "lbWarning")
        Me.lbWarning.Name = "lbWarning"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tbSF1)
        Me.Panel1.Controls.Add(Me.tbSF3)
        Me.Panel1.Controls.Add(Me.tbSF2)
        Me.Panel1.Controls.Add(Me.tbSF6)
        Me.Panel1.Controls.Add(Me.tbSF7)
        Me.Panel1.Controls.Add(Me.tbSF4)
        Me.Panel1.Controls.Add(Me.tbSF5)
        Me.Panel1.Controls.Add(Me.tbSF8)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tbSercCom7)
        Me.Panel2.Controls.Add(Me.tbSercCom1)
        Me.Panel2.Controls.Add(Me.tbSercCom8)
        Me.Panel2.Controls.Add(Me.tbSercCom3)
        Me.Panel2.Controls.Add(Me.tbSercCom4)
        Me.Panel2.Controls.Add(Me.tbSercCom5)
        Me.Panel2.Controls.Add(Me.tbSercCom2)
        Me.Panel2.Controls.Add(Me.tbSercCom6)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.pbRetailHelp)
        Me.gb1.Controls.Add(Me.rbRetAmount)
        Me.gb1.Controls.Add(Me.rbRetUnits)
        resources.ApplyResources(Me.gb1, "gb1")
        Me.gb1.Name = "gb1"
        Me.gb1.TabStop = False
        '
        'pbRetailHelp
        '
        Me.pbRetailHelp.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.pbRetailHelp, "pbRetailHelp")
        Me.pbRetailHelp.Name = "pbRetailHelp"
        Me.pbRetailHelp.TabStop = False
        '
        'rbRetAmount
        '
        resources.ApplyResources(Me.rbRetAmount, "rbRetAmount")
        Me.rbRetAmount.Name = "rbRetAmount"
        '
        'rbRetUnits
        '
        Me.rbRetUnits.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.rbRetUnits, "rbRetUnits")
        Me.rbRetUnits.Name = "rbRetUnits"
        Me.rbRetUnits.UseVisualStyleBackColor = False
        '
        'fBands
        '
        resources.ApplyResources(Me, "$this")
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.gb1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbWarning)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.tbS6)
        Me.Controls.Add(Me.tbS7)
        Me.Controls.Add(Me.tbS8)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.tbS1)
        Me.Controls.Add(Me.tbS2)
        Me.Controls.Add(Me.tbS3)
        Me.Controls.Add(Me.tbS4)
        Me.Controls.Add(Me.tbS5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lbCommission)
        Me.Controls.Add(Me.lbTo)
        Me.Controls.Add(Me.lbFrom)
        Me.Controls.Add(Me.lbSundry)
        Me.Controls.Add(Me.lbService)
        Me.Controls.Add(Me.lbSelectType)
        Me.Controls.Add(Me.rbProduct)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbBand)
        Me.Controls.Add(Me.lbSelectStructure)
        Me.Controls.Add(Me.cbCommSelect)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fBands"
        Me.ShowInTaskbar = False
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.gb1.ResumeLayout(False)
        CType(Me.pbRetailHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region " Type Select "
    Private Sub lbService_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbService.CheckedChanged


        'Hide retail
        gb1.Visible = False
        'And (lbService.Checked) 
        If (bIsLoad = False) And (bHasChange = True) Then


            Dim msgboxYN As New fMsgBoxYN("Exit", "Changes have been made, would you like to save your changes?")
            msgboxYN.ShowDialog()
            If msgboxYN.DialogResult = DialogResult.Yes Then
                SaveBand()
                Me.iTypeSelected = 1
                PopulateForm()
            End If
        ElseIf (bIsLoad = False) And (lbService.Checked) Then
            Me.iTypeSelected = 1
            PopulateForm()
        End If

        bHasChange = False
        Me.btnSave.Enabled = False

    End Sub

    Private Sub Product_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbProduct.CheckedChanged


        'Show retail
        gb1.Visible = True
        'And (rbProduct.Checked)
        If (bIsLoad = False) And (bHasChange = True) Then
            Dim msgboxYN As New fMsgBoxYN("Exit", "Changes have been made, would you like to save your changes?")
            msgboxYN.ShowDialog()
            If msgboxYN.DialogResult = DialogResult.Yes Then
                SaveBand()
                Me.iTypeSelected = 2
                LoadRetailType()
                PopulateForm()
            End If
        ElseIf (bIsLoad = False) And (rbProduct.Checked) Then
            Me.iTypeSelected = 2
            LoadRetailType()
            PopulateForm()
        End If

        bHasChange = False
        Me.btnSave.Enabled = False

    End Sub


    Private Sub lbSundry_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbSundry.CheckedChanged


        'Hide retail
        gb1.Visible = False
        'And (lbSundry.Checked) 
        If (bIsLoad = False) And (bHasChange = True) Then
            Dim msgboxYN As New fMsgBoxYN("Exit", "Changes have been made, would you like to save your changes?")
            msgboxYN.ShowDialog()
            If msgboxYN.DialogResult = DialogResult.Yes Then
                SaveBand()
                Me.iTypeSelected = 3
                PopulateForm()
            End If
        ElseIf (bIsLoad = False) And (lbSundry.Checked) Then
            Me.iTypeSelected = 3
            PopulateForm()
        End If

        bHasChange = False
        Me.btnSave.Enabled = False
    End Sub
#End Region


#Region " Trim Check & From Update "

    Private Sub tbSF1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSF1.TextChanged
        AlterationMade()
    End Sub

    Private Sub tbSF2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSF2.TextChanged
        Try
            If tbSF2.Text.Trim(" ") <> "" Then
                tbS1.Text = tbSF2.Text
            End If

            If tbSF2.Text = 0 Then
                tbS1.Text = ""
            End If
        Catch ex As Exception
        End Try
        AlterationMade()
    End Sub

    Private Sub tbSF3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSF3.TextChanged
        Try
            If tbSF3.Text.Trim(" ") <> "" Then
                tbS2.Text = tbSF3.Text
            End If

            If tbSF3.Text = 0 Then
                tbS2.Text = ""
            End If
        Catch ex As Exception
        End Try
        AlterationMade()
    End Sub

    Private Sub tbSF4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSF4.TextChanged
        Try
            If tbSF4.Text.Trim(" ") <> "" Then
                tbS3.Text = tbSF4.Text
            End If

            If tbSF4.Text = 0 Then
                tbS3.Text = ""
            End If
        Catch ex As Exception
        End Try
        AlterationMade()
    End Sub

    Private Sub tbSF5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSF5.TextChanged
        Try
            If tbSF5.Text.Trim(" ") <> "" Then
                tbS4.Text = tbSF5.Text
            End If

            If tbSF5.Text = 0 Then
                tbS4.Text = ""
            End If

        Catch ex As Exception
        End Try
        AlterationMade()
    End Sub

    Private Sub tbSF6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSF6.TextChanged
        Try
            If tbSF6.Text.Trim(" ") <> "" Then
                tbS5.Text = tbSF6.Text
            End If

            If tbSF6.Text = 0 Then
                tbS5.Text = ""
            End If

        Catch ex As Exception
        End Try
        AlterationMade()
    End Sub

    Private Sub tbSF7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSF7.TextChanged
        Try
            If tbSF7.Text.Trim(" ") <> "" Then
                tbS6.Text = tbSF7.Text
            End If

            If tbSF7.Text = 0 Then
                tbS6.Text = ""
            End If

        Catch ex As Exception
        End Try
        AlterationMade()
    End Sub

    Private Sub tbSF8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSF8.TextChanged
        Try
            If tbSF8.Text.Trim(" ") <> "" Then
                tbS7.Text = tbSF8.Text
            End If

            If tbSF8.Text = 0 Then
                tbS7.Text = ""
            End If

        Catch ex As Exception
        End Try
        AlterationMade()
    End Sub

#End Region


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If bHasChange = True And Me.btnSave.Enabled = True Then

            Dim msgboxYN As New fMsgBoxYN("Exit", "There has been changes made, are you sure you want to exit before saving?")
            msgboxYN.ShowDialog()
            If msgboxYN.DialogResult = DialogResult.Yes Then
                FadeOutDialog(Me)
                Me.Close()
            End If
        Else
            FadeOutDialog(Me)
            Me.Close()
        End If
    End Sub

    Private Sub fBands_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

       
        bIsLoad = True

        SDA.strSqlSP = "dbo.usp_BIComReportStructSelect" 'Just the comm structures and their ID's
        dt1 = SDA.SqlDataSet.Tables(0)

        If iSunSelect = 1 Then
            lbSundry.Text = "Sundry"
        ElseIf iSunSelect = 2 Then
            lbSundry.Text = "Chemical"
        ElseIf iSunSelect = 3 Then
            lbSundry.Text = "Refer"
        ElseIf iSunSelect = 4 Then
            Me.lbSundry.Checked = True
            lbSundry.Text = "Client Count"
            lbWarning.Visible = True
            Me.lbService.Enabled = False
        End If


        FadeInDialog(Me) 'out here so user does not see the page setting up above

        Me.btnSave.Enabled = False

        bHasChange = False 'just in case altered when loading

        If SDA.iReturn = 1 Then
            rbRetUnits.Checked = True
        Else
            rbRetAmount.Checked = True
        End If

        'Reset flag
        bIsLoad = False
    End Sub

    Private Sub cbCommSelect_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCommSelect.DropDown
        Me.cbCommSelect.DataSource = dt1
        Me.cbCommSelect.ValueMember = dt1.Columns(0).ToString
        Me.cbCommSelect.DisplayMember = dt1.Columns(1).ToString
    End Sub


    Private Sub tbSercCom1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSercCom1.TextChanged, _
    tbSercCom2.TextChanged, tbSercCom3.TextChanged, tbSercCom4.TextChanged, tbSercCom5.TextChanged, _
    tbSercCom6.TextChanged, tbSercCom7.TextChanged, tbSercCom8.TextChanged

        AlterationMade()

    End Sub


    Private Sub AlterationMade()
        bHasChange = True
        Me.btnSave.Enabled = True
    End Sub


    Private Sub cbCommSelect_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCommSelect.SelectionChangeCommitted



        iSelectID = Me.cbCommSelect.SelectedValue
        'PopulateForm()

        'Set vis and checks
        If iSunSelect = 4 Then
            Me.lbSundry.Checked = True
            lbSundry.Text = "Client Count"
            lbWarning.Visible = True
            ' Me.Panel1.Enabled = False
            Me.lbService.Enabled = False
            Me.Panel1.Enabled = True
            Me.iTypeSelected = 3
            PopulateForm()
        Else
            PopulateForm()
            Me.lbService.Enabled = True
            Me.lbService.Checked = True

        End If

        'Set rest to visible
        Me.lbSundry.Enabled = True
        Me.rbProduct.Enabled = True

    End Sub


    Private Sub PopulateForm()
        'Used on dropdown commited and on option change along the top


        'Call SP and populate form
        '(used in this format as not to save results that are not used or set to 0
        SDA.strSqlSP = "dbo.usp_BIComReportStructSelectRange"
        SDA.AddParam("@IDComm", iSelectID, SqlDbType.Int)
        SDA.AddParam("@Type", iTypeSelected, SqlDbType.Int)
        SDA.SqlGetDataSingleRow()

        If SDA.iReturn = 0 Then
            tbSF1.Text = SDA.SqlSingleRow(0)
            tbSF2.Text = SDA.SqlSingleRow(2)
            tbSF3.Text = SDA.SqlSingleRow(4)
            tbSF4.Text = SDA.SqlSingleRow(6)
            tbSF5.Text = SDA.SqlSingleRow(8)
            tbSF6.Text = SDA.SqlSingleRow(10)
            tbSF7.Text = SDA.SqlSingleRow(12)
            tbSF8.Text = SDA.SqlSingleRow(14)

            tbSercCom1.Text = SDA.SqlSingleRow(1)
            tbSercCom2.Text = SDA.SqlSingleRow(3)
            tbSercCom3.Text = SDA.SqlSingleRow(5)
            tbSercCom4.Text = SDA.SqlSingleRow(7)
            tbSercCom5.Text = SDA.SqlSingleRow(9)
            tbSercCom6.Text = SDA.SqlSingleRow(11)
            tbSercCom7.Text = SDA.SqlSingleRow(13)
            tbSercCom8.Text = SDA.SqlSingleRow(15)
        ElseIf SDA.iReturn = 1 Then 'reset
            tbSF1.Text = 0
            tbSF2.Text = 0
            tbSF3.Text = 0
            tbSF4.Text = 0
            tbSF5.Text = 0
            tbSF6.Text = 0
            tbSF7.Text = 0
            tbSF8.Text = 0
            tbSercCom1.Text = 0
            tbSercCom2.Text = 0
            tbSercCom3.Text = 0
            tbSercCom4.Text = 0
            tbSercCom5.Text = 0
            tbSercCom6.Text = 0
            tbSercCom7.Text = 0
            tbSercCom8.Text = 0
        End If


        'Dont enable if client count is ticked
        If iSunSelect <> 4 Then
            Me.Panel1.Enabled = False
        End If

        Me.Panel1.Enabled = True
        Me.Panel2.Enabled = True

        Me.btnSave.Enabled = False
        Me.bHasChange = False

    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If CheckInteger(Me) = False Then
            If iSelectID <> Nothing Then
                SaveBand()
            Else
                Dim msgbox As New fMsgBox(2, "Select Error", "Please select from the drop down list")
                msgbox.ShowDialog()
            End If
            bHasChange = False
            Me.btnSave.Enabled = False
        End If
    End Sub

    Private Sub pbRetailHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRetailHelp.Click
        Dim form As New fHelp("‘Units Sold’ – Select this if you want the commission to be calculated on the number of items sold (i.e. 3 bottles of shampoo). Enter the number of items into the ‘From’ box’s" & vbNewLine _
        & "NOTE: units will NOT be calculated as cumulative if this option is selected, they are calculated as ‘target’" & vbNewLine & vbNewLine _
        & "'Amount’ – This will be based on a financial amount (in " & sCurrencyFromMain & ")")
        form.ShowDialog()
    End Sub

    Private Sub rbRetUnits_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRetUnits.CheckedChanged
        If (bIsLoad = False) Then
            AlterationMade()
        End If
    End Sub

    Private Sub rbRetAmount_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRetAmount.CheckedChanged
        If (bIsLoad = False) Then
            AlterationMade()
        End If
    End Sub


    Private Sub LoadRetailType()
        'Load retail type
        SDA.strSqlSP = "dbo.usp_BIComReportProcessSettings"
        SDA.AddParam("@Key", "RetailType", SqlDbType.Text)
        SDA.AddParam("@Value", 0, SqlDbType.Int)
        SDA.AddParam("@Type", 0, SqlDbType.Int)
        SDA.SqlGetDataSingleRow()
        If SDA.SqlSingleRow(0) = 1 Then
            rbRetUnits.Checked = True
        Else
            rbRetAmount.Checked = True
        End If

    End Sub

    Private Sub SaveBand()
        'Update Retail Type IF the retail type button is selected
        'if not dont want to get confused by the user changing the type and then not wanting to save
        'but the application picking this up
        If Me.iTypeSelected = 2 Then
            SaveBandType()
        End If

        'Must check all is set to 0 if null or will have provlems
        If tbSF1.Text.Trim(" ") = "" Then
            tbSF1.Text = 0
        End If
        If tbSF2.Text.Trim(" ") = "" Then
            tbSF2.Text = 0
        End If
        If tbSF3.Text.Trim(" ") = "" Then
            tbSF3.Text = 0
        End If
        If tbSF4.Text.Trim(" ") = "" Then
            tbSF4.Text = 0
        End If
        If tbSF5.Text.Trim(" ") = "" Then
            tbSF5.Text = 0
        End If
        If tbSF6.Text.Trim(" ") = "" Then
            tbSF6.Text = 0
        End If
        If tbSF7.Text.Trim(" ") = "" Then
            tbSF7.Text = 0
        End If
        If tbSF8.Text.Trim(" ") = "" Then
            tbSF8.Text = 0
        End If


        Try
            SDA.strSqlSP = "dbo.usp_BIComReportStructUpdateRange"
            SDA.AddParam("@IDComm", iSelectID, SqlDbType.Int)
            SDA.AddParam("@Type", iTypeSelected, SqlDbType.Int)

            SDA.AddParam("@1f", tbSF1.Text, SqlDbType.Float)
            SDA.AddParam("@2f", tbSF2.Text, SqlDbType.Float)
            SDA.AddParam("@3f", tbSF3.Text, SqlDbType.Float)
            SDA.AddParam("@4f", tbSF4.Text, SqlDbType.Float)
            SDA.AddParam("@5f", tbSF5.Text, SqlDbType.Float)
            SDA.AddParam("@6f", tbSF6.Text, SqlDbType.Float)
            SDA.AddParam("@7f", tbSF7.Text, SqlDbType.Float)
            SDA.AddParam("@8f", tbSF8.Text, SqlDbType.Float)

            SDA.AddParam("@1c", Math.Round(CSng(tbSercCom1.Text), 2), SqlDbType.Float)
            SDA.AddParam("@2c", Math.Round(CSng(tbSercCom2.Text), 2), SqlDbType.Float)
            SDA.AddParam("@3c", Math.Round(CSng(tbSercCom3.Text), 2), SqlDbType.Float)
            SDA.AddParam("@4c", Math.Round(CSng(tbSercCom4.Text), 2), SqlDbType.Float)
            SDA.AddParam("@5c", Math.Round(CSng(tbSercCom5.Text), 2), SqlDbType.Float)
            SDA.AddParam("@6c", Math.Round(CSng(tbSercCom6.Text), 2), SqlDbType.Float)
            SDA.AddParam("@7c", Math.Round(CSng(tbSercCom7.Text), 2), SqlDbType.Float)
            SDA.AddParam("@8c", Math.Round(CSng(tbSercCom8.Text), 2), SqlDbType.Float)

            SDA.SqlExecute() 'pass to sp!

            Dim msgbox As New fMsgBox(0, "Saved", "Settings Saved")
            msgbox.ShowDialog()

            'Me.Close()
        Catch ex As Exception
            Dim msgbox As New fMsgBox(2, "System Error", ex.ToString)
            msgbox.ShowDialog()
        End Try
    End Sub

    Private Sub SaveBandType()

        'Needed for version 2 conversion from boolean, ints and floats
        'to floats only
        Dim temp As Integer
        If Me.rbRetUnits.Checked = -1 Then
            temp = 1
        End If

        SDA.strSqlSP = "dbo.usp_BIComReportProcessSettings"
        SDA.AddParam("@Key", "RetailType", SqlDbType.Text)
        SDA.AddParam("@Value", temp, SqlDbType.Float)
        SDA.AddParam("@Type", 1, SqlDbType.Int)
        SDA.SqlExecute()
    End Sub

    Private Sub cbCommSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCommSelect.SelectedIndexChanged

    End Sub
End Class
