class MeilenKm
{
    public static void Main()
    {
        const double factorMileKm = 1.609344;

        Console.Write("Umrechung von Meilen in km und umgekehrt\n" +
                      "========================================\n" +
                      "1) Meilen in km\n" +
                      "2) km in Meilen\n" +
                      "Wählen Sie: ");
        string auswahl = Console.ReadLine();

        if (auswahl == "1")
        {
            Console.Write("Geben Sie die Entfernung in Meilen ein: ");

            double mi = Convert.ToDouble(Console.ReadLine());
            double km = mi * factorMileKm;

            Console.WriteLine($"\n{mi} Meilen entsprechen {km} km.");
        }
        else if (auswahl == "2")
        {
            Console.Write("Geben Sie die Entfernung in Kilometer ein: ");

            double km = Convert.ToDouble(Console.ReadLine());
            double mi = km / factorMileKm;

            Console.WriteLine($"\n{km} km entsprechen {mi} Meilen.");
        }
        else
        {
            Console.WriteLine("Ungültige Auswahl.");
        }
    }
}
