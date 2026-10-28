using PSI.Models.DModels;
using PSI.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSI.Models.VModels;
using PSI.DbUtility;
using System.Data;
using PSI.Common;
using System.Diagnostics;

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
        public List<UserInfoModel> GetUserList(string username)
        {
            string strWhere = "1=1";
            if (!string.IsNullOrEmpty(username))
            {
                strWhere += " AND UserName LIKE @uName";
                
            }
            SqlParameter parameters = new SqlParameter("@uName", "%" + username + "%");
            string cols = "UserId,UserName,UserPwd,UserState,Creator,CreateTime,IsDeleted";
            return GetModelList(strWhere, cols, parameters);
        }
        public UserInfoModel GetUserInfoById(int userId)
        {
            string strWhere = "UserId = @userId";
            SqlParameter parameters = new SqlParameter("@userId", userId);
            string cols = "UserId,UserName,UserPwd,UserState,Creator,CreateTime,IsDeleted";
            return GetModel(strWhere, cols, parameters);
        }
        public bool AddUser(UserInfoModel user, List<UserRoleInfoModel> urList)
        {
            string cols = "UserId,UserName,UserPwd,UserState,Creator,CreateTime,IsDeleted";
            SqlModel inUser = CreateSql.GetInsertSqlAndParas(user, cols, 1);
            return SqlHelper.ExecuteTrans<bool>(cmd =>
            {
                try
                {
                    cmd.CommandText = inUser.Sql;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Clear();
                    Debug.WriteLine("000000");
                    foreach (var p in inUser.SqlParaArray)
                    {
                        cmd.Parameters.Add(p);   
                    }
                    Debug.WriteLine("1111111");
                    object oId = cmd.ExecuteScalar();
                    cmd.Parameters.Clear();
                    if (oId != null && oId.ToString() != "") {
                        int userId = oId.GetInt();
                        if (urList.Count > 0)
                        {
                            string userRoleCols = "UserId,RoleId,Creator";
                            foreach (var ur in urList)
                            {
                                SqlModel inUserRole = CreateSql.GetInsertSqlAndParas<UserRoleInfoModel>(ur, userRoleCols, 1);
                                ur.UserId = userId;
                                cmd.CommandText = inUserRole.Sql;
                                cmd.CommandType = CommandType.Text;
                                cmd.Parameters.Clear();
                                foreach (var u in inUserRole.SqlParaArray)
                                {
                                    cmd.Parameters.Add(u);
                                }
                                cmd.ExecuteNonQuery();
                                cmd.Parameters.Clear();
                            }
                        }
                    }
                    cmd.Transaction.Commit();
                    return true;
                }
                catch
                {
                    cmd.Transaction.Rollback();
                    throw new Exception("添加用户失败");
                }
            });
        }
        public bool EditUser(UserInfoModel user, List<UserRoleInfoModel> urList)
        {
            string cols = "UserName,UserState";
            SqlModel inUser = CreateSql.GetUpdateSqlAndParas(user, cols, $"UserId={user.UserId}");
            return SqlHelper.ExecuteTrans<bool>(cmd =>
            {
                try
                {
                    cmd.CommandText = inUser.Sql;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Clear();
                    foreach (var p in inUser.SqlParaArray)
                    {
                        cmd.Parameters.Add(p);
                    }
                    cmd.ExecuteScalar();
                    cmd.Parameters.Clear();
                    string userRoleCols = "UserId,RoleId,Creator";
                    foreach (var ur in urList)
                    {
                        SqlModel inUserRole = CreateSql.GetInsertSqlAndParas<UserRoleInfoModel>(ur, userRoleCols, 1);
                        ur.UserId = user.UserId;
                        cmd.CommandText = inUserRole.Sql;
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Clear();
                        foreach (var u in inUserRole.SqlParaArray)
                        {
                            cmd.Parameters.Add(u);
                        }
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    cmd.Transaction.Commit();
                    return true;
                }
                catch
                {
                    cmd.Transaction.Rollback();
                    throw new Exception("修改用户失败");
                }
            });
        }
        //public List<ViewUserRoleModel> GetUserRoleById(int userId)
        //{
        //    string strWhere = "UserId = @userId";
        //    SqlParameter parameters = new SqlParameter("@userId", userId);
        //    string cols = "UserId,UserName,UserPwd,UserState,Creator,CreateTime,IsDeleted";
        //    return GetModelList(strWhere, cols, parameters);
        //}
        // public int Update(UserInfoModel user) { }
    }
}
