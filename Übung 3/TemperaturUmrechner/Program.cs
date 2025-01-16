Console.WriteLine(" °C   | °F");
Console.WriteLine("------+------");
for (int celsius = 0; celsius <= 100; celsius += 4)
{
    double fahrenheit = 9.0 / 5.0 * celsius + 32;
    Console.WriteLine($"{celsius,5:f1} |{fahrenheit,5:f1}");
}

