﻿using System;

namespace methods_datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());

            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(1));
            Console.WriteLine(DateTime.Now.AddYears(10));

            //DAteTime Format
            Console.WriteLine(DateTime.Now.ToString("dd"));//24
            Console.WriteLine(DateTime.Now.ToString("ddd"));//Sat
            Console.WriteLine(DateTime.Now.ToString("dddd"));//Saturday

            Console.WriteLine(DateTime.Now.ToString("MM"));//01
            Console.WriteLine(DateTime.Now.ToString("MMM"));//Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM"));//April

            Console.WriteLine(DateTime.Now.ToString("yy"));//22
            Console.WriteLine(DateTime.Now.ToString("yyyy"));//2022


            // Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25));//25
            Console.WriteLine(Math.Sin(10));

            Console.WriteLine(Math.Ceiling(22.3));//23 double üzerinde çalışır. kendinden büyük en küçük tam sayıyı getirir.
            Console.WriteLine(Math.Round(22.3));//22 En Yakın Tam sayıyı getirir
            Console.WriteLine(Math.Floor(22.20));//22 Kendinden küçük en büyük tam sayı getirir
        }
    }
}
