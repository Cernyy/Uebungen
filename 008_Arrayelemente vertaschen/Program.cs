using System;

namespace _008_Arrayelemente_vertaschen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            printArray(SwapCopy(arr));
        }

        public static int[] SwapCopy(int[] iArray)
        {
            int[] newArray = new int[iArray.Length];

            int zähler = 0;
            for (int i = iArray.Length-1; i >= 0; i--)
            {

                Console.WriteLine(i);

                newArray[zähler++] = iArray[i];
            }
            return newArray;
        }

        public static void printArray(int[] iArray)
        {

            foreach (int item in iArray)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }

    }
}
