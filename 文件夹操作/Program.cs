using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 文件夹操作
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //对于文件夹的操作  创建、删除、获取到当前文件夹下方的文件

            //获取到当前文件夹下方的文件
            /*string[] str=Directory.GetFiles(@"D:\\Microsoft Visual Studio workspace\\Solve2.10\\File文件流\\bin\\Debug");
            foreach (string str2 in str)
            {
                Console.WriteLine(str2);
            }*/
            //表示只获取某个类型
            /*string[] str = Directory.GetFiles(@"D:\\Microsoft Visual Studio workspace\\Solve2.10\\File文件流\\bin\\Debug","*.text");
            foreach (string str2 in str)
            {
                Console.WriteLine(str2);
            }*/


            //创建文件夹
            //Directory.CreateDirectory("./old");

            //删除文件夹  默认只删除当前文件夹自身，内部内容不删除
            Directory.Delete("./old");
            //如果强行删除的话，加入true参数
            Directory.Delete("./old",true);

            //文件夹的复制
            //Directory.Move("老位置文件夹地址", "新位置文件夹地址");


        }
    }
}
