class Heron
{
    // Funktion zur Berechnung der Wurzel (Square Root) nach Heron
    static double Sqrt(double x)
    {
        // Startwert
        double wurzel = x / 2;

        // Heron-Formel
        while (Math.Abs(x - wurzel * wurzel) > 1e-12)
            wurzel = 0.5 * (wurzel + x / wurzel);

        return wurzel;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Wurzelberechnung mit dem Heronverfahren:");
        for (double d = 0; d <= 100; d += 10)
        {
            Console.WriteLine($"{d,4}  | {Sqrt(d),8:F5} | {Math.Sqrt(d),8:F5} | {Math.Sqrt(d) - Sqrt(d),12}");
        }
        Console.WriteLine();
    }
}
