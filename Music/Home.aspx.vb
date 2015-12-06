
Partial Class Home
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargartop()
    End Sub

    Public Sub cargartop()
        Dim sql As String
        Dim ds As New Data.DataSet
        Dim Nombre As String
        Dim votos As Integer
        Dim img As String
        sql = "select top 10 count(v.idBanda)as numero_votos,b.idBanda,b.Nombre,b.Imagen,b.Estado from votos v inner join Bandas b  on v.idBanda = b.idBanda group by b.idBanda,b.Nombre,b.Imagen,b.Estado having b.Estado = 'True' order by count(v.idBanda) desc;"
        LlenarDS(ds, sql)

        For i = 0 To ds.Tables(0).Rows.Count - 1
            Dim div = New HtmlGenericControl("div")
            Nombre = ds.Tables(0).Rows.Item(i).Item(2).ToString
            votos = ds.Tables(0).Rows.Item(i).Item(0)
            img = ds.Tables(0).Rows.Item(i).Item(3)
            div.Attributes("runat") = "server"
            div.Attributes("class") = "TOPS"
            div.InnerHtml = "<p> Top " & i + 1 & "º<p><a href='#'>" & Nombre & "</br><img src ='imagenes/" & img & "' class='img'/></a></br><span class='votos'>Cantidad de votos: " & votos & "<span>"
            secundsection.Controls.Add(div)
        Next
    End Sub
End Class
