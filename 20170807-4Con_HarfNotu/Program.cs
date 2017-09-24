using System;

namespace _20170807_4Con_HarfNotu
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch case kullanılsın. 0-100 arası not girilsin
            /*
             * 0-20 : FF
             * 21-45 : CC
             * 46-70 : BB
             * 71-100 : AA
             * 
             * olacak şekilde geri döndürsün
             */
            int not, anahtar=0;

            Console.Write("0-100 arasında bir not giriniz : ");
            not = Convert.ToInt32(Console.ReadLine());
            if (not >= 0 & not <= 20)
            {
                anahtar = 1;
            }
            else if (not >= 21 & not <= 45)
            {
                anahtar = 2;
            }
            else if (not >= 46 & not <= 70)
            {
                anahtar = 3;
            }
            else if (not >= 71 & not <= 100)
            {
                anahtar = 4;
            }

            switch (anahtar)
            {
                case 1:
                    Console.Write("FF"); break;
                case 2:
                    Console.Write("CC"); break;
                case 3:
                    Console.Write("BB"); break;
                case 4:
                    Console.Write("AA"); break;
                default: Console.Write("NOT 0-100 ARASI OLACAK"); break;
            }

            Console.Read();
        }
    }
}
