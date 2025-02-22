using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 多个窗体1
{
    public partial class Form2 : Form
    {
        string str;
        public Form2(string s)
        {
            InitializeComponent();
            //将传入的参数赋值给str
            str = s;
        }


        //关闭窗口时发生
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
    
            
            //实例化form1,使打开form2时，form1窗体重新出现
            Form1 f1 = new Form1();
            f1.Visible = true;
        }

        //加载窗口时发生
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = str;
        }
    }
}
