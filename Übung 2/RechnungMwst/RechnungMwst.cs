// Programm mit Top-Level Statements:
// Der Programmcode des Hauptprogramms beginnt sofort,
// ohne Klassendefinition und Main

const double steuerSatz = 0.19;

Console.Write("Nettobetrag eingeben: ");

double nettoBetrag = Convert.ToDouble(Console.ReadLine());

Console.Write("Vorauszahlung mit 3% Rabatt (ja/nein): ");
String voraus = Console.ReadLine();

double rabatt = 0;

if (voraus == "ja")
    rabatt = 0.03 * nettoBetrag;

double mwst = (nettoBetrag - rabatt) * steuerSatz;
double bruttoBetrag = (nettoBetrag - rabatt) + mwst;

// kleiner Tipp - wenn das Euro-Zeichen richtig kommen soll
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine();
Console.WriteLine($"Betrag: {nettoBetrag,8:f2} €");
Console.WriteLine($"Rabatt: {-rabatt,8:f2} €");
Console.WriteLine($"Mwst:   {mwst,8:f2} €");
Console.WriteLine($"------------------");
Console.WriteLine($"Gesamt: {bruttoBetrag,8:f2} €");

// Fenster geöffnet lassen, bis Taste gedrückt wird
Console.ReadKey();
