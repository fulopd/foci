using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FociProject.Models
{
    class Focista
    {

        public string Nev { get; set; }
        public int MezSzam { get; set; }
        public int Magassag { get; set; }
        public int Suly { get; set; }
        public bool JobbLabas { get; set; }
        public FociKlub Klub { get; set; }


        public Focista(string nev, int mezSzam, int magassag, int suly, bool jobbLabas, FociKlub klub)
        {
            Nev = nev;
            MezSzam = mezSzam;
            Magassag = magassag;
            Suly = suly;
            JobbLabas = jobbLabas;
            Klub = klub;

           
        }


        
    }
}
