using PSI.DAL;
using PSI.Models.VModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFPSI.DAL
{
    public class ViewUserRoleDAL:BQuery<ViewUserRoleModel>
    {
        public List<ViewUserRoleModel> GetUserRoles(int userId)
        {
            string strWhere = "@UserId=UserId";
            SqlParameter paraId = new SqlParameter("@UserId", userId);
            return GetModelList(strWhere, "UserId,UserName,RoleId,RoleName", paraId);
        }
    }
}
