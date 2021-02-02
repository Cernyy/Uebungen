using System;

namespace _0007_FibonacciZahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[30];

            arr[0] = 0;
            arr[1] = 1;

            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
