<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCliente
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
        Dim Id_clienteLabel As System.Windows.Forms.Label
        Dim NombreClienteLabel As System.Windows.Forms.Label
        Dim DireccionClienteLabel As System.Windows.Forms.Label
        Dim TelefonoClienteLabel As System.Windows.Forms.Label
        Dim DNIclienteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCliente))
        Me._Systerre2026__2002_2003_DataSet = New SysTerre._Systerre2026__2002_2003_DataSet()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New SysTerre._Systerre2026__2002_2003_DataSetTableAdapters.clienteTableAdapter()
        Me.TableAdapterManager = New SysTerre._Systerre2026__2002_2003_DataSetTableAdapters.TableAdapterManager()
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
        Me.Id_clienteTextBox = New System.Windows.Forms.TextBox()
        Me.ClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreClienteTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionClienteTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoClienteTextBox = New System.Windows.Forms.TextBox()
        Me.DNIclienteTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Id_clienteLabel = New System.Windows.Forms.Label()
        NombreClienteLabel = New System.Windows.Forms.Label()
        DireccionClienteLabel = New System.Windows.Forms.Label()
        TelefonoClienteLabel = New System.Windows.Forms.Label()
        DNIclienteLabel = New System.Windows.Forms.Label()
        CType(Me._Systerre2026__2002_2003_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClienteBindingNavigator.SuspendLayout()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_clienteLabel
        '
        Id_clienteLabel.AutoSize = True
        Id_clienteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_clienteLabel.Location = New System.Drawing.Point(397, 105)
        Id_clienteLabel.Name = "Id_clienteLabel"
        Id_clienteLabel.Size = New System.Drawing.Size(64, 13)
        Id_clienteLabel.TabIndex = 1
        Id_clienteLabel.Text = "Id cliente:"
        '
        'NombreClienteLabel
        '
        NombreClienteLabel.AutoSize = True
        NombreClienteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreClienteLabel.Location = New System.Drawing.Point(103, 153)
        NombreClienteLabel.Name = "NombreClienteLabel"
        NombreClienteLabel.Size = New System.Drawing.Size(95, 13)
        NombreClienteLabel.TabIndex = 5
        NombreClienteLabel.Text = "nombre Cliente:"
        '
        'DireccionClienteLabel
        '
        DireccionClienteLabel.AutoSize = True
        DireccionClienteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DireccionClienteLabel.Location = New System.Drawing.Point(95, 101)
        DireccionClienteLabel.Name = "DireccionClienteLabel"
        DireccionClienteLabel.Size = New System.Drawing.Size(106, 13)
        DireccionClienteLabel.TabIndex = 6
        DireccionClienteLabel.Text = "direccion Cliente:"
        AddHandler DireccionClienteLabel.Click, AddressOf Me.DireccionClienteLabel_Click
        '
        'TelefonoClienteLabel
        '
        TelefonoClienteLabel.AutoSize = True
        TelefonoClienteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoClienteLabel.Location = New System.Drawing.Point(367, 127)
        TelefonoClienteLabel.Name = "TelefonoClienteLabel"
        TelefonoClienteLabel.Size = New System.Drawing.Size(100, 13)
        TelefonoClienteLabel.TabIndex = 8
        TelefonoClienteLabel.Text = "telefono Cliente:"
        '
        'DNIclienteLabel
        '
        DNIclienteLabel.AutoSize = True
        DNIclienteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DNIclienteLabel.Location = New System.Drawing.Point(123, 127)
        DNIclienteLabel.Name = "DNIclienteLabel"
        DNIclienteLabel.Size = New System.Drawing.Size(71, 13)
        DNIclienteLabel.TabIndex = 10
        DNIclienteLabel.Text = "DNIcliente:"
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
        Me.TableAdapterManager.facturaTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SysTerre._Systerre2026__2002_2003_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        Me.TableAdapterManager.ventaTableAdapter = Nothing
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
        Me.ClienteBindingNavigator.TabIndex = 0
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
        'Id_clienteTextBox
        '
        Me.Id_clienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Id_cliente", True))
        Me.Id_clienteTextBox.Location = New System.Drawing.Point(473, 102)
        Me.Id_clienteTextBox.Name = "Id_clienteTextBox"
        Me.Id_clienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_clienteTextBox.TabIndex = 2
        '
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView.Location = New System.Drawing.Point(98, 203)
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.Size = New System.Drawing.Size(545, 184)
        Me.ClienteDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_cliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_cliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombreCliente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombreCliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "direccionCliente"
        Me.DataGridViewTextBoxColumn3.HeaderText = "direccionCliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "telefonoCliente"
        Me.DataGridViewTextBoxColumn4.HeaderText = "telefonoCliente"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DNIcliente"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DNIcliente"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'NombreClienteTextBox
        '
        Me.NombreClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "nombreCliente", True))
        Me.NombreClienteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreClienteTextBox.Location = New System.Drawing.Point(204, 153)
        Me.NombreClienteTextBox.Name = "NombreClienteTextBox"
        Me.NombreClienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreClienteTextBox.TabIndex = 6
        '
        'DireccionClienteTextBox
        '
        Me.DireccionClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "direccionCliente", True))
        Me.DireccionClienteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionClienteTextBox.Location = New System.Drawing.Point(204, 101)
        Me.DireccionClienteTextBox.Name = "DireccionClienteTextBox"
        Me.DireccionClienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DireccionClienteTextBox.TabIndex = 7
        '
        'TelefonoClienteTextBox
        '
        Me.TelefonoClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "telefonoCliente", True))
        Me.TelefonoClienteTextBox.Location = New System.Drawing.Point(473, 124)
        Me.TelefonoClienteTextBox.Name = "TelefonoClienteTextBox"
        Me.TelefonoClienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoClienteTextBox.TabIndex = 9
        '
        'DNIclienteTextBox
        '
        Me.DNIclienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "DNIcliente", True))
        Me.DNIclienteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DNIclienteTextBox.Location = New System.Drawing.Point(204, 127)
        Me.DNIclienteTextBox.Name = "DNIclienteTextBox"
        Me.DNIclienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DNIclienteTextBox.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(302, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 29)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Tabla: Cliente"
        '
        'frmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(DNIclienteLabel)
        Me.Controls.Add(Me.DNIclienteTextBox)
        Me.Controls.Add(TelefonoClienteLabel)
        Me.Controls.Add(Me.TelefonoClienteTextBox)
        Me.Controls.Add(DireccionClienteLabel)
        Me.Controls.Add(Me.DireccionClienteTextBox)
        Me.Controls.Add(NombreClienteLabel)
        Me.Controls.Add(Me.NombreClienteTextBox)
        Me.Controls.Add(Me.ClienteDataGridView)
        Me.Controls.Add(Id_clienteLabel)
        Me.Controls.Add(Me.Id_clienteTextBox)
        Me.Controls.Add(Me.ClienteBindingNavigator)
        Me.Name = "frmCliente"
        Me.Text = "Form5"
        CType(Me._Systerre2026__2002_2003_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClienteBindingNavigator.ResumeLayout(False)
        Me.ClienteBindingNavigator.PerformLayout()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Id_clienteTextBox As TextBox
    Friend WithEvents ClienteDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents NombreClienteTextBox As TextBox
    Friend WithEvents DireccionClienteTextBox As TextBox
    Friend WithEvents TelefonoClienteTextBox As TextBox
    Friend WithEvents DNIclienteTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
