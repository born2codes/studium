// Iterativ
static double Potenz(double x, int n)
{
    double potenz = 1;

    for (int i = 1; i <= n; i++)
        potenz *= x;

    return potenz;
}

// Rekursiv
static double PotenzRek(double x, int n)
{
    if (n == 0)
        return 1;
    else
        return x * PotenzRek(x, n - 1);
}

// Hauptprogramm zum Test:  
Console.Write("Basis eingeben: ");
double basis = Convert.ToDouble(Console.ReadLine());
Console.Write("Exponent eingeben: ");
int exponent = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{basis} hoch {exponent}: {PotenzRek(basis, exponent)}");

