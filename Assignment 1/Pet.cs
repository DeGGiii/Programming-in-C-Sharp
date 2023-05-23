using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Pet
    {
        private string name;
        private int petAge;
        private bool isFemale = true;
        private string isFemaleInput;

        public void readInputData()
        {
            Console.WriteLine("Greetings from MyPet Class!");

            Console.WriteLine("What is the name of your pet?");
            name = Console.ReadLine();

            Console.WriteLine("What is " + name + "'s age?");
            petAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Is your pet a female (y/n)?");
            isFemaleInput = Console.ReadLine();
            



        }

        public void writeInputData()
        {

 

            if (isFemaleInput == "y")
            {
                isFemale = true;
                Console.WriteLine("****************************************" + Environment.NewLine + "Name: " + name + Environment.NewLine +"Age: " + petAge + 
                                    Environment.NewLine + name + " is a good girl!" + Environment.NewLine +"****************************************");
            } else if (isFemaleInput == "n")
                {
                isFemale = false;
                Console.WriteLine("****************************************" + Environment.NewLine + "Name: " + name + Environment.NewLine + "Age: " + petAge +
                                    Environment.NewLine + name + " is a good Boy!" + Environment.NewLine + "****************************************");

            } else { Console.WriteLine("Wrong input!"); }
        }

        public void start()
        {
            string timeLbl = DateTime.Now.ToString("HH:mm:ss");
            string dateLbl = DateTime.Now.ToShortDateString();
            Console.WriteLine("Time: " + timeLbl);
            Console.WriteLine("Date: " + dateLbl);
            Console.WriteLine("-----------------------------------------------------");
            readInputData();
            writeInputData();
            Console.WriteLine("-----------------------------------------------------");

        }
    }
}
