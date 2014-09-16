namespace SeekMe
{
    partial class ReceiveRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiveRequest));
            this.ReceiveRequest_label = new System.Windows.Forms.Label();
            this.ReRec_button = new System.Windows.Forms.Button();
            this.ReRef_button = new System.Windows.Forms.Button();
            this.ReReName_label = new System.Windows.Forms.Label();
            this.ReReCon_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReceiveRequest_label
            // 
            this.ReceiveRequest_label.AutoSize = true;
            this.ReceiveRequest_label.BackColor = System.Drawing.Color.Transparent;
            this.ReceiveRequest_label.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReceiveRequest_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReceiveRequest_label.Location = new System.Drawing.Point(111, 19);
            this.ReceiveRequest_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReceiveRequest_label.Name = "ReceiveRequest_label";
            this.ReceiveRequest_label.Size = new System.Drawing.Size(144, 20);
            this.ReceiveRequest_label.TabIndex = 0;
            this.ReceiveRequest_label.Text = "向您发送好友请求：";
            // 
            // ReRec_button
            // 
            this.ReRec_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReRec_button.BackgroundImage")));
            this.ReRec_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReRec_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReRec_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReRec_button.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReRec_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReRec_button.Location = new System.Drawing.Point(73, 107);
            this.ReRec_button.Margin = new System.Windows.Forms.Padding(2);
            this.ReRec_button.Name = "ReRec_button";
            this.ReRec_button.Size = new System.Drawing.Size(67, 23);
            this.ReRec_button.TabIndex = 1;
            this.ReRec_button.Text = "接受";
            this.ReRec_button.UseVisualStyleBackColor = true;
            this.ReRec_button.Click += new System.EventHandler(this.ReRec_button_Click);
            // 
            // ReRef_button
            // 
            this.ReRef_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReRef_button.BackgroundImage")));
            this.ReRef_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReRef_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReRef_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReRef_button.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReRef_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReRef_button.Location = new System.Drawing.Point(220, 107);
            this.ReRef_button.Margin = new System.Windows.Forms.Padding(2);
            this.ReRef_button.Name = "ReRef_button";
            this.ReRef_button.Size = new System.Drawing.Size(67, 23);
            this.ReRef_button.TabIndex = 2;
            this.ReRef_button.Text = "拒绝";
            this.ReRef_button.UseVisualStyleBackColor = true;
            this.ReRef_button.Click += new System.EventHandler(this.ReRef_button_Click);
            // 
            // ReReName_label
            // 
            this.ReReName_label.BackColor = System.Drawing.Color.White;
            this.ReReName_label.Location = new System.Drawing.Point(29, 19);
            this.ReReName_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReReName_label.Name = "ReReName_label";
            this.ReReName_label.Size = new System.Drawing.Size(71, 23);
            this.ReReName_label.TabIndex = 3;
            // 
            // ReReCon_label
            // 
            this.ReReCon_label.BackColor = System.Drawing.Color.White;
            this.ReReCon_label.Location = new System.Drawing.Point(30, 47);
            this.ReReCon_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReReCon_label.Name = "ReReCon_label";
            this.ReReCon_label.Size = new System.Drawing.Size(293, 52);
            this.ReReCon_label.TabIndex = 4;
            this.ReReCon_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // ReceiveRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::SeekMe.Properties.Resources.Request;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(352, 143);
            this.Controls.Add(this.ReReCon_label);
            this.Controls.Add(this.ReReName_label);
            this.Controls.Add(this.ReRef_button);
            this.Controls.Add(this.ReRec_button);
            this.Controls.Add(this.ReceiveRequest_label);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReceiveRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "接收好友信息";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ReceiveRequest_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ReceiveRequest_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReceiveRequest_label;
        private System.Windows.Forms.Button ReRec_button;
        private System.Windows.Forms.Button ReRef_button;
        private System.Windows.Forms.Label ReReName_label;
        private System.Windows.Forms.Label ReReCon_label;
    }
}