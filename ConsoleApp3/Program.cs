using System;
using System.Diagnostics;

namespace ConsoleApp2
{
    // All organizing structures use { and } to define their boundaries
    class L1_Program
    {
        // All .NET programs begin with the main method
        // It looks like this
        static void Main(string[] args)
        {
            /*
            int a, b, c;
            double area;
            
            Console.WriteLine("Enter value for a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for c:");
            c = Convert.ToInt32(Console.ReadLine());
            float s = (a + b + c) / 2f;
            area =  Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine("Area is :" + area);
            Console.ReadLine();


        // example 4 - numeric input


        // Exercise 2
        */
            int a, b;
            try
            {
                Console.WriteLine("Enter value for a:");
                a = Convert.ToInt32(Console.ReadLine());
                b = a % 2;
                if (b == 0)
                {
                    Console.WriteLine("Value entered is an even number");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Entered number is an odd number");
                    Console.ReadLine();
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message);
                Console.ReadLine();
            }

        }

            // Exercise 3
            // Input 3 numbers from the user (x,y,z) and find the greatest of them.

            // Write your code here

            /*


            // example 5 - loop
            bool stopProgram = false;

            while (stopProgram == false)
            {
                Console.Write("Please enter income: $");
                income = Convert.ToDecimal(Console.ReadLine());

                if (income > 400000)
                {
                    taxRate = 0.5M;
                    taxLiability = taxRate * income;
                }
                else if (income >= 0)
                {
                    taxLiability = 0;
                }
                else
                {
                    stopProgram = true;
                }

                Console.WriteLine("Tax liability is " + taxLiability);
            } // end while loop


            // Exercise 4
            // Input a value (n) from the user and calculate the sum of first n natural numbers.
            // Eg. n=5. sum = 1+2+3+4+5 = 15

            // Write your code here




            // Exercise 5
            // Input a value (n) from the user and display the following * pattern:
            // Input n=5
            // Output
            // *
            // **
            // ***
            // ****
            // *****

            // Write your code here




            // Exercise 6
            // Input a value (n) from the user and display the following * pattern:
            // Input n=5
            // Output
            //     *
            //    **
            //   ***
            //  ****
            // *****

            // Write your code here




            // example 6 - method
            income = Convert.ToDecimal(Console.ReadLine());
            taxLiability = ComputeTaxes(income);
            Debug.WriteLine("Tax liability is " + taxLiability);


            // Exercise 7
            // Write a method that accepts a parameter (n) and returns the sum of first n natural numbers.

            // Write your code here




            // example 7 - arrays
            decimal[] incomes = new decimal[] { 100.0M, 234532, 2443245.1M, 123443 };

            for (int i = 0; i < 4; i++)
            {
                Debug.WriteLine(incomes[i]);
            }


            // Exercise 8
            // Enter n numbers in an array and print all the even numbers.

            // Write your code here



            // Exercise 9
            // Enter n numbers in an array and find the highest and the smallest number.

            // Write your code here

        }

        static decimal ComputeTaxes(decimal income)
        {
            decimal taxLiability;
            decimal taxRate;

            if (income < 400000)
                taxLiability = 0;
            else
            {
                taxRate = 0.5M;
                taxLiability = taxRate * income;
            }

            return taxLiability;
        }
        */
    }
}