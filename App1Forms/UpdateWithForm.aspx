<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UpdateWithForm.aspx.cs" Inherits="UpdateWithForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
	<link rel="stylesheet" href="UpdateWithForm.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
	<div class="container">
		<asp:Button ID="btnExportExcel" Text="Excel" runat="server" OnClick="btnExportExcel_Click" CssClass="btn btn-primary" />
		<asp:Button ID="btnUpdate" Text="Add" runat="server" OnClick="AddUser" CssClass="btn btn-primary buttonClass" />
	</div>
	<div class="container">
		<asp:GridView ID="UsersTable" runat="server" AutoGenerateColumns="false" OnRowCommand="DeleteUser">
			<Columns>
				<asp:BoundField DataField="ID" HeaderText="ID" />
				<asp:BoundField DataField="Name" HeaderText="Name" />
				<asp:BoundField DataField="Address" HeaderText="Address" />
				<asp:BoundField DataField="Company" HeaderText="Company" />
				<asp:HyperLinkField Text="Update" DataNavigateUrlFields="ID" DataNavigateUrlFormatString="UpdateForm.aspx?ID={0}" />
				<asp:TemplateField>
					<ItemTemplate>
						<asp:LinkButton runat="server" Text="Delete" CommandName="DeleteUser" CommandArgument='<%# Eval("ID") %>' ></asp:LinkButton>
					</ItemTemplate>
				</asp:TemplateField>
			</Columns>
		</asp:GridView>
	</div>
</asp:Content>

