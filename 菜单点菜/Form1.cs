using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 菜单点菜
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //键值对  字典，存储菜品信息 
        Dictionary<string, string> caidan = new Dictionary<string, string>()
            {
                {"鱼香肉丝","38元" },
                {"麻婆豆腐","18元" },
                {"啤酒鸭","25元" },
                {"毛血旺","58元" },
                {"凉菜","13元" }
            };
        //复选框的索引
        int index = 0;
        private void Form1_Load(object sender, EventArgs e)
        {   
           //遍历菜品名称 
            foreach(var item in caidan.Keys)
            {            
                CheckBox Che=new CheckBox();
                Che.Text = item;
                //设置不同checkbox的不同位置
                Che.Width = 130;
                Che.Location = new Point(10, index*25 );
                //添加到panel1中
                panel1.Controls.Add(Che);
                //Y轴自增
                index++;
            }
            index = 0;
            //遍历菜品价格
            foreach (var item in caidan.Values)
            {
                Label La =new Label();
                La.Text = item;
                //设置La的位置
                La.Location = new Point(150,6+index*25);
                panel1.Controls.Add(La);
                index++;
            }
        }

        //全选事件
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //var万能声明(声明之后禁止修改）  根据所给予的值  自动变为所对应的类型
            //声明的时候必须赋值，不然会报错
            foreach (var item in panel1.Controls)
            {
                //判断item的类型是否为Checkbox
                if (item is CheckBox)
                {
                    //
                    CheckBox it = (CheckBox)item;
                    //令菜品的复选框状态与名为全选的复选框状态相同
                    it.Checked = checkBox1.Checked;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //只取出复选框（复选框先写入panel1,所以复选框的索引为0-4）
            for (int i = 0; i < panel1.Controls.Count/2; i++)
            {
                if (((CheckBox)panel1.Controls[i]).Checked)
                {
                    //判断panel2里是否已经包含菜品，包含的话菜品数量+1,
                    //存在菜品的话，flag=true
                    bool flag = true;
                    for(int j = 0; j < panel2.Controls.Count; j+=3)
                    {
                        if ((((CheckBox)panel2.Controls[j]).Text)== ((CheckBox)panel1.Controls[i]).Text)
                        {
                            ((Label)panel2.Controls[j + 1]).Text = (Convert.ToInt32(((Label)panel2.Controls[j + 1]).Text)+1).ToString();
                            flag = false;
                        }
                    }
                    //不存在菜品，添加
                    if (flag)
                    {
                        CheckBox C=new CheckBox();
                        Label labelNum = new Label();
                        Label labelMoney= new Label();
                        C.Text = ((CheckBox)panel1.Controls[i]).Text;
                        //规定C的作用域
                        C.Width = 100;
                        C.Location = new Point(10, panel2.Controls.Count / 3 * 25);
                        labelNum.Text ="1";
                        labelNum.Width = 25;
                        labelNum.Location = new Point(110, panel2.Controls.Count / 3 * 25+5);
                        labelMoney.Text= ((Label)panel1.Controls[i+panel1.Controls.Count/2]).Text;
                        labelMoney.Location = new Point(160, panel2.Controls.Count / 3 * 25+5);
                        panel2.Controls.Add(C);
                        panel2.Controls.Add(labelNum);
                        panel2.Controls.Add(labelMoney);
                    }
                    //取消菜品
                    ((CheckBox)panel1.Controls[i]).Checked=false;
                }
                
            }
        }


        //取消菜品事件
        private void button2_Click(object sender, EventArgs e)
        {
            //判断是否选中
            for (int i = 0; i < panel2.Controls.Count; i+=3)
            {
                if (((CheckBox)panel2.Controls[i]).Checked)
                {
                    //判断数量是否为1
                    if (((Label)panel2.Controls[i + 1]).Text == "1")
                    {
                        //删除控件后，索引自动补充
                        panel2.Controls.RemoveAt(i);
                        panel2.Controls.RemoveAt(i);
                        panel2.Controls.RemoveAt(i);
                        for (int L = i; L < panel2.Controls.Count; L += 3)
                        {
                            ((CheckBox)panel2.Controls[L]).Location = new Point(((CheckBox)panel2.Controls[L]).Location.X,
                                ((CheckBox)panel2.Controls[L]).Location.Y-25);

                            ((Label)panel2.Controls[L+1]).Location = new Point(((Label)panel2.Controls[L+1]).Location.X,
                                ((Label)panel2.Controls[L+1]).Location.Y - 25);

                            ((Label)panel2.Controls[L + 2]).Location = new Point(((Label)panel2.Controls[L + 2]).Location.X,
                                ((Label)panel2.Controls[L + 2]).Location.Y - 25);
                        }
                    }
                    ((Label)panel2.Controls[i+1]).Text= (Convert.ToInt32(((Label)panel2.Controls[i + 1]).Text) - 1).ToString();
                }
            }
        }
        //创建线程
        static ManualResetEvent M=new ManualResetEvent(true);
        //记录线程执行时间
        int AllMoney = 0;

        //结账
        private void button3_Click(object sender, EventArgs e)
        {
            int money = 0;
            for (int i = 1; i <= panel2.Controls.Count; i += 3)
            {
                //split函数里面的参数用单引号
                string[] str=((Label)panel2.Controls[i + 1]).Text.Split('元');
                money = money+Convert.ToInt32(((Label)panel2.Controls[i]).Text) * Convert.ToInt32(str[0]);
            }
            CountMoney.Text=money.ToString()+"元";
            object Obj=new object[4] {AllMoney,money,CountMoney,M };


            //放到线程池中
            ThreadPool.QueueUserWorkItem(fun,Obj);
        }

        private void fun(object state)
        {
            object[] Obj = (object[])state;
            int TimeNum = (int)Obj[0];
            //进行数字增加  线程阻塞
            //判断是否到达60,120,180  修改显示内容
            while (true)
            {

                //拆箱操作
                //将对象转换为数组
                
                int money=(int)Obj[1];
                Label label=(Label)Obj[2];
                TimeNum++;
                if (TimeNum == 6)
                {
                    CountMoney.Text=(money*0.9).ToString("F1");
                }else if (TimeNum == 120)
                {
                    CountMoney.Text = (money-58).ToString("F1");
                }else if(TimeNum == 180)
                {
                    CountMoney.Text = (money*0.75).ToString("F1");
                }
                ManualResetEvent M=(ManualResetEvent)Obj[3];
                M.WaitOne();//阻塞
                Thread.Sleep(1000);


            }
        }
    }
}
