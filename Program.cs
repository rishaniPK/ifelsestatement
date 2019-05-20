using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelsestatement
{
    class Program
    {
        // Viewing the student great using if else condition
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Percentage:");
            float percentage = float.Parse(Console.ReadLine());

            if (percentage >=80)
                Console.WriteLine("Grade A");
            else if (percentage >= 70)
                Console.WriteLine("Grade B");
            else if (percentage >= 60)
                Console.WriteLine("Grade C");
            else
                Console.WriteLine("Grade D");
        }
    } 
}
   