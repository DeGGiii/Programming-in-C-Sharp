using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class TicketSeller
    {
        private string name;
        private double price = 0;
        private int numOfAdults;
        private int numOfChildren;

        private double amountToPay;

       public void readInputData()
        {
            Console.WriteLine("Welcome to KIDS' FAIR!");
            Console.WriteLine("75% discount for all children" + Environment.NewLine);

            Console.WriteLine("Your name please:");
            name = Console.ReadLine();

            Console.WriteLine("numer of adults:");
            numOfAdults = Convert.ToInt32(Console.ReadLine());
            int adultPrice = 100 * numOfAdults;

            price = price + adultPrice;

            Console.WriteLine("number of children:");
            numOfChildren = Convert.ToInt32(Console.ReadLine());
            price = price + ((100*0.25) * numOfChildren);



        }

        public void writeInputData()
        {
            Console.WriteLine();
            Console.WriteLine("+++ Your receipt +++");
            Console.WriteLine("+++ Amount to pay = " + price + " KR +++" + Environment.NewLine);

            Console.WriteLine("+++ Thank you " + name + " have fun and hope you come back! +++");



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
