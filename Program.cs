namespace SelectionStatementExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello, what is your favorite school subject?");
            var userFav = Console.ReadLine().ToLower();
            
            switch (userFav)
            {
                case "math":
                    Console.WriteLine("Math is my favorite subject too! Now, solve this viral order of operations equation: 6÷2(1+2)=??");
                    break;
                case "history":
                    Console.WriteLine("\"History is a set of lies agreed upon\"-Napoleon Bonaparte");
                    break;
                case "science":
                    Console.WriteLine("BILL NYE THE SCIENCE GUY! BILL BILL BILL BILL BILL BILL NYE THE SCIENCE GUY!(Science Rules)");
                    break;
                case "english":
                case "grammar":
                    Console.WriteLine("Nouns and pronouns and verbs and adjectives and adverbs and prepositions and conjunctions and ...");
                    break;
                case "reading":
                    Console.WriteLine("\"Not all those who wander are lost\"-J.R.R. Tolkien");
                    break;
                case "gym":
                case "physical education":
                case "p.e.":
                case "p e":
                case "pe":
                    Console.WriteLine("BLUE 42! SET! HUT!");
                    break;
                case "lunch":
                    Console.WriteLine("DING DING DING! You win! This was the only correct choice!");
                    break;
                default: 
                    Console.WriteLine("Maybe you said art or band or something I didn't bother to code... sorry.");
                    break;

            }

        }
    }
}
