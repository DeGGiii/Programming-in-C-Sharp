using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_1
{
    internal class Album
    {
        private string albumName;
        private string artistName;
        private int numOfTracks;

        public void readInputData()
        {
            Console.WriteLine("Starting the Album Program!" + Environment.NewLine);

            Console.WriteLine("What is the name of your favourite music album?");
            albumName = Console.ReadLine();

            Console.WriteLine("What is the name of the Artist or Band for " + albumName + "?");
            artistName = Console.ReadLine();

            Console.WriteLine("How many tracks does " + albumName + " have?");
            numOfTracks = Convert.ToInt32(Console.ReadLine());
        }

        public void writeInputData() 
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("Album Name: " + albumName);
            Console.WriteLine("Artist/Band: " + artistName);
            Console.WriteLine("Number of tracks: " + numOfTracks);
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
