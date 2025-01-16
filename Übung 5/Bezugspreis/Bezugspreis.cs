// Funktion zur Berechnung eines Bezugspreises unter Berücksichtigung von
// Versandkosten und Rabatt 
static double Bezugspreis(double listenPreis, int versandArt, double rabatt = 0)
{
    // Variable für Return-Wert
    double preis = listenPreis;

    // Rabatt-Berechnung
    if (rabatt < 0)
        return -1; // Fehlerfall
    preis -= preis * rabatt / 100.0;

    // Versandkosten-Berechnung - hier mal mit switch-Expression
    double porto = versandArt switch
    {
        1 => 4.90, // Päckchen
        2 => 6.50, // Paket < 10kg
        3 => 12.00, // Paket > 10kg
        _ => -1 // Fehlerfall
    };
    if (porto < 0)
        return -1; // Fehlerfall

    preis += porto;

    return preis;
}

Console.WriteLine($"Fall 1: Preis = {Bezugspreis(125, 2, 10):0.00} Euro");
Console.WriteLine($"Fall 2: Preis = {Bezugspreis(200, 1, 3):0.00} Euro");
Console.WriteLine($"Fall 3: Preis = {Bezugspreis(375, 3, 0):0.00} Euro");
Console.WriteLine($"Fehler: Preis = {Bezugspreis(50, 4, 0):0.00} Euro");
Console.WriteLine($"Fehler: Preis = {Bezugspreis(150, 1, -1):0.00} Euro");

Console.ReadKey();
