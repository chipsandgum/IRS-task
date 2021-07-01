using System;

namespace IRStask2
{
    class Program
    {
        static void Main(string[] args)
        {

            Start1:
            double a1, b1, a2, b2, theta;
            Console.Write("We will be working with 2 vectors. Enter the values carefully.\nVector 2 is anti-clockwise to Vector 1." +
                " \nEnter the magnitude of y for vector 1: ");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the magnitude of z for vector 1: ");
            b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the magnitude of y for vector 2: ");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the magnitude of z for vector 2:");
            b2 = Convert.ToInt32(Console.ReadLine());

            theta = angleCalculator(a1, a2, b1, b2);

            if (theta == 90)
            {
                Console.WriteLine("The vectors are Orthogonal, i.e. 90 degrees");
            }
            else
            {
                Console.WriteLine($"The angle between the two vectors is {Math.Round(theta, 3)} degrees");
            }
            Console.WriteLine("Do you want to find the  angle for another pair of vectors (y/n)");
            string ans;
            ans = Console.ReadLine();

            if (ans == "y" || ans == "Y")
            {
                Console.Clear();

                goto Start1;
            }
            else
                Console.Write("Thank You!!");
            Environment.Exit(0);


        }
        public static double angleCalculator(double a1, double a2, double b1, double b2)
        {
            double dot_prod, mod_x, mod_y, angle;

            dot_prod = (a1 * a2) + (b1 * b2);
            mod_x = Math.Sqrt(((Math.Pow(a1, 2)) + (Math.Pow(b1, 2))));
            mod_y = Math.Sqrt(((Math.Pow(a2, 2)) + (Math.Pow(b2, 2))));

            angle = Math.Acos((dot_prod / (mod_x * mod_y)));

            return (angle * (180 / Math.PI));

        }
    }
}