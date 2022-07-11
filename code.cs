using System;
class probelnetprobelyestprobelnet
{
    static void Main()
    {
        Console.WriteLine("Input one number");
        int number = Convert.ToInt32(Console.ReadLine());
        for (int howmuch = 0; howmuch < 4; howmuch++)
        {
            Console.Write($"{number}");
        }
        Console.WriteLine();
        for (int howmuch = 0; howmuch < 4; howmuch++)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
        for (int howmuch = 0; howmuch < 4; howmuch++)
        {
            Console.Write("{0}", number);
        }
        Console.WriteLine();
        for (int howmuch = 0; howmuch < 4; howmuch++)
        {
            Console.Write("{0} ", number);
        }
        Console.WriteLine();
        Console.ReadKey(true);
    }
}
