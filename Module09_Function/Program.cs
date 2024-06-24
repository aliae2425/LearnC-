string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    Console.WriteLine(CreateMail(corporate[i, 0], corporate[i, 1]));
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    Console.WriteLine(CreateMail(corporate[i, 0], corporate[i, 1], externalDomain));
}

string CreateMail (string FirstName, string LastName, string Domain = "contoso.com")
{
    FirstName = FirstName.ToLower();
    LastName = LastName.ToLower();
    return $"{FirstName[0]}{LastName}@{Domain}";
}