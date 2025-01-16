class Program
{
    static void SeparatorCounter(string s, out int period, out int comma, out int semicolon)
    {
        period = 0;
        comma = 0;
        semicolon = 0;

        for (int i = 0; i < s.Length; i++)
            if (s[i] == '.')
                period++;
            else if (s[i] == ',')
                comma++;
            else if (s[i] == ';')
                semicolon++;
    }

    static void Main(string[] args)
    {
        int punkt, komma, semi;
        string test = "A, B, C; D; E; F. G; H; I";

        SeparatorCounter(test, out punkt, out komma, out semi);

        Console.WriteLine("Punkte: " + punkt);
        Console.WriteLine("Kommas: " + komma);
        Console.WriteLine("Semikolons: " + semi);
    }
}
