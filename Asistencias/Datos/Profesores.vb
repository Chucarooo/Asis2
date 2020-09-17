Imports System.Data
Imports System.Data.OleDb

Public Class Profesores
    Inherits conexiones
    Private legajo_ As Integer
    Private nombre_ As String

    Public Property legajo() As Integer
        Get
            Return legajo_

        End Get
        Set(ByVal value As Integer)
            legajo_ = value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return nombre_
        End Get
        Set(ByVal value As String)
            nombre_ = value
        End Set
    End Property

    Public Sub Listar(ByVal grilla As DataGridView)
        Abrir()
        Dim strComando As String = "SELECT * FROM Profesor"
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
