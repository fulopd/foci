using FociProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FociProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var ct = new Context();

            Console.WriteLine("Hány FociKlubb szrepel a listában?");
            Console.WriteLine(ct.FociKlubok.Count());
            Console.WriteLine();

            //min
            Console.WriteLine("össz költség:?");
            var osszeg = ct.FociKlubok.Sum(x => x.Koltsegvetes);
            Console.WriteLine(osszeg);
            Console.WriteLine();


            //max
            Console.WriteLine("legmagasabb?");
            var magassag = ct.Focistak.Max(x => x.Magassag);
            Console.WriteLine(magassag);
            Console.WriteLine();


            //szűrés
            Console.WriteLine("Mely focisták magassága kisebb mint 180 cm?");
            var kicsik = ct.Focistak.Where(x => x.Magassag < 180).ToList();
            kicsik.ForEach(x => Console.WriteLine(x.Nev));
            Console.WriteLine();

            //rendezés
            Console.WriteLine("Rendezze mez szám szerint a focistákat");
            var rendezett = ct.Focistak.OrderBy(x => x.MezSzam).ToList();
            rendezett.ForEach(x => Console.WriteLine(x.Nev));
            Console.WriteLine();

            //csoportosítás
            Console.WriteLine("Csoportosítás focistákat klubbok alaján és számolja meg a tagokat");
            var csoportok = ct.Focistak.GroupBy(x => x.Klub).ToList();
            csoportok.ForEach(x => Console.WriteLine(x.Key.Nev + " Tagok száma: " + x.Count()));
            Console.WriteLine();

            //egyetlen elem kiválasztása
            Console.WriteLine("Melyik az a klubb aminek az alapítási éve kisebb mint 1950 és a költségvetése 10000 felett van");
            var gazdagKlubb = ct.FociKlubok.SingleOrDefault(x => x.Alapitas.Year > 1950 && x.Koltsegvetes > 20000);
            //var gazdagKlubb = ct.FociKlubok.FirstOrDefault(x => x.Alapitas.Year > 1950 && x.Koltsegvetes > 500);

            Console.WriteLine(gazdagKlubb.Nev);

            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
