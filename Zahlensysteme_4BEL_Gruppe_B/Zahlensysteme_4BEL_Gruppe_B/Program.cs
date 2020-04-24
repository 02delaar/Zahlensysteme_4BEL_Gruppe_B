using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Zahlensysteme_4BEL_Gruppe_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int Eingabe = 0;

            while (Eingabe != 9)
            {
                Console.WriteLine("Wilkommen im Menü!\n");
                Console.WriteLine("Wählen sie mit der daneben angegebenen Zahl das Programm:\n");
                Console.WriteLine("1.   Umrechnen in Basis 10!");
                Console.WriteLine("2.   Umrechnung in Basis 16!");
                Console.WriteLine("3.   Ende\n");
                Console.Write("Nummer der Berechnung: ");

                while (!Int32.TryParse(Console.ReadLine(), out Eingabe) || Eingabe < 1 || Eingabe > 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("FEHLER. Bitte wählen sie eine der 7 Varianten aus!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            Console.ReadKey();

        }
    }
}
