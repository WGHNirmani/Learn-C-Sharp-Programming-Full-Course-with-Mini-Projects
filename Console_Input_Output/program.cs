using System;

namespace ConsoleIO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello my name is Hirunika!");

            //Console.WriteLine("Enter your name: ");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            //Console.WriteLine(name);

            Console.Write("Enter your age: ");
            //string age = Console.ReadLine();
            //string ageInput = Console.ReadLine();
            //int age = Convert.ToInt32(ageInput);
            int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(age);

            //Console.Write("Your name is ");
            //Console.Write(name);
            //Console.Write(" and your age is ");
            //Console.Write(age);

            Console.WriteLine();
            Console.WriteLine("Your name is " + name + " and your age is " + age);

            Console.ReadLine();
        }
    }
}
