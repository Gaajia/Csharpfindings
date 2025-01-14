// Random random = new Random();
// int current = random.Next(1, 11);

// do
// {
//     current = random.Next(1, 11);
//     if (current >= 8) continue;

//     Console.WriteLine(current);
// } while (current != 7);

// // while (current >= 3)
// // {
// //     Console.WriteLine(current);
// //     current = random.Next(1, 11);
// // }
// // Console.WriteLine($"Last Number: {current}");

//MY WAY
// Random random = new Random();
// int attack = 0;
// int hero = 10;
// int monster = 10;

// do
// {
//        if (hero <= 0)
//     {
//         Console.WriteLine("Game Over, Hero Lost!");
//         break;
//     }
//      if (monster <= 0)
//     {
//         Console.WriteLine("Game Over, Monster Lost!");
//         break;
//     }
//     attack = random.Next(1, 11);
//     monster -= attack;
//     Console.WriteLine($"Hero took a swing the damage is {attack} now the health of the monster is {monster}");
//     if (monster > 0)
//     {
//         attack = random.Next(1, 11);
//         hero -= attack;
//         Console.WriteLine($"The monster took a big swing at the hero the damage has taken away {hero} of heros health.");
//     }


// } while (hero != 0 | monster != 0);

//Solution from Microsoft.
int hero = 10;
int monster = 10;

Random dice = new Random();
do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now the monster health {monster}");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);
Console.WriteLine(hero > monster ? "hero wins" : "monster wins");