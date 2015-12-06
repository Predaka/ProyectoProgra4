
Partial Class Solicitud
    Inherits System.Web.UI.Page

    Protected Sub btnEnviar_ServerClick(sender As Object, e As EventArgs) Handles btnEnviar.ServerClick
        If insertarSolicitud(Session("Email").ToString, txtAsunto.Value, txtDescripcion.Text) Then
            Response.Write("<script>alert('Solicitud Enviada.')</script>")
            txtAsunto.Value = ""
            txtDescripcion.Text = ""
        Else
            Response.Write("<script>alert('No se Pudo enviar.')</script>")
        End If
    End Sub

    Protected Sub Page_Init(sender As Object, e As EventArgs) Handles Me.Init
        Dim ds As New Data.DataSet
        If Request.QueryString("id") = "" Then

        Else
            Dim id As String = Request.QueryString("id")
            Dim id2 As Integer = CInt(id)
            ds = CargarSolicitud(id)
            txtAsunto.Value = ds.Tables(0).Rows.Item(0).Item(0).ToString
            txtDescripcion.Text = ds.Tables(0).Rows.Item(0).Item(1).ToString
        End If
    End Sub
End Class
