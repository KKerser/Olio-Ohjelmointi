/*
 * Krister kovalenko
 */
//Elain program.cs
using Elain;

internal class Program
{
    static void Main(string[] args)
    {
        Koira KoiraOlio = new Koira("Rekku","Saksanpaimenkoira", 4, "Harmaa", 32.0f); //luodaan uusi koira -olio


        //Tässä lisätään uudelle Koira -oliolle ominaisuudet,
        //sillä tällä hetkellä  KoiraOlio on tyhjä Olio ilman mitään ominaisuuksia 
        KoiraOlio.Nimi = "Rekku";
        KoiraOlio.Rotu = "Saksanpaimenkoira";
        KoiraOlio.Ikä = 4;
        KoiraOlio.Väri = "Harmaa";
        KoiraOlio.Paino = 32.0f;

        //kutsutaan KoiraOlio Metodilla "Hauku"
        KoiraOlio.Hauku();

        /*Kirjoitetaan Konsoliin KoiraOlion tiedot.
         * HUOM: Koira -olion tiedot noudetaan string muodossa  kun taas 
         * "Hauku()" metodi taas kirjoittaa Koira.cs luokan sisällä konsoliin */
        Console.WriteLine(KoiraOlio.HaeTiedot());

        //Haukutaan vielä kerran 
        KoiraOlio.Hauku();
    }
}
