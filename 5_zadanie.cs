using System.Collections.Immutable;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace zad5
{
    internal class zadanie5
    {
        class Program
        {
            static void Main()
            {

                Console.WriteLine("take numer");    
                int number = Convert.ToInt32(Console.ReadLine());
                int prismeNumbersCount = CountPrimeDivisors(number);
                Console.WriteLine("numer " + number + " have " + prismeNumbersCount + " wihich are prime numbers");
                Console.ReadKey();

            }


            public static bool IsPrime(int number)
            {
                if (number < 2) return false;

                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0) return false;
                }

                return true;
            }
            
            public static int CountPrimeDivisors(int n)
            {
                if (n <= 5) return 0;
                int count = 0;

                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0 && IsPrime(i)) count++;
                }

                return count;
            }
        }

    }
}
