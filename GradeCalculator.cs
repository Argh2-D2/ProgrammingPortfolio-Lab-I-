using System;

namespace L1._7_GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Please enter marks acquired from Programming Challenge I.");
            int Number = int.Parse(Console.ReadLine());

            Console.WriteLine("Secondly, Enter the marks gathered from Programming Challenge II.");
            int SecondNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Finally, enter the marks from Capstone Project.");
            int ThirdNumber = int.Parse(Console.ReadLine());   
            
            decimal OverallMarks = Number + SecondNumber + ThirdNumber;
            decimal x = OverallMarks/3;
            //When calculating separate formula as numbers get muddled up
            //breakpoint used at line 19 to identfy previous formula problem 
            
            Console.WriteLine("After calculating, the overall mark is "+ x.ToString("F1")+ "%");
        }
    }
}
