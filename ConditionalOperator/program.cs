using System;

namespace ConditionalOperator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int age = -10;

            /*if(age >= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("InValid");
            }*/

            // condition ? true : false
            string result = age >= 0 ? "valid" : "Invalid";
            Console.WriteLine(result);
            //Console.WriteLine(age >= 0 ? "valid" : "Invalid");

            Console.ReadLine();
        }
    }
}
