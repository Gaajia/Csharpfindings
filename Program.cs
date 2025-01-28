int[] schedule = { 800, 1200, 1600, 2000 };
void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
{

  int diff = 0;
if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
} 
else 
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
}
}