using System;

namespace Personal_Project
{
    class Program
    {
        static void Main(string[] args)
        {

            //Introduction to the program
            Console.WriteLine("Welcome to our online store!");

            //Login options
            Console.WriteLine("\r\nPlease select your login option:\r\n" +
                "1. Login with existing account.\r\n" +
                "2. Create a new account.\r\n" +
                "3. Continue without logging in.");

            //Check the users input
            //Create string variable for users login option
            string loginOption = Console.ReadLine();


            //Create login array

            //Create register array

            //Create a login option
            /*
             *  ask if they login, register, or continue without login/register
             *
             *  login
             *      check user database
             *      password
             *
             *  register
             *      create username
             *      password
             *      enter again
             *
             */

            //Shopping list
            /*
             *
             * list of items to add to cart
             *
             * press number for more information or to order
             *      provide product information
             *      ask quantity
             *      add or cancel
             *
             * chekout or continue
             *      there are X items in your cart would you like to:
             *      checkout: go to cart
             *      continue: back to list
             *
             */
             
            //Checkout
            /*
             *
             * Verify items
             *      use number prompts to select between items
             *      add or delete items
             *
             * Confirm your items when complete
             *
             * Enter card number
             *      X out all but last 4
             *
             * Shipping info
             *      verify
             *
             * Complete checkout
             *
             */

            Console.WriteLine("Hello World!");
        }
    }
}
