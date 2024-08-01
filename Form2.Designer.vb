<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim SalaLabel As System.Windows.Forms.Label
        Dim TituloLabel As System.Windows.Forms.Label
        Dim DirectorLabel As System.Windows.Forms.Label
        Dim GeneroLabel As System.Windows.Forms.Label
        Dim Hora_de_la_FunciónLabel As System.Windows.Forms.Label
        Dim ProductorLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.btn_creditos = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbx_sala = New System.Windows.Forms.TextBox()
        Me.PeliculasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeliculasDataSet1 = New WindowsApp3.PeliculasDataSet1()
        Me.PeliculasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeliculasDataSet = New WindowsApp3.PeliculasDataSet()
        Me.tbx_titulo = New System.Windows.Forms.TextBox()
        Me.tbx_director = New System.Windows.Forms.TextBox()
        Me.tbx_genero = New System.Windows.Forms.TextBox()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.PeliculasTableAdapter = New WindowsApp3.PeliculasDataSetTableAdapters.PeliculasTableAdapter()
        Me.TableAdapterManager = New WindowsApp3.PeliculasDataSetTableAdapters.TableAdapterManager()
        Me.PeliculasTableAdapter1 = New WindowsApp3.PeliculasDataSet1TableAdapters.PeliculasTableAdapter()
        Me.TableAdapterManager1 = New WindowsApp3.PeliculasDataSet1TableAdapters.TableAdapterManager()
        Me.PeliculasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbx_hora = New System.Windows.Forms.TextBox()
        Me.tbx_productor = New System.Windows.Forms.TextBox()
        SalaLabel = New System.Windows.Forms.Label()
        TituloLabel = New System.Windows.Forms.Label()
        DirectorLabel = New System.Windows.Forms.Label()
        GeneroLabel = New System.Windows.Forms.Label()
        Hora_de_la_FunciónLabel = New System.Windows.Forms.Label()
        ProductorLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeliculasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeliculasDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeliculasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeliculasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeliculasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SalaLabel
        '
        SalaLabel.AutoSize = True
        SalaLabel.ForeColor = System.Drawing.Color.White
        SalaLabel.Location = New System.Drawing.Point(27, 115)
        SalaLabel.Name = "SalaLabel"
        SalaLabel.Size = New System.Drawing.Size(31, 13)
        SalaLabel.TabIndex = 8
        SalaLabel.Text = "Sala:"
        '
        'TituloLabel
        '
        TituloLabel.AutoSize = True
        TituloLabel.ForeColor = System.Drawing.Color.White
        TituloLabel.Location = New System.Drawing.Point(170, 115)
        TituloLabel.Name = "TituloLabel"
        TituloLabel.Size = New System.Drawing.Size(36, 13)
        TituloLabel.TabIndex = 9
        TituloLabel.Text = "Titulo:"
        '
        'DirectorLabel
        '
        DirectorLabel.AutoSize = True
        DirectorLabel.ForeColor = System.Drawing.Color.White
        DirectorLabel.Location = New System.Drawing.Point(318, 115)
        DirectorLabel.Name = "DirectorLabel"
        DirectorLabel.Size = New System.Drawing.Size(47, 13)
        DirectorLabel.TabIndex = 11
        DirectorLabel.Text = "Director:"
        '
        'GeneroLabel
        '
        GeneroLabel.AutoSize = True
        GeneroLabel.ForeColor = System.Drawing.Color.White
        GeneroLabel.Location = New System.Drawing.Point(477, 115)
        GeneroLabel.Name = "GeneroLabel"
        GeneroLabel.Size = New System.Drawing.Size(45, 13)
        GeneroLabel.TabIndex = 13
        GeneroLabel.Text = "Genero:"
        '
        'Hora_de_la_FunciónLabel
        '
        Hora_de_la_FunciónLabel.AutoSize = True
        Hora_de_la_FunciónLabel.ForeColor = System.Drawing.Color.White
        Hora_de_la_FunciónLabel.Location = New System.Drawing.Point(299, 151)
        Hora_de_la_FunciónLabel.Name = "Hora_de_la_FunciónLabel"
        Hora_de_la_FunciónLabel.Size = New System.Drawing.Size(100, 13)
        Hora_de_la_FunciónLabel.TabIndex = 23
        Hora_de_la_FunciónLabel.Text = "Hora de la Función:"
        '
        'ProductorLabel
        '
        ProductorLabel.AutoSize = True
        ProductorLabel.ForeColor = System.Drawing.Color.White
        ProductorLabel.Location = New System.Drawing.Point(131, 151)
        ProductorLabel.Name = "ProductorLabel"
        ProductorLabel.Size = New System.Drawing.Size(56, 13)
        ProductorLabel.TabIndex = 24
        ProductorLabel.Text = "Productor:"
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(11, 423)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_volver.TabIndex = 3
        Me.btn_volver.Text = "Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'btn_creditos
        '
        Me.btn_creditos.Location = New System.Drawing.Point(578, 423)
        Me.btn_creditos.Name = "btn_creditos"
        Me.btn_creditos.Size = New System.Drawing.Size(75, 23)
        Me.btn_creditos.TabIndex = 4
        Me.btn_creditos.Text = "Creditos"
        Me.btn_creditos.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(553, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(36, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Germo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(289, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cartelera"
        '
        'tbx_sala
        '
        Me.tbx_sala.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeliculasBindingSource1, "Sala", True))
        Me.tbx_sala.ForeColor = System.Drawing.Color.Black
        Me.tbx_sala.Location = New System.Drawing.Point(64, 112)
        Me.tbx_sala.Name = "tbx_sala"
        Me.tbx_sala.Size = New System.Drawing.Size(100, 20)
        Me.tbx_sala.TabIndex = 9
        '
        'PeliculasBindingSource1
        '
        Me.PeliculasBindingSource1.DataMember = "Peliculas"
        Me.PeliculasBindingSource1.DataSource = Me.PeliculasDataSet1
        '
        'PeliculasDataSet1
        '
        Me.PeliculasDataSet1.DataSetName = "PeliculasDataSet1"
        Me.PeliculasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PeliculasBindingSource
        '
        Me.PeliculasBindingSource.DataMember = "Peliculas"
        Me.PeliculasBindingSource.DataSource = Me.PeliculasDataSet
        '
        'PeliculasDataSet
        '
        Me.PeliculasDataSet.DataSetName = "PeliculasDataSet"
        Me.PeliculasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbx_titulo
        '
        Me.tbx_titulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeliculasBindingSource1, "Titulo", True))
        Me.tbx_titulo.ForeColor = System.Drawing.Color.Black
        Me.tbx_titulo.Location = New System.Drawing.Point(212, 112)
        Me.tbx_titulo.Name = "tbx_titulo"
        Me.tbx_titulo.Size = New System.Drawing.Size(100, 20)
        Me.tbx_titulo.TabIndex = 10
        '
        'tbx_director
        '
        Me.tbx_director.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeliculasBindingSource1, "Director", True))
        Me.tbx_director.ForeColor = System.Drawing.Color.Black
        Me.tbx_director.Location = New System.Drawing.Point(371, 112)
        Me.tbx_director.Name = "tbx_director"
        Me.tbx_director.Size = New System.Drawing.Size(100, 20)
        Me.tbx_director.TabIndex = 12
        '
        'tbx_genero
        '
        Me.tbx_genero.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeliculasBindingSource1, "Genero", True))
        Me.tbx_genero.ForeColor = System.Drawing.Color.Black
        Me.tbx_genero.Location = New System.Drawing.Point(528, 112)
        Me.tbx_genero.Name = "tbx_genero"
        Me.tbx_genero.Size = New System.Drawing.Size(100, 20)
        Me.tbx_genero.TabIndex = 14
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.White
        Me.btn_eliminar.BackgroundImage = CType(resources.GetObject("btn_eliminar.BackgroundImage"), System.Drawing.Image)
        Me.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_eliminar.Location = New System.Drawing.Point(134, 413)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(36, 33)
        Me.btn_eliminar.TabIndex = 19
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.White
        Me.btn_agregar.BackgroundImage = CType(resources.GetObject("btn_agregar.BackgroundImage"), System.Drawing.Image)
        Me.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_agregar.Location = New System.Drawing.Point(494, 413)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(36, 30)
        Me.btn_agregar.TabIndex = 20
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.White
        Me.btn_guardar.BackgroundImage = CType(resources.GetObject("btn_guardar.BackgroundImage"), System.Drawing.Image)
        Me.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_guardar.ForeColor = System.Drawing.Color.White
        Me.btn_guardar.Location = New System.Drawing.Point(92, 414)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(36, 32)
        Me.btn_guardar.TabIndex = 21
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'btn_editar
        '
        Me.btn_editar.BackColor = System.Drawing.Color.White
        Me.btn_editar.BackgroundImage = CType(resources.GetObject("btn_editar.BackgroundImage"), System.Drawing.Image)
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_editar.Location = New System.Drawing.Point(536, 413)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(36, 32)
        Me.btn_editar.TabIndex = 22
        Me.btn_editar.UseVisualStyleBackColor = False
        '
        'PeliculasTableAdapter
        '
        Me.PeliculasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PeliculasTableAdapter = Me.PeliculasTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApp3.PeliculasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PeliculasTableAdapter1
        '
        Me.PeliculasTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.PeliculasTableAdapter = Me.PeliculasTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = WindowsApp3.PeliculasDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PeliculasDataGridView
        '
        Me.PeliculasDataGridView.AllowUserToOrderColumns = True
        Me.PeliculasDataGridView.AutoGenerateColumns = False
        Me.PeliculasDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.PeliculasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PeliculasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.PeliculasDataGridView.DataSource = Me.PeliculasBindingSource1
        Me.PeliculasDataGridView.Location = New System.Drawing.Point(12, 188)
        Me.PeliculasDataGridView.Name = "PeliculasDataGridView"
        Me.PeliculasDataGridView.Size = New System.Drawing.Size(641, 220)
        Me.PeliculasDataGridView.TabIndex = 23
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Sala"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Sala"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Titulo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Titulo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Director"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Director"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Genero"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Genero"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Productor"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Productor"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Hora de la Función"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Hora de la Función"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'tbx_hora
        '
        Me.tbx_hora.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeliculasBindingSource1, "Hora de la Función", True))
        Me.tbx_hora.Location = New System.Drawing.Point(405, 148)
        Me.tbx_hora.Name = "tbx_hora"
        Me.tbx_hora.Size = New System.Drawing.Size(100, 20)
        Me.tbx_hora.TabIndex = 24
        '
        'tbx_productor
        '
        Me.tbx_productor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeliculasBindingSource1, "Productor", True))
        Me.tbx_productor.Location = New System.Drawing.Point(193, 148)
        Me.tbx_productor.Name = "tbx_productor"
        Me.tbx_productor.Size = New System.Drawing.Size(100, 20)
        Me.tbx_productor.TabIndex = 25
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(670, 466)
        Me.Controls.Add(ProductorLabel)
        Me.Controls.Add(Me.tbx_productor)
        Me.Controls.Add(Hora_de_la_FunciónLabel)
        Me.Controls.Add(Me.tbx_hora)
        Me.Controls.Add(Me.PeliculasDataGridView)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(GeneroLabel)
        Me.Controls.Add(Me.tbx_genero)
        Me.Controls.Add(DirectorLabel)
        Me.Controls.Add(Me.tbx_director)
        Me.Controls.Add(TituloLabel)
        Me.Controls.Add(Me.tbx_titulo)
        Me.Controls.Add(SalaLabel)
        Me.Controls.Add(Me.tbx_sala)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_creditos)
        Me.Controls.Add(Me.btn_volver)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cartelera"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeliculasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeliculasDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeliculasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeliculasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeliculasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PeliculasDataSet As PeliculasDataSet
    Friend WithEvents PeliculasBindingSource As BindingSource
    Friend WithEvents PeliculasTableAdapter As PeliculasDataSetTableAdapters.PeliculasTableAdapter
    Friend WithEvents TableAdapterManager As PeliculasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btn_volver As Button
    Friend WithEvents btn_creditos As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbx_sala As TextBox
    Friend WithEvents tbx_titulo As TextBox
    Friend WithEvents tbx_director As TextBox
    Friend WithEvents tbx_genero As TextBox
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_editar As Button
    Friend WithEvents PeliculasDataSet1 As PeliculasDataSet1
    Friend WithEvents PeliculasBindingSource1 As BindingSource
    Friend WithEvents PeliculasTableAdapter1 As PeliculasDataSet1TableAdapters.PeliculasTableAdapter
    Friend WithEvents TableAdapterManager1 As PeliculasDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents PeliculasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents tbx_hora As TextBox
    Friend WithEvents tbx_productor As TextBox
End Class
