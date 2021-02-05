using System;
using System.Collections.Generic;
using System.Text;

namespace _011_Uhrzeit
{
    class Program
    {
        static void Main(string[] args)
        {

            Uhrzeit u1 = new Uhrzeit(12, 12, 12);
            Uhrzeit u2 = new Uhrzeit(02, 02, 02);

            Console.WriteLine(u1.sec);
            Console.WriteLine(u2.sec);
            u1.Drucken();
            u2.Drucken();
            u1.Diff(13,13,13);
            u1.Drucken();
        }
    }
}
