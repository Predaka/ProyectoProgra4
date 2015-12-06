
Partial Class MasterPage
    Inherits System.Web.UI.MasterPage
    Dim url_base As String = "C:\Users\Usuario\Documents\Visual Studio 2013\WebSites\Music\imagenes\"

    Protected Sub Page_Init(sender As Object, e As EventArgs) Handles Me.Init
        'imguser.Attributes("style") = "background-image: url(../imagenes/" & Session("Imagen").ToString & ")"
    End Sub
End Class

