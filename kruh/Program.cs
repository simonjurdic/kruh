using System;

namespace kruh
{
    class Program
    {
        static void Main(string[] args)

        {
            double vstup;
            double obsah;
            int volba;

            Console.WriteLine("1 - výpočet s poloměrem");
            Console.WriteLine("2 - výpočet s průměrem");
            volba = int.Parse(Console.ReadLine());

            if (volba == 1)
            {    

                

                Console.WriteLine("zadejte poleměr");
                vstup = double.Parse(Console.ReadLine());
                if (vstup <= 0)
                {
                    Console.WriteLine("zadejte jiné číslo");
                    vstup = double.Parse(Console.ReadLine());
                }
                obsah = 3.14 * (vstup * vstup);
                obsah = Math.Round(obsah, 1);
                Console.WriteLine(obsah);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("zadejte průměr");
            }
            if (volba == 2)
            {
                vstup = double.Parse(Console.ReadLine());
                if (vstup <= 0)
                {
                    Console.WriteLine("zadejte jiné číslo");
                    vstup = double.Parse(Console.ReadLine());
                }
                vstup = vstup / 2;
                obsah = 3.14 * (vstup * vstup);
                obsah = Math.Round(obsah, 1);
                Console.WriteLine(obsah);
                Console.WriteLine();
                
            }


            
            
            



        }
    }
}
