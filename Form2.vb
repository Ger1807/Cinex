Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PeliculasDataSet1.Peliculas' Puede moverla o quitarla según sea necesario.
        Me.PeliculasTableAdapter1.Fill(Me.PeliculasDataSet1.Peliculas)
        'TODO: esta línea de código carga datos en la tabla 'PeliculasDataSet.Peliculas' Puede moverla o quitarla según sea necesario.
        Me.PeliculasTableAdapter.Fill(Me.PeliculasDataSet.Peliculas)

    End Sub

    'consulta para eliminar
    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        PeliculasTableAdapter1.Delete1(tbx_sala.Text)
        Me.PeliculasTableAdapter1.Fill(Me.PeliculasDataSet1.Peliculas)
    End Sub

    'consulta para guardar
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        PeliculasBindingSource1.EndEdit()
        MsgBox("Guardado", MsgBoxStyle.Information, "")
        Me.PeliculasTableAdapter1.Fill(Me.PeliculasDataSet1.Peliculas)
    End Sub

    'consulta para editar
    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        PeliculasTableAdapter1.Update1(tbx_titulo.Text, tbx_director.Text, tbx_genero.Text, tbx_productor.Text, tbx_hora.Text, tbx_sala.Text)
        Me.PeliculasTableAdapter1.Fill(Me.PeliculasDataSet1.Peliculas)
    End Sub

    'consulta para actualizar
    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        PeliculasTableAdapter1.Add(tbx_titulo.Text, tbx_director.Text, tbx_genero.Text, tbx_productor.Text, tbx_hora.Text)
        Me.PeliculasTableAdapter1.Fill(Me.PeliculasDataSet1.Peliculas)
    End Sub

    'boton de creditos
    Private Sub btn_creditos_Click(sender As Object, e As EventArgs) Handles btn_creditos.Click
        Form3.Show()
        Me.Close()
    End Sub

    'noton para volver
    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class