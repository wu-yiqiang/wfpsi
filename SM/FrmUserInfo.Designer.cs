namespace WFPSI.SM
{
    partial class FrmUserInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userStateEnable = new System.Windows.Forms.RadioButton();
            this.userStateDisable = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.rolesCheckBox = new System.Windows.Forms.CheckedListBox();
            this.edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(343, 111);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(448, 35);
            this.userName.TabIndex = 1;
            this.userName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码";
            // 
            // userPassword
            // 
            this.userPassword.Location = new System.Drawing.Point(343, 207);
            this.userPassword.Name = "userPassword";
            this.userPassword.PasswordChar = '*';
            this.userPassword.Size = new System.Drawing.Size(448, 35);
            this.userPassword.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "状态";
            // 
            // userStateEnable
            // 
            this.userStateEnable.AutoSize = true;
            this.userStateEnable.Location = new System.Drawing.Point(343, 316);
            this.userStateEnable.Name = "userStateEnable";
            this.userStateEnable.Size = new System.Drawing.Size(89, 28);
            this.userStateEnable.TabIndex = 5;
            this.userStateEnable.TabStop = true;
            this.userStateEnable.Text = "启用";
            this.userStateEnable.UseVisualStyleBackColor = true;
            // 
            // userStateDisable
            // 
            this.userStateDisable.AutoSize = true;
            this.userStateDisable.Location = new System.Drawing.Point(480, 316);
            this.userStateDisable.Name = "userStateDisable";
            this.userStateDisable.Size = new System.Drawing.Size(89, 28);
            this.userStateDisable.TabIndex = 6;
            this.userStateDisable.TabStop = true;
            this.userStateDisable.Text = "停用";
            this.userStateDisable.UseVisualStyleBackColor = true;
            this.userStateDisable.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "角色";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(659, 592);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(132, 63);
            this.add.TabIndex = 9;
            this.add.Text = "添加";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(208, 592);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(125, 63);
            this.close.TabIndex = 10;
            this.close.Text = "关闭";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // rolesCheckBox
            // 
            this.rolesCheckBox.FormattingEnabled = true;
            this.rolesCheckBox.Location = new System.Drawing.Point(343, 388);
            this.rolesCheckBox.Name = "rolesCheckBox";
            this.rolesCheckBox.Size = new System.Drawing.Size(448, 196);
            this.rolesCheckBox.TabIndex = 11;
            this.rolesCheckBox.SelectedIndexChanged += new System.EventHandler(this.rolesCheckBox_SelectedIndexChanged);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(659, 592);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(132, 63);
            this.edit.TabIndex = 12;
            this.edit.Text = "编辑";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // FrmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 693);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.rolesCheckBox);
            this.Controls.Add(this.close);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userStateDisable);
            this.Controls.Add(this.userStateEnable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmUserInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户信息";
            this.Load += new System.EventHandler(this.FrmUserInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton userStateEnable;
        private System.Windows.Forms.RadioButton userStateDisable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.CheckedListBox rolesCheckBox;
        private System.Windows.Forms.Button edit;
    }
}