using System;

namespace HataYonetimi // Note: actual namespace depends on the project name.
{
     class Program
    {
        static void Main(string[] args)
        {
           try
           {
               Console.WriteLine("Bir sayı giriniz");
               int sayi = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Girdiğiniz sayı : {0}", sayi);
           }
           catch (Exception ex)
           {
               
               Console.WriteLine("Hata :" +ex.Message.ToString());
           }
           finally
           {
               Console.WriteLine("İşlem tamamlandı.");
           }

           try
           {
               //parse string değerleri int e çevirmek için kullanılır.
               //int a = int.Parse(null);
               int b = int.Parse("-20000000000");
           }
           catch (ArgumentNullException ex)
           {
               Console.WriteLine("Boş değer girdiniz");
               Console.WriteLine(ex);
           }
           catch (OverflowException ex)
           {
               Console.WriteLine("Kapsam dışı bir değer girildi.");
               Console.WriteLine(ex);
           }
           finally
           {
               Console.WriteLine("İşlem başarı ile tamamlandı.");
           }

        }
    }
}