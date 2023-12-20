using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionProgramme
{
    internal class ReverseOddStringProblem
    {
        public static string ReverseOdd(string str)
        {
            string[] str2 = str.Split(' ');
            string[] str3 = new string[str2.Length];
            string remaining = " ";
            string strnew;
            for(int i=0;i<str2.Length; i++)
            {
                strnew = "";
                if (str2[i].Length % 2== 0 )
                {
                    remaining = remaining + str2[i];
                    continue;
                }
                else
                {
                    char[] ch = str2[i].ToCharArray();
                    for(int j=ch.Length-1;j>=0;j--)
                    {
                        strnew += ch[j];
                    }

                }
                str3[i] = str3[i] + strnew;
            }
            return string.Concat(string.Join(" ",str3), remaining);
            
        }
        public static void Main(string[] args)
        {
            string str = ReverseOdd("One Two Three Four");
            Console.WriteLine(str);
        }
    }
}
