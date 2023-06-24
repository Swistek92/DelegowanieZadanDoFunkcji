using System.Collections.Immutable;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace zad6
{
    internal class zadanie6
    {
        class Program
        {
            static void Main()
            {
                double[] arr = { 1.3, 2.3, 1.1, 5.2, 9.1 };
                int size = arr.Length;
                double avrage = arithmeticAvrage(arr, size);
                Console.WriteLine(avrage);
                Console.ReadKey();

            }


        
            public static double arithmeticAvrage(double[] arr, int size )
            {
                if (size == 0) return 0.0;
                double sum = arr[size - 1] + arithmeticAvrage(arr, size-1) * (size-1);
              //  double sum = arr.Aggregate((x, y) => x + y);   
                return sum / size;
            }
        }

    }
}
