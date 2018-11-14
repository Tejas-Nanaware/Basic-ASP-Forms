using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchemaLayer
{
	public class Sch_01_UserMaster
	{
		public Guid U_UserID { get; set; }
		public string S_FirstName { get; set; }
		public string S_LastName { get; set; }
		public string U_UserName { get; set; }
		public string S_EmailID { get; set; }
		public string S_MobileNumber { get; set; }
		public string S_Password { get; set; }
		public string S_ConfirmPassword { get; set; }
		public int I_Status { get; set; }
		public string DT_Created { get; set; }
		public Guid U_CreatedBy { get; set; }
		public string DT_Updated { get; set; }
		public Guid U_UpdatedBy { get; set; }
	}
}
