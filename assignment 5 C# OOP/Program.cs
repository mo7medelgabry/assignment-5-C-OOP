using assignment_5_C__OOP.Project1;
using assignment_5_C__OOP.Project2;
using assignment_5_C__OOP.Project3;
using System;

namespace assignment_5_C__OOP
{
    internal class Program 

    {
        public static Point3D enterPoint()
        {
            string input = Console.ReadLine();
            string[] points = input.Split(' ');

            if (points.Length < 3)
            {
                Console.WriteLine("Invalid");
                return enterPoint();
            }

            int a, b, c;
            if (int.TryParse(points[0], out a) && int.TryParse(points[1], out b) && int.TryParse(points[2], out c))
            {
                return new Point3D(a, b, c);
            }
            else
            {
                Console.WriteLine(" Please enter valid numbers");
                return enterPoint();
            }
        }


        static void Main(string[] args)
        {
            #region First Project:
       Point3D point = new Point3D(10, 10, 10);
            Console.WriteLine(point.ToString());

            Point3D p1, p2;

            Console.WriteLine(" enter 3 numbers for Point 1 in the same line with space  ");
            p1  = enterPoint();

            Console.WriteLine("enter 3 numbers for Point 2 in the same line with space ");
            p2 = enterPoint();

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            if (p1.Equals(p2)) 
            {
                Console.WriteLine("Points P1 and P2 are equal.");
            }
            else
            {
                Console.WriteLine("Points P1 and P2 are not equal.");
            }

            #endregion

            #region Second Project
            double num01 = 50;
            double num02 = 50;
            Console.WriteLine($"The Result Of Addition is : {Maths.Add(num01,num02)}");
            Console.WriteLine($"The Result Of Subtraction is : {Maths.Subtract(num01, num02)}");  
            Console.WriteLine($"The Result Of Multipliction is : {Maths.Multiply(num01, num02)}");
            Console.WriteLine($"The Result Of Division is : {Maths.Divide(num01, num02)}");




            #endregion

            #region third project 
            Duration D1 = new Duration(1, 10, 15);
            D1.ToString();
            Console.WriteLine(D1.ToString());
            Duration D2= new Duration(3600);
            D2.ToString();
            Console.WriteLine(D2.ToString());
            Duration D3 = new Duration(7800);
            D3.ToString();
            Console.WriteLine(D3.ToString());
            Duration D4 = new Duration(666);
            D4 .ToString();
            Console.WriteLine(D4.ToString()); 








            #endregion







        }






    }
}
