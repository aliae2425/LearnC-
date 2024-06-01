for (int i = 0; i < 20; i++)
{
    Console.Write(i);
    if (i%3 == 0)
    {
        Console.Write("Fizz");
    }
    if (i%5 == 0)
    {
        Console.Write("Buzz");
    }
    Console.WriteLine();
}