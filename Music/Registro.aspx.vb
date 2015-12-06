
Partial Class Registro
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub BtnRegistrar_ServerClick(sender As Object, e As EventArgs) Handles BtnRegistrar.ServerClick
        If txtnombre.Value = "" Then
            Response.Write("<script>alert('Favor Verificar la informacion')</script>")
            txtnombre.Focus()

        Else
            If txtEmail.Value.Contains("@") And txtEmail.Value.Contains(".com") Then
                If txtPassword.Value = txtRepassword.Value Then
                    agregarUsuario()
                    Response.Redirect("Login.aspx")
                Else
                    Response.Write("<script>alert('Favor Verificar la informacion')</script>")

                    txtPassword.Focus()
                End If
            Else
                Response.Write("<script>alert('Favor Verificar la informacion')</script>")
                txtEmail.Focus()
            End If
        End If
    End Sub

    Public Sub agregarUsuario()
        Dim sql As String
        sql = "insert into Usuarios values ('" & txtnombre.Value & "','" & txtEmail.Value & "','" & txtPassword.Value & "', 'Cliente', 'true', 'photo12.png' )"
        EjecutaSQL(sql)
        Response.Write("<sript>alert('Registro Exitoso')</script>")

    End Sub
End Class
