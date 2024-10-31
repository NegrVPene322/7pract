using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Pract_7_Карпушин
{
    class Time : Triad
    {
        public int Hour { get; private set; }
        public int Minut { get; private set; }
        public int Seconds { get; private set; }

        public Time(int hour, int minut, int seconds) : base()
        {

            int[] mas = Reverse(hour, minut, seconds);
            hour = mas[0];
            minut = mas[1];
            seconds = mas[2];
            if (hour > 24)
            {
                throw new Exception("Неподходяший формат времени");
            }
            else Hour = hour;
            Minut = minut;
            Seconds = seconds;

            


        }
        public static string Vid(Time ob)
        {
            string str = ob.Hour.ToString() + " " + ob.Minut.ToString() + " " + ob.Seconds.ToString();
            return str;
        }


        private int[] Reverse(int hour, int minut, int seconds)
        {
            TimeSpan t = new TimeSpan(hour, minut, seconds);
            double h = t.TotalHours;
            double m = t.TotalMinutes;
            double s = t.TotalSeconds;
            int h2 = (int)h;
            int m2 = (int)m;
            int s2 = (int)s;
            int[] mas =  [h2, m2, s2];
            return mas;
            

        }

            public static string Moment(Time a, Time b) 
        {
            string str = "";
            TimeSpan t1 = new TimeSpan(a.Hour, a.Minut, a.Seconds);
            TimeSpan t2 = new TimeSpan(b.Hour, b.Minut, b.Seconds);

            if (TimeSpan.Compare(t1, t2) == 1) str = "Первое позже второго";
            else if (TimeSpan.Compare(t1, t2) == -1) str = "Первое раньше второго";
            else if (TimeSpan.Compare(t1, t2) == 0) str = "Один момент";
            return str;
            
        }
    }
}
