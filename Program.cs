using System;
using static System.Console;

namespace granola_sales
{
    class Program
    {
        // declare constants at class level
        const double RETAIL_BAR = 1.5,
                     BARS_PER_CASE = 100,
                     STUDENT_GOV_PERCENTAGE = .1,
                     WHOLESALE_CASE = 100;
        static void Main(string[] args)
        {
            // more compile-time initialization
            double casesSold = 29,
                   grossSales = casesSold * BARS_PER_CASE * RETAIL_BAR,
                   studentGovDeduction = grossSales * STUDENT_GOV_PERCENTAGE,
                   netProceeds = grossSales - studentGovDeduction;
            WriteLine("COMPUTER CLUB GRANOLA SALES");
            WriteLine("{0, 15} {1, 11}", "Cases sold:", casesSold);
            WriteLine("{0, 15} {1, 11:C2}", "Gross sales:", grossSales);
            WriteLine("{0, 15} {1, 11:C2}", "SGA deduction:", studentGovDeduction);
            WriteLine("{0, 15} {1, 11:C2}", "Net proceeds:", netProceeds);
        }
    }
}
