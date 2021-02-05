using System;

namespace _011_Uhrzeit
{
    class Uhrzeit
    {
        public long sec;

        public Uhrzeit(int hh, int mm, int ss)
        {
            sec = (hh * 60 * 60) + (mm * 60) + ss;
        }

        public void Add(Uhrzeit t2)
        {
            sec += t2.sec;
        }

        public void Sub(Uhrzeit t2)
        {
            if (t2.sec > sec)
                this.sec = t2.sec - this.sec;
            else
                this.sec = this.sec - t2.sec;
        }

        public void Diff(int hh, int mm, int ss)
        {
            long otherSec = (hh * 60 * 60) + (mm * 60) + ss;
            long diffInSec;

            if (otherSec > sec)

                diffInSec = sec - otherSec;
            else
                diffInSec = otherSec - sec;

            long sekunden = diffInSec;
            int h = Convert.ToInt32(sekunden / 3600);
            h *= -1;
            sekunden = sekunden % 3600;
            int m = Convert.ToInt32(sekunden / 60);
            m *= -1;
            sekunden = sekunden % 60;
            int s = Convert.ToInt32(sekunden);
            s *= -1;

            Console.WriteLine("Differenz: -{0}:{1}:{2}", h.ToString("00"), m.ToString("00"), s.ToString("00"));
        }

        public void Drucken()
        {
            long sekunden = sec;
            int h = Convert.ToInt32(sekunden / 3600);
            if (h > 23)// Wenn Tag übersprungen wird
            {
                h -= 24;
            }
            else if (h < 0)//Wenn Tag negativ übersprungen wird
            {
                h += 24;
            }
            sekunden = sekunden % 3600;
            int m = Convert.ToInt32(sekunden / 60);
            sekunden = sekunden % 60;
            int s = Convert.ToInt32(sekunden);
            Console.WriteLine("Uhrzeit: {0}:{1}:{2}", h.ToString("00"), m.ToString("00"), s.ToString("00"));
        }

    }
}
