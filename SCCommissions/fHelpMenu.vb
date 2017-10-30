Public Class fHelpMenu
    Inherits System.Windows.Forms.Form


    Private bChange As Boolean = False

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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents lbHelpandSettings As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents lbUser As System.Windows.Forms.Label
    Friend WithEvents lbUserTxt As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lbRestoreTxt As System.Windows.Forms.Label
    Friend WithEvents lbRestoreDefault As System.Windows.Forms.Label
    Friend WithEvents lbEffectMenuTxt As System.Windows.Forms.Label
    Friend WithEvents lbEffectMenu As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fHelpMenu))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.lbHelpandSettings = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.lbUser = New System.Windows.Forms.Label
        Me.lbUserTxt = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.lbRestoreTxt = New System.Windows.Forms.Label
        Me.lbRestoreDefault = New System.Windows.Forms.Label
        Me.lbEffectMenuTxt = New System.Windows.Forms.Label
        Me.lbEffectMenu = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'Panel12
        '
        resources.ApplyResources(Me.Panel12, "Panel12")
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.lbHelpandSettings)
        Me.Panel12.Name = "Panel12"
        '
        'lbHelpandSettings
        '
        Me.lbHelpandSettings.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lbHelpandSettings, "lbHelpandSettings")
        Me.lbHelpandSettings.ForeColor = System.Drawing.Color.White
        Me.lbHelpandSettings.Name = "lbHelpandSettings"
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.PictureBox3, "PictureBox3")
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.PictureBox4, "PictureBox4")
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.TabStop = False
        '
        'lbUser
        '
        resources.ApplyResources(Me.lbUser, "lbUser")
        Me.lbUser.Name = "lbUser"
        '
        'lbUserTxt
        '
        resources.ApplyResources(Me.lbUserTxt, "lbUserTxt")
        Me.lbUserTxt.Name = "lbUserTxt"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Silver
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnClose, "btnClose")
        Me.btnClose.Name = "btnClose"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lbRestoreTxt
        '
        resources.ApplyResources(Me.lbRestoreTxt, "lbRestoreTxt")
        Me.lbRestoreTxt.Name = "lbRestoreTxt"
        '
        'lbRestoreDefault
        '
        resources.ApplyResources(Me.lbRestoreDefault, "lbRestoreDefault")
        Me.lbRestoreDefault.Name = "lbRestoreDefault"
        '
        'lbEffectMenuTxt
        '
        resources.ApplyResources(Me.lbEffectMenuTxt, "lbEffectMenuTxt")
        Me.lbEffectMenuTxt.Name = "lbEffectMenuTxt"
        '
        'lbEffectMenu
        '
        resources.ApplyResources(Me.lbEffectMenu, "lbEffectMenu")
        Me.lbEffectMenu.Name = "lbEffectMenu"
        '
        'fHelpMenu
        '
        resources.ApplyResources(Me, "$this")
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.lbEffectMenuTxt)
        Me.Controls.Add(Me.lbEffectMenu)
        Me.Controls.Add(Me.lbRestoreTxt)
        Me.Controls.Add(Me.lbRestoreDefault)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lbUserTxt)
        Me.Controls.Add(Me.lbUser)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fHelpMenu"
        Me.ShowInTaskbar = False
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Dim sTemp As String = Environment.CurrentDirectory & "\UserGuide.pdf"

        Try
            If System.IO.File.Exists(sTemp) Then
                System.Diagnostics.Process.Start(sTemp)
            Else
                Dim msgbox As New fMsgBox(2, "System Error", "The program can not find the user guide, please contact the help desk")
                msgbox.ShowDialog()
            End If
        Catch ex As Exception
            Dim msgbox As New fMsgBox(2, "System Error", ex.Message.ToString)
            msgbox.ShowDialog()
        End Try
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim msgboxYN As New fMsgBoxYN("Warning", "Are you sure you want to reset all of your options back to the default settings?")
        msgboxYN.ShowDialog()
        If msgboxYN.DialogResult = DialogResult.Yes Then
            'This is done via a sql script to set the defaults then re-load them back into the application for ease
            SDA.strSqlSP = "dbo.usp_BIComReportSetDefault"
            SDA.AddParam("@Install", 0, SqlDbType.Int)
            SDA.SqlExecute()

            'Retrieve all settings from the database
            Me.DialogResult = DialogResult.Yes 'pass back that its changed
            FadeOutDialog(Me)
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        If bFX = False Then
            bFX = True
            Me.lbEffectMenu.Text = "Fade Effects - On"
        Else
            bFX = False
            Me.lbEffectMenu.Text = "Fade Effects - Off"
        End If

        SDA.strSqlSP = "dbo.usp_BIComReportProcessSettings"
        SDA.AddParam("@Key", "FX", SqlDbType.Text)
        SDA.AddParam("@Value", bFX, SqlDbType.Bit)
        SDA.AddParam("@Type", 1, SqlDbType.Int)
        SDA.SqlExecute()

        bChange = True
    End Sub

    Private Sub fHelpMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = "Build: " & sVersionMinor

        If bFX = False Then
            Me.lbEffectMenu.Text = "Fade Effects - Off"
        Else
            Me.lbEffectMenu.Text = "Fade Effects - On"
        End If

        FadeInDialog(Me)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If Me.bChange = True Then
            Me.DialogResult = DialogResult.No 'pass back there has been a change
        End If

        FadeOutDialog(Me)
        Me.Close()
    End Sub
End Class
