using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFPSI.DAL;

namespace WFPSI.BLL
{
    public class SysBLL
    {
        SysDAL sysDal = new SysDAL();
        public bool GetOpenState(int sysId)
        {
            int isOpened = sysDal.GetSysOpenState(sysId);
            if (isOpened == 1)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
