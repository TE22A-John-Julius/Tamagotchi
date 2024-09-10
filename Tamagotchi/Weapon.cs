using System;

namespace Tamagotchi;

public class Weapon
{
    public string Name;
    public int MinDamage;
    public int MaxDamage;
    

    public Weapon ()
    {
        MinDamage = 10;
        MaxDamage = 20;
        Name = "Axe";
    }
    public int Attack()
    {
        Console.WriteLine($"Attack with {Name}");
        return Random.Shared.Next(MinDamage,MaxDamage);
    }
}
