namespace WFPSI
{
    partial class Login_Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button login;
            System.Windows.Forms.Button handle_exit;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.account = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.logoBox = new System.Windows.Forms.PictureBox();
            login = new System.Windows.Forms.Button();
            handle_exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            login.BackColor = System.Drawing.SystemColors.Control;
            login.Location = new System.Drawing.Point(745, 651);
            login.Name = "login";
            login.Size = new System.Drawing.Size(131, 79);
            login.TabIndex = 0;
            login.Text = "登录";
            login.UseVisualStyleBackColor = false;
            login.Click += new System.EventHandler(this.handle_login);
            // 
            // handle_exit
            // 
            handle_exit.BackColor = System.Drawing.SystemColors.Control;
            handle_exit.Location = new System.Drawing.Point(336, 651);
            handle_exit.Name = "handle_exit";
            handle_exit.Size = new System.Drawing.Size(112, 79);
            handle_exit.TabIndex = 1;
            handle_exit.Text = "退出";
            handle_exit.UseVisualStyleBackColor = false;
            handle_exit.Click += new System.EventHandler(this.cancel_login);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.Location = new System.Drawing.Point(263, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "账号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(263, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码";
            // 
            // account
            // 
            this.account.Font = new System.Drawing.Font("宋体", 14F);
            this.account.Location = new System.Drawing.Point(383, 100);
            this.account.MaxLength = 50;
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(467, 50);
            this.account.TabIndex = 4;
            this.account.Text = "admin";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("宋体", 14F);
            this.password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password.Location = new System.Drawing.Point(383, 239);
            this.password.MaxLength = 50;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(467, 50);
            this.password.TabIndex = 5;
            this.password.Text = "admin";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.account);
            this.panel1.Location = new System.Drawing.Point(66, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 405);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(441, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 48);
            this.label3.TabIndex = 8;
            this.label3.Text = "鼎飞进销存系统";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoBox
            // 
            this.logoBox.Image = global::WFPSI.Properties.Resources.logo;
            this.logoBox.Location = new System.Drawing.Point(13, 13);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(120, 120);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 9;
            this.logoBox.TabStop = false;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WFPSI.Properties.Resources.lbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1220, 805);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(handle_exit);
            this.Controls.Add(login);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "鼎飞进销存管理系统";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox account;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox logoBox;
    }
}

