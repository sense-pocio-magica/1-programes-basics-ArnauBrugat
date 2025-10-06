namespace exercici7;

/* Defineix tres variables amb tres notes numèriques. 
Calcula la mitjana i mostra el resultat per pantalla. */ 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nota 1r trimestre: ");
        int nota1 = int .Parse(Console.ReadLine());
        Console.WriteLine("Nota 2n trimestre: ");
        int nota2 = int .Parse(Console.ReadLine());
        Console.WriteLine("Nota 3r trimestre: ");
        int nota3 = int .Parse(Console.ReadLine());
        int mitjanaNotes = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine($"La teva mitjana es de {mitjanaNotes}");
    }
}
