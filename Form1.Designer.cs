﻿namespace portScan4zyc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.RichTextBox();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.tbSPort = new System.Windows.Forms.TextBox();
            this.tbEPort = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "主机地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "起始端口";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "终止端口";
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(131, 249);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(292, 40);
            this.pb.TabIndex = 3;
            this.pb.Click += new System.EventHandler(this.pb_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "扫描";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(437, 0);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(351, 448);
            this.show.TabIndex = 5;
            this.show.Text = "";
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(152, 44);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(271, 28);
            this.tbHost.TabIndex = 6;
            // 
            // tbSPort
            // 
            this.tbSPort.Location = new System.Drawing.Point(152, 103);
            this.tbSPort.Name = "tbSPort";
            this.tbSPort.Size = new System.Drawing.Size(271, 28);
            this.tbSPort.TabIndex = 7;
            // 
            // tbEPort
            // 
            this.tbEPort.Location = new System.Drawing.Point(152, 171);
            this.tbEPort.Name = "tbEPort";
            this.tbEPort.Size = new System.Drawing.Size(271, 28);
            this.tbEPort.TabIndex = 8;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(36, 259);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(80, 18);
            this.lb.TabIndex = 9;
            this.lb.Text = "扫描进度";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.tbEPort);
            this.Controls.Add(this.tbSPort);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.show);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "zyc的端口扫描器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox show;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.TextBox tbSPort;
        private System.Windows.Forms.TextBox tbEPort;
        private System.Windows.Forms.Label lb;
    }
}

