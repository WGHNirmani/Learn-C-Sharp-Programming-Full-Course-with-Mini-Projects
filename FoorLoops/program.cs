using System;

namespace For
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Console.WriteLine("Hi");
            Console.WriteLine("Hi");
            Console.WriteLine("Hi");
            Console.WriteLine("Hi");
            Console.WriteLine("Hi");*/

            Console.Write("What do you want to repeat?: ");
            string message = Console.ReadLine();

            Console.Write("How many times do you want to repeat it?: ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            if (loopCounter <= 0) // >= 1
            {
                Console.WriteLine("Sorry, plase enter a value above 0");
            }
            else
            {
                for (int i = 0; i < loopCounter; i++)
                {
                    //Console.WriteLine("Hi");
                    Console.WriteLine(message);
                }
            }

            /*for (int i = 0; i< 5; i++)
            {
                Console.WriteLine("Hi");
            }*/

            /*for(int i = 0; i<= 10; i += 2)
            {
                Console.WriteLine(i);
            }*/

            Console.ReadLine();
        }
    }
}

