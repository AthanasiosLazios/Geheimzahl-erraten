namespace Geheimzahl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random zufall = new Random();
            int geheimzahl = zufall.Next(1, 101); // Bis 100

           Console.WriteLine("Erraten Sie die geheime Zahl!");
           int benutzerversuch = Convert.ToInt32(Console.ReadLine());

            int versuche = 1;

            while (benutzerversuch != geheimzahl)
            {
                if (geheimzahl > benutzerversuch)
                {
                    Console.WriteLine("Zu niedrig!");
                }
                else
                    {
                    Console.WriteLine("Zu hoch!");
                }
                Console.WriteLine("Versuchen Sie es erneut!");
                benutzerversuch = Convert.ToInt32(Console.ReadLine());
                versuche++;
            } 
            Console.WriteLine("Geschafft!, Geheimzahl erraten.");
            Console.WriteLine($"Sie haben {versuche} Versuche gebraucht.");
        }
    }
}
