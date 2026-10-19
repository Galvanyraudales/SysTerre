<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSplash
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplash))
        Me.lblSistema = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblDesarollador = New System.Windows.Forms.Label()
        Me.lblPlataforma = New System.Windows.Forms.Label()
        Me.lblCoppyright = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pctLogoSistemas = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctLogoSistemas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSistema
        '
        Me.lblSistema.AutoSize = True
        Me.lblSistema.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSistema.Location = New System.Drawing.Point(332, 89)
        Me.lblSistema.Name = "lblSistema"
        Me.lblSistema.Size = New System.Drawing.Size(426, 79)
        Me.lblSistema.TabIndex = 0
        Me.lblSistema.Text = "Sistema Systɘrrɘ"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(466, 168)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(218, 57)
        Me.lblVersion.TabIndex = 1
        Me.lblVersion.Text = "Version 1.0"
        '
        'lblDesarollador
        '
        Me.lblDesarollador.AutoSize = True
        Me.lblDesarollador.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesarollador.Location = New System.Drawing.Point(375, 9)
        Me.lblDesarollador.Name = "lblDesarollador"
        Me.lblDesarollador.Size = New System.Drawing.Size(418, 25)
        Me.lblDesarollador.TabIndex = 2
        Me.lblDesarollador.Text = "Desarrollador: Lic.. Galvany Raudales"
        '
        'lblPlataforma
        '
        Me.lblPlataforma.AutoSize = True
        Me.lblPlataforma.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlataforma.Location = New System.Drawing.Point(12, 295)
        Me.lblPlataforma.Name = "lblPlataforma"
        Me.lblPlataforma.Size = New System.Drawing.Size(427, 34)
        Me.lblPlataforma.TabIndex = 3
        Me.lblPlataforma.Text = "Plataforma: Windows 10 y 11"
        '
        'lblCoppyright
        '
        Me.lblCoppyright.AutoSize = True
        Me.lblCoppyright.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoppyright.Location = New System.Drawing.Point(562, 45)
        Me.lblCoppyright.Name = "lblCoppyright"
        Me.lblCoppyright.Size = New System.Drawing.Size(203, 25)
        Me.lblCoppyright.TabIndex = 4
        Me.lblCoppyright.Text = "Copyright © 2026"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(445, 300)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(339, 29)
        Me.ProgressBar1.TabIndex = 7
        '
        'Timer1
        '
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.SysTerre.My.Resources.Resources._1_vxjAHkrXbGG6gOiPZgjeZA
        Me.PictureBox2.Location = New System.Drawing.Point(35, 62)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(258, 194)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'pctLogoSistemas
        '
        Me.pctLogoSistemas.Image = Global.SysTerre.My.Resources.Resources.startup1
        Me.pctLogoSistemas.Location = New System.Drawing.Point(397, 168)
        Me.pctLogoSistemas.Name = "pctLogoSistemas"
        Me.pctLogoSistemas.Size = New System.Drawing.Size(45, 41)
        Me.pctLogoSistemas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctLogoSistemas.TabIndex = 6
        Me.pctLogoSistemas.TabStop = False
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(814, 342)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.pctLogoSistemas)
        Me.Controls.Add(Me.lblCoppyright)
        Me.Controls.Add(Me.lblPlataforma)
        Me.Controls.Add(Me.lblDesarollador)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblSistema)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSplash"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctLogoSistemas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSistema As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblDesarollador As Label
    Friend WithEvents lblPlataforma As Label
    Friend WithEvents lblCoppyright As Label
    Friend WithEvents pctLogoSistemas As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
End Class
