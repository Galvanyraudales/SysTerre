<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleado
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
        Dim Id_empleadoLabel As System.Windows.Forms.Label
        Dim NombreEmpleadoLabel As System.Windows.Forms.Label
        Dim DireccionEmplLabel As System.Windows.Forms.Label
        Dim TelefonoEmplLabel As System.Windows.Forms.Label
        Dim DNIemplLabel As System.Windows.Forms.Label
        Dim Id_usuarioLabel As System.Windows.Forms.Label
        Dim EdadEmpleLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpleado))
        Me.Label1 = New System.Windows.Forms.Label()
        Me._Systerre2026__2002_2003_DataSet = New SysTerre._Systerre2026__2002_2003_DataSet()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New SysTerre._Systerre2026__2002_2003_DataSetTableAdapters.clienteTableAdapter()
        Me.TableAdapterManager = New SysTerre._Systerre2026__2002_2003_DataSetTableAdapters.TableAdapterManager()
        Me.EmpleadoTableAdapter = New SysTerre._Systerre2026__2002_2003_DataSetTableAdapters.empleadoTableAdapter()
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
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_empleadoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreEmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionEmplTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoEmplTextBox = New System.Windows.Forms.TextBox()
        Me.DNIemplTextBox = New System.Windows.Forms.TextBox()
        Me.Id_usuarioTextBox = New System.Windows.Forms.TextBox()
        Me.EdadEmpleTextBox = New System.Windows.Forms.TextBox()
        Id_empleadoLabel = New System.Windows.Forms.Label()
        NombreEmpleadoLabel = New System.Windows.Forms.Label()
        DireccionEmplLabel = New System.Windows.Forms.Label()
        TelefonoEmplLabel = New System.Windows.Forms.Label()
        DNIemplLabel = New System.Windows.Forms.Label()
        Id_usuarioLabel = New System.Windows.Forms.Label()
        EdadEmpleLabel = New System.Windows.Forms.Label()
        CType(Me._Systerre2026__2002_2003_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClienteBindingNavigator.SuspendLayout()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_empleadoLabel
        '
        Id_empleadoLabel.AutoSize = True
        Id_empleadoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_empleadoLabel.Location = New System.Drawing.Point(147, 84)
        Id_empleadoLabel.Name = "Id_empleadoLabel"
        Id_empleadoLabel.Size = New System.Drawing.Size(80, 13)
        Id_empleadoLabel.TabIndex = 8
        Id_empleadoLabel.Text = "Id empleado:"
        '
        'NombreEmpleadoLabel
        '
        NombreEmpleadoLabel.AutoSize = True
        NombreEmpleadoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreEmpleadoLabel.Location = New System.Drawing.Point(120, 145)
        NombreEmpleadoLabel.Name = "NombreEmpleadoLabel"
        NombreEmpleadoLabel.Size = New System.Drawing.Size(111, 13)
        NombreEmpleadoLabel.TabIndex = 9
        NombreEmpleadoLabel.Text = "nombre Empleado:"
        AddHandler NombreEmpleadoLabel.Click, AddressOf Me.NombreEmpleadoLabel_Click
        '
        'DireccionEmplLabel
        '
        DireccionEmplLabel.AutoSize = True
        DireccionEmplLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DireccionEmplLabel.Location = New System.Drawing.Point(136, 110)
        DireccionEmplLabel.Name = "DireccionEmplLabel"
        DireccionEmplLabel.Size = New System.Drawing.Size(94, 13)
        DireccionEmplLabel.TabIndex = 10
        DireccionEmplLabel.Text = "direccion Empl:"
        '
        'TelefonoEmplLabel
        '
        TelefonoEmplLabel.AutoSize = True
        TelefonoEmplLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoEmplLabel.Location = New System.Drawing.Point(141, 171)
        TelefonoEmplLabel.Name = "TelefonoEmplLabel"
        TelefonoEmplLabel.Size = New System.Drawing.Size(88, 13)
        TelefonoEmplLabel.TabIndex = 11
        TelefonoEmplLabel.Text = "telefono Empl:"
        AddHandler TelefonoEmplLabel.Click, AddressOf Me.TelefonoEmplLabel_Click
        '
        'DNIemplLabel
        '
        DNIemplLabel.AutoSize = True
        DNIemplLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DNIemplLabel.Location = New System.Drawing.Point(424, 99)
        DNIemplLabel.Name = "DNIemplLabel"
        DNIemplLabel.Size = New System.Drawing.Size(59, 13)
        DNIemplLabel.TabIndex = 12
        DNIemplLabel.Text = "DNIempl:"
        '
        'Id_usuarioLabel
        '
        Id_usuarioLabel.AutoSize = True
        Id_usuarioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_usuarioLabel.Location = New System.Drawing.Point(419, 125)
        Id_usuarioLabel.Name = "Id_usuarioLabel"
        Id_usuarioLabel.Size = New System.Drawing.Size(67, 13)
        Id_usuarioLabel.TabIndex = 13
        Id_usuarioLabel.Text = "Id usuario:"
        AddHandler Id_usuarioLabel.Click, AddressOf Me.Id_usuarioLabel_Click
        '
        'EdadEmpleLabel
        '
        EdadEmpleLabel.AutoSize = True
        EdadEmpleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EdadEmpleLabel.Location = New System.Drawing.Point(409, 151)
        EdadEmpleLabel.Name = "EdadEmpleLabel"
        EdadEmpleLabel.Size = New System.Drawing.Size(77, 13)
        EdadEmpleLabel.TabIndex = 15
        EdadEmpleLabel.Text = "edad Emple:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(273, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Tabla: Empleado"
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
        Me.TableAdapterManager.empleadoTableAdapter = Me.EmpleadoTableAdapter
        Me.TableAdapterManager.facturaTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SysTerre._Systerre2026__2002_2003_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        Me.TableAdapterManager.ventaTableAdapter = Nothing
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'ClienteBindingNavigator
        '
        Me.ClienteBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClienteBindingNavigator.BindingSource = Me.ClienteBindingSource
        Me.ClienteBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClienteBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClienteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClienteBindingNavigatorSaveItem})
        Me.ClienteBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClienteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClienteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClienteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClienteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClienteBindingNavigator.Name = "ClienteBindingNavigator"
        Me.ClienteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClienteBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.ClienteBindingNavigator.TabIndex = 8
        Me.ClienteBindingNavigator.Text = "BindingNavigator1"
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
        'ClienteBindingNavigatorSaveItem
        '
        Me.ClienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClienteBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClienteBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClienteBindingNavigatorSaveItem.Name = "ClienteBindingNavigatorSaveItem"
        Me.ClienteBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClienteBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "empleado"
        Me.EmpleadoBindingSource.DataSource = Me._Systerre2026__2002_2003_DataSet
        '
        'EmpleadoDataGridView
        '
        Me.EmpleadoDataGridView.AutoGenerateColumns = False
        Me.EmpleadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.EmpleadoDataGridView.DataSource = Me.EmpleadoBindingSource
        Me.EmpleadoDataGridView.Location = New System.Drawing.Point(12, 218)
        Me.EmpleadoDataGridView.Name = "EmpleadoDataGridView"
        Me.EmpleadoDataGridView.Size = New System.Drawing.Size(742, 220)
        Me.EmpleadoDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_empleado"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_empleado"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombreEmpleado"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombreEmpleado"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "direccionEmpl"
        Me.DataGridViewTextBoxColumn3.HeaderText = "direccionEmpl"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "telefonoEmpl"
        Me.DataGridViewTextBoxColumn4.HeaderText = "telefonoEmpl"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DNIempl"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DNIempl"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Id_usuario"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Id_usuario"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "edadEmple"
        Me.DataGridViewTextBoxColumn7.HeaderText = "edadEmple"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Id_empleadoTextBox
        '
        Me.Id_empleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "Id_empleado", True))
        Me.Id_empleadoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_empleadoTextBox.Location = New System.Drawing.Point(235, 81)
        Me.Id_empleadoTextBox.Name = "Id_empleadoTextBox"
        Me.Id_empleadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_empleadoTextBox.TabIndex = 9
        '
        'NombreEmpleadoTextBox
        '
        Me.NombreEmpleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "nombreEmpleado", True))
        Me.NombreEmpleadoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreEmpleadoTextBox.Location = New System.Drawing.Point(235, 142)
        Me.NombreEmpleadoTextBox.Name = "NombreEmpleadoTextBox"
        Me.NombreEmpleadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreEmpleadoTextBox.TabIndex = 10
        '
        'DireccionEmplTextBox
        '
        Me.DireccionEmplTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "direccionEmpl", True))
        Me.DireccionEmplTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionEmplTextBox.Location = New System.Drawing.Point(235, 107)
        Me.DireccionEmplTextBox.Name = "DireccionEmplTextBox"
        Me.DireccionEmplTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DireccionEmplTextBox.TabIndex = 11
        '
        'TelefonoEmplTextBox
        '
        Me.TelefonoEmplTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "telefonoEmpl", True))
        Me.TelefonoEmplTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonoEmplTextBox.Location = New System.Drawing.Point(235, 168)
        Me.TelefonoEmplTextBox.Name = "TelefonoEmplTextBox"
        Me.TelefonoEmplTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoEmplTextBox.TabIndex = 12
        '
        'DNIemplTextBox
        '
        Me.DNIemplTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "DNIempl", True))
        Me.DNIemplTextBox.Location = New System.Drawing.Point(492, 93)
        Me.DNIemplTextBox.Name = "DNIemplTextBox"
        Me.DNIemplTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DNIemplTextBox.TabIndex = 13
        '
        'Id_usuarioTextBox
        '
        Me.Id_usuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "Id_usuario", True))
        Me.Id_usuarioTextBox.Location = New System.Drawing.Point(492, 119)
        Me.Id_usuarioTextBox.Name = "Id_usuarioTextBox"
        Me.Id_usuarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_usuarioTextBox.TabIndex = 14
        '
        'EdadEmpleTextBox
        '
        Me.EdadEmpleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "edadEmple", True))
        Me.EdadEmpleTextBox.Location = New System.Drawing.Point(492, 145)
        Me.EdadEmpleTextBox.Name = "EdadEmpleTextBox"
        Me.EdadEmpleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EdadEmpleTextBox.TabIndex = 16
        '
        'frmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 458)
        Me.Controls.Add(EdadEmpleLabel)
        Me.Controls.Add(Me.EdadEmpleTextBox)
        Me.Controls.Add(Id_usuarioLabel)
        Me.Controls.Add(Me.Id_usuarioTextBox)
        Me.Controls.Add(DNIemplLabel)
        Me.Controls.Add(Me.DNIemplTextBox)
        Me.Controls.Add(TelefonoEmplLabel)
        Me.Controls.Add(Me.TelefonoEmplTextBox)
        Me.Controls.Add(DireccionEmplLabel)
        Me.Controls.Add(Me.DireccionEmplTextBox)
        Me.Controls.Add(NombreEmpleadoLabel)
        Me.Controls.Add(Me.NombreEmpleadoTextBox)
        Me.Controls.Add(Id_empleadoLabel)
        Me.Controls.Add(Me.Id_empleadoTextBox)
        Me.Controls.Add(Me.EmpleadoDataGridView)
        Me.Controls.Add(Me.ClienteBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEmpleado"
        Me.Text = "Form1"
        CType(Me._Systerre2026__2002_2003_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClienteBindingNavigator.ResumeLayout(False)
        Me.ClienteBindingNavigator.PerformLayout()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
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
    Friend WithEvents EmpleadoTableAdapter As _Systerre2026__2002_2003_DataSetTableAdapters.empleadoTableAdapter
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Id_empleadoTextBox As TextBox
    Friend WithEvents NombreEmpleadoTextBox As TextBox
    Friend WithEvents DireccionEmplTextBox As TextBox
    Friend WithEvents TelefonoEmplTextBox As TextBox
    Friend WithEvents DNIemplTextBox As TextBox
    Friend WithEvents Id_usuarioTextBox As TextBox
    Friend WithEvents EdadEmpleTextBox As TextBox
End Class
