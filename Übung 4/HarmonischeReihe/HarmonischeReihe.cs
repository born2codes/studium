Console.WriteLine("Berechnung der harmonischen Reihe");
Console.Write("Bis zu welchem n? ");
string? eingabe = Console.ReadLine();
int n = Convert.ToInt32(eingabe);

double summe = 0;

for (int i = 1; i <= n; i++)
{
    summe += 1.0 / i;
}

Console.WriteLine($"Summe bis 1/{n}: {summe}");

