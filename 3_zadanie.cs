using System.Collections.Immutable;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace zad3
{
    internal class zadanie3
    {
        class Program
        {
            static void Main()
            {
                int[] numbers1 = { 5, 1, 9, 3, 7 };
                int median1 = findMedian(numbers1);
                Console.WriteLine(" mediana dla parzystej ilosci elementow " + median1);

                foreach (int number in numbers1)
                {
                    // orginalny array bez zmian
                    Console.WriteLine(number);

                }


                int[] numbers2 = { 5, 1, 9, 3, };
                int median2 = findMedian(numbers2);
                Console.WriteLine(" mediana dla  nie parzystej ilosci elementow " + median2);

                foreach (int number in numbers2)
                {
                    // orginalny array bez zmian

                    Console.WriteLine(number);

                }
            }


            public static int findMedian(int[] array)
            {
                int ArrLength = array.Length;

                if (ArrLength > 100) throw new Exception("Array is too Big!");
                if (ArrLength == 0) throw new Exception("Array is empty");



                int[] copiedArray = new int[ArrLength];
                Array.Copy(array, copiedArray, ArrLength);

                Array.Sort(copiedArray);


                if (ArrLength % 2 == 1)
                {
                    return copiedArray[ArrLength / 2];
                }
                else
                {
                    int middleIndex = ArrLength / 2;
                    return (copiedArray[middleIndex - 1] + copiedArray[middleIndex]) / 2;

                }
            }

        }

    }
}
