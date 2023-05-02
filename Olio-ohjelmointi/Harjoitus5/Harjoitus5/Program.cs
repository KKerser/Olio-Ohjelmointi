//KRister Kovalenko
//Program.cs - Laskin
using Harjoitus5;

internal class Program
{
    private static void Main(string[] args)
    {
        float a = 5f;
        float b = 2.5f;

        float summa = Laskin.Summa(a, b);
        float Erotus = Laskin.Erotus(a, b);
        float Kertolasku = Laskin.Kertolasku(a, b);
        float Jakolasku = Laskin.Kertolasku(a, b);

        Console.WriteLine("Numeroiden (0) ja (1):", a, b);
        Console.WriteLine("Summa: " + summa);
        Console.WriteLine("Erotus: " + Erotus);
        Console.WriteLine("Kertolasku" + Kertolasku);
        Console.WriteLine("Jakolasku: " + Jakolasku);
    }
}