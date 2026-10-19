<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategoria
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
        Dim Id_categoriaLabel As System.Windows.Forms.Label
        Dim DescripcioncatLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategoria))
        Me._Systerre2026__2002_2003_DataSet = New SysTerre._Systerre2026__2002_2003_DataSet()
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriaTableAdapter = New SysTerre._Systerre2026__2002_2003_DataSetTableAdapters.categoriaTableAdapter()
        Me.TableAdapterManager = New SysTerre._Systerre2026__2002_2003_DataSetTableAdapters.TableAdapterManager()
        Me.CategoriaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CategoriaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CategoriaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_categoriaTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcioncatTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Id_categoriaLabel = New System.Windows.Forms.Label()
        DescripcioncatLabel = New System.Windows.Forms.Label()
        CType(Me._Systerre2026__2002_2003_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CategoriaBindingNavigator.SuspendLayout()
        CType(Me.CategoriaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_categoriaLabel
        '
        Id_categoriaLabel.AutoSize = True
        Id_categoriaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_categoriaLabel.Location = New System.Drawing.Point(38, 105)
        Id_categoriaLabel.Name = "Id_categoriaLabel"
        Id_categoriaLabel.Size = New System.Drawing.Size(145, 18)
        Id_categoriaLabel.TabIndex = 2
        Id_categoriaLabel.Text = "Codigo Categoria:"
        '
        'DescripcioncatLabel
        '
        DescripcioncatLabel.AutoSize = True
        DescripcioncatLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcioncatLabel.Location = New System.Drawing.Point(38, 131)
        DescripcioncatLabel.Name = "DescripcioncatLabel"
        DescripcioncatLabel.Size = New System.Drawing.Size(123, 18)
        DescripcioncatLabel.TabIndex = 4
        DescripcioncatLabel.Text = "descripcioncat:"
        '
        '_Systerre2026__2002_2003_DataSet
        '
        Me._Systerre2026__2002_2003_DataSet.DataSetName = "_Systerre2026__2002_2003_DataSet"
        Me._Systerre2026__2002_2003_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "categoria"
        Me.CategoriaBindingSource.DataSource = Me._Systerre2026__2002_2003_DataSet
        '
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriaTableAdapter = Me.CategoriaTableAdapter
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.empleadoTableAdapter = Nothing
        Me.TableAdapterManager.facturaTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SysTerre._Systerre2026__2002_2003_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        Me.TableAdapterManager.ventaTableAdapter = Nothing
        '
        'CategoriaBindingNavigator
        '
        Me.CategoriaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CategoriaBindingNavigator.BindingSource = Me.CategoriaBindingSource
        Me.CategoriaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CategoriaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CategoriaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CategoriaBindingNavigatorSaveItem})
        Me.CategoriaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CategoriaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CategoriaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CategoriaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CategoriaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CategoriaBindingNavigator.Name = "CategoriaBindingNavigator"
        Me.CategoriaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CategoriaBindingNavigator.Size = New System.Drawing.Size(377, 25)
        Me.CategoriaBindingNavigator.TabIndex = 0
        Me.CategoriaBindingNavigator.Text = "BindingNavigator1"
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
        'CategoriaBindingNavigatorSaveItem
        '
        Me.CategoriaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CategoriaBindingNavigatorSaveItem.Image = CType(resources.GetObject("CategoriaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CategoriaBindingNavigatorSaveItem.Name = "CategoriaBindingNavigatorSaveItem"
        Me.CategoriaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CategoriaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CategoriaDataGridView
        '
        Me.CategoriaDataGridView.AutoGenerateColumns = False
        Me.CategoriaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CategoriaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.CategoriaDataGridView.DataSource = Me.CategoriaBindingSource
        Me.CategoriaDataGridView.Location = New System.Drawing.Point(41, 181)
        Me.CategoriaDataGridView.Name = "CategoriaDataGridView"
        Me.CategoriaDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.CategoriaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_categoria"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_categoria"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "descripcioncat"
        Me.DataGridViewTextBoxColumn2.HeaderText = "descripcioncat"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Id_categoriaTextBox
        '
        Me.Id_categoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriaBindingSource, "Id_categoria", True))
        Me.Id_categoriaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_categoriaTextBox.Location = New System.Drawing.Point(189, 105)
        Me.Id_categoriaTextBox.Name = "Id_categoriaTextBox"
        Me.Id_categoriaTextBox.Size = New System.Drawing.Size(152, 21)
        Me.Id_categoriaTextBox.TabIndex = 3
        '
        'DescripcioncatTextBox
        '
        Me.DescripcioncatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriaBindingSource, "descripcioncat", True))
        Me.DescripcioncatTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcioncatTextBox.Location = New System.Drawing.Point(189, 132)
        Me.DescripcioncatTextBox.Name = "DescripcioncatTextBox"
        Me.DescripcioncatTextBox.Size = New System.Drawing.Size(152, 21)
        Me.DescripcioncatTextBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 29)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Tabla: Categoria"
        '
        'frmCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(377, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Id_categoriaLabel)
        Me.Controls.Add(Me.Id_categoriaTextBox)
        Me.Controls.Add(DescripcioncatLabel)
        Me.Controls.Add(Me.DescripcioncatTextBox)
        Me.Controls.Add(Me.CategoriaDataGridView)
        Me.Controls.Add(Me.CategoriaBindingNavigator)
        Me.Name = "frmCategoria"
        Me.Text = "Form1"
        CType(Me._Systerre2026__2002_2003_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CategoriaBindingNavigator.ResumeLayout(False)
        Me.CategoriaBindingNavigator.PerformLayout()
        CType(Me.CategoriaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _Systerre2026__2002_2003_DataSet As _Systerre2026__2002_2003_DataSet
    Friend WithEvents CategoriaBindingSource As BindingSource
    Friend WithEvents CategoriaTableAdapter As _Systerre2026__2002_2003_DataSetTableAdapters.categoriaTableAdapter
    Friend WithEvents TableAdapterManager As _Systerre2026__2002_2003_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents CategoriaBindingNavigator As BindingNavigator
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
    Friend WithEvents CategoriaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CategoriaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Id_categoriaTextBox As TextBox
    Friend WithEvents DescripcioncatTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
