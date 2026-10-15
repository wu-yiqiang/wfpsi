using PSI.Common;
using PSI.DbUtility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFPSI.DAL
{
    public class SysDAL
    {
        public int GetSysOpenState(int sysId)
        {
            string sql = "select IsOpened from SysInfos where SysId=@sysId";
            SqlParameter paraId = new SqlParameter("sysId", sysId);
            object oIsOpened = SqlHelper.ExecuteScalar(sql,1, paraId);
            if (oIsOpened != null && oIsOpened.ToString() != "") {
                return oIsOpened.GetInt();
            }else
            {
                return 0;
            }
        }
    }
}
