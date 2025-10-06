namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
    static void Main(string[] args)
    {
        string producte = "Portàtil";
        double preu = 799.99;
        bool enEstoc = true;
        Console.WriteLine($"Producte: {producte}");
        Console.WriteLine($"Preu: {preu} EUR");
        Console.WriteLine($"En estoc: {enEstoc}");
    }
}
