Console.Write("Geben Sie Ihren Namen an: ");
string name = Console.ReadLine();

Console.Write("(H)err oder (F)rau: ");
string anrede = Console.ReadLine();

if (anrede == "H" || anrede == "h")
{
    Console.WriteLine("Hallo, Herr " + name + "!");
}
else if (anrede == "F" || anrede == "f")
{
    Console.WriteLine("Hallo, Frau " + name + "!");
}
else
{
    Console.WriteLine("Ungültige Anrede!");
}
