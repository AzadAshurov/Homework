namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //third task
            string[] things = { "Book", "Frog", "Blackberry", "School", "GitHub", "Gol", "JavaScript", "C++", "Pause" };
            Console.WriteLine("Words that have more than 4 char: ");
            for (int i = 0; i < things.Length; i++)
            {
                if (things[i].Length > 4)
                {
                    Console.WriteLine(things[i]);
                }
            }

        }
    }
}