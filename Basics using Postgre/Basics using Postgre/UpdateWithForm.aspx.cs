using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Odbc;
using System.IO;
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
		OdbcConnection con = new OdbcConnection();
		con.ConnectionString = ConfigurationManager.ConnectionStrings["postgreConnectionString"].ConnectionString;
		con.Open();
		OdbcCommand cmd = new OdbcCommand("Select user_id,name,address,company from users", con);
		OdbcDataReader rd = cmd.ExecuteReader();
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
		OdbcConnection con = new OdbcConnection();
		con.ConnectionString = ConfigurationManager.ConnectionStrings["postgreConnectionString"].ConnectionString;
		con.Open();
		OdbcCommand cmd = new OdbcCommand("Delete from users Where user_id="+ID, con);
		cmd.ExecuteNonQuery();
		con.Close();
		this.GetData();
	}


	protected void btnExportExcel_Click(object sender, EventArgs e)
	{
		this.ExportExcel();
	}
	private void ExportExcel()
	{
		Response.Clear();
		Response.Buffer = true;
		Response.AddHeader("content-disposition", "attachment;filename=UserDetails.xls");
		Response.Charset = "";
		Response.ContentType = "application/vnd.ms-excel";
		StringWriter sw = new StringWriter();
		HtmlTextWriter htw = new HtmlTextWriter(sw);
		bool checkPaging = false;
		if (UsersTable.AllowPaging)
		{
			checkPaging = true;
			UsersTable.AllowPaging = false;
			this.GetData();
		}
		//skip update and delete rows
		UsersTable.Columns[UsersTable.Columns.Count - 1].Visible = false;
		UsersTable.Columns[UsersTable.Columns.Count - 2].Visible = false;

		UsersTable.RenderControl(htw);
		Response.Output.Write(sw.ToString());
		Response.Flush();
		Response.End();
		//set back update and delete rows
		UsersTable.Columns[UsersTable.Columns.Count - 1].Visible = true;
		UsersTable.Columns[UsersTable.Columns.Count - 2].Visible = true;

		if (checkPaging)
		{
			checkPaging = false;
			UsersTable.AllowPaging = true;
			this.GetData();
		}
	}
	public override void VerifyRenderingInServerForm(Control control)
	{
		/* Verifies that the control is rendered */
	}
}