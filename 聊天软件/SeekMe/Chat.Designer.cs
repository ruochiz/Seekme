namespace SeekMe
{
    partial class Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.MsgReceived = new System.Windows.Forms.RichTextBox();
            this.SendMsg = new System.Windows.Forms.Button();
            this.SenderOption = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EnterToSend = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlEnterToSend = new System.Windows.Forms.ToolStripMenuItem();
            this.MsgToBeSent = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SenderOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MsgReceived
            // 
            this.MsgReceived.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MsgReceived.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.MsgReceived.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MsgReceived.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.MsgReceived.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MsgReceived.HideSelection = false;
            this.MsgReceived.Location = new System.Drawing.Point(32, 318);
            this.MsgReceived.Margin = new System.Windows.Forms.Padding(2);
            this.MsgReceived.Name = "MsgReceived";
            this.MsgReceived.Size = new System.Drawing.Size(553, 238);
            this.MsgReceived.TabIndex = 15;
            this.MsgReceived.TabStop = false;
            this.MsgReceived.Text = "";
            this.MsgReceived.TextChanged += new System.EventHandler(this.MsgReceived_TextChanged);
            // 
            // SendMsg
            // 
            this.SendMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendMsg.BackColor = System.Drawing.Color.Transparent;
            this.SendMsg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SendMsg.BackgroundImage")));
            this.SendMsg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SendMsg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendMsg.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SendMsg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SendMsg.Location = new System.Drawing.Point(491, 719);
            this.SendMsg.Margin = new System.Windows.Forms.Padding(2);
            this.SendMsg.Name = "SendMsg";
            this.SendMsg.Size = new System.Drawing.Size(94, 32);
            this.SendMsg.TabIndex = 17;
            this.SendMsg.Text = "发送消息";
            this.SendMsg.UseVisualStyleBackColor = false;
            this.SendMsg.Click += new System.EventHandler(this.SendMsg_Click);
            // 
            // SenderOption
            // 
            this.SenderOption.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SenderOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EnterToSend,
            this.CtrlEnterToSend});
            this.SenderOption.Name = "SenderOption";
            this.SenderOption.Size = new System.Drawing.Size(199, 56);
            // 
            // EnterToSend
            // 
            this.EnterToSend.Name = "EnterToSend";
            this.EnterToSend.Size = new System.Drawing.Size(198, 26);
            this.EnterToSend.Text = "按Enter发送";
            this.EnterToSend.Click += new System.EventHandler(this.按Enter发送ToolStripMenuItem_Click);
            // 
            // CtrlEnterToSend
            // 
            this.CtrlEnterToSend.Checked = true;
            this.CtrlEnterToSend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CtrlEnterToSend.Name = "CtrlEnterToSend";
            this.CtrlEnterToSend.Size = new System.Drawing.Size(198, 26);
            this.CtrlEnterToSend.Text = "按Ctrl+Enter发送";
            this.CtrlEnterToSend.Click += new System.EventHandler(this.CtrlEnterToSend_Click);
            // 
            // MsgToBeSent
            // 
            this.MsgToBeSent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MsgToBeSent.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.MsgToBeSent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MsgToBeSent.EnableAutoDragDrop = true;
            this.MsgToBeSent.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MsgToBeSent.Location = new System.Drawing.Point(32, 570);
            this.MsgToBeSent.Margin = new System.Windows.Forms.Padding(2);
            this.MsgToBeSent.MaxLength = 190;
            this.MsgToBeSent.Name = "MsgToBeSent";
            this.MsgToBeSent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MsgToBeSent.Size = new System.Drawing.Size(553, 135);
            this.MsgToBeSent.TabIndex = 16;
            this.MsgToBeSent.Text = "";
            this.MsgToBeSent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MsgToBeSent_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ContextMenuStrip = this.SenderOption;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(195, 726);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "按Ctrl+Enter发送消息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(234, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 27);
            this.label2.TabIndex = 20;
            this.label2.Text = "label2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(602, 318);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 238);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::SeekMe.Properties.Resources.button2;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(370, 719);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 32);
            this.button2.TabIndex = 24;
            this.button2.Text = "窗口抖动";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(717, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 52);
            this.button1.TabIndex = 25;
            this.button1.Text = "×";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::SeekMe.Properties.Resources.聊天背景图片;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 760);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendMsg);
            this.Controls.Add(this.MsgToBeSent);
            this.Controls.Add(this.MsgReceived);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Chat";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "聊天窗口";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Chat_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Chat_MouseMove);
            this.SenderOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendMsg;
        private System.Windows.Forms.RichTextBox MsgToBeSent;
        private System.Windows.Forms.ContextMenuStrip SenderOption;
        private System.Windows.Forms.ToolStripMenuItem EnterToSend;
        private System.Windows.Forms.ToolStripMenuItem CtrlEnterToSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.RichTextBox MsgReceived;
        private System.Windows.Forms.Button button1;

    }
}