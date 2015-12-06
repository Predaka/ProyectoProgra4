<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Log In - Ingreso a la Pagina</title>
    <link rel="stylesheet" type="text/css" href="css/styles-login.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="login-wrapper">
		    <img src="imagenes/logo.png"/>
			    <div class="login">
			    <h3>Log in</h3>
				    <label>Email:</label>
				    <input type="text" runat="server" id="txtMail" class="txt"/>
				    <label>Password:</label>
				    <input type="password"  runat="server" id="txtPass" class="txt"/>
				    <button runat="server" id="ingresar">Ingresar</button>
				    <button id="registro" runat="server" >Registrarse</button>
			    </div>	
	    </div>

    </div>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.4/jquery.min.js"></script>
	<script type="text/javascript" src="js/Home.js"></script>
    </form>
</body>
</html>
