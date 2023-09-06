
Console.WriteLine("Guard - What is your reason for exiting the kingdom?");
string reason = Console.ReadLine().ToUpper();
if (reason == "FAME" || reason == "GLORY" || reason == "POWER")
{
    Console.WriteLine("Wow. That is some fucking dream of yours. You seem like a nice person, and you know what. I DONT LIKE NICE PEOPLE");
    Console.WriteLine("*The Guard immediately raises his spear, and thrusts it into your chest, killing you swiftly*");
}
else
{
Console.WriteLine("Guard - Just kidding. I don't give a fuck, just go already. You're an insult to this kingdom");
string insult = Console.ReadLine().ToUpper();
}
if (insult == "FUCK OFF" || insult == "FUCK YOU" || insult == "ASSHOLE")
{
    Console.WriteLine("Hey, what did you just call me?");
    Console.WriteLine("*The guard, raging with anger, THROWS the spear right between your eyes, killing you swiftly*");
}


Console.WriteLine("What is your name, brave adventurer?");
string name = Console.ReadLine().ToUpper();


