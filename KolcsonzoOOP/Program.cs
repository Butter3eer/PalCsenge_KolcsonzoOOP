using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolcsonzoOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<object> katalogus = new List<object>();

            katalogus.Add(new Konyv("Alma", "Béla", "abc"));
            katalogus.Add(new Dvd("Almák támadása", 420));
            katalogus.Add(new Ujsag("Almaiszony", "2001", "12"));
            
            foreach (IKolcsonozheto item in katalogus)
            {
                Console.WriteLine(item.MegjelenitendoNev());
                Console.WriteLine(item.MeddigKolcsonozheto());
            }

            List<Dvd> dvdk = new List<Dvd>();

            dvdk.Add(new Dvd("A", 120));
            dvdk.Add(new Dvd("Alm", 360));
            dvdk.Add(new Dvd("Al", 240));
            dvdk.Add(new Dvd("Almak", 600));
            dvdk.Add(new Dvd("Alma", 480));

            dvdk.Sort();
            foreach (Dvd dv in dvdk)
            {
                Console.WriteLine(dv.Cim);
            }
        }
    }
}
