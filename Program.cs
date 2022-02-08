using System;

namespace hata_tontemleri
{
    class Program
    {
        static void Main(string[] args)
        {try
        {   Console.WriteLine("Birinci sayi giriniz:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("ikinci sayi giriniz:");
            int b = int.Parse(Console.ReadLine());
            int c = a+b ;
            Console.WriteLine("Toplam: " + c);
            Console.WriteLine("Toplama islemi tamamlandi");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("girmis oldugunuz deger bir sayi degil");
            Console.WriteLine(ex.Message);
            Console.WriteLine("Yeniden denemek için program yeniden baslatabilirsiniz");
        }
        finally
        {
            Console.WriteLine("Programi kullandiginiz icin tesekkur ederiz");
        }
        }
    }
}
