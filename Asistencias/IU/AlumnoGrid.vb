
Public Class AlumnoGrid

    Private Sub AlumnoGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim alum As New alumnos
        alum.Listar(DataGridView2)
    End Sub
End Class