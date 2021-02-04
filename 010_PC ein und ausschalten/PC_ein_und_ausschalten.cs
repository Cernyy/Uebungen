using System;

namespace _010_PC_ein_und_ausschalten
{
    class PC_ein_und_ausschalten
    {
        public static bool status = false;
        static void Main(string[] args)
        {
            
        }

        /*public static bool Status()
        {
            //get-Methode
        }*/

        public static void Einschalten()
        {
            if (status == false)
                status = true;
            else
            Console.WriteLine("Der PC ist bereits eingeschalten worden!");
        }

        public static void Ausschalten()
        {
            if (status == true)
            
                status = false;
            else
            Console.WriteLine("Der PC ist bereits ausgeschalten worden!");
        }
    }
}
