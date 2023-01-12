using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest3_Link2
{
    internal class TestZoo
    {
        static int menu()
        {
            Console.WriteLine("1. Them chuong");
            Console.WriteLine("2. Xoa chuong");
            Console.WriteLine("3. Them con vat");
            Console.WriteLine("4. Xoa con vat");
            Console.WriteLine("5. Xem tat ca cac con vat");
            Console.WriteLine("6. Thoat");
            while (true)
            {
                Console.Write("Chon menu:");
                int choice = int.Parse(Console.ReadLine());
                if (choice >= 1 && choice <= 6)
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("Chon lai");
                }
            }
        }
        static void Main(string[] args)
        {
            Chuong c = new Chuong();
            Zoo zoo = new Zoo();
            while (true)
            {
                int choice = menu();
                switch (choice)
                {
                    case 1:
                        zoo.themChuong(c);
                        break;
                    case 2:
                        Console.Write("Nhap ma chuong: ");
                        int ma = int.Parse(Console.ReadLine());
                        zoo.xoaChuong(ma);
                        break;
                    case 3:
                        Console.Write("Chon con vat de them (1. Tiger, 2. Dog, 3. Cat): ");
                        int vat = int.Parse(Console.ReadLine());
                        switch (vat)
                        {
                            case 1:
                                Console.Write("Nhap ten con vat: ");
                                string tenho = Console.ReadLine();
                                Console.Write("Nhap tuoi con vat: ");
                                int tuoiho = int.Parse(Console.ReadLine());
                                Console.Write("Nhap mo ta con vat: ");
                                string motaho = Console.ReadLine();
                                Tiger t = new Tiger(tenho, tuoiho, motaho);
                                c.themConVat(t);
                                break;
                            case 2:
                                Console.Write("Nhap ten con vat: ");
                                string tencho = Console.ReadLine();
                                Console.Write("Nhap tuoi con vat: ");
                                int tuoicho = int.Parse(Console.ReadLine());
                                Console.Write("Nhap mo ta con vat: ");
                                string motacho = Console.ReadLine();
                                Dog dog = new Dog(tencho, tuoicho, motacho);
                                c.themConVat(dog);
                                break;
                            case 3:
                                Console.Write("Nhap ten con vat: ");
                                string tenmeo = Console.ReadLine();
                                Console.Write("Nhap tuoi con vat: ");
                                int tuoimeo = int.Parse(Console.ReadLine());
                                Console.Write("Nhap mo ta con vat: ");
                                string motameo = Console.ReadLine();
                                Cat cat = new Cat(tenmeo, tuoimeo, motameo);
                                c.themConVat(cat);
                                break;
                        }
                        break;
                    case 4:
                        Console.Write("Nhap ten con vat muon xoa: ");
                        string name = Console.ReadLine();
                        c.xoaConVat(name);
                        break;
                    case 5:
                        foreach (Animal animal in c.AnimalList)
                        {
                            animal.xemInfo();
                            animal.tiengKeu();
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
