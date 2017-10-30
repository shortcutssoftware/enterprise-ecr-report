Public Class fHelp
    Inherits System.Windows.Forms.Form

    Private sHelpString As String
#Region " Windows Form Designer generated code "

    Public Sub New(ByVal Helptext As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        sHelpString = Helptext
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
    Friend WithEvents lbHelp As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents lbHelpTile As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fHelp))
        Me.btnClose = New System.Windows.Forms.Button
        Me.lbHelp = New System.Windows.Forms.Label
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.lbHelpTile = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel12.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'lbHelp
        '
        Me.lbHelp.AccessibleDescription = Nothing
        Me.lbHelp.AccessibleName = Nothing
        resources.ApplyResources(Me.lbHelp, "lbHelp")
        Me.lbHelp.Name = "lbHelp"
        '
        'Panel12
        '
        Me.Panel12.AccessibleDescription = Nothing
        Me.Panel12.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel12, "Panel12")
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.lbHelpTile)
        Me.Panel12.Font = Nothing
        Me.Panel12.Name = "Panel12"
        '
        'lbHelpTile
        '
        Me.lbHelpTile.AccessibleDescription = Nothing
        Me.lbHelpTile.AccessibleName = Nothing
        resources.ApplyResources(Me.lbHelpTile, "lbHelpTile")
        Me.lbHelpTile.BackColor = System.Drawing.Color.Transparent
        Me.lbHelpTile.ForeColor = System.Drawing.Color.White
        Me.lbHelpTile.Name = "lbHelpTile"
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
        'fHelp
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lbHelp)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fHelp"
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Me.Panel12.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        FadeOutDialog(Me)

        Me.Close()
    End Sub

    Private Sub fHelp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FadeInDialog(Me)

        Me.lbHelp.Text = sHelpString
    End Sub
End Class
