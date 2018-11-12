using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DataFiltering : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			this.SearchUsers();
		}
	}
	private void SearchUsers()
	{
		OdbcConnection con = new OdbcConnection(ConfigurationManager.ConnectionStrings["postgreConnectionString"].ConnectionString);
		con.Open();
		OdbcCommand cmd = new OdbcCommand();
		string query = "SELECT user_id,name,address,company FROM users";
		if (!string.IsNullOrEmpty(NameSearch.Text.Trim()) || !string.IsNullOrEmpty(CompanySearch.Text.Trim()))
		{
			//query += " Where Name Like '%' @Name + '%'";
			query += " WHERE Name LIKE '%" + NameSearch.Text.Trim() + "%' AND Company LIKE '%" + CompanySearch.Text.Trim() + "%'";
			//cmd.Parameters.AddWithValue("@Name", NameSearch.Text.Trim());
			test.Text = query;
		}
		cmd.CommandText = query;
		cmd.Connection = con;
		OdbcDataAdapter sda = new OdbcDataAdapter(cmd);
		DataTable dt = new DataTable();
		sda.Fill(dt);
		Users.DataSource = dt;
		Users.DataBind();
		if (dt.Rows.Count == 0)
		{
			NoResults.Text = "No Results Found!";
		}
		else
		{
			Users.UseAccessibleHeader = true;
			Users.HeaderRow.TableSection = TableRowSection.TableHeader;
			Users.CssClass = "table table-striped table-sm";
			Users.HeaderRow.CssClass = "thead-dark";
		}
	}
	protected void Search(object Sender, EventArgs e)
	{
		NoResults.Text = "";
		this.SearchUsers();
	}
	protected void OnPaging(object sender, GridViewPageEventArgs e)
	{
		Users.PageIndex = e.NewPageIndex;
		this.SearchUsers();
	}
}