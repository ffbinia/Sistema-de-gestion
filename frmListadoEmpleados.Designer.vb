<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoEmpleados
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbpListado = New System.Windows.Forms.TabPage()
        Me.cboApellidos = New System.Windows.Forms.ComboBox()
        Me.lblApellidoListado = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblBarrioListado = New System.Windows.Forms.Label()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.gpbListado = New System.Windows.Forms.GroupBox()
        Me.lblListado = New System.Windows.Forms.Label()
        Me.btnVolverListado = New System.Windows.Forms.Button()
        Me.ltbListado = New System.Windows.Forms.ListBox()
        Me.TabControl1.SuspendLayout()
        Me.tbpListado.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gpbListado.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbpListado)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(15, 21)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(442, 123)
        Me.TabControl1.TabIndex = 0
        '
        'tbpListado
        '
        Me.tbpListado.Controls.Add(Me.cboApellidos)
        Me.tbpListado.Controls.Add(Me.lblApellidoListado)
        Me.tbpListado.Location = New System.Drawing.Point(4, 22)
        Me.tbpListado.Name = "tbpListado"
        Me.tbpListado.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpListado.Size = New System.Drawing.Size(434, 97)
        Me.tbpListado.TabIndex = 0
        Me.tbpListado.Text = "Apellido"
        Me.tbpListado.UseVisualStyleBackColor = True
        '
        'cboApellidos
        '
        Me.cboApellidos.FormattingEnabled = True
        Me.cboApellidos.Location = New System.Drawing.Point(144, 32)
        Me.cboApellidos.Name = "cboApellidos"
        Me.cboApellidos.Size = New System.Drawing.Size(121, 21)
        Me.cboApellidos.TabIndex = 1
        '
        'lblApellidoListado
        '
        Me.lblApellidoListado.AutoSize = True
        Me.lblApellidoListado.Location = New System.Drawing.Point(97, 40)
        Me.lblApellidoListado.Name = "lblApellidoListado"
        Me.lblApellidoListado.Size = New System.Drawing.Size(50, 13)
        Me.lblApellidoListado.TabIndex = 0
        Me.lblApellidoListado.Text = "Apellido: "
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.lblBarrioListado)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(434, 97)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Direccion"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(169, 29)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(116, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'lblBarrioListado
        '
        Me.lblBarrioListado.AutoSize = True
        Me.lblBarrioListado.Location = New System.Drawing.Point(125, 38)
        Me.lblBarrioListado.Name = "lblBarrioListado"
        Me.lblBarrioListado.Size = New System.Drawing.Size(37, 13)
        Me.lblBarrioListado.TabIndex = 0
        Me.lblBarrioListado.Text = "Barrio:"
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(378, 150)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(75, 23)
        Me.btnListar.TabIndex = 1
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'gpbListado
        '
        Me.gpbListado.Controls.Add(Me.ltbListado)
        Me.gpbListado.Controls.Add(Me.lblListado)
        Me.gpbListado.Location = New System.Drawing.Point(19, 179)
        Me.gpbListado.Name = "gpbListado"
        Me.gpbListado.Size = New System.Drawing.Size(434, 137)
        Me.gpbListado.TabIndex = 2
        Me.gpbListado.TabStop = False
        '
        'lblListado
        '
        Me.lblListado.AutoSize = True
        Me.lblListado.Location = New System.Drawing.Point(18, 30)
        Me.lblListado.Name = "lblListado"
        Me.lblListado.Size = New System.Drawing.Size(0, 13)
        Me.lblListado.TabIndex = 0
        '
        'btnVolverListado
        '
        Me.btnVolverListado.Location = New System.Drawing.Point(288, 150)
        Me.btnVolverListado.Name = "btnVolverListado"
        Me.btnVolverListado.Size = New System.Drawing.Size(75, 23)
        Me.btnVolverListado.TabIndex = 3
        Me.btnVolverListado.Text = "Volver"
        Me.btnVolverListado.UseVisualStyleBackColor = True
        '
        'ltbListado
        '
        Me.ltbListado.FormattingEnabled = True
        Me.ltbListado.Location = New System.Drawing.Point(21, 20)
        Me.ltbListado.Name = "ltbListado"
        Me.ltbListado.Size = New System.Drawing.Size(388, 108)
        Me.ltbListado.TabIndex = 1
        '
        'frmListadoEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 361)
        Me.Controls.Add(Me.btnVolverListado)
        Me.Controls.Add(Me.gpbListado)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmListadoEmpleados"
        Me.Text = "Listado de empleados"
        Me.TabControl1.ResumeLayout(False)
        Me.tbpListado.ResumeLayout(False)
        Me.tbpListado.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.gpbListado.ResumeLayout(False)
        Me.gpbListado.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbpListado As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnListar As Button
    Friend WithEvents cboApellidos As ComboBox
    Friend WithEvents lblApellidoListado As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblBarrioListado As Label
    Friend WithEvents gpbListado As GroupBox
    Friend WithEvents lblListado As Label
    Friend WithEvents btnVolverListado As Button
    Friend WithEvents ltbListado As ListBox
End Class
