<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Bandas-Info.aspx.vb" Inherits="Bandas_Info" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <label for="maincanvas" class="box-shadow-menu" runat="server" id="menucanvas"></label>
    <div id="contenido" runat="server" class="content">
        <img src="#" class="band-img" id="imagen" runat="server"/>

     <div class="band-infomation" runat="server" id="Informacion">
		
    </div>
			<label class="titulo">Cancion mas Sonada: </label><audio class="cancion" controls="controls" runat="server" id="cancion" >Cancion Mas Sonada</audio>
        <button id="btnVotar" class="votar" runat="server"> Votar</button>
	</div>
</asp:Content>

