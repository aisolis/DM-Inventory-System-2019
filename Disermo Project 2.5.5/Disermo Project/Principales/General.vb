Public Class General
    Private Sub General_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        centro()
    End Sub

    Function centro()
        'FormHijo.Location = New Point((Me.PanelContenedor.Width - FormHijo.Width) / 2, (Me.PanelContenedor.Height - FormHijo.Height) / 2)
        If My.Settings.ConfigPosicionamiento = True Then
            xd.Location = New Point((Me.PanelContenedor.Width - xd.Width) / 2, 0)
            'Ejemplo2.Location = New Point((Me.PanelContenedor.Width - Ejemplo2.Width) / 2, 0)
        ElseIf My.Settings.ConfigPosicionamiento = False Then
            xd.Location = New Point(10, 0)
            'Ejemplo2.Location = New Point(10, 0)
        End If
    End Function

    Private Sub General_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
End Class