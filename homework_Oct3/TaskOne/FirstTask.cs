
int num = 0;
Console.WriteLine("Enter your positive two-digits number");
while (true)
{
    num = Convert.ToInt32(Console.ReadLine());
    if (num > 9 && num < 100)
    {
        break;
    }
    else
    {
        Console.WriteLine("This is not positive two digits number. Try again!");
    }
}

int firstNum = num / 10;
int secondNum = num % 10;
if (firstNum > secondNum)
{
    Console.WriteLine(firstNum);
}
else if(firstNum == secondNum){
    Console.WriteLine("Numbers are equal"); }
else
{
    Console.WriteLine(secondNum);
}

