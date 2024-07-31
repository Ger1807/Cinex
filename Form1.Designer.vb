<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_entrar = New System.Windows.Forms.Button()
        Me.tbx_contraseña = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.tbx_usuario = New System.Windows.Forms.TextBox()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.lbl_contraseña = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(93, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btn_entrar
        '
        Me.btn_entrar.Location = New System.Drawing.Point(123, 415)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_entrar.TabIndex = 1
        Me.btn_entrar.Text = "Entrar"
        Me.btn_entrar.UseVisualStyleBackColor = True
        '
        'tbx_contraseña
        '
        Me.tbx_contraseña.ForeColor = System.Drawing.Color.Black
        Me.tbx_contraseña.Location = New System.Drawing.Point(110, 231)
        Me.tbx_contraseña.Name = "tbx_contraseña"
        Me.tbx_contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.tbx_contraseña.Size = New System.Drawing.Size(100, 20)
        Me.tbx_contraseña.TabIndex = 3
        Me.tbx_contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(110, 320)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'tbx_usuario
        '
        Me.tbx_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_usuario.ForeColor = System.Drawing.Color.Black
        Me.tbx_usuario.Location = New System.Drawing.Point(110, 156)
        Me.tbx_usuario.Name = "tbx_usuario"
        Me.tbx_usuario.Size = New System.Drawing.Size(100, 20)
        Me.tbx_usuario.TabIndex = 5
        Me.tbx_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_usuario.Enabled = False
        Me.lbl_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lbl_usuario.Location = New System.Drawing.Point(135, 159)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(50, 13)
        Me.lbl_usuario.TabIndex = 6
        Me.lbl_usuario.Text = "Usuario"
        '
        'lbl_contraseña
        '
        Me.lbl_contraseña.AutoSize = True
        Me.lbl_contraseña.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_contraseña.Enabled = False
        Me.lbl_contraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contraseña.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lbl_contraseña.Location = New System.Drawing.Point(125, 234)
        Me.lbl_contraseña.Name = "lbl_contraseña"
        Me.lbl_contraseña.Size = New System.Drawing.Size(71, 13)
        Me.lbl_contraseña.TabIndex = 7
        Me.lbl_contraseña.Text = "Contraseña"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(319, 450)
        Me.Controls.Add(Me.lbl_contraseña)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.tbx_usuario)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.tbx_contraseña)
        Me.Controls.Add(Me.btn_entrar)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_entrar As Button
    Friend WithEvents tbx_contraseña As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents tbx_usuario As TextBox
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents lbl_contraseña As Label
End Class
