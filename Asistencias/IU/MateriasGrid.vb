Public Class MateriasGrid

    Private Sub MateriasGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mate As New Materias
        mate.Listar(DataGridView2)
    End Sub
End Class