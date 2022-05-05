namespace Code
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
            this.but_1 = new System.Windows.Forms.Button();
            this.but_2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_1
            // 
            this.but_1.BackColor = System.Drawing.Color.Red;
            this.but_1.Location = new System.Drawing.Point(12, 268);
            this.but_1.Name = "but_1";
            this.but_1.Size = new System.Drawing.Size(120, 60);
            this.but_1.TabIndex = 0;
            this.but_1.Text = "未连接";
            this.but_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.but_1.UseVisualStyleBackColor = false;
            this.but_1.Click += new System.EventHandler(this.but_1_Click);
            // 
            // but_2
            // 
            this.but_2.BackColor = System.Drawing.SystemColors.Control;
            this.but_2.Location = new System.Drawing.Point(350, 268);
            this.but_2.Name = "but_2";
            this.but_2.Size = new System.Drawing.Size(120, 60);
            this.but_2.TabIndex = 1;
            this.but_2.Text = "无状态";
            this.but_2.UseVisualStyleBackColor = false;
            this.but_2.Click += new System.EventHandler(this.but_2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 232);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据显示区";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 150);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(445, 76);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.but_2);
            this.Controls.Add(this.but_1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "主页面";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_1;
        private System.Windows.Forms.Button but_2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

