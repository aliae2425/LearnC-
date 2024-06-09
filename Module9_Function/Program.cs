Console.WriteLine("Generating random numbers:");
Console.WriteLine("How many random numbers do u want (default 5):");
string temp = Console.ReadLine();
if (temp == "") 
{
    DisplayRandomNumbers();
}
else 
{
    DisplayRandomNumbers(Convert.ToInt32(temp));
}


void DisplayRandomNumbers(int count = 5) 
{
    Random random = new Random();

    for (int i = 0; i < count; i++) 
    {
        Console.Write($"{random.Next(1, 100)} ");
    }

    Console.WriteLine();
}