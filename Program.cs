using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Nobel
    {
        public int evszam;
        public string tipus;
        public string keresztnev;
        public string vezeteknev;

        public int Evszam { get => evszam; set => evszam = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public string Keresztnev { get => keresztnev; set => keresztnev = value; }
        public string Vezeteknev { get => vezeteknev; set => vezeteknev = value; }

        public void nobel(string ertek)

        {
            var erte = ertek.Split(';');
           this.evszam = Convert.ToInt32(erte[0]);
            this.tipus = erte[1];
            this.keresztnev = erte[2];
            this.vezeteknev = erte[3];
        }
                                      
    }

    class Program
    {
        static void Main(string[] args)
        {
            var s = new StreamReader("nobel.csv");
            var elsosor = s.ReadLine();
            List<Dijazottak> adatokl = new List<Dijazottak>();
            
            while (!s.EndOfStream)
            {
                adatokl.Add(new Dijazottak(s.ReadLine));
            }
            s.Close();

            foreach (var adat in adatokl)
            {
                var y2017 = Where(x => x.evszam == 2017 && x => x.tipus == "béke");
                Console.WriteLine(y2017);
            }


            

        }
    }
}
