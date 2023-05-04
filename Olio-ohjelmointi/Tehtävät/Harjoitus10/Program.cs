using Harjoitus10;

internal class Program
{
    private static void Main(string[] args)
    {
        Varis varis = new Varis("Varis", 90);

        varis.MakeAsound();
        varis.Fly();

        Kala ahven = new Kala("Ahven", 50, "blurps");

        ahven.MakeAsound();
        ahven.swim();
    }
}