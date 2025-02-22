using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 打字练习案例
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         正确数量
        错误数量
        正确率
        输入框  用户输入完成后，要进行判断
         */
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //正确数量
        int Correct = 0;
        //错误数量
        int Error = 0;
        //键盘按下抬起事件
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //弹出内容显示框 MessageBox.Show(e.KeyChar.ToString());  
            //e.keyChar获取当前用户输入的内容字符

            //与显示输入文本进行对比（获取到输入文本的内容）
            //将名称通过name属性修改为其他  通过修改后的名称获取到当前组件
            string a, b;
            //不区分大小写 ToUpper(),ToString()转换数据类型为字符串类型
            a=e.KeyChar.ToString().ToUpper();
            b=ShowText.Text.ToUpper();
            //判断后增加正确数量和错误数量
            if (a==b)
            {
                Correct++;
                //页面上数据发生修改
                label2.Text = Correct.ToString();
            }
            else
            {
                Error++;
                label4.Text = Error.ToString();
            }
           
            

            //并修改正确率
            label6.Text = ((double)Correct/(double)(Correct+Error)*100).ToString("f2")+"%";
            //将用户输入的文本进行删除 否则会显示上次输入的内容
            textBox1.Text = "";
            //修改显示文本 让用户输入其他文本进行对比  A-》随机字母(Ascll字母）
            Random random = new Random();
            ShowText.Text=((char)random.Next(65,91)).ToString();

        }
    }
}
