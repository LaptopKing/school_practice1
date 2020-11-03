using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace gyakorlo_feladat
{
    class Program
    {
        static List<double> ertekek = new List<double>();
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader("NO2.txt");
            string sor = "";
            while((sor = streamReader.ReadLine()) != null)
            {
                ertekek.Add(Convert.ToDouble(sor));
            }

            // Methods are after this line
            // First task
            Elso_feladat();

            // Second task
            Masodik_feladat();

            // Third task
            Harmadik_feladat();
        }

        // Displaying the values to command line with a line break after every fourth value
        static void Elso_feladat()
        {
            int szamol = -1;
            for (int i = 0; i < ertekek.Count(); i++)
            {
                if (szamol == 3)
                {
                    szamol = 0;
                    Console.WriteLine();
                    Console.WriteLine(ertekek[i]);
                }
                else
                {
                    Console.WriteLine(ertekek[i]);
                    szamol++;
                }
            }
        }

        // Deciding if there is at least one number that is bigger than one hundred
        static void Masodik_feladat()
        {
            Console.WriteLine();
            bool igaz_hamis = false;
            for (int i = 0; i < ertekek.Count(); i++)
            {
                if (ertekek[i] > 100)
                {
                    igaz_hamis = true;
                }
                else
                {
                    igaz_hamis = false;
                }
            }
            if (igaz_hamis = true)
            {
                Console.WriteLine("Van 100 feletti mérési érték!\n");
            }
            else 
            {
                Console.WriteLine("Nincs 100 feletti mérési érték!\n");
            }
        }

        // Displaying how many value is bigger that 50
        static void Harmadik_feladat()
        {
            int ertek_50 = 0;
            for (int i = 0; i < ertekek.Count(); i++)
            {
                if (ertekek[i] > 50)
                {
                    ertek_50++;
                }
            }
            Console.WriteLine("Összesen " + ertek_50 + " darab 50 feletti mérési érték van!\n");
        }
        // Displaying the lowest and the largest number in the dataset
        static void Negyedik_feladat()
        {
            int min = ertekek[0];
            int max = ertekek[0];

            for (int i = 0; )
        }
    }
}
