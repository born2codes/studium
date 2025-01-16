class Program
{
    // Hier nochmal die Funktion aus anderem Projekt reinkopiert. 
    // In der Praxis würden wir die Funktion aus dem anderen Projekt (andere Klasse)
    // einfach aufrufen - ohne den Code zu kopieren. Ist aber für die Übung einfacher so.
    static string EntferneZeichen(string s, params char[] sonderzeichen)
    {
        string ergebnis = "";

        foreach (char c in s)
        {
            bool istSonderzeichen = false;

            for (int i = 0; i < sonderzeichen.Length && !istSonderzeichen; i++)
                if (c == sonderzeichen[i])
                    istSonderzeichen = true;

            if (!istSonderzeichen)
                ergebnis += c;
        }

        return ergebnis;
    }


    // Palindrom-Test
    static bool IstPalindrom(string s)
    {
        s = EntferneZeichen(s, ' ', ',', ';', ':', '.', '!', '?', '-', '\'');
        s = s.ToUpper();

        // Zeichen in s müssen von vorn und hinten kommend übereinstimmen
        //for (int i = 0, j = s.Length - 1; i < s.Length / 2; i++, j--)
        //    if (s[i] != s[j])
        //        return false;

        // Ohne j geht es auch ganz einfach so:
        for (int i = 0; i < s.Length / 2; i++)
            if (s[i] != s[^(i + 1)])
                return false;

        return true;
    }


    static void Main(string[] args)
    {
        string[] texte = { "ANNA", "Anna", "legal", "Otto", "Lagerregal", "123421",
                               "Hermine - sie mag Ameisen im Reh.",
                               "Einhorn roh? Nie!" };

        foreach (var text in texte)
        {
            Console.Write($"\"{text}\" ist ");
            if (IstPalindrom(text))
                Console.WriteLine("ein Palindrom.");
            else
                Console.WriteLine("kein Palindrom.");
        }
    }
}
