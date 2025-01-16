class Program
{
    // Hamming-Abstand
    static int HammingDistance(string s1, string s2)
    {
        int ergebnis = 0;
        if (s1.Length != s2.Length)
            return -1; // verschieden lang, lassen sich nicht vergleichen
        else // s1.Length == s2.Length ... gleich lang
        {
            for (int i = 0; i < s1.Length; i++)
            {
                // zeichenweise: wenn nicht gleich, dann wird gezählt
                if (s1[i] != s2[i])
                    ergebnis++;
            }
        }
        return ergebnis;
    }

    static void Main(string[] args)
    {
        // Hamming-Abstand
        Console.Write("Hamming-Distance:\n");
        Console.WriteLine($"Foo, Bar\t{HammingDistance("Foo", "Bar")}");
        Console.WriteLine($"Hello, Hallo\t{HammingDistance("Hello", "Hallo")}");
        Console.WriteLine($"Prog, Prog\t{HammingDistance("Prog1", "Prog1")}");
        Console.WriteLine($"Hallo, Welt\t{HammingDistance("Hallo", "Welt")}");
    }
}
