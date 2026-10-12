using PSI.BLL;
using PSI.Common.Encrypt;
using PSI.Models.VModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFPSI.FModels;
using WinPSI;

namespace WFPSI
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            //password.Clear();
            //account.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void handle_login(object sender, EventArgs e)
        {
            string user_account = this.account.Text.Trim();
            string user_password = this.password.Text.Trim();
            if (string.IsNullOrEmpty(user_account) || string.IsNullOrEmpty(user_password))
            {
                MsgBoxHelper.MsgErrorShow("账号和密码不能为空");
                return;
            }
            string enPassword = MD5Encrypt.Encrypt(user_password);
            UserBLL userBLL = new UserBLL();
            List<ViewUserRoleModel> urList = userBLL.Login(user_account, enPassword);
            if (urList == null || urList.Count == 0 )
            {
                MsgBoxHelper.MsgErrorShow("登录失败");
                return;
            }
            if (!FormUtility.CheckOpenForm("MainForm"))
            {   
                MainForm mainForm = new MainForm();
                mainForm.Tag = new LoginModel()
                {
                    URList = urList,
                    Login_Form = this
                };
                mainForm.Show();
                this.Hide();
            }
           
        }

        private void cancel_login(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
