


Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("---------------------------------");
Console.WriteLine("  Multiplier   Calculator   ");
Console.WriteLine("---------------------------------");

Console.WriteLine("Please Enter Your 1rd Number: ");
int No1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter Your 2nd Number:");
int No2 = Convert.ToInt32(Console.ReadLine());
int Answer = No1 * No2;
Console.WriteLine("Here is The Answer: " + Answer );

