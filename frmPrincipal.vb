Public Class frmPrincipal
    Private Sub RegistroDeEmpleadosCTRLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeEmpleadosCTRLToolStripMenuItem.Click
        frmRegistrodeEmpleados.ShowDialog()
    End Sub

    Private Sub timerDiaHora_Tick(sender As Object, e As EventArgs) Handles tmrDiaHora.Tick
        tssHorayFecha.Text = DateTime.Now.ToString("F")
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        frmListadoEmpleados.ShowDialog()

    End Sub

    Private Sub EditorDeTextoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditorDeTextoToolStripMenuItem.Click
        frmEditordeTexto.ShowDialog()

    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles tssHorayFecha.Click

    End Sub
End Class