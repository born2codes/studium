namespace Uebung
{
    class Program
    {
        static int QuerSumme(int zahl)
        {
            int summe = 0;
            while (zahl > 0)
            {
                summe += zahl % 10;
                zahl /= 10;
            }

            return summe;
        }

        static int QuerProdukt(int zahl)
        {
            if (zahl == 0)
                return 0;

            int produkt = 1;
            while (zahl > 0)
            {
                produkt *= zahl % 10;
                zahl /= 10;
            }

            return produkt;
        }

        static bool IstQuerZahl(int zahl)
        {
            return QuerSumme(zahl) + QuerProdukt(zahl) == zahl;
        }

        // Hauptprogramm
        static void Main()
        {
            for (int zahl = 2; zahl < 1000; zahl++)
            {
                // Console.WriteLine($"{zahl,5} {QuerSumme(zahl),5} {QuerProdukt(zahl),5}");
                if (IstQuerZahl(zahl))
                    Console.WriteLine($"{zahl} ist eine Querzahl!");
            }
        }
    }
}