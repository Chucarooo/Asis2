Imports System.Data
Imports System.Data.OleDb
Public Class Preceptores
    Inherits conexiones
    Private doc_ As Integer
    Private nombre_ As String

    Public Property doc() As Integer
        Get
            Return doc_
        End Get
        Set(ByVal value As Integer)
            doc_ = value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return doc_
        End Get
        Set(ByVal value As String)
            doc_ = value
        End Set
    End Property

    Public Sub Listar(ByVal grilla As DataGridView)
        Abrir()
        Dim strComando As String = "SELECT * FROM Preceptor"
        Dim comando As New OleDbCommand(strComando, conexion)
        Dim tabla As New DataTable
        Try
            tabla.Load(comando.ExecuteReader)
            grilla.DataSource = tabla
            Cerrar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
