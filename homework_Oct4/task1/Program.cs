namespace oct4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 8, 10, 5, 3, 2, 40, 12 };
            int minNum = numbers[0];
            //minimum number already equal to first number of array, so loop can be started from second number
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < minNum)
                {
                    minNum = numbers[i];
                }
            }
            Console.WriteLine("The minimum number is: " + minNum);
        }
    }
}