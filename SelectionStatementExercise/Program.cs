namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Guess();
        }
        static void Guess()
        {
            var r = new Random();
            var favNumber = r.Next(1, 10);
           

            Console.WriteLine("Hello guess what my favorite number is!");

            var userInput = int.Parse(Console.ReadLine());

            if (userInput > favNumber)
            {
                Console.WriteLine("Too high!");
            }
            else if (userInput < favNumber)
            {
                Console.WriteLine("Too low!");
            }
            else
            {
                Console.WriteLine("That's correct, good job!");
            }
        }

    }
}
