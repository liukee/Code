using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void but_1_Click(object sender, EventArgs e)
        {
            but_1.Text = "已连接";
            but_1.BackColor = Color.Green;
            if(but_1.Text =="已连接")
            {
                but_2.Text = "程序启动";
                but_2.BackColor = Color.DodgerBlue;
                textBox1.Text = "已连接。。。。";
            }
        }
        private void but_2_Click(object Test,EventArgs e)
        {
            //this.but_2.Text = "程序启动";
            //but_2.BackColor = Color.Green;

        }
    }
}
