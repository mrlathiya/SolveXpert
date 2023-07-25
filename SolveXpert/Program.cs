

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
                    int input1, sum = 0, temp, cube, temp2;
                    input1 = Convert.ToInt32(Console.ReadLine());
                    temp2 = input1;
                    while(temp2 > 0 )
                    {
                        temp = temp2%10;
                        sum = sum + (temp * temp * temp);
                        temp2 = temp2 / 10;
                    }
                    if (sum==input1)
                    {
                        Console.WriteLine("is Armstrong");
                    }
                    else
                    {
                        Console.WriteLine("not Armstrong");
                    }
                }
            }


        }

        //------Menu Option
        public static string? menuOption()
        {
            //Console.Clear();

            Console.WriteLine("1: Armstrong Program");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            return Console.ReadLine();

        }
    }
}

