<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenta
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
        Dim Id_ventaLabel As System.Windows.Forms.Label
        Dim Id_facturaLabel As System.Windows.Forms.Label
        Dim Id_productoLabel As System.Windows.Forms.Label
        Dim CantidadVentaLabel As System.Windows.Forms.Label
        Dim Id_empleadoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenta))
        Me._Systerre2026__2002_2003_DataSet = New SysTerre._Systerre2026__2002_2003_DataSet()
        Me.VentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentaTableAdapter = New SysTerre._Systerre2026__2002_2003_DataSetTableAdapters.ventaTableAdapter()
        Me.TableAdapterManager = New SysTerre._Systerre2026__2002_2003_DataSetTableAdapters.TableAdapterManager()
        Me.VentaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.VentaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.VentaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_ventaTextBox = New System.Windows.Forms.TextBox()
        Me.Id_facturaTextBox = New System.Windows.Forms.TextBox()
        Me.Id_productoTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadVentaTextBox = New System.Windows.Forms.TextBox()
        Me.Id_empleadoTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Id_ventaLabel = New System.Windows.Forms.Label()
        Id_facturaLabel = New System.Windows.Forms.Label()
        Id_productoLabel = New System.Windows.Forms.Label()
        CantidadVentaLabel = New System.Windows.Forms.Label()
        Id_empleadoLabel = New System.Windows.Forms.Label()
        CType(Me._Systerre2026__2002_2003_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VentaBindingNavigator.SuspendLayout()
        CType(Me.VentaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_ventaLabel
        '
        Id_ventaLabel.AutoSize = True
        Id_ventaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_ventaLabel.Location = New System.Drawing.Point(230, 186)
        Id_ventaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_ventaLabel.Name = "Id_ventaLabel"
        Id_ventaLabel.Size = New System.Drawing.Size(81, 20)
        Id_ventaLabel.TabIndex = 2
        Id_ventaLabel.Text = "Id venta:"
        '
        'Id_facturaLabel
        '
        Id_facturaLabel.AutoSize = True
        Id_facturaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_facturaLabel.Location = New System.Drawing.Point(220, 226)
        Id_facturaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_facturaLabel.Name = "Id_facturaLabel"
        Id_facturaLabel.Size = New System.Drawing.Size(95, 20)
        Id_facturaLabel.TabIndex = 4
        Id_facturaLabel.Text = "Id factura:"
        '
        'Id_productoLabel
        '
        Id_productoLabel.AutoSize = True
        Id_productoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_productoLabel.Location = New System.Drawing.Point(207, 266)
        Id_productoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_productoLabel.Name = "Id_productoLabel"
        Id_productoLabel.Size = New System.Drawing.Size(109, 20)
        Id_productoLabel.TabIndex = 6
        Id_productoLabel.Text = "Id producto:"
        AddHandler Id_productoLabel.Click, AddressOf Me.Id_productoLabel_Click
        '
        'CantidadVentaLabel
        '
        CantidadVentaLabel.AutoSize = True
        CantidadVentaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CantidadVentaLabel.Location = New System.Drawing.Point(534, 186)
        CantidadVentaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CantidadVentaLabel.Name = "CantidadVentaLabel"
        CantidadVentaLabel.Size = New System.Drawing.Size(140, 20)
        CantidadVentaLabel.TabIndex = 8
        CantidadVentaLabel.Text = "cantidad Venta:"
        '
        'Id_empleadoLabel
        '
        Id_empleadoLabel.AutoSize = True
        Id_empleadoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_empleadoLabel.Location = New System.Drawing.Point(555, 226)
        Id_empleadoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_empleadoLabel.Name = "Id_empleadoLabel"
        Id_empleadoLabel.Size = New System.Drawing.Size(116, 20)
        Id_empleadoLabel.TabIndex = 10
        Id_empleadoLabel.Text = "Id empleado:"
        '
        '_Systerre2026__2002_2003_DataSet
        '
        Me._Systerre2026__2002_2003_DataSet.DataSetName = "_Systerre2026__2002_2003_DataSet"
        Me._Systerre2026__2002_2003_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentaBindingSource
        '
        Me.VentaBindingSource.DataMember = "venta"
        Me.VentaBindingSource.DataSource = Me._Systerre2026__2002_2003_DataSet
        '
        'VentaTableAdapter
        '
        Me.VentaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriaTableAdapter = Nothing
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.empleadoTableAdapter = Nothing
        Me.TableAdapterManager.facturaTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SysTerre._Systerre2026__2002_2003_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        Me.TableAdapterManager.ventaTableAdapter = Me.VentaTableAdapter
        '
        'VentaBindingNavigator
        '
        Me.VentaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VentaBindingNavigator.BindingSource = Me.VentaBindingSource
        Me.VentaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VentaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VentaBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.VentaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VentaBindingNavigatorSaveItem})
        Me.VentaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VentaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VentaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VentaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VentaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VentaBindingNavigator.Name = "VentaBindingNavigator"
        Me.VentaBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.VentaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VentaBindingNavigator.Size = New System.Drawing.Size(1160, 33)
        Me.VentaBindingNavigator.TabIndex = 0
        Me.VentaBindingNavigator.Text = "BindingNavigator1"
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
        'VentaBindingNavigatorSaveItem
        '
        Me.VentaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VentaBindingNavigatorSaveItem.Image = CType(resources.GetObject("VentaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VentaBindingNavigatorSaveItem.Name = "VentaBindingNavigatorSaveItem"
        Me.VentaBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 28)
        Me.VentaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'VentaDataGridView
        '
        Me.VentaDataGridView.AutoGenerateColumns = False
        Me.VentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.VentaDataGridView.DataSource = Me.VentaBindingSource
        Me.VentaDataGridView.Location = New System.Drawing.Point(190, 328)
        Me.VentaDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.VentaDataGridView.Name = "VentaDataGridView"
        Me.VentaDataGridView.RowHeadersWidth = 62
        Me.VentaDataGridView.Size = New System.Drawing.Size(816, 338)
        Me.VentaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_venta"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_venta"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Id_factura"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id_factura"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Id_producto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Id_producto"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cantidadVenta"
        Me.DataGridViewTextBoxColumn4.HeaderText = "cantidadVenta"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Id_empleado"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Id_empleado"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'Id_ventaTextBox
        '
        Me.Id_ventaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "Id_venta", True))
        Me.Id_ventaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_ventaTextBox.Location = New System.Drawing.Point(316, 182)
        Me.Id_ventaTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Id_ventaTextBox.Name = "Id_ventaTextBox"
        Me.Id_ventaTextBox.Size = New System.Drawing.Size(148, 26)
        Me.Id_ventaTextBox.TabIndex = 3
        '
        'Id_facturaTextBox
        '
        Me.Id_facturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "Id_factura", True))
        Me.Id_facturaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_facturaTextBox.Location = New System.Drawing.Point(316, 222)
        Me.Id_facturaTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Id_facturaTextBox.Name = "Id_facturaTextBox"
        Me.Id_facturaTextBox.Size = New System.Drawing.Size(148, 26)
        Me.Id_facturaTextBox.TabIndex = 5
        '
        'Id_productoTextBox
        '
        Me.Id_productoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "Id_producto", True))
        Me.Id_productoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_productoTextBox.Location = New System.Drawing.Point(316, 262)
        Me.Id_productoTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Id_productoTextBox.Name = "Id_productoTextBox"
        Me.Id_productoTextBox.Size = New System.Drawing.Size(148, 26)
        Me.Id_productoTextBox.TabIndex = 7
        '
        'CantidadVentaTextBox
        '
        Me.CantidadVentaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "cantidadVenta", True))
        Me.CantidadVentaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadVentaTextBox.Location = New System.Drawing.Point(688, 182)
        Me.CantidadVentaTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CantidadVentaTextBox.Name = "CantidadVentaTextBox"
        Me.CantidadVentaTextBox.Size = New System.Drawing.Size(148, 26)
        Me.CantidadVentaTextBox.TabIndex = 9
        '
        'Id_empleadoTextBox
        '
        Me.Id_empleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "Id_empleado", True))
        Me.Id_empleadoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_empleadoTextBox.Location = New System.Drawing.Point(688, 222)
        Me.Id_empleadoTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Id_empleadoTextBox.Name = "Id_empleadoTextBox"
        Me.Id_empleadoTextBox.Size = New System.Drawing.Size(148, 26)
        Me.Id_empleadoTextBox.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(478, 65)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 51)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Tabla: Venta"
        '
        'frmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1160, 699)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Id_empleadoLabel)
        Me.Controls.Add(Me.Id_empleadoTextBox)
        Me.Controls.Add(CantidadVentaLabel)
        Me.Controls.Add(Me.CantidadVentaTextBox)
        Me.Controls.Add(Id_productoLabel)
        Me.Controls.Add(Me.Id_productoTextBox)
        Me.Controls.Add(Id_facturaLabel)
        Me.Controls.Add(Me.Id_facturaTextBox)
        Me.Controls.Add(Id_ventaLabel)
        Me.Controls.Add(Me.Id_ventaTextBox)
        Me.Controls.Add(Me.VentaDataGridView)
        Me.Controls.Add(Me.VentaBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmVenta"
        Me.Text = "Form2"
        CType(Me._Systerre2026__2002_2003_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VentaBindingNavigator.ResumeLayout(False)
        Me.VentaBindingNavigator.PerformLayout()
        CType(Me.VentaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _Systerre2026__2002_2003_DataSet As _Systerre2026__2002_2003_DataSet
    Friend WithEvents VentaBindingSource As BindingSource
    Friend WithEvents VentaTableAdapter As _Systerre2026__2002_2003_DataSetTableAdapters.ventaTableAdapter
    Friend WithEvents TableAdapterManager As _Systerre2026__2002_2003_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents VentaBindingNavigator As BindingNavigator
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
    Friend WithEvents VentaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents VentaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Id_ventaTextBox As TextBox
    Friend WithEvents Id_facturaTextBox As TextBox
    Friend WithEvents Id_productoTextBox As TextBox
    Friend WithEvents CantidadVentaTextBox As TextBox
    Friend WithEvents Id_empleadoTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
