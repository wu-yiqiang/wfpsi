using PSI.BLL;
using PSI.Models.DModels;
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

namespace WFPSI.SM
{
    public partial class FrmUserList : Form
    {
        UserBLL userBLL = new UserBLL();
        List<UserInfoModel> userLists;

        public FrmUserList()
        {
            InitializeComponent();
            // 注册数据绑定完成事件
            userDataGridView.DataBindingComplete += UserDataGridView_DataBindingComplete;
        }

        private void FrmUserList_Load(object sender, EventArgs e)
        {
            LoadUserList();
        }

        private void LoadUserList()
        {
            string userName = usernameInput.Text.Trim();
            userLists = userBLL.GetUserList(userName);
            userDataGridView.AutoGenerateColumns = false;
            userDataGridView.DataSource = userLists;
            // 不要在这里遍历 Rows！
        }

        // 数据绑定完成后，再设置"启用/停用"链接文字
        private void UserDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in userDataGridView.Rows)
            {
                if (row.DataBoundItem is UserInfoModel userInfo)
                {
                    var enableCell = row.Cells["enable"] as DataGridViewLinkCell;
                    enableCell.Value = userInfo.UserState == 1 ? "停用" : "启用";
                }
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            LoadUserList();
        }
    }
}
