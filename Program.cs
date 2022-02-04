using System;

namespace console_programlama
{

    public class prgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba Dünya");
            Console.WriteLine("İsminizi Girin");
            string fName = Console.ReadLine();

            Console.WriteLine("Soyisim Girin");
            string sName = Console.ReadLine();

            Console.WriteLine("Merhaba " + fName + " " + sName);
        }

    }
}

