namespace ReferencesTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant lucinda = new Elephant() { EarSize = 33, Name = "Lucinda" };
            Elephant lloyd = new Elephant() { EarSize = 40, Name = "Lloyd" };

            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap.");
            while (true) 
            { 
                char input = Console.ReadKey(true).KeyChar;
                Console.WriteLine("You pressed " + input + ".");
                if (input == '1')
                {
                    Console.WriteLine("Calling lloyd.WhoAmI...");
                    lloyd.WhoAmI();
                }
                else if (input == '2')
                {
                    Console.WriteLine("Calling lucinda.WhoAmI...");
                    lucinda.WhoAmI();
                }
                else if (input == '3')
                {
                    Elephant holder;
                    holder = lloyd;
                    lloyd = lucinda;
                    lucinda = holder;
                    Console.WriteLine("References have been swapped.");
                }
                else return;
                Console.WriteLine();
            }
        }
    }
}
