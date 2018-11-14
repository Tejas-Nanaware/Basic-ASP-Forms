<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="N_TierApp.Index1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="container">
		<h1>Welcome</h1>
		<asp:GridView ID="viewIdeas" runat="server" AutoGenerateColumns="false">
			<Columns>
				<asp:BoundField DataField="S_FirstName" HeaderText="ID" />
				<asp:BoundField DataField="S_LastName" HeaderText="S_LastName" />
				<asp:BoundField DataField="U_UserName" HeaderText="U_UserName" />
				<asp:BoundField DataField="S_EmailID" HeaderText="S_EmailID" />
				<asp:BoundField DataField="S_MobileNumber" HeaderText="S_MobileNumber" />
			</Columns>
		</asp:GridView>
	</div>
</asp:Content>
