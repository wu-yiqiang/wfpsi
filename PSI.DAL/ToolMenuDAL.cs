using PSI.DAL;
using PSI.Models.DModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFPSI.DAL
{
    public class ToolMenuDAL:BaseDAL<ToolMenuInfoModel>
    {
        public List<ToolMenuInfoModel> GetToolMenuList(string roleIds)
        {
            string strWhere = "1=1 ";
            string cols = "TMenuId,TMenuName,TMPic,TMOrder,TGroupId,TMUrl,IsTop,TMDesp";
            if (!string.IsNullOrEmpty(roleIds))
            {
                strWhere += $" and TMenuId in (select TMenuId from RoleMenuInfos where RoleId in ({roleIds}))";

            }
            strWhere += " order by TMOrder";
            return GetModelList(strWhere, cols);
        }
    }
}
