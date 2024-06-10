using System.Security.Cryptography.X509Certificates;

namespace AgeIdentifier_using_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your birth year: ");
            int birthYear = Convert.ToInt16(Console.ReadLine());

            //computation
            int age = 2024 - birthYear;

            // input validation
            if (age >= 0 && birthYear >= 0)
            {
                // generate generation stage
                string generation = (GenGenerate(birthYear));

                // generate age stage
                string ageStage = (AgeGenerate(age));

                // display (age, generation, age stage)
                Console.WriteLine($"{age} years old, {generation}, {ageStage}");
            }
            else
            {
                // invalid input
                Console.WriteLine("Invalid input");
            }
            Console.ReadKey();
        }
        public static string GenGenerate(int birthYear)
        {
            string generation = "";
            if (birthYear >= 2010 && birthYear <= 2025)
            {
                generation = "Gen Alpha";
            }
            else if (birthYear >= 1997 && birthYear <= 2009)
            {
                generation = "Gen Z";
            }
            else if (birthYear >= 1981 && birthYear <= 1996)
            {
                generation = "Millennials";
            }
            else if (birthYear >= 1965 && birthYear <= 1980)
            {
                generation = "Gen X";
            }
            else if (birthYear >= 1946 && birthYear <= 1964)
            {
                generation = "Baby Boomers";
            }
            else if (birthYear >= 1928 && birthYear <= 1945)
            {
                generation = "The Silent Generation";
            }
            return generation;
        }
        public static string AgeGenerate(int age)
        {
            string ageStage = "";
            if (age >= 0 && age <= 3)
            {
                ageStage = "Infant age";
            }
            else if (age >= 4 && age <= 6)
            {
                ageStage = "Early Childhood age";
            }
            else if (age >= 7 && age <= 8)
            {
                ageStage = "Middle Childhood age";
            }
            else if (age >= 9 && age <= 11)
            {
                ageStage = "Late Childhood age";
            }
            else if (age >= 12 && age <= 20)
            {
                ageStage = "Adolescence age";
            }
            else if (age >= 21 && age <= 35)
            {
                ageStage = "Early Adulthood age";
            }
            else if (age >= 36 && age <= 50)
            {
                ageStage = "Midlife age";
            }
            else if (age >= 51 && age <= 80)
            {
                ageStage = "Mature Adulthood age";
            }
            else if (age > 80)
            {
                ageStage = "Late Adulthood age";
            }
            return ageStage;
        }
    }
}
