using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest3_Link2
{
    internal class Chuong
    {
        public int Machuong { get; set; }
        public ArrayList AnimalList { get; set; }

        public Chuong()
        {
        }

        public Chuong(int machuong, ArrayList? animalList)
        {
            Machuong = machuong;
            AnimalList = animalList;
        }

        public void themConVat(Animal a)
        {
            AnimalList.Add(a);
            Console.WriteLine("Them con vat thanh cong");
        }

        public void xoaConVat(string ten)
        {
            foreach (Animal a in AnimalList)
            {
                if (ten.Equals(a.Ten))
                {
                    AnimalList.Remove(a);
                }
                else
                {
                    Console.WriteLine("Khong co con vat nay");
                }
            }
        }
    }
}
