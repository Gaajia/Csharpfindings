// int[] schedule = { 800, 1200, 1600, 2000 };
// void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
// {

//     int diff = 0;
//     if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//     {
//         Console.WriteLine("Invalid GMT");
//     }
//     else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
//     {
//         diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     }
//     else
//     {
//         diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     }
//     for (int i = 0; i < times.Length; i++)
//     {
//         int newTime = ((times[i] + diff)) % 2400;
//         Console.WriteLine($"{times[i]} -> {newTime}");
//     }
// }
// DisplayAdjustedTimes(schedule, 6, -6);

// double pi = 3.14159;

// double pi = 3.14159;
// void PrintCircleArea(int radius)
// {
//     double area = pi * (radius * radius);
//     Console.WriteLine($"Area = {area}");
// }

// void PrintCircleCircumference(int radius)
// {
//     double circumference = 2 * pi * radius;
//     Console.WriteLine($"Circumference = {circumference}");
// }

// PrintCircleInfo(12);
// PrintCircleInfo(24);

// void PrintCircleInfo(int radius)
// {
//     Console.WriteLine($"Circle with radius {radius}");
//     PrintCircleArea(radius);
//     PrintCircleCircumference(radius);
// }

// int a = 3;
// int b = 4;
// int c = 0;

// Multiply(a, b, c);
// Console.WriteLine($"global statement: {a} x {b} = {c}");

// void Multiply(int a, int b, int c){
//     c = a * b;
//     Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
// }
// //refrence type
// void Main()
// {
//     int[] numbers = {1, 2, 3};
//     ModifyArray(numbers);
//     Console.WriteLine(numbers[0]);  // Prints 99
// }

// void ModifyArray(int[] arr)
// {
//     arr[0] = 99;  // Changes the actual array because we're working with the reference
// }


// int[] array = { 1, 2, 3, 4, 5 };

// PrintArray(array);
// Clear(array);
// PrintArray(array);

// void PrintArray(int[] array)
// {
//     foreach (int a in array)
//     {
//         Console.Write($"{a} ");
//     }
//     Console.WriteLine();
// }
// void Clear(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = 0;
//     }
// }

// string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
// string[] rsvps = new string[10];
// int count = 0;
// RSVP("Rebecca", 1, "none", true);
// RSVP("Nadia", 2, "Nuts", true);
// // RSVP("Linh", 2, "none", false);
// // RSVP("Tony", 1, "Jackfruit", true);
// RSVP("Tony", inviteOnly: true, allergies: "Jackfruit", partySize: 1);
// RSVP("Noor", 4, "none", false);
// RSVP("Jonte", 2, "Stone fruit", false);


// void RSVP(string name, int partySize, string allergies, bool inviteOnly)
// {
//     if (inviteOnly)
//     {
//         // search guestList before adding rsvp
//         bool found = false;
//         foreach (string guest in guestList)
//         {
//             if (guest.Equals(name))
//             {
//                 found = true;
//                 break;
//             }
//         }
//         if (!found)
//         {
//             Console.WriteLine($"Sorry, {name} is not on the guest list");
//             return;
//         }
//     }
//     rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//     count++;
// }

// void showRSVPs()
// {
//     Console.WriteLine("\nTotals RSVPs:");
//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine(rsvps[i]);
//     }

// }
// showRSVPs();
//Display email addresses
// Internal employees
// using System.Reflection.Metadata.Ecma335;
// [,]string gaj = new dick [" gaj has 9 inch", int 5 ]

// string[,] corporate =
// {
//     {"Robert", "Bavin"}, {"Simon", "Bright"},
//     {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
//     {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
// };

// string[,] external =
// {
//     {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
//     {"Shay", "Lawrence"}, {"Daren", "Valdes"}
// };

// string externalDomain = "hayworth.com";

// for (int i = 0; i < corporate.GetLength(0); i++)
// {
//     // display internal email addresses
//     string firstName = corporate[i, 0];
//     string lastName = corporate[i, 1];

//     string username = firstName.Substring(0, 2).ToLower() + lastName.ToLower();
//     string email = $"{username}@contoso.com";
//     Console.WriteLine(email);

// }

// for (int i = 0; i < external.GetLength(0); i++)
// {
//     // display external email addresses
//     string firstName = external[i, 0];
//     string lastName = external[i, 1];
//     string username = firstName.Substring(0, 2).ToLower() + lastName.ToLower();
//     string email = $"{username}{externalDomain}";
//     Console.WriteLine(email);
// }
//  SayHello();

// void SayHello()
// {
//     Console.WriteLine("Hello World!");
// }


// string SayHi()
// {
//     return "hi";
// }
// SayHi();
// string message = SayHi();
// Console.WriteLine(message);
// MakeCoffee(false);
// void MakeCoffee(bool hasCoffeeBeans)
// {
//     // First check if we have coffee beans
//     if (!hasCoffeeBeans)
//     {
//         Console.WriteLine("Sorry, we're out of coffee beans!");
//         return;  // Stop here! Don't try to make coffee without beans
//     }

//     // These lines only run if we didn't hit the return above
//     Console.WriteLine("Grinding coffee beans");
//     Console.WriteLine("Heating water");
//     Console.WriteLine("Brewing coffee");
//     Console.WriteLine("Coffee is ready!");
// }
// Console.WriteLine("Generating random numbers:");
// DisplayRandomNumbers();
// void DisplayRandomNumbers()
// {
//     Random random = new Random();
//     for (int i = 0; i < 5; i++)
//     {
//         Console.Write($"{random.Next(1, 100)} ");
//     }
//     Console.WriteLine(); 

// }
using System;

int[] times = {800, 1200, 1600, 2000};
int diff = 0;

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");

/* Format and display medicine times */
foreach (int val in times)
{
    string time = val.ToString();
    int len = time.Length;

    if (len >= 3)
    {
        time = time.Insert(len - 2, ":");
    }
    else if (len == 2)
    {
        time = time.Insert(0, "0:");
    }
    else
    {
        time = time.Insert(0, "0:0");
    }

    Console.Write($"{time} ");
}

Console.WriteLine();

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

    /* Adjust the times by adding the difference, keeping the value within 24 hours */
    for (int i = 0; i < times.Length; i++) 
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
} 
else 
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

    /* Adjust the times by adding the difference, keeping the value within 24 hours */
    for (int i = 0; i < times.Length; i++) 
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}

Console.WriteLine("New Medicine Schedule:");

/* Format and display medicine times */
foreach (int val in times)
{
    string time = val.ToString();
    int len = time.Length;

    if (len >= 3)
    {
        time = time.Insert(len - 2, ":");
    }
    else if (len == 2)
    {
        time = time.Insert(0, "0:");
    }
    else
    {
        time = time.Insert(0, "0:0");
    }

    Console.Write($"{time} ");
}

Console.WriteLine();