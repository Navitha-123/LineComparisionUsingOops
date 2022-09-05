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
            Console.WriteLine("choose option 1.Lengthoftwo \t 2.Equal \t 3.Compare");
            Console.WriteLine("Enter the number");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    LengthTwoLines.CalculateTwoLineLength();
                    break;
                case 2:
                    LengthEqual.LengthEqualCheck();
                    break;
                case 3:
                    CompareLength.TwoLengthsCompare();
                    break;
                default:
                    Console.WriteLine("Enter wwrong choice");
                    break;
                    Console.ReadLine();
            }
        }
    }
}
