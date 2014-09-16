namespace SeekMe
{
    partial class Set
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Set));
            this.Submit = new System.Windows.Forms.Label();
            this.SubmitIP = new System.Windows.Forms.Button();
            this.IP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.AutoSize = true;
            this.Submit.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Submit.Location = new System.Drawing.Point(12, 18);
            this.Submit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(112, 23);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "登录服务器：";
            // 
            // SubmitIP
            // 
            this.SubmitIP.BackgroundImage = global::SeekMe.Properties.Resources.button2;
            this.SubmitIP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SubmitIP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitIP.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SubmitIP.ForeColor = System.Drawing.Color.White;
            this.SubmitIP.Location = new System.Drawing.Point(200, 35);
            this.SubmitIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubmitIP.Name = "SubmitIP";
            this.SubmitIP.Size = new System.Drawing.Size(36, 105);
            this.SubmitIP.TabIndex = 8;
            this.SubmitIP.Text = "确定";
            this.SubmitIP.UseVisualStyleBackColor = true;
            this.SubmitIP.Click += new System.EventHandler(this.button1_Click);
            // 
            // IP
            // 
            this.IP.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IP.Location = new System.Drawing.Point(18, 49);
            this.IP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(170, 27);
            this.IP.TabIndex = 9;
            this.IP.Text = "59.66.135.77";
            this.IP.TextChanged += new System.EventHandler(this.IP_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "端口：";
            // 
            // port
            // 
            this.port.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.port.Location = new System.Drawing.Point(18, 109);
            this.port.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(170, 27);
            this.port.TabIndex = 11;
            this.port.Text = "8082";
            // 
            // Set
            // 
            this.AcceptButton = this.SubmitIP;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(249, 154);
            this.Controls.Add(this.port);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.SubmitIP);
            this.Controls.Add(this.Submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Set";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "网络设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Submit;
        private System.Windows.Forms.Button SubmitIP;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox port;
    }
}