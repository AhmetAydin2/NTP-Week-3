// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");




//Forreach Döngüsü ile Liste Elemanlarını yazdırma (ArrayList)

namespace Koleksiyonlar
{
    class Dizi
    {
        static void Main(string[] args)
        {
            ArrayList nums= new ArrayList();
            nums.Add(10);
            nums.Add(20);
            nums.Add(30);
            nums.Add(40);


            foreach (int i in nums)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}

//Hazır metod kullanımı [Split()]

namespace Koleksiyonlar2
{
    class Metod
    {
        static void Main()
        {
            Console.WriteLine("Bir cümle giriniz");
            string sentence=Console.ReadLine();
            int words = sentence.Split(' ').Length;
            Console.WriteLine("Kelime sayısı:" + words);

        }

    }
}


   
//ArrayList ile Alfabetik sıralama

namespace Koleksiyonlar3
{
    class Dizi2
    {
        static void main()
        {
            ArrayList nums2 = new ArrayList();
            Console.WriteLine("Sayılar giriniz");
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            string num3 = Console.ReadLine();

            nums2.Add(int.Parse(num1));
            nums2.Add(int.Parse(num2));
            nums2.Add(int.Parse(num3));

            nums2.Sort();

            Console.WriteLine(nums2);
        }
    }

}



//For döngüsü ile Fibonacci Serisi

namespace Fibonacci
{
    class Fibo
    {
        static void Main()
        {
            int first = 0;
            int second = 1;

            Console.WriteLine("Dizinin kaç adet sayısını görmek istersiniz?");
            int next = int.Parse(Console.ReadLine());

            for (int i = 0; i < next; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(first);
                }
                else if (i == 1)
                {
                    Console.WriteLine(second);
                }
                else
                {
                    next = (first + second);
                    Console.WriteLine(next);
                    first = second;
                    second = next;

                }
            }
        }  
    }
}

//While döngüsü ile Tahmin Oyunu

namespace Tahmin
{
    class tahmin
    {
        static void Main()
        {
            int desirednum = 25;

            Console.WriteLine("Bir sayı giriniz");
            int usernum = int.Parse(Console.ReadLine());

            while (usernum != desirednum)
            {
                Console.WriteLine("Yanlış sayı girdiniz");
                Console.WriteLine("Farklı bir sayı giriniz");
                usernum = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Tebrikler! Sayıyı buldunuz.");
        }
    }
}

//Do While Döngüsü ile Basit Hesap Makinesi

namespace HesapMakinesi
{
    class HesapMKN
    {
        static void Main()
        {
            double num1;
            double num2;
            double result;
            string operation;


            do
            {
                Console.WriteLine("İşlem türünü giriniz(toplama,çıkarma,çarpma,bölme) veya 'Çıkış' giriniz");
                operation = Console.ReadLine();

                if (operation == "Çıkış") ;
                break;


                Console.WriteLine("Birinci sayıyı giriniz");
                num1 = Console.ToDouble(Console.ReadLine());

                Console.WriteLine("İkinci sayıyı giriniz");
                num2 = Console.ToDouble(Console.ReadLine());


                if (operation == "toplama")
                {
                    result = num1 + num2;
                }
                else if (operation == "çıkarma")
                {
                    result = num1 - num2;
                }
                else if (operation == "çarpma")
                {
                    result = num1 * num2;
                }
                else if (operation == "bölme")
                {
                    if (num2 == 0)
                    {
                        Console.WriteLine("Sıfıra bölme hatası!");
                        continue;
                    }
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Geçersiz işlem!");
                    continue;
                }
            } while (operation != "Çıkış");
          
        }
    }
}



//For ve While Döngüsü ile Sayı Toplama Oyunu




namespace Toplama
{
  class Toplama
    {
        static void Main() 
        {
            int n;
            double total=0;

            while (true)
            {
                Console.WriteLine("Kaç adet sayı gireceksiniz");
                n = Convert.ToInt32(Console.ReadLine());


                for(int i = 1;i<= n;i++)
                {
                    Console.WriteLine("{i}.sayıyı giriniz");
                    double Num =Convert.ToDouble(Console.ReadLine());

                    total =total + Num;
                }

                Console.WriteLine("Sayıların toplamı:"+total);

            }
        }
    }

}
