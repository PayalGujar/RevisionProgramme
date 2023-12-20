using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionProgramme
{
    internal class SatisfyRelationshipProblem
    {
        public static int SatisfyRelationship(int num)
        {
            int temp=num;
            int output = 0;
            int rev = 0;
            while(num!=0)
            {
                int rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }
            if(rev<temp)
            {
                output=temp-rev;
            }
            else
            {
                output = 0;
            }
            return output;

        }
        public static void Main(string[] args)
        {
            Console.WriteLine(SatisfyRelationship(832));
        }
    }
}
