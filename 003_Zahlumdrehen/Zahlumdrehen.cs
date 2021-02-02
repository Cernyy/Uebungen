using System;

namespace _003_Zahlumdrehen
{
    class Zahlumdrehen
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Umdrehen(1234));
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

    }
}
