using System;

namespace DiziElemanlariToplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 10, 20, 30, 40, 50, 60 };
            int filtreDegeri = 25;

            int toplam = ElemanlariToplaVeFiltrele(sayilar, filtreDegeri);
            Console.WriteLine($"Filtre değerinden büyük elemanların toplamı: {toplam}");
        }

        static int ElemanlariToplaVeFiltrele(int[] dizi, int filtre)
        {
            int toplam = 0;

            foreach (int sayi in dizi)
            {
                if (sayi > filtre)
                {
                    toplam += sayi;
                }
            }

            return toplam;
            Console.ReadKey();
        }
    }
}