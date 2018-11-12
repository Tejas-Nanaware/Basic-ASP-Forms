using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
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

		//OdbcDataAdapter da = new OdbcDataAdapter("SELECT * FROM users", ConfigurationManager.ConnectionStrings["postgreConnectionString"].ConnectionString);
		//da.MissingSchemaAction = MissingSchemaAction.AddWithKey;

		//da.InsertCommand cmd = new OdbcCommand("INSERT INTO users (name, address, company) VALUES (?, ?, ?)");
		//da.InsertCommand.Parameters.Add("@name", OdbcType.VarChar, 50,my_name);
		//da.InsertCommand.Parameters.Add("@address", OdbcType.Text, 50,my_address);
		//da.InsertCommand.Parameters.Add("@company", OdbcType.VarChar, 50,my_company);

		OdbcConnection con = new OdbcConnection(ConfigurationManager.ConnectionStrings["postgreConnectionString"].ConnectionString);
		if (my_address != "")
		{
			OdbcCommand cmd = new OdbcCommand("INSERT INTO users (name, address, company) VALUES ('" + my_name + "', '" + my_address + "', '" + my_company + "')", con);
			query.Text = cmd.CommandText;
			con.Open();
			cmd.ExecuteNonQuery();
			con.Close();
		}
		else
		{
			OdbcCommand cmd = new OdbcCommand("INSERT INTO users (name, company) VALUES ('" + my_name + "', '" + my_company + "')", con);
			query.Text = cmd.CommandText;
			con.Open();
			cmd.ExecuteNonQuery();
			con.Close();

		}
		//OdbcCommand cmd = new OdbcCommand("INSERT INTO users (name, address, company) VALUES (@name, @address, @company)", con);
		//cmd.Parameters.AddWithValue("@name", my_name);
		//cmd.Parameters.AddWithValue("@address", my_address);
		//cmd.Parameters.AddWithValue("@company", my_company);
		name.Text = "";
		address.Text = "";
		company.Text = "";
	}
}