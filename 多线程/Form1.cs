using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 多线程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //在一个进程中，可以执行多个任务
        private void Form1_Load(object sender, EventArgs e)
        {
            //控制线程的基础类  Thread
            Thread Tr;

        }
        //创建线程  每个任务就是一个线程  true开启 false关闭
        static ManualResetEvent Mr1 = new ManualResetEvent(true);
        static ManualResetEvent Mr2 = new ManualResetEvent(true);
        static ManualResetEvent Mr3 = new ManualResetEvent(true);

        private void button7_Click(object sender, EventArgs e)
        {
            //将需要处理的数据和线程 装箱
            object[] obj1 = new object[2] { label1, Mr1 };
            object[] obj2 = new object[2] { label2, Mr2 };
            object[] obj3 = new object[2] { label3, Mr3 };
            //将线程 任务添加到电脑后台的连接池中，只能传入两个参数（1.要执行的任务2.任务的执行内容）
            //调用      方法（函数名，传入的参数）
            ThreadPool.QueueUserWorkItem(addNum, obj1);
            ThreadPool.QueueUserWorkItem(addNum, obj2);
            ThreadPool.QueueUserWorkItem(addNum, obj3);

        }
        //封装一个方法  其中是线程要执行的任务
        private void addNum(object obj)
        {

            //任务重复执行（while） 不使用定时器
            while (true)
            {
                //将传入的obj对象转为object对象数组
                object[] Object = (object[])obj;
                //object[0]--label1
                //object[2]--Mr1
                //拆箱操作  将label从obj中拿取出来
                System.Windows.Forms.Label label =(System.Windows.Forms.Label)Object[0];
                //label显示数值加1
                label.Text=(Convert.ToInt32(label.Text)+1).ToString();
                //线程拆箱操作
                ManualResetEvent M=(ManualResetEvent)Object[1];
                //等待一秒在执行
                M.WaitOne();
                Thread.Sleep(1000);



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //线程暂停方法      reset阻止   set开始
            Mr1.Reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mr2.Reset();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mr3.Reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //继续事件     reset阻止   set开始
            Mr1.Set();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mr2.Set();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Mr3.Set();
        }
    }
}
