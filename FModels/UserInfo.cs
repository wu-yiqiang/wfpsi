using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFPSI.FModels
{
    public class UserInfo
    {
        // 1 新增 2 编辑
        public int ActType { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        //public string UserPwd { get; set; }
        //public int UserState { get; set; }
        //public int IsDeleted { get; set; }
        public Action Reload {  get; set; }

        //UserId,UserName,UserPwd,UserState,Creator,CreateTime,IsDeleted
    }
}
