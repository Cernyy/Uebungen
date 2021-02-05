using System;

namespace _010_PC_ein_und_ausschalten
{
    class PC_ein_und_ausschalten
    {
        public bool status { get; set; } = false;
        static void Main(string[] args)
        {
            
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

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
