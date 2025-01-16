namespace Uebung;

class Program
{
    // Ausgabe Feld f
    static void Ausgabe(int[] f)
    {
        Console.Write("f = [");
        for (int i = 0; i < f.Length; i++)
            Console.Write((i != 0 ? ", " : "") + f[i]); // Trick für das Komma erspart ein "if"
        Console.WriteLine("]\n");
    }

    // Statistik, berechnet summe, durchschnitt, min, max
    static void FeldStatistik(int[] f, out int summe, out double durchschnitt, out int min, out int max)
    {
        summe = 0;
        min = f[0];
        max = f[0];

        for (int i = 0; i < f.Length; i++)
        {
            summe += f[i];
            if (f[i] < min)
                min = f[i];
            if (f[i] > max)
                max = f[i];
        }

        // Type-Cast zur Vermeidung von Integer-Division
        durchschnitt = (double)summe / f.Length;
    }

    static void Main()
    {
        int[] f = { 5, 8, 6, 4, 3, 5, 9, 2, 6, 9 };

        Ausgabe(f);

        FeldStatistik(f, out int summe, out double durchschnitt, out int min, out int max);
        Console.WriteLine("Summe: " + summe);
        Console.WriteLine("Durchschnitt: " + durchschnitt);
        Console.WriteLine("Maximum: " + max);
        Console.WriteLine("Minimum: " + min);

        // Zahl einlesen
        Console.Write("Zahl eingeben: ");
        int zahl = Convert.ToInt32(Console.ReadLine());

        Console.Write("Größer sind: ");

        for (int i = 0; i < f.Length; i++)
        {
            if (f[i] > zahl)
                Console.Write(f[i] + " ");
        }
        Console.WriteLine("\n");

        // C#-Standard-Funktionalität mit Linq
        Console.WriteLine($"Summe durch Linq: {f.Sum()}");
        Console.WriteLine();
        Console.WriteLine("Maximum durch Linq: " + f.Max());
        Console.WriteLine("Minimum durch Linq: " + f.Min());
    }
}
