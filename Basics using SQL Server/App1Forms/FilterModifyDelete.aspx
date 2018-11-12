<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FilterModifyDelete.aspx.cs" Inherits="FilterModifyDelete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



	<asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ID" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
		<AlternatingRowStyle BackColor="White" ForeColor="#284775" />
		<Columns>
			<asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
			<asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
			<asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
			<asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
			<asp:BoundField DataField="Company" HeaderText="Company" SortExpression="Company" />
		</Columns>
		<EditRowStyle BackColor="#999999" />
		<FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
		<HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
		<PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
		<RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
		<SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
		<SortedAscendingCellStyle BackColor="#E9E7E2" />
		<SortedAscendingHeaderStyle BackColor="#506C8C" />
		<SortedDescendingCellStyle BackColor="#FFFDF8" />
		<SortedDescendingHeaderStyle BackColor="#6F8DAE" />
	</asp:GridView>
	<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:UserDetailsConnectionString %>" DeleteCommand="DELETE FROM [UserDetails] WHERE [ID] = @ID" InsertCommand="INSERT INTO [UserDetails] ([Name], [Address], [Company]) VALUES (@Name, @Address, @Company)" SelectCommand="SELECT * FROM [UserDetails]" UpdateCommand="UPDATE [UserDetails] SET [Name] = @Name, [Address] = @Address, [Company] = @Company WHERE [ID] = @ID">
		<DeleteParameters>
			<asp:Parameter Name="ID" Type="Int32" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="Name" Type="String" />
			<asp:Parameter Name="Address" Type="String" />
			<asp:Parameter Name="Company" Type="String" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="Name" Type="String" />
			<asp:Parameter Name="Address" Type="String" />
			<asp:Parameter Name="Company" Type="String" />
			<asp:Parameter Name="ID" Type="Int32" />
		</UpdateParameters>
	</asp:SqlDataSource>



</asp:Content>

