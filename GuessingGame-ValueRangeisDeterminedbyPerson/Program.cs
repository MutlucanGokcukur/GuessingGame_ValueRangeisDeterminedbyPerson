using System;

namespace GuessingGame_ValueRangeisDeterminedbyPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen Tahmin Oyunu için 1'den Başlayan Aralığın Son Sayısını Giriniz: ");
            int aralık = Convert.ToInt32(Console.ReadLine());

            int random = 0;
            Random rnd = new Random();
            random = rnd.Next(1, aralık);
            int deneme = 1;
            do
            {
                Console.Write("Tahmininizi Giriniz: ");
                int tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin < random)
                {
                    Console.WriteLine("Girdiğiniz Değerden Daha Büyük Bir Değer Tahmin Ediniz");
                    deneme += 1;
                }
                else if (tahmin > random)
                {
                    Console.WriteLine("Girdiğiniz Değerden Daha Küçük Bir Değer Tahmin Ediniz");
                    deneme += 1;
                }
                else
                {
                    Console.WriteLine(deneme + ". Tahminde Doğru Sayıyı Buldunuz....\nTebrikler");
                    break;
                }
            } while (true);

            //while (true)
            //{
            //    Console.Write("Tahmininizi Giriniz: ");
            //    int tahmin = Convert.ToInt32(Console.ReadLine());

            //    if (tahmin < random)
            //    {
            //        Console.WriteLine("Girdiğiniz Değerden Daha Büyük Bir Değer Tahmin Ediniz");
            //        deneme += 1;
            //    }
            //    else if (tahmin > random)
            //    {
            //        Console.WriteLine("Girdiğiniz Değerden Daha Küçük Bir Değer Tahmin Ediniz");
            //        deneme += 1;
            //    }
            //    else
            //    {
            //        Console.WriteLine(deneme + ". Tahminde Doğru Sayıyı Buldunuz....\nTebrikler");
            //        break;
            //    }
            //}
            Console.ReadLine();
        }
    }
}
