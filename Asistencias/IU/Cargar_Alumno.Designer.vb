<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cargar_Alumno
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cargar_Alumno))
        Me.lbl_doc = New System.Windows.Forms.Label
        Me.txt_doc_al = New System.Windows.Forms.TextBox
        Me.txt_name_al = New System.Windows.Forms.TextBox
        Me.lbl_name = New System.Windows.Forms.Label
        Me.txt_domic_al = New System.Windows.Forms.TextBox
        Me.lbl_dom = New System.Windows.Forms.Label
        Me.lbl_beg = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.rb_cdt1 = New System.Windows.Forms.RadioButton
        Me.rb_cdt2 = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.rb_beg1 = New System.Windows.Forms.RadioButton
        Me.rb_beg2 = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.lbl_al = New System.Windows.Forms.Label
        Me.txt_apellido_al2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_doc
        '
        Me.lbl_doc.AutoSize = True
        Me.lbl_doc.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_doc.ForeColor = System.Drawing.Color.White
        Me.lbl_doc.Location = New System.Drawing.Point(24, 154)
        Me.lbl_doc.Name = "lbl_doc"
        Me.lbl_doc.Size = New System.Drawing.Size(162, 19)
        Me.lbl_doc.TabIndex = 0
        Me.lbl_doc.Text = "Numero de Documento:"
        '
        'txt_doc_al
        '
        Me.txt_doc_al.BackColor = System.Drawing.Color.White
        Me.txt_doc_al.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_doc_al.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_doc_al.Location = New System.Drawing.Point(28, 176)
        Me.txt_doc_al.Name = "txt_doc_al"
        Me.txt_doc_al.Size = New System.Drawing.Size(171, 19)
        Me.txt_doc_al.TabIndex = 3
        '
        'txt_name_al
        '
        Me.txt_name_al.BackColor = System.Drawing.Color.White
        Me.txt_name_al.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_name_al.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_name_al.Location = New System.Drawing.Point(28, 113)
        Me.txt_name_al.Name = "txt_name_al"
        Me.txt_name_al.Size = New System.Drawing.Size(171, 19)
        Me.txt_name_al.TabIndex = 1
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lbl_name.ForeColor = System.Drawing.Color.White
        Me.lbl_name.Location = New System.Drawing.Point(24, 91)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(71, 19)
        Me.lbl_name.TabIndex = 2
        Me.lbl_name.Text = "Nombres:"
        '
        'txt_domic_al
        '
        Me.txt_domic_al.BackColor = System.Drawing.Color.White
        Me.txt_domic_al.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_domic_al.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_domic_al.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_domic_al.Location = New System.Drawing.Point(225, 176)
        Me.txt_domic_al.Name = "txt_domic_al"
        Me.txt_domic_al.Size = New System.Drawing.Size(171, 19)
        Me.txt_domic_al.TabIndex = 4
        '
        'lbl_dom
        '
        Me.lbl_dom.AutoSize = True
        Me.lbl_dom.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lbl_dom.ForeColor = System.Drawing.Color.White
        Me.lbl_dom.Location = New System.Drawing.Point(221, 154)
        Me.lbl_dom.Name = "lbl_dom"
        Me.lbl_dom.Size = New System.Drawing.Size(74, 19)
        Me.lbl_dom.TabIndex = 4
        Me.lbl_dom.Text = "Domicilio:"
        '
        'lbl_beg
        '
        Me.lbl_beg.AutoSize = True
        Me.lbl_beg.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lbl_beg.ForeColor = System.Drawing.Color.White
        Me.lbl_beg.Location = New System.Drawing.Point(221, 218)
        Me.lbl_beg.Name = "lbl_beg"
        Me.lbl_beg.Size = New System.Drawing.Size(122, 19)
        Me.lbl_beg.TabIndex = 6
        Me.lbl_beg.Text = "Boleto Educativo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Certificado de Trabajo:"
        '
        'rb_cdt1
        '
        Me.rb_cdt1.AutoSize = True
        Me.rb_cdt1.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.rb_cdt1.ForeColor = System.Drawing.Color.White
        Me.rb_cdt1.Location = New System.Drawing.Point(0, 1)
        Me.rb_cdt1.Name = "rb_cdt1"
        Me.rb_cdt1.Size = New System.Drawing.Size(35, 21)
        Me.rb_cdt1.TabIndex = 5
        Me.rb_cdt1.TabStop = True
        Me.rb_cdt1.Text = "Si"
        Me.rb_cdt1.UseVisualStyleBackColor = True
        '
        'rb_cdt2
        '
        Me.rb_cdt2.AutoSize = True
        Me.rb_cdt2.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.rb_cdt2.ForeColor = System.Drawing.Color.White
        Me.rb_cdt2.Location = New System.Drawing.Point(41, 1)
        Me.rb_cdt2.Name = "rb_cdt2"
        Me.rb_cdt2.Size = New System.Drawing.Size(42, 21)
        Me.rb_cdt2.TabIndex = 6
        Me.rb_cdt2.TabStop = True
        Me.rb_cdt2.Text = "No"
        Me.rb_cdt2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rb_cdt1)
        Me.Panel1.Controls.Add(Me.rb_cdt2)
        Me.Panel1.Location = New System.Drawing.Point(28, 241)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(94, 24)
        Me.Panel1.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rb_beg1)
        Me.Panel2.Controls.Add(Me.rb_beg2)
        Me.Panel2.Location = New System.Drawing.Point(225, 240)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(94, 25)
        Me.Panel2.TabIndex = 14
        '
        'rb_beg1
        '
        Me.rb_beg1.AutoSize = True
        Me.rb_beg1.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.rb_beg1.ForeColor = System.Drawing.Color.White
        Me.rb_beg1.Location = New System.Drawing.Point(0, 2)
        Me.rb_beg1.Name = "rb_beg1"
        Me.rb_beg1.Size = New System.Drawing.Size(35, 21)
        Me.rb_beg1.TabIndex = 7
        Me.rb_beg1.TabStop = True
        Me.rb_beg1.Text = "Si"
        Me.rb_beg1.UseVisualStyleBackColor = True
        '
        'rb_beg2
        '
        Me.rb_beg2.AutoSize = True
        Me.rb_beg2.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.rb_beg2.ForeColor = System.Drawing.Color.White
        Me.rb_beg2.Location = New System.Drawing.Point(41, 2)
        Me.rb_beg2.Name = "rb_beg2"
        Me.rb_beg2.Size = New System.Drawing.Size(42, 21)
        Me.rb_beg2.TabIndex = 8
        Me.rb_beg2.TabStop = True
        Me.rb_beg2.Text = "No"
        Me.rb_beg2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(223, 284)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 30)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(22, 284)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(175, 30)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lbl_al
        '
        Me.lbl_al.AutoSize = True
        Me.lbl_al.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbl_al.Font = New System.Drawing.Font("Calibri", 34.0!)
        Me.lbl_al.ForeColor = System.Drawing.Color.White
        Me.lbl_al.Location = New System.Drawing.Point(12, 9)
        Me.lbl_al.Name = "lbl_al"
        Me.lbl_al.Size = New System.Drawing.Size(409, 56)
        Me.lbl_al.TabIndex = 17
        Me.lbl_al.Text = "DATOS DEL ALUMNO"
        '
        'txt_apellido_al2
        '
        Me.txt_apellido_al2.BackColor = System.Drawing.Color.White
        Me.txt_apellido_al2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_apellido_al2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_apellido_al2.Location = New System.Drawing.Point(225, 113)
        Me.txt_apellido_al2.Name = "txt_apellido_al2"
        Me.txt_apellido_al2.Size = New System.Drawing.Size(171, 19)
        Me.txt_apellido_al2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(221, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Apellidos:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(-10, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(461, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Cargar_Alumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(432, 332)
        Me.Controls.Add(Me.lbl_al)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_beg)
        Me.Controls.Add(Me.txt_domic_al)
        Me.Controls.Add(Me.lbl_dom)
        Me.Controls.Add(Me.txt_name_al)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.txt_apellido_al2)
        Me.Controls.Add(Me.txt_doc_al)
        Me.Controls.Add(Me.lbl_doc)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Cargar_Alumno"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargar Alumno"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_doc As System.Windows.Forms.Label
    Friend WithEvents txt_doc_al As System.Windows.Forms.TextBox
    Friend WithEvents txt_name_al As System.Windows.Forms.TextBox
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents txt_domic_al As System.Windows.Forms.TextBox
    Friend WithEvents lbl_dom As System.Windows.Forms.Label
    Friend WithEvents lbl_beg As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rb_cdt1 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_cdt2 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rb_beg1 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_beg2 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lbl_al As System.Windows.Forms.Label
    Friend WithEvents txt_apellido_al2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
