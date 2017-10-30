Imports SDAConnection
Imports Microsoft.Win32
Imports System.Data.SqlClient


Public Class fSplash


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub



    Private Sub fSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.lbVersion.Text = "Version " & sVersion.ToString

        LoadProgram()


        'System.Threading.Thread.Sleep(600000)


        'Check to see if the security is turned on first, if not then skip the pin screen
        SDA.strSqlSP = "dbo.usp_BIComReportSecurityOnOff"
        SDA.SqlExecute()

        If SDA.iReturn = 0 Then 'off
            Dim fmain As New fMain
            fmain.Show()
            Me.Close()
        Else
            Dim fPin As New fPinScreen
            fPin.Show()
            Me.Close()
        End If

    End Sub

End Class




Module mStarter
    Public sVersion As String = "V.2.22" 'Program Version
    Public sVersionMinor As String = "0022" 'Program Version
    ' Public fPinScreen As fPinScreen   'Main form
    Private sServer As String 'Server name
    Private sDatabase As String 'DB name
    Public iSunSelect As Integer 'To keep track of which sundry comm is selected
    Public bFX As Boolean 'Option for fade
    Public bError As Boolean = True 'To prevent running if error
    Friend SDA As New SqlDataAccess("")      'SQL access
    Public sLogName As String = "SC Commissions Report" 'For log file writes


    Public Sub LoadProgram()


        If Process.GetProcessesByName _
                 (Process.GetCurrentProcess.ProcessName).Length > 1 Then

            MessageBox.Show _
             ("Another Instance of this process is already running", _
                 "Multiple Instances Forbidden", _
                  MessageBoxButtons.OK, _
                 MessageBoxIcon.Exclamation)
            Application.Exit()
        Else



            'Check for the existance of a pointer to a test database
            'sDatabase = CStr(Registry.LocalMachine.OpenSubKey("Software\ShortCuts\Database\ShortcutsPOS").GetValue("BIAdminDatabase"))

            '*******************************************************************************************************
            'Before the program does anything it needs to check its access key
            Try
                sServer = CStr(Registry.LocalMachine.OpenSubKey("Software\ShortCuts\Database\ShortcutsPOS").GetValue("Server"))
                If sDatabase = Nothing Then
                    sDatabase = CStr(Registry.LocalMachine.OpenSubKey("Software\ShortCuts\Database\ShortcutsPOS").GetValue("Database"))
                End If
                WriteToEventLog("Server=" + sServer + ";Database=" + sDatabase + ";Trusted_Connection=True", sLogName, EventLogEntryType.Information)
            Catch ex As Exception
                MessageBox.Show("ERROR: Windows Registry 'Database' and 'Server' can not be read", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                WriteToEventLog("ERROR: Windows Registry 'Database' and 'Server' can not be read" & vbNewLine & "VB Error = " & ex.Message, sLogName, EventLogEntryType.Error)
            End Try

            'For dll
            SDA.Connection.ChangeDB(sServer, sDatabase)
            '*******************************************************************************************************



            'Can not call SQLConnection dll on this as need to check for sp's that are used by it
            'If nothing exists then auto-repair database

            Dim myConnection As New SqlConnection("Server=" + sServer + ";Database=" + sDatabase + ";Trusted_Connection=True")
            Dim myCommand As SqlCommand
            Dim dr As SqlDataReader

            'Establishing connection
            Try
                myConnection.Open()
                'opening the connection
                myCommand = New SqlCommand("DECLARE @Missing AS SMALLINT " _
                & "SELECT @MISSING = 0 " _
                & "IF NOT EXISTS (SELECT 'usp_BIComReportCompSelect' FROM sysobjects WHERE  [name] = 'usp_BIComReportCompSelect' AND type = 'P') SELECT @Missing = 1 " _
                & "IF NOT EXISTS (SELECT 'usp_BIComReportSetDefault' FROM sysobjects WHERE  [name] = 'usp_BIComReportSetDefault' AND type = 'P') SELECT @Missing = 1 " _
                & "IF NOT EXISTS (SELECT 'usp_BIComReportProcessSettings' FROM sysobjects WHERE  [name] = 'usp_BIComReportProcessSettings' AND type = 'P') SELECT @Missing = 1 " _
                & "IF NOT EXISTS (SELECT 'usp_BIComReportStructUpdateRange' FROM sysobjects WHERE  [name] = 'usp_BIComReportStructUpdateRange' AND type = 'P') SELECT @Missing = 1 " _
                & "IF NOT EXISTS (SELECT 'usp_BIComReportStructSelectRange' FROM sysobjects WHERE  [name] = 'usp_BIComReportStructSelectRange' AND type = 'P') SELECT @Missing = 1 " _
                & "IF NOT EXISTS (SELECT 'usp_BIComReportStructSelect' FROM sysobjects WHERE  [name] = 'usp_BIComReportStructSelect' AND type = 'P') SELECT @Missing = 1 " _
                & "IF NOT EXISTS (SELECT 'usp_BIComReportLineSelect' FROM sysobjects WHERE  [name] = 'usp_BIComReportLineSelect' AND type = 'P') SELECT @Missing = 1 " _
                & "IF NOT EXISTS (SELECT 'usp_BIComReportLineUpdate' FROM sysobjects WHERE  [name] = 'usp_BIComReportLineUpdate' AND type = 'P') SELECT @Missing = 1 " _
                & "IF NOT EXISTS (SELECT 'usp_BIComReportLineRate' FROM sysobjects WHERE  [name] = 'usp_BIComReportLineRate' AND type = 'P') SELECT @Missing = 1 " _
                & "IF NOT EXISTS (SELECT 'usp_BIComReportSecurityCheck' FROM sysobjects WHERE  [name] = 'usp_BIComReportSecurityCheck' AND type = 'P') SELECT @Missing = 1 " _
                & "IF NOT EXISTS (SELECT 'usp_BIComReportSecurityOnOff' FROM sysobjects WHERE  [name] = 'usp_BIComReportSecurityOnOff' AND type = 'P') SELECT @Missing = 1 " _
                & "IF NOT EXISTS (SELECT 'usp_BIComReportLogInsert' FROM sysobjects WHERE  [name] = 'usp_BIComReportLogInsert' AND type = 'P') SELECT @Missing = 1 " _
                & "IF NOT EXISTS (SELECT 'usp_BIComReportServiceUpdate' FROM sysobjects WHERE  [name] = 'usp_BIComReportServiceUpdate' AND type = 'P') SELECT @Missing = 1 " _
                & "IF NOT EXISTS (SELECT 'usp_BIComReportWage' FROM sysobjects WHERE  [name] = 'usp_BIComReportWage' AND type = 'P') SELECT @Missing = 1 " _
                & "IF NOT EXISTS (SELECT [name] FROM sysobjects WHERE [name] = 'BIComReportBands' AND type = 'U') SELECT @Missing = 1 " _
                & "IF NOT EXISTS (SELECT [name] FROM sysobjects WHERE [name] = 'BIComReportSettings' AND type = 'U') SELECT @Missing = 1 " _
                & "IF NOT EXISTS (SELECT [name] FROM sysobjects WHERE [name] = 'BIComReportServiceCost' AND type = 'U') SELECT @Missing = 1 " _
                & "SELECT @Missing", myConnection)

                'executing the command and assigning it to connection 
                dr = myCommand.ExecuteReader()
                'read from the datareader
                dr.Read()

                If dr(0).ToString = 1 Then
                    Dim msgbox1 As New fMsgBox(2, "Error Detected", "The program has detected that not all the required pre-requisites are installed on your database, the program will now attempt to repair this")
                    msgbox1.ShowDialog()

                    Dim sTemp As String = Environment.CurrentDirectory & "\InstallSQL.exe"

                    Try
                        If System.IO.File.Exists(sTemp) Then
                            System.Diagnostics.Process.Start(sTemp, 0).WaitForExit()
                            Dim msgbox2 As New fMsgBox(0, "Repair Complete", "Update Sucesful!")
                            msgbox2.ShowDialog()
                            WriteToEventLog("Repair: Re-Adding missing sp's & table's -  Repair Complete/Update Sucesful" & vbNewLine, sLogName, EventLogEntryType.Information)
                        Else
                            Dim msgbox3 As New fMsgBox(2, "Error", "The program can not find the repair file, please contact the help desk")
                            msgbox3.ShowDialog()
                            bError = True
                            WriteToEventLog("ERROR: Re-Adding missing sp's & table's - The program can not find the repair file, please contact the help desk", sLogName, EventLogEntryType.Error)
                        End If
                    Catch ex As Exception
                        WriteToEventLog("ERROR: Re-Adding missing sp's & table's" & vbNewLine & "VB Error = " & ex.Message, sLogName, EventLogEntryType.Error)
                        Dim msgbox3 As New fMsgBox(2, "Error", ex.Message.ToString)
                        msgbox3.ShowDialog()
                        bError = True
                    End Try

                End If

                'Cleanup()
                dr.Close()
                myConnection.Close()
            Catch e As Exception
                WriteToEventLog("ERROR: Re-Adding missing sp's & table's" & vbNewLine & "VB Error = " & e.Message, sLogName, EventLogEntryType.Error)
            End Try

            ''Check to see if the security is turned on first, if not then skip the pin screen
            'SDA.strSqlSP = "dbo.usp_BIComReportSecurityOnOff"
            'SDA.SqlExecute()

            'If SDA.iReturn = 0 Then 'off
            '    Dim fmain As New fMain
            '    fmain.Show()
            'Else 'on - run pin check
            '    fPinScreen.Show()
            'End If

            'Application.Run()
        End If


    End Sub


    Public Function WriteToEventLog(ByVal Entry As String, _
         ByVal AppName As String, _
        Optional ByVal EventType As EventLogEntryType = EventLogEntryType.Information, _
         Optional ByVal LogName As String = "Application") As Boolean

        'RETURNS:   True if successful, false if not
        Dim objEventLog As New EventLog
        Try
            objEventLog.Source = AppName

            'WriteEntry is overloaded
            objEventLog.WriteEntry(Entry, EventType)
            Return True
        Catch Ex As Exception
            Return False
        End Try
    End Function

    Public Sub CheckForExistingInstance()
        'Get number of processes of you program
        If Process.GetProcessesByName _
          (Process.GetCurrentProcess.ProcessName).Length > 1 Then

            MessageBox.Show _
             ("Another Instance of this process is already running", _
                 "Multiple Instances Forbidden", _
                  MessageBoxButtons.OK, _
                 MessageBoxIcon.Exclamation)
            Application.Exit()
        End If
    End Sub

End Module
