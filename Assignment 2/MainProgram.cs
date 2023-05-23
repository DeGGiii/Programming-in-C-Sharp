namespace Assignment_2
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "Strings, selection and iretation in C#";
            FunFeatures funFeatures = new FunFeatures();
            funFeatures.Start();

            ContinueToNextPart();

            //Continue with MathWork
            Console.Title = "Let's work with numbers!";



        }

        private static void ContinueToNextPart()
        {
            Console.WriteLine("\nPRESS ENTER TO CONTINUE TO THE NEXT PART");
            Console.WriteLine();
            Console.Clear();
        }
    }
}