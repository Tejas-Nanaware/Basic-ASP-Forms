using System;
using System.Collections.Generic;
using SchemaLayer;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ApplicationBlocks.Data;

namespace DALayer
{
	public class DA_01_UserMaster
	{
		public DataSet DA_02_UserLogin(Sch_01_UserMaster obj_Sch_01_UserMaster)
		{
			try
			{
				//Creating parameters
				SqlParameter[] l_object_sqlparameter = new SqlParameter[2];
				l_object_sqlparameter[0] = new SqlParameter("@U_UserName", SqlDbType.VarChar);
				l_object_sqlparameter[1] = new SqlParameter("@S_Password", SqlDbType.VarChar);

				//Setting Values for the parameters
				l_object_sqlparameter[0].Value = obj_Sch_01_UserMaster.U_UserName.Trim();
				l_object_sqlparameter[1].Value = obj_Sch_01_UserMaster.S_Password.Trim();

				DataSet dsUser = SqlHelper.ExecuteDataset(ConnectionInfo.ConnectionString.ToString(),
					CommandType.StoredProcedure, "02_USP_UserLogin", l_object_sqlparameter);

				return dsUser;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public int SP_Password_Insert(Sch_01_UserMaster objSch_01_UserMaster)
		{
			try
			{
				SqlParameter[] @paramas = new SqlParameter[5];
				@paramas[0] = new SqlParameter("@U_UserID", objSch_01_UserMaster.U_UserID);
				@paramas[1] = new SqlParameter("@S_Password", objSch_01_UserMaster.S_Password);
				@paramas[2] = new SqlParameter("@U_CreatedBy", objSch_01_UserMaster.U_CreatedBy);

				string SQL = "SP_Password_Insert";
				int l_iResult = SqlHelper.ExecuteNonQuery(ConnectionInfo.ConnectionString.ToString(), CommandType.StoredProcedure, SQL, @paramas);
				return l_iResult;
			}
			catch (SqlException sqlEx)
			{
				throw (sqlEx);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public DataSet GetPassword(Sch_01_UserMaster objSch_01_UserMaster)
		{
			SqlParameter[] @paramas = new SqlParameter[1];
			@paramas[0] = new SqlParameter("@U_UserID", objSch_01_UserMaster.U_UserID);

			string SQL = "SP_GetPassword";
			return SqlHelper.ExecuteDataset(ConnectionInfo.ConnectionString.ToString(), CommandType.StoredProcedure, SQL, @paramas);

		}
		public DataSet SP_DuplicatePassword(Sch_01_UserMaster objSch_01_UserMaster)
		{
			SqlParameter[] @paramas = new SqlParameter[2];
			@paramas[0] = new SqlParameter("@U_UserID", objSch_01_UserMaster.U_UserID);
			@paramas[1] = new SqlParameter("@S_Password ", objSch_01_UserMaster.S_Password);

			string SQL = "SP_DuplicatePassword";
			return SqlHelper.ExecuteDataset(ConnectionInfo.ConnectionString.ToString(), CommandType.StoredProcedure, SQL, @paramas);

		}
		public static DataSet sp_BindUser()
		{
			string SQL = "sp_BindUser";
			return SqlHelper.ExecuteDataset(ConnectionInfo.ConnectionString.ToString(), CommandType.StoredProcedure, SQL);
		}
		public static bool DA_63_Usp_UserMaster_Insert(Sch_01_UserMaster objSch_01_UserMaster)
		{
			SqlParameter[] @params = new SqlParameter[12];
			string SQL = "63_Usp_UserMaster_Insert";
			@params[0] = new SqlParameter("@U_UserName", objSch_01_UserMaster.U_UserName);
			@params[1] = new SqlParameter("@S_LastName", objSch_01_UserMaster.S_LastName);
			@params[3] = new SqlParameter("@S_EmailID", objSch_01_UserMaster.S_EmailID);
			@params[4] = new SqlParameter("@S_Password", objSch_01_UserMaster.S_Password);
			@params[5] = new SqlParameter("@S_MobileNumber", objSch_01_UserMaster.S_MobileNumber);
			@params[6] = new SqlParameter("@I_Status", objSch_01_UserMaster.I_Status);
			@params[7] = new SqlParameter("@U_CreatedBy", objSch_01_UserMaster.U_CreatedBy);
			@params[11] = new SqlParameter("@S_ConfirmPassword", objSch_01_UserMaster.S_ConfirmPassword);
			return (((SqlHelper.ExecuteNonQuery(ConnectionInfo.ConnectionString.ToString(), CommandType.StoredProcedure, SQL, @params) > 0) ? true : false));
		}

		public DataSet DA_65_Usp_UserMaster_List()
		{
			//SqlParameter[] @params = new SqlParameter[1];
			// @params[0] = new SqlParameter("@UserId", UserID);
			string SQL = "65_Usp_UserMaster_List";
			return SqlHelper.ExecuteDataset(ConnectionInfo.ConnectionString.ToString(), CommandType.StoredProcedure, SQL);
		}

		public DataSet DA_66_Usp_UserMaster_Retrieve(Sch_01_UserMaster objSch_01_UserMaster)
		{
			SqlParameter[] @params = new SqlParameter[1];
			@params[0] = new SqlParameter("@U_UserID", objSch_01_UserMaster.U_UserID);
			string SQL = "66_Usp_UserMaster_Retrieve";
			return SqlHelper.ExecuteDataset(ConnectionInfo.ConnectionString.ToString(), CommandType.StoredProcedure, SQL, @params);
		}

		public static bool DA_64_Usp_UserMaster_Update(Sch_01_UserMaster objSch_01_UserMaster)
		{
			SqlParameter[] @params = new SqlParameter[13];
			string SQL = "64_Usp_UserMaster_Update";
			@params[0] = new SqlParameter("@U_UserName", objSch_01_UserMaster.U_UserName);
			@params[1] = new SqlParameter("@S_LastName", objSch_01_UserMaster.S_LastName);
			@params[3] = new SqlParameter("@S_EmailID", objSch_01_UserMaster.S_EmailID);
			@params[4] = new SqlParameter("@S_Password", objSch_01_UserMaster.S_Password);
			@params[5] = new SqlParameter("@S_MobileNumber", objSch_01_UserMaster.S_MobileNumber);
			@params[6] = new SqlParameter("@I_Status", objSch_01_UserMaster.I_Status);
			@params[7] = new SqlParameter("@U_UpdatedBy", objSch_01_UserMaster.U_CreatedBy);
			@params[10] = new SqlParameter("@U_UserID", objSch_01_UserMaster.U_UserID);
			@params[12] = new SqlParameter("@S_ConfirmPassword", objSch_01_UserMaster.S_ConfirmPassword);
			return (((SqlHelper.ExecuteNonQuery(ConnectionInfo.ConnectionString.ToString(), CommandType.StoredProcedure, SQL, @params) > 0) ? true : false));
		}
		public DataSet GetForgetPassword(Sch_01_UserMaster objSch_01_UserMaster)
		{
			try
			{
				SqlParameter[] @paramas = new SqlParameter[1];

				@paramas[0] = new SqlParameter("@U_UserName", objSch_01_UserMaster.U_UserName);

				string SQL = "sp_GEtForgetPassword";
				return SqlHelper.ExecuteDataset(ConnectionInfo.ConnectionString.ToString(), CommandType.StoredProcedure, SQL, @paramas);
			}
			catch (SqlException sqlEx)
			{
				throw (sqlEx);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public DataSet SP_EmailConfig()
		{
			string SQL = "SP_EmailConfig";
			return SqlHelper.ExecuteDataset(ConnectionInfo.ConnectionString.ToString(), CommandType.StoredProcedure, SQL);
		}


		public DataSet Usp_AD_Insert_User(Sch_01_UserMaster objSch_01_UserMaster)
		{
			SqlParameter[] @params = new SqlParameter[2];
			string SQL = "Usp_AD_Insert_User";

			@params[0] = new SqlParameter("@Username", objSch_01_UserMaster.U_UserName);
			@params[1] = new SqlParameter("@password", objSch_01_UserMaster.S_Password);

			// @params[2] = new SqlParameter("@U_UserID", objSch_01_UserMaster.U_UserID);
			return SqlHelper.ExecuteDataset(ConnectionInfo.ConnectionString.ToString(), CommandType.StoredProcedure, SQL, @params);
		}

		public DataSet Usp_GetEmailsForValidation(string emailid)
		{
			SqlParameter[] @params = new SqlParameter[1];
			string SQL = "Usp_GetEmailsForValidation";

			@params[0] = new SqlParameter("@Emailid", emailid);


			// @params[2] = new SqlParameter("@U_UserID", objSch_01_UserMaster.U_UserID);
			return SqlHelper.ExecuteDataset(ConnectionInfo.ConnectionString.ToString(), CommandType.StoredProcedure, SQL, @params);
		}

		public DataSet Usp_GetUserNameForValidation(string username)
		{
			SqlParameter[] @params = new SqlParameter[1];
			string SQL = "Usp_GetUserNameForValidation";

			@params[0] = new SqlParameter("@username", username);


			// @params[2] = new SqlParameter("@U_UserID", objSch_01_UserMaster.U_UserID);
			return SqlHelper.ExecuteDataset(ConnectionInfo.ConnectionString.ToString(), CommandType.StoredProcedure, SQL, @params);
		}

		public DataSet Usp_DomainListDropdown()
		{
			string SQL = "Usp_DomainListDropdown";
			return SqlHelper.ExecuteDataset(ConnectionInfo.ConnectionString.ToString(), CommandType.StoredProcedure, SQL);
		}
	}
}
