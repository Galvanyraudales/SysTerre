Public Class frmMenuPrincipal
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        End
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        frmCliente.Show()
    End Sub

    Private Sub btnVenta_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        frmVenta.Show()
    End Sub

    Private Sub btnCategoria_Click(sender As Object, e As EventArgs) Handles btnCategoria.Click
        frmCategoria.Show()
    End Sub

    Private Sub btnEmpleado_Click(sender As Object, e As EventArgs) Handles btnEmpleado.Click
        frmEmpleado.Show()
    End Sub

    Private Sub btnFactura_Click(sender As Object, e As EventArgs) Handles btnFactura.Click
        frmFactura.Show()
    End Sub

    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        frmProducto.Show()
    End Sub

    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        frmProveedor.Show()
    End Sub

    Private Sub btnUsuario_Click(sender As Object, e As EventArgs) Handles btnUsuario.Click
        frmUsuario.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalWin.Click
        Process.Start("calc.exe")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnManualT.Click
        Dim rutaPDF As String = "E:\PROGRAMACION1\CUARTO PARCIAL\Systerre 2026.pdf"
        Process.Start(New ProcessStartInfo(rutaPDF))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCalBas.Click

    End Sub

    Private Sub btnReporductor_Click(sender As Object, e As EventArgs) Handles btnReporductor.Click
        Process.Start("wmplayer.exe")
    End Sub

    Private Sub btnNavegador_Click(sender As Object, e As EventArgs) Handles btnNavegador.Click
        Process.Start("https://google.com")
    End Sub

    Private Sub btnManualU_Click(sender As Object, e As EventArgs) Handles btnManualU.Click

    End Sub

    Private Sub frmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class