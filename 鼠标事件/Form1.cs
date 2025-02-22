using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 鼠标事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //鼠标移动事件
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //e.Location.X  e.Location.Y  获取到鼠标距离当前控件左上角的坐标差额
            label1.Text = $"X:{e.Location.X} Y:{e.Location.Y}";

            //鼠标移动时，其他控件在鼠标上会起到隔离作用
        }

        //鼠标按下事件
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Pink;
        }
        //鼠标抬起事件
        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            //sender发起者对象  包含调用控件的所有信息
            this.BackColor = Color.White;
            //从对象中拿出控件信息 --》拆箱
            Label la=(Label)sender;
            la.ForeColor = Color.Red;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

    }
}
