# 仅供上传者Test！！！

- ### Login为登录窗口
  ```csharp
   if (user == name && b == pass)//此处待修改！！！暂时不使用SQL
                  {
                      MessageBox.Show("登录成功");
                      Form form_index = new Form1();//创建实列
                      //form_index.Show();登录窗口可以使用
                      this.Hide();//隐藏Login窗口
                      form_index.ShowDialog();
                  }
                  else
                  {
                      MessageBox.Show("输入错误");
                  }
  ```

***

- ### Form1为主窗口
  ```csharp
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
  ```
