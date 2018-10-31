using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UpdateWithForm : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			this.GetData();
		}
	}

	private void GetData()
	{
		SqlConnection con = new SqlConnection();
		con.ConnectionString = ConfigurationManager.ConnectionStrings["UserDetailsConnectionString"].ConnectionString;
		con.Open();
		SqlCommand cmd = new SqlCommand("Select ID,Name,Address,Company from UserDetails", con);
		SqlDataReader rd = cmd.ExecuteReader();
		UsersTable.DataSource = rd;
		UsersTable.DataBind();
		UsersTable.UseAccessibleHeader = true;
		UsersTable.HeaderRow.TableSection = TableRowSection.TableHeader;
		UsersTable.CssClass = "table table-striped table-sm";
		UsersTable.HeaderRow.CssClass = "thead-dark";
		con.Close();
	}

	protected void AddUser(object sender, EventArgs e)
	{
		Response.Redirect("AddUser.aspx");
	}

	protected void UsersTable_RowDeleting(object sender, GridViewDeleteEventArgs e)
	{
		
	}

	protected void DeleteUser(object sender, GridViewCommandEventArgs e)
	{
		//GridViewRow rowSelect = (GridViewRow)(((LinkButton)e.CommandSource).NamingContainer);
		int ID = Convert.ToInt32(e.CommandArgument);
		SqlConnection con = new SqlConnection();
		con.ConnectionString = ConfigurationManager.ConnectionStrings["UserDetailsConnectionString"].ConnectionString;
		con.Open();
		SqlCommand cmd = new SqlCommand("Delete from UserDetails Where ID=@ID", con);
		cmd.Parameters.AddWithValue("@ID", ID);
		cmd.ExecuteNonQuery();
		con.Close();
		this.GetData();
	}
}