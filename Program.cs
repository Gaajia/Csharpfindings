// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");

// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(!pangram.Contains("fox"));
// Console.WriteLine(!pangram.Contains("cow"));

// int saleAmount = 1001;

// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

// Random flip = new Random();
// int coin = flip.Next(0, 2);
// Console.WriteLine($"Coin toss: {(coin == 0 ? "Heads" : "Tails")}");

// Random hierachy = new Random();
string permission = "Admin|Manager";
int level = 0;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not sufficient privileges");
    }
}
else
{
    Console.WriteLine("You do not sufficient privileges.");
}