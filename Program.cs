using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)

        {
            // Creating an instance that will allow us to use a method from 
            // another class within this current class 

            var aClass = new Program2();
            aClass.checkValidNum();




        }

    }
    class Program2
    {

        public void checkValidNum()
        {
            bool run = true;
            //  bool Run = true;

            Console.WriteLine("Hello! What is your name?");

            string userName = Console.ReadLine();

            Console.WriteLine();


            while (run)
            {

                Console.WriteLine(userName + " please enter in a number between 1 and 100");


                int userInput = int.Parse(Console.ReadLine());


                if (IsOdd(userInput))

                {
                    Console.WriteLine(userInput + " is an odd number!");
                }



                else if (IsEven(userInput) && (userInput >= 2) && (userInput <= 25))
                {
                    Console.WriteLine("Your input is an even number and in between the range of 2 and 25!");

                }

                else if (IsEven(userInput) && userInput >= 26 && userInput <= 60)
                {
                    Console.WriteLine("Even");
                }

                else if (IsEven(userInput) && userInput > 60)
                {
                    Console.WriteLine(userInput + " is even and greater than than 60");
                }

                else if (IsOdd(userInput) && userInput > 60)

                {
                    Console.WriteLine(userInput + "is odd and greater than 60");
                }

                else if (NotEvenOdd(userInput))
                {
                    Console.WriteLine("This is a prime number!");
                }



                run = Continue();

            }
        }


        // Method that will check if the userInput is even
        public bool IsEven(int userInput)
        {
            // We want to retrn if the userInput is divisible by 2 with a remainder of 2 because that means
            //the number is odd! If its not even it is odd! 
            return userInput % 2 == 0;
        }
        // Method that will check if the userInput is odd
        public bool IsOdd(int userInput)
        {
            return userInput % 3 == 0;
        }

        //This method will catch Prime Numbers!
        public bool NotEvenOdd(int userInput)
        {
            bool checking;
            checking = userInput % 3 != 0 && userInput % 2 != 0;
            return checking;
        }


        public static Boolean Continue()

        {
                Boolean run = true;           
                Console.WriteLine("Would you like to continue? Yes or No? ");
                //I have to put the .ToLower() Method after the userInput so that way it can immediately change the letters to lowercase
                string userChoice = Console.ReadLine();
                userChoice = userChoice.ToLower();
                

                if (userChoice == "yes")
                {
                    Console.WriteLine("Ok lets enter in another number!");
                    run = true;
                }


                else if (userChoice == "no")
                {
                run = false;
                Console.WriteLine("Wrap it up den!");
                   

                }


                else

                {
                    Console.WriteLine("I am sorry I don't understand! Could you please try again?");

                    run = Continue();
                }


            return run;
        }




    }




}

