using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Xiaomi Redmi Note 8";
            urun1.Fiyat = 2600;
            urun1.Aciklama = "128GB dahili hafıza";
            urun1.StokAdedi = 5;

            Urun urun2 = new Urun();
            urun2.Adi = "Apple iPhone 7 32GB";
            urun2.Fiyat = 3000;
            urun2.Aciklama = "32GB dahili hafıza";
            urun2.StokAdedi = 12;


            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Ürün Adı : " + urun.Adi);
                Console.WriteLine("Ürün Fiyatı: " + urun.Fiyat);
                Console.WriteLine("Ürün Özellikleri : " + urun.Aciklama);
                Console.WriteLine("Kalan ürün adedi : " + urun.StokAdedi);
                Console.WriteLine("---------");
            }
            Console.WriteLine("-----Metodlar-----");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yeşil armut",12, 8);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 5);
        }
    }
}
