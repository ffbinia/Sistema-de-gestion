<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeEmpleadosCTRLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VistaPreviaDeImpresionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.timerDiaHora = New System.Windows.Forms.Timer(Me.components)
        Me.lblDiaHora = New System.Windows.Forms.Label()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorDeTextoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gray
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ListadoToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(483, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "mnsInicio"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroDeEmpleadosCTRLToolStripMenuItem, Me.AbrirToolStripMenuItem, Me.ImprimirToolStripMenuItem, Me.VistaPreviaDeImpresionToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'RegistroDeEmpleadosCTRLToolStripMenuItem
        '
        Me.RegistroDeEmpleadosCTRLToolStripMenuItem.Name = "RegistroDeEmpleadosCTRLToolStripMenuItem"
        Me.RegistroDeEmpleadosCTRLToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.RegistroDeEmpleadosCTRLToolStripMenuItem.Text = "Registro de empleados"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'VistaPreviaDeImpresionToolStripMenuItem
        '
        Me.VistaPreviaDeImpresionToolStripMenuItem.Name = "VistaPreviaDeImpresionToolStripMenuItem"
        Me.VistaPreviaDeImpresionToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.VistaPreviaDeImpresionToolStripMenuItem.Text = "Vista previa de impresion"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ListadoToolStripMenuItem
        '
        Me.ListadoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem, Me.EditorDeTextoToolStripMenuItem})
        Me.ListadoToolStripMenuItem.Name = "ListadoToolStripMenuItem"
        Me.ListadoToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.ListadoToolStripMenuItem.Text = "Listado"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'timerDiaHora
        '
        Me.timerDiaHora.Enabled = True
        '
        'lblDiaHora
        '
        Me.lblDiaHora.AutoSize = True
        Me.lblDiaHora.Location = New System.Drawing.Point(12, 160)
        Me.lblDiaHora.Name = "lblDiaHora"
        Me.lblDiaHora.Size = New System.Drawing.Size(0, 13)
        Me.lblDiaHora.TabIndex = 2
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'EditorDeTextoToolStripMenuItem
        '
        Me.EditorDeTextoToolStripMenuItem.Name = "EditorDeTextoToolStripMenuItem"
        Me.EditorDeTextoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EditorDeTextoToolStripMenuItem.Text = "Editor de texto"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 182)
        Me.Controls.Add(Me.lblDiaHora)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = "Sistema de Gestion - Modulo Recursos Humanos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroDeEmpleadosCTRLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VistaPreviaDeImpresionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents timerDiaHora As Timer
    Friend WithEvents lblDiaHora As Label
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditorDeTextoToolStripMenuItem As ToolStripMenuItem
End Class
