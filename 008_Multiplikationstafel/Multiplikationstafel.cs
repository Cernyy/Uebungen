using System;

namespace _009_Multiplikationstafel
{
    class Multiplikationstafel
    {
        static void Main(string[] args)
        {
            Console.Write("         \t");
            for (int i = 1; i < 13; i++)
            {
                Console.Write(i+"\t");
            }
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");

            for (int i = 1; i < 13; i++)
            {

                Console.Write("Zeile {0}:\t", i);

                for (int ii = 1; ii < 13; ii++)
                {
                    Console.Write(i*ii+"\t");
                }
                Console.WriteLine("");
            }
        }
    }
}
