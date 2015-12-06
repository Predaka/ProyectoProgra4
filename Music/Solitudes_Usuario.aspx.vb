Imports System.Web.UI.HtmlControls
Partial Class Solitudes_Usuario
    Inherits System.Web.UI.Page

    Dim ds As New System.Data.DataSet

    Protected Sub Page_Init(sender As Object, e As EventArgs) Handles Me.Init
        ds = CargarSolicitudes_User("bryan@gmail.com")
        If ds.Tables(0).Rows.Count = 0 Then
            contenido.InnerText = "No hay solicitudes asosiadas."
        Else
            For i = 0 To ds.Tables(0).Rows.Count - 1
                Dim request = New HtmlGenericControl("div")
                Dim id = ds.Tables(0).Rows.Item(i).Item(0)
                Dim asunto = ds.Tables(0).Rows.Item(i).Item(1).ToString
                Dim descripcion = ds.Tables(0).Rows.Item(i).Item(2).ToString
                Dim estado = ds.Tables(0).Rows.Item(i).Item(3)
                If IsDBNull(estado) Then

                ElseIf estado = True Then
                    request.Attributes("style") = "border: 1px solid #32CD32"
                    request.Attributes("style") = "background-color: #ADDFAD"
                ElseIf estado = False Then

                    request.Attributes("style") = "border: 1px solid #ff0000"
                    request.Attributes("style") = "background-color: #F5A9A9"
                End If
                request.Attributes("class") = "request"
                request.Attributes("runat") = "server"
                request.InnerHtml = "<p id=" & id & " runat='server'></p>" & vbCrLf & "<h3>" & asunto & "<a runat='server' >Eliminar</a> <a runat='server' href='Solicitud.aspx?id=" & id & "'>Editar</a></h3>" & vbCrLf & "<span>" & descripcion & "</span>"

                contenido.Controls.Add(request)
            Next
        End If
    End Sub

    Protected Sub btnNuevaSolicitud_ServerClick(sender As Object, e As EventArgs) Handles btnNuevaSolicitud.ServerClick
        Response.Redirect("Solicitud.aspx")

    End Sub
End Class
