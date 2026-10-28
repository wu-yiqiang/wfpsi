namespace WFPSI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginTime = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PSIMenus = new System.Windows.Forms.MenuStrip();
            this.PSITools = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tcPages = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.PSITools.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.loginTime);
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 752);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1411, 60);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // loginTime
            // 
            this.loginTime.AutoSize = true;
            this.loginTime.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Bold);
            this.loginTime.Location = new System.Drawing.Point(468, 26);
            this.loginTime.Name = "loginTime";
            this.loginTime.Size = new System.Drawing.Size(202, 22);
            this.loginTime.TabIndex = 3;
            this.loginTime.Text = "0000-00-00 00:00";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Bold);
            this.user.Location = new System.Drawing.Point(121, 25);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(58, 22);
            this.user.TabIndex = 2;
            this.user.Text = "user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11F);
            this.label2.Location = new System.Drawing.Point(325, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "登录时间:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "操作人： ";
            // 
            // PSIMenus
            // 
            this.PSIMenus.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.PSIMenus.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.PSIMenus.Location = new System.Drawing.Point(0, 0);
            this.PSIMenus.Name = "PSIMenus";
            this.PSIMenus.Size = new System.Drawing.Size(1411, 24);
            this.PSIMenus.TabIndex = 2;
            this.PSIMenus.Text = "menuStrip1";
            // 
            // PSITools
            // 
            this.PSITools.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.PSITools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.PSITools.Location = new System.Drawing.Point(0, 24);
            this.PSITools.Name = "PSITools";
            this.PSITools.Size = new System.Drawing.Size(1411, 30);
            this.PSITools.TabIndex = 3;
            this.PSITools.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(46, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // tcPages
            // 
            this.tcPages.Location = new System.Drawing.Point(13, 96);
            this.tcPages.Name = "tcPages";
            this.tcPages.SelectedIndex = 0;
            this.tcPages.Size = new System.Drawing.Size(1398, 641);
            this.tcPages.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 809);
            this.Controls.Add(this.tcPages);
            this.Controls.Add(this.PSITools);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PSIMenus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.PSIMenus;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "鼎飞进销存管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PSITools.ResumeLayout(false);
            this.PSITools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label loginTime;
        private System.Windows.Forms.MenuStrip PSIMenus;
        private System.Windows.Forms.ToolStrip PSITools;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TabControl tcPages;
    }
}