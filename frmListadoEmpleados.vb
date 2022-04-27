Public Class frmListadoEmpleados
    Private Sub frmListadoEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        varFila = 0
        Do While empleados(varFila, 2) <> ""
            cboApellidos.Items.Add(empleados(varFila, 2))
            varFila = varFila + 1
        Loop
    End Sub

    Private Sub btnVolverListado_Click(sender As Object, e As EventArgs) Handles btnVolverListado.Click
        frmPrincipal.Show()
        Me.Close()
        cboApellidos.Items.Clear()
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        ltbListado.Items.Clear()


        FileOpen(1, "Registro de empleados.txt", OpenMode.Input)

        Dim varContenido As String = ""

            While Not EOF(1)

                varContenido = LineInput(1)

            ltbListado.Text = ltbListado.Text & varContenido & vbCrLf


        End While

        FileClose(1)

        varFila = 0

        While varFila <= empleados.GetUpperBound(0)

            If cboApellidos.Text = empleados(varFila, 2) Then
                ltbListado.Items.Add(empleados(varFila, 0))
                ltbListado.Items.Add(empleados(varFila, 1))
                ltbListado.Items.Add(empleados(varFila, 3))
                ltbListado.Items.Add(empleados(varFila, 4))
                ltbListado.Items.Add(empleados(varFila, 5))
                ltbListado.Items.Add(empleados(varFila, 6))

            End If
            varFila = varFila + 1
        End While



    End Sub


End Class