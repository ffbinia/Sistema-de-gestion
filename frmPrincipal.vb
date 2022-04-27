Public Class frmPrincipal
    Private Sub RegistroDeEmpleadosCTRLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeEmpleadosCTRLToolStripMenuItem.Click
        frmRegistrodeEmpleados.ShowDialog()
    End Sub

    Private Sub timerDiaHora_Tick(sender As Object, e As EventArgs) Handles timerDiaHora.Tick
        lblDiaHora.Text = DateTime.Now.ToString("F")
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        frmListadoEmpleados.ShowDialog()

    End Sub
End Class