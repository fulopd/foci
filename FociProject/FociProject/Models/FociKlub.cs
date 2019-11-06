using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FociProject.Models
{
    class FociKlub
    {
        public DateTime Alapitas { get; set; }
        public string Nev { get; set; }
        public double Koltsegvetes { get; set; }
        public List<Focista> Focistak { get; set; }

        public FociKlub(DateTime alapitas, string nev, double koltsegvetes)
        {
            Alapitas = alapitas;
            Nev = nev;
            Koltsegvetes = koltsegvetes;
            Focistak = new List<Focista>();



        }

        
       

    }
}
