namespace dateIdentifier_using_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] month = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};

            string[] evenDays = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
                "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen", "Twenty",
                "Twenty-one", "Twenty-two", "Twenty-three", "Twenty-four", "Twenty-five", "Twenty-six", "Twenty-seven", "Twenty-eight",
                "Twenty-nine", "Thirty", "Thirty-one" };


            int monthNumber;
            int dayNumber;

            Console.Write("Input month number: ");
            monthNumber = Convert.ToInt16(Console.ReadLine());

            Console.Write("Input day number: ");
            dayNumber = Convert.ToInt16(Console.ReadLine());

            if ((monthNumber >= 1 && monthNumber <= 12) && (dayNumber >= 1 && dayNumber <= 31))
            {
                string message = month[monthNumber-1];
                string result = evenDays[dayNumber-1];
                Console.WriteLine($"The date is {message} {result}.");
            }
            else 
            {
                Console.WriteLine("Invalid input");
            }


        }
    }
}
