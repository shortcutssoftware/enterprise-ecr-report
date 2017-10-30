Public Class fMsgBox
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(byval Picture as Integer, Heading as String, byval Body as String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        If Picture = 0 Then
            Me.pbInfo.Visible = True
        ElseIf Picture = 1 Then
            Me.pbQuestion.Visible = True
        ElseIf Picture = 2 Then
            Me.pbWarning.Visible = True
        End If

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
    Friend WithEvents pbDone As System.Windows.Forms.PictureBox
    Friend WithEvents lbDone As System.Windows.Forms.Label
    Friend WithEvents lbBody As System.Windows.Forms.Label
    Friend WithEvents pbInfo As System.Windows.Forms.PictureBox
    Friend WithEvents pbWarning As System.Windows.Forms.PictureBox
    Friend WithEvents pbQuestion As System.Windows.Forms.PictureBox
    Friend WithEvents lbHeading As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fMsgBox))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbHeading = New System.Windows.Forms.Label
        Me.pbDone = New System.Windows.Forms.PictureBox
        Me.pbInfo = New System.Windows.Forms.PictureBox
        Me.pbWarning = New System.Windows.Forms.PictureBox
        Me.pbQuestion = New System.Windows.Forms.PictureBox
        Me.lbDone = New System.Windows.Forms.Label
        Me.lbBody = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Panel1.SuspendLayout()
        CType(Me.pbDone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbWarning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbQuestion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        'pbDone
        '
        Me.pbDone.AccessibleDescription = Nothing
        Me.pbDone.AccessibleName = Nothing
        resources.ApplyResources(Me.pbDone, "pbDone")
        Me.pbDone.BackgroundImage = Nothing
        Me.pbDone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbDone.Font = Nothing
        Me.pbDone.ImageLocation = Nothing
        Me.pbDone.Name = "pbDone"
        Me.pbDone.TabStop = False
        '
        'pbInfo
        '
        Me.pbInfo.AccessibleDescription = Nothing
        Me.pbInfo.AccessibleName = Nothing
        resources.ApplyResources(Me.pbInfo, "pbInfo")
        Me.pbInfo.BackgroundImage = Nothing
        Me.pbInfo.Font = Nothing
        Me.pbInfo.ImageLocation = Nothing
        Me.pbInfo.Name = "pbInfo"
        Me.pbInfo.TabStop = False
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
        'pbQuestion
        '
        Me.pbQuestion.AccessibleDescription = Nothing
        Me.pbQuestion.AccessibleName = Nothing
        resources.ApplyResources(Me.pbQuestion, "pbQuestion")
        Me.pbQuestion.BackgroundImage = Nothing
        Me.pbQuestion.Font = Nothing
        Me.pbQuestion.ImageLocation = Nothing
        Me.pbQuestion.Name = "pbQuestion"
        Me.pbQuestion.TabStop = False
        '
        'lbDone
        '
        Me.lbDone.AccessibleDescription = Nothing
        Me.lbDone.AccessibleName = Nothing
        resources.ApplyResources(Me.lbDone, "lbDone")
        Me.lbDone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbDone.Name = "lbDone"
        '
        'lbBody
        '
        Me.lbBody.AccessibleDescription = Nothing
        Me.lbBody.AccessibleName = Nothing
        resources.ApplyResources(Me.lbBody, "lbBody")
        Me.lbBody.Name = "lbBody"
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = Nothing
        Me.GroupBox1.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.BackgroundImage = Nothing
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = Nothing
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.AccessibleDescription = Nothing
        Me.GroupBox2.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.BackgroundImage = Nothing
        Me.GroupBox2.Font = Nothing
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'fMsgBox
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.lbBody)
        Me.Controls.Add(Me.lbDone)
        Me.Controls.Add(Me.pbInfo)
        Me.Controls.Add(Me.pbDone)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pbQuestion)
        Me.Controls.Add(Me.pbWarning)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = Nothing
        Me.Name = "fMsgBox"
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbDone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbWarning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbQuestion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub pbDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDone.Click, lbDone.Click
        Me.Close()
    End Sub
End Class
