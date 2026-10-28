using PSI.BLL;
using PSI.Common.Encrypt;
using PSI.Models.DModels;
using PSI.Models.VModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFPSI.BLL;
using WFPSI.FModels;
using WinPSI;

namespace WFPSI.SM
{
    public partial class FrmUserInfo : Form
    {
        private UserInfo userinfos;
        RoleBLL roleBll = new RoleBLL();
        UserBLL userBLL = new UserBLL();
        public FrmUserInfo()
        {
            InitializeComponent();
        }

        private void InitLoadRole()
        {
            List<RoleInfoModel> roles = roleBll.GetRoleList();
            rolesCheckBox.DataSource = roles;
            rolesCheckBox.DisplayMember = "RoleName";
            rolesCheckBox.ValueMember = "RoleId";
        }
        private void GetUserInfo(int userId)
        {
            UserInfoModel userInfo = userBLL.GetUserInfoById(userId);
            List<ViewUserRoleModel> viewUserRoles = userBLL.GetUserRoles(userId);
            if (userInfo != null) {
                this.userName.Text = userInfo.UserName;
                this.userPassword.Text = userInfo.UserPwd;
                if (userInfo.UserState == 1)
                {
                    this.userStateEnable.Checked = true;
                }else
                {
                    this.userStateDisable.Checked = true;
                }
            }
            if (viewUserRoles.Count > 0) {
                foreach (var viewUserRole in viewUserRoles)
                {
                    for (int i = 0; i < rolesCheckBox.Items.Count; i++)
                    {
                        RoleInfoModel role = rolesCheckBox.Items[i] as RoleInfoModel;
                        if (viewUserRole.RoleId == role.RoleId)
                        {
                            rolesCheckBox.SetItemChecked(i, true);
                        }
                    }
                }
            }
        }
        private void FrmUserInfo_Load(object sender, EventArgs e)
        {
            InitLoadRole();
            if (this.Tag != null)
            {
                this.userinfos = this.Tag as UserInfo;
            }
            if (this.userinfos.ActType == 1)
            {
                this.Text = "新增用户信息";
                this.add.Visible = true;
                this.edit.Visible = false;
                this.userName.Enabled = true;
                this.userPassword.Enabled = true;


            }
            if (this.userinfos.ActType == 2)
            {
                this.Text = "编辑用户信息";
                this.add.Visible = false;
                this.edit.Visible = true;
                this.userName.Enabled = false;
                this.userPassword.Enabled = false;
                GetUserInfo(this.userinfos.UserId);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            string enPassword = MD5Encrypt.Encrypt(this.userPassword.Text);
            List<RoleInfoModel> roles = this.rolesCheckBox.Items.Cast<RoleInfoModel>().ToList();
            List<UserRoleInfoModel> urList = new List<UserRoleInfoModel>();
            foreach (var item in roles)
            {
                urList.Add(new UserRoleInfoModel
                {
                    UserId = 12,
                    RoleId = item.RoleId,
                    Creator= "admin"
                });
            }
            bool result =  userBLL.AddUser(new UserInfoModel { UserName=this.userName.Text, UserPwd= enPassword, UserState= (this.userStateEnable.Checked == true ? 1:0), Creator="admin", CreateTime= DateTime.Now,IsDeleted = 0}, urList);
            if (result) {
                MsgBoxHelper.MsgBoxShow("添加用户","用户添加成功");
                this.userinfos.Reload();
                this.Close();
            }
            else
            {
                MsgBoxHelper.MsgErrorShow("添加用户失败");
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void edit_Click(object sender, EventArgs e)
        {
            int userId = this.userinfos.UserId;
            string enPassword = MD5Encrypt.Encrypt(this.userPassword.Text);
            List<RoleInfoModel> roles = this.rolesCheckBox.Items.Cast<RoleInfoModel>().ToList();
            List<UserRoleInfoModel> urList = new List<UserRoleInfoModel>();
            foreach (var item in roles)
            {
                urList.Add(new UserRoleInfoModel
                {
                    UserId = userId,
                    RoleId = item.RoleId,
                    Creator = "admin"
                });
            }
            bool result = userBLL.EditUser(new UserInfoModel { UserName = this.userName.Text, UserState = (this.userStateEnable.Checked == true ? 1 : 0) }, urList);
            if (result)
            {
                MsgBoxHelper.MsgBoxShow("编辑用户", "用户编辑成功");
                this.userinfos.Reload();
                this.Close();
            }
            else
            {
                MsgBoxHelper.MsgErrorShow("编辑用户失败");
            }
        }

        private void rolesCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
