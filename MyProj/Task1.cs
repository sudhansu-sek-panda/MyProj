using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace MyProj
{
    public class Task1
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the value");

            int number;
            number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("negetive");
            }
            else
            {
                Console.WriteLine("Zero");
            }
            
        }
    }
}