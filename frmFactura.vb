Public Class frmFactura
    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClienteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Systerre2026__2002_2003_DataSet)

    End Sub

    Private Sub frmFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Systerre2026__2002_2003_DataSet.factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter.Fill(Me._Systerre2026__2002_2003_DataSet.factura)
        'TODO: esta línea de código carga datos en la tabla '_Systerre2026__2002_2003_DataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me._Systerre2026__2002_2003_DataSet.cliente)

    End Sub
End Class