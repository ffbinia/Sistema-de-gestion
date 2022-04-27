<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrodeEmpleados
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
        Me.gpbRegistro = New System.Windows.Forms.GroupBox()
        Me.lblCuil = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtCuil = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.ptbImagen = New System.Windows.Forms.PictureBox()
        Me.tbcRegistro = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblCiudad = New System.Windows.Forms.Label()
        Me.lblBarrio = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.txtBarrio = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.gpbRegistro.SuspendLayout()
        CType(Me.ptbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcRegistro.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbRegistro
        '
        Me.gpbRegistro.BackColor = System.Drawing.Color.Silver
        Me.gpbRegistro.Controls.Add(Me.ptbImagen)
        Me.gpbRegistro.Controls.Add(Me.txtApellido)
        Me.gpbRegistro.Controls.Add(Me.txtNombre)
        Me.gpbRegistro.Controls.Add(Me.txtCuil)
        Me.gpbRegistro.Controls.Add(Me.lblApellido)
        Me.gpbRegistro.Controls.Add(Me.lblNombre)
        Me.gpbRegistro.Controls.Add(Me.lblCuil)
        Me.gpbRegistro.Location = New System.Drawing.Point(28, 12)
        Me.gpbRegistro.Name = "gpbRegistro"
        Me.gpbRegistro.Size = New System.Drawing.Size(408, 146)
        Me.gpbRegistro.TabIndex = 0
        Me.gpbRegistro.TabStop = False
        '
        'lblCuil
        '
        Me.lblCuil.AutoSize = True
        Me.lblCuil.Location = New System.Drawing.Point(16, 35)
        Me.lblCuil.Name = "lblCuil"
        Me.lblCuil.Size = New System.Drawing.Size(32, 13)
        Me.lblCuil.TabIndex = 0
        Me.lblCuil.Text = "CUIT"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(16, 73)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(16, 111)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 2
        Me.lblApellido.Text = "Apellido"
        '
        'txtCuil
        '
        Me.txtCuil.Location = New System.Drawing.Point(77, 28)
        Me.txtCuil.Name = "txtCuil"
        Me.txtCuil.Size = New System.Drawing.Size(88, 20)
        Me.txtCuil.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(77, 66)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(138, 20)
        Me.txtNombre.TabIndex = 4
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(77, 104)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(138, 20)
        Me.txtApellido.TabIndex = 5
        '
        'ptbImagen
        '
        Me.ptbImagen.Location = New System.Drawing.Point(243, 24)
        Me.ptbImagen.Name = "ptbImagen"
        Me.ptbImagen.Size = New System.Drawing.Size(137, 101)
        Me.ptbImagen.TabIndex = 6
        Me.ptbImagen.TabStop = False
        '
        'tbcRegistro
        '
        Me.tbcRegistro.Controls.Add(Me.TabPage1)
        Me.tbcRegistro.Controls.Add(Me.TabPage2)
        Me.tbcRegistro.Location = New System.Drawing.Point(28, 164)
        Me.tbcRegistro.Name = "tbcRegistro"
        Me.tbcRegistro.SelectedIndex = 0
        Me.tbcRegistro.Size = New System.Drawing.Size(408, 184)
        Me.tbcRegistro.TabIndex = 1
        Me.tbcRegistro.Tag = ""
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Silver
        Me.TabPage1.Controls.Add(Me.txtNumero)
        Me.TabPage1.Controls.Add(Me.txtCalle)
        Me.TabPage1.Controls.Add(Me.txtBarrio)
        Me.TabPage1.Controls.Add(Me.txtCiudad)
        Me.TabPage1.Controls.Add(Me.lblNumero)
        Me.TabPage1.Controls.Add(Me.lblCalle)
        Me.TabPage1.Controls.Add(Me.lblBarrio)
        Me.TabPage1.Controls.Add(Me.lblCiudad)
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(400, 158)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Direccion"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(400, 158)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Contactos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lblCiudad
        '
        Me.lblCiudad.AutoSize = True
        Me.lblCiudad.Location = New System.Drawing.Point(16, 29)
        Me.lblCiudad.Name = "lblCiudad"
        Me.lblCiudad.Size = New System.Drawing.Size(40, 13)
        Me.lblCiudad.TabIndex = 0
        Me.lblCiudad.Text = "Ciudad"
        '
        'lblBarrio
        '
        Me.lblBarrio.AutoSize = True
        Me.lblBarrio.Location = New System.Drawing.Point(16, 57)
        Me.lblBarrio.Name = "lblBarrio"
        Me.lblBarrio.Size = New System.Drawing.Size(34, 13)
        Me.lblBarrio.TabIndex = 1
        Me.lblBarrio.Text = "Barrio"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Location = New System.Drawing.Point(16, 83)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(30, 13)
        Me.lblCalle.TabIndex = 2
        Me.lblCalle.Text = "Calle"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(16, 108)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(44, 13)
        Me.lblNumero.TabIndex = 3
        Me.lblNumero.Text = "Numero"
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(73, 22)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(241, 20)
        Me.txtCiudad.TabIndex = 4
        '
        'txtBarrio
        '
        Me.txtBarrio.Location = New System.Drawing.Point(73, 50)
        Me.txtBarrio.Name = "txtBarrio"
        Me.txtBarrio.Size = New System.Drawing.Size(241, 20)
        Me.txtBarrio.TabIndex = 5
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(73, 76)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(241, 20)
        Me.txtCalle.TabIndex = 6
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(73, 101)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(103, 20)
        Me.txtNumero.TabIndex = 7
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(271, 356)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(357, 356)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrar.TabIndex = 3
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'frmRegistrodeEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 391)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.tbcRegistro)
        Me.Controls.Add(Me.gpbRegistro)
        Me.Name = "frmRegistrodeEmpleados"
        Me.Text = "Registro de empleados"
        Me.gpbRegistro.ResumeLayout(False)
        Me.gpbRegistro.PerformLayout()
        CType(Me.ptbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcRegistro.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpbRegistro As GroupBox
    Friend WithEvents ptbImagen As PictureBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCuil As TextBox
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblCuil As Label
    Friend WithEvents tbcRegistro As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents txtBarrio As TextBox
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents lblNumero As Label
    Friend WithEvents lblCalle As Label
    Friend WithEvents lblBarrio As Label
    Friend WithEvents lblCiudad As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnRegistrar As Button
End Class
