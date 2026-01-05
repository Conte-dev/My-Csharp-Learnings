using System;
class stringa{
     public static void Run()
    {
        Console.WriteLine("inserisci una stringa: ");
        string parola = Console.ReadLine();
        Console.WriteLine("la stringa contiene i seguenti caratteri: ");
        foreach (char i in parola)
        {
            Console.WriteLine(i);
        }
    }
}
