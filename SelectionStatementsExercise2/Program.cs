namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "math":
                    Console.WriteLine("I like math a lot too!");
                    break;
                case "english":
                    Console.WriteLine("I like english too, but I hate the grammar part :(");
                    break;
                case "science":
                    Console.WriteLine("Science is cool, but hard!");
                    break;
                case "history":
                    Console.WriteLine("I'm not a big fan of history, but I'm good at it too which is weird?");
                    break;
                case "art":
                    Console.WriteLine("I'm terrible at drawing, but at least you like it!");
                    break;
                default:
                    Console.WriteLine("That is not a chosen school subject or you may not like any subject which is fine too!");
                    break;
            }
           
                
                

        }
    }
}