Module mTypeCheck
    Public Function CheckInteger(ByVal form As Form) As Boolean

        Dim bIsAnyIntegers As Boolean = False

        'Loop through form to check for integers
        Dim Control As Control
        For Each Control In form.Controls
            If TypeOf Control Is TextBox Then
                If Not IsNumeric(Control.Text) Then
                    bIsAnyIntegers = True
                End If
            End If

        Next Control

        If bIsAnyIntegers = True Then
            Dim popup As New fMsgBox(2, "Integer Error", "You can only use numbers on this form, the program has detected that a letter has been used, please remove this and try again")
            popup.ShowDialog()
        End If

        Return bIsAnyIntegers

    End Function


    Public Function CheckIntegerBox(ByVal tb As TextBox) As Boolean

        Dim bIsAnyIntegers As Boolean = False

        If Not IsNumeric(tb.Text) Then
            bIsAnyIntegers = True
        End If

        If bIsAnyIntegers = True Then
            Dim popup As New fMsgBox(2, "Integer Error", "You can only use numbers on this form, the program has detected that a letter has been used, please remove this and try again")
            popup.ShowDialog()
        End If

        Return bIsAnyIntegers

    End Function
End Module
