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
            //string a = "LIUKE";

            //建立字符串数组
            string[] user_z = { "刘科", "xiaolan", "潘广瑞", "范雯心" };
            foreach(string user in user_z)
            {
                //验证User and password
                string b = "123456";
                if (user == name && b == pass)//此处待修改！！！
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
        }

        private void but_2_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗口
        }
    }
}
