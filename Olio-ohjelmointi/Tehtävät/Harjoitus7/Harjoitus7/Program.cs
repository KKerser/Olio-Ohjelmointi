//Krister Kovalenko
//Program.cs - Hissi

using Harjoitus7;

internal class Program
{
    static void Main(string[] args)
    {
        Hissi hissi = new Hissi(1, 6);


        int uusiKerros = 0;

        hissi.TulostaKerros();

        while (true)
        {
            Console.WriteLine();
            Console.Write("Anna uusi kerros 1-6: ", hissi.PalautaMaxMin());

            bool tarkista = int.TryParse(Console.ReadLine(), out uusiKerros);

            if (tarkista)
            {
                hissi.Kerros = uusiKerros;
            }


            hissi.TulostaKerros();
        }


    }
}