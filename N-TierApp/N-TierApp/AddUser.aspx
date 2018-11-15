<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="N_TierApp.AddUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="container">
		<label>First Name:</label>
		<asp:TextBox ID="firstName" class="form-control" CssClass="form-control" runat="server" />
		<asp:RequiredFieldValidator runat="server" ID="reqFirstName" ControlToValidate="firstName" ErrorMessage="First Name is required" />
		<br />
		<label>Last Name:</label>
		<asp:TextBox ID="lastName" class="form-control" CssClass="form-control" runat="server" />
		<br />
		<label>Username:</label>
		<asp:TextBox ID="username" AutoPostBack="true" OnTextChanged="username_TextChanged" class="form-control" CssClass="form-control" runat="server" />
		<asp:RequiredFieldValidator runat="server" ID="reqUsername" ControlToValidate="username" ErrorMessage="Username is required" />
		<br />
		<label>Email:</label>
		<asp:TextBox ID="email" class="form-control" CssClass="form-control" runat="server" />
		<asp:RequiredFieldValidator runat="server" ID="reqEmail" ControlToValidate="email" ErrorMessage="Email name is required" />
		<br />
		<label>Mobile:</label>
		<asp:TextBox ID="mobile" class="form-control" CssClass="form-control" runat="server" />
		<br />
		<label>Password:</label>
		<asp:TextBox ID="password" class="form-control" CssClass="form-control" TextMode="Password" runat="server" />
		<br />
		<label>Confirm Password:</label>
		<asp:TextBox ID="confirmPassword" class="form-control" CssClass="form-control" TextMode="Password" runat="server" />
		<br />
		<br />
		<asp:Button CssClass="btn btn-primary" ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
		<br />
	</div>
</asp:Content>
