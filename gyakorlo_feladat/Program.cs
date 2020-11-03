using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace gyakorlo_feladat
{
    class Program
    {
        static List<double> ertekek = new List<double>();
        static double atlag = 0;
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

            // Fourth task
            Negyedik_feladat();

            // Fifth task
            Otodik_feladat();

            // Sixth task
            Hatodik_feladat();
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

            for (int i = 0; ertekek.Count(); i++)
            {
                if (min > ertekek[i])
                {
                    min = ertekek[i];
                }
                if (max < ertekek[i])
                {
                    max = ertekek[i];
                }
            }

            Console.WriteLine("Legkisebb szám: " + min + "\nLegnagyobb szám: " + max + "\n");
        }

        // Displaying the dataset's values average
        static void Otodik_feladat()
        {
            double ossz = 0;

            for (int i = 0; ertekek.Count(); i++)
            {
                ossz += ertekek[i];
            }

            atlag = ossz / ertekek.Count();

            Console.WriteLine("Értékek átlaga: " + atlag + "\n");
        }

        // Displaying the values that are bigger than the average
        static void Hatodik_feladat()
        {
            int darab = 0;

            for (int i = 0; ertekek.Count(); i++)
            {
                if (ertekek[i] > atlag)
                {
                    darab++;
                }
            }

            Console.WriteLine("Átlag értéknél nagyobb számok darabszáma: " + darab);
        }
    }
}
