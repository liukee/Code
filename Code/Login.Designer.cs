namespace Code
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.passBox2 = new System.Windows.Forms.TextBox();
            this.but_1 = new System.Windows.Forms.Button();
            this.but_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test_Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "User:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "password:";
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(297, 102);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(148, 25);
            this.User.TabIndex = 3;
            // 
            // passBox2
            // 
            this.passBox2.Location = new System.Drawing.Point(297, 165);
            this.passBox2.Name = "passBox2";
            this.passBox2.Size = new System.Drawing.Size(148, 25);
            this.passBox2.TabIndex = 4;
            // 
            // but_1
            // 
            this.but_1.Location = new System.Drawing.Point(68, 256);
            this.but_1.Name = "but_1";
            this.but_1.Size = new System.Drawing.Size(124, 42);
            this.but_1.TabIndex = 5;
            this.but_1.Text = "登录";
            this.but_1.UseVisualStyleBackColor = true;
            this.but_1.Click += new System.EventHandler(this.but_1_Click);
            // 
            // but_2
            // 
            this.but_2.Location = new System.Drawing.Point(468, 256);
            this.but_2.Name = "but_2";
            this.but_2.Size = new System.Drawing.Size(124, 42);
            this.but_2.TabIndex = 6;
            this.but_2.Text = "关闭";
            this.but_2.UseVisualStyleBackColor = true;
            this.but_2.Click += new System.EventHandler(this.but_2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(637, 335);
            this.Controls.Add(this.but_2);
            this.Controls.Add(this.but_1);
            this.Controls.Add(this.passBox2);
            this.Controls.Add(this.User);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox passBox2;
        private System.Windows.Forms.Button but_1;
        private System.Windows.Forms.Button but_2;
    }
}