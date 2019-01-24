using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_a_non_specific_number_of_scores
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 0;
            int math = 0;
            double ave;
            int a = 0;
            string x;

            Console.WriteLine("Enter test scores or enter q to exit.");
            //while statement allows you to loop continuesly

            while (true)
            {
               
            //Having the user enter the test scores
                restart:
                Console.WriteLine($"Entry {a+1} ");
                x = Console.ReadLine();

                if(x == "q")
                {
                    break;
                }
                try
                {
                    t = int.Parse(x);
                }
                catch(Exception error)
                {
                    Console.WriteLine(error.Message.ToString());
                    goto restart;
                }



                //the t is the test score entered. the if statement is saying if its below 0 or above 100 if will diplay invalid number
                if (t < 0 || t > 100)
                {
                    Console.WriteLine("Invalid number. Choose a number between 0 to 100");
                    goto restart;
                }

                math += t;
                a++;
            }

            ave = math/a;

            Grade(ave);
        }

        public static void Grade(double x)
        {
            Console.WriteLine($"Your grade is : {x}");
            if (x > 90 || x > 100)
            {
                Console.WriteLine("That's a A!");
            }
            else if (x > 80 || x > 90)
            {
                Console.WriteLine("That's a B!");
            }
            else if (x > 70 || x > 80)
            {
                Console.WriteLine("THat's a C!");
            }
            else if (x > 60 || x > 70)
            {
                Console.WriteLine("That's a D!");
            }
            else if (x > 0 || x > 60)
            {
                Console.WriteLine("That's a F!");
            }
            Console.ReadLine();
        }

    }
}

