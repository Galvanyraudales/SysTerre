Public Class frmSplash
    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start() 'iniciar conteo
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 99 Then
            ProgressBar1.Value = ProgressBar1.Value + 3
        Else
            frmAcceso.Show()
            Me.Hide()
            Timer1.Stop() 'detener el conteo
        End If
    End Sub

    Private Sub lblDesarollador_Click(sender As Object, e As EventArgs) Handles lblDesarollador.Click

    End Sub

    Private Sub lblCoppyright_Click(sender As Object, e As EventArgs) Handles lblCoppyright.Click

    End Sub

    Private Sub lblSistema_Click(sender As Object, e As EventArgs) Handles lblSistema.Click

    End Sub

    Private Sub lblVersion_Click(sender As Object, e As EventArgs) Handles lblVersion.Click

    End Sub
End Class
