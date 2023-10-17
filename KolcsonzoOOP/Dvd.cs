using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolcsonzoOOP
{
    public class Dvd : IKolcsonozheto, IComparable
    {
        private string cim;
        private int hossz;

        public Dvd(string cim, int hossz)
        {
            this.cim = cim;
            this.hossz = hossz;
        }

        public string Cim { get => cim; set => cim = value; }
        public int Hossz { get => hossz; set => hossz = value; }

        public int CompareTo(object obj)
        {
            if (this.cim.Length < (obj as Dvd).Cim.Length)
            {
                return -1;
            }
            else if (this.cim.Length > (obj as Dvd).Cim.Length)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int MeddigKolcsonozheto()
        {
            return 7;
        }

        public string MegjelenitendoNev()
        {
            return $"{cim} ({hossz})";
        }
    }
}
