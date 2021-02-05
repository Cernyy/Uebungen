using System;

namespace _005___Mirpzahlen
{
    class Mirpzahlen
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 1001; i++)
            {
                isMirp(i);
            }
            
        }

        public static bool isMirp(int n)
        {
            int umgedreht = Umdrehen(n);
            if (n != Umdrehen(n) && isPrim(n) && isPrim(umgedreht))
            {
                Console.WriteLine(n);
                return true;
            }
            return false;
        }

        public static int Umdrehen(int n)
        {
            int umgedreht = 0;
            while (n >= 1)
            {
                umgedreht *= 10;
                umgedreht += n % 10;
                n -= n % 10;
                n /= 10;
            }
            return umgedreht;
        }

        public static bool isPrim(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
