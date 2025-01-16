string eingabe;

Console.Write("Anzahl Kinder eingeben: ");
eingabe = Console.ReadLine()!;
int anzahlKinder = Convert.ToInt32(eingabe);

Console.Write("Anzahl Ü-Eier eingeben: ");
eingabe = Console.ReadLine()!;
int anzahlEier = Convert.ToInt32(eingabe);

int eierProKind = anzahlEier / anzahlKinder;
int eierUebrig = anzahlEier % anzahlKinder;

Console.WriteLine("Es werden " + eierProKind + " pro Kind verteilt. " +
    eierUebrig + " Eier bleiben übrig.");

Console.ReadKey();
