using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File文件流
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //c#提供了两种对于文件的方法  
            //File属于单线程，两个操作不能同时进行，需要先注释掉一个。
            //1. File文件 用于创建、删除、修改、添加文件及内容


            //添加文件
            //有就覆盖  无就添加  默认建立到Debug下
            //手动补齐文件后缀名-》指定文件类型
            //类型不同，名称相同，不会覆盖，只会新建
            //File.Create("1.text");
            //File.Create("1.docx");
            //建立到其他文件夹下
            // File.Create("E:\\文件练习\\a.docx");


            //删除文件
            //需要注释掉File.Create("E:\\文件练习\\a.docx")创建该文件的代码
            //File.Delete("E:\\文件练习\\a.docx");


            //复制文件
            //只能对于已经存在的文件进行处理，无法创建。
            //对于已经存在的文件进行编译，创建一个新的文件接收和显示
            //File.Copy("1.docx","2.docx");


            //向文件中添加数据
            /*string str = "你真帅";
            File.AppendAllLines("1.docx",);*/
            //打开文件，拼接数据
            //File.AppendAllText("1.text", "\n你好看");
            //File.WriteAllText():创建一个文件，如果存在就覆盖，同时添加内容


            //读取文件

            //Console.WriteLine(File.ReadAllText("1.text"));
            //读取所有行
            string[] str = File.ReadAllLines("1.text");
            Console.WriteLine(str[0]);

        }
    }
}
