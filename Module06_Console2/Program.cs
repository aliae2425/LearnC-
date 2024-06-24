int hero = 10;
int Monster = 10;
int turn = 0;

while (hero > 0 && Monster > 0)
{
    // Console.WriteLine($"{hero > 0 }| {Monster >0 } |{hero > 0 || Monster > 0}");
    int damage = new Random().Next(0, 11);
    if (turn % 2 == 0) {
        Monster -= damage;
        Console.WriteLine($"Hero hits monster for {damage} damage. Monster has {Monster} health left.");
    }
    else
    {
        hero -= damage;
        Console.WriteLine($"Monster hits hero for {damage} damage. Hero has {hero} health left.");
    }
    turn++;
}

if (hero <= 0)
{
    Console.WriteLine("Monster wins!");
}
else
{
    Console.WriteLine("Hero wins!");
}