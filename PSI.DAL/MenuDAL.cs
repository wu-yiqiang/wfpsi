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
            string strWhere = "1=1 ";
            string cols = "MId,MName,ParentId,MKey,MKey,MUrl,IsTop";
            if (string.IsNullOrEmpty(roleIds))
            {
                strWhere += $" and MId in (select MId from RoleMenuInfos where RoleId in ({roleIds}))";
            } 
            strWhere += " order by MOrder";
            return GetModelList(strWhere, cols);
        }

    }
}
