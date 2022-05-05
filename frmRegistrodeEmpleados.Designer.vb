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
        Me.mtbCuil = New System.Windows.Forms.MaskedTextBox()
        Me.ptbImagen = New System.Windows.Forms.PictureBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCuil = New System.Windows.Forms.Label()
        Me.tbcRegistro = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.mtbNumero = New System.Windows.Forms.MaskedTextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.txtBarrio = New System.Windows.Forms.TextBox()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.lblBarrio = New System.Windows.Forms.Label()
        Me.lblCiudad = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.mtbTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.gpbRegistro.SuspendLayout()
        CType(Me.ptbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcRegistro.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbRegistro
        '
        Me.gpbRegistro.BackColor = System.Drawing.Color.Silver
        Me.gpbRegistro.Controls.Add(Me.mtbCuil)
        Me.gpbRegistro.Controls.Add(Me.ptbImagen)
        Me.gpbRegistro.Controls.Add(Me.txtApellido)
        Me.gpbRegistro.Controls.Add(Me.txtNombre)
        Me.gpbRegistro.Controls.Add(Me.lblApellido)
        Me.gpbRegistro.Controls.Add(Me.lblNombre)
        Me.gpbRegistro.Controls.Add(Me.lblCuil)
        Me.gpbRegistro.Location = New System.Drawing.Point(28, 12)
        Me.gpbRegistro.Name = "gpbRegistro"
        Me.gpbRegistro.Size = New System.Drawing.Size(408, 146)
        Me.gpbRegistro.TabIndex = 0
        Me.gpbRegistro.TabStop = False
        '
        'mtbCuil
        '
        Me.mtbCuil.Location = New System.Drawing.Point(77, 28)
        Me.mtbCuil.Mask = "00-00000000-0"
        Me.mtbCuil.Name = "mtbCuil"
        Me.mtbCuil.Size = New System.Drawing.Size(103, 20)
        Me.mtbCuil.TabIndex = 7
        '
        'ptbImagen
        '
        Me.ptbImagen.BackgroundImage = Global.prySistemaDeGestion.My.Resources.Resources.agregar_img
        Me.ptbImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbImagen.Location = New System.Drawing.Point(243, 24)
        Me.ptbImagen.Name = "ptbImagen"
        Me.ptbImagen.Size = New System.Drawing.Size(137, 101)
        Me.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbImagen.TabIndex = 6
        Me.ptbImagen.TabStop = False
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(77, 104)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(138, 20)
        Me.txtApellido.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(77, 66)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(138, 20)
        Me.txtNombre.TabIndex = 4
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
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(16, 73)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
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
        Me.TabPage1.Controls.Add(Me.mtbNumero)
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
        'mtbNumero
        '
        Me.mtbNumero.Location = New System.Drawing.Point(73, 101)
        Me.mtbNumero.Mask = "00000"
        Me.mtbNumero.Name = "mtbNumero"
        Me.mtbNumero.Size = New System.Drawing.Size(103, 20)
        Me.mtbNumero.TabIndex = 8
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(73, 76)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(241, 20)
        Me.txtCalle.TabIndex = 6
        '
        'txtBarrio
        '
        Me.txtBarrio.Location = New System.Drawing.Point(73, 50)
        Me.txtBarrio.Name = "txtBarrio"
        Me.txtBarrio.Size = New System.Drawing.Size(241, 20)
        Me.txtBarrio.TabIndex = 5
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(73, 22)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(241, 20)
        Me.txtCiudad.TabIndex = 4
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
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Location = New System.Drawing.Point(16, 83)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(30, 13)
        Me.lblCalle.TabIndex = 2
        Me.lblCalle.Text = "Calle"
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
        'lblCiudad
        '
        Me.lblCiudad.AutoSize = True
        Me.lblCiudad.Location = New System.Drawing.Point(16, 29)
        Me.lblCiudad.Name = "lblCiudad"
        Me.lblCiudad.Size = New System.Drawing.Size(40, 13)
        Me.lblCiudad.TabIndex = 0
        Me.lblCiudad.Text = "Ciudad"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Silver
        Me.TabPage2.Controls.Add(Me.mtbTelefono)
        Me.TabPage2.Controls.Add(Me.txtMail)
        Me.TabPage2.Controls.Add(Me.lblMail)
        Me.TabPage2.Controls.Add(Me.lblTelefono)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(400, 158)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Contactos"
        '
        'mtbTelefono
        '
        Me.mtbTelefono.Location = New System.Drawing.Point(166, 49)
        Me.mtbTelefono.Mask = "+54-0000000000"
        Me.mtbTelefono.Name = "mtbTelefono"
        Me.mtbTelefono.Size = New System.Drawing.Size(100, 20)
        Me.mtbTelefono.TabIndex = 4
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(166, 76)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(100, 20)
        Me.txtMail.TabIndex = 3
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Location = New System.Drawing.Point(111, 83)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(26, 13)
        Me.lblMail.TabIndex = 1
        Me.lblMail.Text = "Mail"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(111, 57)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(55, 13)
        Me.lblTelefono.TabIndex = 0
        Me.lblTelefono.Text = "Telefono: "
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
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
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpbRegistro As GroupBox
    Friend WithEvents ptbImagen As PictureBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblCuil As Label
    Friend WithEvents tbcRegistro As TabControl
    Friend WithEvents TabPage1 As TabPage
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
    Friend WithEvents txtMail As TextBox
    Friend WithEvents lblMail As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents mtbCuil As MaskedTextBox
    Friend WithEvents mtbNumero As MaskedTextBox
    Friend WithEvents mtbTelefono As MaskedTextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
