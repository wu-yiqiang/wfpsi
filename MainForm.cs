using PSI.Models.DModels;
using PSI.Models.VModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFPSI.BLL;
using WFPSI.DAL;
using WFPSI.FModels;
using WinPSI;

namespace WFPSI
{
    public partial class MainForm : Form
    {
        private Login_Form _loginForm;
        private bool _isBackToLogin = false;
        public MainForm(Login_Form loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
        }
        List<ViewUserRoleModel> urList = null;
        private MenuBLL menuBLL = new MenuBLL();
        private ToolMenuBLL toolMenuBLL = new ToolMenuBLL();
        private SysBLL sysBLL = new SysBLL();

        string uName = "";
        bool isAdmin = false;
        bool hasOpened = false;
        private enum ToolMenuDesp
        {
            ExitSystem = 1,
            ChangeActor = 2,
            RefreshMenu = 3,

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Action act = () =>
            {
                hasOpened = sysBLL.GetOpenState(1);
                if (this.Tag != null)
                {
                    InitMainInfo();
                }
            };
            act.TryCatch("页面初始化失败");
        }

        private void AddToolMenuItem(List<ToolMenuInfoModel> toolList)
        {
            List<int> groupIds = new List<int>();
            foreach (var ti in toolList)
            {
                Debug.WriteLine(ti.TGroupId);
                if (!groupIds.Contains(ti.TGroupId))
                {
                    groupIds.Add(ti.TGroupId);
                }
            }
            foreach (var groupId in groupIds)
            {
                var gTools = toolList.Where(t => t.TGroupId == groupId);
                foreach (var tmi in gTools)
                {
                    ToolStripButton tsbtn = new ToolStripButton();
                    tsbtn.Text = tmi.TMenuName;
                    tsbtn.Name = tmi.TMenuId.ToString();
                    if (!string.IsNullOrEmpty(tmi.TMPic)) tsbtn.Image = Image.FromFile(Application.StartupPath + '/' + tmi.TMPic);
                    tsbtn.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                    tsbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                    tsbtn.Tag = tmi;
                    tsbtn.Click += Tsbtn_Click;
                    PSITools.Items.Add(tsbtn);

                }
                if (gTools.ToList().Count > 0) {
                    ToolStripSeparator sp = new ToolStripSeparator();
                    PSITools.Items.Add(sp);
                }
            }
        }

        private void Tsbtn_Click(object sender, EventArgs e)
        {
            ToolStripButton tsBtn = sender as ToolStripButton;
            if (tsBtn.Tag != null) { 
                ToolMenuInfoModel tmInfo = tsBtn.Tag as ToolMenuInfoModel;
                string mUrl = tmInfo.TMUrl;
                if (!string.IsNullOrEmpty(mUrl)) {
                    string assName = this.GetType().Assembly.GetName().Name;
                    ObjectHandle t = Activator.CreateInstance(assName, assName + "." + mUrl);
                    Form f = (Form)t.Unwrap();
                    f.Tag = uName;
                    if (tmInfo.IsTop == 0)
                    {
                        tcPages.AddTabFormPage(f);
                    }
                    else
                    {
                        f.StartPosition = FormStartPosition.CenterScreen;
                        f.WindowState = FormWindowState.Normal;
                        f.ShowDialog();
                    }
                }else
                {
                    if (tmInfo.TMDesp == ToolMenuDesp.ExitSystem.ToString())
                    {
                        // 退出
                        _isBackToLogin = false;
                        Application.Exit();
                    }
                    if (tmInfo.TMDesp == ToolMenuDesp.ChangeActor.ToString())
                    {
                        // 修改操作员
                        _isBackToLogin = true;
                        this.Close();
                        _loginForm.Show();
                    }
                    if (tmInfo.TMDesp == ToolMenuDesp.RefreshMenu.ToString())
                    {
                        // 刷新系统
                        AddMenuAndToolMenus();
                    }
                }

            }
        }

        private void InitMainInfo()
        {
            LoginModel loginModel = this.Tag as LoginModel;
            if (loginModel != null) { 
                urList = loginModel.URList;
                uName = urList[0].UserName;
                user.Text = uName;
                loginTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                AddMenuAndToolMenus();
            }
        }
        private void AddMenuItem(List<MenuInfoModel> mList,ToolStripMenuItem pMenu,int pId)
        {
            var childList = mList.Where(m => m.ParentId == pId);
            foreach (var child in childList) { 
                ToolStripMenuItem mi = new ToolStripMenuItem();
                mi.Name = child.MId.ToString();
                mi.Text = child.MName.ToString();
                if (!string.IsNullOrEmpty(child.MKey))
                {
                    string sKey = child.MKey.ToString().Trim();
                    if (sKey.Length > 1 && sKey.Substring(0,3).ToLower() == "alt")
                    {
                        mi.Text += $"(&{sKey.Substring(4)})";
                        Keys k;
                        Enum.TryParse<Keys>(sKey.Substring(4), out k);
                        mi.ShortcutKeys = ((Keys)(Keys.Alt | k));

                    }else if(sKey.Length > 1 && sKey.Substring(0,4).ToLower() == "ctrl")
                    {
                        Keys k;
                        Enum.TryParse<Keys>(sKey.Substring(5), out k);
                        mi.ShortcutKeys = ((Keys)(Keys.Control | k));
                    } 
                }
                if (!string.IsNullOrEmpty(child.MUrl))
                {
                    mi.Tag = child;
                }
                if (mList.Where(m => m.ParentId == child.MId).ToList().Count ==0) {
                    mi.Click += Mi_Click;
                }
                if (pMenu != null)
                {
                    pMenu.DropDownItems.Add(mi);
                }else
                {
                    PSIMenus.Items.Add(mi);

                }
                AddMenuItem(mList, mi, child.MId);
            }
        }

        private void Mi_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem mi = sender as ToolStripMenuItem;
            if (mi.Tag != null)
            {
                MenuInfoModel mInfo = mi.Tag as MenuInfoModel;
                if (!string.IsNullOrEmpty(mInfo.MUrl))
                {
                    string assName = this.GetType().Assembly.GetName().Name;
                    ObjectHandle t = Activator.CreateInstance(assName, assName + "." + mInfo.MUrl);
                    Form f = (Form)t.Unwrap();
                    f.Tag = uName;
                    if (mInfo.IsTop == 0)
                    {
                        tcPages.AddTabFormPage(f);
                    }else
                    {
                        f.StartPosition = FormStartPosition.CenterScreen;
                        f.WindowState = FormWindowState.Normal;
                        f.ShowDialog();
                    }

                }
            }
            
        }

        private void AddMenuAndToolMenus()
        {
            List<MenuInfoModel> menuList = new List<MenuInfoModel>();
            List<ToolMenuInfoModel> toolMenuList = new List<ToolMenuInfoModel>();
            isAdmin = CheckIsAdmin();
            if (isAdmin)
            {
                menuList = menuBLL.GetMenuList("");
                toolMenuList = toolMenuBLL.GetMenuList("");

            }
            else
            {
                string roles = string.Join(",", urList.Select(ur => ur.RoleId));

                menuList = menuBLL.GetMenuList(roles);
                toolMenuList = toolMenuBLL.GetMenuList(roles);
            }
            PSIMenus.Items.Clear();
            PSITools.Items.Clear();
            AddMenuItem(menuList, null, 0);
            AddToolMenuItem(toolMenuList);

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


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isBackToLogin)
            {
                return;
            }
            var result = MsgBoxHelper.MsgBoxConfirm("关闭确认", "确认退出当前系统吗？");
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }else
            {
                e.Cancel = true;
            }
        }
    }
}
