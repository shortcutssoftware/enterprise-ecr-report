Module mFade
    Public Sub FadeOut(ByVal form As Form)
        Dim x As Decimal = 0
        Do While form.Opacity > 0.0
            form.Refresh()
            form.Opacity -= 0.1
            For x = 1 To 100000
            Next x
        Loop
    End Sub


    Public Sub FadeOutDialog(ByVal form As Form)
        If bFX = True Then
            Dim x As Decimal = 0
            Do While form.Opacity > 0.0
                form.Refresh()
                form.Opacity -= 0.1
                For x = 1 To 10
                Next x
            Loop
        End If
    End Sub


    Public Sub FadeIn(ByVal form As Form)
        form.Opacity = 0
        Dim x As Decimal = 0
        Do While form.Opacity < 1.0
            form.Refresh()
            form.Opacity += 0.1
            For x = 1 To 100000
            Next x
        Loop
        form.Opacity = 1
        Call form.Activate()
    End Sub


    Public Sub FadeInDialog(ByVal form As Form)
        If bFX = True Then
            form.Opacity = 0
            Dim x As Decimal = 0
            Do While form.Opacity < 1.0
                form.Refresh()
                form.Opacity += 0.1
                For x = 1 To 10
                Next x
            Loop

            form.Opacity = 1
            Call form.Activate()
        End If
    End Sub


End Module