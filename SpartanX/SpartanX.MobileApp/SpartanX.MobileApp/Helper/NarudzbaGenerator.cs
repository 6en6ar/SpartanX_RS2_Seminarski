using System;
using System.Collections.Generic;
using System.Text;

namespace SpartanX.MobileApp.Helper
{
    public class NarudzbaGenerator
    {
        private static readonly Random _random = new Random();
        public static string Generator(int stari)
        {
            string novaNarudzba = "BN";
            int number = RandomNumber(1, 10000);
            number += stari;
            novaNarudzba += number;
            return novaNarudzba;
        }
        public static int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
    }
}
