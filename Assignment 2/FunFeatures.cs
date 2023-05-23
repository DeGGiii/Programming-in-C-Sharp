using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class FunFeatures
    {
        private string FNInput = "";
        private string LNInput = "";
        private string EmailInput = "";

        /// <summary>
        /// Start method
        /// </summary>
        public void Start()
        {
            Introduction();
            
            bool repeat = false;
            do
            {

                //Calculates the length of given input text from user
                CalculateStrengthLength();

                //Calls the fortunte teller method.
                PredictMyDay();

                repeat = RunAgain();
            } while (repeat);
            

        }

        /// <summary>
        /// Students introduction
        /// </summary>
        public void Introduction()
        {
            Console.WriteLine("My name is Jagtej and I am a student of the VT23 semester!");
            Console.WriteLine("");

            Console.WriteLine("Let me know about yourself!");
            Console.WriteLine("Your first name:");
            FNInput = Console.ReadLine();
            Console.WriteLine("Your last name:");
            LNInput = Console.ReadLine();
            Console.WriteLine("Your email adress:");
            EmailInput = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Nice to mee you " + FNInput + "" + LNInput);
            Console.WriteLine("Your email is " + EmailInput);

        }



        /// <summary>
        /// Calculates the amount of chars in the given input from user. 
        /// </summary>
        public void CalculateStrengthLength()
        {
                Console.WriteLine();
                Console.WriteLine("Write a text with any number of characters and press Enter.");
                string charInput = Console.ReadLine();

                Console.WriteLine(charInput.ToUpper());
                Console.WriteLine("Number of chars = " + charInput.Length);
        }

        /// <summary>
        /// Fortune teller where user input is a number from 1-7 and output a message depending on what number is chosen. 
        /// </summary>
        public void PredictMyDay()
        {
            Console.WriteLine();
            Console.WriteLine("******** FORTUNE TELLER ********");
            Console.WriteLine("Type a number from 1-7: ");
            int days = Convert.ToInt32(Console.ReadLine());

            switch (days) 
            {
                    case 1: Console.WriteLine("Keep calm on Mondays! You can fall apart!");
                    break;

                    case 2: Console.WriteLine("Tuesdays and Wednesdays break your heart!");
                    break;

                    case 3: Console.WriteLine("Tuesdays and Wednesdays break your heart!");
                    break;

                    case 4: Console.WriteLine("Thursday is your lucky day, don't wait for Friday!");
                    break;

                    case 5: Console.WriteLine("Friday, you are in love!");
                    break;

                    case 6: Console.WriteLine("Saturday, do nothing and do plenty of it!");
                    break;

                    case 7: Console.WriteLine("And Sunday always comes too soon!");
                    break;

                    default: Console.WriteLine("No day? is a good day but it doesn't exist!");
                    break;
            
            }
        }

        public void ReadEmail(string email)
        {
            email = EmailInput;

        }

        public void ReadName(string Fname, string Lname)
        {
            Fname = FNInput;
            Lname = LNInput;
        }
        private bool RunAgain()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to retry? yes/no");
            string input = Console.ReadLine();

            if (input == "y" | input == "Y" | input == "Yes" | input == "yes" | input == "YES") 
            {
                return true;
            } else { return false; }
        }
    }
}
