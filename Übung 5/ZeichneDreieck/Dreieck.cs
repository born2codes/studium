class Program
{
    static void ZeichneDreieck(int n, char c = '*', bool zentriert = false)
    {
        // Man könnte jetzt die beiden Code-Blöcke auch in einen zusammenfassen,
        // weil die Schleifen ja im Prinzip das Gleiche machen.
        // Versuchen Sie mal, den Code umzustellen!
        if (!zentriert)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(c);

                Console.WriteLine();
            }
        }
        else // zentriert
        {
            for (int i = 1, leer = n-1; i <= n; i++, leer--)
            {
                // Leerzeichen vorher einfügen
                for (int j = 1; j <= leer; j++)
                    Console.Write(' ');

                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write(c);

                Console.WriteLine();
            }
        }
    }

    static void Main()
    {
        ZeichneDreieck(6, '$');
        Console.WriteLine();
        ZeichneDreieck(3);
        Console.WriteLine();
        ZeichneDreieck(5, '#', true);
    }
}