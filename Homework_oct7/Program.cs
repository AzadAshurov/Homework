//All five tasks in one
Console.WriteLine("Enter 1-5 for tasks");
string option;
do
{
    option = Console.ReadLine();
    switch (option)
    {
        // task 1) show are numbers in array prime or not 
        case "1":
            int[] numbers = { 2, 4, 5, 7, 9, 13, 20, 54, 234, 325, 851 };
            for (int i = 0; i < numbers.Length; i++)
            {
                bool prime = true;
                for (int j = 2; j <= numbers[i] / 2; j++)
                {
                    if (numbers[i] % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine("Information that number " + numbers[i] + " is " + prime);
            }
            break;

        //task 2) show similar numbers in two different arrays
        case "2":
            int[] setFirst = { 1, 3, 5, 34, 56, 6, 63, 67, 52, 12, 65 };
            int[] setSecond = { 1, 31, 5, 34, 536, 6, 63, 67, 522, 12, 615 };
            Console.WriteLine("Similar number:");
            for (int i = 0; i < setFirst.Length; i++)
            {
                for (int j = 0; j < setSecond.Length; j++)
                {
                    if (setSecond[j] == setFirst[i])
                    {
                        Console.WriteLine(setSecond[j]);
                        break;
                    }
                }
            }
            break;

        //task3) show index of greateat and least numbers in array
        //upd: in this array  min or max numbers are not unical(2 - two times,35 - five times) 
        case "3":
            int[] nums = { 2, 4, 3, 13, 35, 12, 35, 5, 6, 35, 32, 2, 23, 32, 35, 18, 19, 4, 35, 32, 12 };
            int numMin = nums[0];
            int numMax = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < numMin)
                {
                    numMin = nums[i];
                }
                if (nums[i] > numMax)
                {
                    numMax = nums[i];
                }
            }
            Console.WriteLine("The least number is " + numMin + " and it has indices:");
            for (int i = 0; i < nums.Length; i++)
            {
                if (numMin == nums[i])
                {
                    Console.WriteLine("[" + i + "]");
                }
            }
            Console.WriteLine("The greatest number is " + numMax + " and it has indices:");
            for (int i = 0; i < nums.Length; i++)
            {
                if (numMax == nums[i])
                {
                    Console.WriteLine("[" + i + "]");
                }
            }
            //can be used only one FOR loop instead of two, but output will look weird
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (numMin == nums[i])
            //    {
            //        Console.WriteLine("The least number is " + numMin + " and has index [" + i + "]");
            //    }
            //    if (numMax == nums[i])
            //    {
            //        Console.WriteLine("The greatest number is " + numMax + " and has index [" + i + "]");
            //    }
            //}
            break;

        // sum of all digits in number
        case "4":
            Console.WriteLine("Enter your number");
            string inputNum = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < inputNum.Length; i++)
            {
                sum += (inputNum[i] - '0');
            }
            Console.WriteLine("Sum of all digits of number is egual to: " + sum);







            ////another method
            Console.WriteLine("Enter your number");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int summa = 0;
            while (inputNumber != 0)
            {
                summa += inputNumber % 10;
                inputNumber = inputNumber / 10;
            }
            Console.WriteLine("Sum of all digits of number is egual to: " + summa);
            break;

        //find missing number from 1-10 
        case "5":
            int[] numberSet = { 1, 3, 7, 9, 6, 4, 2, 5, 10 };
            int arraySum = 0;
            for (int i = 0; i < numberSet.Length; i++)
            {
                arraySum += numberSet[i];
            }
            //1+2+3+...+10 equal to 55
            Console.WriteLine("The missing number is " + (55 - arraySum));
            break;
    }
}
while (option == "1" || option == "2" || option == "3" || option == "4" || option == "5");