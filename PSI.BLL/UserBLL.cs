using PSI.BLL;
using PSI.DAL;
using PSI.Models.DModels;
using PSI.Models.VModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFPSI.DAL;

namespace PSI.BLL
{
    public class UserBLL:BaseBLL<UserInfoModel>
    {
        UserDAL userDAL = new DAL.UserDAL();
        ViewUserRoleDAL vUserRole = new ViewUserRoleDAL();
        public List<ViewUserRoleModel> Login(string username, string user_hashed_password)
        {
            List<ViewUserRoleModel> roleList = new List<ViewUserRoleModel>();
            ViewUserRoleDAL vurDAL = new ViewUserRoleDAL();
            int userId = userDAL.Login(username, user_hashed_password);
            if (userId > 0) {
                roleList = vurDAL.GetUserRoles(userId);
            }
            return roleList;
        }
        public List<UserInfoModel> GetUserList(string username)
        {
            return userDAL.GetUserList(username);
        }
        public UserInfoModel GetUserInfoById(int userId)
        {
            return userDAL.GetUserInfoById(userId);
        }
        public List<ViewUserRoleModel> GetUserRoles(int userId) { 
            return vUserRole.GetUserRoles(userId);
        }
        public bool AddUser(UserInfoModel user, List<UserRoleInfoModel> urList)
        {
            try
            {
                userDAL.AddUser(user, urList);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool EditUser(UserInfoModel user, List<UserRoleInfoModel> urList)
        {
            try
            {
                userDAL.EditUser(user, urList);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
