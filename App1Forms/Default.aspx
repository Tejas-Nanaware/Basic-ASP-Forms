<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<a href="AddUser.aspx">Add</a>
	<br />
	<a href="DBTableUsingGridView.aspx">List by GridView</a>
	<br />
	<a href="DBTableUsingTable.aspx">List by Table</a>
	<br />
</asp:Content>
