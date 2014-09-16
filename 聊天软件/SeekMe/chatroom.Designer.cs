namespace SeekMe
{
    partial class chatroom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chatroom));
            this.OnFriList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MsgReceived = new System.Windows.Forms.RichTextBox();
            this.MsgToBeSent = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SendMsg = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // OnFriList
            // 
            this.OnFriList.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.OnFriList.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.OnFriList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OnFriList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OnFriList.FormattingEnabled = true;
            this.OnFriList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OnFriList.ItemHeight = 20;
            this.OnFriList.Location = new System.Drawing.Point(34, 86);
            this.OnFriList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OnFriList.Name = "OnFriList";
            this.OnFriList.Size = new System.Drawing.Size(266, 420);
            this.OnFriList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "当前在线用户列表";
            // 
            // MsgReceived
            // 
            this.MsgReceived.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.MsgReceived.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MsgReceived.Location = new System.Drawing.Point(325, 62);
            this.MsgReceived.Name = "MsgReceived";
            this.MsgReceived.Size = new System.Drawing.Size(622, 297);
            this.MsgReceived.TabIndex = 2;
            this.MsgReceived.Text = "";
            // 
            // MsgToBeSent
            // 
            this.MsgToBeSent.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.MsgToBeSent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MsgToBeSent.Location = new System.Drawing.Point(325, 375);
            this.MsgToBeSent.Name = "MsgToBeSent";
            this.MsgToBeSent.Size = new System.Drawing.Size(505, 131);
            this.MsgToBeSent.TabIndex = 3;
            this.MsgToBeSent.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(925, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 43);
            this.button1.TabIndex = 22;
            this.button1.Text = "×";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SeekMe.Properties.Resources.touxiang;
            this.pictureBox1.Location = new System.Drawing.Point(850, 375);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
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
            this.SendMsg.Location = new System.Drawing.Point(854, 474);
            this.SendMsg.Margin = new System.Windows.Forms.Padding(2);
            this.SendMsg.Name = "SendMsg";
            this.SendMsg.Size = new System.Drawing.Size(94, 32);
            this.SendMsg.TabIndex = 20;
            this.SendMsg.Text = "发送消息";
            this.SendMsg.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SeekMe.Properties.Resources.群聊动图;
            this.pictureBox2.Location = new System.Drawing.Point(741, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SeekMe.Properties.Resources.群聊动图;
            this.pictureBox3.Location = new System.Drawing.Point(569, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(177, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SeekMe.Properties.Resources.群聊动图;
            this.pictureBox4.Location = new System.Drawing.Point(398, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(177, 59);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SeekMe.Properties.Resources.群聊动图;
            this.pictureBox5.Location = new System.Drawing.Point(226, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(177, 59);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::SeekMe.Properties.Resources.群聊动图;
            this.pictureBox6.Location = new System.Drawing.Point(55, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(177, 59);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 27;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::SeekMe.Properties.Resources.群聊动图;
            this.pictureBox7.Location = new System.Drawing.Point(-118, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(177, 59);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 28;
            this.pictureBox7.TabStop = false;
            // 
            // chatroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(981, 544);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SendMsg);
            this.Controls.Add(this.MsgToBeSent);
            this.Controls.Add(this.MsgReceived);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OnFriList);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "chatroom";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OnFriList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox MsgReceived;
        private System.Windows.Forms.RichTextBox MsgToBeSent;
        private System.Windows.Forms.Button SendMsg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}