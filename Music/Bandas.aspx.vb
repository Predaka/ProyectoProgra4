
Partial Class Home
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Cargar()
    End Sub

    Public Sub cargar()
        Dim ds As New Data.DataSet
        Dim ID As Integer
        Dim Nombre As String
        Dim img As String

        ds = CargarBanda()

        For i = 0 To ds.Tables(0).Rows.Count - 1
            Dim div = New HtmlGenericControl("div")
            ID = ds.Tables(0).Rows.Item(i).Item(0)
            Nombre = ds.Tables(0).Rows.Item(i).Item(1).ToString
            img = ds.Tables(0).Rows.Item(i).Item(5).ToString
            div.Attributes("class") = "band-option"
            div.Attributes("runat") = "server"
            div.Attributes("ID") = ID
            div.InnerHtml = "<img src ='imagenes/" & img & "'/><div class='cover-option'><a href='#'>" & Nombre & "</a></div>"
            contenido.Controls.Add(div)
        Next
    End Sub

End Class

