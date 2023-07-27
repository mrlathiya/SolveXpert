

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
                    
                }
            }


        }

        //------Menu Option
        public static string? menuOption()
        {
            //Console.Clear();

            Console.WriteLine("1: Armstrong Program");
            Console.WriteLine("2: Reverse a String");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");
            Console.WriteLine("7");
            return Console.ReadLine();

        }
    }
}

