using System;
using System.Collections;
using System.Collections.Generic;

namespace Class_and_Object_creation
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1testing klasse1;
            List<Class1testing> lijst = new List<Class1testing>();
            int antwoord = 0;
            do
            {
                antwoord = menu();


                if (antwoord == 1)
                {
                    klasse1 = new Class1testing();
                    lijst.Add(toevoegen(klasse1));
                }

                if (antwoord == 2)
                {
                    print(lijst);
                }
            } while (antwoord > 0);
        }

        private static void print(List<Class1testing> lijst)
        {
            int teller = 1;
            foreach (Class1testing auto in lijst)
            {

                Console.WriteLine($"De kleur van de auto {teller} is {auto.Color}");
                Console.WriteLine($"De nummerplaat van de auto {teller} is {auto.Plate}");
                Console.WriteLine($"Het merk van de auto {teller} is {auto.Brand}");
                Console.WriteLine();
                teller++;
                Console.ReadLine();
            }
        }

        private static Class1testing toevoegen(Class1testing klasse1)
        {

            Console.WriteLine("Wat is de kleur van de auto?");
            klasse1.Color = Console.ReadLine();
            Console.WriteLine("Wat is de nummerplaat van de auto?");
            klasse1.Plate = Console.ReadLine();
            Console.WriteLine("Wat is het merk van de auto?");
            klasse1.Brand = Console.ReadLine();
            return (klasse1);
        }

        private static int menu()
        {
            Console.Clear();
            int antwoord = 0;
            Console.WriteLine("(1) Auto toevoegen");
            Console.WriteLine("(2) Auto's weergeven");
            Console.WriteLine("(0) menu sluiten");
            antwoord = Convert.ToInt32(Console.ReadLine());
            return antwoord;
        }
    }
}
