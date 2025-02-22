using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 进程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //一个程序，最少有一个进程，而一个进程可以有多个线程（异步）。ps:多人聊天

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*//获取计算机的进程  Process是一个类，调用方法是Process.方法名
            Process[] pro = Process.GetProcesses();
            //遍历进程
            foreach (Process proc in pro)
            {
                //结束所有进程
                proc.Kill();
            }*/

            //start打开进程   路径为绝对路径
            Process.Start("C:/Users/Public/Desktop/CPUID CPU-Z.lnk");


            
        }
    }
}
