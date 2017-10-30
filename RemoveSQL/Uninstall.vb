Imports System.Data.SqlClient
Imports Microsoft.Win32
Imports System.IO
Imports System.Reflection

Module Module1
    Dim cmInitSQL As New SqlCommand
    Dim Asm As [Assembly] = [Assembly].GetExecutingAssembly() 'Gets the current assembly.
    Dim sLogName As String = "SC Commissions Report" 'For log file writes
    Private m_TargetAssembly As System.Reflection.Assembly

    Sub Main()


        Dim f() As String = System.Environment.GetCommandLineArgs
        Dim sAction As String = f(1).ToLower

        'Get the argument passed during install
        '0 - Install, 1 - Uninstall
        MsgBox(sAction)


        'Dim sServer As String
        'Dim sDatabase As String
        'Dim strContents As String

        'Console.WriteLine("Please Wait: Configuring the Shortcuts Database...")
        'Console.WriteLine("")


        ''Set Keys
        'Try
        '    sServer = CStr(Registry.LocalMachine.OpenSubKey("Software\ShortCuts\Database\ShortcutsPOS").GetValue("Server"))
        '    sDatabase = CStr(Registry.LocalMachine.OpenSubKey("Software\ShortCuts\Database\ShortcutsPOS").GetValue("Database"))
        '    Console.WriteLine("Complete: Windows Registry Update")
        'Catch ex As Exception
        '    Console.WriteLine("ERROR: Windows Registry 'Database' and 'Server' can not be read")
        'End Try

        'Dim con As New SqlConnection("Server=" + sServer + ";Database=" + sDatabase + ";Trusted_Connection=True")
        'con.Open()



        '' Attach the command to the connection
        'cmInitSQL.Connection = con

        '' Set the command type to Text
        'cmInitSQL.CommandType = CommandType.Text



        ''******** Drop sp's ***************
        ''This is the legacy section, this will remove sp's from version 1 that are no longer used
        ''the existing add/remove system should have removed these but this is to ensure a clean db
        'Try

        '    cmInitSQL.CommandText = "IF EXISTS (SELECT 'usp_BIComReportWriteKeyInt' FROM sysobjects WHERE  [name] = 'usp_BIComReportWriteKeyInt' AND type = 'P') DROP PROCEDURE usp_BIComReportWriteKeyInt"
        '    cmInitSQL.ExecuteNonQuery()

        '    cmInitSQL.CommandText = "IF EXISTS (SELECT 'usp_BIComReportWriteKeyString' FROM sysobjects WHERE  [name] = 'usp_BIComReportWriteKeyString' AND type = 'P') DROP PROCEDURE usp_BIComReportWriteKeyString"
        '    cmInitSQL.ExecuteNonQuery()

        '    cmInitSQL.CommandText = "IF EXISTS (SELECT 'usp_BIComReportReadKeyInt' FROM sysobjects WHERE  [name] = 'usp_BIComReportReadKeyInt' AND type = 'P') DROP PROCEDURE usp_BIComReportReadKeyInt"
        '    cmInitSQL.ExecuteNonQuery()

        '    cmInitSQL.CommandText = "IF EXISTS (SELECT 'usp_BIComReportReadKeyString' FROM sysobjects WHERE  [name] = 'usp_BIComReportReadKeyString' AND type = 'P') DROP PROCEDURE usp_BIComReportReadKeyString"
        '    cmInitSQL.ExecuteNonQuery()

        '    cmInitSQL.CommandText = "IF EXISTS (SELECT 'usp_BIComReportGetServicePrice' FROM sysobjects WHERE  [name] = 'usp_BIComReportGetServicePrice' AND type = 'P') DROP PROCEDURE usp_BIComReportGetServicePrice"
        '    cmInitSQL.ExecuteNonQuery()

        '    cmInitSQL.CommandText = "IF EXISTS (SELECT 'fn_GetCommission' FROM sysobjects WHERE [name] = 'fn_GetCommission') DROP FUNCTION fn_GetCommission"
        '    cmInitSQL.ExecuteNonQuery()

        '    Console.WriteLine("Complete: Legacy Drop USP")
        'Catch ex As Exception
        '    WriteToEventLog("ERROR: Dropping: " & vbNewLine & "VB Error = " & ex.Message, sLogName, EventLogEntryType.Error)
        '    MsgBox("Error - " & vbNewLine & vbNewLine & ex.Message.ToString)
        'End Try



        ''******** Drop all sp's ***************
        'Dim sScripts() As String
        'Dim iInteger As Integer = 0

        'm_TargetAssembly = System.Reflection.Assembly.GetExecutingAssembly

        ''Loop through all of the embedded object.
        ''Note - all embedded objects must have the same name as the object being installed
        'For Each str As String In m_TargetAssembly.GetManifestResourceNames()
        '    If str.EndsWith(".sql") Then
        '        iInteger = iInteger + 1
        '        ReDim Preserve sScripts(iInteger)
        '        sScripts(iInteger) = str
        '    End If
        'Next str

        'sScripts.Sort(sScripts) 'So can order which are run first by numbering

        'Dim i As Short
        'For i = 1 To UBound(sScripts)
        '    Uninstall(sScripts(i))
        'Next

        'Console.WriteLine("")
        'Console.WriteLine(".....Database setup complete")
        ''**********************************************


    End Sub


    Private Sub Uninstall(ByVal name As String)

        'First begin by dropping any existing ones that are there or else the create statements will crash
        Dim sTrimName As String 'For use below

        Try
            '##################### Stored Procedure Removal (with prefiv usp_) #####################
            If InStr(name, "usp_") And name.Replace(Asm.GetName().Name + ".", "").Replace(".sql", "").StartsWith("usp_") Then
                'Normal path for regular stored procedures
                sTrimName = name.Replace(Asm.GetName().Name + ".", "").Replace(".sql", "")
                cmInitSQL.CommandText = "IF EXISTS (SELECT '" & sTrimName & "' FROM sysobjects WHERE  [name] = '" & sTrimName & "' AND type = 'P') DROP PROCEDURE " & sTrimName
                cmInitSQL.ExecuteNonQuery()
            ElseIf name.Replace(Asm.GetName().Name + ".", "").Remove(0, 3).Replace(".sql", "").StartsWith("usp_") Then
                'If there is a 3 digit number in front for ordering
                sTrimName = name.Replace(Asm.GetName().Name + ".", "").Remove(0, 3).Replace(".sql", "")
                cmInitSQL.CommandText = "IF EXISTS (SELECT '" & sTrimName & "' FROM sysobjects WHERE  [name] = '" & sTrimName & "' AND type = 'P') DROP PROCEDURE " & sTrimName
                cmInitSQL.ExecuteNonQuery()
                '##################### View Removal (with prefiv view_) #####################
            ElseIf InStr(name, "view_") And name.Replace(Asm.GetName().Name + ".", "").Replace(".sql", "").StartsWith("view_") Then
                'If its a regular view
                sTrimName = name.Replace(Asm.GetName().Name + ".", "").Replace(".sql", "")
                cmInitSQL.CommandText = "IF EXISTS (SELECT '" & sTrimName & "' FROM sysobjects WHERE  [name] = '" & sTrimName & "' AND type = 'V') DROP PROCEDURE " & sTrimName
                cmInitSQL.ExecuteNonQuery()
            ElseIf name.Replace(Asm.GetName().Name + ".", "").Remove(0, 3).Replace(".sql", "").StartsWith("view_") Then
                'If its a priority view (3 digit number in front for ordering)
                sTrimName = name.Replace(Asm.GetName().Name + ".", "").Remove(0, 3).Replace(".sql", "")
                cmInitSQL.CommandText = "IF EXISTS (SELECT '" & sTrimName & "' FROM sysobjects WHERE  [name] = '" & sTrimName & "' AND type = 'V') DROP PROCEDURE " & sTrimName
                cmInitSQL.ExecuteNonQuery()
                '##################### UFD Removal (with prefix udf_)  #####################
            ElseIf InStr(name, "udf_") And name.Replace(Asm.GetName().Name + ".", "").Replace(".sql", "").StartsWith("udf_") Then
                'If its a regular udf
                sTrimName = name.Replace(Asm.GetName().Name + ".", "").Replace(".sql", "")
                cmInitSQL.CommandText = "IF EXISTS (SELECT '" & sTrimName & "' FROM sysobjects WHERE  [name] = '" & sTrimName & "' AND type = 'FN') DROP PROCEDURE " & sTrimName
                cmInitSQL.ExecuteNonQuery()
            ElseIf name.Replace(Asm.GetName().Name + ".", "").Remove(0, 3).Replace(".sql", "").StartsWith("udf_") Then
                'If its a priority udf (3 digit number in front for ordering)
                sTrimName = name.Replace(Asm.GetName().Name + ".", "").Remove(0, 3).Replace(".sql", "")
                cmInitSQL.CommandText = "IF EXISTS (SELECT '" & sTrimName & "' FROM sysobjects WHERE  [name] = '" & sTrimName & "' AND type = 'FN') DROP PROCEDURE " & sTrimName
                cmInitSQL.ExecuteNonQuery()
            End If
        Catch ex As Exception
            WriteToEventLog("ERROR: " & name & vbNewLine & "VB Error = " & ex.Message, sLogName, EventLogEntryType.Error)
            MsgBox("ERROR Dropping- " & name & vbNewLine & vbNewLine & ex.ToString)
        End Try

    End Sub



    Public Function WriteToEventLog(ByVal Entry As String, _
          Optional ByVal AppName As String = "SC Commissions Report", _
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
