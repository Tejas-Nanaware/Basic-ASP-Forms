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
using System.Web.Configuration;

public partial class List : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		//string connString = WebConfigurationManager.ConnectionStrings["sqlConnectionString"].ConnectionString;
		////SqlConnection con = new SqlConnection(@"Data Source=TEJAS-NANAWARE\SQLEXPRESS\;Initial Catalog=UserDetails; User ID=sa; Password=$abcd123");
		//SqlConnection con = new SqlConnection();
		//con.ConnectionString = ConfigurationManager.ConnectionStrings["sqlConnectionString"].ConnectionString;
		//con.Open();
		//SqlCommand cmd = new SqlCommand("Select * from UserDetails",con);
		//SqlDataReader rd = cmd.ExecuteReader();
		//GridView1.DataSource = rd;
		//GridView1.DataBind();
		//con.Close();
	}
}