using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Basic
{
    internal static class TextToNumericConversion
    {
        public static void Run() 
        {
            string textAge = "29";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            string textBigNumber = "100000000";
            long bigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(bigNumber);

            string textNegetive = "-55.2";
            double negetive = Convert.ToDouble(textNegetive);
            Console.WriteLine(negetive);

            string textPrecision = "5.000001";
            float precision = Convert.ToSingle(textPrecision);
            Console.WriteLine(precision);

            string textMoney = "15.5";
            decimal money = Convert.ToDecimal(textMoney);
            Console.WriteLine(money);
        }
    }
}
