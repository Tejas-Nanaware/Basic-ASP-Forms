using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UpdateForm : System.Web.UI.Page
{
	string constr = ConfigurationManager.ConnectionStrings["UserDetailsConnectionString"].ConnectionString;
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
			return !string.IsNullOrEmpty(Request.QueryString["ID"]) ? int.Parse(Request.QueryString["ID"]) : 0 ;
		}
	}

	private void UserUpdate()
	{
		SqlConnection con = new SqlConnection();
		con.ConnectionString = this.constr;
		con.Open();
		SqlCommand cmd = new SqlCommand("UPDATE UserDetails SET Name=@Name, Address=@Address, Company=@Company WHERE ID=@ID",con);
		cmd.Parameters.AddWithValue("@ID", id);
		cmd.Parameters.AddWithValue("@Name", txtName.Text);
		cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
		cmd.Parameters.AddWithValue("@Company", txtCompany.Text);
		cmd.ExecuteNonQuery();
		con.Close();
		Response.Redirect("UpdateWithForm.aspx");
	}

	private void GetUsers()
	{
		SqlConnection con = new SqlConnection();
		con.ConnectionString = this.constr;
		con.Open();
		SqlCommand cmd = new SqlCommand("Select ID,Name,Address,Company from UserDetails WHERE ID=@ID", con);
		cmd.Parameters.AddWithValue("@ID", id);
		SqlDataAdapter sda = new SqlDataAdapter(cmd);
		DataTable dt = new DataTable();
		sda.Fill(dt);
		foreach (DataRow dr in dt.Rows)
		{
			this.txtID.Text = dr["ID"].ToString();
			this.txtName.Text = dr["Name"].ToString();
			this.txtAddress.Text = dr["Address"].ToString();
			this.txtCompany.Text = dr["Company"].ToString();
		}
		con.Close();
	}
}