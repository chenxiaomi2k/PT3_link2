using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest3_Link2
{
    internal class Cat : Animal
    {
        public Cat()
        {
        }

        public Cat(string ten) : base(ten)
        {
            Ten = ten;
        }

        public Cat(string ten, int tuoi) : base(ten, tuoi)
        {
            Ten = ten;
            Tuoi = tuoi;
        }

        public Cat(string ten, int tuoi, string mota) : base(ten, tuoi, mota)
        {
            Ten = ten;
            Tuoi = tuoi;
            Mota = mota;
        }

        public override void tiengKeu()
        {
            Console.WriteLine("meo meo");
        }

        public override void xemInfo()
        {
            Console.WriteLine("Ten con vat: {0}", base.Ten);
            Console.WriteLine("Ten con vat: {0}", base.Tuoi);
            Console.WriteLine("Ten con vat: {0}", base.Mota);
        }
    }
}
