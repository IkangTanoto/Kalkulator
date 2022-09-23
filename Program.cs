using System;
namespace Kalkulator
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("===========================");
            Console.WriteLine("KALKULATOR MANUAL");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1. Penjumlahan \n2. Pengurangan \n3. Perkalian \n4. Pembagian");

            Console.Write("Pilih aksi aritmatika : ");
            var aksi = Console.ReadLine();
            Console.WriteLine("===========================");
            Console.WriteLine("Masukkan bilangan 1 : ");
            int bil1 = Console.Read();
            Console.WriteLine("Masukkan bilangan 2 : ");
            int bil2 = Console.Read();

            switch (aksi)
            {
                case "1":
                    Console.WriteLine($"Hasil : {bil1 + bil2}");
                    break;
                case "2":
                    Console.WriteLine($"Hasil : {bil1 - bil2}");
                    break;
                case "3":
                    Console.WriteLine($"Hasil : {bil1 * bil2}");
                    break;
                case "4":
                    Console.WriteLine($"Hasil : {bil1 / bil2}");
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }
    }
}
