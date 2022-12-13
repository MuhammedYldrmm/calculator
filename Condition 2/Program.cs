namespace Condition_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Makinesi Çalışıyor.");
            Console.WriteLine("Ne işlem yapmak istersin?Toplama için T ,Çıkarma için Ç ,Çarpma için X,Bölme için B yaz");
            var islem = Console.ReadLine();
           

            bool toplamaislemiMi = (islem == "T" || islem == "t");
            bool cıkarmaislemiMi = islem == "Ç" || islem == "ç"||islem=="C"||islem=="c";
            bool carpmaislemiMi = islem == "X" || islem == "x";
            bool bölmeislemiMi = islem == "B" || islem == "b";

            if (toplamaislemiMi || cıkarmaislemiMi || carpmaislemiMi || bölmeislemiMi)
            {

                int sayi1 = 0;
                int sayi2 = 0;
                int sonuc = 0;


                Console.WriteLine("Birinci Sayıyı gir");
                var sayi = Console.ReadLine();
                sayi1 = Convert.ToInt32(sayi);

                Console.WriteLine("İkinci sayıyı gir");
                sayi = Console.ReadLine();
                sayi2 = Convert.ToInt32(sayi);

                if (toplamaislemiMi)
                {
                    Console.WriteLine("Toplama İşlemi Yapıyoruz");
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine(sayi1.ToString() + "+" + sayi2.ToString() + "=" + sonuc.ToString());
                    //(Uzun toplama işlemi yöntemi)

                }
                if (cıkarmaislemiMi)
                {
                    Console.WriteLine("Çıkartma işlemi yapıyoruz");
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine("{0}-{1}={2}", sayi1, sayi2, sonuc);
                    //Kısa toplama işlemi
                }

                if (carpmaislemiMi)
                {
                    Console.WriteLine("Çarpma işlemi yapıyoruz");
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine("{0}*{1}={2}", sayi1, sayi2, sonuc);
                }
                if (bölmeislemiMi)
                {
                    Console.WriteLine("Bölme işlemi yapıyoruz");
                    decimal sonuc2 = (decimal)sayi1 / sayi2;
                    Console.WriteLine("{0}/{1}={2}", sayi1, sayi2, sonuc2);
                }
                else
                {
                    Console.WriteLine("İşlem geçerli değil");
                }
                //Not:"if kullanılıyorsa else inde kulanılması zorunlu değildir ama iyi bir yazılımcı tercihidir."
            }
            Console.ReadLine();

        }
    }
}