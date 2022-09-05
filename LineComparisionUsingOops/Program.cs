using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionUsingOops
{
    internal class Program
    {
       public  static void Main(string[] args)
        {
            Console.WriteLine("choose option 1.Lengthoftwo \t 2.Equal");
            Console.WriteLine("Enter the number");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    LengthTwoLines.CalculateTwoLineLength();
                    break;
                case 2:
                    EqualLength.LengthEqualCheck();
                    break;
                    Console.ReadLine();
            }
        }
    }
}
