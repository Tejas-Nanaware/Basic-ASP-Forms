<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddUser.aspx.cs" Inherits="AddUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<h1>Add</h1>
	<a href="Default.aspx">Home</a>
	<br />

	<label>name:</label>
	<asp:TextBox ID="name" runat="server" />
	<asp:RequiredFieldValidator runat="server" id="reqName" ControlToValidate="name" ErrorMessage="Name is required" />
	<br />
	<label>address:</label>
	<asp:TextBox ID="address" runat="server" />
	<br />
	<label>company:</label>
	<asp:TextBox ID="company" runat="server" />
	<asp:RequiredFieldValidator runat="server" ID="redCompany" ControlToValidate="company" ErrorMessage="Company name is required" />
	<br />
	<br />
	<asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
	<br />

	<asp:PlaceHolder ID="my_data" runat="server"></asp:PlaceHolder>
</asp:Content>
