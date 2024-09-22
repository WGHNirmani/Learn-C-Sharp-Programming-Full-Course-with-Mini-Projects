using System;

namespace Operations
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //int age = 23;
            double age = 23;

            //age++;
            //age = age + 10;

            // + - * /
            age += 10;
            age -= 10;
            age *= 10;
            age /= 10; // 2.3 -> 2
            Console.WriteLine(age);

            //age--;
            //Console.WriteLine(age);


            string name = "Aba";
            name += " is Programming!";
            //name -= " is Programming!";
            Console.WriteLine(name);

            char ch = 'a';
            ch += 'b';
            Console.WriteLine(ch);

            int i = 0;
            //++i;
            //i++;
            //Console.WriteLine(i);
            Console.WriteLine(++i);
            //Console.WriteLine(i++);
            Console.WriteLine(i);

            Console.ReadLine();
            
        }
    }
}
