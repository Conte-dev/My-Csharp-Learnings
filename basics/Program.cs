using System;
class Program{
    static void Stampa_menu() {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("|    INSERISCI UN NUMERO(1-3)   |");
        Console.WriteLine("|          ESERCIZI BASE        |");
        Console.WriteLine("|    1.Maggiore di tre numeri   |");
        Console.WriteLine("|        2.Stampa caratteri     |");
        Console.WriteLine("|  3.Somma primi 50 numeri pari |");
        Console.WriteLine("|            ARRAY              |");
        Console.WriteLine("| 4.Somma di tutti gli elementi |");
        Console.WriteLine("|                               |");
        Console.WriteLine("---------------------------------");
    }
    static void Switch(){
        int scelta;
        do{
            Console.WriteLine("Scelta: ");
            scelta = int.Parse(Console.ReadLine());
            switch (scelta)
            {
                case 1:
                    tre_numeri.Run();
                    break;
                case 2:
                    stringa.Run();
                    break;
                case 3:
                    sommapari.Run();
                    break;
                case 4:
                    Sommaarray.Run();
                    break;
            }
        }while(scelta!= 0);
    }
    static void Main(){
        Stampa_menu();
        Switch();
        }
    }
