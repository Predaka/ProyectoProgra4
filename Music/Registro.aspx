<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Registro.aspx.vb" Inherits="Registro" %>

<!DOCTYPE html>
<html lang="es">
<head runat="server">
	<meta charset="UTF-8">
	<title>Registro</title>
	<link rel="stylesheet" type="text/css" href="css/styles-Registro.css">
</head>
<body>
    <form id="form1" runat="server">
	<div class="login-wrapper">
		<img src="imagenes/logo.png"/>
			<div class="Registro">
			<h3>Registro</h3>
				<label>Nombre:</label>
				<input type="text" class="log-text" runat="server" id="txtnombre">
				<label>Email:</label>
				<input type="text" class="log-text" runat="server" id="txtEmail">
				<label>Password:</label>
				<input type="Password" class="log-text" runat="server" id="txtPassword">
				<label>Re-Password:</label>
				<input type="Password" class="log-text" runat="server" id="txtRepassword">
				<label>Profile-Photo:</label>
				<input type="file" class="log-text" runat="server" id="txtPhoto">
				<button runat="server" id="BtnRegistrar">Registrar</button>
			</div>
		
	</div>
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.4/jquery.min.js"></script>
	<script type="text/javascript" src="js/Home.js"></script>
    </form>
</body>
</html>



<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>--%>
