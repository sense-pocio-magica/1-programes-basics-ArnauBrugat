namespace exercici14;

// Declara una paraula i fes que el programa imprimeixi només la primera lletra, l'última lletra i la lletra del mig 
class Program
{
    static void Main(string[] args)
    {
        string paraula = "Programacio";
        char primeraLletra = paraula[0];
        char ultimaLletra = paraula[paraula.Length - 1];
        char lletraDelMig = paraula[paraula.Length / 2];
        Console.WriteLine($"La primera lletra és: {primeraLletra}");
        Console.WriteLine($"L'última lletra és: {ultimaLletra}");
        Console.WriteLine($"La lletra del mig és: {lletraDelMig}");
    }
}
