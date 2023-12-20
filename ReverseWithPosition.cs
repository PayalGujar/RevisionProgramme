using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionProgramme
{
    internal class ReverseWithPosition
    {
        static void Main()
        {
            Console.WriteLine(SpecialReverseString("Edabit"));        // Output: "Tibade"
            Console.WriteLine(SpecialReverseString("UPPER lower"));   // Output: "REWOL reppu"
            Console.WriteLine(SpecialReverseString("1 23 456"));       // Output: "6 54 321"
        }

        static string SpecialReverseString(string input)
        {
            char[] charArray = input.ToCharArray();

            // Reverse characters ignoring spaces
            int i = 0, j = charArray.Length - 1;
            while (i < j)
            {
                if (char.IsWhiteSpace(charArray[i]))
                    i++;
                else if (char.IsWhiteSpace(charArray[j]))
                    j--;
                else
                {
                    // Swap characters and reverse the case
                    char temp = charArray[i];
                    charArray[i] = charArray[j];
                    charArray[j] = temp;

                    charArray[i] = char.IsUpper(charArray[i]) ? char.ToLower(charArray[i]) : char.ToUpper(charArray[i]);
                    charArray[j] = char.IsUpper(charArray[j]) ? char.ToLower(charArray[j]) : char.ToUpper(charArray[j]);

                    i++;
                    j--;
                }
            }

            return new string(charArray);
        }
    }
    }
