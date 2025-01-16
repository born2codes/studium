namespace Uebung;

class BalkenDiagramm
{
    // Zeichnet ein BalkenDiagramm mit den Werten des Feldes f
    static void ZeichneBalkenDiagramm(int[] feld)
    {
        for (int i = 0; i < feld.Length; i++)
        {
            Console.Write("{0,2} ", feld[i]);
            for (int j = 0; j < feld[i]; j++)
                Console.Write('\u2584'); // Zeichen "Halbblock unten"
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int[] f = { 10, 20, 15, 18, 2, 6 };

        ZeichneBalkenDiagramm(f);

        Console.WriteLine("\n\n\n");
    }
}
