Console.WriteLine("Enter your number");
int num = Convert.ToInt32(Console.ReadLine());
bool prime = true;
for (int i = 2; i <= (num / 2); i++)
{
    if (num % i == 0)
    {
        prime = false;
        break;
    }
}
Console.WriteLine("Information that this number is prime number: " + prime);
