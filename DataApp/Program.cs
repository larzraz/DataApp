using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.show();
            myProgram.sorter();
        }
        Dato dat = new Dato();

        public void show()
        {
            DateTime day = DateTime.Now;
           // dat.SetDay();
            Console.WriteLine("dagen er " + day.DayOfWeek);
            Console.ReadKey();
            
        }

        public void sorter()
        {
            List<DateTime> dtt = new List<DateTime>();
            DateTime dt = new DateTime(2017, 3, 1);
            DateTime dat1 = new DateTime(dt.Year,dt.Month,2);
            DateTime dat2 = new DateTime(dt.Year, dt.Month,3);
            DateTime dat3 = new DateTime(dt.Year, dt.Month,4);
            DateTime dat4 = new DateTime(dt.Year, dt.Month,5);
            DateTime dat5 = new DateTime(dt.Year, dt.Month,6);
            DateTime dat6 = new DateTime(dt.Year, dt.Month,7);
            DateTime dat7 = new DateTime(dt.Year, dt.Month,8);
            DateTime dat8 = new DateTime(dt.Year, dt.Month,9);
            DateTime dat9 = new DateTime(dt.Year, dt.Month,10);
            DateTime dat10 = new DateTime(dt.Year, dt.Month,11);
            DateTime dat11 = new DateTime(dt.Year, dt.Month,12);
            DateTime dat12 = new DateTime(dt.Year, dt.Month,13);
            DateTime dat13 = new DateTime(dt.Year, dt.Month,14);
            DateTime dat14 = new DateTime(dt.Year, dt.Month,15);
            DateTime dat15 = new DateTime(dt.Year, dt.Month,16);

            dtt.Add(dat1);
            dtt.Add(dat2);
            dtt.Add(dat3);
            dtt.Add(dat4);
            dtt.Add(dat5);
            dtt.Add(dat6);
            dtt.Add(dat7);
            dtt.Add(dat8);
            dtt.Add(dat9);
            dtt.Add(dat10);
            dtt.Add(dat11);
            dtt.Add(dat12);
            dtt.Add(dat13);
            dtt.Add(dat14);
            dtt.Add(dat15);
            

            List<DateTime> monday = new List<DateTime>();
            List<DateTime> tuesday = new List<DateTime>();
            List<DateTime> wednesday = new List<DateTime>();
            List<DateTime> thursday = new List<DateTime>();
            List<DateTime> friday = new List<DateTime>();
            List<DateTime> saturday = new List<DateTime>();
            List<DateTime> sunday = new List<DateTime>();

            foreach (DateTime datet in dtt)
            {
                if (datet.DayOfWeek == DayOfWeek.Monday)
                {
                    monday.Add(datet);
                }
                if (datet.DayOfWeek == DayOfWeek.Tuesday)
                {
                    tuesday.Add(datet);
                }
                if (datet.DayOfWeek == DayOfWeek.Wednesday)
                {
                    wednesday.Add(datet);
                }
                if (datet.DayOfWeek == DayOfWeek.Thursday)
                {
                    thursday.Add(datet);
                }

                if (datet.DayOfWeek == DayOfWeek.Friday)
                {
                    friday.Add(datet);
                }

                if (datet.DayOfWeek == DayOfWeek.Saturday)
                {
                    saturday.Add(datet);
                }
                if (datet.DayOfWeek == DayOfWeek.Sunday)
                {
                    sunday.Add(datet);
                }

              
            }
            Console.WriteLine(monday.Count);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(friday.Count);
            Console.WriteLine();
            Console.WriteLine("tallet er " + thursday.Count);
            Console.ReadKey();
        }
    }
}
