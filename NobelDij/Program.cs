using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.IO;
namespace NobelDij
{
    class Program
    {

        static void Main(string[] args)
        {
            List<NobelDij> adatok = new List<NobelDij>();
            try
            {
                File.ReadAllLines("nobel.csv").Skip(1).ToList().ForEach(x => adatok.Add(new NobelDij(x)));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Hiba a fájl beolvasásakor {e}");
                throw;
            }
            var artur = adatok.Where(x => x.VezetekNev == "McDonald" && x.KeresztNev == "Arthur B.");
            foreach (var item in artur)
            {
                Console.WriteLine($"3. feladat: {item.Tipus}");
            }
            var nobeldij2017 = adatok.Where(x => x.Evszam == 2017).ToList();
            foreach (var nobel in nobeldij2017)
            {
                Console.WriteLine($"4. feladat: {nobel.VezetekNev} {nobel.KeresztNev}");
            }
            var napjainkban = adatok.Where(x => x.Evszam > 1990 && x.Tipus == "béke").ToList();
            Console.WriteLine("5. feladat:");
            foreach (var item in napjainkban)
            {
                Console.WriteLine($"{item.Evszam} {item.VezetekNev}");
            }
            var curieCsalad = adatok.Where(x => x.VezetekNev.Contains("Curie")).ToList();
            Console.WriteLine("6. feladat:");
            foreach (var csalad in curieCsalad)
            {
                Console.WriteLine($"{csalad.Evszam}: {csalad.KeresztNev}- {csalad.VezetekNev} ({csalad.Tipus})");
            }
            var tipusok = adatok.Select(x => x.Tipus).Distinct().ToList();
            foreach (var tipus in tipusok)
            {
                //  Console.WriteLine($"{tipus.Tipus} {tipus.Tipus.Count()}");
            }
            var orvosi = adatok.Where(x => x.Tipus == "orvosi").OrderBy(x => x.Evszam);
            using (StreamWriter writer = new StreamWriter("orvosi.txt"))
            {
                foreach (var item in orvosi)
                {
                    string adatsor = $"{item.Evszam} {item.KeresztNev} {item.VezetekNev}";
                    writer.WriteLine(adatsor);

                }
            }
            Console.WriteLine("8. feladat: orvosi.txt");

        }
    }
}
