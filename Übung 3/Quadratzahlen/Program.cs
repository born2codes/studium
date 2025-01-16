Console.Write("Zahl eingeben: ");
int zahl = Convert.ToInt32(Console.ReadLine());

Console.Write("Quadratzahlen bis max. " + zahl + ": ");

int quadrat = 1;
int i = 1;

// geht auch mit for-Schleife
while (i * i <= zahl)
{
    // Es gibt verschiedene Varianten, das "Innere" der Schleife zu gestalten
    // bzw. die Schleifenbedingung zu variieren. 
    // Wichtig ist, dass bei Eingabe der Zahl "120" am Ende nicht mehr die 121 
    // und zu Anfang auch nicht zweimal die 1 ausgegeben wird.
    quadrat = i * i;

    // Trick: Setze ein Komma vor allen Zahlen, außer der ersten
    if (i > 1)
        Console.Write(", ");
    Console.Write(quadrat);

    i++;
}

Console.ReadKey();
