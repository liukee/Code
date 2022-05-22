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
            //建立字符串数组
            //string[] user_z = { "刘科", "xiaolan", "潘广瑞", "范雯心" };


            //获取内容
            string name = User.Text;
            string pass = passBox2.Text;

            //验证User and password暂时不使用数据库
            string user_u = "LIUKE";
            string pass_w = "123456";
            if (user_u == name && pass_w == pass)//此处待修改！！！
             {
                MessageBox.Show("登录成功");
                Form form_index = new Form1();//创建实列
                //form_index.Show();//登录窗口可以使用
                this.Hide();//隐藏Login窗口
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
