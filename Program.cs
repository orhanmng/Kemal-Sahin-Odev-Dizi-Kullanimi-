using System;

class Program
{
    static void Main()
    {
        int[] sayilar = new int[10];
        Random rastgele = new Random();

        Console.WriteLine("Üretilen Rastgele Sayılar:");
        for (int i = 0; i < sayilar.Length; i++)
        {
            sayilar[i] = rastgele.Next(1, 101);
            Console.WriteLine((i + 1) + ". sayı: " + sayilar[i]);
        }

        int enBuyuk = sayilar[0];
        int enKucuk = sayilar[0];
        int enBuyukSira = 1;
        int enKucukSira = 1;
        int ciftAdet = 0;
        int tekAdet = 0;

        for (int i = 0; i < sayilar.Length; i++)
        {
            if (sayilar[i] > enBuyuk)
            {
                enBuyuk = sayilar[i];
                enBuyukSira = i + 1;
            }

            if (sayilar[i] < enKucuk)
            {
                enKucuk = sayilar[i];
                enKucukSira = i + 1;
            }

            if (sayilar[i] % 2 == 0)
            {
                ciftAdet++;
            }
            else
            {
                tekAdet++;
            }
        }

        Console.WriteLine();
        Console.WriteLine("En büyük sayı: " + enBuyuk + " (" + enBuyukSira + ". sayı)");
        Console.WriteLine("En küçük sayı: " + enKucuk + " (" + enKucukSira + ". sayı)");
        Console.WriteLine("Çift sayı adedi: " + ciftAdet);
        Console.WriteLine("Tek sayı adedi: " + tekAdet);

        Console.WriteLine();
        Console.Write("Bir sayı girin: ");
        int kullaniciSayisi = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Girdiğiniz sayıdan büyük olan rastgele sayılar:");
        for (int i = 0; i < sayilar.Length; i++)
        {
            if (sayilar[i] > kullaniciSayisi)
            {
                Console.WriteLine(sayilar[i]);
            }
        }
    }
}
