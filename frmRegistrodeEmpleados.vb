Public Class frmRegistrodeEmpleados
    Public varRegistros As String = ""
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim result As DialogResult = MessageBox.Show("¿Desea cerrar esta ventana? Se perderan los datos no registrados!", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)
        If result = DialogResult.No Then
            Me.BringToFront()
        Else
            Me.Close()

        End If

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        If txtCuil.Text = "" Or txtNombre.Text = "" Or txtApellido.Text = "" Or txtCiudad.Text = "" Or txtBarrio.Text = "" Or txtCalle.Text = "" Or txtNumero.Text = "" Then
            MessageBox.Show("Por favor complete todos los campos", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            empleados(varFila, 0) = txtCuil.Text
            empleados(varFila, 1) = txtNombre.Text
            empleados(varFila, 2) = txtApellido.Text
            empleados(varFila, 3) = txtCiudad.Text
            empleados(varFila, 4) = txtBarrio.Text
            empleados(varFila, 5) = txtCalle.Text
            empleados(varFila, 6) = txtNumero.Text
            varFila = varFila + 1

            varRegistros = txtCuil.Text.Insert(2, "-") & " - " & txtNombre.Text & " - " & txtApellido.Text & " - " & txtCiudad.Text & " - " & txtBarrio.Text & " - " & txtCalle.Text & " - " & txtNumero.Text

            FileOpen(1, "Registro de empleados.txt", OpenMode.Append)

            WriteLine(1, varRegistros)

            FileClose()

            MessageBox.Show("¡Registro exitoso!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNombre.Text = ""
            txtApellido.Text = ""
            txtBarrio.Text = ""
            txtCalle.Text = ""
            txtCuil.Text = ""
            txtNumero.Text = ""
            txtCiudad.Text = ""
            txtCuil.Focus()
        End If
    End Sub
End Class