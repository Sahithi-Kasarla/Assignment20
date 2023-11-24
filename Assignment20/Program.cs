using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1:Printing hello world
             Console.WriteLine("Hello World!");

            //T-2:Taking values from user
            string name;
            Console.WriteLine("enter the name");
            name=Console.ReadLine();
            Console.WriteLine("Hello " + name);

            //T-3:Basic Arithmetic
            int num1, num2;
             Console.WriteLine("enter first number");
             num1=int.Parse(Console.ReadLine());
             Console.WriteLine("enter second number");
             num2=int.Parse(Console.ReadLine());
             Console.WriteLine($"addition of {num1} + {num2} is {num1+num2} ");
             Console.WriteLine($"subtraction of {num1} - {num2} is {num1 - num2} ");
             Console.WriteLine($"Multiplication of {num1} * {num2} is {num1 * num2} ");
             Console.WriteLine($"division of {num1} / {num2} is {num1 / num2} ");
             Console.WriteLine($"Modulus of {num1} % {num2} is {num1 % num2} ");

            //T-4:using ctrl stmts:if-else
             Console.WriteLine("enter the number");
             int num =int.Parse(Console.ReadLine());
             if (num / 2 == 0)
             {
                 Console.WriteLine("The number is even");
             }
             else
             {
                 Console.WriteLine("The number is odd");
             }

             //T-5:loops-for
            int[] myArray=new int[10];
            for(int i = 1; i <=myArray.Length; i++)
            {
                Console.WriteLine(i);

            }

            //T-6:Arrays
            int[] array = new int[5]{ 3, 4, 5, 6, 6 };//int[] array={1,4,5,6,7};
            int sum=0;
            for(int i= 0; i < array.Length; i++)
            {
              sum += array[i];
            }
            double average= sum /array.Length;
            Console.WriteLine("sum of the numbers is sum " + sum);
            Console.WriteLine("The average of numbers is " + average);

            //Task-8:Exception Handling
            int age;

            // Use a loop to keep prompting the user until a valid input is provided
            while (true)
            {
                // Prompt the user for age input
                Console.Write("Enter your age: ");

                // Read the input as a string
                string ageInput = Console.ReadLine();

                // Use try-catch for exception handling
                try
                {
                    // Attempt to parse the input
                    if (int.TryParse(ageInput, out age))
                    {
                        // Display the result if parsing is successful
                        Console.WriteLine($"Your age is: {age}");

                        // Determine and display the age category
                        if (age < 18)
                        {
                            Console.WriteLine("You are a minor.");
                        }
                        else if (age >= 18 && age <= 65)
                        {
                            Console.WriteLine("You are an adult.");
                        }
                        else
                        {
                            Console.WriteLine("You are a senior.");
                        }

                        break; // Exit the loop if a valid input is provided
                    }
                    else
                    {
                        // Display an error message if parsing fails
                        Console.WriteLine("Invalid input. Please enter a valid age as a number.");
                    }
                }
                catch (Exception ex)
                {
                    // Handle any other exceptions that might occur
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
            Console.ReadLine();


            //T-7:calculating the factorial
            Console.WriteLine("enter the number");
            int num3 = int.Parse(Console.ReadLine());
            long result = fact(num1);
            Console.WriteLine("The factorial is" + result);
            Console.ReadLine();
        }

        static long fact(int n)
        {
            if (n == 0||n==1)
            {
                return 1;
            }

            else
            { return n * fact(n - 1); }

        }

        
    }
            
}


