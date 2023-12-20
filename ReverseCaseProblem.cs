using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionProgramme
{
    internal class ReverseCaseProblem
    {
       public static string ReverseCase(string str)
        {
            char[] ch=str.ToCharArray();
            string str2 = "";
            for(int i=0; i<ch.Length; i++)
            {
                char c = ch[i];
                if(char.IsUpper(c))
                {
                    str2=str2+char.ToLower(c);
                }
                else if(char.IsLower(c))
                {
                    str2=str2+char.ToUpper(c);
                }
                else if(c==' ')
                {
                    str2 = str2 + ' ';
                }

            }
            return str2;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(ReverseCase("happy BirthDay"));
        }
    }
}
