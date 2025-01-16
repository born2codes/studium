class Program
{
    // Vertauscht die Werte der beiden Parameter
    static void Exchange(ref double x, ref double y)
    {
        double tmp = x;
        x = y;
        y = tmp;
    }

    static void Main()
    {
        // Hauptprogramm
        double zahl1 = 17;
        double zahl2 = 23;

        Console.WriteLine($"zahl1 = {zahl1}, zahl2 = {zahl2}");
        Exchange(ref zahl1, ref zahl2);
        Console.WriteLine("Exchange!");
        Console.WriteLine($"zahl1 = {zahl1}, zahl2 = {zahl2}");

        /*
        Geht nicht:

        int zahl3 = 12;
        int zahl4 = 34;
        Exchange(ref zahl3, ref zahl4);

        Grund: Bei Call-by - Reference wird ja die Speicherreferenz übergeben
        Damit das funktioniert muss die übergebene Variable vom gleichen Typ
        wie der Parameter sein.
        Man kann ja nicht einfach mit den Bits einer Integer-Zahl
        den Speicher einer Double-Variablen überschreiben.
        */
    }
}