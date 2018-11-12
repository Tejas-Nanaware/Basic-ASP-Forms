using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

public partial class DBTableUsingTable : System.Web.UI.Page
{
	StringBuilder table = new StringBuilder();
	protected void Page_Load(object sender, EventArgs e)
	{
		if(!Page.IsPostBack)
		{
			SqlConnection con = new SqlConnection();
			con.ConnectionString = ConfigurationManager.ConnectionStrings["UserDetailsConnectionString"].ConnectionString;
			con.Open();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "Select ID,Name,Address,Company from UserDetails";
			cmd.Connection = con;
			SqlDataReader rd = cmd.ExecuteReader();
			table.Append("<table class='table table-striped table-responsive table-sm'>");
			table.Append("<thead class='thead-dark'><tr><th>ID</th><th>Name</th><th>Address</th><th>Company</th></tr></thead>");

			if(rd.HasRows)
			{
				while(rd.Read())
				{
					table.Append("<tr>");
					table.Append("<td>" + rd[0] + "</td><td>" + rd[1] + "</td><td>" + rd[2] + "</td><td>" + rd[3] + "</td>");
					table.Append("</tr>");
				}
			}
			table.Append("</table>");
			PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });
			rd.Close();

		}
	}
}