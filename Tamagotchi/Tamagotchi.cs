using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Tamagotchi;

public class Tamagotchi
{
    private int hunger;
    private int boredom;
    private List<string> words = new();
    private bool isAlive = true;
    private Random Generator = new Random();
    public string Name;

    public void Feed()
    {
        hunger--;
    }

    public void Hi()
    {
        Console.WriteLine(words);
        ReduceBoredom();

    }

    public void Teach(string word)
    {
        words.Add(word);
    }
    public void Tick()
    {
        hunger++;
        boredom++;
        isAlive = hunger > 10 && boredom > 10;
    }
    public void PrintStats()
    {
        if (hunger == 9)
        {
            Console.WriteLine($"{Name} is starving, feed it quickly!");
        }

        if (boredom == 9)
        {
            Console.WriteLine($"{Name} is depressed, entertain it quickly!");
        }

        else if (hunger >= 3 && hunger != 9)
        {
            Console.WriteLine($"{Name} is getting hungry");
        }

    }
    public bool GetAlive()
    {
        return true;
    }
    private void ReduceBoredom()
    {

    }
}
