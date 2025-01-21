// using System.Buffers;
// using System.Diagnostics.CodeAnalysis;
// using System.Reflection.PortableExecutable;
// using System.Runtime.CompilerServices;
// using System.Security.Cryptography.X509Certificates;

// // string[] pallets = ["B14", "A11", "B12", "A13"];

// // Console.WriteLine("Sorted...");
// // Array.Sort(pallets);
// // foreach (string pallet in pallets)
// // {
// //     Console.WriteLine($"-- {pallet}");
// // }
// // Console.WriteLine("Reversed...");
// // Array.Reverse(pallets);
// // foreach (string pallet in pallets)
// // {
// //     Console.WriteLine($"-- {pallet}");
// // }
// // Console.WriteLine($"Before: {pallets[0].ToLower()}");
// // Array.Clear(pallets, 0, 2);
// // // if (pallets[0] != null)
// // // Console.WriteLine($"After: {pallets[0].ToLower()}");
// // Console.WriteLine($"Clearing 2 ... count:{pallets.Length}");
// // foreach (string pallet in pallets)
// // {
// //     Console.WriteLine($"-- {pallet}");
// // }
// // Console.WriteLine($"Before: {pallets[0].ToLower()}");
// // Array.Clear(pallets, 0, 2);

// // // Check if element is null before trying to use ToLower()
// // if (pallets[0] != null)
// // {
// //     Console.WriteLine($"After: {pallets[0].ToLower()}");
// // }
// // else
// // {
// //     Console.WriteLine("After: Element is null");
// // }

// // // Print all elements to see what happened
// // foreach (var pallet in pallets)
// // {
// //     Console.WriteLine($"-- {pallet ?? "null"}");  // Print "null" if element is null
// // }
// // Console.WriteLine("");
// // Array.Resize(ref pallets, 6);
// // Array.Resize(ref pallets, 6);
// // Console.WriteLine($"Resizing 6 .. count: {pallets.Length}");
// // pallets[4] = "C01";
// // pallets[5] = "C02";
// // foreach(var pallet in pallets)
// // {
// //     Console.WriteLine($"-- {pallet}");
// // }

// // Console.WriteLine("");
// // Array.Resize(ref pallets, 3);
// // Console.WriteLine($"Reiszing 3 ... count: {pallets.Length}");
// // foreach (var pallet in pallets)
// // {
// //     Console.WriteLine($"-- {pallet}");
// // }
// // string value = "abc123";
// // char[] valueArray = value.ToCharArray();
// // Array.Reverse(valueArray);
// // string result = new string(valueArray);
// // //String.Join - joins chars with a separator
// // // string result = String.Join("", valueArray);
// // Console.WriteLine(result);
// // // string[] items = result.Split(',');
// // // foreach (string item in items)
// // // {
// // //     Console.WriteLine(item);
// // // }

// string pangram = "The quick brown fox jumps over the lazy dog";
// string[] message = pangram.Split();
// string[] newMessage = new string[message.Length];

// for (int i = 0; i < message.Length; i++)
// {
//     //current word to a char -> "quick" "q","u","i","c","k"
//     char[] letters = message[i].ToCharArray();
//     // ['q','u','i','c','k'] becomes ['k','c','i','u','q']
//     Array.Reverse(letters);
//     // new string(letters) takes the reversed characters and joins them back together into one word
//     // We need this because we can't store characters in a string array - it needs full words
//     // ['k','c','i','u','q'] becomes "kciuq"
//     // newMessage[i] puts this reversed word into position i of our new array
//     newMessage[i] = new string(letters);

// }
// // Joins all the reversed words with spaces between them to make the final reversed sentence
// Console.WriteLine(String.Join(" ",newMessage));
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderId = orderStream.Split(",");
string[] hierarchy = new string[orderId.Length];

for (int i = 0; i < orderId.Length; i++)
{
   // Check if order number is exactly 4 characters long
    if (orderId[i].Length != 4)
    {
        hierarchy[i] = orderId[i] + "  -Error";
    }
    else
    {

        hierarchy[i] = orderId[i];
    }// Store the original order ID
}

Array.Sort(hierarchy);
Console.Write(String.Join("\n", hierarchy));
