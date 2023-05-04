/*
 * Krister Kovalenko
 */
//Harjoitus1 Program.cs
using Harjotus1;

internal class Program
{
    private static void Main(string[] args)
    {
        Ajoneuvo Auto = new Ajoneuvo("Ford" , 60 , 4); 
        
        Console.WriteLine(Auto.TulostaData());
    }
}