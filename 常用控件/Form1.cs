using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 列表选项框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 视图ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //定时器事件，单位毫秒
            //每0.1秒自动执行一次,x轴向左移动10，y轴不变
            pictureBox1.Location = new Point(pictureBox1.Location.X-10,pictureBox1.Location.Y);
        }

        //窗体加载完毕后，默认执行的事件
        private void Form1_Load(object sender, EventArgs e)
        {
            //修改图像路径 控件名.属性名=属性值
            //图像替换需要接收的是图像类型
            //Image类
            pictureBox1.Image = Image.FromFile("./111.jpg");
            
        }
    }
}
