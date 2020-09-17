Public Class PreceptoresGrid

    Private Sub PreceptoresGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim prece As New Preceptores
        prece.Listar(DataGridView2)
    End Sub
End Class