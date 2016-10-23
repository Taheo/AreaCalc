using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static void RysujMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("Menu wyboru");
            Console.WriteLine("1. Stożek ");
            Console.WriteLine("2. Walec");
            Console.WriteLine("3. Kula");
            Console.WriteLine("4. Prostpoadłościan");
            Console.WriteLine("5. Ostrosłup o podstawie prostokątnej");
            Console.WriteLine("");
        }

        public static double PBstozka(double r, double l)
        {
            return (Math.PI * r * l);
        }

        public static double PPwalca(double r)
        {
            return (Math.PI*r* r);
        }

        public static double PBwalca(double r, double h)
        {
            return (Math.PI * r * h);
        }

        public static double Objwalca(double r, double h)
        {
            return Math.PI * r * r * h;
        }

        public static double Poleprosto(double a, double b, double h)
        {
            return 2 * (a * b + b * h + a * h);
        }

        public static double Objprosto(double a, double b, double h)
        {
            return a * b * h;
        }

        public static void Switcher(int willbeswitchnum)
        {
            
            switch (willbeswitchnum)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("Policzę pole stożka ");
                    Console.WriteLine("Podaj promień podstawy");
                    double r = double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj tworzącą");
                    double l = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Pole stożka = {PPwalca(r) + PBstozka(r, l)}");
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("Policzę pole walca");
                    Console.WriteLine("Najpierw policzymy pole podstawy");
                    Console.WriteLine("Podaj promień podstawy");
                    double rw = double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj wysokosc");
                    double h = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Pole walca = {2*PPwalca(rw) + PBwalca(rw, h)}");
                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("Policzę pole kuli");
                    break;
                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("Policzę pole prostopadłościanu");
                    Console.WriteLine("Podaj a");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj b");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj c");
                    double c = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Pole prostopadłościanu = {Poleprosto(a, b, c)}");
                    break;
                case 5:
                    Console.WriteLine("");
                    Console.WriteLine("Policzę pole ostrosłupa");
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("default...");
                    break;
            }
        }

        static void Main(string[] args)
        {
            RysujMenu();
            int switchnum = int.Parse(Console.ReadLine());
            Switcher(switchnum);

        }
    }
}
