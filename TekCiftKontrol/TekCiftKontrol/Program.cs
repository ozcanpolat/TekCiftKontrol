using System;

namespace TekCiftKontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Kullanıcıdan alınan bir sayının tek çift kontrolünü yapınız.
            Console.Write("Bir sayı giriniz :");
            int sayi = int.Parse(Console.ReadLine());

            if ((sayi % 2) == 0)
            {
                Console.WriteLine("Girilen sayı çift sayıdır.");
            }
            else
            {
                Console.WriteLine("Girilen sayı tek sayıdır.");
            }
        }
    }
}
