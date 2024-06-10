namespace SimpleCalculator_using_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select 1 to ADD, 2 to SUBTRACT, 3 to MULTIPLY, 4 to DIVIDE");
            Console.Write("\nUser input: ");
            int operation = Convert.ToInt16(Console.ReadLine());

            if (operation >=1 && operation <= 4)
            {
                Console.Write("Input first number: ");
                int firstNum = Convert.ToInt16(Console.ReadLine());

                Console.Write("Input second number: ");
                int secondNum = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine(Compute(operation, firstNum, secondNum));
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
        public static string Compute(int operation, int firstNum, int secondNum)
        {
            string print = "";
            int result = 0;

            switch (operation)
            {
                case 1:
                    result = Addition(firstNum, secondNum);
                    print = ($"ADD {firstNum} and {secondNum} the result is {result}");
                    break;

                case 2:
                    result = Subtract(firstNum, secondNum);

                    print = (result !=-1) ?
                        $"SUBTRACT {firstNum} from {secondNum} the result is {result}" 
                        : "Invalid input: The first number should be greater than the second number.";
                    break;

                case 3:
                    result = Multiply(firstNum, secondNum);
                    print = ($"MULTIPLY {firstNum} to {secondNum} the result is {result}");
                    break;

                case 4:
                    double quotient = (Division(firstNum, secondNum));
                    print = (quotient !=-1) ?
                        $"DIVIDE {firstNum} to {secondNum} the result is {quotient}" 
                        : "Invalid input: This results to an error.";
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            return print;
        }
        public static int Addition(int firstNum, int secondNum)
        {
            int sum = firstNum + secondNum;
            return sum;
        }
        public static int Subtract(int firstNum, int secondNum)
        {
            int difference = -1;
            if (firstNum >= secondNum)
            {
                difference = firstNum - secondNum;
            }
            return difference;
            
        }
        public static int Multiply(int firstNum, int secondNum)
        {
            int product = firstNum * secondNum;
            return product;
        }
        public static double Division(int firstNum, int secondNum)
        {
            double quotient = -1;
            if ((firstNum >= secondNum) && (firstNum == 0) || (secondNum >= 1))
            {
                quotient = firstNum / secondNum;
            }
            return quotient;
        }
    }
}
