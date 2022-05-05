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

        If mtbCuil.Text = "" Or txtNombre.Text = "" Or txtApellido.Text = "" Or txtCiudad.Text = "" Or txtBarrio.Text = "" Or txtCalle.Text = "" Or mtbNumero.Text = "" Then
            MessageBox.Show("Por favor complete todo el registro", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf mtbTelefono.Text = "" Or txtMail.Text = "" Then
            MessageBox.Show("¡Complete los datos de contacto!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Else


            empleados(varFila, 0) = mtbCuil.Text
            empleados(varFila, 1) = txtNombre.Text
            empleados(varFila, 2) = txtApellido.Text
            empleados(varFila, 3) = txtCiudad.Text
            empleados(varFila, 4) = txtBarrio.Text
            empleados(varFila, 5) = txtCalle.Text
            empleados(varFila, 6) = mtbNumero.Text
            empleados(varFila, 7) = mtbTelefono.Text
            empleados(varFila, 8) = txtMail.Text

            varFila = varFila + 1

            varRegistros = mtbCuil.Text & " - " & txtNombre.Text & " - " & txtApellido.Text & " - " & txtCiudad.Text & " - " & txtBarrio.Text & " - " & txtCalle.Text & " - " & mtbNumero.Text & " - " & mtbTelefono.Text & " - " & txtMail.Text

            FileOpen(ADEmpleados, ArchivoEmpleados, OpenMode.Append)

            WriteLine(ADEmpleados, varRegistros)

            FileClose(ADEmpleados)

            MessageBox.Show("¡Registro exitoso!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNombre.Text = ""
            txtApellido.Text = ""
            txtBarrio.Text = ""
            txtCalle.Text = ""
            mtbCuil.Text = ""
            mtbNumero.Text = ""
            txtCiudad.Text = ""
            mtbTelefono.Text = ""
            txtMail.Text = ""
            mtbCuil.Focus()

        End If
    End Sub



    Private Sub ptbImagen_Click(sender As Object, e As EventArgs) Handles ptbImagen.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            ptbImagen.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If

    End Sub
End Class