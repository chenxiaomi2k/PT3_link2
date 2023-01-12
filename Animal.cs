using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest3_Link2
{
    internal abstract class Animal
    {
        public string Ten { get; set; }
        public int Tuoi { get; set; }
        public string Mota { get; set; }

        public Animal()
        {
        }

        public Animal(string ten)
        {
            Ten = ten;
        }

        public Animal(string ten, int tuoi)
        {
            Ten = ten;
            Tuoi = tuoi;
        }

        public Animal(string ten, int tuoi, string mota)
        {
            Ten = ten;
            Tuoi = tuoi;
            Mota = mota;
        }

        public abstract void xemInfo();
        public abstract void tiengKeu();
    }
}
