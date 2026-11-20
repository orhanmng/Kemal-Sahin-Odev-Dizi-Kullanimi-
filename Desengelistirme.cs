using System;

class Program
{
    static void Main()
    {
        int satirSayisi;

        while (true)
        {
            Console.Write("Satır sayısını girin: ");
            string giris = Console.ReadLine();

            if (!int.TryParse(giris, out satirSayisi))
            {
                Console.WriteLine("HATA! Lütfen metin değil, geçerli bir tam sayı girin.");
                continue;
            }

            if (satirSayisi <= 0)
            {
                Console.WriteLine("HATA! Satır sayısı 0'dan büyük olmalıdır.");
                continue;
            }

            break;
        }

        string birinciKarakter;
        while (true)
        {
            Console.Write("Birinci karakteri girin (çift satırlar için): ");
            string giris = Console.ReadLine().Trim();

            if (giris.Length != 1)
            {
                Console.WriteLine("HATA! Boş bırakmadan sadece 1 adet karakter girin.");
                continue;
            }

            birinciKarakter = giris;
            break;
        }

        string ikinciKarakter;
        while (true)
        {
            Console.Write("İkinci karakteri girin (tek satırlar için): ");
            string giris = Console.ReadLine().Trim();

            if (giris.Length != 1)
            {
                Console.WriteLine("HATA! Boş bırakmadan sadece 1 adet karakter girin.");
                continue;
            }

            if (giris == birinciKarakter)
            {
                Console.WriteLine("HATA! İkinci karakter birinci karakterden farklı olmalıdır.");
                continue;
            }

            ikinciKarakter = giris;
            break;
        }

        Console.WriteLine();

        for (int satir = 1; satir <= satirSayisi; satir++)
        {
            string kullanilacakKarakter;

            if (satir % 2 != 0)
            {
                kullanilacakKarakter = ikinciKarakter;
            }
            else
            {
                kullanilacakKarakter = birinciKarakter;
            }

            for (int sutun = 1; sutun <= satir; sutun++)
            {
                Console.Write(kullanilacakKarakter + " ");
            }

            Console.WriteLine();
        }
    }
}
