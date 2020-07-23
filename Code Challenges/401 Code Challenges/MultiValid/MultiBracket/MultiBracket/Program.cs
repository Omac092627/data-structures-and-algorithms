using System;

namespace MultiBracket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool MultiBracketValidation(string input)
        {
            int leftParen = 0;
            int rightParen = 0;
            int leftCurly = 0;
            int rightCurly = 0;
            int leftSquare = 0;
            int rightSquare = 0;
            foreach (char item in input)
            {
                if (input == "(")
                {
                    leftParen++;
                }
                else if (input == ")")
                {
                    rightParen++;
                }
                else if (input == "{")
                {
                    leftCurly++;
                }
                else if (input == "}")
                {
                    rightCurly++;
                }
                else if (input == "[")
                {
                    leftSquare++;
                }
                else if (input == "]")
                {
                    rightSquare++;
                }

                if ((leftParen == rightParen) && (leftCurly == rightCurly) && (leftSquare == rightSquare))
                {
                    return true;
                }
            }
            return false;

        }

    }
}
