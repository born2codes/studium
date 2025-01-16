namespace Uebung;

class Program
{
    // Selection Sort
    static void Sort(int[] f)
    {
        for (int i = 0; i < f.Length; i++)
        {
            // Suche Index der nächstkleinsten Zahl
            int minIdx = i;
            for (int j = i + 1; j < f.Length; j++)
            {
                if (f[j] < f[minIdx])
                    minIdx = j;
            }

            // tausche Feldwert mit nächstkleinster Zahl
            int tmp = f[i];
            f[i] = f[minIdx];
            f[minIdx] = tmp;
        }
    }

    // Hauptprogramm
    static void Main()
    {
        int[] a = { 5, 8, 3, 2, 9, 8 };

        Sort(a);

        for (int i = 0; i < a.Length; i++)
            Console.Write(a[i] + " ");
        Console.WriteLine();
    }
}
