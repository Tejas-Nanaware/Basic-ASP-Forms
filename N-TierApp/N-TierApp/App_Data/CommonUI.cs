using Microsoft.ApplicationBlocks.Data;
using SchemaLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace N_TierApp
{
	public class CommonUI : Page
	{
		internal void ShowMessage(string strMessage, int iMsgNo)
		{
			strMessage = strMessage.Replace("'", "");
			strMessage = strMessage.Replace("\r\n", "");
			ClientScript.RegisterStartupScript(typeof(Page), "Msg" + iMsgNo, "<script>alert('" + strMessage + "')</script>");
		}

		internal void ShowMessage(string strMessage, string strFocusID, int iMsgNo)
		{
			strMessage = strMessage.Replace("'", "");
			strMessage = strMessage.Replace("\r\n", "");
			ClientScript.RegisterStartupScript(typeof(Page), "Msg" + iMsgNo, "<script>alert('" + strMessage + "');" + strFocusID + ".focus()</script>");
		}

		internal void ShowMessageAndRedirect(string strMessage, string strRedirectUrl, int iMsgNo)
		{
			strMessage = strMessage.Replace("'", "");
			strMessage = strMessage.Replace("\r\n", "");
			ClientScript.RegisterStartupScript(typeof(Page), "Msg" + iMsgNo, "<script>alert('" + strMessage + "');location.href='" + strRedirectUrl + "';</script>");
		}


		internal void PageRedirect(string strURL)
		{
			Response.Write("<script>window.location.href=('" + strURL + "');</script>");
		}
		internal void PageOpen(string strurl)
		{
			Response.Redirect("<script>window.open('" + strurl + "');</script>");
		}

		internal Sch_01_UserMaster GetUserInfo1 {
			get { return (Sch_01_UserMaster)Session["S_UserName"]; }
		}
		internal Sch_01_UserMaster GetUserInfo {
			get { return (Sch_01_UserMaster)Session["UserInfo"]; }
		}

		internal void SessionCheck()
		{
			try
			{
				if (Session["UserInfo"] == null)
				{
					HttpContext.Current.Session.Clear();
					Response.Redirect("../Login.aspx");
				}
			}
			catch (Exception ex)
			{
				HttpContext.Current.Response.Redirect("~/Login.aspx");
				//Response.Redirect("../frmUserLogin.aspx");
			}
		}

		internal bool ddlFindBytext(DropDownList ddl, string value)
		{
			bool isFound = false;
			foreach (ListItem item in ddl.Items)
			{
				if (string.Compare(value.Trim(), item.Text.Trim(), true) == 0)
				{
					ddl.SelectedIndex = ddl.Items.IndexOf(ddl.Items.FindByText(item.ToString()));
					break;
				}
			}
			return isFound;
		}

		public DataSet SP_EmailConfig()
		{
			string SQL = "SP_EmailConfig";
			return SqlHelper.ExecuteDataset(ConnectionInfo.ConnectionString.ToString(), CommandType.StoredProcedure, SQL);
		}

		public DataSet SP_BindMenu(string S_UserId)
		{
			SqlParameter[] @params = new SqlParameter[1];
			@params[0] = new SqlParameter("@UserID", S_UserId);
			string SQL = "SP_BindMenu";
			return SqlHelper.ExecuteDataset(ConnectionInfo.ConnectionString.ToString(), CommandType.StoredProcedure, SQL, @params);
		}
	}
}