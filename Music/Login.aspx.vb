
Partial Class Login
    Inherits System.Web.UI.Page
    Dim DS As New Data.DataSet

    Protected Sub ingresar_ServerClick(sender As Object, e As EventArgs) Handles ingresar.ServerClick
        If DatoRepetidoDB("Usuarios", "Email", txtMail.Value) Then
            Response.Write("<script>alert('Funciona la wea')</script>")
            DS = CargarDatosUser(txtMail.Value)
            Session("Nombre") = DS.Tables(0).Rows.Item(0).Item(0).ToString
            Session("Email") = DS.Tables(0).Rows.Item(0).Item(1).ToString
            Session("Imagen") = DS.Tables(0).Rows.Item(0).Item(2).ToString
            Response.Redirect("Home.aspx")
        End If

    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
    End Sub

    Protected Sub registro_ServerClick(sender As Object, e As EventArgs) Handles registro.ServerClick
        Response.Redirect("Registro.aspx")
    End Sub
End Class
