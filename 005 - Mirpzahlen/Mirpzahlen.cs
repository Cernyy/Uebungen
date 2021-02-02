using System;

namespace _005___Mirpzahlen
{
    class Mirpzahlen
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isMirp(13));
        }

        public static bool isMirp(int n)
        {
            if (n != Umdrehen(n) && isPrim(n))
            {
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
            for (int i = 2; i < n*n; i++)
            {
                if (n % i == 0 && i != n)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
