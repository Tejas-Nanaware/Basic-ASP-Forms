<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="NewList.aspx.cs" Inherits="NewList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<a href="Default.aspx">Home</a>
	<asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>

