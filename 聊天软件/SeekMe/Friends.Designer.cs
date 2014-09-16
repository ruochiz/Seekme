namespace SeekMe
{
    partial class Friends
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Friends));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开SeekMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人资料修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.好友管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.密码修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.服务器IP修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.综合设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcome_label = new System.Windows.Forms.Label();
            this.Set = new System.Windows.Forms.Button();
            this.PassWordSet = new System.Windows.Forms.Button();
            this.AddFriend = new System.Windows.Forms.Button();
            this.SetSelfInfo = new System.Windows.Forms.Button();
            this.MenuStrip_FriDisplay = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.好友显示方式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.皮肤ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.皮肤1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.皮肤2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.皮肤3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.imageList_small = new System.Windows.Forms.ImageList(this.components);
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.FriList = new System.Windows.Forms.ListView();
            this.Exit = new System.Windows.Forms.Button();
            this.TimerForCheckConn = new System.Windows.Forms.Timer(this.components);
            this.OnlineState = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.NotifyMenu.SuspendLayout();
            this.MenuStrip_FriDisplay.SuspendLayout();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.NotifyMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "SeekMe";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // NotifyMenu
            // 
            this.NotifyMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NotifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开SeekMeToolStripMenuItem,
            this.个人设置ToolStripMenuItem,
            this.系统设置ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.NotifyMenu.Name = "NotifyMenu";
            this.NotifyMenu.Size = new System.Drawing.Size(199, 100);
            // 
            // 打开SeekMeToolStripMenuItem
            // 
            this.打开SeekMeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.打开SeekMeToolStripMenuItem.Name = "打开SeekMeToolStripMenuItem";
            this.打开SeekMeToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.打开SeekMeToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.打开SeekMeToolStripMenuItem.Text = "打开SeekMe! (&O)";
            this.打开SeekMeToolStripMenuItem.Click += new System.EventHandler(this.打开SeekMeToolStripMenuItem_Click);
            // 
            // 个人设置ToolStripMenuItem
            // 
            this.个人设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个人资料修改ToolStripMenuItem,
            this.好友管理ToolStripMenuItem,
            this.密码修改ToolStripMenuItem});
            this.个人设置ToolStripMenuItem.Name = "个人设置ToolStripMenuItem";
            this.个人设置ToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.个人设置ToolStripMenuItem.Text = "个人设置 (&P)";
            // 
            // 个人资料修改ToolStripMenuItem
            // 
            this.个人资料修改ToolStripMenuItem.Name = "个人资料修改ToolStripMenuItem";
            this.个人资料修改ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.个人资料修改ToolStripMenuItem.Text = "个人资料修改";
            // 
            // 好友管理ToolStripMenuItem
            // 
            this.好友管理ToolStripMenuItem.Name = "好友管理ToolStripMenuItem";
            this.好友管理ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.好友管理ToolStripMenuItem.Text = "好友管理";
            // 
            // 密码修改ToolStripMenuItem
            // 
            this.密码修改ToolStripMenuItem.Name = "密码修改ToolStripMenuItem";
            this.密码修改ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.密码修改ToolStripMenuItem.Text = "密码修改";
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.服务器IP修改ToolStripMenuItem,
            this.综合设置ToolStripMenuItem});
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.系统设置ToolStripMenuItem.Text = "系统设置 (&S)";
            // 
            // 服务器IP修改ToolStripMenuItem
            // 
            this.服务器IP修改ToolStripMenuItem.Name = "服务器IP修改ToolStripMenuItem";
            this.服务器IP修改ToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.服务器IP修改ToolStripMenuItem.Text = "服务器IP修改";
            // 
            // 综合设置ToolStripMenuItem
            // 
            this.综合设置ToolStripMenuItem.Name = "综合设置ToolStripMenuItem";
            this.综合设置ToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.综合设置ToolStripMenuItem.Text = "综合设置";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.退出ToolStripMenuItem.Text = "退出 (&Q)";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.BackColor = System.Drawing.Color.Transparent;
            this.welcome_label.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.welcome_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.welcome_label.Location = new System.Drawing.Point(35, 92);
            this.welcome_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(130, 20);
            this.welcome_label.TabIndex = 2;
            this.welcome_label.Text = "Hi, Nickname(ID)";
            // 
            // Set
            // 
            this.Set.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Set.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Set.BackgroundImage")));
            this.Set.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Set.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Set.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Set.Location = new System.Drawing.Point(8, 593);
            this.Set.Margin = new System.Windows.Forms.Padding(2);
            this.Set.Name = "Set";
            this.Set.Size = new System.Drawing.Size(86, 32);
            this.Set.TabIndex = 8;
            this.Set.Text = "网络设置";
            this.Set.UseVisualStyleBackColor = true;
            this.Set.Click += new System.EventHandler(this.Set_Click);
            // 
            // PassWordSet
            // 
            this.PassWordSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PassWordSet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PassWordSet.BackgroundImage")));
            this.PassWordSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PassWordSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PassWordSet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PassWordSet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PassWordSet.Location = new System.Drawing.Point(107, 593);
            this.PassWordSet.Margin = new System.Windows.Forms.Padding(2);
            this.PassWordSet.Name = "PassWordSet";
            this.PassWordSet.Size = new System.Drawing.Size(86, 32);
            this.PassWordSet.TabIndex = 10;
            this.PassWordSet.Text = "密码修改";
            this.PassWordSet.UseVisualStyleBackColor = true;
            this.PassWordSet.Click += new System.EventHandler(this.PassWordSet_Click);
            // 
            // AddFriend
            // 
            this.AddFriend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddFriend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddFriend.BackgroundImage")));
            this.AddFriend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFriend.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddFriend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddFriend.Location = new System.Drawing.Point(206, 593);
            this.AddFriend.Margin = new System.Windows.Forms.Padding(2);
            this.AddFriend.Name = "AddFriend";
            this.AddFriend.Size = new System.Drawing.Size(86, 32);
            this.AddFriend.TabIndex = 11;
            this.AddFriend.Text = "添加好友";
            this.AddFriend.UseVisualStyleBackColor = true;
            this.AddFriend.Click += new System.EventHandler(this.AddFriend_Click);
            // 
            // SetSelfInfo
            // 
            this.SetSelfInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SetSelfInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SetSelfInfo.BackgroundImage")));
            this.SetSelfInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetSelfInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetSelfInfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SetSelfInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SetSelfInfo.Location = new System.Drawing.Point(7, 676);
            this.SetSelfInfo.Margin = new System.Windows.Forms.Padding(2);
            this.SetSelfInfo.Name = "SetSelfInfo";
            this.SetSelfInfo.Size = new System.Drawing.Size(116, 32);
            this.SetSelfInfo.TabIndex = 12;
            this.SetSelfInfo.Text = "修改个人资料";
            this.SetSelfInfo.UseVisualStyleBackColor = true;
            this.SetSelfInfo.Click += new System.EventHandler(this.SetSelfInfo_Click);
            // 
            // MenuStrip_FriDisplay
            // 
            this.MenuStrip_FriDisplay.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip_FriDisplay.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.好友显示方式ToolStripMenuItem,
            this.皮肤ToolStripMenuItem});
            this.MenuStrip_FriDisplay.Name = "MenuStrip_FriDisplay";
            this.MenuStrip_FriDisplay.Size = new System.Drawing.Size(169, 52);
            // 
            // 好友显示方式ToolStripMenuItem
            // 
            this.好友显示方式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.大图标ToolStripMenuItem,
            this.小图标ToolStripMenuItem,
            this.列表ToolStripMenuItem,
            this.tailToolStripMenuItem});
            this.好友显示方式ToolStripMenuItem.Name = "好友显示方式ToolStripMenuItem";
            this.好友显示方式ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.好友显示方式ToolStripMenuItem.Text = "好友显示方式";
            // 
            // 大图标ToolStripMenuItem
            // 
            this.大图标ToolStripMenuItem.Name = "大图标ToolStripMenuItem";
            this.大图标ToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.大图标ToolStripMenuItem.Text = "大图标";
            this.大图标ToolStripMenuItem.Click += new System.EventHandler(this.大图标ToolStripMenuItem_Click);
            // 
            // 小图标ToolStripMenuItem
            // 
            this.小图标ToolStripMenuItem.Name = "小图标ToolStripMenuItem";
            this.小图标ToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.小图标ToolStripMenuItem.Text = "小图标";
            this.小图标ToolStripMenuItem.Click += new System.EventHandler(this.小图标ToolStripMenuItem_Click);
            // 
            // 列表ToolStripMenuItem
            // 
            this.列表ToolStripMenuItem.Name = "列表ToolStripMenuItem";
            this.列表ToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.列表ToolStripMenuItem.Text = "列表";
            this.列表ToolStripMenuItem.Click += new System.EventHandler(this.列表ToolStripMenuItem_Click);
            // 
            // tailToolStripMenuItem
            // 
            this.tailToolStripMenuItem.Name = "tailToolStripMenuItem";
            this.tailToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.tailToolStripMenuItem.Text = "平铺";
            this.tailToolStripMenuItem.Click += new System.EventHandler(this.平铺ToolStripMenuItem_Click);
            // 
            // 皮肤ToolStripMenuItem
            // 
            this.皮肤ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.皮肤1ToolStripMenuItem,
            this.皮肤2ToolStripMenuItem,
            this.皮肤3ToolStripMenuItem});
            this.皮肤ToolStripMenuItem.Name = "皮肤ToolStripMenuItem";
            this.皮肤ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.皮肤ToolStripMenuItem.Text = "皮肤";
            // 
            // 皮肤1ToolStripMenuItem
            // 
            this.皮肤1ToolStripMenuItem.Name = "皮肤1ToolStripMenuItem";
            this.皮肤1ToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.皮肤1ToolStripMenuItem.Text = "皮肤1";
            this.皮肤1ToolStripMenuItem.Click += new System.EventHandler(this.皮肤1ToolStripMenuItem_Click);
            // 
            // 皮肤2ToolStripMenuItem
            // 
            this.皮肤2ToolStripMenuItem.Name = "皮肤2ToolStripMenuItem";
            this.皮肤2ToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.皮肤2ToolStripMenuItem.Text = "皮肤2";
            this.皮肤2ToolStripMenuItem.Click += new System.EventHandler(this.皮肤2ToolStripMenuItem_Click);
            // 
            // 皮肤3ToolStripMenuItem
            // 
            this.皮肤3ToolStripMenuItem.Name = "皮肤3ToolStripMenuItem";
            this.皮肤3ToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.皮肤3ToolStripMenuItem.Text = "皮肤3";
            this.皮肤3ToolStripMenuItem.Click += new System.EventHandler(this.皮肤3ToolStripMenuItem_Click);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageList.ImageSize = new System.Drawing.Size(40, 40);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList_small
            // 
            this.imageList_small.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageList_small.ImageSize = new System.Drawing.Size(15, 15);
            this.imageList_small.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // GroupBox
            // 
            this.GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox.Controls.Add(this.FriList);
            this.GroupBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBox.Location = new System.Drawing.Point(8, 138);
            this.GroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox.Size = new System.Drawing.Size(285, 440);
            this.GroupBox.TabIndex = 14;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "好友列表";
            // 
            // FriList
            // 
            this.FriList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FriList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FriList.ContextMenuStrip = this.MenuStrip_FriDisplay;
            this.FriList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FriList.LargeImageList = this.imageList;
            this.FriList.Location = new System.Drawing.Point(2, 22);
            this.FriList.Margin = new System.Windows.Forms.Padding(2);
            this.FriList.Name = "FriList";
            this.FriList.Size = new System.Drawing.Size(281, 416);
            this.FriList.SmallImageList = this.imageList_small;
            this.FriList.TabIndex = 14;
            this.FriList.TileSize = new System.Drawing.Size(200, 55);
            this.FriList.UseCompatibleStateImageBehavior = false;
            this.FriList.View = System.Windows.Forms.View.Tile;
            this.FriList.DoubleClick += new System.EventHandler(this.FriList_DoubleClick);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Location = new System.Drawing.Point(175, 676);
            this.Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(116, 32);
            this.Exit.TabIndex = 15;
            this.Exit.Text = "退出";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // TimerForCheckConn
            // 
            this.TimerForCheckConn.Tick += new System.EventHandler(this.TimerForCheckConn_Tick);
            // 
            // OnlineState
            // 
            this.OnlineState.AutoSize = true;
            this.OnlineState.BackColor = System.Drawing.Color.Transparent;
            this.OnlineState.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.OnlineState.Location = new System.Drawing.Point(60, 31);
            this.OnlineState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OnlineState.Name = "OnlineState";
            this.OnlineState.Size = new System.Drawing.Size(44, 23);
            this.OnlineState.TabIndex = 16;
            this.OnlineState.Text = "离线";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SeekMe.Properties.Resources.button2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(8, 634);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 32);
            this.button1.TabIndex = 17;
            this.button1.Text = "开启公共聊天室";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::SeekMe.Properties.Resources.button2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(175, 634);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 32);
            this.button2.TabIndex = 18;
            this.button2.Text = "开启消息盒子";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Friends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::SeekMe.Properties.Resources.好友列表背景1;
            this.ClientSize = new System.Drawing.Size(302, 720);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OnlineState);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.SetSelfInfo);
            this.Controls.Add(this.AddFriend);
            this.Controls.Add(this.PassWordSet);
            this.Controls.Add(this.Set);
            this.Controls.Add(this.welcome_label);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 720);
            this.MinimumSize = new System.Drawing.Size(250, 450);
            this.Name = "Friends";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeekMe!";
            this.TransparencyKey = System.Drawing.SystemColors.GradientInactiveCaption;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Friends_FormClosing);
            this.Load += new System.EventHandler(this.Friends_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Friends_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Friends_MouseMove);
            this.NotifyMenu.ResumeLayout(false);
            this.MenuStrip_FriDisplay.ResumeLayout(false);
            this.GroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip NotifyMenu;
        private System.Windows.Forms.ToolStripMenuItem 打开SeekMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人资料修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 好友管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 密码修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 服务器IP修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 综合设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Button Set;
        private System.Windows.Forms.Button PassWordSet;
        private System.Windows.Forms.Button AddFriend;
        private System.Windows.Forms.Button SetSelfInfo;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ContextMenuStrip MenuStrip_FriDisplay;
        private System.Windows.Forms.ToolStripMenuItem 好友显示方式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大图标ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小图标ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tailToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList_small;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.ListView FriList;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ToolStripMenuItem 皮肤ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 皮肤1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 皮肤2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 皮肤3ToolStripMenuItem;
        private System.Windows.Forms.Timer TimerForCheckConn;
        private System.Windows.Forms.Label OnlineState;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}