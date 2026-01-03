
using System;
class tre_numeri
{
    public static void Run(){ 
        int n = 0, mag = 0;
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("inserisci un numero intero:");
            n = int.Parse(Console.ReadLine());
            if (n > mag)
            {
                mag = n;
            }
        }
        Console.WriteLine($"Il maggiore tra i numeri inseriti è {mag}");
    }
} 
