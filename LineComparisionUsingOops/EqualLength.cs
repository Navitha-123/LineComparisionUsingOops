﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionUsingOops
{
    internal class EqualLength
    {
       public  static void LengthEqualCheck()
        {
            Console.WriteLine("Enter the value of x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of p1");
            int p1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of q1");
            int q1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of p2");
            int p2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of q2");
            int q2 = Convert.ToInt32(Console.ReadLine());
            double length1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double length2 = Math.Sqrt((p2 - p1) * (p2 - p1) + (q2 - q1) * (q2 - q1));
            if (length1.Equals(length2))
            {
                Console.WriteLine("Both lines are equals");
               
            }
            else
            {
                Console.WriteLine("Both lines are not equals");
               
            }
        }
        
       
    }
       
           



    
}
