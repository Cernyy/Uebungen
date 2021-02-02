using System;

namespace _002_Gamblers_Ruin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Startkapital:");
            double startk = double.Parse(Console.ReadLine());
            Console.WriteLine("Zielkapital:");
            double zielk = double.Parse(Console.ReadLine());
            Console.WriteLine("Wiederholungen:");
            int wiederholungen = int.Parse(Console.ReadLine());

            int gewonnen = 0;

            double spielkapital = startk;
            Random r = new Random();


            for (int i = 0; i < wiederholungen; i++)
            {
                double zufall = r.NextDouble();
                if (zufall < 0.5)
                {
                    gewonnen++;
                    spielkapital++;
                }
                else
                {
                    spielkapital--;
                }

                if (spielkapital <= 0 || spielkapital >= zielk)
                {
                    break;
                }
            }

            Console.WriteLine("\nGewonnene Spiele: {0}\nStartkapital: {1}\nEndkapital: {2}", gewonnen, startk, spielkapital);
        }
    }
}
