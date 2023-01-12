using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest3_Link2
{
    internal class Zoo
    {
        public ArrayList? DanhSachChuong { get; set; }

        public Zoo()
        {
        }

        public Zoo(ArrayList? danhSachChuong)
        {
            DanhSachChuong = danhSachChuong;
        }

        public void themChuong(Chuong c)
        {
            DanhSachChuong.Add(c);
            Console.WriteLine("Them chuong thanh cong");
        }

        public void xoaChuong(int ma)
        {
            foreach (Chuong c in DanhSachChuong)
            {
                if (c.Machuong == ma)
                {
                    DanhSachChuong.Remove(c);
                    Console.WriteLine("Xoa chuong thanh cong");
                }
            }
        }
    }
}
