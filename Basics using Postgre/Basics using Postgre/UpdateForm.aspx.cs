using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UpdateForm : System.Web.UI.Page
{
	string constr = ConfigurationManager.ConnectionStrings["postgreConnectionString"].ConnectionString;
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			this.GetUsers();
		}
	}
	protected void UserUpdate(object sender, EventArgs e)
	{
		this.UserUpdate();
	}

	private int id {
		get {
			return !string.IsNullOrEmpty(Request.QueryString["ID"]) ? int.Parse(Request.QueryString["ID"]) : 0;
		}
	}

	private void UserUpdate()
	{
		OdbcConnection con = new OdbcConnection();
		con.ConnectionString = this.constr;
		con.Open();
		if (txtAddress.Text != "")
		{
			OdbcCommand cmd = new OdbcCommand("UPDATE users SET name='" + txtName.Text + "', address='" + txtAddress.Text + "', company='" + txtCompany.Text + "' WHERE user_id=" + id, con);
			cmd.ExecuteNonQuery();
			con.Close();
		}
		else
		{
			OdbcCommand cmd = new OdbcCommand("UPDATE users SET name='" + txtName.Text + "', address=null, company='" + txtCompany.Text + "' WHERE user_id=" + id, con);
			cmd.ExecuteNonQuery();
			con.Close();
		}
		Response.Redirect("UpdateWithForm.aspx");
	}

	private void GetUsers()
	{
		OdbcConnection con = new OdbcConnection();
		con.ConnectionString = this.constr;
		con.Open();
		OdbcCommand cmd = new OdbcCommand("Select user_id,name,address,company from users WHERE user_id=" + id, con);
		OdbcDataAdapter sda = new OdbcDataAdapter(cmd);
		DataTable dt = new DataTable();
		sda.Fill(dt);
		foreach (DataRow dr in dt.Rows)
		{
			this.txtID.Text = dr["user_id"].ToString();
			this.txtName.Text = dr["name"].ToString();
			this.txtAddress.Text = dr["address"].ToString();
			this.txtCompany.Text = dr["company"].ToString();
		}
		con.Close();
	}
}