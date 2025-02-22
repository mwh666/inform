using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 轮播图_最终
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        //图像路径数组
        string[] Src = { "./1.jpg", "./2.jpg", "./3.jpg", "./4.jpg" };
        int Index = 0;
        bool flag = true;
        private void Form1_Load(object sender, EventArgs e)
        {
            //默认显示第一张图
            pictureBox1.Image=Image.FromFile(Src[Index]);
            //添加对应的单选框
            for (int i = 0; i < Src.Length; i++)
            {
                RadioButton Ra = new RadioButton();
                //控件会相互覆盖  设置宽度 修改作用域
                Ra.Width = 15;
                //默认添加位置相同，修改x轴坐标
                Ra.Location = new Point(i*(panel1.Width/Src.Length),10);
                //添加到盒子容器
                panel1.Controls.Add(Ra);
                //第一个单选框默认选中
                if (i == 0)
                {
                    Ra.Checked = true;
                }
            }
        }
        //点击下一张，索引增加一
        private void button2_Click(object sender, EventArgs e)
        {
            
            Fun();
        }

        
        

        private void Fun()
        {

            //获取到目前选择的单选框
            RadioButton Ra=(RadioButton)panel1.Controls[Index];
            Ra.Checked = false;
            if (flag)
            {
                Index++;
                if (Index > Src.Length - 1)
                {
                    Index = 0;
                }
            }
            else
            {
                Index--;
                if (Index > Src.Length - 1)
                {
                    Index = 0;
                }
            }
            
            //图像切换
            pictureBox1.Image = Image.FromFile(Src[Index]);

            //获取到下一个选择的单选框
            RadioButton ra = (RadioButton)panel1.Controls[Index];
            Ra.Checked = true;
            
        }

        //自动切换，索引增加一
        private void timer1_Tick(object sender, EventArgs e)
        {
            flag=true;
            Fun();
        }
        //点击上一张，索引减一
        private void button1_Click_1(object sender, EventArgs e)
        {
            flag = false;
            timer1.Enabled = false;
            timer1.Enabled = true;
            Fun();
        }
    }
}
