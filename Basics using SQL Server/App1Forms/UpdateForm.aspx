<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UpdateForm.aspx.cs" Inherits="UpdateForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
	<div class="container col-lg-8">
		<div class="input-group mb-3">
			<div class="input-group-prepend">
				<span class="input-group-text">ID</span>
			</div>
			<asp:TextBox ID="txtID" runat="server" TextMode="SingleLine" CssClass="form-control" Enabled="false" />
		</div>
		<div class="input-group mb-3">
			<div class="input-group-prepend">
				<span class="input-group-text">Name</span>
			</div>
			<asp:TextBox ID="txtName" runat="server" TextMode="SingleLine" CssClass="form-control" />
			<asp:RequiredFieldValidator runat="server" ID="reqName" ControlToValidate="txtName" ErrorMessage="Name is required" />
		</div>
		<div class="input-group mb-3">
			<div class="input-group-prepend">
				<span class="input-group-text">Address</span>
			</div>
			<asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" CssClass="form-control" />
		</div>
		<div class="input-group mb-3">
			<div class="input-group-prepend">
				<span class="input-group-text">Company</span>
			</div>
			<asp:TextBox ID="txtCompany" runat="server" TextMode="SingleLine" CssClass="form-control" />
			<asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ControlToValidate="txtCompany" ErrorMessage="Company is required" />
		</div>
		<asp:Button ID="btnUpdate" Text="Update" runat="server" OnClick="UserUpdate" CssClass="btn btn-primary" />
	</div>
</asp:Content>

