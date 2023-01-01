using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Code
    {
        static void Main(string[] args)
        {
            int realNum;
            double sum = 0, counter = 1;
            bool num;
            string ans;
            do
            {
                //We use a boolean besides of "TryCatch" to highlight some bugs and give solutions, so the program
                //can keep operating 
                Console.Write("Enter {0}° grade: ", counter);
                num = int.TryParse(ans=Console.ReadLine(), out realNum);
                if (num == false && ans != "end")
                {
                    Console.WriteLine("Please enter the right format");
                    Console.ReadKey(); Console.Clear();
                    continue;
                }
                else if (num == true)
                {
                    //In OUR program there is a limit regarding grades (0 to 10) 
                    if (realNum>=0 && realNum<=10)
                    {
                        sum += realNum;
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number from 0 to 10");
                        Console.ReadKey();Console.Clear();
                        continue;
                    }
                }
                counter++;
            } while (ans != "end");
            Console.WriteLine("Average --> {0}/{1} --> {2}", sum, counter-2, sum/(counter-2));
        }
    }
}
