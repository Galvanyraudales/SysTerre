Public Class frmCategoria
    Private Sub CategoriaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CategoriaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CategoriaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Systerre2026__2002_2003_DataSet)

    End Sub

    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Systerre2026__2002_2003_DataSet.categoria' Puede moverla o quitarla según sea necesario.
        Me.CategoriaTableAdapter.Fill(Me._Systerre2026__2002_2003_DataSet.categoria)

    End Sub
End Class