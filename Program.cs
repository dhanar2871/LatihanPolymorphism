using System;

namespace LatihanPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterJenis printer = new PrinterJenis();

            Console.WriteLine("Pilih Printer:");
            Console.WriteLine(" 1. Epson\n 2. Canon\n 3. LaserJet\n\n");

            Console.Write("Nomor Printer [1..3]: ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomorPrinter == 1)
                printer = new Epson();
            else if (nomorPrinter == 2)
                printer = new Canon();
            else if (nomorPrinter == 3)
                printer = new LaserJet();
            else
                Console.WriteLine("maaf, kode yang anda masukkan tidak terdaftar");

            printer.Show();
            printer.Print();

        }
    }
}
