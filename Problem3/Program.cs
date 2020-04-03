using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入文本！");
            string Line = Console.ReadLine();
            string text = "";
            while(!Line.Equals("END"))
            {
                text = text + Line;
                Line = Console.ReadLine();
            }
           // Console.WriteLine(text);
            string pattern = @"[<][a]([^<>]*)[>]";
            foreach(Match match in Regex.Matches(text, pattern))
            {
                //Console.WriteLine(match.Value);
                string value1 = match.Value;
                string patt1 = @"[h][r][e][f]\s*[=]\s*[""]([^>""]*?)[""]";  //双引号
                string patt2 = @"[h][r][e][f]\s*[=]\s*[']([^>'""]*?)[']";   //单引号
                string patt3 = @"[h][r][e][f]\s*[=]\s*([^>""']*)\s";        //不用引号且不是最后一个属性
                string patt4 = @"[h][r][e][f]\s*[=]\s*([^>""']*)[>]";       //不用引号且是最后一个属性
                bool ismatch1 = Regex.IsMatch(value1, patt1);
                bool ismatch2 = Regex.IsMatch(value1, patt2);
                bool ismatch3 = Regex.IsMatch(value1, patt3);
                bool ismatch4 = Regex.IsMatch(value1, patt4);
                if (ismatch1)
                {
                   // Console.WriteLine(1);
                    Match match1 = Regex.Match(value1, patt1);
                    //Console.WriteLine(match1.Value);
                    Console.WriteLine(match1.Groups[1].Value);
                }
                else if (ismatch2)
                {
                    //Console.WriteLine(2);
                    Match match1 = Regex.Match(value1, patt2);
                   // Console.WriteLine(match1.Value);
                     Console.WriteLine(match1.Groups[1].Value);
                }
                else if (ismatch3)
                {
                    //Console.WriteLine(3);
                    Match match1 = Regex.Match(value1, patt3);
                   // Console.WriteLine(match1.Value);
                    Console.WriteLine(match1.Groups[1].Value);
                }
                else if (ismatch4)
                {
                    //Console.WriteLine(4);
                    Match match1 = Regex.Match(value1, patt4);
                    // Console.WriteLine(match1.Value);
                    Console.WriteLine(match1.Groups[1].Value);
                }
            }
            Console.ReadKey();
        }
    }
}
