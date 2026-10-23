using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFPSI.FModels;

namespace WFPSI.SM
{
    public partial class FrmUserInfo : Form
    {
        private UserInfo userinfos;
        public FrmUserInfo()
        {
            InitializeComponent();
        }

        private void FrmUserInfo_Load(object sender, EventArgs e)
        {

            if (this.Tag != null)
            {
                this.userinfos = this.Tag as UserInfo;
            }
            if (this.userinfos.ActType == 1)
            {
                this.Text = "新增用户信息";
            }
            if (this.userinfos.ActType == 2)
            {
                this.Text = "编辑用户信息";
            }
        }
    }
}
