using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 登录注册
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * 登录功能：判断账号是否存在
         * 
         * 注册功能：
         */
        string[] ZhangHao_Input = {"zhangsan","" };
        string[] password_Input= {"123456","" };

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
        }
        //点击登录，展示登录页面,隐藏注册按钮
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Show();
     //       button2.Hide();
        }
        //点击注册，显示注册页面，隐藏登录按钮
        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Show();
        //    button1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < ZhangHao_Input.Length; i++)
            {
                if (textBox1.Text == ZhangHao_Input[i] && textBox2.Text == password_Input[i])
                {
                    MessageBox.Show("登录成功");
                }
                else
                {
                    MessageBox.Show("密码或账号错误，请重新登陆");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0;i < ZhangHao_Input.Length; i++)
            {
                if (textBox3.Text == ZhangHao_Input[i])
                {
                    MessageBox.Show("账号重复,请输入新的账号");
                }
                else
                {
                    i++;
                    textBox3.Text = ZhangHao_Input[i];
                    textBox4.Text = password_Input[i];
                }
            }
        }
    }
}
