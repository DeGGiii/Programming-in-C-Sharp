using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_1
{
    internal class Table
    {
        private string tableName;
        private string condition;
        private int legs;
        private double length;
        private double width;

        public void readInputData()
        {
            Console.WriteLine("************* Table seller INC' ******************");

            Console.WriteLine("What is the name of your table?");
            tableName = Console.ReadLine();

            Console.WriteLine("What is the condition of " + tableName + "?");
            condition = Console.ReadLine();

            Console.WriteLine("How many legs does your table (" + tableName + ") have?");
            legs = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Whats the length of the table:");
            length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Whats the length of the table:");
            width = Convert.ToDouble(Console.ReadLine());

        }

        public void writeInputData()
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("Table name: " + tableName);
            Console.WriteLine("Table condition: " + condition);
            Console.WriteLine("Number of legs: " + legs);
            Console.WriteLine("Tables length: " + length + "cm");
            Console.WriteLine("Tables width: " + width + "cm");
            Console.WriteLine("****************************************");
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
