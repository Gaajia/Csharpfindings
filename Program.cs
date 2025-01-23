// string first = "Hello";
// string second = "World!";
// string result = string.Format("{0} {1}!", first, second);
// Console.WriteLine("{0} {0} {0}!", first, second);

// Console.WriteLine(result);
// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (save {discount:C})");

// using System.Globalization;
// decimal measurement = 123456.78912m;
// string formatter = measurement.ToString("C", new CultureInfo("en-GB"));
// Console.WriteLine(formatter);
// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

// yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
// Console.WriteLine(yourDiscount);

// string input = "Pad this";
// Console.WriteLine(input.PadLeft(12, '-'));
// Console.WriteLine(input.PadRight(12, '-'));

// string paymentId = "769C";
// string payeeName = "Mr. Stephen Ortega";
// string test = "wazzaup"

// var formattedLine = paymentId.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += test.PadRight(3);

// Console.WriteLine(formattedLine);


// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// // Your logic here

// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = "";

// // Your logic here

// Console.WriteLine(comparisonMessage);

// string message = "Find what is (inside the parentheses)";
// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');
// //adding to the position to avoid opening bracket.
// openingPosition += 1;

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));
// string message = "What is the value <span>between the tags</span>?";
// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// while (true)
// {
//     //opening position
//     int openingPosition = message.IndexOf('(');
//     //if no more opening brackets == -1 then it would break
//     if (openingPosition == -1) break;
//     //add to avoid the current opening bracket. 
//     openingPosition += 1;
//     //checking for closing bracket
//     int closingPosition = message.IndexOf(')');
//     //get hte amount of charecters. in the current parenthesis. 
//     int length = closingPosition - openingPosition;
//     //print out the current iteration of what's inside the parenthesis.
//     Console.WriteLine(message.Substring(openingPosition, length));
//     //avoid the same current closing parethensis by extracting what's been done. and keeping the remaining string.  
//     message = message.Substring(closingPosition + 1);
// }
// string message = "Hello, world!";
// char[] charsToFind = { 'a', 'e', 'i' };

// int index = message.IndexOfAny(charsToFind);

// Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");
// string message = "Help (find) the {opening symbols}";
// Console.WriteLine($"Searching THIS Message: {message}");
// char[] openSymbols = { '[', '{', '(' };
// int startPosition = 5;
// int openingPosition = message.IndexOfAny(openSymbols);
// Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

// openingPosition = message.IndexOfAny(openSymbols, startPosition);
// Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");

// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// char[] openSymbols = { '[', '{', '(' };

// int closingPosition = 0;
// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//     if (openingPosition == -1)
//     {
//         break;
//     }
//     string currentSymbol = message.Substring(openingPosition, 1);
//     char matchingSymbol = ' ';
//     switch (currentSymbol)
//     {
//         case "[":
//             matchingSymbol = ']';
//             break;
//         case "{":
//             matchingSymbol = '}';
//             break;
//         case "(":
//             matchingSymbol = ')';
//             break;

//     }
//     openingPosition += 1;
//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));

// }

// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 20);
// Console.WriteLine(updatedData);

// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);
// const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

// int takeAway = input.IndexOf("<span>", 1);
// string quantity = input.Substring(takeAway + 5, 5);
// Console.WriteLine(quantity);
// Console.WriteLine("");

// // Your work here
// string replacer = input.Replace("&trade", "&reg");
// int divCloserStart = replacer.IndexOf("</div>");
// replacer = "Output: " + replacer.Remove(divCloserStart);

// Console.WriteLine(replacer);
// // Console.WriteLine(output);