using PSI.DAL;
using PSI.Models.DModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFPSI.DAL
{
    public class MenuDAL:BaseDAL<MenuInfoModel>
    { 

        public List<MenuInfoModel> GetMenuList(string roleIds)
        {
            string strWhere = "";
            if (string.IsNullOrEmpty(roleIds))
            {
                strWhere = " order by MOrder";
            }else
            {
                strWhere = $" MId in (select MId from RoleMenuInfos where RoleId in ({roleIds})) order by MOrder";
            }
            string cols = "MId,MName,ParentId,MKey,MKey,MUrl,IsTop";
            return GetModelList(strWhere, cols);
        }

    }
}
