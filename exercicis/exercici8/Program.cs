namespace exercici8;

/* Assigna un nombre total de minuts a una variable. 
   Calcula quantes hores senceres i minuts restants són i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        int minuts = 111;
        int hora = 60;

        int hores = minuts / hora;
        int minutsRestants = minuts % hora;

        Console.WriteLine($"{minuts} minuts són {hores} hores i {minutsRestants} minuts.");
    }
}
