<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuPrincipal))
        Me.btnNavegador = New System.Windows.Forms.Button()
        Me.btnManualU = New System.Windows.Forms.Button()
        Me.btnReporductor = New System.Windows.Forms.Button()
        Me.btnCalBas = New System.Windows.Forms.Button()
        Me.btnManualT = New System.Windows.Forms.Button()
        Me.btnCalWin = New System.Windows.Forms.Button()
        Me.btnProducto = New System.Windows.Forms.Button()
        Me.btnProveedor = New System.Windows.Forms.Button()
        Me.btnUsuario = New System.Windows.Forms.Button()
        Me.btnVenta = New System.Windows.Forms.Button()
        Me.btnCategoria = New System.Windows.Forms.Button()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.btnEmpleado = New System.Windows.Forms.Button()
        Me.btnFactura = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnNavegador
        '
        Me.btnNavegador.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavegador.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNavegador.Image = Global.SysTerre.My.Resources.Resources.email
        Me.btnNavegador.Location = New System.Drawing.Point(99, 445)
        Me.btnNavegador.Name = "btnNavegador"
        Me.btnNavegador.Size = New System.Drawing.Size(123, 74)
        Me.btnNavegador.TabIndex = 21
        Me.btnNavegador.Text = "Navegador"
        Me.btnNavegador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnNavegador.UseVisualStyleBackColor = True
        '
        'btnManualU
        '
        Me.btnManualU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManualU.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManualU.Image = Global.SysTerre.My.Resources.Resources.bookmarck2
        Me.btnManualU.Location = New System.Drawing.Point(435, 350)
        Me.btnManualU.Name = "btnManualU"
        Me.btnManualU.Size = New System.Drawing.Size(123, 73)
        Me.btnManualU.TabIndex = 20
        Me.btnManualU.Text = "Manual de Usuario"
        Me.btnManualU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnManualU.UseVisualStyleBackColor = True
        '
        'btnReporductor
        '
        Me.btnReporductor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReporductor.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporductor.Image = Global.SysTerre.My.Resources.Resources.bt_play
        Me.btnReporductor.Location = New System.Drawing.Point(266, 446)
        Me.btnReporductor.Name = "btnReporductor"
        Me.btnReporductor.Size = New System.Drawing.Size(123, 75)
        Me.btnReporductor.TabIndex = 19
        Me.btnReporductor.Text = "Reproductor"
        Me.btnReporductor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnReporductor.UseVisualStyleBackColor = True
        '
        'btnCalBas
        '
        Me.btnCalBas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalBas.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalBas.Image = Global.SysTerre.My.Resources.Resources.cel
        Me.btnCalBas.Location = New System.Drawing.Point(99, 349)
        Me.btnCalBas.Name = "btnCalBas"
        Me.btnCalBas.Size = New System.Drawing.Size(123, 74)
        Me.btnCalBas.TabIndex = 18
        Me.btnCalBas.Text = "Calculadora Basica"
        Me.btnCalBas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCalBas.UseVisualStyleBackColor = True
        '
        'btnManualT
        '
        Me.btnManualT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManualT.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManualT.Image = Global.SysTerre.My.Resources.Resources.app_preferences
        Me.btnManualT.Location = New System.Drawing.Point(266, 349)
        Me.btnManualT.Name = "btnManualT"
        Me.btnManualT.Size = New System.Drawing.Size(123, 74)
        Me.btnManualT.TabIndex = 17
        Me.btnManualT.Text = "Manual Tecnico"
        Me.btnManualT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnManualT.UseVisualStyleBackColor = True
        '
        'btnCalWin
        '
        Me.btnCalWin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalWin.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalWin.Image = Global.SysTerre.My.Resources.Resources.calculator
        Me.btnCalWin.Location = New System.Drawing.Point(435, 258)
        Me.btnCalWin.Name = "btnCalWin"
        Me.btnCalWin.Size = New System.Drawing.Size(123, 74)
        Me.btnCalWin.TabIndex = 16
        Me.btnCalWin.Text = "Calculadora de Windows"
        Me.btnCalWin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCalWin.UseVisualStyleBackColor = True
        '
        'btnProducto
        '
        Me.btnProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProducto.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProducto.Image = Global.SysTerre.My.Resources.Resources.deb
        Me.btnProducto.Location = New System.Drawing.Point(266, 168)
        Me.btnProducto.Name = "btnProducto"
        Me.btnProducto.Size = New System.Drawing.Size(123, 74)
        Me.btnProducto.TabIndex = 15
        Me.btnProducto.Text = "Producto"
        Me.btnProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnProducto.UseVisualStyleBackColor = True
        '
        'btnProveedor
        '
        Me.btnProveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProveedor.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProveedor.Image = Global.SysTerre.My.Resources.Resources.iCandy_Junior_022
        Me.btnProveedor.Location = New System.Drawing.Point(435, 168)
        Me.btnProveedor.Name = "btnProveedor"
        Me.btnProveedor.Size = New System.Drawing.Size(123, 74)
        Me.btnProveedor.TabIndex = 14
        Me.btnProveedor.Text = "Proveedor"
        Me.btnProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnProveedor.UseVisualStyleBackColor = True
        '
        'btnUsuario
        '
        Me.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUsuario.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuario.Image = Global.SysTerre.My.Resources.Resources.guy_yellow
        Me.btnUsuario.Location = New System.Drawing.Point(99, 258)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(123, 74)
        Me.btnUsuario.TabIndex = 13
        Me.btnUsuario.Text = "Usuario"
        Me.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnUsuario.UseVisualStyleBackColor = True
        '
        'btnVenta
        '
        Me.btnVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVenta.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVenta.Image = Global.SysTerre.My.Resources.Resources.kwrite_32x32_32
        Me.btnVenta.Location = New System.Drawing.Point(266, 258)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Size = New System.Drawing.Size(123, 74)
        Me.btnVenta.TabIndex = 12
        Me.btnVenta.Text = "Venta"
        Me.btnVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnVenta.UseVisualStyleBackColor = True
        '
        'btnCategoria
        '
        Me.btnCategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCategoria.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategoria.Image = Global.SysTerre.My.Resources.Resources.find
        Me.btnCategoria.Location = New System.Drawing.Point(99, 73)
        Me.btnCategoria.Name = "btnCategoria"
        Me.btnCategoria.Size = New System.Drawing.Size(123, 74)
        Me.btnCategoria.TabIndex = 11
        Me.btnCategoria.Text = "Categoria"
        Me.btnCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCategoria.UseVisualStyleBackColor = True
        '
        'btnCliente
        '
        Me.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCliente.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCliente.Image = Global.SysTerre.My.Resources.Resources.people
        Me.btnCliente.Location = New System.Drawing.Point(266, 72)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(123, 74)
        Me.btnCliente.TabIndex = 10
        Me.btnCliente.Text = "Cliente"
        Me.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'btnEmpleado
        '
        Me.btnEmpleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmpleado.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpleado.Image = Global.SysTerre.My.Resources.Resources.user_1
        Me.btnEmpleado.Location = New System.Drawing.Point(435, 71)
        Me.btnEmpleado.Name = "btnEmpleado"
        Me.btnEmpleado.Size = New System.Drawing.Size(123, 74)
        Me.btnEmpleado.TabIndex = 9
        Me.btnEmpleado.Text = "Empleado "
        Me.btnEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnEmpleado.UseVisualStyleBackColor = True
        '
        'btnFactura
        '
        Me.btnFactura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFactura.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactura.Image = Global.SysTerre.My.Resources.Resources.notepad
        Me.btnFactura.Location = New System.Drawing.Point(99, 168)
        Me.btnFactura.Name = "btnFactura"
        Me.btnFactura.Size = New System.Drawing.Size(123, 74)
        Me.btnFactura.TabIndex = 8
        Me.btnFactura.Text = "Factura"
        Me.btnFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnFactura.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SysTerre.My.Resources.Resources._Stop
        Me.btnCancelar.Location = New System.Drawing.Point(435, 446)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(123, 73)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Salir"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(190, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 57)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Menu Principal"
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(681, 531)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNavegador)
        Me.Controls.Add(Me.btnManualU)
        Me.Controls.Add(Me.btnReporductor)
        Me.Controls.Add(Me.btnCalBas)
        Me.Controls.Add(Me.btnManualT)
        Me.Controls.Add(Me.btnCalWin)
        Me.Controls.Add(Me.btnProducto)
        Me.Controls.Add(Me.btnProveedor)
        Me.Controls.Add(Me.btnUsuario)
        Me.Controls.Add(Me.btnVenta)
        Me.Controls.Add(Me.btnCategoria)
        Me.Controls.Add(Me.btnCliente)
        Me.Controls.Add(Me.btnEmpleado)
        Me.Controls.Add(Me.btnFactura)
        Me.Controls.Add(Me.btnCancelar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMenuPrincipal"
        Me.Text = "frmMenuPrincipal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnFactura As Button
    Friend WithEvents btnEmpleado As Button
    Friend WithEvents btnCliente As Button
    Friend WithEvents btnCategoria As Button
    Friend WithEvents btnVenta As Button
    Friend WithEvents btnUsuario As Button
    Friend WithEvents btnProveedor As Button
    Friend WithEvents btnProducto As Button
    Friend WithEvents btnCalWin As Button
    Friend WithEvents btnManualT As Button
    Friend WithEvents btnCalBas As Button
    Friend WithEvents btnReporductor As Button
    Friend WithEvents btnManualU As Button
    Friend WithEvents btnNavegador As Button
    Friend WithEvents Label1 As Label
End Class
