using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FociProject.Models
{
    class Context
    {

        public List<Focista> Focistak { get; set; }
        public List<FociKlub> FociKlubok { get; set; }

        public Context()
        {
            Focistak = new List<Focista>();
            FociKlubok = new List<FociKlub>();

            FociKlub fk1 = new FociKlub(new DateTime(2019, 1, 1), "Klub1", 10000);
            FociKlub fk2 = new FociKlub(new DateTime(2018, 12, 31), "Klub2", 90000);

            FociKlubok.Add(fk1);
            FociKlubok.Add(fk2);

            Focistak.Add(new Focista("Focista1", 1, 190, 90, true, fk1));
            Focistak.Add(new Focista("Focista2", 2, 180, 140, true, fk1));
            Focistak.Add(new Focista("Focista3", 3, 170, 100, true, fk1));

            Focistak.Add(new Focista("Focista4", 4, 200, 130, false, fk2));
            Focistak.Add(new Focista("Focista5", 5, 160, 120, false, fk2));
            Focistak.Add(new Focista("Focista6", 6, 140, 110, false, fk2));


            //fk1.Focistak.Add(Focistak[0]);
            //fk1.Focistak.Add(Focistak[1]);
            //fk1.Focistak.Add(Focistak[2]);

            //fk2.Focistak.Add(Focistak[3]);
            //fk2.Focistak.Add(Focistak[4]); 
            //fk2.Focistak.Add(Focistak[5]);

            fk1.Focistak = Focistak.Where(x => x.Klub.Equals(fk1)).ToList();
            fk2.Focistak = Focistak.Where(x => x.Klub.Equals(fk2)).ToList();








        }





    }
}
