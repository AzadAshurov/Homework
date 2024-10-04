namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //second task
            int[] numbers = { 8, 10, 5, 3, 2, 40, 12 };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("The sum of numbers is: " + sum);
        }
    }
}