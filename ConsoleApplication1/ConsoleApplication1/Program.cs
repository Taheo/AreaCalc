using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static void RysujMenuPola()
        {
            Console.WriteLine("");
            Console.WriteLine("Menu wyboru liczenia pól");
            Console.WriteLine("1. Stożek ");
            Console.WriteLine("2. Walec");
            Console.WriteLine("3. Kula");
            Console.WriteLine("4. Prostpoadłościan");
            Console.WriteLine("5. Ostrosłup o podstawie prostokątnej");
            Console.WriteLine("");
        }

        public static void RysujMenuObjetosci()
        {
            Console.WriteLine("");
            Console.WriteLine("Menu wyboru liczenia objętości");
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

        public static double PoleKuli(double r)
        {
            return 4 * Math.PI * r * r;
        }

        public static double Poleprosto(double a, double b, double h)
        {
            return 2 * (a * b + b * h + a * h);
        }

        public static double Objprosto(double a, double b, double h)
        {
            return a * b * h;
        }

        public static double PPostro(double a, double b)
        {
            return a * b;
        }

        public static double PBostro(double a, double h)
        {
            return  4*(a * h) * 0.5;
        }




        public static void SwitchMenuArea(int switchnumarea)
        {
            
            switch (switchnumarea)
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
                    double rk = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Pole walca = {PoleKuli(rk)}");
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
                    Console.WriteLine("Policzę pole podstawy");
                    Console.WriteLine("Podaj a");
                    double ao = double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj b");
                    double bo = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Pole podstawy = {PPostro(ao, bo)}");
                    Console.WriteLine("Policzę pole boczne");
                    Console.WriteLine("Podaj a");
                    double aob = double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj h");
                    double aoh = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Pole podstawy = {PBostro(aob, aoh)}");
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("default...");
                    break;
            }
        }
        public static void SwitchMenuVolumes(int switchnumvol)
        {
            switch (switchnumvol)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("Policzę objętość stożka ");
                    Console.WriteLine("Podaj promień podstawy");
                    double r = double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj h");
                    double h = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Objętość stożka = {0.33 * PPwalca(r) * h}");
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("Policzę objętość walca");
                    Console.WriteLine("Podaj promień podstawy");
                    double rw = double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj wysokosc");
                    double hw = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Objętość walca = {Objwalca(rw, hw)}");
                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("Policzę objętość kuli");
                    Console.WriteLine("Podaj promień");
                    double rk = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Objętość kuli = {4/3 * Math.PI * rk * rk * rk}");
                    break;
                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("Policzę pole prostopadłościanu");
                    Console.WriteLine("Podaj a");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj b");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj h");
                    double hp = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Objętość prostopadłościanu = {Objprosto(a, b, hp)}");
                    break;
                case 5:
                    Console.WriteLine("");
                    Console.WriteLine("Policzę objętość ostrosłupa");
                    Console.WriteLine("Policzę pole podstawy");
                    Console.WriteLine("Podaj a");
                    double ao = double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj b");
                    double bo = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Pole podstawy = {PPostro(ao, bo)}");
                    Console.WriteLine("Podaj h");
                    double aoh = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Objętość  = {0.33 * PPostro(ao, bo) * aoh}");
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("default...");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("[P]ola czy [O]bjętości?");
            var decision = Console.ReadLine();
            if (decision == "P" || decision == "p")
            {
                RysujMenuPola();
                int switchnumarea = int.Parse(Console.ReadLine());
                SwitchMenuArea(switchnumarea);
            }

            else
            {
                RysujMenuObjetosci();
                int switchnumvol = int.Parse(Console.ReadLine());
                SwitchMenuVolumes(switchnumvol);

            }
            


        }
    }
}
