namespace SeekMe
{
    partial class SendRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendRequest));
            this.SendRequest_label = new System.Windows.Forms.Label();
            this.SendRequest_button = new System.Windows.Forms.Button();
            this.SendRequest_richtextbox = new System.Windows.Forms.RichTextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SendRequest_label
            // 
            this.SendRequest_label.AutoSize = true;
            this.SendRequest_label.BackColor = System.Drawing.Color.Transparent;
            this.SendRequest_label.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SendRequest_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SendRequest_label.Location = new System.Drawing.Point(21, 46);
            this.SendRequest_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SendRequest_label.Name = "SendRequest_label";
            this.SendRequest_label.Size = new System.Drawing.Size(135, 20);
            this.SendRequest_label.TabIndex = 0;
            this.SendRequest_label.Text = "请输入好友验证信息";
            // 
            // SendRequest_button
            // 
            this.SendRequest_button.BackColor = System.Drawing.Color.Transparent;
            this.SendRequest_button.BackgroundImage = global::SeekMe.Properties.Resources.button2;
            this.SendRequest_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SendRequest_button.CausesValidation = false;
            this.SendRequest_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendRequest_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SendRequest_button.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SendRequest_button.ForeColor = System.Drawing.Color.Transparent;
            this.SendRequest_button.Location = new System.Drawing.Point(151, 146);
            this.SendRequest_button.Margin = new System.Windows.Forms.Padding(0);
            this.SendRequest_button.Name = "SendRequest_button";
            this.SendRequest_button.Size = new System.Drawing.Size(50, 23);
            this.SendRequest_button.TabIndex = 2;
            this.SendRequest_button.Text = "发送";
            this.SendRequest_button.UseVisualStyleBackColor = false;
            this.SendRequest_button.Click += new System.EventHandler(this.SendRequest_button_Click);
            // 
            // SendRequest_richtextbox
            // 
            this.SendRequest_richtextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SendRequest_richtextbox.Location = new System.Drawing.Point(28, 73);
            this.SendRequest_richtextbox.Margin = new System.Windows.Forms.Padding(2);
            this.SendRequest_richtextbox.Name = "SendRequest_richtextbox";
            this.SendRequest_richtextbox.Size = new System.Drawing.Size(300, 67);
            this.SendRequest_richtextbox.TabIndex = 3;
            this.SendRequest_richtextbox.Text = "";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label1.Location = new System.Drawing.Point(95, 7);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(172, 27);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "发送好友验证信息";
            // 
            // SendRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::SeekMe.Properties.Resources.Request;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(352, 177);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.SendRequest_richtextbox);
            this.Controls.Add(this.SendRequest_button);
            this.Controls.Add(this.SendRequest_label);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SendRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "发送好友申请";
            this.Load += new System.EventHandler(this.SendRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SendRequest_label;
        private System.Windows.Forms.Button SendRequest_button;
        private System.Windows.Forms.RichTextBox SendRequest_richtextbox;
        private System.Windows.Forms.Label Label1;
    }
}