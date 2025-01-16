namespace Uebung
{
    class Program
    {
        // 2D-Array: Spalten- und Zeilensummen
        static void FeldAusgeben(int[,] f)
        {
            for (int z = 0; z < f.GetLength(0); z++)
            {
                for (int s = 0; s < f.GetLength(1); s++)
                {
                    Console.Write($"{f[z, s]} ");
                }
                Console.WriteLine();
            }
        }

        static int ZeileSpalte(int k, int[,] m)
        {
            int summe = 0; // mit 0 initialisieren spart den else-Zweig

            if (k >= 0) // keine negativen Indizes
            {
                if (k < m.GetLength(0)) // Es gibt die Zeile.
                {
                    for (int i = 0; i < m.GetLength(1); i++) // Anzahl aller Spalten
                    {
                        summe += m[k, i];
                    }
                }
                if (k < m.GetLength(1)) // Es gibt die Spalte.
                {
                    for (int i = 0; i < m.GetLength(0); i++) // Anzahl aller Zeilen
                    {
                        summe -= m[i, k];
                    }
                }
            }

            return summe;
        }

        static void Main(string[] args)
        {
            //Spalten- und Zeilensummen
            Console.Write("\nSpalten- und Zeilensummen:\n");
            int[,] meinFeld = { { 1, 2, 6, 8 }, 
                                { 3, 4, 7, 2 }, 
                                { 5, 6, 5, 4 }, 
                                { 7, 8, 9, 1 }, 
                                { 8, 7, 1, 2 }, 
                                { 2, 9, 2, 1 } };
            FeldAusgeben(meinFeld);
            Console.WriteLine("\nRechnung Zeilen/Spalten");
            int meineSumme = ZeileSpalte(2, meinFeld);
            Console.WriteLine($"Summe: {meineSumme}\n");
        }
    }
}