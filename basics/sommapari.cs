using System;
class sommapari()
{
    public static void Run()
    {
        Console.WriteLine("Stampa della somma di tutti i numeri pari da 1 a 50");
        int somma = 0;
        for (int i = 0; i < 50; i++)
        {
            if (i % 2 == 0)
            {
                somma += i;
            }
        }
        Console.WriteLine($"La somma dei numeri pari da 1 a 50 è: {somma}");
    }
}