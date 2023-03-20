Public Class FrmPrincipal
    Dim porcentaje As Double = 1

    Private Sub SalidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidaToolStripMenuItem.Click
        End
    End Sub

    Private Sub AumentarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AumentarToolStripMenuItem.Click
        If (porcentaje = 1) Then
        Else
            porcentaje += 0.01
        End If
        Me.Opacity = porcentaje
        Me.Text = porcentaje
    End Sub

    Private Sub DisminuirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisminuirToolStripMenuItem.Click
        If (porcentaje = 0) Then
        Else
            porcentaje -= 0.01
        End If
        Me.Opacity = porcentaje
        Me.Text = porcentaje
    End Sub
End Class
