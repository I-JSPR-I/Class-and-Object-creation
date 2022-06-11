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
            int antwoord;
            do
            {
                Console.WriteLine("(1) Auto toevoegen");
                Console.WriteLine("(2) Auto's weergeven");
                Console.WriteLine("(0) menu sluiten");
                antwoord = Convert.ToInt32(Console.ReadLine());

                if (antwoord == 1)
                {
                    klasse1 = new Class1testing();
                    Console.WriteLine("Wat is de kleur van de auto?");
                    klasse1.Color = Console.ReadLine();
                    Console.WriteLine("Wat is de nummerplaat van de auto?");
                    klasse1.Plate = Console.ReadLine();
                    Console.WriteLine("Wat is het merk van de auto?");
                    klasse1.Brand = Console.ReadLine();
                    lijst.Add(klasse1);
                }

                if (antwoord == 2)
                {
                    int teller = 1;
                    foreach (Class1testing auto in lijst)
                    {
                        Console.WriteLine($"De kleur van de auto {teller} is {auto.Color}");
                        Console.WriteLine($"De nummerplaat van de auto {teller} is {auto.Plate}");
                        Console.WriteLine($"Het merk van de auto {teller} is {auto.Brand}");
                        Console.WriteLine();
                        teller++;
                    }

                }
            } while (antwoord > 0);
        }
    }
}
