Public Class frmProveedor
    Private Sub ProveedorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProveedorBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProveedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Systerre2026__2002_2003_DataSet)

    End Sub

    Private Sub frmProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Systerre2026__2002_2003_DataSet.proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me._Systerre2026__2002_2003_DataSet.proveedor)

    End Sub
End Class