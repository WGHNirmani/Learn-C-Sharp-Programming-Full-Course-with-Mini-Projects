using System;

namespace VarKeyword
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //int age = -23;
            var age = 23;
            Console.WriteLine(age);


            //long bigNumber = 900000000L;
            var bigNumber = 90000;
            Console.WriteLine(bigNumber);



            //double negative = -55.2D;
            var negative = -55.2D;
            Console.WriteLine(negative);


            //float precision = 5.000001F;
            var precision = 5.000001F;
            Console.WriteLine(precision);


            //decimal money = 14.99M;
            var money = 14.99M;
            Console.WriteLine(money);

            var name = "Aba";
            Console.WriteLine(name);

            var letter = 'a';
            Console.WriteLine(letter);

            Console.ReadLine();
        }
    }
}

