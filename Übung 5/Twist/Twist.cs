static int Twist(int zahl)
{
    int twist = 0;

    while (zahl > 0)
    {
        int ziffer = zahl % 10;
        twist = twist * 10 + ziffer;
        zahl /= 10;
    }

    return twist;
}

// Hauptprogramm
int zahl = 4567;
Console.WriteLine($"{zahl} umgekehrt: {Twist(zahl)}");
zahl = 1234567890;
Console.WriteLine($"{zahl} umgekehrt: {Twist(zahl)}");
