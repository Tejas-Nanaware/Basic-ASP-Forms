using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewList : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		SqlConnection con = new SqlConnection();
		con.ConnectionString = ConfigurationManager.ConnectionStrings["UserDetailsConnectionString"].ConnectionString;
		con.Open();
		SqlCommand cmd = new SqlCommand("Select ID,Name,Address,Company from UserDetails", con);
		SqlDataReader rd = cmd.ExecuteReader();
		GridView1.DataSource = rd;
		GridView1.DataBind();
		con.Close();
	}
}