using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            ogrBilgi ogr1 = new ogrBilgi();
            ogr1.isimSoyisim = "Büşra Şafak";
            ogr1.cepNo = "555xxxxxxx";

            ogrBilgi ogr2 = new ogrBilgi();
            ogr2.isimSoyisim = "Kerem KORKMAZ";
            ogr2.cepNo = "555yyyyyyy";

            ogrBilgi ogr3 = new ogrBilgi();
            ogr3.isimSoyisim = "Gökay Selçuk KORKMAZ";
            ogr3.cepNo = "555zzzzzzz";

            ogrBilgi[] ogrenciBilgi = new ogrBilgi[] { ogr1, ogr2, ogr3 };

            foreach (ogrBilgi aaa in ogrenciBilgi)
            {
                Console.WriteLine(aaa.isimSoyisim+ " : " + aaa.cepNo);
            }

        }
    }
    class ogrBilgi
    {
        public string isimSoyisim { get; set; }
        public string cepNo { get; set; }
    }
}
