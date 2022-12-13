using System.Runtime.CompilerServices;

namespace Condıtıon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Makinesi Çalışıyor.");
            Console.WriteLine("Ne işlem yapmak istersin?Toplama için T ,Çıkarma için Ç ,Çarpma için X,Bölme için B yaz");
            var islem = Console.ReadLine();

            Console.WriteLine("Birinci Sayıyı gir");
            var sayi = Console.ReadLine();
            int sayi1 = Convert.ToInt32(sayi);

            Console.WriteLine("İkinci sayıyı gir");
            sayi = Console.ReadLine();
            int sayi2 = Convert.ToInt32(sayi);

            int sonuc = 0;

            if (islem == "T") //yada if(false)
            {
                Console.WriteLine("Toplama İşlemi Yapıyoruz");
                sonuc = sayi1 + sayi2;
                Console.WriteLine(sayi1.ToString() + "+" + sayi2.ToString() + "=" + sonuc.ToString());
                //(Uzun toplama işlemi yöntemi)

            }

            else if (islem == "Ç")

            {
                Console.WriteLine("Çıkartma işlemi yapıyoruz");
                sonuc = sayi1 - sayi2;
                Console.WriteLine("{0}-{1}={2}", sayi1, sayi2, sonuc);
                //Kısa toplama işlemi
            }

            else if (islem == "X")
            {
                Console.WriteLine("Çarpma işlemi yapıyoruz");
                sonuc = sayi1 * sayi2;
                Console.WriteLine("{0}*{1}={2}", sayi1, sayi2, sonuc);
            }
            else if (islem=="B")
            {
                Console.WriteLine("Bölme işlemi yapıyoruz");
                double sonuc2 =(double) sayi1 / sayi2;
                Console.WriteLine("{0}/{1}={2}", sayi1, sayi2, sonuc2);
            }
            else 
            {
                Console.WriteLine("İşlem geçerli değil");
            }
            //Not:"if kullanılıyorsa else inde kulanılması zorunlu değildir ama iyi bir yazılımcı tercihidir."

            Console.ReadLine();


            

        

            //Dikkat et!!!!

            /*Console.WriteLine("Toplama İşlemi Yapıyoruz");
            Console.WriteLine("Birinci Sayıyı gir");
            var sayi = Console.ReadLine();
            int sayi1 = Convert.ToInt32(sayi);

            /*Console.WriteLine("İkinci sayıyı gir");
            sayi = Console.ReadLine();
            int sayi2 = Convert.ToInt32(sayi);

            sayi1 = sayi1 + sayi2;   // =    sayi1 += sayi2;
            Console.WriteLine("Sonuc={0}", sayi1);


            //Arttırma işlemi
            sayi1++;

            //sayi1=sayi1+sayi2;
            sayi1 += 20;
            sayi1--;

            Console.WriteLine("Sonuc={0}", sayi1);*/
        }
    }
}