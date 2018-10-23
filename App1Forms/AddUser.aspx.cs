using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddUser : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{

	}

	protected void Submit_Click(object sender, EventArgs e)
	{
		var my_name = name.Text;
		var my_address = address.Text;
		var my_company = company.Text;

		SqlConnection con = new SqlConnection();
		con.ConnectionString = ConfigurationManager.ConnectionStrings["UserDetailsConnectionString"].ConnectionString;
		con.Open();

		SqlCommand cmd = con.CreateCommand();
		cmd.CommandType = CommandType.Text;
		cmd.CommandText = "INSERT INTO UserDetails values ('"+my_name+"','"+my_address+"','"+my_company+"');";

		cmd.ExecuteNonQuery();
		con.Close();

		name.Text = "";
		address.Text = "";
		company.Text = "";

	}
}