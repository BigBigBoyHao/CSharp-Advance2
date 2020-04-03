using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = null;
            Console.WriteLine("请输入要进行计算的文本内容：");
            content = Console.ReadLine().ToLower();
            string goal = null;
            Console.WriteLine("请输入要计算出现次数的字符串：");
            goal = Console.ReadLine().ToLower();
            int count = 0;
            for (int i = 0; content.IndexOf(goal) != -1; i++)
            {
                count++;
                content = content.Substring(content.IndexOf(goal) + 1);
            }
            Console.Write(count);
            Console.ReadKey();
        }
    }
}
