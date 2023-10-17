using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolcsonzoOOP
{
    public class Ujsag : IKolcsonozheto
    {
        private string cim;
        private string kiadasEv;
        private string kiadasHet;

        public Ujsag(string cim, string kiadasEv, string kiadasHet)
        {
            this.cim = cim;
            this.kiadasEv = kiadasEv;
            this.kiadasHet = kiadasHet;
        }

        public int MeddigKolcsonozheto()
        {
            return 0;
        }

        public string MegjelenitendoNev()
        {
            return $"{cim} {kiadasEv}/{kiadasHet}";
        }
    }
}
