Public Class frmEmpleado
    Private Sub frmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Systerre2026__2002_2003_DataSet.empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me._Systerre2026__2002_2003_DataSet.empleado)
        'TODO: esta línea de código carga datos en la tabla '_Systerre2026__2002_2003_DataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me._Systerre2026__2002_2003_DataSet.cliente)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClienteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Systerre2026__2002_2003_DataSet)

    End Sub

    Private Sub EmpleadoDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpleadoDataGridView.CellContentClick

    End Sub

    Private Sub NombreEmpleadoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TelefonoEmplTextBox_TextChanged(sender As Object, e As EventArgs) Handles TelefonoEmplTextBox.TextChanged

    End Sub

    Private Sub TelefonoEmplLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NombreEmpleadoTextBox_TextChanged(sender As Object, e As EventArgs) Handles NombreEmpleadoTextBox.TextChanged

    End Sub

    Private Sub Id_usuarioTextBox_TextChanged(sender As Object, e As EventArgs) Handles Id_usuarioTextBox.TextChanged

    End Sub

    Private Sub Id_usuarioLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class