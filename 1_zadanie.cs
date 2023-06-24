using System.Collections.Immutable;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace zad1
{
    internal class zadanie1
    {
        class Program
        {
            static void Main()
            {
                int second = 332;
                string time = timeFormater(second);
                Console.WriteLine(time);    
            }


            static string timeFormater(int second) =>  TimeSpan.FromSeconds(second).ToString(@"hh\:mm\:ss");

        }

    }
}
