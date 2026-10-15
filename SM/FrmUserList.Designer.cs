namespace WFPSI.SM
{
    partial class FrmUserList
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
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserState = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.enable = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameInput
            // 
            this.usernameInput.Font = new System.Drawing.Font("宋体", 10F);
            this.usernameInput.Location = new System.Drawing.Point(129, 22);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(249, 38);
            this.usernameInput.TabIndex = 0;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(21, 35);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(82, 24);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "用户名";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(429, 12);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(118, 48);
            this.search.TabIndex = 2;
            this.search.Text = "查询";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(25, 89);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(113, 48);
            this.add.TabIndex = 3;
            this.add.Text = "新增";
            this.add.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 47);
            this.button2.TabIndex = 6;
            this.button2.Text = "批量启用";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(300, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 47);
            this.button3.TabIndex = 7;
            this.button3.Text = "批量停用";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // userDataGridView
            // 
            this.userDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.UserName,
            this.UserState,
            this.createTime,
            this.edit,
            this.enable});
            this.userDataGridView.Location = new System.Drawing.Point(25, 144);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.RowHeadersWidth = 82;
            this.userDataGridView.RowTemplate.Height = 37;
            this.userDataGridView.Size = new System.Drawing.Size(1399, 624);
            this.userDataGridView.TabIndex = 8;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "编号";
            this.UserId.MinimumWidth = 10;
            this.UserId.Name = "UserId";
            this.UserId.Width = 200;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "用户名";
            this.UserName.MinimumWidth = 10;
            this.UserName.Name = "UserName";
            this.UserName.Width = 200;
            // 
            // UserState
            // 
            this.UserState.DataPropertyName = "UserState";
            this.UserState.FalseValue = "";
            this.UserState.HeaderText = "状态";
            this.UserState.MinimumWidth = 10;
            this.UserState.Name = "UserState";
            this.UserState.TrueValue = "";
            this.UserState.Width = 200;
            // 
            // createTime
            // 
            this.createTime.DataPropertyName = "CreateTime";
            this.createTime.HeaderText = "创建时间";
            this.createTime.MinimumWidth = 10;
            this.createTime.Name = "createTime";
            this.createTime.Width = 200;
            // 
            // edit
            // 
            this.edit.HeaderText = "修改";
            this.edit.MinimumWidth = 10;
            this.edit.Name = "edit";
            this.edit.Width = 200;
            // 
            // enable
            // 
            this.enable.HeaderText = "启用";
            this.enable.MinimumWidth = 10;
            this.enable.Name = "enable";
            this.enable.Width = 200;
            // 
            // FrmUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 780);
            this.Controls.Add(this.userDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.search);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameInput);
            this.Name = "FrmUserList";
            this.ShowIcon = false;
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.FrmUserList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UserState;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTime;
        private System.Windows.Forms.DataGridViewLinkColumn edit;
        private System.Windows.Forms.DataGridViewLinkColumn enable;
    }
}