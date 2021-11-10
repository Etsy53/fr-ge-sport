using System;
Console.WriteLine("vad är 1+1");
string answer = Console.ReadLine();
int points = 0;
if (answer == "2")
{
    Console.WriteLine("Du hade RÄTT!!!");
    Console.WriteLine("Grattis Du Fick 1 Poäng");
    points = points + 1;
    Console.ReadLine();
}


Console.WriteLine("vad är 5x5");
answer = Console.ReadLine();
if (answer == "25")
{
    Console.WriteLine("Du hade RÄTT!!!");
    Console.WriteLine("Grattis Du Fick 1 Poäng");
    points = points + 1;
    Console.ReadLine();
}

Console.WriteLine("vad är 10x10");
answer = Console.ReadLine();
if (answer == "100")
{
    Console.WriteLine("Du hade RÄTT!!!");
    Console.WriteLine("Grattis Du Fick 1 Poäng");
    points = points + 1;
    Console.ReadLine();
}

Console.WriteLine($"grattis, du fick {points} poäng");

Console.ReadLine();
