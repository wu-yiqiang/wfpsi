using PSI.DAL;
using PSI.Models.DModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFPSI.DAL
{
    public class RoleDAL: BaseDAL<RoleInfoModel>
    {
       public List<RoleInfoModel> GetRoleList()
       {
            string strWhere = " IsDeleted = 0";
            string cols = "RoleId,RoleName";
            List<RoleInfoModel> roles = GetModelList(strWhere, cols);
            return roles;
        }
    }
}
