namespace Uebung;

class Program
{
    // Zum Vergleich nochmal iterativ
    static int QuerSumme(int zahl)
    {
        int q = 0;

        while (zahl > 0)
        {
            q += zahl % 10;
            zahl /= 10;
        }

        return q;
    }

    // Jetzt rekursiv. Elegant, oder?
    static int QuerSummeRek(int zahl)
    {
        if (zahl < 10)
            return zahl;
        else
            return zahl % 10 + QuerSummeRek(zahl / 10);
    }

    static void Main(string[] args)
    {
        Console.Write("Zahl eingeben: ");
        int zahl = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"QuerSumme({zahl}) = {QuerSumme(zahl)}");
        Console.WriteLine($"QuerSummeRek({zahl}) = {QuerSummeRek(zahl)}");
    }
}
