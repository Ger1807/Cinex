Imports System.IO

Public Class Form1
    'Como no supe hacer un placeholder pues use labels y cada vez que se hace click en los textbox los labels se borran
    Private Sub tbx_usuario_TextChanged(sender As Object, e As EventArgs) Handles tbx_usuario.Click
        lbl_usuario.Text = ""
    End Sub


    Private Sub tbx_contraseña_TextChanged(sender As Object, e As EventArgs) Handles tbx_contraseña.Click
        lbl_contraseña.Text = ""

    End Sub

    'Estructura del login
    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Dim Usuario_login, Contraseña_login As String

        'entrada de los textbox
        Usuario_login = tbx_usuario.Text
        Contraseña_login = tbx_contraseña.Text

        'con esto puedo autenticar los datos del login
        If (Usuario_login = "Germo") And (Contraseña_login = "1807") Then
            'con esto cierro el login y abro la base de datos
            Form2.Show()
            Me.Close()
        Else
            'mensaje de error 
            MsgBox("Usuario y/o contraseña incorrectos", MsgBoxStyle.Critical, "")
        End If
    End Sub
End Class
