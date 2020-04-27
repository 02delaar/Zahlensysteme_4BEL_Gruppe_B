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

            int Eingangszahl = 0;
            int DecZahl = 0;
            int merkeDec = 0;
            int basis = 1;

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

                strEingabe = EingabeBinaerZahl();



                switch (EingabeMenu)
                {
                    case 1:

                        Eingangszahl = int.Parse(strEingabe);

                        while (Eingangszahl > 0)
                        {
                            merkeDec = Eingangszahl % 10;
                            Eingangszahl = Eingangszahl / 10;
                            DecZahl += merkeDec * basis;
                            basis = basis * 2;
                        }

                        Console.WriteLine("---------------------------------------------------------");
                        Console.WriteLine("Der Dezimalwert ist {0} ", DecZahl);
                        Console.WriteLine("---------------------------------------------------------");
                        break;

                    case 2:
                        //Methode von Gufi
                        break;

                }
            }
            Console.ReadKey();

        }

        static String EingabeBinaerZahl()
        {
            bool EingabeRichtig;
            String BinaerZahl;

            do
            {
                EingabeRichtig = true;


                char[] KontrolleBinaerZahl;


                Console.Write("Geben Sie eine Binärzahl ein = ");
                BinaerZahl = Console.ReadLine();
                KontrolleBinaerZahl = BinaerZahl.ToCharArray();

                for (int i = 0; i < BinaerZahl.Length; i++)
                {
                    if (KontrolleBinaerZahl[i] == '0' || KontrolleBinaerZahl[i] == '1') { }

                    else
                        EingabeRichtig = false;
                }

            } while (!EingabeRichtig);



            return BinaerZahl;

        }
    }
}
