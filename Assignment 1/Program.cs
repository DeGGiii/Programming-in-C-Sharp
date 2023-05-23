namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an Pet object
            Pet pet = new Pet();
            pet.start();
            Console.WriteLine("Press ENTER to continue!");
            Console.ReadLine();

            //Create an Album object
            Album album = new Album();
            album.start();
            Console.WriteLine("Press ENTER to continue!");
            Console.ReadLine();

            //Create an TicketSeller object
            TicketSeller ticketSeller = new TicketSeller();
            ticketSeller.start();
            Console.WriteLine("Press ENTER to continue!");
            Console.ReadLine();
           
            //Create an table object
            Table table = new Table();
            table.start();
            Console.WriteLine("Press ENTER to exit!");
            Console.ReadLine();
        }

        static void PrepareConsoleLook()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "KIDS' FAIR";
        }
    }
}