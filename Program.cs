﻿namespace hendesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
        yenidendaxilet:
            Console.WriteLine("Esas Menu:");
            Console.WriteLine("1.Sahenin Hesablanmasi:");
            Console.WriteLine("2.Perimetr hesablanması:");
            Console.WriteLine("3.Çıxış:");
            int exitNumber = Convert.ToInt32(Console.ReadLine());
            if (exitNumber > 3)
            {
                goto yenidendaxilet;
            }
            //3.Cixis:
            if (exitNumber == 3)
            {
                Console.WriteLine("Proqramdan Cixilir>");
            }
            if (exitNumber == 1 || exitNumber == 2)
            {
                Console.WriteLine("\nFİQUR SEÇİMİ ALT MENU");
                Console.WriteLine("1. Kvadrat");
                double square;
                Console.WriteLine("2. Düzbucaqlı");
                double rectangular;
                Console.WriteLine("3. Üçbucaq");
                double triangle;
                Console.WriteLine("4. Çevrə");
                double circle;
                Console.WriteLine("5. Əsas Menyu");
                Console.Write("\nSeçiminizi daxil edin: ");
                int secim = Convert.ToInt32(Console.ReadLine());
                double sahe = 0;
                double perimetr = 0;
                double pi = Math.PI;
                switch (secim)
                {
                    case 1:
                    case1:
                        Console.WriteLine("Kvadrarin Terefini  daxil et");
                        double teref = Convert.ToDouble(Console.ReadLine());
                        sahe = teref * teref;
                        perimetr = teref * 4;
                        Console.WriteLine("Kvadratin sahesi:" + sahe);
                        Console.WriteLine("Kvadratin Terefi:" + perimetr);
                        break;
                    case 2:
                        Console.WriteLine("Duzbucaqlinin enini daxil et:");
                        double en = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Duzbucaqlinin uzunlugunu daxil et:");
                        double uzunluq = Convert.ToDouble(Console.ReadLine());
                        sahe = en * uzunluq;
                        perimetr = 2 * (en + uzunluq);
                        Console.WriteLine("duzbucaqlinin Sahesi:" + sahe);
                        Console.WriteLine("Duzbucaqlinin Perimetri:" + perimetr);
                        break;
                    case 3:
                        Console.WriteLine("Ucbucagin uzunlugunu daxil edin:");
                        double ucbucaqUzunlugu = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ucbucagin Hundurluyunu daxil edin:");
                        double ucbucaqHundurluyu = Convert.ToDouble(Console.ReadLine());
                        sahe = (ucbucaqHundurluyu * ucbucaqUzunlugu) / 2;
                        perimetr = ucbucaqUzunlugu * 3;
                        Console.WriteLine("Ucbucagin Sahesi:" + sahe);
                        Console.WriteLine("Ucbucagin Perimetri:" + perimetr);
                        break;
                    case 4:
                        Console.WriteLine("Çevrənin Radiusunu daxil edin:");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        sahe = pi * radius * radius;
                        perimetr = 2 * pi * radius;
                        Console.WriteLine("Cevrenin Sahesi:" + sahe);
                        Console.WriteLine("Cevrenin Uzunlugu:" + perimetr);
                        break;
                    case 5:
                        goto yenidendaxilet;
                        break;

                }


            }
        }
    }
}
