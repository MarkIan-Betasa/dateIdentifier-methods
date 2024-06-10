namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // add Days program
            // input a day number
            // program will ask the user to input another number to be added to the day number
            // program will compute and display the final day.

            Console.WriteLine("" +
                "Choose a day number: " +
                "\n1 is Monday" +
                "\n2 is Tuesday" +
                "\n3 is Wednesday" +
                "\n4 is Thursday" +
                "\n5 is Friday" +
                "\n6 is Saturday" +
                "\n7 is Sunday" +
                "\n");

            // asking for input I
            Console.Write("Enter day number: ");
            int startingday = Convert.ToInt16(Console.ReadLine());

            //validation checking 
            if (startingday >= 1 && startingday <= 7)
            {
                Console.WriteLine(InitialDay(startingday));

                // asking for input II
                Console.Write("\nEnter number of days to be added: ");
                int addedday = Convert.ToInt16(Console.ReadLine());

                if (addedday >= 0)
                {
                    //computation 
                    Console.WriteLine(Computation(startingday, addedday));
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadKey();
        }
        public static string InitialDay(int startingday)
        {
            string print = "";
            switch (startingday)
            {
                case 1:
                    print = "The day is MONDAY";
                    break;

                case 2:
                    print = "The day is TUESDAY";
                    break;

                case 3:
                    print = "The day is WEDNESDAY";
                    break;

                case 4:
                    print = "The day is THURSDAY";
                    break;

                case 5:
                    print = "The day is FRIDAY";
                    break;

                case 6:
                    print = "The day is SATURDAY";
                    break;

                case 7:
                    print = "The day is SUNDAY";
                    break;

                default:
                    print = "Indalid input";
                    break;
            }
            return print;
        }
        public static string Computation(int startingday, int addedday)
        {
            int computedday = (startingday + addedday) % 7;
            string print = "";

            switch (computedday)
            {
                case 0:
                    print = "The new day is SUNDAY";
                    break;

                case 1:
                    print = "The new day is MONDAY";
                    break;

                case 2:
                    print = "The new day is TUESDAY";
                    break;

                case 3:
                    print = "The new day is WEDNESDAY";
                    break;

                case 4:
                    print = "The new day is THURSDAY";
                    break;

                case 5:
                    print = "The new day is FRIDAY";
                    break;

                case 6:
                    print = "The new day is SATURDAY";
                    break;

                default:
                    print = "Invalid input";
                    break;
            }
            return print;
        }
    }
}
