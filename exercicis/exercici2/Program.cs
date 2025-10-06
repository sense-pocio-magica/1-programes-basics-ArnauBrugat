namespace exercici2;

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

class Program
{
    static void Main(string[] args)
    {
        string carrer = "Carrer de l'Exemple";
        int numero = 123;
        int codiPostal = "08001";
        string poblacio = "Barcelona";

        Console.WriteLine($"Adreça: {carrer}, {numero}, {codiPostal} {poblacio}");
    }
}
