using PSI.Models.DModels;
using PSI.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI.DAL
{
    public class UserDAL:BaseDAL<UserInfoModel>
    {
        public int Login(string user_account, string user_hash_password)
        {
            string strWhere = "UserName=@UserName and UserPwd=@UserPwd and UserState = 1";
            SqlParameter[] paras =
            {
                new SqlParameter("@UserName", user_account),
                new SqlParameter("@UserPwd", user_hash_password)
            };
            UserInfoModel user = GetModel(strWhere, "UserId",paras);
            if (user != null) {
                return user.UserId;
            }else
            {
                return 0;
            }
        }
    }
}
