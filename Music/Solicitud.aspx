<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Solicitud.aspx.vb" Inherits="Solicitud" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <label for="maincanvas" class="box-shadow-menu" runat="server" id="menucanvas"></label>
    <div id="contenido" runat="server" class="content">
			<div class="solicitud">
				<label>Asunto: </label>
				<input type="text" id="txtAsunto" runat="server"/>
				<label>Descripcion: </label>
                <asp:TextBox ID="txtDescripcion" runat="server" CssClass="descrip" TextMode="MultiLine" Height="300"></asp:TextBox>
				<button runat="server" id="btnEnviar">Enviar</button>	
			</div>
	</div>
</asp:Content>

