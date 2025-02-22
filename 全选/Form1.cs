using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 全选
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] ArrayList = { "胡萝卜", "鱼香肉丝", "红烧鱼","红烧肉","扣肉" };
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ArrayList.Length; i++)
            {
                //实例化复选框控件
                CheckBox Che=new CheckBox();
                
                //默认在同一位置显示，修改y轴高度
                Che.Location = new Point(10,i*25);
                //对复选框赋值
                Che.Text = ArrayList[i];
                //添加到指定容器内，指定控件容器Controls,Add()
                Box.Controls.Add(Che);
            }
        }


        /*
        1.选中所有菜品后，全选才会选中
        2.当点击全选时，如果是选中，则所有菜品选中。  否则所有菜品取消

        //技术点：点击事件或者CheckedChanged  
                  Contorls
                  for循环
                  属性 属性值
                  
         */
        

        private void checkBox5_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox1.Checked = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
                checkBox4.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //checked选中状态值 返回布尔类型
            //MessageBox.Show(checkBox1.Checked.ToString());
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked)
            {
                checkBox5.Checked = true;
            }
            else
            {
                checkBox5.Checked = false;
            }
        }

        private void AllcheckBox_Click(object sender, EventArgs e)
        {
            /*点击全选，所有小的复选框 选中状态和全选状态是相同的 */
            for(int i = 0; i < Box.Controls.Count; i++)
            {
                //che表示上方的复选框
                CheckBox che =(CheckBox)Box.Controls[i];
                che.Checked=AllcheckBox.Checked;
            }   
        }
    }
}
