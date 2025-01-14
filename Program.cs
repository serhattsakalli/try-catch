using System;

namespace try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz:");
            int sayi =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("girdiğiniz sayı :"+sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("hata : "+ex.Message);
               
            }
            /*finally
            {
                Console.WriteLine("işlem tamamlandı");
            }*/
            try
            {
               // int a=int.Parse(null);
               // int a=int.Parse("test");
                int a=int.Parse("-20000000000");
                
            }catch(ArgumentNullException ex)
            {
            Console.WriteLine("boş değer girdiniz");
            Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
            Console.WriteLine("veri tipi uygun değildir");
            Console.WriteLine(ex); 
            }catch(OverflowException ex)
            {
            Console.WriteLine("değer aşımı");
            Console.WriteLine(ex); 
            }
            finally{Console.WriteLine("işlem başarılı");}
            Console.ReadKey();
            
        }
    }
}