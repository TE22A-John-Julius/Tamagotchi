using Tamagotchi;

Console.WriteLine("Welcome to Tamagotchi!");

Tamagotchis newTamagotchi = new();

Console.WriteLine("Please name your Tamagotchi:");

newTamagotchi.name = Console.ReadLine();

Console.WriteLine($"You have named your tamagotchi {newTamagotchi.name}");

Console.ReadLine();
while (newTamagotchi.GetAlive() == true)
{
    Console.Clear();
    newTamagotchi.PrintStats();
    Console.WriteLine("What would you like to do?");
    Console.WriteLine($"1. Teach {newTamagotchi} a new word");
    Console.WriteLine($"2. Feed {newTamagotchi}");
    Console.WriteLine($"3. Do nothing");

    string activity = Console.ReadLine();
    if (activity == "1")
    {
        Console.WriteLine($"What word would you like to teach {newTamagotchi.name}");
        
    }
}


//Weapon axe = new();

//int damage = axe.Attack();

//Console.WriteLine(damage);

Console.ReadLine();