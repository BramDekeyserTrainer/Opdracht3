using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    /*Ik maak mijn custom kleine klasse 'Auto' aan.*/
    internal class Auto
    {
        /*Ik maak een public string 'Merk' aan.*/
        public string Merk { get; set; }

        /*Ik laat een constructor genereren voor mijn klasse.*/
        public Auto(string merk)
        {
            Merk = merk;
        }

        /*Ik maak mijn override boolean aan.*/
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is Auto)) return false;
            return (this.Merk == ((Auto)obj).Merk);
        }

        /*Ik maak een public override ToString function aan.
         Deze is gebaseerd op een string.*/
        public override string ToString()
        {
            return this.Merk;
        }
    }
}
