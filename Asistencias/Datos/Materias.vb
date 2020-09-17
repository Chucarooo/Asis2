Imports System.Data
Imports System.Data.OleDb

Public Class Materias
    Inherits conexiones

    Private id_ As Integer
    Private nombre_ As String
    Private CantHoras_ As Integer
    Private idProfe_ As Integer
    Private idCarrera_ As Integer

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
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

    Public Property CantHoras() As Integer
        Get
            Return CantHoras_
        End Get
        Set(ByVal value As Integer)
            CantHoras_ = value
        End Set
    End Property

    Public Property idProfe() As Integer
        Get
            Return idProfe_
        End Get
        Set(ByVal value As Integer)
            idProfe_ = value
        End Set
    End Property

    Public Property idCarrera() As Integer
        Get
            Return idCarrera_
        End Get
        Set(ByVal value As Integer)
            idCarrera_ = value
        End Set
    End Property

    Public Sub Listar(ByVal grilla As DataGridView)
        Abrir()
        Dim strComando As String = "SELECT * FROM Materias"
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
