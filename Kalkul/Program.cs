using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Kalkulator
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                Run();
            }

            static void Run()
            {
                Console.Clear();
                Menu(); int wyb = int.Parse(Console.ReadLine());
                switch (wyb)
                {
                    case 1: Sum(); Dalej(); break;
                    case 2: Roz(); Dalej(); break;
                    case 3: Iloczyn(); Dalej(); break;
                    case 4: Iloraz(); Dalej(); break;
                    case 5: Pot(); Dalej(); break;
                    case 6: Pierw(); Dalej(); break;
                    case 7: FunkTryg(); Dalej(); break;
                    case 8: break;
                    default:
                        Console.WriteLine("Ups coś źle zostało wpisane(kliknij cokolwiek aby kontynuować)");
                        Console.ReadKey();
                        Run(); break;
                }
            }
        
        static void Menu()
        {
            Console.WriteLine("Wyb co potrzebujesz:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Róż");
            Console.WriteLine("3. Ilocz");
            Console.WriteLine("4. Iloraz");
            Console.WriteLine("5. Pot");
            Console.WriteLine("6. Pierw");
            Console.WriteLine("7. Funk tryg");
            Console.WriteLine("8. End");
            Console.WriteLine();
        }
        static void Sum()
        {
            Console.Write("Pod pierw licz:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Pod drug licz:");
            double b = double.Parse(Console.ReadLine());
            double wynik = a + b;
            Console.WriteLine("Sum liczb {0} i {1}: " + wynik, a, b);
        }
        static void Roz()
        {
            Console.Write("Pod odjemną:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Pod odjemnik:");
            double b = double.Parse(Console.ReadLine());
            double wynik = a - b;
            Console.WriteLine("Róż liczb {0} i {1}: " + wynik, a, b);
        }
        static void Iloczyn()
        {
            Console.Write("Pod 1 czynn: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Pod 2 czynnik: ");
            double b = double.Parse(Console.ReadLine());
            double wynik = a * b;
            Console.WriteLine("Ilocz liczb {0} i {1}: " + wynik, a, b);
        }
        static void Iloraz()
        {
            Console.Write("Pod dzielną: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Pod dzielnik: ");
            double b = double.Parse(Console.ReadLine());
            if (b == 0)
                Console.WriteLine("Nie można przez 0");
            else
            {
                double wynik = a / b;
                Console.WriteLine("Ilor liczb {0} i {1}: " + wynik, a, b);
            }
        }
        static void Pot()
        {
            Console.Write("Pod pod: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Pod wykł: ");
            double b = double.Parse(Console.ReadLine());
            double wynik = Math.Pow(a, b);
            Console.WriteLine("Pot licz {0} do licz {1}: "+wynik, a, b);
        }
        static void Pierw()
        {
            Console.Write("Pod licz: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Pod stop pierw: ");
            double b = double.Parse(Console.ReadLine());
            double wynik = Math.Pow(a, 1d / b);
            Console.WriteLine("Pierw z licz {0} stop {1}: " + wynik, a, b);
        }
        static void FunkTryg()
        {
            Console.Write("Pod miar kąt: ");
            double a = double.Parse(Console.ReadLine());
            double wynik = Math.Sin(a);
            Console.WriteLine("Sin kąta o mierze {0}: "+ wynik, a);
            wynik = Math.Cos(a);
            Console.WriteLine("Cos kąta o mierze {0}: "+ wynik, a);
            wynik = Math.Tan(a);
            Console.WriteLine("Tang kąta o mierze {0}: "+ wynik, a);
        }
        static void Dalej()
        {
            Console.WriteLine("kliknij cokolwiek aby kontynuować");
            Console.ReadLine();
            Run();
        }
    }
    
}
