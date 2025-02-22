using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform基础
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //按钮2的事件 控件名_Click
        private void button2_Click(object sender, EventArgs e)
        {
            //实现将button2中的内容替换
            button2.Text="OK";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //点击美羊羊时，将第二个按钮文本变成沸羊羊
            button2.Text = "沸羊羊";
            //将第二个按钮文本颜色修改为绿色
            //在C#中，颜色定义为一个类，使用前必须添加  Color.颜色
            button2.ForeColor= Color.Green;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
