// // string? readResult;
// // bool validEntry = false;
// // Console.WriteLine("Enter a string containing at least three characters:");
// // do
// // {
// //     readResult = Console.ReadLine();
// //     if (readResult != null)
// //     {

// //         if (readResult.Length >= 5)
// //         {
// //             validEntry = true;
// //             Console.WriteLine($"Your input '{readResult}' is valid.");
// //         }
// //         else
// //             Console.WriteLine("Your input is invalid, please try again");
// //     }

// // } while (validEntry == false);

// // int numericValue = 0;
// // bool validNumber = false;
// // validNumber = int.TryParse(readResult, out numericValue);
// // Console.WriteLine($"Your input {numericValue} {validNumber}");

// //CHALLENGES

// // string? readNumber;
// // bool validNumber = false;
// // int numericValue = 0;

// // do
// // {
// //     readNumber = Console.ReadLine();
// //     validNumber = int.TryParse(readNumber, out numericValue);

// //     if (!validNumber)
// //     {
// //         Console.WriteLine("Please enter a number");
// //         break;
// //     }
// //     else if (numericValue > 5 && numericValue < 10)
// //     {
// //         validNumber = true;
// //         Console.WriteLine($"Your input ({numericValue}) is valid");
// //     }
// //     else {
// //         Console.WriteLine($"Entered {numericValue} Please enter a numeric value between 5-10");
// //         break;
// //         }


// // } while (validNumber == false);

// //CHALENGE 2


// // string? readLine;
// // bool validInput = false;


// // while (validInput == false)
// // {
// //     Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
// //     readLine = Console.ReadLine();
// //     readLine = readLine.Trim().ToLower();

// //     switch (readLine)
// //     {
// //         case "administrator":
// //             Console.WriteLine($"Your input value {readLine} has been accepted");
// //             validInput = true;
// //             break;
// //         case "manager":
// //             Console.WriteLine($"Your input value {readLine} has been accepted");
// //             validInput = true;
// //             break;
// //         case "user":
// //             Console.WriteLine($"Your input value {readLine} has been accepted");
// //             validInput = true;
// //             break;
// //         default:
// //             Console.WriteLine($"The role name that you entered,{readLine} is not valid. Enter your role name (Administrator, Manager, or User");
// //             break;

// //     }


// // }

// //Challenge 3 

// /* I like pizza
// I like roast chicken
// I like salad
// I like all three of the menu choices*/

// /* 
// first go over each element within the array
//  - find the index of the period in each string
//  - use the substring method to extract the substring up to the period
//  - concatenate the extracted substring to a new string
//  - print the new string
//  - repeat the process for all elements in the array
//  - the final string will be the concatenation of all the extracted substrings, each with a period at the end.

// Here is the code:

// */

// string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
// int periodLocation = 0;

// for (int i = 0; i < myStrings.Length; i++)
// {
//     string myString = myStrings[i];
//     periodLocation = myString.IndexOf(".");
//     string mySentence;


//     while (periodLocation != -1)
//     {
//         mySentence = myString.Substring(0, periodLocation);
//         Console.WriteLine(mySentence);
//         myString = myString.Remove(0, periodLocation + 1).TrimStart();
//         periodLocation = myString.IndexOf(".");


//     }
//     if (myString.Length > 0)
//     {
//         Console.WriteLine(myString);
//     }

// }

string[][] jaggedArray = new string[][]
{
    new string[] { "one1", "two1", "three1", "four1", "five1", "six1" },
    new string[] { "one2", "two2", "three2", "four2", "five2", "six2" },
    new string[] { "one3", "two3", "three3", "four3", "five3", "six3" },
    new string[] { "one4", "two4", "three4", "four4", "five4", "six4" },
    new string[] { "one5", "two5", "three5", "four5", "five5", "six5" },
    new string[] { "one6", "two6", "three6", "four6", "five6", "six6" },
    new string[] { "one7", "two7", "three7", "four7", "five7", "six7" },
    new string[] { "one8", "two8", "three8", "four8", "five8", "six8" }
};

foreach (string[] array in jaggedArray)
{
    foreach (string value in array)
    {
        Console.WriteLine(value);
    }
    Console.WriteLine();
}