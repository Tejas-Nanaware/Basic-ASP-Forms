<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DataFiltering.aspx.cs" Inherits="DataFiltering" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<div class="container">
		<div class="row">
			<asp:label id="test" runat="server">Query</asp:label>
			<br />
		</div>
		<div class="row">
			<div class="col-4">
				<div class="input-group">
					<div class="input-group-prepend">
						<span class="input-group-text">Search Name</span>
					</div>
					<asp:textbox id="NameSearch" runat="server" cssclass="form-control"></asp:textbox>
				</div>
			</div>
			<div class="col-4">
				<div class="input-group">
					<div class="input-group-prepend">
						<span class="input-group-text">Search Company</span>
					</div>
					<asp:textbox id="CompanySearch" runat="server" cssclass="form-control"></asp:textbox>
				</div>
			</div>
			<div class="col">
				<asp:button id="NameSearchButton" runat="server" onclick="Search" text="Submit" cssclass="btn btn-primary" />
			</div>
		</div>
	</div>
	<br />
	<div class="container">
		<asp:label id="NoResults" runat="server"></asp:label>
		<asp:gridview id="Users" runat="server"></asp:gridview>
	</div>
</asp:Content>

