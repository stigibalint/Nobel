using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NobelDij
{
    public class NobelDij
    {
        int evszam;
        string tipus;
        string keresztNev;
        string vezetekNev;

        public NobelDij(int evszam, string tipus, string keresztNev, string vezetekNev)
        {
            this.Evszam = evszam;
            this.Tipus = tipus;
            this.KeresztNev = keresztNev;
            this.VezetekNev = vezetekNev;
        }
        public NobelDij(string CSVsorok)
        {
            var mezo = CSVsorok.Split(';');
            this.evszam = int.Parse(mezo[0]);
            this.tipus = mezo[1];
            this.keresztNev = mezo[2];
            this.vezetekNev = mezo[3];
        }
        public int Evszam { get => evszam; set => evszam = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public string KeresztNev { get => keresztNev; set => keresztNev = value; }
        public string VezetekNev { get => vezetekNev; set => vezetekNev = value; }
    }
}
