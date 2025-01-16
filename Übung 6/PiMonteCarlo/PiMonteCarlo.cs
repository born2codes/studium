class Program
{
    static double Pi(int n = 1000000)
    {
        Random zufall = new Random();  // Anlegen des Zufallsgenerators; einmalig! 

        int drin = 0; // Anzahl der Treffer im Einheitskreis
        for (int i = 0; i < n; i++)
        {
            // Bestimmung der x und y Koordinate
            double x = zufall.NextDouble();
            double y = zufall.NextDouble();

            // Pythagoras-Test: Hypothenuse aus x^2 und y^2 kürzer als 1?
            if ((x * x + y * y) <= 1)
                drin++;
        }

        // Pi = 4 * Treffer/alle Versuche
        return 4.0 * drin / n;
    }

    // Hauptprogramm
    static void Main()
    {
        Console.WriteLine("Berechnung der Zahl PI:");
        double pi = Pi(100000);
        Console.WriteLine($"Pi: {pi} - {Math.PI} = {pi - Math.PI}");
    }
}
