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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f= new Form2(textBox1.Text);
            //隐藏，但后台还在   需要在任务管理器中结束进程
            this.Visible= false;
            f.ShowDialog();
        }
    }
}
