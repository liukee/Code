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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void but_1_Click(object sender, EventArgs e)
        {
            //暂时不使用数据库
            string name = User.Text;
            string pass = passBox2.Text;
            string a = "刘科";
            string b = "123456";

            //验证User and password
            if(a == name || b ==pass)
            {
                MessageBox.Show("登录成功");
                Form form_index = new Form1();
                //form_index.Show();//登录窗口可以使用
                form_index.ShowDialog();
            }
            else
            {
                MessageBox.Show("输入错误");
            }

        }

        private void but_2_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗口
        }
    }
}
