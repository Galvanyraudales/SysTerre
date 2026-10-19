Public Class frmCliente
    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Systerre2026__2002_2003_DataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me._Systerre2026__2002_2003_DataSet.cliente)

    End Sub

    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClienteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Systerre2026__2002_2003_DataSet)

    End Sub

    Private Sub DireccionClienteTextBox_TextChanged(sender As Object, e As EventArgs) Handles DireccionClienteTextBox.TextChanged

    End Sub

    Private Sub DireccionClienteLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class