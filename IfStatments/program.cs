using System;

namespace ConsoleIO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            //Console.Write("Enter your age: ");
            //string ageInput = Console.ReadLine();
            //int age = Convert.ToInt32(ageInput);

            //Console.WriteLine();
            //Console.WriteLine("Your name is " + name + " and your age is " + age);

            // == > >= <= != || &&
            //if(ageInput == "18")
            //{
            //    Console.WriteLine("You are 18");
            //}

            //if (age == 18)
            //{
            //    Console.WriteLine("You are 18");
            //}

            /*if (age >= 18 && age <= 25) // 18 > 18
            {
                Console.WriteLine("You are between 18 and 25");
            }
            else if(age >= 26)
            {
                Console.WriteLine("You are 26 or Older");
            }*/

            //if (age < 0 || age > 150)
            //{
            //    Console.WriteLine("Invalid age!");
            //}
            //else
            //{
            //    //Console.WriteLine("Valid age!");
            //    if (age >= 18 && age <= 25) // 18 > 18
            //    {
            //        Console.WriteLine("You are between 18 and 25");
            //    }
            //    else if (age >= 26)
            //    {
            //        Console.WriteLine("You are 26 or Older");

            //    }
            //}

            Console.WriteLine("Enter the first number: ");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);

            Console.WriteLine("Enter the second number: ");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);

            int answer = numberA * numberB;

            Console.Write("Value of " + numberA + " x " + numberB + " : ");
            string answerInput = Console.ReadLine();
            int actualanswer = Convert.ToInt32(answerInput);

            if(answer == actualanswer) //!=
            {
                Console.WriteLine("Well done!");
            }
            else
            {
                Console.WriteLine("Close but it was wrong!");
            }

            Console.ReadLine();
        }
    }
}
