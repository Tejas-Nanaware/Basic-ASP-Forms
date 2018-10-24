<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DataFiltering.aspx.cs" Inherits="DataFiltering" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<div class="container">
		<asp:Label ID="test" runat="server">Query</asp:Label>
		<br />
		<label>Search Name:</label>
		<asp:TextBox id="NameSearch" runat="server"></asp:TextBox>
		<label>Search Company:</label>
		<asp:TextBox id="CompanySearch" runat="server"></asp:TextBox>
		<asp:Button ID="NameSearchButton" runat="server" OnClick="Search" Text="Submit" CssClass="btn btn-primary" />
		<br />
		<br />
		<asp:Label ID="NoResults" runat="server"></asp:Label>
		<asp:GridView id="Users" runat="server"></asp:GridView>
	</div>
</asp:Content>

