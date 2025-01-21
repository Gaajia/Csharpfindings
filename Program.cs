// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result);
// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}");



// string value = "30";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");

// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }
// if (result > 0)
// {
//     Console.WriteLine($"Measurement (w/ offset): {50 + result}");
// }

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
// double result = 0;
// string charac = "";

// for (int i = 0; i < values.Length; i++)
// {

//     if (double.TryParse(values[i], out double number))
//     {
//         result += number;
//     }
//     else
//     {
//         charac += values[i];
//     }


// }

// Console.WriteLine($"{result} , {charac}");

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int:");
if (value1 % 2 != 0)
{
    int result = Convert.ToInt32(value1 / value2);

    Console.WriteLine(result);
}

// Your code here to set result2
Console.WriteLine($"Divide value2 by value3, display the result as a decimal:");
if (value3 != 0)
{

    decimal result2 = value2 / Convert.ToDecimal(value3);
    Console.WriteLine($"Result as decimal: {result2}");
}

// Your code here to set result3
Console.WriteLine($"Divide value3 by value1, display the result as a float: ");
if (value3 != 0)
{
    float result3 = value3 / value1;
    Console.WriteLine($"{result3}");
}