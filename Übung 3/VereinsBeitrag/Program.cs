Console.WriteLine("Beitragsrechnung für einen Verein");
Console.WriteLine("=================================");
Console.Write("Geben Sie Ihr Alter ein: ");
int alter = Convert.ToInt32(Console.ReadLine());

double beitrag;

if (alter <= 6)
    beitrag = 0;
else if (alter <= 17)
    beitrag = 30;
else if (alter <= 65)
{
    Console.Write("Sind Sie erwerbslos (j/n): ");
    string antwort = Console.ReadLine()!;
    if (antwort == "j")
        beitrag = 40;
    else 
        beitrag = 80;
}
else
    beitrag = 50;

Console.WriteLine($"Ihr Beitrag ist {beitrag} Euro.");

