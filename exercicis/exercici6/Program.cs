namespace exercici6;

/* Declara una variable per al costat d'un quadrat. Calcula el seu perímetre (suma dels quatre costats) 
i imprimeix-lo. */

class Program
{
    static void Main(string[] args)
    {
        int CostatCuadrat = 14;
        int Perimetre = CostatCuadrat * 4;
        Console.WriteLine($"El perimetre del cuadrat amb els costats de {CostatCuadrat} cm, és {Perimetre}");
    }
}
