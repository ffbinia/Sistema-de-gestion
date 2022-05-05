Module EstructuraDatos

    Public Sub ListarEmpleados()
        FileOpen(ADEmpleados, ArchivoEmpleados, OpenMode.Input)
        While Not EOF(ADEmpleados)
            Input(ADEmpleados, varRegistros)
        End While
        FileClose(ADEmpleados)
    End Sub

    Public empleados(29, 8) As String

    Public ADEmpleados As Integer = 1
    Public ArchivoEmpleados As String = "Registro de empleados.txt"
    Public ADEditorTexto As Integer = 2
    Public ArchivoEditado As String = "Archivo Editado Empleados.secreto"

    Public varRegistros As String
    Public varFila As Integer = 0
    Public varColumna As Integer = 0
End Module
