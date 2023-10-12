using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap
{
    internal class marks
    {
        static void Main(string[] args)

        {
            // Declare variables for marks and total 

            int r, marks1, marks2, marks3, total;



            // Declare percentage variable 

            float percentage;
              // Enter student subject 1 marks 

            Console.WriteLine("Enter Subject-1 Marks : ");

            marks1 = Convert.ToInt32(Console.ReadLine());



            // Enter student subject 2 marks 

            Console.WriteLine("Enter Subject-2 Marks : ");

            marks2 = Convert.ToInt32(Console.ReadLine());



            // Enter student subject 3 marks 

            Console.WriteLine("Enter Subject-3 Marks :");

            marks3 = Convert.ToInt32(Console.ReadLine());



            // Calculate total marks 

            total = marks1 + marks2 + marks3;



            // Calculate percentage 

            percentage = total / 3.0f;



            // Display the final result 

            // Console.WriteLine("Final result of {0} is:", n);

            Console.WriteLine("Total Marks : " + total);

            Console.WriteLine("Percentage : " + percentage);



            // Calculate grades 

            if (percentage < 35)

            {

                Console.WriteLine("Grade is fail");

            }

            else if (percentage >= 35 && percentage <= 45)

            {

                Console.WriteLine("Grade is third");

            }

            else if (percentage >= 45 && percentage <= 60)

            {

                Console.WriteLine("Grade is second");

            }


            else if (percentage > 60)

            {

                Console.WriteLine("Grade is first");

            }
        }
    }
}
