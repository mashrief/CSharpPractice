namespace CSharpPractice.Basic
{
    internal static class BasicOperators
    {
        public static void Run()
        {
            int num1 = 100, num2 = 200;
            double num3 = 1, num4 = 2, num5 = 3, num6 = 4, num7 = 5;

            // Arithmetic Operators

            Console.WriteLine(num1 + num2);
            Console.WriteLine(num2 - num1);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num2 / num1);
            Console.WriteLine(num1 % 2);

            // Increment & Decrement Operators

            Console.WriteLine(num1++);
            Console.WriteLine(num1);
            Console.WriteLine(++num2);
            Console.WriteLine(num2);

            // Assignment Operators

            num3 += 10;
            Console.WriteLine(num3);
            num4 -= 2;
            Console.WriteLine(num4);
            num5 *= 5;
            Console.WriteLine(num5);
            num6 /= 3;
            Console.WriteLine(num6);
            num7 %= 2;
            Console.WriteLine(num7);

            string name = "Mashrief";
            name += " Bin Zulfiquer";
            Console.WriteLine(name);

            char ch = 'x';
            ch += 'y';
            Console.WriteLine(ch);
        }
    }
}
