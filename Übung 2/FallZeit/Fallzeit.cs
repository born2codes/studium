// Hauptprogramm mit Klassendefinition und Main()-Methode,
// ohne Top-Level Statements
class Program
{
    static void Main()
    {
        const double g = 9.80665; // Gravitationskonstante

        Console.Write("Höhe des Körpers (in Meter): ");

        string eingabe = Console.ReadLine();
        double hoehe = Convert.ToDouble(eingabe);

        if (hoehe < 0)
        {
            Console.WriteLine("Ungültige Höhe.");
        }
        else
        {
            double zeit = Math.Sqrt(2 * hoehe / g);

            Console.WriteLine($"Die Fallzeit beträgt {zeit:f2} Sekunden.");
        }
    }
}
