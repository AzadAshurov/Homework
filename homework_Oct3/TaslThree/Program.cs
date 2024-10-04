int i = 2;
Console.WriteLine("enter number");
int num = Convert.ToInt32(Console.ReadLine());
bool basis2 = false;
while (i <= num)
{
    if (i == num)
    {
        basis2 = true;
        break;
    }
    i *= 2;
}
Console.WriteLine("Information that this number is basis of 2: " + basis2);
