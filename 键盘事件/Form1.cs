using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 键盘事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //KeyDown和KeyUp不区分功能键
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Down按下 ，能够多次触发
            //MessageBox.Show("你好");
            //KeyValue返回AscII码
            label1.Text=e.KeyCode.ToString();
            if (e.KeyCode.ToString() == "F1")
            {
                //this表示为当前窗体  Close()表示关闭
                this.Close();
            }
        }

        //功能键无法触发F1-F12等，只有字母数字才能触发
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString());
        }
    }
}
