using System;

namespace HemligtTalDel3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomerare = new Random();
            int slump_tal = randomerare.Next(1,101);
            int gissa_tal = 0;
            bool vinst = false;

            do 
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\n Skriva in ditt gissa talet från 1 till 100: ");
                    gissa_tal = Convert.ToInt32(Console.ReadLine());

                    if (gissa_tal > slump_tal)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Det är högre ! gissa lägre talet...");
                    }
                    else if (gissa_tal < slump_tal)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Det är lägre ! gissa högre talet...");
                    }
                    else if (gissa_tal == slump_tal)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Du vinner !!!");
                        vinst = true;
                    }
                }
                catch (FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(e.Message);
                }

            } while (vinst == false);

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("\nSkriva valfri tangent för att fortsätta ... ");
            Console.ReadKey();
        }
    }
}
