using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;


namespace Code
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private static System.Timers.Timer aTimer;
        //定时函数设置
        private static void SetTimer()
        {
            aTimer = new System.Timers.Timer(2000);//(2000ms)
            aTimer.Elapsed += test_22;//被执行函数名
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        //定时执行函数
        private static void test_22(object source,ElapsedEventArgs e)
        {
            MessageBox.Show("Timer执行成功!");
            aTimer.Stop();
            aTimer.Enabled = false;
        }


        //按钮1
        private void but_1_Click(object sender, EventArgs e)
        {
            but_1.Text = "已连接";
            but_1.BackColor = Color.Green;//背景颜色

            if(but_1.Text =="已连接")
            {
                but_2.Text = "程序启动";
                but_2.BackColor = Color.DodgerBlue;
                textBox1.Text = "已连接。。。。";
            }
            //执行Set Timer函数
            SetTimer();
        }

        private void but_2_Click(object sender,EventArgs e)
        {
            //this.but_2.Text = "程序启动";
            //but_2.BackColor = Color.Green;

        }
    }
}
