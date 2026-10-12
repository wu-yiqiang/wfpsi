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
    public class MenuBLL:BaseBLL<MenuInfoModel>
    {
        MenuDAL menuDAL = new MenuDAL();
        public List<MenuInfoModel> GetMenuList(string roleIds)
        {
            List<MenuInfoModel> list = new List<MenuInfoModel>();
            list = menuDAL.GetMenuList(roleIds);
            return list;
        }
    }
}
