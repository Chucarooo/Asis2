Public Class Cargar_Alumno
    Private alum_ As New alumnos
    Private alumnuevo_ As Boolean

    Public Property alum() As alumnos
        Get
            Return alum_
        End Get
        Set(ByVal value As alumnos)
            alum_ = value
        End Set
    End Property

    Private Property alumnuevo() As Boolean
        Get
            Return alumnuevo_
        End Get
        Set(ByVal value As Boolean)
            alumnuevo_ = value
        End Set
    End Property

    Public Sub New(ByVal alum As alumnos) 'Constructor para Modificar
        InitializeComponent()
        txt_doc_al.Text = alum.aldni
        txt_name_al.Text = alum.alnombre
        txt_domic_al.Text = alum.aldomicilio

        Me.Text = "Modificar Alumno"
        alumnuevo = False
    End Sub

    Public Sub New() 'Constructor para Agregar
        InitializeComponent()
        txt_doc_al.Text = ""
        txt_name_al.Text = ""
        txt_domic_al.Text = ""

        Me.Text = "Agregar Alumno"
        alumnuevo = True
    End Sub
    Function cambia(ByVal cambiatext As String) As String
        Dim a As String = StrConv(cambiatext, VbStrConv.ProperCase)
        Return a
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txt_name_al.Text = "" Or txt_doc_al.Text = "" Or txt_domic_al.Text = "" Or txt_apellido_al2.Text = "" Then
            MsgBox("Debes rellenar todos los campos para continuar")
            Return
        End If

        If Not IsNumeric(txt_doc_al.Text) And _
            txt_doc_al.Text <> "" Then
            Beep()
            MsgBox("Se debe ingresar solo números")
            txt_doc_al.Text = ""
            Return
        End If
        If txt_doc_al.Text.Length < 8 Then
            Beep()
            MsgBox("El número de documento está mal escrito")
            Return
        End If

        Me.txt_name_al.Text = cambia(Me.txt_name_al.Text)
        Me.txt_apellido_al2.Text = cambia(Me.txt_apellido_al2.Text)
        Me.txt_domic_al.Text = cambia(Me.txt_domic_al.Text)

        alum.alnombre = txt_name_al.Text + " " + txt_apellido_al2.Text
        alum.aldni = txt_doc_al.Text
        alum.aldomicilio = txt_domic_al.Text
        alum.albeg = rb_beg1.Checked
        alum.alcerttrab = rb_cdt1.Checked



        If alumnuevo = False Then
            alum.aldni = txt_doc_al.Text
            alum.Modificar(alum)
            Close()
        Else
            alum.Agregar(alum)
            Close()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
    Private Sub txtnombres_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_doc_al.KeyPress
        txt_doc_al.MaxLength = 8
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If


    End Sub

    Private Sub txt_apellido_al2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_apellido_al2.TextChanged

    End Sub
End Class