<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DBTableUsingGridView.aspx.cs" Inherits="DBTableUsingGridView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
	<div class="container">
		<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="user_id" DataSourceID="SqlDataSource2">
			<Columns>
				<asp:BoundField DataField="user_id" HeaderText="user_id" InsertVisible="False" ReadOnly="True" SortExpression="user_id" />
				<asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
				<asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
				<asp:BoundField DataField="company" HeaderText="company" SortExpression="company" />
			</Columns>
		</asp:GridView>
		<asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:postgreConnectionString %>" ProviderName="<%$ ConnectionStrings:postgreConnectionString.ProviderName %>" SelectCommand="SELECT * from users"></asp:SqlDataSource>

	</div>
</asp:Content>

