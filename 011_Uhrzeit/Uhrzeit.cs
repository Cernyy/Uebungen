using System;

namespace _011_Uhrzeit
{
    class Uhrzeit
    {
        long sec;


        static void Main(string[] args)
        {

            Uhrzeit u1 = new Uhrzeit(12, 12, 12);
            Uhrzeit u2 = new Uhrzeit(02, 02, 02);

            Console.WriteLine(u1.sec);
            u1.Drucken();
            u1.Sub(u2);
            u1.Drucken();
        }

        public Uhrzeit(int hh, int mm, int ss)
        {
            this.sec += hh * 360;
            this.sec += mm * 60;
            this.sec += ss;
        }

        public void Add(Uhrzeit t2)
        {
            t2.sec += this.sec;
        }

        public void Sub(Uhrzeit t2)
        {
            if (t2.sec > sec)
                this.sec = t2.sec - this.sec;
            else
                this.sec = this.sec - t2.sec;
        }

        public void Diff(Uhrzeit t2)
        {

        }

        public void Drucken()
        {
            int hh = 0;
            int mm = 0;
            int ss = 0;

            long thissec = this.sec;

            for (int i = 0; thissec > 360 ; hh++)
            {
                thissec -= 360;
            }
            for (int i = 0; thissec > 60; mm++)
            {
                thissec -= 60;
            }
            for (int i = 0; ss < thissec; ss++) { }
            

            Console.WriteLine("Es ist {0}:{1} Uhr und {2} Sekunden.",hh,mm,ss);
        }

    }
}
