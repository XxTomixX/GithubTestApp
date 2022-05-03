using System;
using TestowaBiblioteka;

namespace GithubTestApp
{
    class Program
    {
        static int Main(string[] args)
        {
            double wynik = MathCalculations.Add(5, 5);
            Console.WriteLine("Wynik operacji: "+wynik);
            return 0;
        }
    }
}
