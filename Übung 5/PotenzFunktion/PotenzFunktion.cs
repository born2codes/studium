namespace Uebung
{
    class Program
    {
        // Potenzfunktion
        static double Potenz(double x, int n)
        {
            double potenz = 1;

            for (int i = 1; i <= n; i++)
                potenz *= x;

            return potenz;
        }

        // Hauptprogramm
        static void Main()
        {
            Console.Write("Basis eingeben: ");
            double basis = Convert.ToDouble(Console.ReadLine());
            Console.Write("Exponent eingeben: ");
            int exponent = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= exponent; i++)
                Console.WriteLine($"{basis}^{i}: {Potenz(basis, i),4}");
        }
    }
}