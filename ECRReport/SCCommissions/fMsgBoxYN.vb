Public Class fMsgBoxYN
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal Heading As String, ByVal Body As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.lbHeading.Text = Heading
        Me.lbBody.Text = Body
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbHeading As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents pbWarning As System.Windows.Forms.PictureBox
    Friend WithEvents pbYes As System.Windows.Forms.PictureBox
    Friend WithEvents pbNo As System.Windows.Forms.PictureBox
    Friend WithEvents lbNo As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbBody As System.Windows.Forms.Label
    Friend WithEvents lbYes As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fMsgBoxYN))
        Me.pbYes = New System.Windows.Forms.PictureBox
        Me.pbNo = New System.Windows.Forms.PictureBox
        Me.lbNo = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbHeading = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbBody = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lbYes = New System.Windows.Forms.Label
        Me.pbWarning = New System.Windows.Forms.PictureBox
        CType(Me.pbYes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.pbWarning, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbYes
        '
        Me.pbYes.AccessibleDescription = Nothing
        Me.pbYes.AccessibleName = Nothing
        resources.ApplyResources(Me.pbYes, "pbYes")
        Me.pbYes.BackgroundImage = Nothing
        Me.pbYes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbYes.Font = Nothing
        Me.pbYes.ImageLocation = Nothing
        Me.pbYes.Name = "pbYes"
        Me.pbYes.TabStop = False
        '
        'pbNo
        '
        Me.pbNo.AccessibleDescription = Nothing
        Me.pbNo.AccessibleName = Nothing
        resources.ApplyResources(Me.pbNo, "pbNo")
        Me.pbNo.BackgroundImage = Nothing
        Me.pbNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbNo.Font = Nothing
        Me.pbNo.ImageLocation = Nothing
        Me.pbNo.Name = "pbNo"
        Me.pbNo.TabStop = False
        '
        'lbNo
        '
        Me.lbNo.AccessibleDescription = Nothing
        Me.lbNo.AccessibleName = Nothing
        resources.ApplyResources(Me.lbNo, "lbNo")
        Me.lbNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbNo.Name = "lbNo"
        '
        'Panel1
        '
        Me.Panel1.AccessibleDescription = Nothing
        Me.Panel1.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Panel1.BackgroundImage = Nothing
        Me.Panel1.Controls.Add(Me.lbHeading)
        Me.Panel1.Font = Nothing
        Me.Panel1.Name = "Panel1"
        '
        'lbHeading
        '
        Me.lbHeading.AccessibleDescription = Nothing
        Me.lbHeading.AccessibleName = Nothing
        resources.ApplyResources(Me.lbHeading, "lbHeading")
        Me.lbHeading.ForeColor = System.Drawing.Color.White
        Me.lbHeading.Name = "lbHeading"
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = Nothing
        Me.GroupBox1.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.BackgroundImage = Nothing
        Me.GroupBox1.Controls.Add(Me.lbBody)
        Me.GroupBox1.Controls.Add(Me.pbYes)
        Me.GroupBox1.Controls.Add(Me.pbNo)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = Nothing
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'lbBody
        '
        Me.lbBody.AccessibleDescription = Nothing
        Me.lbBody.AccessibleName = Nothing
        resources.ApplyResources(Me.lbBody, "lbBody")
        Me.lbBody.Name = "lbBody"
        '
        'GroupBox2
        '
        Me.GroupBox2.AccessibleDescription = Nothing
        Me.GroupBox2.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.BackgroundImage = Nothing
        Me.GroupBox2.Controls.Add(Me.lbNo)
        Me.GroupBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.GroupBox2.Font = Nothing
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.AccessibleDescription = Nothing
        Me.GroupBox3.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.BackgroundImage = Nothing
        Me.GroupBox3.Controls.Add(Me.lbYes)
        Me.GroupBox3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.GroupBox3.Font = Nothing
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'lbYes
        '
        Me.lbYes.AccessibleDescription = Nothing
        Me.lbYes.AccessibleName = Nothing
        resources.ApplyResources(Me.lbYes, "lbYes")
        Me.lbYes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbYes.Name = "lbYes"
        '
        'pbWarning
        '
        Me.pbWarning.AccessibleDescription = Nothing
        Me.pbWarning.AccessibleName = Nothing
        resources.ApplyResources(Me.pbWarning, "pbWarning")
        Me.pbWarning.BackgroundImage = Nothing
        Me.pbWarning.Font = Nothing
        Me.pbWarning.ImageLocation = Nothing
        Me.pbWarning.Name = "pbWarning"
        Me.pbWarning.TabStop = False
        '
        'fMsgBoxYN
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pbWarning)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = Nothing
        Me.Name = "fMsgBoxYN"
        Me.ShowInTaskbar = False
        Me.TopMost = True
        CType(Me.pbYes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.pbWarning, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub pbYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbYes.Click, lbYes.Click
        Me.DialogResult = DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub pbNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbNo.Click, lbNo.Click
        Me.DialogResult = DialogResult.No
        Me.Close()
    End Sub
End Class
