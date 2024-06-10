namespace evaluateGrades_using_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will compute the average of 2 grades");
            Console.Write("\nInput your 1st grade: ");
            double grade1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input your 2nd grade: ");
            double grade2 = Convert.ToDouble(Console.ReadLine());


            if ((grade1 >= 1 && grade1 <= 100) && (grade2 >= 1 && grade2 <= 100))
            {
                double aveGrade = Compute((double)grade1, (double)grade2);
                string print = Remarks((double)grade1, (double)grade2, aveGrade);
                Console.WriteLine(print);
            }
            else
                Console.WriteLine("Invalid grade input");
        }
        public static double Compute(double grade1, double grade2)
        {
            double aveGrade = ((grade1 + grade2) / 2);
            return aveGrade;
        }
        public static string Remarks(double grade1, double grade2, double aveGrade)
        {
            string message = "";
            if (aveGrade > 90 && aveGrade <= 100)
            {
                message = Excellent(aveGrade);
            }

            else if (aveGrade > 80 && aveGrade <= 90)
            {
                message = VeryGood(aveGrade);
            }

            else if (aveGrade > 70 && aveGrade <= 80)
            {
                message = Good(aveGrade);
            }

            else if (aveGrade > 50 && aveGrade <= 70)
            {
                message = Fair(aveGrade);
            }

            else if (aveGrade <= 50)
            {
                message = Failed(aveGrade);
            }
            return message;
        }
        public static string Excellent(double aveGrade)
        {
            string remarks = ($"\nYour average grade is {aveGrade}, EXCELLENT!");
            return remarks;
        }
        public static string VeryGood(double aveGrade)
        {
            string remarks = ($"\nYour average grade is {aveGrade}, VERY GOOD!");
            return remarks;
        }
        public static string Good(double aveGrade)
        {
            string remarks = ($"\nYour average grade is {aveGrade}, GOOD!");
            return remarks;
        }
        public static string Fair(double aveGrade)
        {
            string remarks = ($"\nYour average grade is {aveGrade}, FAIR!");
            return remarks;
        }
        public static string Failed(double aveGrade)
        {
            string remarks = ($"\nYour average grade is {aveGrade}, FAILED!");
            return remarks;
        }
    }
}
