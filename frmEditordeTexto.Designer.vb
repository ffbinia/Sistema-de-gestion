<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditordeTexto
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
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCaracter = New System.Windows.Forms.Button()
        Me.btnEspacio = New System.Windows.Forms.Button()
        Me.gpbEditor = New System.Windows.Forms.GroupBox()
        Me.lblCaracteres = New System.Windows.Forms.Label()
        Me.lblCantidadCaracteres = New System.Windows.Forms.Label()
        Me.gpbQuitar = New System.Windows.Forms.GroupBox()
        Me.txtQuitar = New System.Windows.Forms.TextBox()
        Me.txtModificar = New System.Windows.Forms.TextBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblModificar = New System.Windows.Forms.Label()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.txtEditorTexto = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.gpbEditor.SuspendLayout()
        Me.gpbQuitar.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(245, 59)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 0
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(245, 28)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(359, 187)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(541, 187)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(450, 187)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnCaracter
        '
        Me.btnCaracter.Location = New System.Drawing.Point(131, 18)
        Me.btnCaracter.Name = "btnCaracter"
        Me.btnCaracter.Size = New System.Drawing.Size(75, 23)
        Me.btnCaracter.TabIndex = 5
        Me.btnCaracter.Text = "Caracter"
        Me.btnCaracter.UseVisualStyleBackColor = True
        '
        'btnEspacio
        '
        Me.btnEspacio.Location = New System.Drawing.Point(131, 47)
        Me.btnEspacio.Name = "btnEspacio"
        Me.btnEspacio.Size = New System.Drawing.Size(75, 23)
        Me.btnEspacio.TabIndex = 6
        Me.btnEspacio.Text = "Espacios"
        Me.btnEspacio.UseVisualStyleBackColor = True
        '
        'gpbEditor
        '
        Me.gpbEditor.Controls.Add(Me.lblCaracteres)
        Me.gpbEditor.Controls.Add(Me.lblCantidadCaracteres)
        Me.gpbEditor.Controls.Add(Me.gpbQuitar)
        Me.gpbEditor.Controls.Add(Me.txtModificar)
        Me.gpbEditor.Controls.Add(Me.txtBuscar)
        Me.gpbEditor.Controls.Add(Me.lblModificar)
        Me.gpbEditor.Controls.Add(Me.lblBuscar)
        Me.gpbEditor.Controls.Add(Me.btnBuscar)
        Me.gpbEditor.Controls.Add(Me.btnModificar)
        Me.gpbEditor.Location = New System.Drawing.Point(22, 216)
        Me.gpbEditor.Name = "gpbEditor"
        Me.gpbEditor.Size = New System.Drawing.Size(604, 139)
        Me.gpbEditor.TabIndex = 7
        Me.gpbEditor.TabStop = False
        Me.gpbEditor.Text = "Herramientas"
        '
        'lblCaracteres
        '
        Me.lblCaracteres.AutoSize = True
        Me.lblCaracteres.Location = New System.Drawing.Point(161, 111)
        Me.lblCaracteres.Name = "lblCaracteres"
        Me.lblCaracteres.Size = New System.Drawing.Size(10, 13)
        Me.lblCaracteres.TabIndex = 13
        Me.lblCaracteres.Text = "-"
        '
        'lblCantidadCaracteres
        '
        Me.lblCantidadCaracteres.AutoSize = True
        Me.lblCantidadCaracteres.Location = New System.Drawing.Point(32, 111)
        Me.lblCantidadCaracteres.Name = "lblCantidadCaracteres"
        Me.lblCantidadCaracteres.Size = New System.Drawing.Size(123, 13)
        Me.lblCantidadCaracteres.TabIndex = 12
        Me.lblCantidadCaracteres.Text = "Cantidad de caracteres: "
        '
        'gpbQuitar
        '
        Me.gpbQuitar.Controls.Add(Me.txtQuitar)
        Me.gpbQuitar.Controls.Add(Me.btnEspacio)
        Me.gpbQuitar.Controls.Add(Me.btnCaracter)
        Me.gpbQuitar.Location = New System.Drawing.Point(337, 28)
        Me.gpbQuitar.Name = "gpbQuitar"
        Me.gpbQuitar.Size = New System.Drawing.Size(232, 86)
        Me.gpbQuitar.TabIndex = 12
        Me.gpbQuitar.TabStop = False
        Me.gpbQuitar.Text = "Quitar"
        '
        'txtQuitar
        '
        Me.txtQuitar.Location = New System.Drawing.Point(22, 21)
        Me.txtQuitar.Name = "txtQuitar"
        Me.txtQuitar.Size = New System.Drawing.Size(91, 20)
        Me.txtQuitar.TabIndex = 11
        '
        'txtModificar
        '
        Me.txtModificar.Location = New System.Drawing.Point(90, 59)
        Me.txtModificar.Name = "txtModificar"
        Me.txtModificar.Size = New System.Drawing.Size(137, 20)
        Me.txtModificar.TabIndex = 10
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(90, 28)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(139, 20)
        Me.txtBuscar.TabIndex = 9
        '
        'lblModificar
        '
        Me.lblModificar.AutoSize = True
        Me.lblModificar.Location = New System.Drawing.Point(32, 66)
        Me.lblModificar.Name = "lblModificar"
        Me.lblModificar.Size = New System.Drawing.Size(50, 13)
        Me.lblModificar.TabIndex = 8
        Me.lblModificar.Text = "Modificar"
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(32, 35)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(40, 13)
        Me.lblBuscar.TabIndex = 7
        Me.lblBuscar.Text = "Buscar"
        '
        'txtEditorTexto
        '
        Me.txtEditorTexto.Location = New System.Drawing.Point(22, 111)
        Me.txtEditorTexto.Multiline = True
        Me.txtEditorTexto.Name = "txtEditorTexto"
        Me.txtEditorTexto.Size = New System.Drawing.Size(604, 54)
        Me.txtEditorTexto.TabIndex = 8
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(22, 13)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(604, 82)
        Me.ListBox1.TabIndex = 9
        '
        'frmEditordeTexto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 368)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.txtEditorTexto)
        Me.Controls.Add(Me.gpbEditor)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Name = "frmEditordeTexto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editor de texto"
        Me.gpbEditor.ResumeLayout(False)
        Me.gpbEditor.PerformLayout()
        Me.gpbQuitar.ResumeLayout(False)
        Me.gpbQuitar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnModificar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnCaracter As Button
    Friend WithEvents btnEspacio As Button
    Friend WithEvents gpbEditor As GroupBox
    Friend WithEvents lblCaracteres As Label
    Friend WithEvents lblCantidadCaracteres As Label
    Friend WithEvents gpbQuitar As GroupBox
    Friend WithEvents txtQuitar As TextBox
    Friend WithEvents txtModificar As TextBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents lblModificar As Label
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtEditorTexto As TextBox
    Friend WithEvents ListBox1 As ListBox
End Class
