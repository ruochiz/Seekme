namespace SeekMe_Server
{
    partial class Main
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.StartListenButton = new System.Windows.Forms.Button();
            this.StopListenButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbSocketClients = new System.Windows.Forms.ListBox();
            this.tbSocketClientsNum = new System.Windows.Forms.Label();
            this.ChatroomList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(469, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Information Received";
            // 
            // StartListenButton
            // 
            this.StartListenButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartListenButton.BackgroundImage")));
            this.StartListenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartListenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartListenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartListenButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StartListenButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StartListenButton.Location = new System.Drawing.Point(28, 15);
            this.StartListenButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartListenButton.Name = "StartListenButton";
            this.StartListenButton.Size = new System.Drawing.Size(164, 29);
            this.StartListenButton.TabIndex = 1;
            this.StartListenButton.Text = "接受客户端的连接";
            this.StartListenButton.UseVisualStyleBackColor = true;
            this.StartListenButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // StopListenButton
            // 
            this.StopListenButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StopListenButton.BackgroundImage")));
            this.StopListenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StopListenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopListenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopListenButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StopListenButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StopListenButton.Location = new System.Drawing.Point(224, 15);
            this.StopListenButton.Margin = new System.Windows.Forms.Padding(4);
            this.StopListenButton.Name = "StopListenButton";
            this.StopListenButton.Size = new System.Drawing.Size(164, 29);
            this.StopListenButton.TabIndex = 2;
            this.StopListenButton.Text = "停止";
            this.StopListenButton.UseVisualStyleBackColor = true;
            this.StopListenButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(16, 75);
            this.listBox.Margin = new System.Windows.Forms.Padding(4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(596, 484);
            this.listBox.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // lbSocketClients
            // 
            this.lbSocketClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSocketClients.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSocketClients.FormattingEnabled = true;
            this.lbSocketClients.ItemHeight = 20;
            this.lbSocketClients.Location = new System.Drawing.Point(621, 75);
            this.lbSocketClients.Margin = new System.Windows.Forms.Padding(4);
            this.lbSocketClients.Name = "lbSocketClients";
            this.lbSocketClients.Size = new System.Drawing.Size(393, 244);
            this.lbSocketClients.TabIndex = 4;
            // 
            // tbSocketClientsNum
            // 
            this.tbSocketClientsNum.AutoSize = true;
            this.tbSocketClientsNum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSocketClientsNum.Location = new System.Drawing.Point(793, 21);
            this.tbSocketClientsNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbSocketClientsNum.Name = "tbSocketClientsNum";
            this.tbSocketClientsNum.Size = new System.Drawing.Size(58, 20);
            this.tbSocketClientsNum.TabIndex = 5;
            this.tbSocketClientsNum.Text = "renshu";
            // 
            // ChatroomList
            // 
            this.ChatroomList.FormattingEnabled = true;
            this.ChatroomList.ItemHeight = 15;
            this.ChatroomList.Location = new System.Drawing.Point(621, 342);
            this.ChatroomList.Margin = new System.Windows.Forms.Padding(4);
            this.ChatroomList.Name = "ChatroomList";
            this.ChatroomList.Size = new System.Drawing.Size(393, 229);
            this.ChatroomList.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1032, 600);
            this.Controls.Add(this.ChatroomList);
            this.Controls.Add(this.tbSocketClientsNum);
            this.Controls.Add(this.lbSocketClients);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.StopListenButton);
            this.Controls.Add(this.StartListenButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "SeekMe! 服务端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartListenButton;
        private System.Windows.Forms.Button StopListenButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lbSocketClients;
        private System.Windows.Forms.Label tbSocketClientsNum;
        public System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ListBox ChatroomList;
    }
}

