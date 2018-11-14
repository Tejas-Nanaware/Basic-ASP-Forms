<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="N_TierApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>RVG Idea Management Portal</title>
	<meta http-equiv="Contetn-Type" content="text/html; charset=UTF-8" />
	<meta http-equiv="X-UA-Compatible" content="IE=edge, chrome=1" />
	<meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0" />
	<meta name="viewport" content="width=device-width" />
	<link href="css/font-awesome.css" rel="stylesheet" type="text/css" />
	<link href="Content/bootstrap.css" rel="stylesheet" type="text/css" />
</head>
<body>
	<form id="Login" method="post" runat="server">
		<div>
			<asp:TextBox ID="txtEmailID" runat="server" class="form-control" CssClass="form-control" placeholder="Enter Email ID." />
			<asp:TextBox ID="txtPassword" runat="server" class="form-control" CssClass="form-control" placeholder="Enter Password" TextMode="Password" />
			<asp:Button ID="btnLogin" Text="Login" CssClass="btn btn-grey btn-rounded z-depth-1a bg-color-base" runat="server" OnClick="btnLogin_Click" />
		</div>
	</form>
	<script src="Scripts/jquery-3.3.1.min.js" type="text/javascript"></script>
	<script src="Scripts/popper.min.js" type="text/javascript"></script>
	<script src="Scripts/bootstrap.min.js" type="text/javascript"></script>
</body>
</html>
