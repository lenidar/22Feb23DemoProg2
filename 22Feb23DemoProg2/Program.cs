using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22Feb23DemoProg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Capital letters 65 - 90
            // Lowercase letters 97 - 122

            string uInput = "";
            string uOutput = "";

            Console.WriteLine("Please input a string : ");
            uInput = Console.ReadLine();

            // Goal, swap letters from upper case to lower case
            // and vice versa


            //-- Section A ------------
            for (int x = 0; x < uInput.Length; x++)
            {
                if ((int)uInput[x] >= 65 && (int)uInput[x] <= 90)
                {
                    uOutput += (char)((int)uInput[x] + 32) + "";
                }
                else if ((int)uInput[x] >= 97 && (int)uInput[x] <= 122)
                {
                    uOutput += (char)((int)uInput[x] - 32) + "";
                }
                else
                {
                    uOutput += uInput[x] + "";
                }
            }
            //------------------


            Console.WriteLine(uOutput);
            Console.ReadKey();

            uOutput = "";

            //-- Section B ------------
            for (int x = 0; x < uInput.Length;x++) 
            {
                int temp = (int)uInput[x];
                if (temp >= 65 && temp <= 90)
                {
                    temp += 32;
                    uOutput += (char)(temp);
                }
                else if(temp >= 97 && temp <= 122)
                {
                    temp -= 32;
                    uOutput += (char)(temp);
                }
                else
                {
                    uOutput += (char)(temp);
                }
            }
            //------------------

            Console.WriteLine(uOutput);
            Console.ReadKey();

        }
    }
}
