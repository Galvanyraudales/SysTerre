<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducto
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
        Dim Id_productoLabel As System.Windows.Forms.Label
        Dim DescripcionProdLabel As System.Windows.Forms.Label
        Dim PrecioprodLabel As System.Windows.Forms.Label
        Dim Id_categoriaLabel As System.Windows.Forms.Label
        Dim Id_proveedorLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProducto))
        Me._Systerre2026__2002_2003_DataSet = New SysTerre._Systerre2026__2002_2003_DataSet()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New SysTerre._Systerre2026__2002_2003_DataSetTableAdapters.productoTableAdapter()
        Me.TableAdapterManager = New SysTerre._Systerre2026__2002_2003_DataSetTableAdapters.TableAdapterManager()
        Me.ProductoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ProductoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Id_productoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionProdTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioprodTextBox = New System.Windows.Forms.TextBox()
        Me.Id_categoriaTextBox = New System.Windows.Forms.TextBox()
        Me.Id_proveedorTextBox = New System.Windows.Forms.TextBox()
        Id_productoLabel = New System.Windows.Forms.Label()
        DescripcionProdLabel = New System.Windows.Forms.Label()
        PrecioprodLabel = New System.Windows.Forms.Label()
        Id_categoriaLabel = New System.Windows.Forms.Label()
        Id_proveedorLabel = New System.Windows.Forms.Label()
        CType(Me._Systerre2026__2002_2003_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductoBindingNavigator.SuspendLayout()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_productoLabel
        '
        Id_productoLabel.AutoSize = True
        Id_productoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_productoLabel.Location = New System.Drawing.Point(434, 120)
        Id_productoLabel.Name = "Id_productoLabel"
        Id_productoLabel.Size = New System.Drawing.Size(76, 13)
        Id_productoLabel.TabIndex = 13
        Id_productoLabel.Text = "Id producto:"
        '
        'DescripcionProdLabel
        '
        DescripcionProdLabel.AutoSize = True
        DescripcionProdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionProdLabel.Location = New System.Drawing.Point(409, 149)
        DescripcionProdLabel.Name = "DescripcionProdLabel"
        DescripcionProdLabel.Size = New System.Drawing.Size(106, 13)
        DescripcionProdLabel.TabIndex = 14
        DescripcionProdLabel.Text = "descripcion Prod:"
        '
        'PrecioprodLabel
        '
        PrecioprodLabel.AutoSize = True
        PrecioprodLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrecioprodLabel.Location = New System.Drawing.Point(166, 146)
        PrecioprodLabel.Name = "PrecioprodLabel"
        PrecioprodLabel.Size = New System.Drawing.Size(71, 13)
        PrecioprodLabel.TabIndex = 15
        PrecioprodLabel.Text = "precioprod:"
        '
        'Id_categoriaLabel
        '
        Id_categoriaLabel.AutoSize = True
        Id_categoriaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_categoriaLabel.Location = New System.Drawing.Point(160, 120)
        Id_categoriaLabel.Name = "Id_categoriaLabel"
        Id_categoriaLabel.Size = New System.Drawing.Size(79, 13)
        Id_categoriaLabel.TabIndex = 16
        Id_categoriaLabel.Text = "Id categoria:"
        '
        'Id_proveedorLabel
        '
        Id_proveedorLabel.AutoSize = True
        Id_proveedorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_proveedorLabel.Location = New System.Drawing.Point(156, 172)
        Id_proveedorLabel.Name = "Id_proveedorLabel"
        Id_proveedorLabel.Size = New System.Drawing.Size(83, 13)
        Id_proveedorLabel.TabIndex = 17
        Id_proveedorLabel.Text = "Id proveedor:"
        '
        '_Systerre2026__2002_2003_DataSet
        '
        Me._Systerre2026__2002_2003_DataSet.DataSetName = "_Systerre2026__2002_2003_DataSet"
        Me._Systerre2026__2002_2003_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "producto"
        Me.ProductoBindingSource.DataSource = Me._Systerre2026__2002_2003_DataSet
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriaTableAdapter = Nothing
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.empleadoTableAdapter = Nothing
        Me.TableAdapterManager.facturaTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Me.ProductoTableAdapter
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SysTerre._Systerre2026__2002_2003_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        Me.TableAdapterManager.ventaTableAdapter = Nothing
        '
        'ProductoBindingNavigator
        '
        Me.ProductoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProductoBindingNavigator.BindingSource = Me.ProductoBindingSource
        Me.ProductoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProductoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProductoBindingNavigatorSaveItem})
        Me.ProductoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProductoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductoBindingNavigator.Name = "ProductoBindingNavigator"
        Me.ProductoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductoBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.ProductoBindingNavigator.TabIndex = 0
        Me.ProductoBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ProductoBindingNavigatorSaveItem
        '
        Me.ProductoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProductoBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductoBindingNavigatorSaveItem.Name = "ProductoBindingNavigatorSaveItem"
        Me.ProductoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProductoBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ProductoDataGridView
        '
        Me.ProductoDataGridView.AutoGenerateColumns = False
        Me.ProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ProductoDataGridView.DataSource = Me.ProductoBindingSource
        Me.ProductoDataGridView.Location = New System.Drawing.Point(134, 231)
        Me.ProductoDataGridView.Name = "ProductoDataGridView"
        Me.ProductoDataGridView.Size = New System.Drawing.Size(542, 220)
        Me.ProductoDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_producto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_producto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "descripcionProd"
        Me.DataGridViewTextBoxColumn2.HeaderText = "descripcionProd"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "precioprod"
        Me.DataGridViewTextBoxColumn3.HeaderText = "precioprod"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Id_categoria"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Id_categoria"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Id_proveedor"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Id_proveedor"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(280, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 33)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Tabla: Producto"
        '
        'Id_productoTextBox
        '
        Me.Id_productoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Id_producto", True))
        Me.Id_productoTextBox.Location = New System.Drawing.Point(521, 117)
        Me.Id_productoTextBox.Name = "Id_productoTextBox"
        Me.Id_productoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_productoTextBox.TabIndex = 14
        '
        'DescripcionProdTextBox
        '
        Me.DescripcionProdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "descripcionProd", True))
        Me.DescripcionProdTextBox.Location = New System.Drawing.Point(521, 146)
        Me.DescripcionProdTextBox.Name = "DescripcionProdTextBox"
        Me.DescripcionProdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DescripcionProdTextBox.TabIndex = 15
        '
        'PrecioprodTextBox
        '
        Me.PrecioprodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "precioprod", True))
        Me.PrecioprodTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioprodTextBox.Location = New System.Drawing.Point(245, 143)
        Me.PrecioprodTextBox.Name = "PrecioprodTextBox"
        Me.PrecioprodTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrecioprodTextBox.TabIndex = 16
        '
        'Id_categoriaTextBox
        '
        Me.Id_categoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Id_categoria", True))
        Me.Id_categoriaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_categoriaTextBox.Location = New System.Drawing.Point(245, 117)
        Me.Id_categoriaTextBox.Name = "Id_categoriaTextBox"
        Me.Id_categoriaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_categoriaTextBox.TabIndex = 17
        '
        'Id_proveedorTextBox
        '
        Me.Id_proveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Id_proveedor", True))
        Me.Id_proveedorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_proveedorTextBox.Location = New System.Drawing.Point(245, 169)
        Me.Id_proveedorTextBox.Name = "Id_proveedorTextBox"
        Me.Id_proveedorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_proveedorTextBox.TabIndex = 18
        '
        'frmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 524)
        Me.Controls.Add(Id_proveedorLabel)
        Me.Controls.Add(Me.Id_proveedorTextBox)
        Me.Controls.Add(Id_categoriaLabel)
        Me.Controls.Add(Me.Id_categoriaTextBox)
        Me.Controls.Add(PrecioprodLabel)
        Me.Controls.Add(Me.PrecioprodTextBox)
        Me.Controls.Add(DescripcionProdLabel)
        Me.Controls.Add(Me.DescripcionProdTextBox)
        Me.Controls.Add(Id_productoLabel)
        Me.Controls.Add(Me.Id_productoTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProductoDataGridView)
        Me.Controls.Add(Me.ProductoBindingNavigator)
        Me.Name = "frmProducto"
        Me.Text = "Form2"
        CType(Me._Systerre2026__2002_2003_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductoBindingNavigator.ResumeLayout(False)
        Me.ProductoBindingNavigator.PerformLayout()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _Systerre2026__2002_2003_DataSet As _Systerre2026__2002_2003_DataSet
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As _Systerre2026__2002_2003_DataSetTableAdapters.productoTableAdapter
    Friend WithEvents TableAdapterManager As _Systerre2026__2002_2003_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductoBindingNavigator As BindingNavigator
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
    Friend WithEvents ProductoBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ProductoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Id_productoTextBox As TextBox
    Friend WithEvents DescripcionProdTextBox As TextBox
    Friend WithEvents PrecioprodTextBox As TextBox
    Friend WithEvents Id_categoriaTextBox As TextBox
    Friend WithEvents Id_proveedorTextBox As TextBox
End Class
