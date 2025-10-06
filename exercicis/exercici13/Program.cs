namespace exercici13;

/* Un alumne ha inventat un sistema per codificar dates que consisteix a eliminar els separadors de les dates 
per fer no es vegi que són dates (la data 24/09/2024 la converteix en 24092024). 
El problema és que ho ha aplicat a tots els documents de l’institut i ara la direcció no sap 
ordenar els documents.

Necessitem un programa que faci el procés invers

Entra la data sense formatar: 25092024
La data és 25/09/2024

Entra la data sense formatar: 12031970
La data és 12/03/1970 */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entra la data sense formatar: ");
        string dataSenseFormatar = Console.ReadLine();

        if (dataSenseFormatar.Length == 8)
        {
            string dia = dataSenseFormatar.Substring(0, 2);
            string mes = dataSenseFormatar.Substring(2, 2);
            string any = dataSenseFormatar.Substring(4, 4);

            string dataFormatada = $"{dia}/{mes}/{any}";
            Console.WriteLine($"La data és {dataFormatada}");
        }
        else
        {
            Console.WriteLine("Error: La data ha de tenir 8 dígits.");
        }
    }
}
