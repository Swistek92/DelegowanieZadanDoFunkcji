using System.Collections.Immutable;
using System.Runtime.ExceptionServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace zad2
{
    internal class zadanie2
    {
        class Program
        {
            static void Main()
            {


                double[] a = { 2, 7};
                double[] b = { 5, 3 };


                double distance =  segmentDistance(a, b);  

                Console.WriteLine(distance);    
                Console.ReadKey();  

            }


            static double segmentDistance(double[] a, double[] b)
            {
                if (a.Length != 2 || b.Length != 2) throw new Exception("points needs 2 coordinates");
                double Xa = a[0];
                double Ya = a[1];
                double Xb = b[0];
                double Yb = b[1];

                double deltaX = Xb - Xa;
                double deltaY = Yb - Ya;

                return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            }

        }

    }
}
