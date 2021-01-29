using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety
            // Do not repeat yourself
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;

            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış İconu Göster");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış İconu Göster");
            }
            else
            {
                Console.WriteLine("Değişmedi iconu Göster");
            }

            if (sistemeGirisYapmisMi == true) // 2 kez tab'a basarsak otomatik if blogu yazar.
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}
