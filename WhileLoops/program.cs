using System;

namespace While
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }*/

            /*int i = 0;

            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }*/

            Console.WriteLine("Enter the first number: ");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);

            Console.WriteLine("Enter the second number: ");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);
            Console.WriteLine();

            int answer = numberA * numberB;
            int actualanswer = 0;

            Console.Write("Whats the Value of " + numberA + " x " + numberB + " ? ");
            Console.WriteLine();


            /*while (answer != actualanswer)
            {
                Console.Write("Enter your answer: ");
                string answerInput = Console.ReadLine();
                actualanswer = Convert.ToInt32(answerInput);

                if (answer != actualanswer) 
                {
                    Console.WriteLine("Close but it was wrong!");
                    Console.WriteLine();
                }
            }*/

            do
            {
                Console.Write("Enter your answer: ");
                string answerInput = Console.ReadLine();
                actualanswer = Convert.ToInt32(answerInput);

                if (answer != actualanswer)
                {
                    Console.WriteLine("Close but it was wrong!");
                    Console.WriteLine();
                }
            } while (answer != actualanswer);

            Console.WriteLine("Well done!");

            Console.ReadLine();
        }
    }
}

