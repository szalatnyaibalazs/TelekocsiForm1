using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelekocsiForm1
{
    class Igeny
    {
        public string Azonosito { get; private set; }
        public string Indulas { get; private set; }
        public string Cel { get; private set; }
        public int Szemelyek { get; private set; }
        public string utvonal { get; private set; }

        public Igeny(string azonosito, string indulas, string cel, int szemely)
        {
            Azonosito = azonosito;
            Indulas = indulas;
            Cel = cel;
            Szemelyek = szemely;
            utvonal = Indulas + " " + Cel;
        }
        public int VanAuto(List<Auto> autok)
        {
            int x = 0;
            while (x < autok.Count &&
                !(utvonal == autok[x].utvonal &&
                Szemelyek <= autok[x].Ferohely))
            {
                x++;
            }
            if (x < autok.Count)
            {
                return x;
            }
            else
            {
                return -1;
            }

        }
    }
}
