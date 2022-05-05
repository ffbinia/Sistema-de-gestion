Public Class frmEditordeTexto


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        FileOpen(ADEmpleados, ArchivoEmpleados, OpenMode.Input)


        Dim varContador As Integer = 0

        While Not EOF(ADEmpleados)

            varRegistros = LineInput(ADEmpleados)

            If varRegistros.Contains(txtBuscar.Text) Then

                varContador = varContador + 1

            End If

        End While
        txtEditorTexto.Text = ""

        MessageBox.Show("SE ENCONTRO LA PALABRA Q BUSCABAS " & varContador & " VECES!")
        FileClose(ADEmpleados)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        frmPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        FileOpen(ADEditorTexto, ArchivoEditado, OpenMode.Append)
        Dim varEditado As String = ""
        varEditado = txtEditorTexto.Text

        WriteLine(ADEditorTexto, varEditado)
        MessageBox.Show("Registro creado con exito")
        FileClose(ADEditorTexto)

    End Sub

    Private Sub btnEspacio_Click(sender As Object, e As EventArgs) Handles btnEspacio.Click
        Dim caracter As String = ""
        txtEditorTexto.Text = txtEditorTexto.Text.Replace(" ", caracter)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub

    Private Sub btnCaracter_Click(sender As Object, e As EventArgs) Handles btnCaracter.Click
        Dim caracter As String = ""

        txtEditorTexto.Text = txtEditorTexto.Text.Replace(txtQuitar.Text, caracter)
    End Sub

    Private Sub frmEditordeTexto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarEmpleados()
        txtEditorTexto.Text = varRegistros

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        FileOpen(ADEmpleados, ArchivoEmpleados, OpenMode.Output)
    End Sub
End Class