using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_11_While_Do
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WHile

            // while loop repeats until condition is false

            //while(false) // While checks the condition first
            //{
            //    Console.WriteLine("The while loop ran");
            //}

            //// Do While

            //do // Do will run at least once
            //{
            //    Console.WriteLine("The while loop ran");
            //} while (false);

            //bool menu = true;


            string usersname = "Will";
            string userInput;

            do
            {
                Console.WriteLine("Please enter the users name: ");
                userInput = Console.ReadLine();
            } while (userInput != usersname); // place while after do curly braces

            Console.WriteLine("Hello" + userInput);


            Console.ReadKey();
            // asdfaskj == Will : False
            // asdfkj;asdfj != Will : True

        } // Main

        public static void ValidateUser()
        {
            // Declaring a set of username and password
            const string man_name = "Will";
            const string man_password = "Cram";

            //string userInput = "Will";
            //string userPass = "Cram";


            // Asks the user for their name
            Console.WriteLine("Enter a name");
            string user = Console.ReadLine();

            // Keyword while, followed by a true false condition. curlys
            // Checks to see if the name is the same as stored in man_name

            // Gate keeping code
            // ---------
            while (man_name != user) // As long as they have not given me the correct name
            {

                Console.WriteLine("That was an invalid name");

                Console.Write("Try Again - Enter a name: ");
                user = Console.ReadLine();
                Console.WriteLine();
            }
        } // Validate User

        public static void PromptForNumbers()
        {
            // Ask the user for 5 numbers
            // Get the sum
            // Get the average
            // Display them all

            int sum = 0;
            int count = 0;
            int end = 5;
            string allUserNumbers = "";

            Console.WriteLine("Enter a number: ");

            // Loop 5 times
            while (count < end)
            {
                // Adds users number to sum
                // Asking the user for their number, storing in a string.
                string userNumber = Console.ReadLine();

                sum += int.Parse(userNumber);
                // Display 1 + 2 + 3 + 4 + 5 +
                allUserNumbers += userNumber + " + ";

                // increment counter
                count++;
                Console.WriteLine("Enter a number: ");
            }

            double average = sum / (double)count;
            // Display Sum
            Console.WriteLine(allUserNumbers);
            Console.WriteLine(sum);
            Console.WriteLine(average);

        }

        public static void Menu()
        {
            // Online if uses has entered the proper indentification 
            // -------------- Menu
            bool menuRunning = true; // Our menu keeps running as long as this is true

            while (menuRunning)
            {
                Console.WriteLine("1 - Do Something");
                Console.WriteLine("2 - Exit");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Grats on doing something");
                        break;
                    case "2":

                        // Changed our flag, to false. Our menu will stop running.
                        menuRunning = false;
                        break;
                    default:
                        Console.WriteLine("You didn't choose a proper choice");
                        break;

                }

            }




            Console.WriteLine("This is the end of our app. Goodbye");

        }

        public static void Counting()
        {
            // While
            // Do While

            // == 
            // !=
            // ><
            // <=
            // >=


            //    int count = 0;
            //    // Don't hard code numbers
            //    int endOfLoop = 10;

            //countHere:;

            //    Console.WriteLine(count);

            //    if (count < endOfLoop)
            //    {
            //        count++;
            //        goto countHere;
            //    }

            // 0 through 10

            int wCount = 0;
            int wEnd = 100000;

            int time = 0;
            int endTime = 100;

            while (wCount <= wEnd || time < endTime)
            {
                Console.WriteLine(wCount);
                wCount++;
                time++;
            }

            // bool || bool = One has to be true

            Console.WriteLine(endTime);
            Console.ReadKey();
        }

        public static void Labels()
        {
        tryPassAgain:;
            // User inputs


            //// CHecking if user info is same as manager
            //if (man_name == userInput && userPass == man_password)
            //{
            //    Console.WriteLine("You have logged in");

            //}
            //else
            //{
            //    Console.WriteLine("This was invalid information");
            //    goto tryPassAgain;
            //}

        }

    } // internal

} // namespace
