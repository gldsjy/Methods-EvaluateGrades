using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_EvaluateGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfGrades = EnterNumberOfGrades();
            double[] grades = EnterGrades(numberOfGrades);
            double average = CalculateAverage(grades);
            Console.WriteLine("The average grade is " + average);
            DisplayGradeEquivalence(average);
            Console.WriteLine("Here are the grades given by your professor:");
            DisplayAllGrades(numberOfGrades, grades);
            Console.ReadKey();
        }

        static int EnterNumberOfGrades()
        {
            Console.Write("Enter how many grades you want to input: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static double[] EnterGrades(int numberOfGrades)
        {
            double[] grades = new double[numberOfGrades];

            for (int counter = 0; counter < numberOfGrades; counter++)
            {
                Console.Write($"Input grade: ");
                double grade = Convert.ToDouble(Console.ReadLine());

                if (grade >= 0 && grade <= 100)
                {
                    grades[counter] = grade;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Enter a grade between 0 and 100.");
                    counter--; 
                }
            }

            Console.WriteLine("END OF USER INPUT");
            Console.WriteLine("PROCESSING GRADES....");

            return grades;
        }

        static double CalculateAverage(double[] grades)
        {
            double sum = 0;

            foreach (double grade in grades)
            {
                sum += grade;
            }

            return sum / grades.Length;
        }

        static void DisplayGradeEquivalence(double average)
        {
            if (average <= 50)
            {
                Console.WriteLine("FAILED");
            }
            else if (average > 50 && average <= 70)
            {
                Console.WriteLine("FAIR");
            }
            else if (average > 70 && average <= 80)
            {
                Console.WriteLine("GOOD");
            }
            else if (average > 80 && average <= 90)
            {
                Console.WriteLine("VERY GOOD");
            }
            else if (average > 90 && average <= 100)
            {
                Console.WriteLine("EXCELLENT");
            }
        }

        static void DisplayAllGrades(int numberOfGrades, double[] grades)
        {
            for (int counter = 0; counter < numberOfGrades; counter++)
            {
                Console.Write(grades[counter] + "-");
            }
        }
    }
    
}
