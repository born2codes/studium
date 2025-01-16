namespace Uebung;

class Program
{
    // Dreht den Feld-Inhalt um
    static void Reverse(int[] a)
    {
        for (int i = 0; i < a.Length / 2; i++)
        {
            int temp = a[i];
            a[i] = a[a.Length - 1 - i]; // oder a[^(1+i)]
            a[a.Length - 1 - i] = temp;
        }
    }

    static void Main()
    {
        int[] f = { 6, 7, 4, 3, 2, 5, 9 };

        Reverse(f);

        // jetzt sollte f = { 9, 5, 2, 3, 4, 7, 6 } sein
        for (int i = 0; i < f.Length; i++)
            Console.Write(f[i] + " ");
        Console.WriteLine();

        // Original-Reihenfolge mit Standard-Funktion wieder herstellen
        Array.Reverse(f);
        for (int i = 0; i < f.Length; i++)
            Console.Write(f[i] + " ");
        Console.WriteLine();
    }
}