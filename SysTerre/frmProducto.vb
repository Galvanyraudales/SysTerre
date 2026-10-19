Public Class frmProducto
    Private Sub ProductoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Systerre2026__2002_2003_DataSet)

    End Sub

    Private Sub frmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Systerre2026__2002_2003_DataSet.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me._Systerre2026__2002_2003_DataSet.producto)

    End Sub
End Class