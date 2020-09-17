Public Class ProfesoresGrid

    Private Sub ProfesoresGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim profe As New Profesores
        profe.Listar(DataGridView2)
    End Sub
End Class