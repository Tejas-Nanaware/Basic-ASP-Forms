using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DALayer;
using SchemaLayer;
using System.Data.SqlClient;


namespace N_TierApp
{
	public partial class Login : CommonUI
	{
		DA_01_UserMaster objDA_01_UserMaster;
		Sch_01_UserMaster objSch_01_UserMaster;
		string strUserName;
		string strPassword;
		protected void Page_Load(object sender, EventArgs e)
		{

		}
		protected void btnLogin_Click(object sender, EventArgs e)
		{
			int flag = 0;
			try
			{
				objDA_01_UserMaster = new DA_01_UserMaster();
				objSch_01_UserMaster = new Sch_01_UserMaster();
				strUserName = txtEmailID.Text.Trim();
				strPassword = txtPassword.Text.Trim();

				objSch_01_UserMaster.U_UserName = strUserName;
				objSch_01_UserMaster.S_Password = strPassword;



				DataSet ds = new DataSet();
				ds = objDA_01_UserMaster.DA_02_UserLogin(objSch_01_UserMaster);
				if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
				{
					objSch_01_UserMaster.U_UserID = new Guid(ds.Tables[0].Rows[0]["U_UserID"].ToString());
					objSch_01_UserMaster.U_UserName = Convert.ToString(ds.Tables[0].Rows[0]["U_UserName"]);
					objSch_01_UserMaster.S_Password = Convert.ToString(ds.Tables[0].Rows[0]["S_Password"]);
					objSch_01_UserMaster.S_EmailID = Convert.ToString(ds.Tables[0].Rows[0]["S_EmailID"]);
					//objSch_UserMaster.Department = new Guid(ds.Tables[0].Rows[0]["Department"].ToString());
					//objSch_UserMaster.UserLevel = Convert.ToInt32(ds.Tables[0].Rows[0]["UserLevel"].ToString());

					Session["UserInfo"] = objSch_01_UserMaster;
					Session["U_UserName"] = objSch_01_UserMaster.U_UserName;
					Session["S_EmailID"] = objSch_01_UserMaster.S_EmailID;
					Session["U_UserID"] = new Guid(ds.Tables[0].Rows[0]["U_UserID"].ToString());
					Response.Redirect("Index.aspx", false);
					string str = Session["U_UserName"].ToString();
					ds.Clear();
					ds.Dispose();
				}
				else
					base.ShowMessage("Invalid UserName Or Password...!!!", 1);
				txtEmailID.Text = "";
			}

			// }

			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}