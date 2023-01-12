using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest3_Link2
{
    internal class Tiger : Animal
    {
        public Tiger()
        {
        }

        public Tiger(string ten) : base(ten)
        {
            Ten = ten;
        }

        public Tiger(string ten, int tuoi) : base(ten, tuoi)
        {
            Ten = ten;
            Tuoi = tuoi;
        }

        public Tiger(string ten, int tuoi, string mota) : base(ten, tuoi, mota)
        {
            Ten = ten;
            Tuoi = tuoi;
            Mota = mota;
        }

        public override void tiengKeu()
        {
            Console.WriteLine("buh buh");
        }

        public override void xemInfo()
        {
            Console.WriteLine("Ten con vat: {0}", base.Ten);
            Console.WriteLine("Ten con vat: {0}", base.Tuoi);
            Console.WriteLine("Ten con vat: {0}", base.Mota);
        }
    }
}
