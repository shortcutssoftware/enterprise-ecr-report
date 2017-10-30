Imports System.Data.SqlClient
Imports Microsoft.Win32
Imports System.IO
Imports System.Reflection



Module Module1

    Dim sLogName As String = "SC Commissions Report" 'For log file writes
    Dim sServer As String 'Server Name
    Dim sDatabase As String 'Database Name
    Dim strContents As String 'what is read from the SQL files
    Dim Asm As [Assembly] = [Assembly].GetExecutingAssembly() 'Gets the current assembly.
    Dim cmInitSQL As New SqlCommand  'Instantiate Command Object to execute SQL Statements
    Private m_TargetAssembly As System.Reflection.Assembly
    Dim valDebug As Boolean = True


    Sub Main()

        'Get the argument passed during install to process request
        '0 - Install, 1 - Uninstall

        Dim f() As String = System.Environment.GetCommandLineArgs
        Dim sAction As String = f(1).ToLower


        'Check for the existance of a pointer to a test database
        sDatabase = CStr(Registry.LocalMachine.OpenSubKey("Software\ShortCuts\Database\ShortcutsPOS").GetValue("BIAdminDatabase"))

        WriteToEventLog("Database Install Started", sLogName, EventLogEntryType.Information)
        Console.WriteLine("Please Wait: Configuring the Shortcuts Database...")
        Console.WriteLine("")


        '******** Set Keys ***************

        Try
            sServer = CStr(Registry.LocalMachine.OpenSubKey("Software\ShortCuts\Database\ShortcutsPOS").GetValue("Server"))
            If sDatabase = Nothing Then
                sDatabase = CStr(Registry.LocalMachine.OpenSubKey("Software\ShortCuts\Database\ShortcutsPOS").GetValue("Database"))
            End If
            If valDebug = True Then
                Console.WriteLine("DEBUG: sServer = " + sServer)
                Console.WriteLine("DEBUG: sDatabase = " + sDatabase)
            End If
            WriteToEventLog("Server=" + sServer + ";Database=" + sDatabase + ";Trusted_Connection=True", sLogName, EventLogEntryType.Information)
        Catch ex As Exception
            Console.WriteLine("ERROR: Windows Registry 'Database' and 'Server' can not be read")
            WriteToEventLog("ERROR: Windows Registry 'Database' and 'Server' can not be read" & vbNewLine & "VB Error = " & ex.Message, sLogName, EventLogEntryType.Error)
        End Try




        Try
            Dim con As New SqlConnection("Server=" + sServer + ";Database=" + sDatabase + ";Trusted_Connection=True")
            con.Open()
            cmInitSQL.Connection = con ' Attach the command to the connection
            cmInitSQL.CommandType = CommandType.Text  ' Set the command type to Text
            Console.WriteLine("SQL Connection Open")
        Catch ex As Exception
            Console.WriteLine("ERROR: connecting to the SQL server, please check that the server is online !!!!!!!")
            WriteToEventLog("ERROR: connecting to the SQL server: " & vbNewLine & "VB Error = " & ex.Message, sLogName, EventLogEntryType.Error)
        End Try
        '**********************************************


        ''Make Sure old report is being deleted!
        ''Possible bug by Rich Ack 16/04/10
        'My.Computer.FileSystem.DeleteFile("C:\Program Files\Shortcuts Software\Point Of Sale\Reports\ExtendedCommReport.rpt")
        'My.Computer.FileSystem.DeleteFile("C:\Program Files\Shortcuts Software\Point Of Sale\Reports-Custom\ExtendedCommReport.rpt")



        '******** Drop Legacy sp's ***************
        'This is the legacy section, this will remove sp's from version 1 that are no longer used
        'the existing add/remove system should have removed these but this is to ensure a clean db
        Try
            cmInitSQL.CommandText = "IF EXISTS (SELECT 'usp_BIComReportWriteKeyInt' FROM sysobjects WHERE  [name] = 'usp_BIComReportWriteKeyInt' AND type = 'P') DROP PROCEDURE usp_BIComReportWriteKeyInt"
            cmInitSQL.ExecuteNonQuery()

            cmInitSQL.CommandText = "IF EXISTS (SELECT 'usp_BIComReportWriteKeyString' FROM sysobjects WHERE  [name] = 'usp_BIComReportWriteKeyString' AND type = 'P') DROP PROCEDURE usp_BIComReportWriteKeyString"
            cmInitSQL.ExecuteNonQuery()

            cmInitSQL.CommandText = "IF EXISTS (SELECT 'usp_BIComReportReadKeyInt' FROM sysobjects WHERE  [name] = 'usp_BIComReportReadKeyInt' AND type = 'P') DROP PROCEDURE usp_BIComReportReadKeyInt"
            cmInitSQL.ExecuteNonQuery()

            cmInitSQL.CommandText = "IF EXISTS (SELECT 'usp_BIComReportReadKeyString' FROM sysobjects WHERE  [name] = 'usp_BIComReportReadKeyString' AND type = 'P') DROP PROCEDURE usp_BIComReportReadKeyString"
            cmInitSQL.ExecuteNonQuery()

            cmInitSQL.CommandText = "IF EXISTS (SELECT 'usp_BIComReportGetServicePrice' FROM sysobjects WHERE  [name] = 'usp_BIComReportGetServicePrice' AND type = 'P') DROP PROCEDURE usp_BIComReportGetServicePrice"
            cmInitSQL.ExecuteNonQuery()

            cmInitSQL.CommandText = "IF EXISTS (SELECT 'fn_GetCommission' FROM sysobjects WHERE [name] = 'fn_GetCommission') DROP FUNCTION fn_GetCommission"
            cmInitSQL.ExecuteNonQuery()

            Console.WriteLine("Complete: Legacy Drop USP")
        Catch ex As Exception
            WriteToEventLog("ERROR: Dropping: " & vbNewLine & "VB Error = " & ex.Message, sLogName, EventLogEntryType.Error)
            MsgBox("Error - " & vbNewLine & vbNewLine & ex.Message.ToString)
        End Try
        '**********************************************


        '******** Process SP's from Scripts ***************
        Dim sScripts() As String
        Dim iInteger As Integer = 0

        m_TargetAssembly = System.Reflection.Assembly.GetExecutingAssembly

        'Loop through all of the embedded object.
        'Note - all embedded objects must have the same name as the object being installed
        For Each str As String In m_TargetAssembly.GetManifestResourceNames()
            If str.EndsWith(".sql") Then
                iInteger = iInteger + 1
                ReDim Preserve sScripts(iInteger)
                sScripts(iInteger) = str
            End If
        Next str

        sScripts.Sort(sScripts) 'So can order which are run first by numbering

        Dim i As Short
        For i = 1 To UBound(sScripts)
            'Always remove all scripts first
            RemoveSP(sScripts(i))
            If sAction = 0 Then 'If installing then go on to install each one
                InstallSP(sScripts(i))
            End If
        Next


        Try
            If sAction = 1 Then 'If uninstalling then go on to install each one
                Dim reportid As Object

                cmInitSQL.CommandText = "SELECT [Id Number] FROM REPORTS WHERE [FILENAME] = 'ExtendedCommReport'"
                cmInitSQL.CommandType = CommandType.Text
                reportid = cmInitSQL.ExecuteScalar()

                cmInitSQL.CommandText = "DELETE FROM SecurityAccessItem WHERE EntityTypeCode = 33 AND EntityId = " + reportid.ToString()
                cmInitSQL.ExecuteNonQuery()
                cmInitSQL.CommandText = "DELETE FROM REPORTS WHERE [FILENAME] = 'ExtendedCommReport'"
                cmInitSQL.ExecuteNonQuery()
                WriteToEventLog("Report Removed", sLogName, EventLogEntryType.Information)
            End If
        Catch ex As Exception
            WriteToEventLog("ERROR: Removing Report: " & vbNewLine & "VB Error = " & ex.Message, sLogName, EventLogEntryType.Error)
        End Try

        Console.WriteLine("")
        Console.WriteLine(".....Database setup complete")
        '**********************************************

        WriteToEventLog("Database Install Complete", sLogName, EventLogEntryType.Information)

    End Sub


    Private Sub RemoveSP(ByVal Name As String)
        'First begin by dropping any existing ones that are there or else the create statements will crash
        Dim sTrimName As String 'For use below

        Try
            '##################### Stored Procedure Removal (with prefiv usp_) #####################
            If InStr(Name, "usp_") And Name.Replace(Asm.GetName().Name + ".", "").Replace(".sql", "").StartsWith("usp_") Then
                'Normal path for regular stored procedures
                sTrimName = Name.Replace(Asm.GetName().Name + ".", "").Replace(".sql", "")
                cmInitSQL.CommandText = "IF EXISTS (SELECT '" & sTrimName & "' FROM sysobjects WHERE  [name] = '" & sTrimName & "' AND type = 'P') DROP PROCEDURE " & sTrimName
                cmInitSQL.ExecuteNonQuery()
                WriteToEventLog("DROPPED: " & Name, sLogName, EventLogEntryType.Information)
            ElseIf Name.Replace(Asm.GetName().Name + ".", "").Remove(0, 3).Replace(".sql", "").StartsWith("usp_") Then
                'If there is a 3 digit number in front for ordering
                sTrimName = Name.Replace(Asm.GetName().Name + ".", "").Remove(0, 3).Replace(".sql", "")
                cmInitSQL.CommandText = "IF EXISTS (SELECT '" & sTrimName & "' FROM sysobjects WHERE  [name] = '" & sTrimName & "' AND type = 'P') DROP PROCEDURE " & sTrimName
                cmInitSQL.ExecuteNonQuery()
                WriteToEventLog("DROPPED: " & Name, sLogName, EventLogEntryType.Information)
                '##################### View Removal (with prefiv view_) #####################
            ElseIf InStr(Name, "view_") And Name.Replace(Asm.GetName().Name + ".", "").Replace(".sql", "").StartsWith("view_") Then
                'If its a regular view
                sTrimName = Name.Replace(Asm.GetName().Name + ".", "").Replace(".sql", "")
                cmInitSQL.CommandText = "IF EXISTS (SELECT '" & sTrimName & "' FROM sysobjects WHERE  [name] = '" & sTrimName & "' AND type = 'V') DROP VIEW " & sTrimName
                cmInitSQL.ExecuteNonQuery()
                WriteToEventLog("DROPPED: " & Name, sLogName, EventLogEntryType.Information)
            ElseIf Name.Replace(Asm.GetName().Name + ".", "").Remove(0, 3).Replace(".sql", "").StartsWith("view_") Then
                'If its a priority view (3 digit number in front for ordering)
                sTrimName = Name.Replace(Asm.GetName().Name + ".", "").Remove(0, 3).Replace(".sql", "")
                cmInitSQL.CommandText = "IF EXISTS (SELECT '" & sTrimName & "' FROM sysobjects WHERE  [name] = '" & sTrimName & "' AND type = 'V') DROP VIEW " & sTrimName
                cmInitSQL.ExecuteNonQuery()
                WriteToEventLog("DROPPED: " & Name, sLogName, EventLogEntryType.Information)
                '##################### UFD Removal (with prefix udf_)  #####################
            ElseIf InStr(Name, "udf_") And Name.Replace(Asm.GetName().Name + ".", "").Replace(".sql", "").StartsWith("udf_") Then
                'If its a regular udf
                sTrimName = Name.Replace(Asm.GetName().Name + ".", "").Replace(".sql", "")
                cmInitSQL.CommandText = "IF EXISTS (SELECT '" & sTrimName & "' FROM sysobjects WHERE  [name] = '" & sTrimName & "' AND type = 'FN') DROP FUNCTION " & sTrimName
                cmInitSQL.ExecuteNonQuery()
                WriteToEventLog("DROPPED: " & Name, sLogName, EventLogEntryType.Information)
            ElseIf Name.Replace(Asm.GetName().Name + ".", "").Remove(0, 3).Replace(".sql", "").StartsWith("udf_") Then
                'If its a priority udf (3 digit number in front for ordering)
                sTrimName = Name.Replace(Asm.GetName().Name + ".", "").Remove(0, 3).Replace(".sql", "")
                cmInitSQL.CommandText = "IF EXISTS (SELECT '" & sTrimName & "' FROM sysobjects WHERE  [name] = '" & sTrimName & "' AND type = 'FN') DROP FUNTION " & sTrimName
                cmInitSQL.ExecuteNonQuery()
                WriteToEventLog("DROPPED: " & Name, sLogName, EventLogEntryType.Information)
            End If
        Catch ex As Exception
            WriteToEventLog("ERROR: " & Name & vbNewLine & "VB Error = " & ex.Message, sLogName, EventLogEntryType.Error)
            MsgBox("ERROR Dropping- " & Name & vbNewLine & vbNewLine & ex.ToString)
        End Try
    End Sub

    Private Sub InstallSP(ByVal Name As String)
        Try
            ' Resources are named using a fully qualified name.
            Dim strm As Stream = Asm.GetManifestResourceStream(Name)
            Dim reader As StreamReader = New StreamReader(strm) ' Reads the contents of the embedded file.
            strContents = reader.ReadToEnd()
            reader.Close()
            cmInitSQL.CommandText = strContents
            cmInitSQL.ExecuteNonQuery()
            strContents = Nothing 'Just to make sure
            WriteToEventLog("INSTALL: " & Name, sLogName, EventLogEntryType.Information)
            Console.WriteLine("Complete: " + Name)
        Catch ex As Exception
            WriteToEventLog("ERROR: " & Name & vbNewLine & "VB Error = " & ex.Message, sLogName, EventLogEntryType.Error)
            MsgBox("ERROR - " & Name & vbNewLine & vbNewLine & ex.ToString)
        End Try
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
End Module
