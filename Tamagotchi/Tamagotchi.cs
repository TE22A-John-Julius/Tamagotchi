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
        if (hunger < 0)
        {
            hunger = 0;
        }
        hunger--;
    }

    public void Hi()
    {
        if (words.Count < 1)
        {
            Console.WriteLine($"They don't know any words");
        }
        else
        {
            int wordNumber = Random.Shared.Next(words.Count);
            Console.WriteLine($"{Name} says {words[wordNumber]}");
        }
        ReduceBoredom();

    }

    public void Teach(String word)
    {
        Console.WriteLine($"{Name} has learned {word}");
        words.Add(word);
        ReduceBoredom();
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
        
        else if(boredom >= 3 && boredom != 9)
        {
            Console.WriteLine($"{Name} is getting bored");
        }
        else if (hunger == 10 || boredom == 10 ){
            isAlive = false;
        }
        else
        {
            Console.WriteLine($"You're tamagotchi is happy and fed");
        }
    }
    public bool GetAlive()
    {
        isAlive = true;
        return isAlive;
    }
    private void ReduceBoredom()
    {
        boredom --;
        if (boredom < 0)
        {
            boredom = 0;
        }
    }
}
