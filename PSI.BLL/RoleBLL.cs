using PSI.BLL;
using PSI.DAL;
using PSI.Models.DModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFPSI.DAL;

namespace WFPSI.BLL
{
    public class RoleBLL : BaseBLL<RoleInfoModel>
    {
        RoleDAL roleDAL = new DAL.RoleDAL();
        public List<RoleInfoModel> GetRoleList()
        {
            return roleDAL.GetRoleList();
        }
    }
}
