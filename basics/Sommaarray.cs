using System;
class Sommaarray{
    public static void Run(){
        int[] vettore = new int[10];
        int somma = 0, massimo = 0, minimo = 0;
        Console.WriteLine("Inserisci gli elementi dell'array: ");
        for (int i = 0; i < vettore.Length; i++){
            vettore[i] = int.Parse(Console.ReadLine());
            minimo = vettore[0];
            somma += vettore[i];
            if (vettore[i] > massimo)
            {
                massimo = vettore[i];
            }
            if (vettore[i] < minimo){
                minimo = vettore[i];
            }
        }
        Console.WriteLine($"la somma di tutti i valori dell' array è: {somma}");
        Console.WriteLine($"il massimo tra i valori inseriti è: {massimo}");
        Console.WriteLine($"il massimo tra i valori inseriti è: {minimo}");
    }
}