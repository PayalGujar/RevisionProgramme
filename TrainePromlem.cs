using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionProgramme
{
    internal class TrainePromlem
    {
        public static int FindSeat(int capacity, int[] carriages)
        {
            int temp=0;
            int t=capacity/carriages.Length;
            for(int i=0;i<carriages.Length;i++)
            {
                double per = (double)carriages[i]/t*100;
                if(per<=50)
                {
                    temp = i;
                    break;
                }
            }
            if(temp>1)
            {
                return temp;
            }
            else
            {
                return -1;
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(FindSeat(200, new int[] { 35,23,48,21,38 }));
        }
    }
}
