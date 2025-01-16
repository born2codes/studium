Console.WriteLine("Bitte geben Sie drei Zahlen ein:");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Vor Rotation:");
Console.WriteLine($"a = {a}, b = {b}, c = {c}");
Console.WriteLine("Nach Rotation:");

// Rotation
int merker = a;
a = b;
b = c;
c = merker;

Console.WriteLine($"a = {a}, b = {b}, c = {c}");
