using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionProgramme
{
    internal class LeftRightProblem
    {
        public static string[] LeftRotation(string str)
        {
            int length=str.Length;
            string[] Rotations = new string[length];
            for(int i=0; i<length; i++)
            {
                Rotations[i]=str.Substring(i)+str.Substring(0,i);
            }
            return Rotations;
        }

        public static string[] RightRotation(string str)
        {
            int length = str.Length;
            string[] Rotations = new string[length];
            for( int i=0; i<length;i++) 
            {
                Rotations[i]=str.Substring(length-i)+str.Substring(0,length-i);
            }
            return Rotations;
        }
        public static void Main(string[] args)
        {
            string[] Rotations = LeftRotation("abcdef");
            foreach(string Rotation in Rotations)
            {
                Console.WriteLine(Rotation);
            }

            string[] Rotation2=RightRotation("abcdef");
            foreach(string Rotation in Rotation2)
            {
                Console.WriteLine(Rotation);
            }
        }

    }
}
