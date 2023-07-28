﻿

namespace SolveXpert
{
    public class SolveXpert
    {
        static void Main(String[] args)
        {

            while(true)
            {
                string? choice;
                choice = menuOption();

                //------My First Solution
                if (choice == "1" )
                {
                    ///------ArmStrong Number
                    Console.Clear();
                    Console.WriteLine("Enter a Number");
                    int input, sum = 0, cube, temp;
                    input = Convert.ToInt32(Console.ReadLine());
                    temp = input;
                    while(temp > 0 )
                    {
                        cube = temp % 10;
                        sum = sum + (cube * cube * cube);
                        temp = temp / 10;
                    }
                    if (sum==input)
                    {
                        Console.WriteLine("Entered Number is Armstrong");
                    }
                    else
                    {
                        Console.WriteLine("Entered Number is not Armstrong");
                    }
                }

                //------My Second Solution
                else if (choice == "2" ) {
                    ///------Reverse a String
                    Console.Clear();
                    Console.WriteLine("Enter a String to be reversed.");
                    string abc = Console.ReadLine();
                    char[] abcq = abc.ToCharArray();
                    string reverse = "";
                    for (int i = abc.Length - 1; i >= 0; i--)
                    {
                        char c = abcq[i];
                        reverse = reverse + c;
                    }
                    Console.WriteLine(reverse.ToString());
                }
            }


        }

        //------Menu Option
        public static string? menuOption()
        {
            //Console.Clear();

            Console.WriteLine("1: Armstrong Program");
            Console.WriteLine("2: Reverse a String");
            Console.WriteLine("3: Palindrome Checker");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");
            Console.WriteLine("7");
            return Console.ReadLine();

        }
    }
}

