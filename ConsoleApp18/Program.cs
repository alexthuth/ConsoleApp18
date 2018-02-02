namespace ConsoleApp18
{
    using System;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {

            int[] numberArray = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            
            int indexTest = 9;

            Console.WriteLine("Index:" + numberArray[indexTest]);
            Console.WriteLine("Index with --:" + numberArray[indexTest--]);
            Console.WriteLine("Index: " + numberArray[indexTest]);




        }

        public static int AddTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int SubtractTwoNumbers(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int CombineTwoNumbers(int num1, int num2)
        {

            int concatNumber = int.Parse(num1.ToString() + num2.ToString());
            return concatNumber;
        }

        public static string IntToBase3(int number)
        {



        }

        public static StringBuilder DecimalToArbitrarySystem(int intNumber)
        {
            const int BitsInLong = 64;
            const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

           

            int index = BitsInLong - 1;
            long currentNumber = intNumber;
            char[] charArray = new char[BitsInLong];

            while (currentNumber != 0)
            {
                int remainder = (int)(currentNumber % 3);
                charArray[index--] = Digits[remainder];
                currentNumber = currentNumber / 3;
            }

            StringBuilder result = new StringBuilder(charArray, index + 1, BitsInLong - index - 1);

            if (result.Length < 10)
            {
                int difference = 10 - result.Length;

            }
        // To move forward, you need to see if the resulting number is less than 10 digits, create a new substring of the right amount 
        // of 0s, then append the result as the substring and output that string
            return result;
        }

    }
}
