Module Module1

    Sub Main()
        If Not EventLog.SourceExists("SC Commissions Report") Then
            EventLog.CreateEventSource("SC Commissions Report", "Application")
        End If

        WriteToEventLog("Log Created", "SC Commissions Report", EventLogEntryType.Information)

    End Sub


    Public Function WriteToEventLog(ByVal Entry As String, _
         Optional ByVal AppName As String = "SC Commissions Report", _
         Optional ByVal EventType As EventLogEntryType = EventLogEntryType.Information, _
         Optional ByVal LogName As String = "Application") As Boolean

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
