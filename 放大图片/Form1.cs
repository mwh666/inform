using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 放大图片
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         默认显示一张图像，鼠标他移动到不同位置，显示该图像的放大图像

        鼠标移动事件  MouseMove事件
        显示图像  包裹一个盒子，盒子作为视图窗口（100*100）  添加一个放大的图像
         移动内部图像到100*100的窗口位置
         */

        Image Img = Image.FromFile("./1.jpg");

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Img;
            //窗体大小等于图像大小
            this.Width = Img.Width;
            this.Height = Img.Height;
            //this.BackgroundImageLayout=ImageLayout.Stretch;
            //盒子会影响到鼠标事件，需要禁用
            panel1.Enabled = false;

            //放大的图像 路径和显示的图像相同
            pictureBox1.Image = Img;
            //设置放大倍数
            pictureBox1.Width = Img.Width * 3;
            pictureBox1.Height = Img.Height * 3;
            //修改显示模板，使图像填充到整个模板
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.Location = new Point(0,0);

        }

        //在移动时，窗口的图像会发生掉帧现象，需要提前打开缓存DoubleBuffered-》true\
        //
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.Location=new Point(e.Location.X-50, e.Location.Y-50);

            pictureBox1.Location=new Point(-e.Location.X*3, -e.Location.Y*3);

        }
    }
}
