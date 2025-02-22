using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 移动轮播_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //获取debug文件夹下的后缀为jpg文件的名称
            string[] SrccArr=Directory.GetFiles("./images","*.jpg");
            //显示文件路径
            //MessageBox.Show(SrccArr[0]);

            int index = 0;//记录图像的索引
            foreach (string Srcc in SrccArr)
            {
                PictureBox pic = new PictureBox();

                pic.Image = Image.FromFile(Srcc);
                //设置图像的大小
                pic.Width=this.Width;
                pic.Height=this.Height;
                //设置图像的坐标
                pic.Location=new Point(this.Width*index,0);
                this.Controls.Add(pic);
                index++;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                //获取到图像的坐标
                int x=this.Controls[i].Location.X;
                x -= 5;
                //更新图像的坐标
                //如果图像向左移出窗体   则在最后一张图像的后方显示
                if (x < -this.Width)
                {
                    x=(this.Controls.Count-1)*this.Width;
                }
                this.Controls[i].Location = new Point(x,0);

            }
        }
    }
}
