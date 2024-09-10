using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Tamagotchi;

public class Tamagotchi
{
    private int Hunger;
    private int Boredom;
    private List<string> words;
    private bool IsAlive = true;
    private Random Generator = new Random();
    public string Name;

    public void Feed(){

    }
    
    public void Hi(){

    }
    public void Teach(){

    }
    public void Tick(){

    }
    public void PrintStats(){

    }
    public bool GetAlive(){
        return true;
    }
    private void ReduceBoredom(){

    }
}
