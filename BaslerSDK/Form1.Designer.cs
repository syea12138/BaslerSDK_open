namespace BaslerSDK
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_Oneshot = new System.Windows.Forms.Button();
            this.button_keepShot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 339);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(354, 13);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(118, 35);
            this.button_stop.TabIndex = 1;
            this.button_stop.Text = "button_stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_Oneshot
            // 
            this.button_Oneshot.Location = new System.Drawing.Point(354, 54);
            this.button_Oneshot.Name = "button_Oneshot";
            this.button_Oneshot.Size = new System.Drawing.Size(118, 35);
            this.button_Oneshot.TabIndex = 2;
            this.button_Oneshot.Text = "button_Oneshot";
            this.button_Oneshot.UseVisualStyleBackColor = true;
            this.button_Oneshot.Click += new System.EventHandler(this.button_Oneshot_Click);
            // 
            // button_keepShot
            // 
            this.button_keepShot.Location = new System.Drawing.Point(354, 96);
            this.button_keepShot.Name = "button_keepShot";
            this.button_keepShot.Size = new System.Drawing.Size(118, 40);
            this.button_keepShot.TabIndex = 3;
            this.button_keepShot.Text = "button_keepShot";
            this.button_keepShot.UseVisualStyleBackColor = true;
            this.button_keepShot.Click += new System.EventHandler(this.button_keepShot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_keepShot);
            this.Controls.Add(this.button_Oneshot);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_Oneshot;
        private System.Windows.Forms.Button button_keepShot;
    }
}

