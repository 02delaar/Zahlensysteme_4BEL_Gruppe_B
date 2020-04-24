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
            int EingabeMenu = 0;
            string strEingabe = "";
            string strAusgabe = "";

            while (EingabeMenu != 3)
            {
                Console.WriteLine("Wilkommen im Menü!\n");
                Console.WriteLine("Wählen sie mit der daneben angegebenen Zahl das Programm:\n");
                Console.WriteLine("1.   Umrechnen in Basis 10!");
                Console.WriteLine("2.   Umrechnung in Basis 16!");
                Console.WriteLine("3.   Ende\n");
                Console.Write("Nummer der Berechnung: ");

                while (!Int32.TryParse(Console.ReadLine(), out EingabeMenu) || EingabeMenu < 1 || EingabeMenu > 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("FEHLER. Bitte wählen sie eine der 3 Varianten aus!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------------------------------------------");
                Console.WriteLine();

                //Metode von Isaak:



                switch (EingabeMenu)
                {
                    case 1:
                        //Methode von Gabbo
                        break;

                    case 2:
                        //Methode von Gufi
                        break;

                }
            }
            Console.ReadKey();

        }
    }
}
