Public Class frmVenta
    Private Sub VentaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VentaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VentaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Systerre2026__2002_2003_DataSet)

    End Sub

    Private Sub frmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Systerre2026__2002_2003_DataSet.venta' Puede moverla o quitarla según sea necesario.
        Me.VentaTableAdapter.Fill(Me._Systerre2026__2002_2003_DataSet.venta)

    End Sub

    Private Sub Id_productoTextBox_TextChanged(sender As Object, e As EventArgs) Handles Id_productoTextBox.TextChanged

    End Sub

    Private Sub Id_productoLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class