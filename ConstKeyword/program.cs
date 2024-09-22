using System;

namespace Constants
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int vat = 20;
            const double percentVAT = vat / 100D;

            int balance = 1000;

            Console.WriteLine(balance * (vat / 100D));
            Console.WriteLine(balance * percentVAT);

            const string version = "v1.0";

            //Console.WriteLine(20);
            Console.WriteLine(vat);

            //vat = 10;

            Console.ReadLine();
        }
    }
}
