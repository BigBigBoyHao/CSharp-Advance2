using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入文本内容！");
            string text = Console.ReadLine();
            string pattern = @"[a-zA-Z0-9]+([-_.]?[a-zA-Z0-9]+)*@[a-zA-Z]+([-]?[a-zA-Z]+)+(\.[a-zA-Z]+([-]?[a-zA-Z]+)+)+";
           
            foreach (Match match in Regex.Matches(text, pattern))
                Console.WriteLine(match.Value);
            Console.ReadKey();


        }
    }
}
