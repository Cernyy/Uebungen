using System;

namespace _006_Primzahlenüberprüfung_nach_Wilson
{
    class Primzahl_Wilson
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isPrime(19));
        }

        public static bool isPrime(int p)
        {
            if (p > 20)
            {
                Console.WriteLine("Zahl zu groß (muss kleiner als 21 sein!)");
                return false;
            }

            if (fakult(p - 1) + 1 % p == 0)
                return true;
            else return false;
        }

        public static long fakult(long n)
        {
            long fakult = 1;
            for (int i = 1; i < n; i++)
            {
                fakult *= i;
            }
            return fakult;
        } 

    }
}
