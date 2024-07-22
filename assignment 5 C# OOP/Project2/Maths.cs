using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_5_C__OOP.Project2
{
    internal class  Maths
    {
        public double X {  get; set; }
        public double Y { get; set; }
       
        public static double Add(double X , double Y) 
        {
            return X + Y; 

        }

        public static double Subtract(double X, double Y)
        {
            return X - Y;
        }

        public static double Multiply(double X, double Y)
        {
            return X * Y;
        }

        public static double Divide(double X, double Y)
        {
            if (Y == 0)
            {
                throw new DivideByZeroException("Error Divided By Zero ");
            }
            return X / Y;
        
        }



    }
}
