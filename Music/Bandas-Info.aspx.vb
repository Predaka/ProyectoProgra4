
Partial Class Bandas_Info
    Inherits System.Web.UI.Page
    Dim DS As New Data.DataSet
    Dim voto_realizado As Boolean
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        ValidarVoto()
        If System.DateTime.Now.DayOfWeek <> DayOfWeek.Sunday And voto_realizado Or System.DateTime.Now.DayOfWeek = DayOfWeek.Sunday And voto_realizado Then
            btnVotar.Disabled = True
        Else
            btnVotar.Disabled = False
        End If
        If Request.QueryString("id") <> "" Then
            Dim id = CInt(Request.QueryString("id").ToString)
            DS = BandaInfo(id)
            imagen.Attributes("src") = "imagenes/" & DS.Tables(0).Rows.Item(0).Item(0).ToString & ""
            cancion.Attributes("src") = "audios/" & DS.Tables(0).Rows.Item(0).Item(1).ToString & ""
            Informacion.InnerHtml = DS.Tables(0).Rows.Item(0).Item(2).ToString
        End If
    End Sub

    Protected Sub btnVotar_ServerClick(sender As Object, e As EventArgs) Handles btnVotar.ServerClick
        Dim id = CInt(Request.QueryString("id").ToString)
        If insertarVoto(id, Session("Email").ToString) Then
            voto_realizado = True
            btnVotar.Disabled = True
            Response.Write("<script>alert('Voto Realizado.!');</script>")
            actualizarVoto()
        End If
    End Sub

    Sub actualizarVoto()
        Dim sql As String = "update Usuarios set Emitio_voto = 'True' where Email = '" & Session("Email").ToString & "' "
        EjecutaSQL(sql)
    End Sub

    Sub ValidarVoto()
        If VerificarVoto("Usuarios", "Emitio_voto", "false", Session("Email").ToString) Then
            voto_realizado = False
        Else
            voto_realizado = True
        End If
    End Sub
End Class
