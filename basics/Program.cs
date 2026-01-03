using System;
class Program
{
    static void Stampa_menu()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("|    INSERISCI UN NUMERO(1-3)   |");
        Console.WriteLine("|    1.Maggiore di tre numeri   |");
        Console.WriteLine("|        2.Stampa caratteri     |");
        Console.WriteLine("|  3.Somma primi 50 numeri pari |");
        Console.WriteLine("|                               |");
        Console.WriteLine("---------------------------------");
    }
    static void Main(){
        Stampa_menu();
        Console.WriteLine("Scelta: ");
        int n=int.Parse(Console.ReadLine());
        switch (n){
            case 1:
                tre_numeri.Run();
                break;
            case 2:
                stringa.Run();
                break;
            case 3:

                break;
        }
    }
}