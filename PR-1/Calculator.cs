using System;

namespace Prac_1
{
    public class Calculator
    {
        public Calculator() // constructor to initialise and print the headings
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t++++++++++++++++++++  Calculator  ++++++++++++++++++++");
        }

        double num1;
        double num2;

        private void GetNums() // getting userrinputs for the calculation
        {
            Console.Write("\t\t\tEnter Number 1 :    ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\t\t\tEnter Number 2 :    ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\t\t\t-------------------------------------------------------------");
            Console.WriteLine();
        }

        private void Compute() // calculating the values entered by user
        {
            Console.WriteLine($"\t\t\tAddition of {num1} & {num2} is :       " + (num1 + num2));
            Console.WriteLine();
            Console.WriteLine($"\t\t\tSubtraction of {num1} & {num2} is :    " + (num1 - num2));
            Console.WriteLine();
            Console.WriteLine($"\t\t\tMultiplication of {num1} & {num2} is : " + (num1 * num2));
            Console.WriteLine();
            Console.WriteLine($"\t\t\tDivison of {num1} & {num2} is :        " + Math.Round((num1 / num2), 3));
            Console.WriteLine();
        }
        public void InitCalc() // initialise the getnums() and compute() methods .
        {
            GetNums();
            Compute();

        }
    }
}

