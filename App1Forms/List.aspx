<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="List.aspx.cs" Inherits="List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<h1>List</h1>
	<a href="Default.aspx">Home</a>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
	<Columns>
		<asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
		<asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
		<asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
		<asp:BoundField DataField="CompanyName" HeaderText="CompanyName" SortExpression="CompanyName" />
	</Columns>
	</asp:GridView>
	<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:UserDetailsConnectionString %>" SelectCommand="SELECT * FROM [UserDetails] ORDER BY [Name]"></asp:SqlDataSource>
</asp:Content>

