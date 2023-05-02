//Krister Kovalenko
//Program.cs - Eläimet

using Harjoitus6;

internal class Program
{
    private static void Main(string[] args)
    {
        Eläimet.KuinkaMonta();
            
        Koira Koira1 = new Koira();
        Koira1.Ääni();

        Kissa Kissa1 = new Kissa();
        Kissa1.Ääni();

        Eläimet.KuinkaMonta();

        Koira Koira2 = new Koira();
        Koira Koira3 = new Koira();

        Kissa Kissa2 = new Kissa();

        Kissa.KuinkaMonta();
        Koira.KuinkaMonta();
        Eläimet.KuinkaMonta();
    }
}