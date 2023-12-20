using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionProgramme
{
    internal class StaireCaseProblem
    {
        public static int WaysToClimb(int n)
        {
            if(n<=1)
            {
                return 1;
            }
            int[] ways= new int[n+1];
            ways[0] = 1;
            ways[1]=1;
            for(int i=2;i<=n; i++)
            {
                ways[i] = ways[i - 1] + ways[i - 2];
            }
            return ways[n];
        }
        public static void Main(string[] args)
        {
            int result = WaysToClimb(4);
            Console.WriteLine(result);
        }
    }
}
