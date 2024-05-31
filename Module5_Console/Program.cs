Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

Console.WriteLine($"Days until expiration: {daysUntilExpiration}");

switch (daysUntilExpiration)
{
    case 0:
        Console.WriteLine("Your subscription has expired.");
        break;
    case 1 :
        discountPercentage = 20;
        Console.WriteLine("Your subscription expires within a day!");
        break;
    case <=5:
        discountPercentage = 10;
        Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\n Renew Now and save {discountPercentage}!");
        break;
    case <=10:
        Console.WriteLine("Your subscription expires soon.  Renew Now!");
        break;
    default:
        break;
}