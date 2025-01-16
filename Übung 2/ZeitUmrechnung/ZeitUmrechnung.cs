/*
 * a)	Schreiben Sie ein Programm, dass eine Anzahl von Sekunden einliest und sie in der Form MI:SS ausgibt. 
 * Für die Berechnung benötigen Sie Modulo und ganzzahlige Division. Überlegen Sie sich anhand der Beispiele, was zu tun ist (69 Sek. = 1 min + 9 Sek.):
Anzahl Sekunden eingeben: 69
Das sind 01:09 Minuten.

Anzahl Sekunden eingeben: 48
Das sind 00:48 Minuten.
b)	Ergänzen Sie das Programm so, dass auch Stunden ausgegeben werden. Beispiel:
Anzahl Sekunden eingeben: 5427
Das sind 1:30:27 Stunden.
*/

Console.Write("Anzahl Sekunden eingeben: ");
int sek = Convert.ToInt32(Console.ReadLine());

int min = sek / 60;
int std = min / 60;
sek = sek % 60;
min = min % 60;

Console.WriteLine($"Das sind {std:00}:{min:00}:{sek:00} Stunden.");