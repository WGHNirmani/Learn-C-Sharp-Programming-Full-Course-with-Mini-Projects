using System;

namespace DataTypes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //int x = 10;
            //int y = 20;
            //int z = 30;

            int x = 10, y = 20, z = 30;

            string textAge = "-23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            string textBigNumber = "-900000000";
            long bigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(bigNumber);


            string textNegative = "55.2";
            double negative = Convert.ToDouble(textNegative);
            Console.WriteLine(negative);

            string textPrecision = "5.000001";
            float precision = Convert.ToSingle(textPrecision);
            Console.WriteLine(precision);

            string textMoney = "14.99";
            decimal money = Convert.ToDecimal(textMoney);
            Console.WriteLine(money);
         

            Console.ReadLine();
        }
    }
}
