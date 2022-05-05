Public Class frmListadoEmpleados
    Private Sub frmListadoEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        varFila = 0
        Do While empleados(varFila, 2) <> ""
            cboApellidos.Items.Add(empleados(varFila, 2))
            varFila = varFila + 1
        Loop

    End Sub

    Private Sub btnVolverListado_Click(sender As Object, e As EventArgs) Handles btnVolverListado.Click

        Dim result As DialogResult = MessageBox.Show("¿Volver al menu principal?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Me.Close()
            txtApellidoListar.Text = ""
            txtBarrioListar.Text = ""
            cboApellidos.Text = ""
            ltbListado.Items.Clear()
        Else
            Me.BringToFront()
        End If



    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        If txtApellidoListar.Text = "" And cboApellidos.Text = "" And txtBarrioListar.Text = "" Then
            ltbListado.Items.Clear()

            FileOpen(ADEmpleados, ArchivoEmpleados, OpenMode.Input)
            ltbListado.Items.Add(" CUIL " & "-" & " NOMBRE " & "-" & " APELLIDO " & "-" & " CIUDAD " & "-" & " BARRIO " & "-" & " CALLE " & "-" & " NUMERO " & "-" & " TELEFONO " & "-" & " MAIL ")

            While Not EOF(1)
                varRegistros = LineInput(ADEmpleados)
                ltbListado.Items.Add(varRegistros)
            End While

            FileClose(ADEmpleados)

        ElseIf txtApellidoListar.Text <> "" And cboApellidos.Text = "" And txtBarrioListar.Text = "" Then

            ltbListado.Items.Clear()

            FileOpen(ADEmpleados, ArchivoEmpleados, OpenMode.Input)
            ltbListado.Items.Add(" CUIL " & "-" & " NOMBRE " & "-" & " APELLIDO " & "-" & " CIUDAD " & "-" & " BARRIO " & "-" & " CALLE " & "-" & " NUMERO " & "-" & " TELEFONO " & "-" & " MAIL ")

            While Not EOF(ADEmpleados)
                varRegistros = LineInput(ADEmpleados)
                If varRegistros.Contains(txtApellidoListar.Text) Then
                    ltbListado.Items.Add(varRegistros)
                End If

            End While

            FileClose(ADEmpleados)
        ElseIf txtApellidoListar.Text = "" And cboApellidos.Text = "" And txtBarrioListar.Text <> "" Then

            ltbListado.Items.Clear()
            ltbListado.Items.Add(" CUIL " & "-" & " NOMBRE " & "-" & " APELLIDO " & "-" & " CIUDAD " & "-" & " BARRIO " & "-" & " CALLE " & "-" & " NUMERO " & "-" & " TELEFONO " & "-" & " MAIL ")

            FileOpen(ADEmpleados, ArchivoEmpleados, OpenMode.Input)

            While Not EOF(ADEmpleados)
                varRegistros = LineInput(ADEmpleados)
                If varRegistros.Contains(txtBarrioListar.Text) Then
                    ltbListado.Items.Add(varRegistros)
                End If

            End While

            FileClose(ADEmpleados)

            'agregue esta matriz para que en el combobox me tire los apellidos cargados en el ultimo registro, porque no pude hacer filtrar solo por los apellidos de un archivo .txt

        ElseIf cboApellidos.Text <> "" And txtApellidoListar.Text = "" And txtBarrioListar.Text = "" Then
            ltbListado.Items.Clear()

            varFila = 0

            While varFila <= empleados.GetUpperBound(0)

                If cboApellidos.Text = empleados(varFila, 2) Then
                    ltbListado.Items.Add("Filtrado por apellido: " & cboApellidos.Text)
                    ltbListado.Items.Add("CUIL: " & empleados(varFila, 0))
                    ltbListado.Items.Add("Nombre: " & empleados(varFila, 1))
                    ltbListado.Items.Add("Ciudad: " & empleados(varFila, 3))
                    ltbListado.Items.Add("Barrio: " & empleados(varFila, 4))
                    ltbListado.Items.Add("Calle: " & empleados(varFila, 5))
                    ltbListado.Items.Add("Numero: " & empleados(varFila, 6))
                    ltbListado.Items.Add("Telefono: " & empleados(varFila, 7))
                    ltbListado.Items.Add("Mail: " & empleados(varFila, 8))
                    ltbListado.Items.Add(" ------------------- ")
                End If
                varFila = varFila + 1
            End While
        Else
            MessageBox.Show("¡¡Realice de un filtro a la vez!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtApellidoListar.Text = ""
            txtBarrioListar.Text = ""
            cboApellidos.Text = ""

        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        ltbListado.Items.Clear()
    End Sub
End Class