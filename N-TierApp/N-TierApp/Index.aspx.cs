using DALayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace N_TierApp
{
	public partial class Index1 : CommonUI
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			DataSet ds = new DataSet();
			ds = DA_01_UserMaster.sp_BindUser();
			viewIdeas.DataSource = ds;
			viewIdeas.DataBind();
		}

		protected void addUser_Click(object sender, EventArgs e)
		{
			Response.Redirect("AddUser.aspx");
		}
	}
}