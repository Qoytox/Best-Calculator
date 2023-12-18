
using System.Formats.Asn1;
Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("---------------------------------");
Console.WriteLine("            Calculator           ");
Console.WriteLine("---------------------------------");

Console.WriteLine("Please Enter Your Symbol: ");
string sy = Console.ReadLine();
double Answer;
Console.WriteLine("Please Enter Your 1rd Number: ");
double No1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please Enter Your 2nd Number:");
double No2 = Convert.ToDouble(Console.ReadLine());
if (sy == "+");
{
 double Answer = No1 + No2;
}

if (sy == "-"){
    double Answer = No1 - No2;
}

if (sy == "/");{
 double Answer = No1 / No2;
}

if (sy == "*");{
 double Answer = No1 * No2;
}


Console.WriteLine("Here is Your Answer: " + Answer);


