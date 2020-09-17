Public Class CarrerasGrid

    Private Sub CarrerasGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim carre As New Carreras
        carre.Listar(DataGridView1)
    End Sub
End Class