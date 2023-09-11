Console.WriteLine("Guard - What is your reason for exiting the kingdom?");
string reason = Console.ReadLine().ToUpper();
if (reason == "FAME" || reason == "GLORY" || reason == "POWER")
{
    Console.WriteLine("Wow. That is some fucking dream of yours. You seem like a nice person, and you know what. I DONT LIKE NICE PEOPLE");
    Console.WriteLine("*The Guard immediately raises his spear, and thrusts it into your chest, killing you swiftly*");
    Console.WriteLine(
        "Game Over. You suck");
        Console.ReadLine();
}
else
{
    Console.WriteLine("Guard - Just kidding. I don't give a fuck, just go already. You're an insult to this kingdom");
    string insult = Console.ReadLine().ToUpper();
    if (insult == "FUCK OFF" || insult == "FUCK YOU" || insult == "ASSHOLE")
    {
        Console.WriteLine("Hey, what did you just call me?");
        Console.WriteLine("*The guard, raging with anger, THROWS the spear right between your eyes, killing you swiftly*");
    }
    else
    Console.WriteLine("*A voice rings in your ears, with no source. It asks you*");
    Console.WriteLine("What is your name, brave adventurer?");
    string name = Console.ReadLine().ToUpper();
    if (name == "LEO")
    {
        Console.WriteLine("*You hear the same voice, etched deep into your mind. It screams.*");
        Console.WriteLine("Traitor to the gods detected. Commensing immediate divine punishment!");
        Console.WriteLine("*A lightning bolt brigther and stronger than anything you've ever seen before strikes right where you stand, killing you instantly*");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine($"Welcome {name}, to the world of [?¤=!%/#&%]");
    }
}


Console.ReadLine();