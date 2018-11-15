using SchemaLayer;
using DALayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace N_TierApp
{
	public partial class AddUser : CommonUI
	{
		bool flag_UserName = true;
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Submit_Click(object sender, EventArgs e)
		{
			var my_firstName = firstName.Text.Trim();
			var my_lastName = lastName.Text.Trim();
			var my_username = username.Text.Trim();
			var my_email = email.Text.Trim();
			var my_mobile = mobile.Text.Trim();
			var my_password = password.Text.Trim();
			var my_confirmPassword = confirmPassword.Text.Trim();
			checkUsername();
			if (flag_UserName == false)
			{
				Sch_01_UserMaster ObjAddUser = new Sch_01_UserMaster();
				ObjAddUser.U_UserID = new Guid(base.GetUserInfo.U_UserID.ToString());
				ObjAddUser.S_FirstName = my_firstName;
				ObjAddUser.S_LastName = my_lastName;
				ObjAddUser.U_UserName = my_username;
				ObjAddUser.S_EmailID = my_email;
				ObjAddUser.S_MobileNumber = my_mobile;
				ObjAddUser.S_Password = my_password;
				ObjAddUser.S_ConfirmPassword = my_confirmPassword;
				ObjAddUser.I_Status = 1;
				ObjAddUser.U_CreatedBy = new Guid(base.GetUserInfo.U_UserID.ToString());

				DA_01_UserMaster objDA_01_UserMaster = new DA_01_UserMaster();
				objDA_01_UserMaster.SP_AddUser(ObjAddUser);
				base.ShowMessage("Successfully Added", 1);
				firstName.Text = "";
				lastName.Text = "";
				username.Text = "";
				email.Text = "";
				mobile.Text = "";
				password.Text = "";
				confirmPassword.Text = "";
			}
			else
			{
				base.ShowMessage("Username already exists", 1);
			}
		}

		private void checkUsername()
		{
			DA_01_UserMaster objDA_01_UserMaster = new DA_01_UserMaster();
			Sch_01_UserMaster objSch_01_UserMaster = new Sch_01_UserMaster();

			objSch_01_UserMaster.U_UserName = username.Text.Trim();

			DataSet ds = new DataSet();
			ds = objDA_01_UserMaster.Check_UserName(objSch_01_UserMaster);
			if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
			{
				flag_UserName = true;
				username.CssClass = "form-control is-invalid";
			}
			else
			{
				flag_UserName = false;
				username.CssClass = "form-control is-valid";
			}
		}

		protected void username_TextChanged(object sender, EventArgs e)
		{
			checkUsername();
		}
	}
}