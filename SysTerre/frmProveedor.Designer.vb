<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedor))
        Dim Id_proveedorLabel As System.Windows.Forms.Label
        Dim NombreProveedorLabel As System.Windows.Forms.Label
        Dim DireccionProvedorLabel As System.Windows.Forms.Label
        Dim TelefonoProveedorLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me._Systerre2026__2002_2003_DataSet = New SysTerre._Systerre2026__2002_2003_DataSet()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedorTableAdapter = New SysTerre._Systerre2026__2002_2003_DataSetTableAdapters.proveedorTableAdapter()
        Me.TableAdapterManager = New SysTerre._Systerre2026__2002_2003_DataSetTableAdapters.TableAdapterManager()
        Me.ProveedorBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ProveedorBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProveedorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_proveedorTextBox = New System.Windows.Forms.TextBox()
        Me.NombreProveedorTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionProvedorTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoProveedorTextBox = New System.Windows.Forms.TextBox()
        Id_proveedorLabel = New System.Windows.Forms.Label()
        NombreProveedorLabel = New System.Windows.Forms.Label()
        DireccionProvedorLabel = New System.Windows.Forms.Label()
        TelefonoProveedorLabel = New System.Windows.Forms.Label()
        CType(Me._Systerre2026__2002_2003_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProveedorBindingNavigator.SuspendLayout()
        CType(Me.ProveedorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(266, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 29)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Tabla: Proveedor"
        '
        '_Systerre2026__2002_2003_DataSet
        '
        Me._Systerre2026__2002_2003_DataSet.DataSetName = "_Systerre2026__2002_2003_DataSet"
        Me._Systerre2026__2002_2003_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "proveedor"
        Me.ProveedorBindingSource.DataSource = Me._Systerre2026__2002_2003_DataSet
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriaTableAdapter = Nothing
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.empleadoTableAdapter = Nothing
        Me.TableAdapterManager.facturaTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Me.ProveedorTableAdapter
        Me.TableAdapterManager.UpdateOrder = SysTerre._Systerre2026__2002_2003_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        Me.TableAdapterManager.ventaTableAdapter = Nothing
        '
        'ProveedorBindingNavigator
        '
        Me.ProveedorBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProveedorBindingNavigator.BindingSource = Me.ProveedorBindingSource
        Me.ProveedorBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProveedorBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProveedorBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProveedorBindingNavigatorSaveItem})
        Me.ProveedorBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProveedorBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProveedorBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProveedorBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProveedorBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProveedorBindingNavigator.Name = "ProveedorBindingNavigator"
        Me.ProveedorBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProveedorBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.ProveedorBindingNavigator.TabIndex = 14
        Me.ProveedorBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'ProveedorBindingNavigatorSaveItem
        '
        Me.ProveedorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProveedorBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProveedorBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProveedorBindingNavigatorSaveItem.Name = "ProveedorBindingNavigatorSaveItem"
        Me.ProveedorBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ProveedorBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ProveedorDataGridView
        '
        Me.ProveedorDataGridView.AutoGenerateColumns = False
        Me.ProveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProveedorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ProveedorDataGridView.DataSource = Me.ProveedorBindingSource
        Me.ProveedorDataGridView.Location = New System.Drawing.Point(179, 230)
        Me.ProveedorDataGridView.Name = "ProveedorDataGridView"
        Me.ProveedorDataGridView.Size = New System.Drawing.Size(444, 220)
        Me.ProveedorDataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_proveedor"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_proveedor"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombreProveedor"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombreProveedor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "direccionProvedor"
        Me.DataGridViewTextBoxColumn3.HeaderText = "direccionProvedor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "telefonoProveedor"
        Me.DataGridViewTextBoxColumn4.HeaderText = "telefonoProveedor"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Id_proveedorLabel
        '
        Id_proveedorLabel.AutoSize = True
        Id_proveedorLabel.Location = New System.Drawing.Point(188, 117)
        Id_proveedorLabel.Name = "Id_proveedorLabel"
        Id_proveedorLabel.Size = New System.Drawing.Size(70, 13)
        Id_proveedorLabel.TabIndex = 14
        Id_proveedorLabel.Text = "Id proveedor:"
        '
        'Id_proveedorTextBox
        '
        Me.Id_proveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "Id_proveedor", True))
        Me.Id_proveedorTextBox.Location = New System.Drawing.Point(264, 114)
        Me.Id_proveedorTextBox.Name = "Id_proveedorTextBox"
        Me.Id_proveedorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_proveedorTextBox.TabIndex = 15
        '
        'NombreProveedorLabel
        '
        NombreProveedorLabel.AutoSize = True
        NombreProveedorLabel.Location = New System.Drawing.Point(161, 143)
        NombreProveedorLabel.Name = "NombreProveedorLabel"
        NombreProveedorLabel.Size = New System.Drawing.Size(97, 13)
        NombreProveedorLabel.TabIndex = 15
        NombreProveedorLabel.Text = "nombre Proveedor:"
        '
        'NombreProveedorTextBox
        '
        Me.NombreProveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "nombreProveedor", True))
        Me.NombreProveedorTextBox.Location = New System.Drawing.Point(264, 140)
        Me.NombreProveedorTextBox.Name = "NombreProveedorTextBox"
        Me.NombreProveedorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreProveedorTextBox.TabIndex = 16
        '
        'DireccionProvedorLabel
        '
        DireccionProvedorLabel.AutoSize = True
        DireccionProvedorLabel.Location = New System.Drawing.Point(409, 146)
        DireccionProvedorLabel.Name = "DireccionProvedorLabel"
        DireccionProvedorLabel.Size = New System.Drawing.Size(99, 13)
        DireccionProvedorLabel.TabIndex = 16
        DireccionProvedorLabel.Text = "direccion Provedor:"
        '
        'DireccionProvedorTextBox
        '
        Me.DireccionProvedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "direccionProvedor", True))
        Me.DireccionProvedorTextBox.Location = New System.Drawing.Point(514, 143)
        Me.DireccionProvedorTextBox.Name = "DireccionProvedorTextBox"
        Me.DireccionProvedorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DireccionProvedorTextBox.TabIndex = 17
        '
        'TelefonoProveedorLabel
        '
        TelefonoProveedorLabel.AutoSize = True
        TelefonoProveedorLabel.Location = New System.Drawing.Point(408, 117)
        TelefonoProveedorLabel.Name = "TelefonoProveedorLabel"
        TelefonoProveedorLabel.Size = New System.Drawing.Size(100, 13)
        TelefonoProveedorLabel.TabIndex = 17
        TelefonoProveedorLabel.Text = "telefono Proveedor:"
        '
        'TelefonoProveedorTextBox
        '
        Me.TelefonoProveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "telefonoProveedor", True))
        Me.TelefonoProveedorTextBox.Location = New System.Drawing.Point(514, 114)
        Me.TelefonoProveedorTextBox.Name = "TelefonoProveedorTextBox"
        Me.TelefonoProveedorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoProveedorTextBox.TabIndex = 18
        '
        'frmProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(800, 470)
        Me.Controls.Add(TelefonoProveedorLabel)
        Me.Controls.Add(Me.TelefonoProveedorTextBox)
        Me.Controls.Add(DireccionProvedorLabel)
        Me.Controls.Add(Me.DireccionProvedorTextBox)
        Me.Controls.Add(NombreProveedorLabel)
        Me.Controls.Add(Me.NombreProveedorTextBox)
        Me.Controls.Add(Id_proveedorLabel)
        Me.Controls.Add(Me.Id_proveedorTextBox)
        Me.Controls.Add(Me.ProveedorDataGridView)
        Me.Controls.Add(Me.ProveedorBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmProveedor"
        Me.Text = "Form1"
        CType(Me._Systerre2026__2002_2003_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProveedorBindingNavigator.ResumeLayout(False)
        Me.ProveedorBindingNavigator.PerformLayout()
        CType(Me.ProveedorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents _Systerre2026__2002_2003_DataSet As _Systerre2026__2002_2003_DataSet
    Friend WithEvents ProveedorBindingSource As BindingSource
    Friend WithEvents ProveedorTableAdapter As _Systerre2026__2002_2003_DataSetTableAdapters.proveedorTableAdapter
    Friend WithEvents TableAdapterManager As _Systerre2026__2002_2003_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProveedorBindingNavigator As BindingNavigator
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
    Friend WithEvents ProveedorBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ProveedorDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Id_proveedorTextBox As TextBox
    Friend WithEvents NombreProveedorTextBox As TextBox
    Friend WithEvents DireccionProvedorTextBox As TextBox
    Friend WithEvents TelefonoProveedorTextBox As TextBox
End Class
