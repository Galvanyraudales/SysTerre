<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFactura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Id_facturaLabel As System.Windows.Forms.Label
        Dim FechafacturaLabel As System.Windows.Forms.Label
        Dim Id_usuarioLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFactura))
        Me._Systerre2026__2002_2003_DataSet = New SysTerre._Systerre2026__2002_2003_DataSet()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New SysTerre._Systerre2026__2002_2003_DataSetTableAdapters.clienteTableAdapter()
        Me.TableAdapterManager = New SysTerre._Systerre2026__2002_2003_DataSetTableAdapters.TableAdapterManager()
        Me.FacturaTableAdapter = New SysTerre._Systerre2026__2002_2003_DataSetTableAdapters.facturaTableAdapter()
        Me.ClienteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClienteBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_facturaTextBox = New System.Windows.Forms.TextBox()
        Me.FechafacturaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Id_usuarioTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Id_facturaLabel = New System.Windows.Forms.Label()
        FechafacturaLabel = New System.Windows.Forms.Label()
        Id_usuarioLabel = New System.Windows.Forms.Label()
        CType(Me._Systerre2026__2002_2003_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClienteBindingNavigator.SuspendLayout()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_facturaLabel
        '
        Id_facturaLabel.AutoSize = True
        Id_facturaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_facturaLabel.Location = New System.Drawing.Point(110, 180)
        Id_facturaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_facturaLabel.Name = "Id_facturaLabel"
        Id_facturaLabel.Size = New System.Drawing.Size(95, 20)
        Id_facturaLabel.TabIndex = 4
        Id_facturaLabel.Text = "Id factura:"
        '
        'FechafacturaLabel
        '
        FechafacturaLabel.AutoSize = True
        FechafacturaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechafacturaLabel.Location = New System.Drawing.Point(87, 222)
        FechafacturaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FechafacturaLabel.Name = "FechafacturaLabel"
        FechafacturaLabel.Size = New System.Drawing.Size(120, 20)
        FechafacturaLabel.TabIndex = 6
        FechafacturaLabel.Text = "fechafactura:"
        '
        'Id_usuarioLabel
        '
        Id_usuarioLabel.AutoSize = True
        Id_usuarioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_usuarioLabel.Location = New System.Drawing.Point(646, 185)
        Id_usuarioLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_usuarioLabel.Name = "Id_usuarioLabel"
        Id_usuarioLabel.Size = New System.Drawing.Size(98, 20)
        Id_usuarioLabel.TabIndex = 8
        Id_usuarioLabel.Text = "Id usuario:"
        '
        '_Systerre2026__2002_2003_DataSet
        '
        Me._Systerre2026__2002_2003_DataSet.DataSetName = "_Systerre2026__2002_2003_DataSet"
        Me._Systerre2026__2002_2003_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me._Systerre2026__2002_2003_DataSet
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriaTableAdapter = Nothing
        Me.TableAdapterManager.clienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.empleadoTableAdapter = Nothing
        Me.TableAdapterManager.facturaTableAdapter = Me.FacturaTableAdapter
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SysTerre._Systerre2026__2002_2003_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        Me.TableAdapterManager.ventaTableAdapter = Nothing
        '
        'FacturaTableAdapter
        '
        Me.FacturaTableAdapter.ClearBeforeFill = True
        '
        'ClienteBindingNavigator
        '
        Me.ClienteBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClienteBindingNavigator.BindingSource = Me.ClienteBindingSource
        Me.ClienteBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClienteBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClienteBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ClienteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClienteBindingNavigatorSaveItem})
        Me.ClienteBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClienteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClienteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClienteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClienteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClienteBindingNavigator.Name = "ClienteBindingNavigator"
        Me.ClienteBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.ClienteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClienteBindingNavigator.Size = New System.Drawing.Size(1082, 33)
        Me.ClienteBindingNavigator.TabIndex = 0
        Me.ClienteBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(57, 28)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(73, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'ClienteBindingNavigatorSaveItem
        '
        Me.ClienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClienteBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClienteBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClienteBindingNavigatorSaveItem.Name = "ClienteBindingNavigatorSaveItem"
        Me.ClienteBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 28)
        Me.ClienteBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'FacturaBindingSource
        '
        Me.FacturaBindingSource.DataMember = "factura"
        Me.FacturaBindingSource.DataSource = Me._Systerre2026__2002_2003_DataSet
        '
        'FacturaDataGridView
        '
        Me.FacturaDataGridView.AutoGenerateColumns = False
        Me.FacturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.FacturaDataGridView.DataSource = Me.FacturaBindingSource
        Me.FacturaDataGridView.Location = New System.Drawing.Point(316, 354)
        Me.FacturaDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FacturaDataGridView.Name = "FacturaDataGridView"
        Me.FacturaDataGridView.RowHeadersWidth = 62
        Me.FacturaDataGridView.Size = New System.Drawing.Size(537, 202)
        Me.FacturaDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Id_factura"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Id_factura"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "fechafactura"
        Me.DataGridViewTextBoxColumn7.HeaderText = "fechafactura"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Id_usuario"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Id_usuario"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'Id_facturaTextBox
        '
        Me.Id_facturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "Id_factura", True))
        Me.Id_facturaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_facturaTextBox.Location = New System.Drawing.Point(218, 175)
        Me.Id_facturaTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Id_facturaTextBox.Name = "Id_facturaTextBox"
        Me.Id_facturaTextBox.Size = New System.Drawing.Size(148, 26)
        Me.Id_facturaTextBox.TabIndex = 5
        '
        'FechafacturaDateTimePicker
        '
        Me.FechafacturaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FacturaBindingSource, "fechafactura", True))
        Me.FechafacturaDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechafacturaDateTimePicker.Location = New System.Drawing.Point(218, 215)
        Me.FechafacturaDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FechafacturaDateTimePicker.Name = "FechafacturaDateTimePicker"
        Me.FechafacturaDateTimePicker.Size = New System.Drawing.Size(298, 26)
        Me.FechafacturaDateTimePicker.TabIndex = 7
        '
        'Id_usuarioTextBox
        '
        Me.Id_usuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "Id_usuario", True))
        Me.Id_usuarioTextBox.Location = New System.Drawing.Point(756, 180)
        Me.Id_usuarioTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Id_usuarioTextBox.Name = "Id_usuarioTextBox"
        Me.Id_usuarioTextBox.Size = New System.Drawing.Size(148, 26)
        Me.Id_usuarioTextBox.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(414, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 40)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Tabla: Factura"
        '
        'frmFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1082, 587)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Id_usuarioLabel)
        Me.Controls.Add(Me.Id_usuarioTextBox)
        Me.Controls.Add(FechafacturaLabel)
        Me.Controls.Add(Me.FechafacturaDateTimePicker)
        Me.Controls.Add(Id_facturaLabel)
        Me.Controls.Add(Me.Id_facturaTextBox)
        Me.Controls.Add(Me.FacturaDataGridView)
        Me.Controls.Add(Me.ClienteBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmFactura"
        Me.Text = "Form2"
        CType(Me._Systerre2026__2002_2003_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClienteBindingNavigator.ResumeLayout(False)
        Me.ClienteBindingNavigator.PerformLayout()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _Systerre2026__2002_2003_DataSet As _Systerre2026__2002_2003_DataSet
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As _Systerre2026__2002_2003_DataSetTableAdapters.clienteTableAdapter
    Friend WithEvents TableAdapterManager As _Systerre2026__2002_2003_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClienteBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ClienteBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FacturaTableAdapter As _Systerre2026__2002_2003_DataSetTableAdapters.facturaTableAdapter
    Friend WithEvents FacturaBindingSource As BindingSource
    Friend WithEvents FacturaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Id_facturaTextBox As TextBox
    Friend WithEvents FechafacturaDateTimePicker As DateTimePicker
    Friend WithEvents Id_usuarioTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
