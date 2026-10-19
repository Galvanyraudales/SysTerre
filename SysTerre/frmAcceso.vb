Public Class frmAcceso
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        End
    End Sub

    Private Sub txtContrasena_TextChanged(sender As Object, e As EventArgs) Handles txtContrasena.TextChanged

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If txtContrasena.Text = "123" Then
            MsgBox("Bienvenido al sistema", vbInformation, "Mensaje")
            Me.Hide()
            frmMenuPrincipal.Show()
        Else
            MsgBox("Contraseña Incorrecta", vbCritical, "Mensaje")
            txtContrasena.Text = ""
            txtContrasena.Focus()

        End If
    End Sub

    Private Sub frmAcceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class