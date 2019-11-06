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

            Focista Focista1 = new Focista("Focista1", 1, 190, 90, true, fk1);
            Focista Focista2 = new Focista("Focista2", 2, 180, 140, true, fk1);
            Focista Focista3 = new Focista("Focista3", 3, 170, 100, true, fk1);

            Focista Focista4 = new Focista("Focista4", 4, 200, 130, false, fk2);
            Focista Focista5 = new Focista("Focista5", 5, 160, 120, false, fk2);
            Focista Focista6 = new Focista("Focista6", 6, 140, 110, false, fk2);

            fk1.Focistak.Add(Focista1);
            fk1.Focistak.Add(Focista2);
            fk1.Focistak.Add(Focista3);

            fk2.Focistak.Add(Focista4);
            fk2.Focistak.Add(Focista5); 
            fk2.Focistak.Add(Focista6);


            Focistak.Add(Focista1);
            Focistak.Add(Focista2);
            Focistak.Add(Focista3);
            Focistak.Add(Focista4);
            Focistak.Add(Focista5);
            Focistak.Add(Focista6);





        }





    }
}
