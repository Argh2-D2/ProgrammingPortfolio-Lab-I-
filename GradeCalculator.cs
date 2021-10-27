using System;

namespace L1._7_GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Your codes here
            Console.WriteLine("Hello. Please enter marks acquired from Programming Challenge I.");
            int Number = int.Parse(Console.ReadLine());

            Console.WriteLine("Secondly, Enter the marks gathered from Programming Challenge II.");
            int SecondNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Finally, enter the marks from Capstone Project.");
            int ThirdNumber = int.Parse(Console.ReadLine());   
            
            decimal OverallMarks = Number + SecondNumber + ThirdNumber / ((Number + SecondNumber + ThirdNumber/100 * Number + SecondNumber + ThirdNumber));

            Console.WriteLine("The overall mark is " + OverallMarks + "%. "+ OverallMarks.ToString("F1"));

        }
    }
}
