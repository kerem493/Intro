using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Kerem KORKMAZ", "Gökay Selçuk KORKMAZ", "Mehmet KORKMAZ", "Nezire KORKMAZ" };
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(isimler[i]);
            }

            Console.WriteLine("for döngüsü sonu...");


            foreach (string isim in isimler)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
