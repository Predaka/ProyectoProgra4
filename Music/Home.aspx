<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Home.aspx.vb" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <label for="maincanvas" class="box-shadow-menu" runat="server" id="menucanvas"></label>
    <section class="slider-wrapper" id="slider">
				<ul class="slider-section">
					<li class="slider-current">
							<img src="imagenes/slide1.jpg" alt=""/>
							<div class="caption">
								<h3 class="caption-tittle">AC/DC</h3>
								<p>Banda de los 60's que aun permanece fuerte y vigente en festivales y los corazones de los fanaticos del Rock.</p>
							</div>
					</li>
					<li>
							<img src="imagenes/slide2.jpg" alt=""/>
							<div class="caption">
								<h3 class="caption-tittle">Bullet For my Valentine</h3>
								<p>Esta asombrosa banda nos presenta su nuevo sencillo llamado Temper Temper , el cual presenta el primer single con el mismo nombre.</p>
							</div>
					</li>
					<li>
							<img src="imagenes/slide3.jpg" alt=""/>
							<div class="caption">
								<h3 class="caption-tittle">Alter Bridge</h3>
								<p>Gran exponente de rock alternativo. Pronto tendremos la fecha de su proxima gira a Latino America , el cual se rumora su primera parada sera Costa Rica.</p>
							</div>
					</li>
					<li>
							<img src="imagenes/slide4.jpg" alt=""/>
							<div class="caption">
								<h3 class="caption-tittle">Foo Figthers</h3>
								<p>Su lider Dave Grohl anuncia, ex-nirvana, anuncia su llegada a Tierras Colombianas para vacacionar.</p>
							</div>
					</li>	
				</ul>
			</section>
			<ul class="slider-controls" id="slider-controls">
				<li class="active"></li>
				<li></li>
				<li></li>
				<li></li>
			</ul>
			<section id="secundsection" runat="server">

			</section>
</asp:Content>

