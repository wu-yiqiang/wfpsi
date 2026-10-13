using PSI.BLL;
using PSI.Models.DModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFPSI.DAL;

namespace WFPSI.BLL
{
    public class ToolMenuBLL:BaseBLL<ToolMenuInfoModel>
    {
        ToolMenuDAL tooMenuDAL = new ToolMenuDAL();
        public List<ToolMenuInfoModel> GetMenuList(string roleIds)
        {
            return tooMenuDAL.GetToolMenuList(roleIds);
        }
    }
}
