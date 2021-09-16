using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Partition.Player player = new Partition.Player();

        //Even we have divided into two partial class, when IDE compile this project, it will automatically combine into one single class.
        // Single Player class has both func() and Damage() methods.
        player.Func();
        player.Damage();

    }
}
