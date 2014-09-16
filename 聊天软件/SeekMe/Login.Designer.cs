namespace SeekMe
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override 
            void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.ID = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.ID_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon_Login = new System.Windows.Forms.NotifyIcon(this.components);
            this.Notify_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开SeekMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Set_Button = new System.Windows.Forms.Button();
            this.Reg_Button = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Notify_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ID.Location = new System.Drawing.Point(151, 253);
            this.ID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(209, 27);
            this.ID.TabIndex = 2;
            this.ID.Text = "Rhodes";
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Password.Location = new System.Drawing.Point(151, 294);
            this.Password.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(209, 27);
            this.Password.TabIndex = 3;
            this.Password.Text = "1234567";
            this.Password.UseSystemPasswordChar = true;
            // 
            // ID_Label
            // 
            this.ID_Label.AutoSize = true;
            this.ID_Label.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ID_Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ID_Label.Location = new System.Drawing.Point(53, 255);
            this.ID_Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ID_Label.Name = "ID_Label";
            this.ID_Label.Size = new System.Drawing.Size(69, 20);
            this.ID_Label.TabIndex = 4;
            this.ID_Label.Text = "用户名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(53, 301);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "密  码：";
            // 
            // notifyIcon_Login
            // 
            this.notifyIcon_Login.ContextMenuStrip = this.Notify_Menu;
            this.notifyIcon_Login.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_Login.Icon")));
            this.notifyIcon_Login.Text = "SeekMe!(未登录)";
            this.notifyIcon_Login.Visible = true;
            this.notifyIcon_Login.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_Login_MouseDoubleClick);
            // 
            // Notify_Menu
            // 
            this.Notify_Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Notify_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开SeekMeToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.Notify_Menu.Name = "Notify_Menu";
            this.Notify_Menu.Size = new System.Drawing.Size(168, 52);
            // 
            // 打开SeekMeToolStripMenuItem
            // 
            this.打开SeekMeToolStripMenuItem.Name = "打开SeekMeToolStripMenuItem";
            this.打开SeekMeToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.打开SeekMeToolStripMenuItem.Text = "打开SeekMe";
            this.打开SeekMeToolStripMenuItem.Click += new System.EventHandler(this.打开SeekMeToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(399, 299);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 20);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "忘记密码";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(331, 345);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login_Button
            // 
            this.Login_Button.BackColor = System.Drawing.Color.Transparent;
            this.Login_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login_Button.BackgroundImage")));
            this.Login_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Button.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Login_Button.Location = new System.Drawing.Point(57, 343);
            this.Login_Button.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(214, 51);
            this.Login_Button.TabIndex = 0;
            this.Login_Button.Text = "登陆";
            this.Login_Button.UseVisualStyleBackColor = false;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Set_Button
            // 
            this.Set_Button.BackColor = System.Drawing.Color.Transparent;
            this.Set_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Set_Button.BackgroundImage")));
            this.Set_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Set_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Set_Button.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Set_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Set_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Set_Button.Location = new System.Drawing.Point(471, 250);
            this.Set_Button.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Set_Button.Name = "Set_Button";
            this.Set_Button.Size = new System.Drawing.Size(66, 35);
            this.Set_Button.TabIndex = 2;
            this.Set_Button.Text = "设置";
            this.Set_Button.UseVisualStyleBackColor = false;
            this.Set_Button.Click += new System.EventHandler(this.Set_Button_Click);
            // 
            // Reg_Button
            // 
            this.Reg_Button.BackColor = System.Drawing.Color.Transparent;
            this.Reg_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Reg_Button.BackgroundImage")));
            this.Reg_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reg_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reg_Button.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Reg_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Reg_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Reg_Button.Location = new System.Drawing.Point(396, 250);
            this.Reg_Button.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Reg_Button.Name = "Reg_Button";
            this.Reg_Button.Size = new System.Drawing.Size(66, 35);
            this.Reg_Button.TabIndex = 1;
            this.Reg_Button.Text = "注册";
            this.Reg_Button.UseVisualStyleBackColor = false;
            this.Reg_Button.Click += new System.EventHandler(this.Reg_Button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SeekMe.Properties.Resources.logingif;
            this.pictureBox2.Location = new System.Drawing.Point(0, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(600, 214);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // Login
            // 
            this.AcceptButton = this.Login_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(594, 440);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Set_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID_Label);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Reg_Button);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeekMe!";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.Notify_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button Reg_Button;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label ID_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Set_Button;
        private System.Windows.Forms.NotifyIcon notifyIcon_Login;
        private System.Windows.Forms.ContextMenuStrip Notify_Menu;
        private System.Windows.Forms.ToolStripMenuItem 打开SeekMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        public System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

