using PSI.Models.DModels;
using PSI.Models.VModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFPSI.BLL;
using WFPSI.FModels;
using WinPSI;

namespace WFPSI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        List<ViewUserRoleModel> urList = null;
        private MenuBLL menuBLL = new MenuBLL();
        string uName = "";
        bool isAdmin = false;

        private void MainForm_Load(object sender, EventArgs e)
        {
            Action act = () =>
            {
                if (this.Tag != null)
                {
                    InitMainInfo();
                }
            };
            act.TryCatch("页面初始化失败");
        }

        private void InitMainInfo()
        {
            LoginModel loginModel = this.Tag as LoginModel;
            if (loginModel != null) { 
                urList = loginModel.URList;
                uName = urList[0].UserName;
                isAdmin = CheckIsAdmin();
                List<MenuInfoModel> menuList = new List<MenuInfoModel>();
                if (isAdmin) {
                    menuList = menuBLL.GetMenuList("");
                }else
                {
                    string roles = string.Join(",", urList.Select(ur => ur.RoleId));
                    user.Text = uName;
                    loginTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                    menuList = menuBLL.GetMenuList(roles);
                }
            }
        }
        private bool CheckIsAdmin()
        {
            foreach (var ur in urList)
            {
                if (ur.RoleName == "admin")
                {
                    return true;
                } 
            }
            return false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
